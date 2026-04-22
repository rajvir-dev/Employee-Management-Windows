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
            
            pnlPending.BackColor = ThemeColors.TextSecondary;
            pnlInProgress.BackColor = ThemeColors.Warning;
            pnlCompleted.BackColor = ThemeColors.Success;

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

                    // Support both ID-based and Name-based mapping for robustness
                    string status = task.Status?.ToLower() ?? "";
                    int statusId = task.StatusId ?? 0;

                    if (statusId == 1 || status == "pending")
                    {
                        flowPending.Controls.Add(card);
                    }
                    else if (statusId == 2 || status == "in progress" || status == "inprogress")
                    {
                        flowInProgress.Controls.Add(card);
                    }
                    else if (statusId == 3 || status == "completed" || status == "done" || status == "complete" || task.IsCompleted)
                    {
                        flowCompleted.Controls.Add(card);
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
        }
    }
}
