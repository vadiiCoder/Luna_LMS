using Luna_LMS.folder_form;
using Luna_LMS.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Luna_LMS.folder_form
{
    public partial class SplashScreen : Form
    {
        // Variable to track the loading progress
        private int progressValue = 0;

        public SplashScreen()
        {
            InitializeComponent();

            // Ensure the progress bar starts at 0 and goes up to 100
            loadingProgressBar.Minimum = 0;
            loadingProgressBar.Maximum = 100;
            loadingProgressBar.Value = 0;
        }

        private void loadingTimer_Tick(object sender, EventArgs e)
        {
            // 1. Increment the counter
            progressValue++;

            // 2. Prevent the value from accidentally exceeding 100
            if (progressValue > 100)
            {
                progressValue = 100;
            }

            // 3. Update BOTH the progress bar and the label text
            loadingProgressBar.Value = progressValue;
            lblPercentage.Text = progressValue.ToString() + "%";

            // 4. Check if loading is complete
            if (progressValue >= 100)
            {
                // Stop the timer so it doesn't loop
                loadingTimer.Stop();

                // Open your main application form
                FrmLogin log_in = new FrmLogin();
                log_in.Show();

                // Hide or close the splash screen
                this.Hide();
            }
        }
    }
}



