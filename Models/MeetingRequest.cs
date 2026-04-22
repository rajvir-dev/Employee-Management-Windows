using System;

namespace EmployeeManagement_Windows.Models
{
    /// <summary>
    /// Request body for POST /api/task/{id}/meetings.
    /// </summary>
    public class MeetingRequest
    {
        public string MeetingTitle { get; set; } = string.Empty;
        public DateTime MeetingDateTime { get; set; }
        public string Description { get; set; } = string.Empty;
        public int? HoursWorked { get; set; }
        public int? MinutesWorked { get; set; }
    }
}
