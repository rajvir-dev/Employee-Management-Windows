namespace EmployeeManagement_Windows.Components
{
    partial class LeaveItem
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
            this.lblType = new System.Windows.Forms.Label();
            this.lblDates = new System.Windows.Forms.Label();
            this.lblReason = new System.Windows.Forms.Label();
            this.badgeStatus = new EmployeeManagement_Windows.CustomControls.StatusBadge();
            this.btnEdit = new EmployeeManagement_Windows.CustomControls.ModernButton();
            this.pnlContainer = new EmployeeManagement_Windows.CustomControls.CardPanel();
            this.pnlContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblType.ForeColor = EmployeeManagement_Windows.Helpers.ThemeColors.TextPrimary;
            this.lblType.Location = new System.Drawing.Point(15, 15);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(113, 20);
            this.lblType.TabIndex = 0;
            this.lblType.Text = "Leave Request";
            // 
            // lblDates
            // 
            this.lblDates.AutoSize = true;
            this.lblDates.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.lblDates.ForeColor = EmployeeManagement_Windows.Helpers.ThemeColors.Primary;
            this.lblDates.Location = new System.Drawing.Point(15, 40);
            this.lblDates.Name = "lblDates";
            this.lblDates.Size = new System.Drawing.Size(127, 15);
            this.lblDates.TabIndex = 1;
            this.lblDates.Text = "Oct 20 - Oct 25, 2026";
            // 
            // lblReason
            // 
            this.lblReason.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblReason.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblReason.ForeColor = EmployeeManagement_Windows.Helpers.ThemeColors.TextSecondary;
            this.lblReason.Location = new System.Drawing.Point(15, 65);
            this.lblReason.Name = "lblReason";
            this.lblReason.Size = new System.Drawing.Size(550, 45);
            this.lblReason.TabIndex = 2;
            this.lblReason.Text = "Reason for leave goes here. This can be multiple lines if needed.";
            // 
            // badgeStatus
            // 
            this.badgeStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.badgeStatus.BadgeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(67)))));
            this.badgeStatus.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.badgeStatus.ForeColor = System.Drawing.Color.White;
            this.badgeStatus.Location = new System.Drawing.Point(580, 15);
            this.badgeStatus.Name = "badgeStatus";
            this.badgeStatus.Size = new System.Drawing.Size(90, 24);
            this.badgeStatus.TabIndex = 3;
            this.badgeStatus.Text = "PENDING";
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.BackColor = System.Drawing.Color.Transparent;
            this.btnEdit.BorderRadius = 8;
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.GradientEnd = EmployeeManagement_Windows.Helpers.ThemeColors.PrimaryDark;
            this.btnEdit.GradientStart = EmployeeManagement_Windows.Helpers.ThemeColors.Primary;
            this.btnEdit.Location = new System.Drawing.Point(580, 50);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(90, 30);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "EDIT";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // pnlContainer
            // 
            this.pnlContainer.BackColor = System.Drawing.Color.Transparent;
            this.pnlContainer.BorderRadius = 15;
            this.pnlContainer.CardColor = EmployeeManagement_Windows.Helpers.ThemeColors.Surface;
            this.pnlContainer.Controls.Add(this.btnEdit);
            this.pnlContainer.Controls.Add(this.badgeStatus);
            this.pnlContainer.Controls.Add(this.lblReason);
            this.pnlContainer.Controls.Add(this.lblDates);
            this.pnlContainer.Controls.Add(this.lblType);
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(5, 5);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Padding = new System.Windows.Forms.Padding(0);
            this.pnlContainer.ShadowSize = 5;
            this.pnlContainer.Size = new System.Drawing.Size(690, 115);
            this.pnlContainer.TabIndex = 0;
            // 
            // LeaveItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pnlContainer);
            this.Name = "LeaveItem";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(700, 125);
            this.pnlContainer.ResumeLayout(false);
            this.pnlContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblDates;
        private System.Windows.Forms.Label lblReason;
        private EmployeeManagement_Windows.CustomControls.StatusBadge badgeStatus;
        private EmployeeManagement_Windows.CustomControls.ModernButton btnEdit;
        private EmployeeManagement_Windows.CustomControls.CardPanel pnlContainer;
    }
}
