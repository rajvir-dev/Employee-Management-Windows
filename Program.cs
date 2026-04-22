using System;
using System.Windows.Forms;
using EmployeeManagement_Windows.Core;
using EmployeeManagement_Windows.Forms;

namespace EmployeeManagement_Windows
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Initialize API Client
            ApiClient.Initialize("https://localhost:44325");

            // Check if user is already logged in via persisted session
            if (SessionManager.IsLoggedIn)
            {
                // Start real-time notifications
                _ = SignalRService.Instance.StartAsync(); 
                
                Application.Run(new MainDashboard());
            }
            else
            {
                using (var login = new LoginForm())
                {
                    if (login.ShowDialog() == DialogResult.OK)
                    {
                        Application.Run(new MainDashboard());
                    }
                }
            }
        }
    }
}
