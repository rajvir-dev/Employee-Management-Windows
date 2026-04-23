using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmployeeManagement_Windows.Components;
using EmployeeManagement_Windows.Helpers;
using EmployeeManagement_Windows.Models;
using EmployeeManagement_Windows.Services;

namespace EmployeeManagement_Windows.Views
{
    public partial class TaskDetailsView : UserControl
    {
        private TaskDto _task;
        public event Action OnBack;

        public TaskDetailsView(TaskDto task)
        {
            _task = task;
            InitializeComponent();
            LoadData();
        }

        private async void LoadData()
        {
            lblTitle.Text = _task.Title ?? "Untitled Task";
            lblDescription.Text = _task.Description ?? "No description provided.";
            
            // Set initial status
            UpdateStatusDisplay(_task.StatusId);

            await LoadComments();
        }

        private void UpdateStatusDisplay(int? statusId)
        {
            switch (statusId)
            {
                case 1: cmbStatus.SelectedIndex = 0; break; // TO DO
                case 2: cmbStatus.SelectedIndex = 1; break; // IN PROGRESS
                case 3: cmbStatus.SelectedIndex = 2; break; // COMPLETED
                default: cmbStatus.SelectedIndex = -1; break;
            }
            
            badgeStatus.Text = cmbStatus.SelectedItem?.ToString() ?? "UNKNOWN";
            badgeStatus.BadgeColor = ThemeColors.GetStatusColor(statusId);
            btnSaveStatus.Visible = false;
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbStatus.SelectedIndex < 0) return;

            int newStatusId = cmbStatus.SelectedIndex + 1;
            btnSaveStatus.Visible = (newStatusId != _task.StatusId);
        }

        private async void btnSaveStatus_Click(object sender, EventArgs e)
        {
            if (cmbStatus.SelectedIndex < 0) return;

            int newStatusId = cmbStatus.SelectedIndex + 1;
            btnSaveStatus.Enabled = false;
            
            try
            {
                var result = await TaskService.UpdateStatusAsync(_task.EncryptedId, newStatusId);
                if (result.Success)
                {
                    _task.StatusId = newStatusId;
                    UpdateStatusDisplay(newStatusId);
                }
                else
                {
                    MessageBox.Show("Failed to update status: " + result.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating status: " + ex.Message);
            }
            finally
            {
                btnSaveStatus.Enabled = true;
            }
        }

        private async Task LoadComments()
        {
            pnlComments.Controls.Clear();
            try
            {
                var comments = await TaskService.GetCommentsAsync(_task.EncryptedId);
                if (this.IsDisposed) return;

                foreach (var comment in comments)
                {
                    var item = new CommentItem(comment);
                    item.Width = pnlComments.Width - 30; // Leave room for scrollbar
                    pnlComments.Controls.Add(item);
                }
                
                // Scroll to bottom
                pnlComments.VerticalScroll.Value = pnlComments.VerticalScroll.Maximum;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading comments: " + ex.Message);
            }
        }

        private async void btnSend_Click(object sender, EventArgs e)
        {
            string text = txtComment.Text.Trim();
            if (string.IsNullOrEmpty(text)) return;

            btnSend.Enabled = false;
            try
            {
                int.TryParse(txtHours.Text, out int hours);
                int.TryParse(txtMinutes.Text, out int minutes);

                var request = new CommentRequest 
                { 
                    CommentText = text,
                    HoursWorked = hours > 0 ? (int?)hours : null,
                    MinutesWorked = minutes > 0 ? (int?)minutes : null
                };

                var result = await TaskService.AddCommentAsync(_task.EncryptedId, request);
                if (result.Success)
                {
                    txtComment.Clear();
                    txtHours.Text = "";
                    txtMinutes.Text = "";
                    await LoadComments();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding comment: " + ex.Message);
            }
            finally
            {
                btnSend.Enabled = true;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            OnBack?.Invoke();
        }
    }
}
