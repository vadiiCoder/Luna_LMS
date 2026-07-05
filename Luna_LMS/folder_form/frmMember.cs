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
    public partial class frmMember : Form
    {
        public frmMember()
        {
            InitializeComponent();
        }

        private void btn_dash_Click(object sender, EventArgs e)
        {
            frmDashboard dashboard = new frmDashboard();
            dashboard.Show();
            this.Hide();
        }

        private void btn_borrow_Click(object sender, EventArgs e)
        {
            frmBorrow borrow = new frmBorrow();
            borrow.Show();
            this.Hide();
        }

        private void book_btn_Click(object sender, EventArgs e)
        {
            frmBook book = new frmBook();
            book.Show();
            this.Hide();
        }
    }
}
