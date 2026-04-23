using System;
using System.Drawing;
using System.Windows.Forms;
using EmployeeManagement_Windows.Models;
using EmployeeManagement_Windows.Helpers;
using EmployeeManagement_Windows.Core;

namespace EmployeeManagement_Windows.Components
{
    public partial class MeetingCard : UserControl
    {
        private CommentDto _meeting;

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
            string status = _meeting.StatusText ?? "Scheduled";
            badgeStatus.Text = status;
            
            if (status.Equals("Sheduled", StringComparison.OrdinalIgnoreCase) || status.Equals("Scheduled", StringComparison.OrdinalIgnoreCase))
                badgeStatus.SetTheme(ThemeColors.StatusBadgeColors.Scheduled);
            else if (status.Equals("Concluded", StringComparison.OrdinalIgnoreCase))
                badgeStatus.SetTheme(ThemeColors.StatusBadgeColors.Concluded);
            else if (status.Equals("Cancelled", StringComparison.OrdinalIgnoreCase))
                badgeStatus.SetTheme(ThemeColors.StatusBadgeColors.Cancelled);
            else
                badgeStatus.SetTheme(ThemeColors.StatusBadgeColors.Scheduled);

            // User Avatar in card
            if (!string.IsNullOrEmpty(SessionManager.PhotoBase64))
            {
                avatar.SetImageFromBase64(SessionManager.PhotoBase64);
            }
        }
    }
}
