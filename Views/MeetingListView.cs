using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmployeeManagement_Windows.Components;
using EmployeeManagement_Windows.Helpers;
using EmployeeManagement_Windows.Models;
using EmployeeManagement_Windows.Services;
using EmployeeManagement_Windows.Core;
using EmployeeManagement_Windows.Controls;

namespace EmployeeManagement_Windows.Views
{
    public partial class MeetingListView : UserControl
    {
        private List<CommentDto> _allMeetings;
        private bool _isDateFilterActive = false;
        private bool _isResetting = false;

        public MeetingListView()
        {
            InitializeComponent();
            SetupStyles();
            SetupEvents();
        }

        private void SetupEvents()
        {
            try
            {
                dtpFrom.ValueChanged += (s, e) => { 
                    if (!_isResetting)
                    {
                        _isDateFilterActive = true; 
                        ApplyFilters(); 
                    }
                };
                dtpTo.ValueChanged += (s, e) => { 
                    if (!_isResetting)
                    {
                        _isDateFilterActive = true; 
                        ApplyFilters(); 
                    }
                };
                cmbStatus.SelectedIndexChanged += (s, e) => ApplyFilters();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("SetupEvents error: " + ex.Message);
            }
        }

        private void SetupStyles()
        {
            try
            {
                this.BackColor = ThemeColors.Background;
                lblBreadcrumb.ForeColor = ThemeColors.TextSecondary;
                
                // Filter panel styling
                cardFilters.CardColor = Color.White;
                cardFilters.ShadowSize = 2;
                
                btnSearch.BackColor = ColorTranslator.FromHtml("#6B5FE4");
                btnSearch.ForeColor = Color.White;
                btnSearch.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
                
                btnReset.BackColor = ColorTranslator.FromHtml("#4B5563");
                btnReset.ForeColor = Color.White;
                btnReset.Font = new Font("Segoe UI", 10F, FontStyle.Bold);

                // Set larger fonts to increase control heights to match buttons
                cmbStatus.Font = new Font("Segoe UI", 12F);

                cmbStatus.Items.Clear();
                cmbStatus.Items.AddRange(new object[] { "All Statuses", "Scheduled", "OnGoing", "Concluded", "Cancelled", "Rescheduled" });
                cmbStatus.FlatStyle = FlatStyle.Flat;
                cmbStatus.SelectedIndex = 0;
                cmbStatus.DrawMode = DrawMode.OwnerDrawFixed;
                cmbStatus.ItemHeight = 34; // Match the 40px button height feel
                cmbStatus.DrawItem += CmbStatus_DrawItem;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("SetupStyles error: " + ex.Message);
            }
        }

        private void CmbStatus_DrawItem(object sender, DrawItemEventArgs e)
        {
            try
            {
                if (e.Index < 0) return;

                string text = cmbStatus.Items[e.Index].ToString();
                Color textColor = ThemeColors.TextPrimary;

                // Define colors matching the user image
                if (text == "Scheduled") textColor = ColorTranslator.FromHtml("#6B5FE4"); 
                else if (text == "OnGoing") textColor = ColorTranslator.FromHtml("#F59E0B"); 
                else if (text == "Concluded") textColor = ColorTranslator.FromHtml("#374151"); 
                else if (text == "Cancelled") textColor = ColorTranslator.FromHtml("#E24B4A"); 
                else if (text == "Rescheduled") textColor = ColorTranslator.FromHtml("#10B981"); 

                // Draw background
                if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                {
                    e.Graphics.FillRectangle(new SolidBrush(ThemeColors.Primary), e.Bounds);
                    textColor = Color.White;
                }
                else
                {
                    e.Graphics.FillRectangle(new SolidBrush(Color.White), e.Bounds);
                }

                // Draw text
                using (Font font = new Font("Segoe UI", 11F, FontStyle.Bold))
                {
                    Rectangle textRect = new Rectangle(e.Bounds.X + 8, e.Bounds.Y, e.Bounds.Width - 8, e.Bounds.Height);
                    TextRenderer.DrawText(e.Graphics, text, font, textRect, textColor, TextFormatFlags.Left | TextFormatFlags.VerticalCenter);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("CmbStatus_DrawItem error: " + ex.Message);
            }
        }

        protected override async void OnLoad(EventArgs e)
        {
            try
            {
                base.OnLoad(e);
                await LoadMeetingsAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on load: " + ex.Message);
            }
        }

        private async Task LoadMeetingsAsync()
        {
            try
            {
                _allMeetings = await TaskService.GetMyMeetingsAsync();
                ApplyFilters();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading meetings: " + ex.Message);
            }
        }

        private void ApplyFilters()
        {
            try
            {
                if (_allMeetings == null) return;

                flowMeetings.Controls.Clear();
                string selectedStatus = cmbStatus.SelectedItem?.ToString() ?? "All Statuses";
                DateTime? fromDate = _isDateFilterActive ? dtpFrom.Value : (DateTime?)null;
                DateTime? toDate = _isDateFilterActive ? dtpTo.Value : (DateTime?)null;

                foreach (var meeting in _allMeetings)
                {
                    string mStatus = meeting.StatusText ?? "";
                    bool matchesStatus = selectedStatus == "All Statuses" || 
                                       mStatus.Equals(selectedStatus, StringComparison.OrdinalIgnoreCase) ||
                                       (selectedStatus.Equals("Rescheduled", StringComparison.OrdinalIgnoreCase) && mStatus.Equals("ReSheduled", StringComparison.OrdinalIgnoreCase)) ||
                                       (selectedStatus.Equals("Scheduled", StringComparison.OrdinalIgnoreCase) && mStatus.Equals("Sheduled", StringComparison.OrdinalIgnoreCase));
                    
                    bool matchesDate = true;
                    if (meeting.MeetingDateTime.HasValue)
                    {
                        DateTime mDate = meeting.MeetingDateTime.Value.Date;
                        if (fromDate.HasValue && mDate < fromDate.Value) matchesDate = false;
                        if (toDate.HasValue && mDate > toDate.Value) matchesDate = false;
                    }

                    if (matchesStatus && matchesDate)
                    {
                        var card = new MeetingCard(meeting);
                        card.MeetingChanged += async () => await LoadMeetingsAsync();
                        
                        // Standard width for meeting cards (grid layout feel)
                        card.Width = (flowMeetings.Width - 60) / 3;
                        if (card.Width < 300) card.Width = flowMeetings.Width - 40;
                        
                        flowMeetings.Controls.Add(card);
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("ApplyFilters error: " + ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                ApplyFilters();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching: " + ex.Message);
            }
        }

        private async void btnReset_Click(object sender, EventArgs e)
        {
            try
            {
                _isResetting = true;
                cmbStatus.SelectedIndex = 0;
                _isDateFilterActive = false;
                
                // Properly clear the ModernDatePicker values
                dtpFrom.Value = null;
                dtpTo.Value = null;
                
                _isResetting = false;
                await LoadMeetingsAsync();
            }
            catch (Exception ex)
            {
                _isResetting = false;
                MessageBox.Show("Error resetting filters: " + ex.Message);
            }
        }
    }
}
