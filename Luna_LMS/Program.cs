using System;
using System.Windows.Forms; // Keep this for Windows Forms
using Luna_LMS.folder_form; // Points to your custom folder containing your forms

namespace Luna_LMS
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // We explicitly tell C# to use System.Windows.Forms.Application 
            // to stop the conflict with WPF's System.Windows.Application
            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);

            // Explicitly call your specific SplashScreen form from folder_form
            System.Windows.Forms.Application.Run(new Luna_LMS.folder_form.frmMember());
        }
    }
}