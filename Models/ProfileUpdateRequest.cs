using System;

namespace EmployeeManagement_Windows.Models
{
    /// <summary>
    /// Matches the ProfileUpdateDto from the API. Used for PUT /api/employee/me.
    /// </summary>
    public class ProfileUpdateRequest
    {
        public string EmployeeId { get; set; }
        public string FullName { get; set; }
        public string Bio { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Position { get; set; }
        public string EmailId { get; set; }
        public string Address { get; set; }
        public string MobileNumber { get; set; }
        public string Password { get; set; }
        public int EmployeeType { get; set; }
        public string SalaryType { get; set; }
        public string Amount { get; set; }
        public string PhotoPath { get; set; }
        public string PhotoBase64 { get; set; }
    }
}
