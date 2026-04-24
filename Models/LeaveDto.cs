using System;

namespace EmployeeManagement_Windows.Models
{
    /// <summary>
    /// Request body for POST /api/leave.
    /// </summary>
    public class LeaveRequestDto
    {
        public long? LeaveId { get; set; }
        public string Description { get; set; } = string.Empty;
        public DateTime LeaveDate { get; set; }
        public DateTime LeaveEndDate { get; set; }
        public int LeaveType { get; set; }
    }

    /// <summary>
    /// Response model for GET /api/leave (leave list items).
    /// Matches the LeaveMaster entity returned from the API.
    /// </summary>
    public class LeaveDto
    {
        public long LeaveId { get; set; }
        public string Description { get; set; } = string.Empty;
        public DateTime LeaveDate { get; set; }
        public DateTime LeaveEndDate { get; set; }
        public long EmployeeId { get; set; }
        /// <summary>
        /// 0 = Pending, 1 = Approved, 2 = Rejected
        /// </summary>
        public int IsApproved { get; set; }
        public string Remarks { get; set; } = string.Empty;
        public DateTime? CreatedDate { get; set; }
        public int LeaveType { get; set; }

        public string FullName { get; set; } = string.Empty;
        public string EmailId { get; set; } = string.Empty;
        public string MobileNumber { get; set; } = string.Empty;
        public string PhotoPath { get; set; } = string.Empty;
        public string PhotoBase64 { get; set; } = string.Empty;

        public string StatusText
        {
            get
            {
                switch (IsApproved)
                {
                    case 0: return "Pending";
                    case 1: return "Approved";
                    case 2: return "Rejected";
                    default: return "Unknown";
                }
            }
        }

        public string LeaveTypeName
        {
            get
            {
                switch (LeaveType)
                {
                    case 0: return "Vacation";
                    case 1: return "Sick";
                    case 2: return "Other";
                    default: return "Other";
                }
            }
        }
    }
}
