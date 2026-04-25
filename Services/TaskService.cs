using System.Collections.Generic;
using System.Threading.Tasks;
using EmployeeManagement_Windows.Core;
using EmployeeManagement_Windows.Models;

namespace EmployeeManagement_Windows.Services
{
    public static class TaskService
    {
        /// <summary>
        /// Gets all tasks assigned to the current employee.
        /// </summary>
        public static async Task<List<TaskDto>> GetMyTasksAsync()
        {
            return await ApiClient.GetAsync<List<TaskDto>>("api/task");
        }

        /// <summary>
        /// Gets a single task by its encrypted ID.
        /// </summary>
        public static async Task<TaskDto> GetTaskByIdAsync(string encryptedId)
        {
            return await ApiClient.GetAsync<TaskDto>($"api/task/{encryptedId}");
        }

        /// <summary>
        /// Updates the status of a task.
        /// Status values: 1 = Pending, 2 = In Progress, 3 = Completed
        /// </summary>
        public static async Task<ApiResponse> UpdateStatusAsync(string encryptedId, int statusId)
        {
            return await ApiClient.PutAsync($"api/task/{encryptedId}/status", statusId);
        }

        /// <summary>
        /// Gets comments for a specific task.
        /// </summary>
        public static async Task<List<CommentDto>> GetCommentsAsync(string encryptedId)
        {
            return await ApiClient.GetAsync<List<CommentDto>>($"api/task/{encryptedId}/comments");
        }

        /// <summary>
        /// Adds a comment / logs time on a task.
        /// </summary>
        public static async Task<ApiResponse> AddCommentAsync(string encryptedId, CommentRequest comment)
        {
            return await ApiClient.PostAsync($"api/task/{encryptedId}/comments", comment);
        }

        /// <summary>
        /// Schedules a meeting for a task.
        /// </summary>
        public static async Task<ApiResponse> ScheduleMeetingAsync(string encryptedId, MeetingRequest meeting)
        {
            return await ApiClient.PostAsync($"api/task/{encryptedId}/meetings", meeting);
        }

        /// <summary>
        /// Gets all meetings for the current employee.
        /// </summary>
        public static async Task<List<CommentDto>> GetMyMeetingsAsync()
        {
            return await ApiClient.GetAsync<List<CommentDto>>("api/task/meetings");
        }

        /// <summary>
        /// Cancels a meeting.
        /// </summary>
        public static async Task<ApiResponse> CancelMeetingAsync(string encryptedMeetingId)
        {
            return await ApiClient.PostAsync($"api/task/meetings/{encryptedMeetingId}", null);
        }

        /// <summary>
        /// Deletes a meeting.
        /// </summary>
        public static async Task<ApiResponse> DeleteMeetingAsync(string encryptedMeetingId)
        {
            return await ApiClient.DeleteAsync($"api/task/meetings/{encryptedMeetingId}");
        }

        /// <summary>
        /// Updates an existing meeting.
        /// </summary>
        public static async Task<ApiResponse> UpdateMeetingAsync(string encryptedMeetingId, object meetingData)
        {
            return await ApiClient.PutAsync($"api/task/meetings/{encryptedMeetingId}", meetingData);
        }

        /// <summary>
        /// Deletes a comment.
        /// </summary>
        public static async Task<ApiResponse> DeleteCommentAsync(long commentId)
        {
            return await ApiClient.DeleteAsync($"api/task/comments/{commentId}");
        }
    }
}
