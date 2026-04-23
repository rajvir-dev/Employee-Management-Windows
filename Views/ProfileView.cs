using System;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmployeeManagement_Windows.Core;
using EmployeeManagement_Windows.Models;
using EmployeeManagement_Windows.Services;

namespace EmployeeManagement_Windows.Views
{
    public partial class ProfileView : UserControl
    {
        private EmployeeDto _currentEmployee;
        private string _selectedPhotoBase64;

        public ProfileView()
        {
            InitializeComponent();
        }

        protected override async void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            await LoadProfileAsync();
        }

        private async Task LoadProfileAsync()
        {
            try
            {
                _currentEmployee = await EmployeeService.GetProfileAsync();
                if (this.IsDisposed) return;

                if (_currentEmployee != null)
                {
                    // Basic Info
                    txtFullName.Text = _currentEmployee.FullName;
                    lblHeaderName.Text = _currentEmployee.FullName;
                    lblHeaderEmail.Text = _currentEmployee.EmailId;

                    // Personal Info
                    txtBirthDate.Text = _currentEmployee.DateOfBirth.ToString("yyyy-MM-dd");
                    txtMobile.Text = _currentEmployee.MobileNumber;
                    txtEmail.Text = _currentEmployee.EmailId;

                    // Professional Info
                    txtBio.Text = _currentEmployee.Bio;
                    txtAddress.Text = _currentEmployee.Address;
                    txtPosition.Text = _currentEmployee.Position;
                    txtAmount.Text = _currentEmployee.Amount;
                    cmbSalaryType.SelectedItem = _currentEmployee.SalaryType;

                    // Security
                    txtPassword.Text = _currentEmployee.Password;
                    txtConfirmPassword.Text = _currentEmployee.Password;

                    // Photo
                    var apiPhoto = CleanBase64(_currentEmployee.PhotoBase64);
                    if (!string.IsNullOrEmpty(apiPhoto))
                    {
                        _selectedPhotoBase64 = apiPhoto;
                        
                        // Update session cache
                        SessionManager.PhotoBase64 = _selectedPhotoBase64;
                        SessionManager.SaveSession();
                    }
                    else if (!string.IsNullOrEmpty(SessionManager.PhotoBase64))
                    {
                        // Keep the local cached photo if API returns empty
                        _selectedPhotoBase64 = SessionManager.PhotoBase64;
                    }

                    if (!string.IsNullOrEmpty(_selectedPhotoBase64))
                    {
                        try
                        {
                            byte[] imageBytes = Convert.FromBase64String(_selectedPhotoBase64);
                            using (var ms = new MemoryStream(imageBytes))
                            {
                                pbPhoto.Image = Image.FromStream(ms);
                            }
                        }
                        catch { /* Ignore invalid base64 */ }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading profile: " + ex.Message);
            }
        }

        private void btnUploadPhoto_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        byte[] imageBytes = File.ReadAllBytes(ofd.FileName);
                        _selectedPhotoBase64 = Convert.ToBase64String(imageBytes);
                        
                        // Update session cache immediately
                        SessionManager.PhotoBase64 = _selectedPhotoBase64;
                        SessionManager.SaveSession();
                        
                        using (var ms = new MemoryStream(imageBytes))
                        {
                            pbPhoto.Image = Image.FromStream(ms);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error uploading photo: " + ex.Message);
                    }
                }
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Passwords do not match!");
                return;
            }

            var request = new ProfileUpdateRequest
            {
                EmployeeId = _currentEmployee?.EmployeeId,
                FullName = txtFullName.Text.Trim(),
                Bio = txtBio.Text.Trim(),
                Position = txtPosition.Text.Trim(),
                EmailId = txtEmail.Text.Trim(),
                Address = txtAddress.Text.Trim(),
                MobileNumber = txtMobile.Text.Trim(),
                Password = txtPassword.Text,
                Amount = txtAmount.Text.Trim(),
                SalaryType = cmbSalaryType.SelectedItem?.ToString(),
                PhotoBase64 = _selectedPhotoBase64
            };

            // Parse BirthDate safely
            if (DateTime.TryParse(txtBirthDate.Text, out DateTime dob))
            {
                request.DateOfBirth = dob;
            }

            btnSave.Enabled = false;
            try
            {
                var result = await EmployeeService.UpdateProfileAsync(request);
                if (result.Success)
                {
                    MessageBox.Show("Profile updated successfully!");
                    await LoadProfileAsync();
                    if (this.IsDisposed) return;
                }
                else
                {
                    MessageBox.Show("Update failed: " + result.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                btnSave.Enabled = true;
            }
        }
        private string CleanBase64(string base64)
        {
            if (string.IsNullOrEmpty(base64)) return string.Empty;
            if (base64.Contains(","))
            {
                return base64.Split(',')[1];
            }
            return base64;
        }
    }
}
