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
    public partial class frmBorrow : Form
    {
        public frmBorrow()
        {
            InitializeComponent();
        }

        //to enter the members form
        private void btn_mem_Click(object sender, EventArgs e)
        {
            frmMember mem = new frmMember();
            mem.Show();
            this.Hide();
        }

        //to enter the books form
        private void book_btn_Click(object sender, EventArgs e)
        {
            frmBook book = new frmBook();
            book.Show();
            this.Hide();
        }

        //to enter the dashboards form
        private void btn_dash_Click(object sender, EventArgs e)
        {
            frmDashboard dashboard = new frmDashboard();
            dashboard.Show();
            this.Hide();
        }
    }
}
