namespace EmployeeManagement_Windows.Models
{
    public class LoginResponse
    {
        public string Token { get; set; } = string.Empty;
        public string EmployeeId { get; set; } = string.Empty;
        public string FullName { get; set; } = string.Empty;
        public int EmployeeType { get; set; }
    }
}
