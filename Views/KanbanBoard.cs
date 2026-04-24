using System;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmployeeManagement_Windows.Components;
using EmployeeManagement_Windows.Helpers;
using EmployeeManagement_Windows.Models;
using EmployeeManagement_Windows.Services;

namespace EmployeeManagement_Windows.Views
{
    public partial class KanbanBoard : UserControl
    {
        public event Action<TaskDto> OnTaskSelected;

        public KanbanBoard()
        {
            InitializeComponent();
            SetupStyles();
        }

        protected override async void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            await LoadTasks();
        }

        private void SetupStyles()
        {
            this.BackColor = ThemeColors.Background;
            
            pnlPending.BackColor = ColorTranslator.FromHtml("#0369A1"); // Assigned (Blue)
            pnlInProgress.BackColor = ThemeColors.Warning; // In Progress (Amber)
            pnlCompleted.BackColor = ThemeColors.Success; // Completed (Green)

            lblPending.ForeColor = Color.White;
            lblInProgress.ForeColor = Color.White;
            lblCompleted.ForeColor = Color.White;

            btnRefresh.BackColor = ThemeColors.Primary;
            btnRefresh.ForeColor = Color.White;
        }

        private async Task LoadTasks()
        {
            try
            {
                var tasks = await TaskService.GetMyTasksAsync();
                if (this.IsDisposed) return;
                
                flowPending.Controls.Clear();
                flowInProgress.Controls.Clear();
                flowCompleted.Controls.Clear();

                if (tasks == null || tasks.Count == 0) return;

                foreach (var task in tasks)
                {
                    var card = new TaskCard(task);
                    card.OnTaskClicked += (t) => OnTaskSelected?.Invoke(t);
                    
                    // Use a more robust width calculation
                    int targetWidth = flowPending.Width > 20 ? flowPending.Width - 25 : 220;
                    card.Width = targetWidth;

                    string status = task.Status?.ToLower() ?? "";
                    int statusId = task.StatusId ?? 0;

                    // PRIORITIZE COMPLETED STATUS
                    if (statusId == 3 || status == "completed" || status == "done" || status == "complete" || task.IsCompleted)
                    {
                        flowCompleted.Controls.Add(card);
                    }
                    else if (statusId == 2 || status.Contains("progress"))
                    {
                        flowInProgress.Controls.Add(card);
                    }
                    else
                    {
                        // Default to Pending
                        flowPending.Controls.Add(card);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading tasks: " + ex.Message);
            }
        }

        private async void btnRefresh_Click(object sender, EventArgs e)
        {
            await LoadTasks();
            if (this.IsDisposed) return;
        }
    }
}
