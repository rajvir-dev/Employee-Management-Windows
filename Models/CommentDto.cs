using System;

namespace EmployeeManagement_Windows.Models
{
    /// <summary>
    /// Matches the CommentDto from the API. Returned by GET /api/task/{id}/comments.
    /// </summary>
    public class CommentDto
    {
        public long CommentId { get; set; }
        public string EncryptedId { get; set; } = string.Empty;
        public long TaskId { get; set; }
        public string EncryptedTaskId { get; set; } = string.Empty;
        public long EmployeeId { get; set; }
        public string AuthorName { get; set; } = string.Empty;
        public string CommentText { get; set; } = string.Empty;
        public int? HoursWorked { get; set; }
        public int? MinutesWorked { get; set; }
        public DateTime? CreatedDate { get; set; }
        public bool IsMeeting { get; set; }
        public string MeetingTitle { get; set; } = string.Empty;
        public DateTime? MeetingDateTime { get; set; }
        public string Status { get; set; } = string.Empty;
    }

    /// <summary>
    /// Request body for POST /api/task/{id}/comments.
    /// </summary>
    public class CommentRequest
    {
        public string CommentText { get; set; } = string.Empty;
        public int? HoursWorked { get; set; }
        public int? MinutesWorked { get; set; }
    }
}
