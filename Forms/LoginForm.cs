using System;
using System.Drawing;
using System.Windows.Forms;
using EmployeeManagement_Windows.Core;
using EmployeeManagement_Windows.Helpers;
using EmployeeManagement_Windows.Services;

namespace EmployeeManagement_Windows.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            btnLogin.Enabled = false;
            btnLogin.Text = "Logging in...";

            try
            {
                var result = await AuthService.LoginAsync(email, password);
                if (result.Token != null) 
                {
                    // Start real-time notifications
                    _ = SignalRService.Instance.StartAsync();
                    
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Login Failed: Invalid credentials.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                btnLogin.Enabled = true;
                btnLogin.Text = "LOG IN";
            }
        }
    }
}
