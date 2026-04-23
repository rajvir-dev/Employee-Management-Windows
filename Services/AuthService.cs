using System.Threading.Tasks;
using EmployeeManagement_Windows.Core;
using EmployeeManagement_Windows.Models;

namespace EmployeeManagement_Windows.Services
{
    public static class AuthService
    {
        /// <summary>
        /// Authenticates with the API and stores session data on success.
        /// </summary>
        public static async Task<LoginResponse> LoginAsync(string email, string password)
        {
            var request = new LoginRequest { Email = email, Password = password };
            var response = await ApiClient.PostAsync<LoginResponse>("api/auth/login", request);

            // Store session
            SessionManager.SetSession(
                response.Token,
                response.EmployeeId,
                response.FullName,
                response.EmployeeType);

            // Fetch full profile to get the photo
            try
            {
                var profile = await EmployeeService.GetProfileAsync();
                if (profile != null && !string.IsNullOrEmpty(profile.PhotoBase64))
                {
                    SessionManager.PhotoBase64 = profile.PhotoBase64;
                    SessionManager.SaveSession();
                }
            }
            catch { /* Ignore profile fetch errors during login */ }

            return response;
        }

        /// <summary>
        /// Logs out by calling the API and clearing local session data.
        /// </summary>
        public static async Task LogoutAsync()
        {
            try
            {
                await ApiClient.PostAsync("api/auth/logout", new { });
            }
            finally
            {
                SessionManager.Clear();
            }
        }
    }
}
