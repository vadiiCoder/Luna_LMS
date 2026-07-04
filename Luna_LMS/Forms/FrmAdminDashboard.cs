using Luna_LMS.Database;
using Luna_LMS.Helpers;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Luna_LMS.Forms
{
    public partial class FrmAdminDashboard : Form
    {

        public FrmAdminDashboard()
        {
            InitializeComponent();
        }


        //load the counts
        private void LoadAdminCounts()
        {
            ////DbConnectionFactory db = new DbConnectionFactory();



            ////using (MySqlConnection conn = db.GetConnection())
            //{
            //    conn.Open();

            //    lblTotalUsers.Text =
            //    new MySqlCommand(
            //        "SELECT COUNT(*) FROM users",
            //        conn)
            //    .ExecuteScalar()
            //    .ToString();

            //    lblTotalBooks.Text =
            //        new MySqlCommand(
            //            "SELECT COUNT(*) FROM books",
            //            conn)
            //        .ExecuteScalar()
            //        .ToString();

            //    lblTotalBorrowed.Text =
            //        new MySqlCommand(
            //            "SELECT COUNT(*) FROM borrowings",
            //            conn)
            //        .ExecuteScalar()
            //        .ToString();

            //    lblOverdueBooks.Text =
            //        new MySqlCommand(
            //            "SELECT COUNT(*) FROM OverdueBooks",
            //            conn)
            //        .ExecuteScalar()
            //        .ToString();
            //}
        }


        //load charts


        private void guna2Button1_Click(object sender, EventArgs e)
        {
         
        }

        private void lblTotalUsers_Click(object sender, EventArgs e)
        {

        }

        private void FrmAdminDashboard_Load(object sender, EventArgs e)
        {
            LoadAdminCounts();
        }

        private void guna2Panel6_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
