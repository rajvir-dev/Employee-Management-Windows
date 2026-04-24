namespace EmployeeManagement_Windows.Components
{
    using EmployeeManagement_Windows.Controls;

    partial class TaskCard
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
            this.pnlAccent = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.badgeStatus = new EmployeeManagement_Windows.Controls.StatusBadge();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblStartDateLabel = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblDueDateLabel = new System.Windows.Forms.Label();
            this.lblDueDate = new System.Windows.Forms.Label();
            this.pnlSeparator = new System.Windows.Forms.Panel();
            this.pnlAvatars = new System.Windows.Forms.Panel();
            this.cardBase.SuspendLayout();
            this.SuspendLayout();
            // 
            // cardBase
            // 
            this.cardBase.BackColor = System.Drawing.Color.Transparent;
            this.cardBase.BorderRadius = 15;
            this.cardBase.CardColor = System.Drawing.Color.White;
            this.cardBase.Controls.Add(this.pnlAvatars);
            this.cardBase.Controls.Add(this.pnlSeparator);
            this.cardBase.Controls.Add(this.lblDueDate);
            this.cardBase.Controls.Add(this.lblDueDateLabel);
            this.cardBase.Controls.Add(this.lblStartDate);
            this.cardBase.Controls.Add(this.lblStartDateLabel);
            this.cardBase.Controls.Add(this.lblDescription);
            this.cardBase.Controls.Add(this.badgeStatus);
            this.cardBase.Controls.Add(this.lblTitle);
            this.cardBase.Controls.Add(this.pnlAccent);
            this.cardBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardBase.Location = new System.Drawing.Point(8, 8);
            this.cardBase.Name = "cardBase";
            this.cardBase.Padding = new System.Windows.Forms.Padding(12);
            this.cardBase.ShadowSize = 4;
            this.cardBase.Size = new System.Drawing.Size(304, 194);
            this.cardBase.TabIndex = 0;
            this.cardBase.Click += new System.EventHandler(this.cardBase_Click);
            // 
            // pnlAccent
            // 
            this.pnlAccent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(95)))), ((int)(((byte)(228)))));
            this.pnlAccent.Location = new System.Drawing.Point(0, 15);
            this.pnlAccent.Name = "pnlAccent";
            this.pnlAccent.Size = new System.Drawing.Size(4, 160);
            this.pnlAccent.TabIndex = 4;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.lblTitle.Location = new System.Drawing.Point(20, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(51, 20);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Task 1";
            this.lblTitle.Click += new System.EventHandler(this.cardBase_Click);
            // 
            // badgeStatus
            // 
            this.badgeStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.badgeStatus.BadgeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(243)))), ((int)(((byte)(199)))));
            this.badgeStatus.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.badgeStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(64)))), ((int)(((byte)(14)))));
            this.badgeStatus.Location = new System.Drawing.Point(205, 15);
            this.badgeStatus.Name = "badgeStatus";
            this.badgeStatus.Size = new System.Drawing.Size(85, 22);
            this.badgeStatus.TabIndex = 3;
            this.badgeStatus.Text = "IN PROGRESS";
            this.badgeStatus.Click += new System.EventHandler(this.cardBase_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblDescription.Location = new System.Drawing.Point(20, 50);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(270, 35);
            this.lblDescription.TabIndex = 5;
            this.lblDescription.Text = "Task 1 is very important complete it within time";
            this.lblDescription.Click += new System.EventHandler(this.cardBase_Click);
            // 
            // lblStartDateLabel
            // 
            this.lblStartDateLabel.AutoSize = true;
            this.lblStartDateLabel.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblStartDateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblStartDateLabel.Location = new System.Drawing.Point(20, 95);
            this.lblStartDateLabel.Name = "lblStartDateLabel";
            this.lblStartDateLabel.Size = new System.Drawing.Size(58, 15);
            this.lblStartDateLabel.TabIndex = 6;
            this.lblStartDateLabel.Text = "Start Date";
            this.lblStartDateLabel.Click += new System.EventHandler(this.cardBase_Click);
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblStartDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.lblStartDate.Location = new System.Drawing.Point(20, 115);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(90, 19);
            this.lblStartDate.TabIndex = 7;
            this.lblStartDate.Text = "01 Jan, 1900";
            this.lblStartDate.Click += new System.EventHandler(this.cardBase_Click);
            // 
            // lblDueDateLabel
            // 
            this.lblDueDateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDueDateLabel.AutoSize = true;
            this.lblDueDateLabel.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblDueDateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblDueDateLabel.Location = new System.Drawing.Point(235, 95);
            this.lblDueDateLabel.Name = "lblDueDateLabel";
            this.lblDueDateLabel.Size = new System.Drawing.Size(55, 15);
            this.lblDueDateLabel.TabIndex = 8;
            this.lblDueDateLabel.Text = "Due Date";
            this.lblDueDateLabel.Click += new System.EventHandler(this.cardBase_Click);
            // 
            // lblDueDate
            // 
            this.lblDueDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDueDate.AutoSize = true;
            this.lblDueDate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblDueDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.lblDueDate.Location = new System.Drawing.Point(200, 115);
            this.lblDueDate.Name = "lblDueDate";
            this.lblDueDate.Size = new System.Drawing.Size(90, 19);
            this.lblDueDate.TabIndex = 9;
            this.lblDueDate.Text = "30 Apr, 2026";
            this.lblDueDate.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblDueDate.Click += new System.EventHandler(this.cardBase_Click);
            // 
            // pnlSeparator
            // 
            this.pnlSeparator.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSeparator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.pnlSeparator.Location = new System.Drawing.Point(20, 145);
            this.pnlSeparator.Name = "pnlSeparator";
            this.pnlSeparator.Size = new System.Drawing.Size(270, 1);
            this.pnlSeparator.TabIndex = 10;
            // 
            // pnlAvatars
            // 
            this.pnlAvatars.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlAvatars.Location = new System.Drawing.Point(20, 155);
            this.pnlAvatars.Name = "pnlAvatars";
            this.pnlAvatars.Size = new System.Drawing.Size(270, 30);
            this.pnlAvatars.TabIndex = 11;
            this.pnlAvatars.Click += new System.EventHandler(this.cardBase_Click);
            // 
            // TaskCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.cardBase);
            this.Name = "TaskCard";
            this.Padding = new System.Windows.Forms.Padding(8);
            this.Size = new System.Drawing.Size(320, 210);
            this.cardBase.ResumeLayout(false);
            this.cardBase.PerformLayout();
            this.ResumeLayout(false);

        }

        private EmployeeManagement_Windows.Controls.CardPanel cardBase;
        private System.Windows.Forms.Panel pnlAccent;
        private System.Windows.Forms.Label lblTitle;
        private EmployeeManagement_Windows.Controls.StatusBadge badgeStatus;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblStartDateLabel;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblDueDateLabel;
        private System.Windows.Forms.Label lblDueDate;
        private System.Windows.Forms.Panel pnlSeparator;
        private System.Windows.Forms.Panel pnlAvatars;
    }
}
