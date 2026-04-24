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
            this.pnlHeader = new EmployeeManagement_Windows.Controls.CardPanel();
            this.btnToggleComments = new EmployeeManagement_Windows.Controls.ModernButton();
            this.btnBack = new EmployeeManagement_Windows.Controls.ModernButton();
            this.btnSaveStatus = new EmployeeManagement_Windows.Controls.ModernButton();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.lblStatusTitle = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblDescriptionTitle = new System.Windows.Forms.Label();
            this.flowAssignedTo = new System.Windows.Forms.FlowLayoutPanel();
            this.lblAssignedToTitle = new System.Windows.Forms.Label();
            this.lblDueDateValue = new System.Windows.Forms.Label();
            this.lblDueDateTitle = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblTitleTitle = new System.Windows.Forms.Label();
            this.pnlCommentsContainer = new System.Windows.Forms.Panel();
            this.pnlComments = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlInput = new EmployeeManagement_Windows.Controls.CardPanel();
            this.lblCharCount = new System.Windows.Forms.Label();
            this.txtHours = new EmployeeManagement_Windows.Controls.ModernTextBox();
            this.btnSend = new EmployeeManagement_Windows.Controls.ModernButton();
            this.txtComment = new EmployeeManagement_Windows.Controls.ModernTextBox();
            this.txtMinutes = new EmployeeManagement_Windows.Controls.ModernTextBox();
            this.pnlHeader.SuspendLayout();
            this.pnlCommentsContainer.SuspendLayout();
            this.pnlInput.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.Transparent;
            this.pnlHeader.BorderRadius = 15;
            this.pnlHeader.CardColor = System.Drawing.Color.White;
            this.pnlHeader.Controls.Add(this.btnToggleComments);
            this.pnlHeader.Controls.Add(this.btnBack);
            this.pnlHeader.Controls.Add(this.btnSaveStatus);
            this.pnlHeader.Controls.Add(this.cmbStatus);
            this.pnlHeader.Controls.Add(this.lblStatusTitle);
            this.pnlHeader.Controls.Add(this.lblDescription);
            this.pnlHeader.Controls.Add(this.lblDescriptionTitle);
            this.pnlHeader.Controls.Add(this.flowAssignedTo);
            this.pnlHeader.Controls.Add(this.lblAssignedToTitle);
            this.pnlHeader.Controls.Add(this.lblDueDateValue);
            this.pnlHeader.Controls.Add(this.lblDueDateTitle);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.lblTitleTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Padding = new System.Windows.Forms.Padding(20);
            this.pnlHeader.ShadowSize = 4;
            this.pnlHeader.Size = new System.Drawing.Size(960, 280);
            this.pnlHeader.TabIndex = 0;
            // 
            // btnToggleComments
            // 
            this.btnToggleComments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.btnToggleComments.BorderRadius = 8;
            this.btnToggleComments.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnToggleComments.FlatAppearance.BorderSize = 0;
            this.btnToggleComments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToggleComments.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F);
            this.btnToggleComments.ForeColor = System.Drawing.Color.White;
            this.btnToggleComments.GradientEnd = System.Drawing.Color.Empty;
            this.btnToggleComments.GradientStart = System.Drawing.Color.Empty;
            this.btnToggleComments.Location = new System.Drawing.Point(205, 225);
            this.btnToggleComments.Name = "btnToggleComments";
            this.btnToggleComments.Size = new System.Drawing.Size(100, 35);
            this.btnToggleComments.Style = EmployeeManagement_Windows.Controls.ButtonStyle.Primary;
            this.btnToggleComments.TabIndex = 12;
            this.btnToggleComments.Text = "Comments";
            this.btnToggleComments.UseVisualStyleBackColor = false;
            this.btnToggleComments.Click += new System.EventHandler(this.btnToggleComments_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.White;
            this.btnBack.BorderRadius = 8;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F);
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.btnBack.GradientEnd = System.Drawing.Color.Empty;
            this.btnBack.GradientStart = System.Drawing.Color.Empty;
            this.btnBack.Location = new System.Drawing.Point(135, 225);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(60, 35);
            this.btnBack.Style = EmployeeManagement_Windows.Controls.ButtonStyle.Outline;
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSaveStatus
            // 
            this.btnSaveStatus.BackColor = System.Drawing.Color.White;
            this.btnSaveStatus.BorderRadius = 8;
            this.btnSaveStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveStatus.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(95)))), ((int)(((byte)(228)))));
            this.btnSaveStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F);
            this.btnSaveStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(95)))), ((int)(((byte)(228)))));
            this.btnSaveStatus.GradientEnd = System.Drawing.Color.Empty;
            this.btnSaveStatus.GradientStart = System.Drawing.Color.Empty;
            this.btnSaveStatus.Location = new System.Drawing.Point(25, 225);
            this.btnSaveStatus.Name = "btnSaveStatus";
            this.btnSaveStatus.Size = new System.Drawing.Size(100, 35);
            this.btnSaveStatus.Style = EmployeeManagement_Windows.Controls.ButtonStyle.Outline;
            this.btnSaveStatus.TabIndex = 10;
            this.btnSaveStatus.Text = "Save Status";
            this.btnSaveStatus.UseVisualStyleBackColor = false;
            this.btnSaveStatus.Visible = false;
            this.btnSaveStatus.Click += new System.EventHandler(this.btnSaveStatus_Click);
            // 
            // cmbStatus
            // 
            this.cmbStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(243)))), ((int)(((byte)(199)))));
            this.cmbStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbStatus.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.ItemHeight = 34;
            this.cmbStatus.Items.AddRange(new object[] {
            "Assigned",
            "In Progress",
            "Completed"});
            this.cmbStatus.Location = new System.Drawing.Point(25, 170);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(200, 40);
            this.cmbStatus.TabIndex = 9;
            this.cmbStatus.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cmbStatus_DrawItem);
            this.cmbStatus.SelectedIndexChanged += new System.EventHandler(this.cmbStatus_SelectedIndexChanged);
            // 
            // lblStatusTitle
            // 
            this.lblStatusTitle.AutoSize = true;
            this.lblStatusTitle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblStatusTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.lblStatusTitle.Location = new System.Drawing.Point(25, 145);
            this.lblStatusTitle.Name = "lblStatusTitle";
            this.lblStatusTitle.Size = new System.Drawing.Size(46, 17);
            this.lblStatusTitle.TabIndex = 8;
            this.lblStatusTitle.Text = "Status";
            // 
            // lblDescription
            // 
            this.lblDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.lblDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblDescription.Location = new System.Drawing.Point(25, 105);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(910, 30);
            this.lblDescription.TabIndex = 7;
            this.lblDescription.Text = "Task 1 is very important complete it within time";
            // 
            // lblDescriptionTitle
            // 
            this.lblDescriptionTitle.AutoSize = true;
            this.lblDescriptionTitle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblDescriptionTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.lblDescriptionTitle.Location = new System.Drawing.Point(25, 85);
            this.lblDescriptionTitle.Name = "lblDescriptionTitle";
            this.lblDescriptionTitle.Size = new System.Drawing.Size(79, 17);
            this.lblDescriptionTitle.TabIndex = 6;
            this.lblDescriptionTitle.Text = "Description";
            // 
            // flowAssignedTo
            // 
            this.flowAssignedTo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowAssignedTo.Location = new System.Drawing.Point(620, 45);
            this.flowAssignedTo.Name = "flowAssignedTo";
            this.flowAssignedTo.Size = new System.Drawing.Size(310, 45);
            this.flowAssignedTo.TabIndex = 5;
            // 
            // lblAssignedToTitle
            // 
            this.lblAssignedToTitle.AutoSize = true;
            this.lblAssignedToTitle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblAssignedToTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.lblAssignedToTitle.Location = new System.Drawing.Point(620, 25);
            this.lblAssignedToTitle.Name = "lblAssignedToTitle";
            this.lblAssignedToTitle.Size = new System.Drawing.Size(83, 17);
            this.lblAssignedToTitle.TabIndex = 4;
            this.lblAssignedToTitle.Text = "Assigned To";
            // 
            // lblDueDateValue
            // 
            this.lblDueDateValue.AutoSize = true;
            this.lblDueDateValue.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.lblDueDateValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblDueDateValue.Location = new System.Drawing.Point(350, 45);
            this.lblDueDateValue.Name = "lblDueDateValue";
            this.lblDueDateValue.Size = new System.Drawing.Size(87, 19);
            this.lblDueDateValue.TabIndex = 3;
            this.lblDueDateValue.Text = "16 Apr 2026";
            // 
            // lblDueDateTitle
            // 
            this.lblDueDateTitle.AutoSize = true;
            this.lblDueDateTitle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblDueDateTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.lblDueDateTitle.Location = new System.Drawing.Point(350, 25);
            this.lblDueDateTitle.Name = "lblDueDateTitle";
            this.lblDueDateTitle.Size = new System.Drawing.Size(66, 17);
            this.lblDueDateTitle.TabIndex = 2;
            this.lblDueDateTitle.Text = "Due Date";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblTitle.Location = new System.Drawing.Point(25, 45);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(46, 19);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Task 1";
            // 
            // lblTitleTitle
            // 
            this.lblTitleTitle.AutoSize = true;
            this.lblTitleTitle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblTitleTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.lblTitleTitle.Location = new System.Drawing.Point(25, 25);
            this.lblTitleTitle.Name = "lblTitleTitle";
            this.lblTitleTitle.Size = new System.Drawing.Size(36, 17);
            this.lblTitleTitle.TabIndex = 0;
            this.lblTitleTitle.Text = "Title";
            // 
            // pnlCommentsContainer
            // 
            this.pnlCommentsContainer.AutoScroll = true;
            this.pnlCommentsContainer.Controls.Add(this.pnlComments);
            this.pnlCommentsContainer.Controls.Add(this.pnlHeader);
            this.pnlCommentsContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCommentsContainer.Location = new System.Drawing.Point(20, 20);
            this.pnlCommentsContainer.Name = "pnlCommentsContainer";
            this.pnlCommentsContainer.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.pnlCommentsContainer.Size = new System.Drawing.Size(960, 460);
            this.pnlCommentsContainer.TabIndex = 1;
            // 
            // pnlComments
            // 
            this.pnlComments.AutoSize = true;
            this.pnlComments.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlComments.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlComments.Location = new System.Drawing.Point(0, 280);
            this.pnlComments.Name = "pnlComments";
            this.pnlComments.Padding = new System.Windows.Forms.Padding(0, 20, 10, 20);
            this.pnlComments.Size = new System.Drawing.Size(960, 40);
            this.pnlComments.TabIndex = 0;
            this.pnlComments.Visible = false;
            // 
            // pnlInput
            // 
            this.pnlInput.BackColor = System.Drawing.Color.Transparent;
            this.pnlInput.BorderRadius = 15;
            this.pnlInput.CardColor = System.Drawing.Color.White;
            this.pnlInput.Controls.Add(this.lblCharCount);
            this.pnlInput.Controls.Add(this.txtMinutes);
            this.pnlInput.Controls.Add(this.txtHours);
            this.pnlInput.Controls.Add(this.btnSend);
            this.pnlInput.Controls.Add(this.txtComment);
            this.pnlInput.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlInput.Location = new System.Drawing.Point(20, 480);
            this.pnlInput.Name = "pnlInput";
            this.pnlInput.Padding = new System.Windows.Forms.Padding(15);
            this.pnlInput.ShadowSize = 3;
            this.pnlInput.Size = new System.Drawing.Size(960, 180);
            this.pnlInput.TabIndex = 2;
            this.pnlInput.Visible = false;
            // 
            // lblCharCount
            // 
            this.lblCharCount.AutoSize = true;
            this.lblCharCount.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblCharCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblCharCount.Location = new System.Drawing.Point(15, 105);
            this.lblCharCount.Name = "lblCharCount";
            this.lblCharCount.Size = new System.Drawing.Size(186, 13);
            this.lblCharCount.TabIndex = 4;
            this.lblCharCount.Text = "You can enter up to 500 characters.";
            // 
            // txtHours
            // 
            this.txtHours.BackColor = System.Drawing.Color.Transparent;
            this.txtHours.LabelText = "Hour";
            this.txtHours.Location = new System.Drawing.Point(15, 130);
            this.txtHours.MaxValue = 0;
            this.txtHours.Multiline = false;
            this.txtHours.Name = "txtHours";
            this.txtHours.NumericOnly = false;
            this.txtHours.PasswordChar = false;
            this.txtHours.PasswordCharValue = '\0';
            this.txtHours.PlaceholderText = "Hours";
            this.txtHours.Size = new System.Drawing.Size(250, 35);
            this.txtHours.TabIndex = 2;
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSend.BackColor = System.Drawing.Color.Transparent;
            this.btnSend.BorderRadius = 20;
            this.btnSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSend.FlatAppearance.BorderSize = 0;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnSend.ForeColor = System.Drawing.Color.White;
            this.btnSend.GradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(95)))), ((int)(((byte)(228)))));
            this.btnSend.GradientStart = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(95)))), ((int)(((byte)(228)))));
            this.btnSend.Location = new System.Drawing.Point(890, 35);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(40, 40);
            this.btnSend.Style = EmployeeManagement_Windows.Controls.ButtonStyle.Primary;
            this.btnSend.TabIndex = 1;
            this.btnSend.Text = "➤";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtComment
            // 
            this.txtComment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtComment.BackColor = System.Drawing.Color.Transparent;
            this.txtComment.LabelText = "";
            this.txtComment.Location = new System.Drawing.Point(15, 15);
            this.txtComment.MaxValue = 0;
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.NumericOnly = false;
            this.txtComment.PasswordChar = false;
            this.txtComment.PasswordCharValue = '\0';
            this.txtComment.PlaceholderText = "Type a New Message";
            this.txtComment.Size = new System.Drawing.Size(860, 80);
            this.txtComment.TabIndex = 0;
            // 
            // txtMinutes
            // 
            this.txtMinutes.BackColor = System.Drawing.Color.White;
            this.txtMinutes.LabelText = "Minutes";
            this.txtMinutes.Location = new System.Drawing.Point(280, 130);
            this.txtMinutes.MaxValue = 0;
            this.txtMinutes.Multiline = false;
            this.txtMinutes.Name = "txtMinutes";
            this.txtMinutes.NumericOnly = false;
            this.txtMinutes.PasswordChar = false;
            this.txtMinutes.PasswordCharValue = '\0';
            this.txtMinutes.PlaceholderText = "Minutes";
            this.txtMinutes.Size = new System.Drawing.Size(250, 35);
            this.txtMinutes.TabIndex = 3;
            this.txtMinutes.Load += new System.EventHandler(this.txtMinutes_Load);
            // 
            // TaskDetailsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.pnlCommentsContainer);
            this.Controls.Add(this.pnlInput);
            this.Name = "TaskDetailsView";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Size = new System.Drawing.Size(1000, 680);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlCommentsContainer.ResumeLayout(false);
            this.pnlCommentsContainer.PerformLayout();
            this.pnlInput.ResumeLayout(false);
            this.pnlInput.PerformLayout();
            this.ResumeLayout(false);

        }

        private EmployeeManagement_Windows.Controls.CardPanel pnlHeader;
        private System.Windows.Forms.Label lblTitleTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDueDateTitle;
        private System.Windows.Forms.Label lblDueDateValue;
        private System.Windows.Forms.Label lblAssignedToTitle;
        private System.Windows.Forms.FlowLayoutPanel flowAssignedTo;
        private System.Windows.Forms.Label lblDescriptionTitle;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblStatusTitle;
        private System.Windows.Forms.ComboBox cmbStatus;
        private EmployeeManagement_Windows.Controls.ModernButton btnSaveStatus;
        private EmployeeManagement_Windows.Controls.ModernButton btnBack;
        private EmployeeManagement_Windows.Controls.ModernButton btnToggleComments;
        private System.Windows.Forms.Panel pnlCommentsContainer;
        private System.Windows.Forms.FlowLayoutPanel pnlComments;
        private EmployeeManagement_Windows.Controls.CardPanel pnlInput;
        private EmployeeManagement_Windows.Controls.ModernTextBox txtComment;
        private EmployeeManagement_Windows.Controls.ModernButton btnSend;
        private EmployeeManagement_Windows.Controls.ModernTextBox txtHours;
        private System.Windows.Forms.Label lblCharCount;
        private ModernTextBox txtMinutes;
    }
}
