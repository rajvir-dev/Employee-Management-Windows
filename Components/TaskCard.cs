using System;
using System.Drawing;
using System.Windows.Forms;
using EmployeeManagement_Windows.Models;
using EmployeeManagement_Windows.Helpers;

namespace EmployeeManagement_Windows.Components
{
    public partial class TaskCard : UserControl
    {
        private TaskDto _task;
        public event Action<TaskDto> OnTaskClicked;

        public TaskCard(TaskDto task)
        {
            InitializeComponent();
            _task = task;
            PopulateData();
        }

        private void PopulateData()
        {
            lblTitle.Text = _task.Title ?? "Untitled Task";
            
            // Null-safe Priority
            string priority = _task.Priority ?? "Normal";
            lblPriority.Text = priority.ToUpper();
            
            lblDueDate.Text = "Due: " + (_task.DueDate?.ToString("MMM dd") ?? "N/A");
            
            // Priority Color Logic
            string priorityLower = priority.ToLower();
            if (priorityLower == "high") lblPriority.ForeColor = ThemeColors.Danger;
            else if (priorityLower == "medium") lblPriority.ForeColor = ThemeColors.Warning;
            else lblPriority.ForeColor = ThemeColors.Success;

            // Status Badge
            string status = _task.Status ?? "Pending";
            if (_task.StatusId == 3) status = "Completed";
            else if (_task.StatusId == 2) status = "In Progress";
            else if (_task.StatusId == 1) status = "To Do";

            badgeStatus.Text = status;
            badgeStatus.SetTheme(GetStatusTheme(_task.StatusId ?? 0));
        }

        private (Color bg, Color text) GetStatusTheme(int statusId)
        {
            switch (statusId)
            {
                case 1: return ThemeColors.StatusBadgeColors.Pending;    // To Do
                case 2: return ThemeColors.StatusBadgeColors.InProgress; // In Progress
                case 3: return ThemeColors.StatusBadgeColors.Approved;   // Completed
                default: return ThemeColors.StatusBadgeColors.Pending;
            }
        }

        private void cardBase_Click(object sender, EventArgs e)
        {
            OnTaskClicked?.Invoke(_task);
        }
    }
}
