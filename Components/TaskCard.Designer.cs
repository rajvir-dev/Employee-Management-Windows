namespace EmployeeManagement_Windows.Components
{
    using EmployeeManagement_Windows.CustomControls;

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
            this.cardBase = new CardPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblPriority = new System.Windows.Forms.Label();
            this.lblDueDate = new System.Windows.Forms.Label();
            this.badgeStatus = new StatusBadge();
            this.cardBase.SuspendLayout();
            this.SuspendLayout();
            // 
            // cardBase
            // 
            this.cardBase.BackColor = System.Drawing.Color.Transparent;
            this.cardBase.BorderRadius = 12;
            this.cardBase.CardColor = System.Drawing.Color.White;
            this.cardBase.Controls.Add(this.badgeStatus);
            this.cardBase.Controls.Add(this.lblDueDate);
            this.cardBase.Controls.Add(this.lblPriority);
            this.cardBase.Controls.Add(this.lblTitle);
            this.cardBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardBase.Location = new System.Drawing.Point(5, 5);
            this.cardBase.Name = "cardBase";
            this.cardBase.Padding = new System.Windows.Forms.Padding(12);
            this.cardBase.ShadowSize = 3;
            this.cardBase.Size = new System.Drawing.Size(250, 110);
            this.cardBase.TabIndex = 0;
            this.cardBase.Click += new System.EventHandler(this.cardBase_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.lblTitle.Location = new System.Drawing.Point(12, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(220, 40);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Task Title Content";
            this.lblTitle.Click += new System.EventHandler(this.cardBase_Click);
            // 
            // lblPriority
            // 
            this.lblPriority.AutoSize = true;
            this.lblPriority.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblPriority.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(48)))), ((int)(((byte)(49)))));
            this.lblPriority.Location = new System.Drawing.Point(12, 55);
            this.lblPriority.Name = "lblPriority";
            this.lblPriority.Size = new System.Drawing.Size(35, 13);
            this.lblPriority.TabIndex = 1;
            this.lblPriority.Text = "HIGH";
            this.lblPriority.Click += new System.EventHandler(this.cardBase_Click);
            // 
            // lblDueDate
            // 
            this.lblDueDate.AutoSize = true;
            this.lblDueDate.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblDueDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(190)))), ((int)(((byte)(195)))));
            this.lblDueDate.Location = new System.Drawing.Point(12, 80);
            this.lblDueDate.Name = "lblDueDate";
            this.lblDueDate.Size = new System.Drawing.Size(73, 13);
            this.lblDueDate.TabIndex = 2;
            this.lblDueDate.Text = "Due: Apr 30";
            this.lblDueDate.Click += new System.EventHandler(this.cardBase_Click);
            // 
            // badgeStatus
            // 
            this.badgeStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.badgeStatus.BadgeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(92)))), ((int)(((byte)(231)))));
            this.badgeStatus.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold);
            this.badgeStatus.ForeColor = System.Drawing.Color.White;
            this.badgeStatus.Location = new System.Drawing.Point(155, 75);
            this.badgeStatus.Name = "badgeStatus";
            this.badgeStatus.Size = new System.Drawing.Size(80, 22);
            this.badgeStatus.TabIndex = 3;
            this.badgeStatus.Text = "STAFF";
            this.badgeStatus.Click += new System.EventHandler(this.cardBase_Click);
            // 
            // TaskCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.cardBase);
            this.Name = "TaskCard";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(260, 120);
            this.cardBase.ResumeLayout(false);
            this.cardBase.PerformLayout();
            this.ResumeLayout(false);

        }

        private CardPanel cardBase;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblPriority;
        private System.Windows.Forms.Label lblDueDate;
        private StatusBadge badgeStatus;
    }
}
