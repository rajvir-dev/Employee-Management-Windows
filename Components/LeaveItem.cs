using System;
using System.Drawing;
using System.Windows.Forms;
using EmployeeManagement_Windows.Helpers;
using EmployeeManagement_Windows.Models;
using EmployeeManagement_Windows.Forms;

namespace EmployeeManagement_Windows.Components
{
    public partial class LeaveItem : UserControl
    {
        private LeaveDto _leave;
        public event Action OnLeaveUpdated;

        public LeaveItem(LeaveDto leave)
        {
            _leave = leave;
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            lblType.Text = _leave.LeaveTypeName;
            lblDates.Text = $"{_leave.LeaveDate:MMM dd} - {_leave.LeaveEndDate:MMM dd, yyyy}";
            lblReason.Text = string.IsNullOrEmpty(_leave.Description) ? "No reason provided." : _leave.Description;

            // Map Status (0 = Pending, 1 = Approved, 2 = Rejected)
            switch (_leave.IsApproved)
            {
                case 1:
                    badgeStatus.Text = "APPROVED";
                    badgeStatus.BadgeColor = ThemeColors.Success;
                    btnEdit.Visible = false;
                    break;
                case 2:
                    badgeStatus.Text = "REJECTED";
                    badgeStatus.BadgeColor = ThemeColors.Danger;
                    btnEdit.Visible = false;
                    break;
                default:
                    badgeStatus.Text = "PENDING";
                    badgeStatus.BadgeColor = ThemeColors.Warning;
                    btnEdit.Visible = true;
                    break;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            using (var form = new LeaveRequestForm(_leave))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    OnLeaveUpdated?.Invoke();
                }
            }
        }
    }
}
