using System.Threading.Tasks;
using EmployeeManagement_Windows.Core;
using EmployeeManagement_Windows.Models;

namespace EmployeeManagement_Windows.Services
{
    public static class EmployeeService
    {
        /// <summary>
        /// Gets the current employee's profile.
        /// </summary>
        public static async Task<EmployeeDto> GetProfileAsync()
        {
            return await ApiClient.GetAsync<EmployeeDto>("api/employee/me");
        }

        /// <summary>
        /// Updates the current employee's profile.
        /// </summary>
        public static async Task<ApiResponse> UpdateProfileAsync(ProfileUpdateRequest profile)
        {
            return await ApiClient.PutAsync("api/employee/me", profile);
        }
    }
}
