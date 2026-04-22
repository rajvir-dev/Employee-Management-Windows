using System.Collections.Generic;
using System.Threading.Tasks;
using EmployeeManagement_Windows.Core;
using EmployeeManagement_Windows.Models;

namespace EmployeeManagement_Windows.Services
{
    public static class LeaveService
    {
        /// <summary>
        /// Gets all leave requests for the current employee.
        /// </summary>
        public static async Task<List<LeaveDto>> GetMyLeavesAsync()
        {
            return await ApiClient.GetAsync<List<LeaveDto>>("api/leave");
        }

        /// <summary>
        /// Submits a new leave request.
        /// </summary>
        public static async Task<ApiResponse> RequestLeaveAsync(LeaveRequestDto request)
        {
            return await ApiClient.PostAsync("api/leave", request);
        }

        /// <summary>
        /// Updates an existing pending leave request.
        /// </summary>
        public static async Task<ApiResponse> UpdateLeaveAsync(LeaveRequestDto request)
        {
            // Assuming the API supports PUT for updates
            return await ApiClient.PutAsync($"api/leave/{request.LeaveId}", request);
        }

        /// <summary>
        /// Deletes a pending leave request.
        /// </summary>
        public static async Task<ApiResponse> DeleteLeaveAsync(long leaveId)
        {
            return await ApiClient.DeleteAsync($"api/leave/{leaveId}");
        }
    }
}
