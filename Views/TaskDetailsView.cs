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
            
            badgeStatus.Text = _task.Status?.ToUpper() ?? "UNKNOWN";
            badgeStatus.BadgeColor = ThemeColors.GetStatusColor(_task.StatusId);

            await LoadComments();
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
                var request = new CommentRequest { CommentText = text };
                var result = await TaskService.AddCommentAsync(_task.EncryptedId, request);
                if (result.Success)
                {
                    txtComment.Clear();
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
