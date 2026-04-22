using System;
using System.Drawing;
using System.Windows.Forms;
using EmployeeManagement_Windows.Core;
using EmployeeManagement_Windows.Views;
using EmployeeManagement_Windows.Services;

namespace EmployeeManagement_Windows.Forms
{
    public partial class MainDashboard : Form
    {
        private KanbanBoard _kanbanBoard;
        private ProfileView _profileView;
        private LeaveHistoryView _leaveHistoryView;

        public MainDashboard()
        {
            InitializeComponent();
            SetupDashboard();
        }

        private void SetupDashboard()
        {
            lblUserName.Text = SessionManager.FullName ?? "User";
            ShowKanban();
        }

        private void ShowKanban()
        {
            if (_kanbanBoard == null)
            {
                _kanbanBoard = new KanbanBoard();
                _kanbanBoard.Dock = DockStyle.Fill;
                _kanbanBoard.OnTaskSelected += ShowTaskDetails;
            }

            pnlMainContent.Controls.Clear();
            pnlMainContent.Controls.Add(_kanbanBoard);
            
            SetButtonActive(btnKanban);
        }

        private void ShowProfile()
        {
            if (_profileView == null)
            {
                _profileView = new ProfileView();
                _profileView.Dock = DockStyle.Fill;
            }

            pnlMainContent.Controls.Clear();
            pnlMainContent.Controls.Add(_profileView);
            
            SetButtonActive(btnProfile);
        }

        private void ShowLeaves()
        {
            if (_leaveHistoryView == null)
            {
                _leaveHistoryView = new LeaveHistoryView();
                _leaveHistoryView.Dock = DockStyle.Fill;
            }

            pnlMainContent.Controls.Clear();
            pnlMainContent.Controls.Add(_leaveHistoryView);
            
            SetButtonActive(btnLeaves);
        }

        private void ShowTaskDetails(Models.TaskDto task)
        {
            var details = new TaskDetailsView(task);
            details.Dock = DockStyle.Fill;
            details.OnBack += ShowKanban;

            pnlMainContent.Controls.Clear();
            pnlMainContent.Controls.Add(details);
        }

        private void SetButtonActive(EmployeeManagement_Windows.CustomControls.ModernButton activeBtn)
        {
            // Inactive state: Subtle dark purple or transparent
            btnKanban.GradientStart = Color.Transparent;
            btnKanban.GradientEnd = Color.Transparent;
            btnProfile.GradientStart = Color.Transparent;
            btnProfile.GradientEnd = Color.Transparent;
            btnLeaves.GradientStart = Color.Transparent;
            btnLeaves.GradientEnd = Color.Transparent;

            // Active state: Vibrant Purple Gradient
            activeBtn.GradientStart = Color.FromArgb(142, 45, 226);
            activeBtn.GradientEnd = Color.FromArgb(74, 0, 224);
        }

        private void btnKanban_Click(object sender, EventArgs e) => ShowKanban();
        private void btnProfile_Click(object sender, EventArgs e) => ShowProfile();
        private void btnLeaves_Click(object sender, EventArgs e) => ShowLeaves();

        private void btnLogout_Click(object sender, EventArgs e)
        {
            SessionManager.Clear();
            this.Hide();
            using (var login = new LoginForm())
            {
                if (login.ShowDialog() == DialogResult.OK)
                {
                    this.Show();
                    SetupDashboard();
                }
                else
                {
                    Application.Exit();
                }
            }
        }
    }
}
