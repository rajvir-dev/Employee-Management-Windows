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
            try
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
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("SetupDashboard error: " + ex.Message);
            }
        }

        public void RefreshAvatar()
        {
            try
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
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("RefreshAvatar error: " + ex.Message);
            }
        }

        private async void ShowKanban()
        {
            try
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
                
                // Instantly refresh tasks whenever board is shown
                await _kanbanBoard.LoadTasks();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error showing Kanban: " + ex.Message);
            }
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

            // Instantly refresh kanban board if status changes while in details view
            details.OnStatusChanged += async () => {
                if (_kanbanBoard != null)
                {
                    await _kanbanBoard.LoadTasks();
                }
            };

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

        #region Window Controls
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private void pnlTopBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, 0x112, 0xf012, 0);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                btnMaximize.Text = "1"; // Maximize icon
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                btnMaximize.Text = "2"; // Restore icon
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion

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
