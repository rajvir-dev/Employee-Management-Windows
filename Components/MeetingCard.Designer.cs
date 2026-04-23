namespace EmployeeManagement_Windows.Components
{
    partial class MeetingCard
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
            this.cardBase = new EmployeeManagement_Windows.Controls.CardPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.badgeStatus = new EmployeeManagement_Windows.Controls.StatusBadge();
            this.avatar = new EmployeeManagement_Windows.Controls.AvatarCircle();
            this.iconCalendar = new System.Windows.Forms.Label();
            this.iconClock = new System.Windows.Forms.Label();
            this.cardBase.SuspendLayout();
            this.SuspendLayout();
            // 
            // cardBase
            // 
            this.cardBase.BackColor = System.Drawing.Color.Transparent;
            this.cardBase.BorderRadius = 15;
            this.cardBase.CardColor = System.Drawing.Color.White;
            this.cardBase.Controls.Add(this.iconClock);
            this.cardBase.Controls.Add(this.iconCalendar);
            this.cardBase.Controls.Add(this.avatar);
            this.cardBase.Controls.Add(this.badgeStatus);
            this.cardBase.Controls.Add(this.lblTime);
            this.cardBase.Controls.Add(this.lblDate);
            this.cardBase.Controls.Add(this.lblTitle);
            this.cardBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardBase.Location = new System.Drawing.Point(5, 5);
            this.cardBase.Name = "cardBase";
            this.cardBase.Padding = new System.Windows.Forms.Padding(15);
            this.cardBase.ShadowSize = 3;
            this.cardBase.Size = new System.Drawing.Size(340, 160);
            this.cardBase.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.lblTitle.Location = new System.Drawing.Point(15, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(260, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Meeting Title";
            // 
            // iconCalendar
            // 
            this.iconCalendar.AutoSize = true;
            this.iconCalendar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.iconCalendar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(95)))), ((int)(((byte)(228)))));
            this.iconCalendar.Location = new System.Drawing.Point(15, 55);
            this.iconCalendar.Name = "iconCalendar";
            this.iconCalendar.Size = new System.Drawing.Size(22, 19);
            this.iconCalendar.TabIndex = 6;
            this.iconCalendar.Text = "🗓";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblDate.Location = new System.Drawing.Point(40, 58);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(82, 15);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "April 15, 2026";
            // 
            // iconClock
            // 
            this.iconClock.AutoSize = true;
            this.iconClock.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.iconClock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(95)))), ((int)(((byte)(228)))));
            this.iconClock.Location = new System.Drawing.Point(15, 85);
            this.iconClock.Name = "iconClock";
            this.iconClock.Size = new System.Drawing.Size(22, 19);
            this.iconClock.TabIndex = 7;
            this.iconClock.Text = "🕒";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblTime.Location = new System.Drawing.Point(40, 88);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(58, 15);
            this.lblTime.TabIndex = 2;
            this.lblTime.Text = "12:00 PM";
            // 
            // badgeStatus
            // 
            this.badgeStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.badgeStatus.BadgeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(95)))), ((int)(((byte)(228)))));
            this.badgeStatus.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold);
            this.badgeStatus.ForeColor = System.Drawing.Color.White;
            this.badgeStatus.Location = new System.Drawing.Point(235, 120);
            this.badgeStatus.Name = "badgeStatus";
            this.badgeStatus.Size = new System.Drawing.Size(90, 24);
            this.badgeStatus.TabIndex = 3;
            this.badgeStatus.Text = "SCHEDULED";
            // 
            // avatar
            // 
            this.avatar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.avatar.BackColor = System.Drawing.Color.Transparent;
            this.avatar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.avatar.Location = new System.Drawing.Point(15, 120);
            this.avatar.Name = "avatar";
            this.avatar.Size = new System.Drawing.Size(24, 24);
            this.avatar.TabIndex = 5;
            // 
            // MeetingCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.cardBase);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "MeetingCard";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(350, 170);
            this.cardBase.ResumeLayout(false);
            this.cardBase.PerformLayout();
            this.ResumeLayout(false);

        }

        private EmployeeManagement_Windows.Controls.CardPanel cardBase;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTime;
        private EmployeeManagement_Windows.Controls.StatusBadge badgeStatus;
        private EmployeeManagement_Windows.Controls.AvatarCircle avatar;
        private System.Windows.Forms.Label iconCalendar;
        private System.Windows.Forms.Label iconClock;
    }
}
