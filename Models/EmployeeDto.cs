using System;

namespace EmployeeManagement_Windows.Models
{
    /// <summary>
    /// Matches the anonymous object returned by GET /api/employee/me.
    /// </summary>
    public class EmployeeDto
    {
        public string EmployeeId { get; set; } = string.Empty;
        public string FullName { get; set; } = string.Empty;
        public string Bio { get; set; } = string.Empty;
        public DateTime DateOfBirth { get; set; }
        public string Position { get; set; } = string.Empty;
        public string EmailId { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string MobileNumber { get; set; } = string.Empty;
        public int EmployeeType { get; set; }
        public string SalaryType { get; set; } = string.Empty;
        public string Amount { get; set; } = string.Empty;
        public string EmployeeTypeName { get; set; } = string.Empty;
        public string EmployeeTypeClass { get; set; } = string.Empty;
        public long CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string PhotoPath { get; set; } = string.Empty;
        public string OldPath { get; set; } = string.Empty;
        public string PhotoBase64 { get; set; } = string.Empty;
    }
}
