using System.Collections.Generic;
using System.Threading.Tasks;
using EmployeeManagement_Windows.Core;
using EmployeeManagement_Windows.Models;

namespace EmployeeManagement_Windows.Services
{
    public static class NotificationService
    {
        /// <summary>
        /// Gets all notifications for the current employee.
        /// </summary>
        public static async Task<List<NotificationDto>> GetNotificationsAsync()
        {
            return await ApiClient.GetAsync<List<NotificationDto>>("api/notification");
        }

        /// <summary>
        /// Marks a notification as read.
        /// </summary>
        public static async Task<ApiResponse> MarkAsReadAsync(string encryptedId)
        {
            return await ApiClient.PostAsync($"api/notification/{encryptedId}/read", new { });
        }
    }
}
