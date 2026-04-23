namespace EmployeeManagement_Windows.Forms
{
    partial class LoginForm
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
            this.cardLogin = new EmployeeManagement_Windows.Controls.CardPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.txtEmail = new EmployeeManagement_Windows.Controls.ModernTextBox();
            this.txtPassword = new EmployeeManagement_Windows.Controls.ModernTextBox();
            this.btnLogin = new EmployeeManagement_Windows.Controls.ModernButton();
            this.btnExit = new System.Windows.Forms.Button();
            this.cardLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // cardLogin
            // 
            this.cardLogin.BackColor = System.Drawing.Color.Transparent;
            this.cardLogin.BorderRadius = 12;
            this.cardLogin.CardColor = System.Drawing.Color.White;
            this.cardLogin.Controls.Add(this.lblTitle);
            this.cardLogin.Controls.Add(this.lblSubtitle);
            this.cardLogin.Controls.Add(this.txtEmail);
            this.cardLogin.Controls.Add(this.txtPassword);
            this.cardLogin.Controls.Add(this.btnLogin);
            this.cardLogin.Controls.Add(this.btnExit);
            this.cardLogin.Location = new System.Drawing.Point(50, 50);
            this.cardLogin.Name = "cardLogin";
            this.cardLogin.Padding = new System.Windows.Forms.Padding(30);
            this.cardLogin.ShadowSize = 5;
            this.cardLogin.Size = new System.Drawing.Size(400, 480);
            this.cardLogin.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.lblTitle.Location = new System.Drawing.Point(30, 40);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(340, 45);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Login";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
            this.lblSubtitle.Location = new System.Drawing.Point(30, 85);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(340, 20);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "Please enter your credentials to continue";
            this.lblSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.Transparent;
            this.txtEmail.LabelText = "Email or Mobile";
            this.txtEmail.Location = new System.Drawing.Point(40, 140);
            this.txtEmail.Multiline = false;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = false;
            this.txtEmail.PasswordCharValue = '\0';
            this.txtEmail.Size = new System.Drawing.Size(320, 65);
            this.txtEmail.TabIndex = 3;
            this.txtEmail.Text = "user@gmail.com";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.Transparent;
            this.txtPassword.LabelText = "Password";
            this.txtPassword.Location = new System.Drawing.Point(40, 220);
            this.txtPassword.Multiline = false;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = true;
            this.txtPassword.PasswordCharValue = '●';
            this.txtPassword.Size = new System.Drawing.Size(320, 65);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.Text = "R@jveer007";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.BorderRadius = 8;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(40, 320);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(320, 50);
            this.btnLogin.Style = EmployeeManagement_Windows.Controls.ButtonStyle.Primary;
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "LOG IN";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(190)))), ((int)(((byte)(195)))));
            this.btnExit.Location = new System.Drawing.Point(40, 390);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(320, 30);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "CLOSE APPLICATION";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(240)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(500, 580);
            this.Controls.Add(this.cardLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Management - Login";
            this.cardLogin.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private EmployeeManagement_Windows.Controls.CardPanel cardLogin;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private EmployeeManagement_Windows.Controls.ModernTextBox txtEmail;
        private EmployeeManagement_Windows.Controls.ModernTextBox txtPassword;
        private EmployeeManagement_Windows.Controls.ModernButton btnLogin;
        private System.Windows.Forms.Button btnExit;
    }
}
