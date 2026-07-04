using Luna_LMS.folder_form;
using Luna_LMS.Forms.Login;
using Luna_LMS.Helpers;
using Luna_LMS.Services;
using System;
using System.Windows.Forms;

namespace Luna_LMS.Forms
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        // FORM LOAD
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            txtUsername.Text = RememberMeHelper.Load();
            txtPassIn.UseSystemPasswordChar = true;
        }

        // SHOW / HIDE PASSWORD
        private void btnShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassIn.UseSystemPasswordChar = !btnShowPassword.Checked;
        }

        // LOGIN BUTTON
        private void btnSignIn_Click(object sender, EventArgs e)
        {
            // VALIDATION FIRST
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("Username is required.");
                txtUsername.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPassIn.Text))
            {
                MessageBox.Show("Password is required.");
                txtPassIn.Focus();
                return;
            }

            try
            {
                AuthenticationService auth = new AuthenticationService();

                bool success = auth.Login(
                    txtUsername.Text.Trim(),
                    txtPassIn.Text
                );

                if (!success)
                {
                    MessageBox.Show("Invalid username or password.");
                    return;
                }

                // REMEMBER ME
                if (chkRememberMe.Checked)
                {
                    RememberMeHelper.Save(txtUsername.Text.Trim());
                }
                else
                {
                    RememberMeHelper.Clear();
                }

                // OPEN DASHBOARD BASED ON ROLE
                OpenDashboard();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // ROLE BASED DASHBOARD
        private void OpenDashboard()
        {
            if (SessionManager.RoleID == 1)
            {
                Admin_Dashboard frm = new Admin_Dashboard();
                frm.Show();
                this.Hide();
            }
            else if (SessionManager.RoleID == 2)
            {
                FrmStudentDashboard frm = new FrmStudentDashboard();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Unknown role. Access denied.");
            }
        }

        // FORGOT PASSWORD
        private void lnkForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmForgotPassword frm = new FrmForgotPassword();
            frm.ShowDialog();
        }

        private void btnShowPassword_Click(object sender, EventArgs e)
        {

        }
    }
}