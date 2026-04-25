using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmployeeManagement_Windows.Components;
using EmployeeManagement_Windows.Helpers;
using EmployeeManagement_Windows.Models;
using EmployeeManagement_Windows.Services;
using EmployeeManagement_Windows.Controls;

namespace EmployeeManagement_Windows.Views
{
    public partial class TaskDetailsView : UserControl
    {
        private TaskDto _task;
        public event Action OnBack;
        public event Action OnStatusChanged;

        public TaskDetailsView(TaskDto task)
        {
            _task = task;
            InitializeComponent();
            LoadData();
        }

        private async void LoadData()
        {
            try
            {
                // Fetch full task details including assigned employees
                var fullTask = await TaskService.GetTaskByIdAsync(_task.EncryptedId);
                if (fullTask != null)
                {
                    _task = fullTask;
                }

                lblTitle.Text = _task.Title ?? "Untitled Task";
                lblDescription.Text = _task.Description ?? "No description provided.";
                lblDueDateValue.Text = _task.DueDate?.ToString("dd MMM yyyy") ?? "Not set";
                
                // Set initial status
                UpdateStatusDisplay(_task.StatusId);

                // Populate assigned employees
                flowAssignedTo.Controls.Clear();
                if (_task.AssignedEmployees != null && _task.AssignedEmployees.Count > 0)
                {
                    foreach (var emp in _task.AssignedEmployees)
                    {
                        var lblBadge = new Label
                        {
                            Text = emp.FullName ?? "Unknown",
                            AutoSize = true,
                            BackColor = Color.FromArgb(243, 244, 246),
                            ForeColor = Color.FromArgb(31, 41, 55),
                            Font = new Font("Segoe UI", 8.5F, FontStyle.Bold),
                            Padding = new Padding(10, 4, 10, 4),
                            Margin = new Padding(0, 0, 8, 4),
                            TextAlign = ContentAlignment.MiddleCenter
                        };

                        // Make it slightly rounded
                        System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
                        int radius = 12;
                        Rectangle rect = new Rectangle(0, 0, 1000, 1000); // Large enough
                        // Since AutoSize is true, we'll need to do this in a Paint or Resize event if we want exact rounding,
                        // but for now, simple FlatStyle with border might be enough, or just leave as is for a clean look.
                        // Actually, I'll just use a custom control or leave it as a neat rectangle with padding.
                        
                        flowAssignedTo.Controls.Add(lblBadge);
                    }
                }
                else if (!string.IsNullOrEmpty(_task.AssignedTo))
                {
                    var lblBadge = new Label
                    {
                        Text = _task.AssignedTo,
                        AutoSize = true,
                        BackColor = Color.FromArgb(243, 244, 246),
                        ForeColor = Color.FromArgb(31, 41, 55),
                        Font = new Font("Segoe UI", 8.5F, FontStyle.Bold),
                        Padding = new Padding(10, 4, 10, 4),
                        Margin = new Padding(0, 0, 8, 4),
                        TextAlign = ContentAlignment.MiddleCenter
                    };
                    flowAssignedTo.Controls.Add(lblBadge);
                }

                if (pnlCommentsContainer.Visible)
                {
                    await LoadComments();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading task details: " + ex.Message);
            }
        }

        private void UpdateStatusDisplay(int? statusId)
        {
            try
            {
                switch (statusId)
                {
                    case 1: 
                        cmbStatus.SelectedIndex = 0;
                        cmbStatus.BackColor = Color.FromArgb(219, 234, 254); // Blue 100
                        cmbStatus.ForeColor = Color.FromArgb(37, 99, 235);   // Blue 600
                        break;
                    case 2: 
                        cmbStatus.SelectedIndex = 1;
                        cmbStatus.BackColor = Color.FromArgb(254, 243, 199); // Amber 100
                        cmbStatus.ForeColor = Color.FromArgb(217, 119, 6);   // Amber 600
                        break;
                    case 3: 
                        cmbStatus.SelectedIndex = 2;
                        cmbStatus.BackColor = Color.FromArgb(209, 250, 229); // Green 100
                        cmbStatus.ForeColor = Color.FromArgb(5, 150, 105);   // Green 600
                        break;
                    default: 
                        cmbStatus.SelectedIndex = -1;
                        cmbStatus.BackColor = Color.White;
                        cmbStatus.ForeColor = Color.Black;
                        break;
                }
                
                btnSaveStatus.Visible = false;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("UpdateStatusDisplay error: " + ex.Message);
            }
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbStatus.SelectedIndex < 0) return;

                int newStatusId = cmbStatus.SelectedIndex + 1;
                btnSaveStatus.Visible = (newStatusId != _task.StatusId);

                // Update visual immediately for feedback
                switch (newStatusId)
                {
                    case 1: 
                        cmbStatus.BackColor = Color.FromArgb(219, 234, 254);
                        cmbStatus.ForeColor = Color.FromArgb(37, 99, 235);
                        break;
                    case 2: 
                        cmbStatus.BackColor = Color.FromArgb(254, 243, 199);
                        cmbStatus.ForeColor = Color.FromArgb(217, 119, 6);
                        break;
                    case 3: 
                        cmbStatus.BackColor = Color.FromArgb(209, 250, 229);
                        cmbStatus.ForeColor = Color.FromArgb(5, 150, 105);
                        break;
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("cmbStatus_SelectedIndexChanged error: " + ex.Message);
            }
        }

        private void cmbStatus_DrawItem(object sender, DrawItemEventArgs e)
        {
            try
            {
                if (e.Index < 0) return;

                string text = cmbStatus.Items[e.Index].ToString();
                Color textColor = Color.Black;

                // Individual colors for each option
                if (text == "Assigned") textColor = ColorTranslator.FromHtml("#2563EB");
                else if (text == "In Progress") textColor = ColorTranslator.FromHtml("#D97706");
                else if (text == "Completed") textColor = ColorTranslator.FromHtml("#059669");

                // Draw background
                if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                {
                    e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(243, 244, 246)), e.Bounds); // Light Gray hover
                }
                else
                {
                    e.Graphics.FillRectangle(new SolidBrush(Color.White), e.Bounds);
                }

                // Draw text
                using (Font font = new Font("Segoe UI Semibold", 10F))
                {
                    Rectangle textRect = new Rectangle(e.Bounds.X + 10, e.Bounds.Y, e.Bounds.Width - 10, e.Bounds.Height);
                    TextRenderer.DrawText(e.Graphics, text, font, textRect, textColor, TextFormatFlags.Left | TextFormatFlags.VerticalCenter);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("cmbStatus_DrawItem error: " + ex.Message);
            }
        }

        private void btnToggleComments_Click(object sender, EventArgs e)
        {
            try
            {
                bool isVisible = !pnlComments.Visible;
                pnlComments.Visible = isVisible;
                pnlInput.Visible = isVisible;

                if (isVisible)
                {
                    _ = LoadComments();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error toggling comments: " + ex.Message);
            }
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
                    OnStatusChanged?.Invoke();
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
            try
            {
                OnBack?.Invoke();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("btnBack_Click error: " + ex.Message);
            }
        }

        private void btnNewMeeting_Click(object sender, EventArgs e)
        {
            try
            {
                using (var form = new Forms.ScheduleMeetingForm(_task.EncryptedId))
                {
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        // Refresh comments if we're in meeting mode or just to show the new meeting entry
                        if (pnlComments.Visible)
                        {
                            _ = LoadComments();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening meeting scheduler: " + ex.Message);
            }
        }

        private void txtMinutes_Load(object sender, EventArgs e)
        {

        }
    }
}
