using System;
using System.Drawing;
using System.Windows.Forms;
using EmployeeManagement_Windows.Helpers;
using EmployeeManagement_Windows.Models;
using EmployeeManagement_Windows.Forms;
using EmployeeManagement_Windows.Core;
using EmployeeManagement_Windows.Services;

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
            lblEmployeeName.Text = string.IsNullOrEmpty(_leave.FullName) ? SessionManager.FullName : _leave.FullName;
            lblEmployeeEmail.Text = string.IsNullOrEmpty(_leave.EmailId) ? "No email provided" : _leave.EmailId;
            lblEmployeePhone.Text = string.IsNullOrEmpty(_leave.MobileNumber) ? "No phone provided" : _leave.MobileNumber;
            
            lblReason.Text = $"Description: {(string.IsNullOrEmpty(_leave.Description) ? "No reason provided." : _leave.Description)}";
            lblDates.Text = _leave.LeaveDate.ToString("dd MMM yyyy");
            lblRequestedOn.Text = _leave.CreatedDate?.ToString("dd MMM yyyy") ?? "N/A";

            if (!string.IsNullOrEmpty(_leave.PhotoBase64))
            {
                avatar.SetImageFromBase64(_leave.PhotoBase64);
            }

            // Status Logic (0 = Pending, 1 = Approved, 2 = Rejected)
            bool isPending = _leave.IsApproved == 0;
            btnEdit.Visible = isPending;
            btnDelete.Visible = isPending;

            switch (_leave.IsApproved)
            {
                case 1:
                    badgeStatus.Text = "APPROVED";
                    badgeStatus.SetTheme(ThemeColors.StatusBadgeColors.Approved);
                    break;
                case 2:
                    badgeStatus.Text = "REJECTED";
                    badgeStatus.SetTheme(ThemeColors.StatusBadgeColors.Rejected);
                    break;
                default:
                    badgeStatus.Text = "PENDING";
                    badgeStatus.SetTheme(ThemeColors.StatusBadgeColors.Pending);
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

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to delete this leave request?", 
                "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    var response = await LeaveService.DeleteLeaveAsync(_leave.LeaveId);
                    if (response.Success)
                    {
                        OnLeaveUpdated?.Invoke();
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete: " + response.Message);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}
