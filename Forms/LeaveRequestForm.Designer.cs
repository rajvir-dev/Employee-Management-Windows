namespace EmployeeManagement_Windows.Forms
{
    partial class LeaveRequestForm
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
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblStart = new System.Windows.Forms.Label();
            this.dtpStart = new EmployeeManagement_Windows.Controls.ModernDatePicker();
            this.lblEnd = new System.Windows.Forms.Label();
            this.dtpEnd = new EmployeeManagement_Windows.Controls.ModernDatePicker();
            this.lblReason = new System.Windows.Forms.Label();
            this.txtReason = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblLeaveType = new System.Windows.Forms.Label();
            this.cmbLeaveType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.ForeColor = EmployeeManagement_Windows.Helpers.ThemeColors.TextPrimary;
            this.lblHeader.Location = new System.Drawing.Point(20, 20);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(155, 30);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Request Leave";
            // 
            // lblLeaveType
            // 
            this.lblLeaveType.AutoSize = true;
            this.lblLeaveType.ForeColor = EmployeeManagement_Windows.Helpers.ThemeColors.TextSecondary;
            this.lblLeaveType.Location = new System.Drawing.Point(25, 70);
            this.lblLeaveType.Name = "lblLeaveType";
            this.lblLeaveType.Size = new System.Drawing.Size(64, 13);
            this.lblLeaveType.TabIndex = 9;
            this.lblLeaveType.Text = "Leave Type";
            // 
            // cmbLeaveType
            // 
            this.cmbLeaveType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLeaveType.FormattingEnabled = true;
            this.cmbLeaveType.Items.AddRange(new object[] {
            "Vacation",
            "Sick",
            "Other"});
            this.cmbLeaveType.Location = new System.Drawing.Point(25, 90);
            this.cmbLeaveType.Name = "cmbLeaveType";
            this.cmbLeaveType.Size = new System.Drawing.Size(350, 21);
            this.cmbLeaveType.TabIndex = 10;
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.ForeColor = EmployeeManagement_Windows.Helpers.ThemeColors.TextSecondary;
            this.lblStart.Location = new System.Drawing.Point(25, 130);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(55, 13);
            this.lblStart.TabIndex = 1;
            this.lblStart.Text = "Start Date";
            // 
            // dtpStart
            // 
            this.dtpStart.Location = new System.Drawing.Point(25, 150);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(160, 40);
            this.dtpStart.TabIndex = 2;
            this.dtpStart.Value = System.DateTime.Today;
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.ForeColor = EmployeeManagement_Windows.Helpers.ThemeColors.TextSecondary;
            this.lblEnd.Location = new System.Drawing.Point(215, 130);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(52, 13);
            this.lblEnd.TabIndex = 3;
            this.lblEnd.Text = "End Date";
            // 
            // dtpEnd
            // 
            this.dtpEnd.Location = new System.Drawing.Point(215, 150);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(160, 40);
            this.dtpEnd.TabIndex = 4;
            this.dtpEnd.Value = System.DateTime.Today;
            // 
            // lblReason
            // 
            this.lblReason.AutoSize = true;
            this.lblReason.ForeColor = EmployeeManagement_Windows.Helpers.ThemeColors.TextSecondary;
            this.lblReason.Location = new System.Drawing.Point(25, 190);
            this.lblReason.Name = "lblReason";
            this.lblReason.Size = new System.Drawing.Size(44, 13);
            this.lblReason.TabIndex = 5;
            this.lblReason.Text = "Reason";
            // 
            // txtReason
            // 
            this.txtReason.BackColor = EmployeeManagement_Windows.Helpers.ThemeColors.Surface;
            this.txtReason.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReason.ForeColor = EmployeeManagement_Windows.Helpers.ThemeColors.TextPrimary;
            this.txtReason.Location = new System.Drawing.Point(25, 210);
            this.txtReason.Multiline = true;
            this.txtReason.Name = "txtReason";
            this.txtReason.Size = new System.Drawing.Size(350, 80);
            this.txtReason.TabIndex = 6;
            // 
            // btnSubmit
            // 
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSubmit.Location = new System.Drawing.Point(275, 310);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(100, 35);
            this.btnSubmit.TabIndex = 7;
            this.btnSubmit.Text = "SUBMIT";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(165, 310);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 35);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // LeaveRequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = EmployeeManagement_Windows.Helpers.ThemeColors.Background;
            this.ClientSize = new System.Drawing.Size(400, 370);
            this.Controls.Add(this.cmbLeaveType);
            this.Controls.Add(this.lblLeaveType);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtReason);
            this.Controls.Add(this.lblReason);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.lblEnd);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.lblHeader);
            this.Name = "LeaveRequestForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Request Leave";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblStart;
        private EmployeeManagement_Windows.Controls.ModernDatePicker dtpStart;
        private System.Windows.Forms.Label lblEnd;
        private EmployeeManagement_Windows.Controls.ModernDatePicker dtpEnd;
        private System.Windows.Forms.Label lblReason;
        private System.Windows.Forms.TextBox txtReason;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblLeaveType;
        private System.Windows.Forms.ComboBox cmbLeaveType;
    }
}
