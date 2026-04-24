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
        private MeetingListView _meetingListView;

        public MainDashboard()
        {
            InitializeComponent();
            SetupDashboard();
        }

        private void SetupDashboard()
        {
            // Load photo from session
            if (!string.IsNullOrEmpty(SessionManager.PhotoBase64))
            {
                avatar.SetImageFromBase64(SessionManager.PhotoBase64);
            }
            else
            {
                avatar.Image = null; // Clear if no photo in current session
            }
            ShowKanban();
        }

        public void RefreshAvatar()
        {
            if (!string.IsNullOrEmpty(SessionManager.PhotoBase64))
            {
                avatar.SetImageFromBase64(SessionManager.PhotoBase64);
            }
            else
            {
                avatar.Image = null;
            }
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
                _profileView.OnProfileUpdated += () => RefreshAvatar();
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

        private void ShowMeetings()
        {
            if (_meetingListView == null)
            {
                _meetingListView = new MeetingListView();
                _meetingListView.Dock = DockStyle.Fill;
            }

            pnlMainContent.Controls.Clear();
            pnlMainContent.Controls.Add(_meetingListView);

            SetButtonActive(btnMeeting);
        }

        private void ShowTaskDetails(Models.TaskDto task)
        {
            var details = new TaskDetailsView(task);
            details.Dock = DockStyle.Fill;
            details.OnBack += ShowKanban;

            pnlMainContent.Controls.Clear();
            pnlMainContent.Controls.Add(details);
        }

        private void SetButtonActive(EmployeeManagement_Windows.Controls.TabButton activeBtn)
        {
            btnKanban.IsActive = false;
            btnProfile.IsActive = false;
            btnLeaves.IsActive = false;
            btnMeeting.IsActive = false;

            if (activeBtn != null)
            {
                activeBtn.IsActive = true;
            }
        }

        private void btnKanban_Click(object sender, EventArgs e) => ShowKanban();
        private void btnProfile_Click(object sender, EventArgs e) => ShowProfile();
        private void btnLeaves_Click(object sender, EventArgs e) => ShowLeaves();
        private void btnMeeting_Click(object sender, EventArgs e) => ShowMeetings();

        private void btnLogout_Click(object sender, EventArgs e)
        {
            SessionManager.Clear();
            
            // Clear cached views to prevent cross-user data leakage
            _kanbanBoard = null;
            _profileView = null;
            _leaveHistoryView = null;
            _meetingListView = null;

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
