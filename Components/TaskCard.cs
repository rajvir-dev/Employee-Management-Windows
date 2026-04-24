using System;
using System.Drawing;
using System.Windows.Forms;
using EmployeeManagement_Windows.Models;
using EmployeeManagement_Windows.Helpers;
using EmployeeManagement_Windows.Controls;

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
            lblDescription.Text = _task.Description ?? "No description provided.";
            
            lblStartDate.Text = _task.CreatedDate?.ToString("dd MMM, yyyy") ?? "01 Jan, 1900";
            lblDueDate.Text = _task.DueDate?.ToString("dd MMM, yyyy") ?? "N/A";

            // Priority Color Logic for Accent Bar
            string priority = (_task.Priority ?? "Normal").ToLower();
            if (priority == "high") pnlAccent.BackColor = ThemeColors.Danger;
            else if (priority == "medium") pnlAccent.BackColor = ThemeColors.Warning;
            else pnlAccent.BackColor = ThemeColors.Primary;

            // Status Badge Logic
            string statusText = "ASSIGNED";
            if (_task.StatusId == 2) statusText = "IN PROGRESS";
            else if (_task.StatusId == 3) statusText = "COMPLETED";
            
            badgeStatus.Text = statusText;
            badgeStatus.SetTheme(GetStatusTheme(_task.StatusId ?? 1));

            RenderAvatars();
        }

        private void RenderAvatars()
        {
            pnlAvatars.Controls.Clear();
            if (_task.AssignedEmployees == null || _task.AssignedEmployees.Count == 0) return;

            int maxAvatars = 3;
            int count = 0;
            int offset = 16; // Amount of overlap

            foreach (var emp in _task.AssignedEmployees)
            {
                if (count >= maxAvatars) break;

                var avatar = new AvatarCircle();
                avatar.Size = new Size(24, 24);
                avatar.Location = new Point(count * offset, 3);
                
                if (!string.IsNullOrEmpty(emp.PhotoBase64))
                {
                    avatar.SetImageFromBase64(emp.PhotoBase64);
                }

                pnlAvatars.Controls.Add(avatar);
                avatar.BringToFront();
                count++;
            }

            if (_task.AssignedEmployees.Count > maxAvatars)
            {
                Label lblMore = new Label();
                lblMore.AutoSize = false;
                lblMore.Size = new Size(24, 24);
                lblMore.BackColor = Color.FromArgb(243, 244, 246);
                lblMore.ForeColor = Color.FromArgb(107, 114, 128);
                lblMore.Font = new Font("Segoe UI", 7.5F, FontStyle.Bold);
                lblMore.Text = "+" + (_task.AssignedEmployees.Count - maxAvatars);
                lblMore.TextAlign = ContentAlignment.MiddleCenter;
                lblMore.Location = new Point(count * offset, 3);
                
                // Make it circular
                System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
                path.AddEllipse(0, 0, 24, 24);
                lblMore.Region = new Region(path);

                pnlAvatars.Controls.Add(lblMore);
                lblMore.BringToFront();
            }
        }

        private (Color bg, Color text) GetStatusTheme(int statusId)
        {
            switch (statusId)
            {
                case 1: return ThemeColors.StatusBadgeColors.Assigned;   // Assigned (Blue)
                case 2: return ThemeColors.StatusBadgeColors.InProgress; // In Progress (Amber)
                case 3: return ThemeColors.StatusBadgeColors.Approved;   // Completed (Green)
                default: return ThemeColors.StatusBadgeColors.Assigned;
            }
        }

        private void cardBase_Click(object sender, EventArgs e)
        {
            OnTaskClicked?.Invoke(_task);
        }
    }
}
