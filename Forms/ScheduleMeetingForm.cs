using System;
using System.Windows.Forms;
using EmployeeManagement_Windows.Models;
using EmployeeManagement_Windows.Services;
using EmployeeManagement_Windows.Core;

namespace EmployeeManagement_Windows.Forms
{
    public partial class ScheduleMeetingForm : Form
    {
        private string _taskId;
        private CommentDto _meeting;
        private bool _isEditMode = false;

        public ScheduleMeetingForm(string taskId)
        {
            _taskId = taskId;
            InitializeComponent();
        }

        public ScheduleMeetingForm(CommentDto meeting)
        {
            _meeting = meeting;
            _taskId = meeting.EncryptedTaskId;
            _isEditMode = true;
            InitializeComponent();
            LoadMeetingData();
        }

        private void LoadMeetingData()
        {
            this.Text = "Update Meeting";
            lblTitle.Text = "Update Meeting";
            btnSchedule.Text = "Update Meeting";
            txtSubject.Text = _meeting.MeetingTitle;
            txtHours.Text = _meeting.HoursWorked?.ToString() ?? "0";
            txtMinutes.Text = _meeting.MinutesWorked?.ToString() ?? "0";
            if (_meeting.MeetingDateTime.HasValue)
            {
                dtpDate.Value = _meeting.MeetingDateTime.Value.Date;
                dtpTime.Value = _meeting.MeetingDateTime.Value;
            }
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

            DateTime scheduledTime = dtpDate.Value.Date + dtpTime.Value.TimeOfDay;
            if (!_isEditMode && scheduledTime < DateTime.Now)
            {
                MessageBox.Show("Meeting cannot be scheduled in the past.");
                return;
            }

            int.TryParse(txtHours.Text, out int hours);
            int.TryParse(txtMinutes.Text, out int minutes);

            btnSchedule.Enabled = false;
            try
            {
                ApiResponse result;
                if (_isEditMode)
                {
                    var updateData = new 
                    {
                        MeetingTitle = subject,
                        MeetingDateTime = scheduledTime,
                        HoursWorked = hours,
                        MinutesWorked = minutes,
                        TaskId = _meeting.EncryptedTaskId,
                        StatusId = int.Parse(_meeting.Status ?? "21")
                    };
                    result = await TaskService.UpdateMeetingAsync(_meeting.EncryptedId, updateData);
                }
                else
                {
                    var request = new MeetingRequest
                    {
                        MeetingTitle = subject,
                        MeetingDateTime = scheduledTime,
                        HoursWorked = hours,
                        MinutesWorked = minutes,
                        Description = $"Meeting scheduled for task"
                    };
                    result = await TaskService.ScheduleMeetingAsync(_taskId, request);
                }

                if (result.Success)
                {
                    MessageBox.Show(_isEditMode ? "Meeting updated successfully!" : "Meeting scheduled successfully!");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error: " + result.Message);
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
