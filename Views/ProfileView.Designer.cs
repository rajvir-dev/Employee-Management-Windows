namespace EmployeeManagement_Windows.Views
{
    partial class ProfileView
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
            this.pnlFlow = new System.Windows.Forms.FlowLayoutPanel();
            this.cardHeader = new EmployeeManagement_Windows.CustomControls.ModernCard();
            this.lblHeaderEmail = new System.Windows.Forms.Label();
            this.lblHeaderName = new System.Windows.Forms.Label();
            this.btnUploadPhoto = new EmployeeManagement_Windows.CustomControls.ModernButton();
            this.pbPhoto = new System.Windows.Forms.PictureBox();
            this.cardPersonal = new EmployeeManagement_Windows.CustomControls.ModernCard();
            this.txtEmail = new EmployeeManagement_Windows.CustomControls.ModernTextBox();
            this.txtMobile = new EmployeeManagement_Windows.CustomControls.ModernTextBox();
            this.txtBirthDate = new EmployeeManagement_Windows.CustomControls.ModernTextBox();
            this.txtFullName = new EmployeeManagement_Windows.CustomControls.ModernTextBox();
            this.cardAdditional = new EmployeeManagement_Windows.CustomControls.ModernCard();
            this.lblSalaryType = new System.Windows.Forms.Label();
            this.cmbSalaryType = new System.Windows.Forms.ComboBox();
            this.txtAmount = new EmployeeManagement_Windows.CustomControls.ModernTextBox();
            this.txtPosition = new EmployeeManagement_Windows.CustomControls.ModernTextBox();
            this.txtAddress = new EmployeeManagement_Windows.CustomControls.ModernTextBox();
            this.txtBio = new EmployeeManagement_Windows.CustomControls.ModernTextBox();
            this.cardSecurity = new EmployeeManagement_Windows.CustomControls.ModernCard();
            this.txtConfirmPassword = new EmployeeManagement_Windows.CustomControls.ModernTextBox();
            this.txtPassword = new EmployeeManagement_Windows.CustomControls.ModernTextBox();
            this.pnlActions = new System.Windows.Forms.Panel();
            this.btnBack = new EmployeeManagement_Windows.CustomControls.ModernButton();
            this.btnSave = new EmployeeManagement_Windows.CustomControls.ModernButton();
            this.pnlFlow.SuspendLayout();
            this.cardHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).BeginInit();
            this.cardPersonal.SuspendLayout();
            this.cardAdditional.SuspendLayout();
            this.cardSecurity.SuspendLayout();
            this.pnlActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFlow
            // 
            this.pnlFlow.AutoScroll = true;
            this.pnlFlow.Controls.Add(this.cardHeader);
            this.pnlFlow.Controls.Add(this.cardPersonal);
            this.pnlFlow.Controls.Add(this.cardAdditional);
            this.pnlFlow.Controls.Add(this.cardSecurity);
            this.pnlFlow.Controls.Add(this.pnlActions);
            this.pnlFlow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFlow.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnlFlow.Location = new System.Drawing.Point(0, 0);
            this.pnlFlow.Name = "pnlFlow";
            this.pnlFlow.Padding = new System.Windows.Forms.Padding(20);
            this.pnlFlow.Size = new System.Drawing.Size(900, 600);
            this.pnlFlow.TabIndex = 0;
            this.pnlFlow.WrapContents = false;
            // 
            // cardHeader
            // 
            this.cardHeader.BackColor = System.Drawing.Color.Transparent;
            this.cardHeader.BorderRadius = 15;
            this.cardHeader.CardColor = System.Drawing.Color.White;
            this.cardHeader.Controls.Add(this.lblHeaderEmail);
            this.cardHeader.Controls.Add(this.lblHeaderName);
            this.cardHeader.Controls.Add(this.btnUploadPhoto);
            this.cardHeader.Controls.Add(this.pbPhoto);
            this.cardHeader.Location = new System.Drawing.Point(23, 23);
            this.cardHeader.Name = "cardHeader";
            this.cardHeader.Padding = new System.Windows.Forms.Padding(20, 45, 20, 20);
            this.cardHeader.ShadowSize = 5;
            this.cardHeader.Size = new System.Drawing.Size(830, 140);
            this.cardHeader.TabIndex = 0;
            this.cardHeader.Text = "Profile Settings";
            // 
            // lblHeaderEmail
            // 
            this.lblHeaderEmail.AutoSize = true;
            this.lblHeaderEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblHeaderEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
            this.lblHeaderEmail.Location = new System.Drawing.Point(120, 85);
            this.lblHeaderEmail.Name = "lblHeaderEmail";
            this.lblHeaderEmail.Size = new System.Drawing.Size(110, 15);
            this.lblHeaderEmail.TabIndex = 3;
            this.lblHeaderEmail.Text = "user@gmail.com";
            // 
            // lblHeaderName
            // 
            this.lblHeaderName.AutoSize = true;
            this.lblHeaderName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblHeaderName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.lblHeaderName.Location = new System.Drawing.Point(120, 60);
            this.lblHeaderName.Name = "lblHeaderName";
            this.lblHeaderName.Size = new System.Drawing.Size(131, 21);
            this.lblHeaderName.TabIndex = 2;
            this.lblHeaderName.Text = "Vaibhav P Rathod";
            // 
            // btnUploadPhoto
            // 
            this.btnUploadPhoto.BackColor = System.Drawing.Color.Transparent;
            this.btnUploadPhoto.BorderRadius = 8;
            this.btnUploadPhoto.FlatAppearance.BorderSize = 0;
            this.btnUploadPhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUploadPhoto.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.btnUploadPhoto.ForeColor = System.Drawing.Color.White;
            this.btnUploadPhoto.GradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(0)))), ((int)(((byte)(224)))));
            this.btnUploadPhoto.GradientStart = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(45)))), ((int)(((byte)(226)))));
            this.btnUploadPhoto.Location = new System.Drawing.Point(680, 65);
            this.btnUploadPhoto.Name = "btnUploadPhoto";
            this.btnUploadPhoto.Size = new System.Drawing.Size(120, 35);
            this.btnUploadPhoto.TabIndex = 1;
            this.btnUploadPhoto.Text = "Upload Photo";
            this.btnUploadPhoto.UseVisualStyleBackColor = true;
            this.btnUploadPhoto.Click += new System.EventHandler(this.btnUploadPhoto_Click);
            // 
            // pbPhoto
            // 
            this.pbPhoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.pbPhoto.Location = new System.Drawing.Point(30, 50);
            this.pbPhoto.Name = "pbPhoto";
            this.pbPhoto.Size = new System.Drawing.Size(70, 70);
            this.pbPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPhoto.TabIndex = 0;
            this.pbPhoto.TabStop = false;
            // 
            // cardPersonal
            // 
            this.cardPersonal.BackColor = System.Drawing.Color.Transparent;
            this.cardPersonal.BorderRadius = 15;
            this.cardPersonal.CardColor = System.Drawing.Color.White;
            this.cardPersonal.Controls.Add(this.txtEmail);
            this.cardPersonal.Controls.Add(this.txtMobile);
            this.cardPersonal.Controls.Add(this.txtBirthDate);
            this.cardPersonal.Controls.Add(this.txtFullName);
            this.cardPersonal.Location = new System.Drawing.Point(23, 169);
            this.cardPersonal.Name = "cardPersonal";
            this.cardPersonal.Padding = new System.Windows.Forms.Padding(20, 45, 20, 20);
            this.cardPersonal.ShadowSize = 5;
            this.cardPersonal.Size = new System.Drawing.Size(830, 180);
            this.cardPersonal.TabIndex = 1;
            this.cardPersonal.Text = "Personal Information";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.White;
            this.txtEmail.LabelText = "Email Address";
            this.txtEmail.Location = new System.Drawing.Point(430, 105);
            this.txtEmail.Multiline = false;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = false;
            this.txtEmail.PasswordCharValue = '\0';
            this.txtEmail.Size = new System.Drawing.Size(370, 45);
            this.txtEmail.TabIndex = 3;
            // 
            // txtMobile
            // 
            this.txtMobile.BackColor = System.Drawing.Color.White;
            this.txtMobile.LabelText = "Mobile Number";
            this.txtMobile.Location = new System.Drawing.Point(30, 105);
            this.txtMobile.Multiline = false;
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.PasswordChar = false;
            this.txtMobile.PasswordCharValue = '\0';
            this.txtMobile.Size = new System.Drawing.Size(370, 45);
            this.txtMobile.TabIndex = 2;
            // 
            // txtBirthDate
            // 
            this.txtBirthDate.BackColor = System.Drawing.Color.White;
            this.txtBirthDate.LabelText = "Birth Date";
            this.txtBirthDate.Location = new System.Drawing.Point(430, 55);
            this.txtBirthDate.Multiline = false;
            this.txtBirthDate.Name = "txtBirthDate";
            this.txtBirthDate.PasswordChar = false;
            this.txtBirthDate.PasswordCharValue = '\0';
            this.txtBirthDate.Size = new System.Drawing.Size(370, 45);
            this.txtBirthDate.TabIndex = 1;
            // 
            // txtFullName
            // 
            this.txtFullName.BackColor = System.Drawing.Color.White;
            this.txtFullName.LabelText = "Full Name";
            this.txtFullName.Location = new System.Drawing.Point(30, 55);
            this.txtFullName.Multiline = false;
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.PasswordChar = false;
            this.txtFullName.PasswordCharValue = '\0';
            this.txtFullName.Size = new System.Drawing.Size(370, 45);
            this.txtFullName.TabIndex = 0;
            // 
            // cardAdditional
            // 
            this.cardAdditional.BackColor = System.Drawing.Color.Transparent;
            this.cardAdditional.BorderRadius = 15;
            this.cardAdditional.CardColor = System.Drawing.Color.White;
            this.cardAdditional.Controls.Add(this.lblSalaryType);
            this.cardAdditional.Controls.Add(this.cmbSalaryType);
            this.cardAdditional.Controls.Add(this.txtAmount);
            this.cardAdditional.Controls.Add(this.txtPosition);
            this.cardAdditional.Controls.Add(this.txtAddress);
            this.cardAdditional.Controls.Add(this.txtBio);
            this.cardAdditional.Location = new System.Drawing.Point(23, 355);
            this.cardAdditional.Name = "cardAdditional";
            this.cardAdditional.Padding = new System.Windows.Forms.Padding(20, 45, 20, 20);
            this.cardAdditional.ShadowSize = 5;
            this.cardAdditional.Size = new System.Drawing.Size(830, 280);
            this.cardAdditional.TabIndex = 2;
            this.cardAdditional.Text = "Professional Details";
            // 
            // lblSalaryType
            // 
            this.lblSalaryType.AutoSize = true;
            this.lblSalaryType.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblSalaryType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
            this.lblSalaryType.Location = new System.Drawing.Point(30, 225);
            this.lblSalaryType.Name = "lblSalaryType";
            this.lblSalaryType.Size = new System.Drawing.Size(68, 15);
            this.lblSalaryType.TabIndex = 5;
            this.lblSalaryType.Text = "Salary Type";
            // 
            // cmbSalaryType
            // 
            this.cmbSalaryType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSalaryType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbSalaryType.FormattingEnabled = true;
            this.cmbSalaryType.Items.AddRange(new object[] {
            "Monthly",
            "Weekly",
            "Hourly"});
            this.cmbSalaryType.Location = new System.Drawing.Point(30, 245);
            this.cmbSalaryType.Name = "cmbSalaryType";
            this.cmbSalaryType.Size = new System.Drawing.Size(370, 25);
            this.cmbSalaryType.TabIndex = 4;
            // 
            // txtAmount
            // 
            this.txtAmount.BackColor = System.Drawing.Color.White;
            this.txtAmount.LabelText = "Salary Amount";
            this.txtAmount.Location = new System.Drawing.Point(430, 170);
            this.txtAmount.Multiline = false;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.PasswordChar = false;
            this.txtAmount.PasswordCharValue = '\0';
            this.txtAmount.Size = new System.Drawing.Size(370, 45);
            this.txtAmount.TabIndex = 3;
            // 
            // txtPosition
            // 
            this.txtPosition.BackColor = System.Drawing.Color.White;
            this.txtPosition.LabelText = "Position";
            this.txtPosition.Location = new System.Drawing.Point(30, 170);
            this.txtPosition.Multiline = false;
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.PasswordChar = false;
            this.txtPosition.PasswordCharValue = '\0';
            this.txtPosition.Size = new System.Drawing.Size(370, 45);
            this.txtPosition.TabIndex = 2;
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.White;
            this.txtAddress.LabelText = "Address";
            this.txtAddress.Location = new System.Drawing.Point(430, 55);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PasswordChar = false;
            this.txtAddress.PasswordCharValue = '\0';
            this.txtAddress.Size = new System.Drawing.Size(370, 100);
            this.txtAddress.TabIndex = 1;
            // 
            // txtBio
            // 
            this.txtBio.BackColor = System.Drawing.Color.White;
            this.txtBio.LabelText = "Bio";
            this.txtBio.Location = new System.Drawing.Point(30, 55);
            this.txtBio.Multiline = true;
            this.txtBio.Name = "txtBio";
            this.txtBio.PasswordChar = false;
            this.txtBio.PasswordCharValue = '\0';
            this.txtBio.Size = new System.Drawing.Size(370, 100);
            this.txtBio.TabIndex = 0;
            // 
            // cardSecurity
            // 
            this.cardSecurity.BackColor = System.Drawing.Color.Transparent;
            this.cardSecurity.BorderRadius = 15;
            this.cardSecurity.CardColor = System.Drawing.Color.White;
            this.cardSecurity.Controls.Add(this.txtConfirmPassword);
            this.cardSecurity.Controls.Add(this.txtPassword);
            this.cardSecurity.Location = new System.Drawing.Point(23, 641);
            this.cardSecurity.Name = "cardSecurity";
            this.cardSecurity.Padding = new System.Windows.Forms.Padding(20, 45, 20, 20);
            this.cardSecurity.ShadowSize = 5;
            this.cardSecurity.Size = new System.Drawing.Size(830, 120);
            this.cardSecurity.TabIndex = 3;
            this.cardSecurity.Text = "Security";
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.BackColor = System.Drawing.Color.White;
            this.txtConfirmPassword.LabelText = "Confirm Password";
            this.txtConfirmPassword.Location = new System.Drawing.Point(430, 55);
            this.txtConfirmPassword.Multiline = false;
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = true;
            this.txtConfirmPassword.PasswordCharValue = '\0';
            this.txtConfirmPassword.Size = new System.Drawing.Size(370, 45);
            this.txtConfirmPassword.TabIndex = 1;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.White;
            this.txtPassword.LabelText = "New Password";
            this.txtPassword.Location = new System.Drawing.Point(30, 55);
            this.txtPassword.Multiline = false;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = true;
            this.txtPassword.PasswordCharValue = '\0';
            this.txtPassword.Size = new System.Drawing.Size(370, 45);
            this.txtPassword.TabIndex = 0;
            // 
            // pnlActions
            // 
            this.pnlActions.Controls.Add(this.btnBack);
            this.pnlActions.Controls.Add(this.btnSave);
            this.pnlActions.Location = new System.Drawing.Point(23, 767);
            this.pnlActions.Name = "pnlActions";
            this.pnlActions.Size = new System.Drawing.Size(830, 80);
            this.pnlActions.TabIndex = 4;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.BorderRadius = 10;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
            this.btnBack.FlatAppearance.BorderSize = 1;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
            this.btnBack.GradientEnd = System.Drawing.Color.Transparent;
            this.btnBack.GradientStart = System.Drawing.Color.Transparent;
            this.btnBack.Location = new System.Drawing.Point(200, 20);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(150, 45);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back to Dashboard";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BorderRadius = 10;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.GradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(0)))), ((int)(((byte)(224)))));
            this.btnSave.GradientStart = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(45)))), ((int)(((byte)(226)))));
            this.btnSave.Location = new System.Drawing.Point(30, 20);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 45);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save Changes";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ProfileView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.pnlFlow);
            this.Name = "ProfileView";
            this.Size = new System.Drawing.Size(900, 600);
            this.pnlFlow.ResumeLayout(false);
            this.cardHeader.ResumeLayout(false);
            this.cardHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).EndInit();
            this.cardPersonal.ResumeLayout(false);
            this.cardAdditional.ResumeLayout(false);
            this.cardAdditional.PerformLayout();
            this.cardSecurity.ResumeLayout(false);
            this.pnlActions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.FlowLayoutPanel pnlFlow;
        private EmployeeManagement_Windows.CustomControls.ModernCard cardHeader;
        private System.Windows.Forms.PictureBox pbPhoto;
        private EmployeeManagement_Windows.CustomControls.ModernButton btnUploadPhoto;
        private System.Windows.Forms.Label lblHeaderName;
        private System.Windows.Forms.Label lblHeaderEmail;
        private EmployeeManagement_Windows.CustomControls.ModernCard cardPersonal;
        private EmployeeManagement_Windows.CustomControls.ModernTextBox txtFullName;
        private EmployeeManagement_Windows.CustomControls.ModernTextBox txtBirthDate;
        private EmployeeManagement_Windows.CustomControls.ModernTextBox txtMobile;
        private EmployeeManagement_Windows.CustomControls.ModernTextBox txtEmail;
        private EmployeeManagement_Windows.CustomControls.ModernCard cardAdditional;
        private EmployeeManagement_Windows.CustomControls.ModernTextBox txtBio;
        private EmployeeManagement_Windows.CustomControls.ModernTextBox txtAddress;
        private EmployeeManagement_Windows.CustomControls.ModernTextBox txtPosition;
        private EmployeeManagement_Windows.CustomControls.ModernTextBox txtAmount;
        private EmployeeManagement_Windows.CustomControls.ModernCard cardSecurity;
        private EmployeeManagement_Windows.CustomControls.ModernTextBox txtPassword;
        private EmployeeManagement_Windows.CustomControls.ModernTextBox txtConfirmPassword;
        private System.Windows.Forms.Panel pnlActions;
        private EmployeeManagement_Windows.CustomControls.ModernButton btnSave;
        private EmployeeManagement_Windows.CustomControls.ModernButton btnBack;
        private System.Windows.Forms.Label lblSalaryType;
        private System.Windows.Forms.ComboBox cmbSalaryType;
    }
}
