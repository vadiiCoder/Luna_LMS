using LibraryManagementSystem.Utilities;
using Luna_LMS.Database;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Cmp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using System.IO;


namespace Luna_LMS.folder_form
{
    public partial class Book_fomr : Form
    {
        private readonly string connectionString =
    "server=localhost;database=library_db;uid=root;pwd=;";
        public Book_fomr()
        {
            InitializeComponent();

            LoadCategories();
            LoadShelves();
            LoadStatus();

            LoadBooks();

            LoadDashboard();

            txt_search.TextChanged += txt_search_TextChanged;

            category_cmb.SelectedIndexChanged += FilterChanged;
            cmb_shelf.SelectedIndexChanged += FilterChanged;
            All_status.SelectedIndexChanged += FilterChanged;

        }


        //the structure of the book form

        //load the dashboard counts
        private void LoadDashboard()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                lblTotalBooks.Text =
                    ExecuteScalar(conn,
                    "SELECT COUNT(*) FROM books").ToString();

                lblavailble.Text =
                    ExecuteScalar(conn,
                    "SELECT COUNT(*) FROM book_copies WHERE status='Available'").ToString();

                lblTotalBorrowed.Text =
                    ExecuteScalar(conn,
                    "SELECT COUNT(*) FROM book_copies WHERE status='Borrowed'").ToString();

                reserv.Text =
                    ExecuteScalar(conn,
                    "SELECT COUNT(*) FROM book_copies WHERE status='Reserved'").ToString();
            }
        }

        private object ExecuteScalar(MySqlConnection conn, string sql)
        {
            using (MySqlCommand cmd = new MySqlCommand(sql, conn))
            {
                return cmd.ExecuteScalar();
            }
        }

        //load category
        private void LoadCategories()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                MySqlDataAdapter da =
                    new MySqlDataAdapter(
                        "SELECT id,name FROM categories ORDER BY name",
                        conn);

                DataTable dt = new DataTable();

                da.Fill(dt);

                DataRow row = dt.NewRow();

                row["id"] = 0;
                row["name"] = "All Categories";

                dt.Rows.InsertAt(row, 0);

                category_cmb.DataSource = dt;

                category_cmb.DisplayMember = "name";

                category_cmb.ValueMember = "id";
            }
        }

        //load shelf
        private void LoadShelves()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                MySqlDataAdapter da =
                    new MySqlDataAdapter(
                        "SELECT id,shelf_code FROM shelves ORDER BY shelf_code",
                        conn);

                DataTable dt = new DataTable();

                da.Fill(dt);

                DataRow row = dt.NewRow();

                row["id"] = 0;
                row["shelf_code"] = "All Shelves";

                dt.Rows.InsertAt(row, 0);

                cmb_shelf.DataSource = dt;

                cmb_shelf.DisplayMember = "shelf_code";

                cmb_shelf.ValueMember = "id";
            }
        }

        //LOAD STATUS
        private void LoadStatus()
        {
            All_status.Items.Clear();

            All_status.Items.Add("All Status");
            All_status.Items.Add("Available");
            All_status.Items.Add("Borrowed");
            All_status.Items.Add("Reserved");

            All_status.SelectedIndex = 0;
        }

        //LOAD BOOKS
        private void LoadBooks()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                StringBuilder sql = new StringBuilder();

                sql.Append(@"
SELECT
    bc.id,
    b.title,
    b.author,
    b.isbn,
    c.name AS Category,
    s.shelf_code AS Shelf,
    bc.barcode,
    bc.status,
    b.cover_image_path

FROM book_copies bc

INNER JOIN books b
    ON bc.book_id = b.id

INNER JOIN categories c
    ON b.category_id = c.id

INNER JOIN shelves s
    ON bc.shelf_id = s.id

WHERE 1 = 1
");

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;

                // Search
                if (!string.IsNullOrWhiteSpace(txt_search.Text))
                {
                    sql.Append(@"
AND
(
    b.title LIKE @search
    OR b.author LIKE @search
    OR b.isbn LIKE @search
    OR bc.barcode LIKE @search
)");

                    cmd.Parameters.AddWithValue("@search",
                        "%" + txt_search.Text.Trim() + "%");
                }

                // Category
                if (category_cmb.SelectedIndex > 0)
                {
                    sql.Append(" AND b.category_id=@category");

                    cmd.Parameters.AddWithValue("@category",
                        category_cmb.SelectedValue);
                }

                // Shelf
                if (cmb_shelf.SelectedIndex > 0)
                {
                    sql.Append(" AND bc.shelf_id=@shelf");

                    cmd.Parameters.AddWithValue("@shelf",
                        cmb_shelf.SelectedValue);
                }

                // Status
                if (All_status.SelectedIndex > 0)
                {
                    sql.Append(" AND bc.status=@status");

                    cmd.Parameters.AddWithValue("@status",
                        All_status.Text);
                }

                sql.Append(" ORDER BY b.title ASC, bc.id ASC");

                cmd.CommandText = sql.ToString();

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                DataTable dt = new DataTable();

                da.Fill(dt);

                dvg_books.DataSource = dt;

                
            }
        }

        //SEARCH TEXT CHANGED
        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            LoadBooks();
        }

        //THE FILTER CHANGED
        private void FilterChanged(object sender, EventArgs e)
        {
            if (category_cmb.SelectedValue == null)
                return;

            if (cmb_shelf.SelectedValue == null)
                return;

            LoadBooks();
        }

        // THE CLEAR FILTER BUTTON
        private void btnClear_Click(object sender, EventArgs e)
        {
            txt_search.Clear();

            category_cmb.SelectedIndex = 0;

            cmb_shelf.SelectedIndex = 0;

            All_status.SelectedIndex = 0;

            LoadBooks();
        }

        //the pop ups
        private void guna2Button15_Click(object sender, EventArgs e)
        {
           Pop_up_pnl.Visible = !Pop_up_pnl.Visible;
            
        }

        private void close_pop_Click(object sender, EventArgs e)
        {
            Pop_up_pnl.Hide();
        }

    
        private void guna2Button17_Click(object sender, EventArgs e)
        {
            popup_cat.Visible = !popup_cat.Visible;
        }

        private void guna2Button20_Click(object sender, EventArgs e)
        {
            popup_shelf.Visible = !popup_shelf.Visible;
        }

        private void guna2CircleButton15_Click(object sender, EventArgs e)
        {
            popup_shelf.Hide();
        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {
            popup_cat.Hide();

        }

        private void dvg_books_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        
        }
    }
}
