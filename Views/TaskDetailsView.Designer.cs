namespace EmployeeManagement_Windows.Views
{
    using System.Windows.Forms;
    using EmployeeManagement_Windows.Controls;

    partial class TaskDetailsView
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
            this.pnlHeader = new CardPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.badgeStatus = new StatusBadge();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.btnSaveStatus = new EmployeeManagement_Windows.Controls.ModernButton();
            this.pnlComments = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlInput = new CardPanel();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSend = new ModernButton();
            this.lblActivityTitle = new System.Windows.Forms.Label();
            this.txtHours = new EmployeeManagement_Windows.Controls.ModernTextBox();
            this.txtMinutes = new EmployeeManagement_Windows.Controls.ModernTextBox();
            this.pnlHeader.SuspendLayout();
            this.pnlInput.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.Transparent;
            this.pnlHeader.BorderRadius = 15;
            this.pnlHeader.CardColor = System.Drawing.Color.White;
            this.pnlHeader.Controls.Add(this.btnSaveStatus);
            this.pnlHeader.Controls.Add(this.badgeStatus);
            this.pnlHeader.Controls.Add(this.cmbStatus);
            this.pnlHeader.Controls.Add(this.lblDescription);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(20, 20);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Padding = new System.Windows.Forms.Padding(20);
            this.pnlHeader.ShadowSize = 5;
            this.pnlHeader.Size = new System.Drawing.Size(960, 120);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.lblTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(124, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Task Title";
            // 
            // lblDescription
            // 
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
            this.lblDescription.Location = new System.Drawing.Point(22, 60);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(700, 40);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = "Detailed description of the task goes here...";
            // 
            // cmbStatus
            // 
            this.cmbStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "TO DO",
            "IN PROGRESS",
            "COMPLETED"});
            this.cmbStatus.Location = new System.Drawing.Point(680, 25);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(120, 23);
            this.cmbStatus.TabIndex = 2;
            this.cmbStatus.SelectedIndexChanged += new System.EventHandler(this.cmbStatus_SelectedIndexChanged);
            // 
            // badgeStatus
            // 
            this.badgeStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.badgeStatus.BadgeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.badgeStatus.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.badgeStatus.ForeColor = System.Drawing.Color.White;
            this.badgeStatus.Location = new System.Drawing.Point(820, 23);
            this.badgeStatus.Name = "badgeStatus";
            this.badgeStatus.Size = new System.Drawing.Size(110, 28);
            this.badgeStatus.TabIndex = 3;
            this.badgeStatus.Text = "IN PROGRESS";
            // 
            // btnSaveStatus
            // 
            this.btnSaveStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveStatus.BackColor = System.Drawing.Color.Transparent;
            this.btnSaveStatus.BorderRadius = 8;
            this.btnSaveStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveStatus.FlatAppearance.BorderSize = 0;
            this.btnSaveStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveStatus.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.btnSaveStatus.ForeColor = System.Drawing.Color.White;
            this.btnSaveStatus.GradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(95)))), ((int)(((byte)(228)))));
            this.btnSaveStatus.GradientStart = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(95)))), ((int)(((byte)(228)))));
            this.btnSaveStatus.Location = new System.Drawing.Point(600, 23);
            this.btnSaveStatus.Name = "btnSaveStatus";
            this.btnSaveStatus.Size = new System.Drawing.Size(70, 28);
            this.btnSaveStatus.TabIndex = 4;
            this.btnSaveStatus.Text = "SAVE";
            this.btnSaveStatus.Visible = false;
            this.btnSaveStatus.Click += new System.EventHandler(this.btnSaveStatus_Click);
            // 
            // pnlComments
            // 
            this.pnlComments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlComments.AutoScroll = true;
            this.pnlComments.BackColor = System.Drawing.Color.Transparent;
            this.pnlComments.Location = new System.Drawing.Point(20, 180);
            this.pnlComments.Name = "pnlComments";
            this.pnlComments.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.pnlComments.Size = new System.Drawing.Size(960, 380);
            this.pnlComments.TabIndex = 1;
            // 
            // pnlInput
            // 
            this.pnlInput.BackColor = System.Drawing.Color.Transparent;
            this.pnlInput.BorderRadius = 15;
            this.pnlInput.CardColor = System.Drawing.Color.White;
            this.pnlInput.Controls.Add(this.txtMinutes);
            this.pnlInput.Controls.Add(this.txtHours);
            this.pnlInput.Controls.Add(this.btnSend);
            this.pnlInput.Controls.Add(this.txtComment);
            this.pnlInput.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlInput.Location = new System.Drawing.Point(20, 560);
            this.pnlInput.Name = "pnlInput";
            this.pnlInput.Padding = new System.Windows.Forms.Padding(10);
            this.pnlInput.ShadowSize = 5;
            this.pnlInput.Size = new System.Drawing.Size(960, 100);
            this.pnlInput.TabIndex = 2;
            // 
            // txtHours
            // 
            this.txtHours.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtHours.BackColor = System.Drawing.Color.White;
            this.txtHours.LabelText = "";
            this.txtHours.Location = new System.Drawing.Point(20, 60);
            this.txtHours.MaxValue = 24;
            this.txtHours.Multiline = false;
            this.txtHours.Name = "txtHours";
            this.txtHours.NumericOnly = true;
            this.txtHours.PasswordChar = false;
            this.txtHours.PasswordCharValue = '\0';
            this.txtHours.PlaceholderText = "Hours";
            this.txtHours.Size = new System.Drawing.Size(120, 30);
            this.txtHours.TabIndex = 2;
            // 
            // txtMinutes
            // 
            this.txtMinutes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtMinutes.BackColor = System.Drawing.Color.White;
            this.txtMinutes.LabelText = "";
            this.txtMinutes.Location = new System.Drawing.Point(150, 60);
            this.txtMinutes.MaxValue = 60;
            this.txtMinutes.Multiline = false;
            this.txtMinutes.Name = "txtMinutes";
            this.txtMinutes.NumericOnly = true;
            this.txtMinutes.PasswordChar = false;
            this.txtMinutes.PasswordCharValue = '\0';
            this.txtMinutes.PlaceholderText = "Minutes";
            this.txtMinutes.Size = new System.Drawing.Size(120, 30);
            this.txtMinutes.TabIndex = 3;
            // 
            // txtComment
            // 
            this.txtComment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtComment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.txtComment.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtComment.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtComment.Location = new System.Drawing.Point(20, 20);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(780, 40);
            this.txtComment.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(45)))), ((int)(((byte)(226)))));
            this.btnBack.Location = new System.Drawing.Point(5, 5);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(30, 30);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "←";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSend.BackColor = System.Drawing.Color.Transparent;
            this.btnSend.BorderRadius = 12;
            this.btnSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSend.FlatAppearance.BorderSize = 0;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSend.ForeColor = System.Drawing.Color.White;
            this.btnSend.GradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(0)))), ((int)(((byte)(224)))));
            this.btnSend.GradientStart = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(45)))), ((int)(((byte)(226)))));
            this.btnSend.Location = new System.Drawing.Point(820, 15);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(120, 50);
            this.btnSend.TabIndex = 1;
            this.btnSend.Text = "SEND";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // lblActivityTitle
            // 
            this.lblActivityTitle.AutoSize = true;
            this.lblActivityTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblActivityTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.lblActivityTitle.Location = new System.Drawing.Point(25, 155);
            this.lblActivityTitle.Name = "lblActivityTitle";
            this.lblActivityTitle.Size = new System.Drawing.Size(71, 21);
            this.lblActivityTitle.TabIndex = 3;
            this.lblActivityTitle.Text = "Activity";
            // 
            // TaskDetailsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblActivityTitle);
            this.Controls.Add(this.pnlInput);
            this.Controls.Add(this.pnlComments);
            this.Controls.Add(this.pnlHeader);
            this.Name = "TaskDetailsView";
            this.Padding = new Padding(20);
            this.Size = new System.Drawing.Size(1000, 680);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlInput.ResumeLayout(false);
            this.pnlInput.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private CardPanel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.ComboBox cmbStatus;
        private StatusBadge badgeStatus;
        private ModernButton btnSaveStatus;
        private System.Windows.Forms.FlowLayoutPanel pnlComments;
        private CardPanel pnlInput;
        private System.Windows.Forms.TextBox txtComment;
        private ModernButton btnSend;
        private System.Windows.Forms.Label lblActivityTitle;
        private System.Windows.Forms.Button btnBack;
        private EmployeeManagement_Windows.Controls.ModernTextBox txtHours;
        private EmployeeManagement_Windows.Controls.ModernTextBox txtMinutes;
    }
}
