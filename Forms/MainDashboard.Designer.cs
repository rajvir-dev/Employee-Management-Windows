namespace EmployeeManagement_Windows.Forms
{
    using EmployeeManagement_Windows.CustomControls;

    partial class MainDashboard
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlSidebar = new CardPanel();
            this.pnlTopBar = new CardPanel();
            this.pnlMainContent = new System.Windows.Forms.Panel();
            this.lblDashboard = new System.Windows.Forms.Label();
            this.btnKanban = new ModernButton();
            this.btnProfile = new ModernButton();
            this.btnLeaves = new ModernButton();
            this.btnLogout = new ModernButton();
            this.lblUserName = new System.Windows.Forms.Label();
            this.pnlSidebar.SuspendLayout();
            this.pnlTopBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.Transparent;
            this.pnlSidebar.BorderRadius = 0;
            this.pnlSidebar.CardColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.pnlSidebar.Controls.Add(this.btnLogout);
            this.pnlSidebar.Controls.Add(this.btnLeaves);
            this.pnlSidebar.Controls.Add(this.btnProfile);
            this.pnlSidebar.Controls.Add(this.btnKanban);
            this.pnlSidebar.Controls.Add(this.lblDashboard);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Padding = new System.Windows.Forms.Padding(0);
            this.pnlSidebar.ShadowSize = 0;
            this.pnlSidebar.Size = new System.Drawing.Size(250, 720);
            this.pnlSidebar.TabIndex = 0;
            // 
            // lblDashboard
            // 
            this.lblDashboard.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblDashboard.ForeColor = System.Drawing.Color.White;
            this.lblDashboard.Location = new System.Drawing.Point(0, 40);
            this.lblDashboard.Name = "lblDashboard";
            this.lblDashboard.Size = new System.Drawing.Size(250, 50);
            this.lblDashboard.TabIndex = 0;
            this.lblDashboard.Text = "EMS DASHBOARD";
            this.lblDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnKanban
            // 
            this.btnKanban.BackColor = System.Drawing.Color.Transparent;
            this.btnKanban.BorderRadius = 10;
            this.btnKanban.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKanban.FlatAppearance.BorderSize = 0;
            this.btnKanban.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKanban.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.btnKanban.ForeColor = System.Drawing.Color.White;
            this.btnKanban.GradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(45)))), ((int)(((byte)(226)))));
            this.btnKanban.GradientStart = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(45)))), ((int)(((byte)(226)))));
            this.btnKanban.Location = new System.Drawing.Point(20, 150);
            this.btnKanban.Name = "btnKanban";
            this.btnKanban.Size = new System.Drawing.Size(210, 45);
            this.btnKanban.TabIndex = 1;
            this.btnKanban.Text = "Kanban Board";
            this.btnKanban.UseVisualStyleBackColor = false;
            this.btnKanban.Click += new System.EventHandler(this.btnKanban_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.BackColor = System.Drawing.Color.Transparent;
            this.btnProfile.BorderRadius = 10;
            this.btnProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProfile.FlatAppearance.BorderSize = 0;
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.btnProfile.ForeColor = System.Drawing.Color.White;
            this.btnProfile.GradientEnd = System.Drawing.Color.Transparent;
            this.btnProfile.GradientStart = System.Drawing.Color.Transparent;
            this.btnProfile.Location = new System.Drawing.Point(20, 210);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(210, 45);
            this.btnProfile.TabIndex = 2;
            this.btnProfile.Text = "My Profile";
            this.btnProfile.UseVisualStyleBackColor = false;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnLeaves
            // 
            this.btnLeaves.BackColor = System.Drawing.Color.Transparent;
            this.btnLeaves.BorderRadius = 10;
            this.btnLeaves.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLeaves.FlatAppearance.BorderSize = 0;
            this.btnLeaves.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLeaves.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.btnLeaves.ForeColor = System.Drawing.Color.White;
            this.btnLeaves.GradientEnd = System.Drawing.Color.Transparent;
            this.btnLeaves.GradientStart = System.Drawing.Color.Transparent;
            this.btnLeaves.Location = new System.Drawing.Point(20, 270);
            this.btnLeaves.Name = "btnLeaves";
            this.btnLeaves.Size = new System.Drawing.Size(210, 45);
            this.btnLeaves.TabIndex = 4;
            this.btnLeaves.Text = "My Leaves";
            this.btnLeaves.UseVisualStyleBackColor = false;
            this.btnLeaves.Click += new System.EventHandler(this.btnLeaves_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.BorderRadius = 10;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.btnLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(121)))), ((int)(((byte)(121)))));
            this.btnLogout.GradientEnd = System.Drawing.Color.Transparent;
            this.btnLogout.GradientStart = System.Drawing.Color.Transparent;
            this.btnLogout.Location = new System.Drawing.Point(20, 650);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(210, 45);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // pnlTopBar
            // 
            this.pnlTopBar.BackColor = System.Drawing.Color.Transparent;
            this.pnlTopBar.BorderRadius = 0;
            this.pnlTopBar.CardColor = System.Drawing.Color.White;
            this.pnlTopBar.Controls.Add(this.lblUserName);
            this.pnlTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopBar.Location = new System.Drawing.Point(250, 0);
            this.pnlTopBar.Name = "pnlTopBar";
            this.pnlTopBar.Padding = new System.Windows.Forms.Padding(0);
            this.pnlTopBar.ShadowSize = 5;
            this.pnlTopBar.Size = new System.Drawing.Size(1030, 70);
            this.pnlTopBar.TabIndex = 1;
            // 
            // lblUserName
            // 
            this.lblUserName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUserName.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.lblUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.lblUserName.Location = new System.Drawing.Point(760, 20);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(250, 30);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "User Name";
            this.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlMainContent
            // 
            this.pnlMainContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.pnlMainContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainContent.Location = new System.Drawing.Point(250, 70);
            this.pnlMainContent.Name = "pnlMainContent";
            this.pnlMainContent.Size = new System.Drawing.Size(1030, 650);
            this.pnlMainContent.TabIndex = 2;
            // 
            // MainDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.pnlMainContent);
            this.Controls.Add(this.pnlTopBar);
            this.Controls.Add(this.pnlSidebar);
            this.Name = "MainDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Management - Dashboard";
            this.pnlSidebar.ResumeLayout(false);
            this.pnlTopBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private CardPanel pnlSidebar;
        private CardPanel pnlTopBar;
        private System.Windows.Forms.Panel pnlMainContent;
        private System.Windows.Forms.Label lblDashboard;
        private ModernButton btnKanban;
        private ModernButton btnProfile;
        private ModernButton btnLeaves;
        private ModernButton btnLogout;
        private System.Windows.Forms.Label lblUserName;
    }
}
