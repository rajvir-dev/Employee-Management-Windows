using EmployeeManagement_Windows.Controls;

namespace EmployeeManagement_Windows.Forms
{
    partial class MainDashboard
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlTopBar = new EmployeeManagement_Windows.Controls.CardPanel();
            this.lblLogo = new System.Windows.Forms.Label();
            this.pnlNav = new System.Windows.Forms.Panel();
            this.btnKanban = new EmployeeManagement_Windows.Controls.TabButton();
            this.btnMeeting = new EmployeeManagement_Windows.Controls.TabButton();
            this.btnLeaves = new EmployeeManagement_Windows.Controls.TabButton();
            this.btnProfile = new EmployeeManagement_Windows.Controls.TabButton();
            this.btnLogout = new EmployeeManagement_Windows.Controls.TabButton();
            this.avatar = new EmployeeManagement_Windows.Controls.AvatarCircle();
            this.pnlMainContent = new System.Windows.Forms.Panel();
            this.pnlTopBar.SuspendLayout();
            this.pnlNav.SuspendLayout();
            this.SuspendLayout();

            // pnlTopBar
            this.pnlTopBar.BackColor = System.Drawing.Color.Transparent;
            this.pnlTopBar.BorderRadius = 0;
            this.pnlTopBar.CardColor = System.Drawing.Color.White;
            this.pnlTopBar.Controls.Add(this.avatar);
            this.pnlTopBar.Controls.Add(this.btnLogout);
            this.pnlTopBar.Controls.Add(this.pnlNav);
            this.pnlTopBar.Controls.Add(this.lblLogo);
            this.pnlTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTopBar.Name = "pnlTopBar";
            this.pnlTopBar.Padding = new System.Windows.Forms.Padding(0);
            this.pnlTopBar.ShadowSize = 0;
            this.pnlTopBar.Size = new System.Drawing.Size(1280, 80);
            this.pnlTopBar.TabIndex = 1;

            // lblLogo
            this.lblLogo.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblLogo.ForeColor = System.Drawing.Color.FromArgb(107, 95, 228);
            this.lblLogo.Location = new System.Drawing.Point(20, 0);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(150, 80);
            this.lblLogo.TabIndex = 0;
            this.lblLogo.Text = "EMS";
            this.lblLogo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // pnlNav
            this.pnlNav.BackColor = System.Drawing.Color.Transparent;
            this.pnlNav.Controls.Add(this.btnKanban);
            this.pnlNav.Controls.Add(this.btnMeeting);
            this.pnlNav.Controls.Add(this.btnLeaves);
            this.pnlNav.Controls.Add(this.btnProfile);
            this.pnlNav.Location = new System.Drawing.Point(200, 0);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(600, 80);
            this.pnlNav.TabIndex = 1;

            // btnKanban
            this.btnKanban.BackColor = System.Drawing.Color.Transparent;
            this.btnKanban.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKanban.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnKanban.IsActive = false;
            this.btnKanban.Location = new System.Drawing.Point(0, 20);
            this.btnKanban.Name = "btnKanban";
            this.btnKanban.Size = new System.Drawing.Size(120, 60);
            this.btnKanban.TabIndex = 0;
            this.btnKanban.Text = "Tasks";
            this.btnKanban.Click += new System.EventHandler(this.btnKanban_Click);

            // btnMeeting
            this.btnMeeting.BackColor = System.Drawing.Color.Transparent;
            this.btnMeeting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMeeting.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnMeeting.IsActive = false;
            this.btnMeeting.Location = new System.Drawing.Point(120, 20);
            this.btnMeeting.Name = "btnMeeting";
            this.btnMeeting.Size = new System.Drawing.Size(120, 60);
            this.btnMeeting.TabIndex = 1;
            this.btnMeeting.Text = "Meeting";
            this.btnMeeting.Click += new System.EventHandler(this.btnMeeting_Click);

            // btnLeaves
            this.btnLeaves.BackColor = System.Drawing.Color.Transparent;
            this.btnLeaves.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLeaves.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnLeaves.IsActive = false;
            this.btnLeaves.Location = new System.Drawing.Point(240, 20);
            this.btnLeaves.Name = "btnLeaves";
            this.btnLeaves.Size = new System.Drawing.Size(150, 60);
            this.btnLeaves.TabIndex = 2;
            this.btnLeaves.Text = "Leave Requests";
            this.btnLeaves.Click += new System.EventHandler(this.btnLeaves_Click);

            // btnProfile
            this.btnProfile.BackColor = System.Drawing.Color.Transparent;
            this.btnProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProfile.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnProfile.IsActive = false;
            this.btnProfile.Location = new System.Drawing.Point(390, 20);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(120, 60);
            this.btnProfile.TabIndex = 3;
            this.btnProfile.Text = "Profile";
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);

            // btnLogout
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)(
                System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnLogout.IsActive = false;
            this.btnLogout.Location = new System.Drawing.Point(1170, 25);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(80, 40);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Logout";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);

            // avatar
            this.avatar.Anchor = ((System.Windows.Forms.AnchorStyles)(
                System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
            this.avatar.BackColor = System.Drawing.Color.Transparent;
            this.avatar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.avatar.Location = new System.Drawing.Point(1110, 20);
            this.avatar.Name = "avatar";
            this.avatar.Size = new System.Drawing.Size(40, 40);
            this.avatar.TabIndex = 5;

            // pnlMainContent
            this.pnlMainContent.BackColor = System.Drawing.Color.FromArgb(243, 244, 246);
            this.pnlMainContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainContent.Location = new System.Drawing.Point(0, 80);
            this.pnlMainContent.Name = "pnlMainContent";
            this.pnlMainContent.Size = new System.Drawing.Size(1280, 640);
            this.pnlMainContent.TabIndex = 2;

            // MainDashboard
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(243, 244, 246);
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.pnlMainContent);
            this.Controls.Add(this.pnlTopBar);
            this.Name = "MainDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EMS Dashboard";
            this.pnlTopBar.ResumeLayout(false);
            this.pnlNav.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private EmployeeManagement_Windows.Controls.CardPanel pnlTopBar;
        private System.Windows.Forms.Panel pnlMainContent;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Panel pnlNav;
        private EmployeeManagement_Windows.Controls.TabButton btnKanban;
        private EmployeeManagement_Windows.Controls.TabButton btnMeeting;
        private EmployeeManagement_Windows.Controls.TabButton btnLeaves;
        private EmployeeManagement_Windows.Controls.TabButton btnProfile;
        private EmployeeManagement_Windows.Controls.TabButton btnLogout;
        private EmployeeManagement_Windows.Controls.AvatarCircle avatar;
    }
}