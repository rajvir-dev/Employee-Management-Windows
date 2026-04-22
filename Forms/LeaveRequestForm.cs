using System;
using System.Drawing;
using System.Windows.Forms;
using EmployeeManagement_Windows.Helpers;
using EmployeeManagement_Windows.Models;
using EmployeeManagement_Windows.Services;
using EmployeeManagement_Windows.Core;

namespace EmployeeManagement_Windows.Forms
{
    public partial class LeaveRequestForm : Form
    {
        private LeaveDto _existingLeave;
        private bool _isEditMode => _existingLeave != null;

        public LeaveRequestForm()
        {
            InitializeComponent();
            SetupStyles();
        }

        public LeaveRequestForm(LeaveDto leave) : this()
        {
            _existingLeave = leave;
            PopulateData();
        }

        private void SetupStyles()
        {
            this.BackColor = ThemeColors.Background;
            lblHeader.ForeColor = ThemeColors.TextPrimary;
            
            btnSubmit.BackColor = ThemeColors.Primary;
            btnSubmit.ForeColor = Color.White;
            btnSubmit.FlatStyle = FlatStyle.Flat;
            btnSubmit.FlatAppearance.BorderSize = 0;
            
            btnCancel.BackColor = Color.Transparent;
            btnCancel.ForeColor = ThemeColors.TextSecondary;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.FlatAppearance.BorderSize = 0;
        }

        private void PopulateData()
        {
            if (_existingLeave == null) return;

            lblHeader.Text = "Edit Leave Request";
            btnSubmit.Text = "UPDATE REQUEST";
            txtReason.Text = _existingLeave.Description;
            dtpStart.Value = _existingLeave.LeaveDate;
            dtpEnd.Value = _existingLeave.LeaveEndDate;
        }

        private async void btnSubmit_Click(object sender, EventArgs e)
        {
            var request = new LeaveRequestDto
            {
                LeaveId = _isEditMode ? _existingLeave.LeaveId : (long?)null,
                Description = txtReason.Text.Trim(),
                LeaveDate = dtpStart.Value,
                LeaveEndDate = dtpEnd.Value
            };

            if (string.IsNullOrEmpty(request.Description))
            {
                MessageBox.Show("Please provide a reason for the leave.");
                return;
            }

            btnSubmit.Enabled = false;
            try
            {
                ApiResponse result;
                if (_isEditMode)
                {
                    result = await LeaveService.UpdateLeaveAsync(request);
                }
                else
                {
                    result = await LeaveService.RequestLeaveAsync(request);
                }

                if (result.Success)
                {
                    MessageBox.Show(_isEditMode ? "Leave request updated!" : "Leave request submitted!");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Operation failed: " + result.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                btnSubmit.Enabled = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
