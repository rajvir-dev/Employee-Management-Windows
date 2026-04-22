using System;
using System.Threading.Tasks;
using Microsoft.AspNet.SignalR.Client;
using EmployeeManagement_Windows.Core;

namespace EmployeeManagement_Windows.Core
{
    /// <summary>
    /// Manages the real-time SignalR connection for notifications.
    /// Uses the HubConnection from Microsoft.AspNet.SignalR.Client.
    /// </summary>
    public class SignalRService
    {
        private static SignalRService _instance;
        public static SignalRService Instance => _instance ?? (_instance = new SignalRService());

        private HubConnection _connection;
        private IHubProxy _notificationHub;

        public event Action<string, string> OnNotificationReceived;
        public event Action<string> OnConnectionStatusChanged;

        private SignalRService() { }

        /// <summary>
        /// Starts the SignalR connection using the current JWT token.
        /// </summary>
        public async Task StartAsync()
        {
            if (_connection != null) return;

            // Initialize connection. Standard ASP.NET SignalR expects the hub at /signalr
            string signalrUrl = ApiClient.BaseUrl.TrimEnd('/') + "/signalr";
            _connection = new HubConnection(signalrUrl);
            
            // Attach the JWT token for authentication
            if (SessionManager.IsLoggedIn)
            {
                _connection.Headers.Add("Authorization", "Bearer " + SessionManager.Token);
            }
            
            _notificationHub = _connection.CreateHubProxy("NotificationHub");

            // Listen for 'ReceiveNotification' calls from the server
            _notificationHub.On<string, string>("ReceiveNotification", (title, message) =>
            {
                OnNotificationReceived?.Invoke(title, message);
            });

            _connection.StateChanged += (change) =>
            {
                string status = "Disconnected";
                switch (change.NewState)
                {
                    case ConnectionState.Connected: status = "Live"; break;
                    case ConnectionState.Connecting: status = "Connecting..."; break;
                    case ConnectionState.Reconnecting: status = "Reconnecting..."; break;
                }
                OnConnectionStatusChanged?.Invoke(status);
            };

            try
            {
                await _connection.Start();
            }
            catch (Exception ex)
            {
                // Log technical error to console, but keep UI clean
                System.Diagnostics.Debug.WriteLine("SignalR Error: " + ex.Message);
                OnConnectionStatusChanged?.Invoke("Offline");
            }
        }

        public void Stop()
        {
            _connection?.Stop();
            _connection = null;
        }
    }
}
