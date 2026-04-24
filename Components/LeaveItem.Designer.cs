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
            this.pnlContainer = new EmployeeManagement_Windows.Controls.CardPanel();
            this.avatar = new EmployeeManagement_Windows.Controls.AvatarCircle();
            this.badgeStatus = new EmployeeManagement_Windows.Controls.StatusBadge();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.lblEmployeeEmail = new System.Windows.Forms.Label();
            this.lblEmployeePhone = new System.Windows.Forms.Label();
            this.lblReason = new System.Windows.Forms.Label();
            this.lblLeaveDateLabel = new System.Windows.Forms.Label();
            this.lblDates = new System.Windows.Forms.Label();
            this.lblRequestedOnLabel = new System.Windows.Forms.Label();
            this.lblRequestedOn = new System.Windows.Forms.Label();
            this.btnViewDetails = new EmployeeManagement_Windows.Controls.ModernButton();
            this.btnEdit = new EmployeeManagement_Windows.Controls.ModernButton();
            this.btnDelete = new EmployeeManagement_Windows.Controls.ModernButton();
            this.pnlContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContainer
            // 
            this.pnlContainer.BackColor = System.Drawing.Color.Transparent;
            this.pnlContainer.BorderRadius = 15;
            this.pnlContainer.CardColor = System.Drawing.Color.White;
            this.pnlContainer.Controls.Add(this.btnDelete);
            this.pnlContainer.Controls.Add(this.btnEdit);
            this.pnlContainer.Controls.Add(this.btnViewDetails);
            this.pnlContainer.Controls.Add(this.lblRequestedOn);
            this.pnlContainer.Controls.Add(this.lblRequestedOnLabel);
            this.pnlContainer.Controls.Add(this.lblDates);
            this.pnlContainer.Controls.Add(this.lblLeaveDateLabel);
            this.pnlContainer.Controls.Add(this.lblReason);
            this.pnlContainer.Controls.Add(this.lblEmployeePhone);
            this.pnlContainer.Controls.Add(this.lblEmployeeEmail);
            this.pnlContainer.Controls.Add(this.lblEmployeeName);
            this.pnlContainer.Controls.Add(this.badgeStatus);
            this.pnlContainer.Controls.Add(this.avatar);
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(8, 8);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Padding = new System.Windows.Forms.Padding(15);
            this.pnlContainer.ShadowSize = 5;
            this.pnlContainer.Size = new System.Drawing.Size(334, 254);
            this.pnlContainer.TabIndex = 0;
            // 
            // avatar
            // 
            this.avatar.Location = new System.Drawing.Point(20, 20);
            this.avatar.Name = "avatar";
            this.avatar.Size = new System.Drawing.Size(55, 55);
            this.avatar.TabIndex = 0;
            this.avatar.TabStop = false;
            // 
            // badgeStatus
            // 
            this.badgeStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.badgeStatus.BadgeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(67)))));
            this.badgeStatus.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.badgeStatus.ForeColor = System.Drawing.Color.White;
            this.badgeStatus.Location = new System.Drawing.Point(245, 18);
            this.badgeStatus.Name = "badgeStatus";
            this.badgeStatus.Size = new System.Drawing.Size(70, 22);
            this.badgeStatus.TabIndex = 1;
            this.badgeStatus.Text = "PENDING";
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.AutoSize = true;
            this.lblEmployeeName.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblEmployeeName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.lblEmployeeName.Location = new System.Drawing.Point(85, 20);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(125, 19);
            this.lblEmployeeName.TabIndex = 2;
            this.lblEmployeeName.Text = "Vaibhav P Rathod";
            // 
            // lblEmployeeEmail
            // 
            this.lblEmployeeEmail.AutoSize = true;
            this.lblEmployeeEmail.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblEmployeeEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.lblEmployeeEmail.Location = new System.Drawing.Point(85, 41);
            this.lblEmployeeEmail.Name = "lblEmployeeEmail";
            this.lblEmployeeEmail.Size = new System.Drawing.Size(91, 15);
            this.lblEmployeeEmail.TabIndex = 3;
            this.lblEmployeeEmail.Text = "user@gmail.com";
            // 
            // lblEmployeePhone
            // 
            this.lblEmployeePhone.AutoSize = true;
            this.lblEmployeePhone.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblEmployeePhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.lblEmployeePhone.Location = new System.Drawing.Point(85, 58);
            this.lblEmployeePhone.Name = "lblEmployeePhone";
            this.lblEmployeePhone.Size = new System.Drawing.Size(73, 15);
            this.lblEmployeePhone.TabIndex = 4;
            this.lblEmployeePhone.Text = "8128599587";
            // 
            // lblReason
            // 
            this.lblReason.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblReason.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblReason.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(84)))), ((int)(((byte)(96)))));
            this.lblReason.Location = new System.Drawing.Point(20, 95);
            this.lblReason.Name = "lblReason";
            this.lblReason.Size = new System.Drawing.Size(294, 35);
            this.lblReason.TabIndex = 5;
            this.lblReason.Text = "Description: I want leave on next monday for some personal work.";
            // 
            // lblLeaveDateLabel
            // 
            this.lblLeaveDateLabel.AutoSize = true;
            this.lblLeaveDateLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblLeaveDateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.lblLeaveDateLabel.Location = new System.Drawing.Point(20, 135);
            this.lblLeaveDateLabel.Name = "lblLeaveDateLabel";
            this.lblLeaveDateLabel.Size = new System.Drawing.Size(73, 15);
            this.lblLeaveDateLabel.TabIndex = 6;
            this.lblLeaveDateLabel.Text = "Leave Date:";
            // 
            // lblDates
            // 
            this.lblDates.AutoSize = true;
            this.lblDates.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDates.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.lblDates.Location = new System.Drawing.Point(95, 135);
            this.lblDates.Name = "lblDates";
            this.lblDates.Size = new System.Drawing.Size(75, 15);
            this.lblDates.TabIndex = 7;
            this.lblDates.Text = "20 Apr 2026";
            // 
            // lblRequestedOnLabel
            // 
            this.lblRequestedOnLabel.AutoSize = true;
            this.lblRequestedOnLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblRequestedOnLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.lblRequestedOnLabel.Location = new System.Drawing.Point(20, 155);
            this.lblRequestedOnLabel.Name = "lblRequestedOnLabel";
            this.lblRequestedOnLabel.Size = new System.Drawing.Size(87, 15);
            this.lblRequestedOnLabel.TabIndex = 8;
            this.lblRequestedOnLabel.Text = "Requested On:";
            // 
            // lblRequestedOn
            // 
            this.lblRequestedOn.AutoSize = true;
            this.lblRequestedOn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblRequestedOn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.lblRequestedOn.Location = new System.Drawing.Point(110, 155);
            this.lblRequestedOn.Name = "lblRequestedOn";
            this.lblRequestedOn.Size = new System.Drawing.Size(75, 15);
            this.lblRequestedOn.TabIndex = 9;
            this.lblRequestedOn.Text = "13 Apr 2026";
            // 
            // btnViewDetails
            // 
            this.btnViewDetails.BackColor = System.Drawing.Color.Transparent;
            this.btnViewDetails.BorderRadius = 5;
            this.btnViewDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewDetails.FlatAppearance.BorderSize = 1;
            this.btnViewDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewDetails.Font = new System.Drawing.Font("Segoe UI Semibold", 8F);
            this.btnViewDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(103)))), ((int)(((byte)(239)))));
            this.btnViewDetails.GradientEnd = System.Drawing.Color.White;
            this.btnViewDetails.GradientStart = System.Drawing.Color.White;
            this.btnViewDetails.Location = new System.Drawing.Point(20, 195);
            this.btnViewDetails.Name = "btnViewDetails";
            this.btnViewDetails.Size = new System.Drawing.Size(95, 32);
            this.btnViewDetails.TabIndex = 10;
            this.btnViewDetails.Text = "View Details";
            this.btnViewDetails.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Transparent;
            this.btnEdit.BorderRadius = 5;
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI Semibold", 8F);
            this.btnEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.btnEdit.GradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(190)))), ((int)(((byte)(118)))));
            this.btnEdit.GradientStart = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(202)))), ((int)(((byte)(36)))));
            this.btnEdit.Location = new System.Drawing.Point(125, 195);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(55, 32);
            this.btnEdit.TabIndex = 11;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.BorderRadius = 5;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 8F);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.GradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(77)))), ((int)(((byte)(75)))));
            this.btnDelete.GradientStart = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(121)))), ((int)(((byte)(121)))));
            this.btnDelete.Location = new System.Drawing.Point(190, 195);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(70, 32);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // LeaveItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pnlContainer);
            this.Name = "LeaveItem";
            this.Padding = new System.Windows.Forms.Padding(8);
            this.Size = new System.Drawing.Size(350, 270);
            this.pnlContainer.ResumeLayout(false);
            this.pnlContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        private EmployeeManagement_Windows.Controls.CardPanel pnlContainer;
        private EmployeeManagement_Windows.Controls.AvatarCircle avatar;
        private EmployeeManagement_Windows.Controls.StatusBadge badgeStatus;
        private System.Windows.Forms.Label lblEmployeeName;
        private System.Windows.Forms.Label lblEmployeeEmail;
        private System.Windows.Forms.Label lblEmployeePhone;
        private System.Windows.Forms.Label lblReason;
        private System.Windows.Forms.Label lblLeaveDateLabel;
        private System.Windows.Forms.Label lblDates;
        private System.Windows.Forms.Label lblRequestedOnLabel;
        private System.Windows.Forms.Label lblRequestedOn;
        private EmployeeManagement_Windows.Controls.ModernButton btnViewDetails;
        private EmployeeManagement_Windows.Controls.ModernButton btnEdit;
        private EmployeeManagement_Windows.Controls.ModernButton btnDelete;
    }
}
