using System;

namespace EmployeeManagement_Windows.Models
{
    public class AssignToDto
    {
        public long EmployeeId { get; set; }
        public long TaskId { get; set; }
        public string FullName { get; set; }
        public string PhotoPath { get; set; }
        public string PhotoBase64 { get; set; }
    }
}
