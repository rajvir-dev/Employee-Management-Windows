using System;
using System.Windows.Forms;
using EmployeeManagement_Windows.Models;
using EmployeeManagement_Windows.Services;

namespace EmployeeManagement_Windows.Forms
{
    public partial class ScheduleMeetingForm : Form
    {
        private string _taskId;

        public ScheduleMeetingForm(string taskId)
        {
            _taskId = taskId;
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private async void btnSchedule_Click(object sender, EventArgs e)
        {
            string subject = txtSubject.Text.Trim();
            if (string.IsNullOrEmpty(subject))
            {
                MessageBox.Show("Please enter a subject.");
                return;
            }

            // Combine date and time
            DateTime scheduledTime = dtpDate.Value.Date + dtpTime.Value.TimeOfDay;

            btnSchedule.Enabled = false;
            try
            {
                var request = new CommentRequest
                {
                    CommentText = $"SCHEDULED MEETING: {subject} at {scheduledTime:f}"
                };

                var result = await TaskService.AddCommentAsync(_taskId, request);
                if (result.Success)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to schedule: " + result.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                btnSchedule.Enabled = true;
            }
        }
    }
}
