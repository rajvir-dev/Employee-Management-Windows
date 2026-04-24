using System;
using System.Drawing;
using System.Windows.Forms;
using EmployeeManagement_Windows.Models;
using EmployeeManagement_Windows.Helpers;
using EmployeeManagement_Windows.Core;
using EmployeeManagement_Windows.Services;

namespace EmployeeManagement_Windows.Components
{
    public partial class MeetingCard : UserControl
    {
        private CommentDto _meeting;
        public event Action MeetingChanged;

        public MeetingCard(CommentDto meeting)
        {
            InitializeComponent();
            _meeting = meeting;
            LoadData();
        }

        private void LoadData()
        {
            lblTitle.Text = _meeting.MeetingTitle ?? "General Meeting";
            lblDate.Text = _meeting.MeetingDateTime.HasValue ? _meeting.MeetingDateTime.Value.ToString("MMMM dd, yyyy") : "TBD";
            lblTime.Text = _meeting.MeetingDateTime.HasValue ? _meeting.MeetingDateTime.Value.ToString("hh:mm tt") : "TBD";
            
            // Status Badge
            string status = !string.IsNullOrWhiteSpace(_meeting.StatusText) ? _meeting.StatusText : "Scheduled";
            badgeStatus.Text = status;
            
            // Theme Logic based on StatusId
            if (_meeting.StatusId == 21) // Scheduled
                badgeStatus.SetTheme(ThemeColors.StatusBadgeColors.Scheduled);
            else if (_meeting.StatusId == 23) // Concluded
                badgeStatus.SetTheme(ThemeColors.StatusBadgeColors.Concluded);
            else if (_meeting.StatusId == 24) // Cancelled
                badgeStatus.SetTheme(ThemeColors.StatusBadgeColors.Cancelled);
            else
                badgeStatus.SetTheme(ThemeColors.StatusBadgeColors.Scheduled);

            // Button Visibility Logic based on StatusId
            bool isScheduled = _meeting.StatusId == 21 || _meeting.StatusId == 25; // 25 = Rescheduled
            bool isOther = _meeting.StatusId == 22 || _meeting.StatusId == 23 || _meeting.StatusId == 24; // Ongoing, Concluded, Cancelled

            if (isScheduled)
            {
                btnEdit.Visible = true;
                btnCancel.Visible = true;
                btnDelete.Visible = false;
            }
            else if (isOther)
            {
                btnEdit.Visible = false;
                btnCancel.Visible = false;
                btnDelete.Visible = true;
            }
            else
            {
                btnEdit.Visible = false;
                btnCancel.Visible = false;
                btnDelete.Visible = false;
            }

            btnEdit.BringToFront();
            btnCancel.BringToFront();
            btnDelete.BringToFront();

            // Participants Avatars
            flowParticipants.Controls.Clear();
            ToolTip tt = new ToolTip();
            
            if (_meeting.AssignedEmployees != null && _meeting.AssignedEmployees.Count > 0)
            {
                foreach (var emp in _meeting.AssignedEmployees)
                {
                    var av = new EmployeeManagement_Windows.Controls.AvatarCircle
                    {
                        Size = new Size(28, 28),
                        Margin = new Padding(0, 0, 4, 0)
                    };
                    
                    if (!string.IsNullOrEmpty(emp.PhotoBase64))
                    {
                        av.SetImageFromBase64(emp.PhotoBase64);
                    }
                    
                    tt.SetToolTip(av, emp.FullName ?? "Unknown");
                    flowParticipants.Controls.Add(av);
                }
            }
            else
            {
                // Fallback: Show current user if no assignments found
                var av = new EmployeeManagement_Windows.Controls.AvatarCircle
                {
                    Size = new Size(28, 28),
                    Margin = new Padding(0, 0, 4, 0)
                };
                if (!string.IsNullOrEmpty(SessionManager.PhotoBase64))
                {
                    av.SetImageFromBase64(SessionManager.PhotoBase64);
                }
                tt.SetToolTip(av, "Me (Organizer)");
                flowParticipants.Controls.Add(av);
            }

            // Wire up events
            btnEdit.Click += btnEdit_Click;
            btnCancel.Click += btnCancel_Click;
            btnDelete.Click += btnDelete_Click;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            using (var form = new Forms.ScheduleMeetingForm(_meeting))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    MeetingChanged?.Invoke();
                }
            }
        }

        private async void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to cancel this meeting?", "Confirm Cancel", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var result = await TaskService.CancelMeetingAsync(_meeting.EncryptedId);
                if (result.Success)
                {
                    MessageBox.Show("Meeting cancelled successfully.");
                    MeetingChanged?.Invoke();
                }
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this meeting record?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var result = await TaskService.DeleteMeetingAsync(_meeting.EncryptedId);
                if (result.Success)
                {
                    MessageBox.Show("Meeting record deleted.");
                    MeetingChanged?.Invoke();
                }
            }
        }
    }
}
