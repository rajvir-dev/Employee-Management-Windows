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
    public partial class LeaveHistoryView : UserControl
    {
        public LeaveHistoryView()
        {
            InitializeComponent();
            SetupStyles();
        }

        private void SetupStyles()
        {
            this.BackColor = ThemeColors.Background;
            lblHeader.ForeColor = ThemeColors.TextPrimary;
        }

        protected override async void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            await LoadLeaveHistoryAsync();

            try
            {
                SignalRService.Instance.OnNotificationReceived += async (title, message) => {
                    if (title != null && title.Contains("Leave"))
                    {
                        if (this.IsDisposed) return;
                        if (this.InvokeRequired)
                        {
                            this.Invoke(new MethodInvoker(async () => await LoadLeaveHistoryAsync()));
                        }
                        else
                        {
                            await LoadLeaveHistoryAsync();
                        }
                    }
                };
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("SignalR Subscription Error: " + ex.Message);
            }
        }

        private async Task LoadLeaveHistoryAsync()
        {
            if (this.IsDisposed) return;
            try
            {
                var leaves = await LeaveService.GetMyLeavesAsync();
                if (this.IsDisposed) return;
                flowLeaveHistory.Controls.Clear();

                if (leaves == null) return;

                foreach (var leave in leaves)
                {
                    var item = new LeaveItem(leave);
                    item.OnLeaveUpdated += async () => await LoadLeaveHistoryAsync();
                    flowLeaveHistory.Controls.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading leaves: " + ex.Message);
            }
        }

        private async void btnRequestLeave_Click(object sender, EventArgs e)
        {
            using (var form = new EmployeeManagement_Windows.Forms.LeaveRequestForm())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    await LoadLeaveHistoryAsync();
                }
            }
        }
    }
}
