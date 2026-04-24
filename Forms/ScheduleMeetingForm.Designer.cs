namespace EmployeeManagement_Windows.Forms
{
    using EmployeeManagement_Windows.Controls;

    partial class ScheduleMeetingForm
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
            this.cardModal = new CardPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubject = new System.Windows.Forms.Label();
            this.txtSubject = new EmployeeManagement_Windows.Controls.ModernTextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblTime = new System.Windows.Forms.Label();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.btnSchedule = new ModernButton();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblDuration = new System.Windows.Forms.Label();
            this.txtHours = new EmployeeManagement_Windows.Controls.ModernTextBox();
            this.txtMinutes = new EmployeeManagement_Windows.Controls.ModernTextBox();
            this.cardModal.SuspendLayout();
            this.SuspendLayout();
            // 
            // cardModal
            // 
            this.cardModal.BackColor = System.Drawing.Color.Transparent;
            this.cardModal.BorderRadius = 20;
            this.cardModal.CardColor = System.Drawing.Color.White;
            this.cardModal.Controls.Add(this.txtMinutes);
            this.cardModal.Controls.Add(this.txtHours);
            this.cardModal.Controls.Add(this.lblDuration);
            this.cardModal.Controls.Add(this.lblTitle);
            this.cardModal.Controls.Add(this.lblSubject);
            this.cardModal.Controls.Add(this.txtSubject);
            this.cardModal.Controls.Add(this.lblDate);
            this.cardModal.Controls.Add(this.dtpDate);
            this.cardModal.Controls.Add(this.lblTime);
            this.cardModal.Controls.Add(this.dtpTime);
            this.cardModal.Controls.Add(this.btnSchedule);
            this.cardModal.Controls.Add(this.btnCancel);
            this.cardModal.Location = new System.Drawing.Point(0, 0);
            this.cardModal.Name = "cardModal";
            this.cardModal.Padding = new System.Windows.Forms.Padding(20);
            this.cardModal.ShadowSize = 8;
            this.cardModal.Size = new System.Drawing.Size(450, 500);
            this.cardModal.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.lblTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(410, 40);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Schedule Meeting";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblSubject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
            this.lblSubject.Location = new System.Drawing.Point(40, 80);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(50, 17);
            this.lblSubject.TabIndex = 1;
            this.lblSubject.Text = "Subject";
            // 
            // txtSubject
            // 
            this.txtSubject.BackColor = System.Drawing.Color.Transparent;
            this.txtSubject.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSubject.LabelText = "";
            this.txtSubject.Location = new System.Drawing.Point(40, 95);
            this.txtSubject.Multiline = false;
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.PlaceholderText = "Enter meeting subject...";
            this.txtSubject.Size = new System.Drawing.Size(370, 50);
            this.txtSubject.TabIndex = 2;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
            this.lblDate.Location = new System.Drawing.Point(40, 160);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(35, 17);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "Date";
            // 
            // dtpDate
            // 
            this.dtpDate.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.dtpDate.Location = new System.Drawing.Point(40, 185);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(370, 28);
            this.dtpDate.TabIndex = 4;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
            this.lblTime.Location = new System.Drawing.Point(40, 230);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(36, 17);
            this.lblTime.TabIndex = 5;
            this.lblTime.Text = "Time";
            // 
            // dtpTime
            // 
            this.dtpTime.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpTime.Location = new System.Drawing.Point(40, 255);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.ShowUpDown = true;
            this.dtpTime.Size = new System.Drawing.Size(370, 28);
            this.dtpTime.TabIndex = 6;
            // 
            // btnSchedule
            // 
            this.btnSchedule.BackColor = System.Drawing.Color.Transparent;
            this.btnSchedule.BorderRadius = 15;
            this.btnSchedule.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSchedule.FlatAppearance.BorderSize = 0;
            this.btnSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSchedule.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnSchedule.ForeColor = System.Drawing.Color.White;
            this.btnSchedule.GradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(0)))), ((int)(((byte)(224)))));
            this.btnSchedule.GradientStart = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(45)))), ((int)(((byte)(226)))));
            this.btnSchedule.Location = new System.Drawing.Point(40, 390);
            this.btnSchedule.Name = "btnSchedule";
            this.btnSchedule.Size = new System.Drawing.Size(370, 50);
            this.btnSchedule.TabIndex = 9;
            this.btnSchedule.Text = "SCHEDULE";
            this.btnSchedule.UseVisualStyleBackColor = false;
            this.btnSchedule.Click += new System.EventHandler(this.btnSchedule_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
            this.btnCancel.Location = new System.Drawing.Point(40, 445);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(370, 35);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblDuration.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
            this.lblDuration.Location = new System.Drawing.Point(40, 300);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(58, 17);
            this.lblDuration.TabIndex = 7;
            this.lblDuration.Text = "Duration";
            // 
            // txtHours
            // 
            this.txtHours.BackColor = System.Drawing.Color.Transparent;
            this.txtHours.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtHours.LabelText = "";
            this.txtHours.Location = new System.Drawing.Point(40, 320);
            this.txtHours.Multiline = false;
            this.txtHours.Name = "txtHours";
            this.txtHours.NumericOnly = true;
            this.txtHours.PlaceholderText = "Hours";
            this.txtHours.Size = new System.Drawing.Size(180, 50);
            this.txtHours.TabIndex = 7;
            // 
            // txtMinutes
            // 
            this.txtMinutes.BackColor = System.Drawing.Color.Transparent;
            this.txtMinutes.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMinutes.LabelText = "";
            this.txtMinutes.Location = new System.Drawing.Point(230, 320);
            this.txtMinutes.MaxValue = 59;
            this.txtMinutes.Multiline = false;
            this.txtMinutes.Name = "txtMinutes";
            this.txtMinutes.NumericOnly = true;
            this.txtMinutes.PlaceholderText = "Minutes";
            this.txtMinutes.Size = new System.Drawing.Size(180, 50);
            this.txtMinutes.TabIndex = 8;
            // 
            // ScheduleMeetingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(450, 500);
            this.Controls.Add(this.cardModal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ScheduleMeetingForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Text = "Schedule Meeting";
            this.cardModal.ResumeLayout(false);
            this.cardModal.PerformLayout();
            this.ResumeLayout(false);

        }

        private CardPanel cardModal;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubject;
        private EmployeeManagement_Windows.Controls.ModernTextBox txtSubject;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.DateTimePicker dtpTime;
        private ModernButton btnSchedule;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblDuration;
        private EmployeeManagement_Windows.Controls.ModernTextBox txtHours;
        private EmployeeManagement_Windows.Controls.ModernTextBox txtMinutes;
    }
}
