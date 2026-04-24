using System;

namespace EmployeeManagement_Windows.Models
{
    /// <summary>
    /// Matches the TaskDto from the API. Returned by GET /api/task.
    /// Note: EncryptedId is the string ID to use in API calls (e.g., PUT /api/task/{EncryptedId}/status).
    /// </summary>
    public class TaskDto
    {
        public long TaskId { get; set; }
        public string EncryptedId { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
        public int? StatusId { get; set; }
        public string Priority { get; set; } = string.Empty;
        public int? PriorityId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? DueDate { get; set; }
        public bool IsCompleted { get; set; }
        public string AssignedTo { get; set; } = string.Empty;
        public string ProjectName { get; set; } = string.Empty;
        public System.Collections.Generic.List<AssignToDto> AssignedEmployees { get; set; } = new System.Collections.Generic.List<AssignToDto>();
    }
}
