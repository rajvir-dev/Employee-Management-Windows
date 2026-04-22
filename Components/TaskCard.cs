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
            if (priorityLower == "high") lblPriority.ForeColor = Color.FromArgb(214, 48, 49);
            else if (priorityLower == "medium") lblPriority.ForeColor = Color.FromArgb(253, 150, 68);
            else lblPriority.ForeColor = Color.FromArgb(0, 184, 148);

            // Status Badge
            badgeStatus.Text = _task.Status ?? "Pending";
            badgeStatus.BadgeColor = GetStatusColor(_task.StatusId ?? 0);
        }

        private Color GetStatusColor(int statusId)
        {
            switch (statusId)
            {
                case 1: return ThemeColors.TextSecondary; // Pending
                case 2: return ThemeColors.Warning;       // In Progress
                case 3: return ThemeColors.Success;       // Completed
                default: return ThemeColors.Primary;
            }
        }

        private void cardBase_Click(object sender, EventArgs e)
        {
            OnTaskClicked?.Invoke(_task);
        }
    }
}
