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
            this.iconCalendar = new System.Windows.Forms.Label();
            this.iconClock = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.flowParticipants = new System.Windows.Forms.FlowLayoutPanel();
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
            this.cardBase.Controls.Add(this.flowParticipants);
            this.cardBase.Controls.Add(this.badgeStatus);
            this.cardBase.Controls.Add(this.btnDelete);
            this.cardBase.Controls.Add(this.btnCancel);
            this.cardBase.Controls.Add(this.btnEdit);
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
            // flowParticipants
            // 
            this.flowParticipants.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.flowParticipants.Location = new System.Drawing.Point(15, 115);
            this.flowParticipants.Name = "flowParticipants";
            this.flowParticipants.Size = new System.Drawing.Size(200, 32);
            this.flowParticipants.TabIndex = 5;
            this.flowParticipants.WrapContents = false;
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
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(95)))), ((int)(((byte)(228)))));
            this.btnEdit.Location = new System.Drawing.Point(275, 12);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(26, 26);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.Text = "📝";
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(75)))), ((int)(((byte)(74)))));
            this.btnCancel.Location = new System.Drawing.Point(305, 12);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(26, 26);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "ⓧ";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(75)))), ((int)(((byte)(74)))));
            this.btnDelete.Location = new System.Drawing.Point(305, 12);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(26, 26);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "🗑";
            this.btnDelete.UseVisualStyleBackColor = false;
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
        private System.Windows.Forms.FlowLayoutPanel flowParticipants;
        private System.Windows.Forms.Label iconCalendar;
        private System.Windows.Forms.Label iconClock;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;
    }
}
