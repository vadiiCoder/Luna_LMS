using Luna_LMS.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Luna_LMS.Forms.Login
{
    public partial class FrmResetPassword : Form
    {
        public FrmResetPassword()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            if (txtNewPassword.Text !=
   txtConfirmPassword.Text)
            {
                MessageBox.Show(
                    "Passwords do not match");

                return;
            }

            string hash =
                PasswordHelper.HashPassword(
                    txtNewPassword.Text);

            // Update DB
        }
    }
}
