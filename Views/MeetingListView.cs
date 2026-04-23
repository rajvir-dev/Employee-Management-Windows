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

namespace EmployeeManagement_Windows.Views
{
    public partial class MeetingListView : UserControl
    {
        private List<CommentDto> _allMeetings;

        public MeetingListView()
        {
            InitializeComponent();
            SetupStyles();
        }

        private void SetupStyles()
        {
            this.BackColor = ThemeColors.Background;
            lblBreadcrumb.ForeColor = ThemeColors.TextSecondary;
            
            // Filter panel styling
            cardFilters.CardColor = Color.White;
            cardFilters.ShadowSize = 2;
            
            btnSearch.BackColor = ThemeColors.Primary;
            btnSearch.ForeColor = Color.White;
            
            btnReset.BackColor = ThemeColors.DarkButton;
            btnReset.ForeColor = Color.White;

            cmbStatus.Items.Clear();
            cmbStatus.Items.AddRange(new object[] { "All Statuses", "Scheduled", "Concluded", "Cancelled" });
            cmbStatus.SelectedIndex = 0;
        }

        protected override async void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            await LoadMeetingsAsync();
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
            if (_allMeetings == null) return;

            flowMeetings.Controls.Clear();
            string selectedStatus = cmbStatus.SelectedItem?.ToString() ?? "All Statuses";
            DateTime? fromDate = dtpFrom.Checked ? dtpFrom.Value.Date : (DateTime?)null;
            DateTime? toDate = dtpTo.Checked ? dtpTo.Value.Date : (DateTime?)null;

            foreach (var meeting in _allMeetings)
            {
                string mStatus = meeting.StatusText ?? "";
                bool matchesStatus = selectedStatus == "All Statuses" || 
                                   mStatus.Equals(selectedStatus, StringComparison.OrdinalIgnoreCase) ||
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
                    // Standard width for meeting cards (grid layout feel)
                    card.Width = (flowMeetings.Width - 60) / 3;
                    if (card.Width < 300) card.Width = flowMeetings.Width - 40;
                    
                    flowMeetings.Controls.Add(card);
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private async void btnReset_Click(object sender, EventArgs e)
        {
            cmbStatus.SelectedIndex = 0;
            dtpFrom.Checked = false;
            dtpTo.Checked = false;
            await LoadMeetingsAsync();
        }
    }
}
