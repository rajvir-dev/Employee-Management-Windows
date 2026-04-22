using System;

namespace EmployeeManagement_Windows.Models
{
    /// <summary>
    /// Notification model returned by GET /api/notification.
    /// </summary>
    public class NotificationDto
    {
        public long NotificationId { get; set; }
        public string EncryptedId { get; set; } = string.Empty;
        public string Message { get; set; } = string.Empty;
        public bool IsRead { get; set; }
        public DateTime? CreatedDate { get; set; }

        public string TimeAgo
        {
            get
            {
                if (!CreatedDate.HasValue) return "";
                var span = DateTime.Now - CreatedDate.Value;
                if (span.TotalMinutes < 1) return "Just now";
                if (span.TotalMinutes < 60) return $"{(int)span.TotalMinutes}m ago";
                if (span.TotalHours < 24) return $"{(int)span.TotalHours}h ago";
                if (span.TotalDays < 30) return $"{(int)span.TotalDays}d ago";
                return CreatedDate.Value.ToString("MMM dd");
            }
        }
    }
}
