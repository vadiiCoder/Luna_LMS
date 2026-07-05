using LibraryManagementSystem.Utilities;
using Luna_LMS.Forms;
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
using System.Windows.Forms.DataVisualization.Charting;

namespace Luna_LMS.folder_form
{
    public partial class frmDashboard : Form
    {
        string connectionString = "server=localhost;port=3307;database=library_db;uid=root;pwd=;";

        private Chart borrowingChart;
        private Chart membersChart;

        public frmDashboard()
        {
            InitializeComponent();

            // 1. INITIALIZE BOTH CHARTS FIRST (Creates them in memory)
            InitializeModernChart();
            InitializeMembersChart(); // Make sure this line is here!

            // 2. THEN LOAD DATA INTO THEM
            LoadReportData();
            LoadMembersChartData();
            LoadBooks();
            FetchDatabaseMetrics();

            // 3. START THE TIMER LAST
            chartRefreshTimer.Start();


        }

        //Generating the chart as code
        private void InitializeModernChart()
        {

            // 1. Create Chart Instance of borrowingChart
            borrowingChart = new Chart();
            borrowingChart.Dock = DockStyle.Fill;
            borrowingChart.AntiAliasing = AntiAliasingStyles.All;
            borrowingChart.TextAntiAliasingQuality = TextAntiAliasingQuality.High;

            // 2. Setup Chart Area
            ChartArea chartArea = new ChartArea("MainArea");

            // Background and Borders
            chartArea.BackColor = Color.White;
            chartArea.BorderColor = Color.Transparent;

            // X-Axis Customization (Smooth minimalist lines)
            chartArea.AxisX.MajorGrid.LineColor = Color.FromArgb(240, 242, 245);
            chartArea.AxisX.LineColor = Color.FromArgb(218, 222, 229);
            chartArea.AxisX.LabelStyle.ForeColor = Color.FromArgb(108, 117, 125);
            chartArea.AxisX.LabelStyle.Font = new Font("Segoe UI", 9f);
            chartArea.AxisX.IsMarginVisible = false; // Gives it that edge-to-edge look

            // Y-Axis Customization
            chartArea.AxisY.MajorGrid.LineColor = Color.FromArgb(240, 242, 245);
            chartArea.AxisY.LineColor = Color.Transparent; // Hide vertical axis line for clean look
            chartArea.AxisY.LabelStyle.ForeColor = Color.FromArgb(108, 117, 125);
            chartArea.AxisY.LabelStyle.Font = new Font("Segoe UI", 9f);
            chartArea.AxisY.LabelStyle.Format = "#,##0";

            borrowingChart.ChartAreas.Add(chartArea);

            // 3. Setup Series (Area Chart with Spline Smoothing)
            Series series = new Series("Daily circulation");
            series.ChartType = SeriesChartType.SplineArea; // Makes the lines smooth instead of jagged
            series.XValueType = ChartValueType.String;

            // Color Palette Configuration (Matching your clean blue theme)
            series.Color = Color.FromArgb(40, 54, 153, 212); // Semi-transparent fill for the area
            series.BorderColor = Color.FromArgb(14, 116, 179); // Crisp solid border line
            series.BorderWidth = 3;

            // Clean marker styling on hover/points if needed
            series.MarkerSize = 6;
            series.MarkerColor = Color.FromArgb(14, 116, 179);

            borrowingChart.Series.Add(series);

            // 4. Clean up Titles/Legends
            Title title = new Title("Borrowing Activity", Docking.Top, new Font("Segoe UI", 14f, FontStyle.Bold), Color.FromArgb(33, 37, 41));
            title.Alignment = ContentAlignment.TopLeft;
            borrowingChart.Titles.Add(title);

            // Add to your Form or custom Panel container
            this.panelChartContainer.Controls.Add(borrowingChart);
        }

        //loading the report data of borrows
        private void LoadReportData()
        {
            // Connection string to your database - adjust credentials if necessary
            string connString = "server=localhost;port=3307;database=library_db;uid=root;";

            // Query calculates total transactions recorded up to each unique date
            string query = @"
        SELECT 
            DATE_FORMAT(borrow_date, '%b %d') AS FormattedDate, 
            COUNT(*) AS TotalBorrows 
        FROM borrow_transactions 
        GROUP BY DATE(borrow_date) 
        ORDER BY DATE(borrow_date) ASC 
        LIMIT 10;";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        conn.Open();
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            // Clear previous points before plotting new data to avoid line overlapping
                            if (borrowingChart.Series.Count > 0)
                            {
                                borrowingChart.Series["Daily circulation"].Points.Clear();
                            }

                            while (reader.Read())
                            {
                                string dayLabel = reader["FormattedDate"].ToString();
                                int transactionCount = Convert.ToInt32(reader["TotalBorrows"]);

                                // Seamlessly plot live data point
                                borrowingChart.Series["Daily circulation"].Points.AddXY(dayLabel, transactionCount);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Stop timer temporarily on failure so an alert loop doesn't lock up your screen
                chartRefreshTimer.Stop();
                MessageBox.Show("Database Error: " + ex.Message, "Live Chart Link Fault", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //Genearting the chart memeber
        private void InitializeMembersChart()
        {
            // 1. Create Chart Control Instance
            membersChart = new Chart();
            membersChart.Dock = DockStyle.Fill;
            membersChart.AntiAliasing = AntiAliasingStyles.All;
            membersChart.TextAntiAliasingQuality = TextAntiAliasingQuality.High;

            // 2. Setup Chart Canvas Area
            ChartArea chartArea = new ChartArea("MembersArea");
            chartArea.BackColor = Color.White;
            chartArea.BorderColor = Color.Transparent;

            // Custom Grid Lines & Label Formatting (Matching your design)
            chartArea.AxisX.MajorGrid.LineColor = Color.FromArgb(245, 246, 248);
            chartArea.AxisX.LineColor = Color.FromArgb(218, 222, 229);
            chartArea.AxisX.LabelStyle.ForeColor = Color.FromArgb(108, 117, 125);
            chartArea.AxisX.LabelStyle.Font = new Font("Segoe UI", 9f);

            chartArea.AxisY.MajorGrid.LineColor = Color.FromArgb(245, 246, 248);
            chartArea.AxisY.LineColor = Color.Transparent; 
            chartArea.AxisY.LabelStyle.ForeColor = Color.FromArgb(108, 117, 125);
            chartArea.AxisY.LabelStyle.Font = new Font("Segoe UI", 9f);
            chartArea.AxisY.Maximum = 100; // Matches the 100 max boundary in your image

            membersChart.ChartAreas.Add(chartArea);

            // 3. Create "New Members" Series (Green Bar)
            Series newMembersSeries = new Series("New Members");
            newMembersSeries.ChartType = SeriesChartType.Column;
            newMembersSeries.Color = Color.FromArgb(40, 167, 69); // Clean UI Emerald Green
            newMembersSeries.CustomProperties = "PointWidth=0.3"; // Slimmer sleek bar profile
            membersChart.Series.Add(newMembersSeries);

            // 4. Create "Active Members" Series (Blue Bar)
            Series activeMembersSeries = new Series("Active Members");
            activeMembersSeries.ChartType = SeriesChartType.Column;
            activeMembersSeries.Color = Color.FromArgb(24, 119, 242); // Modern Accent Blue
            activeMembersSeries.CustomProperties = "PointWidth=0.3";
            membersChart.Series.Add(activeMembersSeries);

            // 5. Title & Custom Legend setup
            Title title = new Title("Members Overview", Docking.Top, new Font("Segoe UI", 14f, FontStyle.Bold), Color.FromArgb(33, 37, 41));
            title.Alignment = ContentAlignment.TopLeft;
            membersChart.Titles.Add(title);

            Legend legend = new Legend("MainLegend");
            legend.Docking = Docking.Top;
            legend.Alignment = StringAlignment.Center;
            legend.Font = new Font("Segoe UI", 9f);
            legend.ForeColor = Color.FromArgb(33, 37, 41);
            membersChart.Legends.Add(legend);

            // 6. Inject control cleanly into your newly designed container panel
            this.panelMembersContainer.Controls.Add(membersChart);
        }

        //loading
        private void FetchDatabaseMetrics()
        {
            try
            {
                // Retrieve metrics from MySQL database
                lblTotalUsers.Text = DbHelper.ExecuteScalar("SELECT COUNT(*) FROM members").ToString();
                lblTotalBooks.Text = DbHelper.ExecuteScalar("SELECT COUNT(*) FROM books").ToString();
                lblTotalBorrowed.Text = DbHelper.ExecuteScalar("SELECT COUNT(*) FROM book_copies WHERE status = 'Borrowed'").ToString();
                lblOverdueBooks.Text = DbHelper.ExecuteScalar("SELECT COUNT(*) FROM borrow_transactions WHERE status = 'Overdue'").ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Dashboard query error: {ex.Message}");
            }
        }

        //loading members data
        private void LoadMembersChartData()
        {
            string connString = "server=localhost;port=3307;database=library_db;uid=root;";

            // We use created_at instead of join_date, and filter out soft-deleted members
            string query = @"
        SELECT 
            CONCAT('Week ', WEEK(created_at) - WEEK(DATE_SUB(created_at, INTERVAL DAYOFMONTH(created_at)-1 DAY)) + 1) AS WeekLabel,
            COUNT(*) AS NewCount,
            SUM(CASE WHEN status = 'Active' THEN 1 ELSE 0 END) AS ActiveCount
        FROM members
        WHERE is_deleted = 0
          AND created_at >= DATE_SUB(NOW(), INTERVAL 1 MONTH)
        GROUP BY WeekLabel
        ORDER BY WeekLabel ASC;";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        conn.Open();
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            membersChart.Series["New Members"].Points.Clear();
                            membersChart.Series["Active Members"].Points.Clear();

                            while (reader.Read())
                            {
                                string week = reader["WeekLabel"].ToString();
                                int newMembers = Convert.ToInt32(reader["NewCount"]);
                                int activeMembers = Convert.ToInt32(reader["ActiveCount"]);

                                membersChart.Series["New Members"].Points.AddXY(week, newMembers);
                                membersChart.Series["Active Members"].Points.AddXY(week, activeMembers);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Members Data Error: " + ex.Message);
            }
        }



        // 3. The Auto-Refresh Loop
        private void chartRefreshTimer_Tick(object sender, EventArgs e)
        {
            // This executes background updates every single second automatically
            LoadReportData();
            LoadMembersChartData();
            LoadBooks();
        }

        //book button
        private void book_btn_Click(object sender, EventArgs e)
        {
            frmBook book = new frmBook();
            book.Show();
            this.Hide();
        }

        private void LoadBooks()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"
                SELECT
                    id,
                    cover_image_path,
                    title,
                    author,
                    isbn,
                    category_id,
                    created_at
                FROM books";

                    MySqlDataAdapter da = new MySqlDataAdapter(query, conn);

                    DataTable dt = new DataTable();

                    da.Fill(dt);

                    dvg_books.DataSource = dt;

                    // ========= BEAUTIFY THE GRID =========

                    dvg_books.RowTemplate.Height = 50;
                    dvg_books.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dvg_books.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    dvg_books.AllowUserToAddRows = false;
                    dvg_books.ReadOnly = true;

                    if (dvg_books.Columns["cover_image_path"] is DataGridViewImageColumn img)
                    {
                        img.ImageLayout = DataGridViewImageCellLayout.Zoom;
                        img.Width = 60;
                    }

                    dvg_books.Columns["id"].Width = 10;
                    dvg_books.Columns["isbn"].Width = 200;//150
                    dvg_books.Columns["created_at"].Width = 50;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //log out btn action
        private void btn_logout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have been logged out successfully.", "Logout", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            FrmLogin loginForm = new FrmLogin();
            loginForm.ShowDialog();
            this.Hide();
        }

        //member button action
        private void btn_mem_Click(object sender, EventArgs e)
        {
            frmMember member = new frmMember();
            member.Show();
            this.Hide();
        }

        //borrow button action
        private void btn_borrow_Click(object sender, EventArgs e)
        {
            frmBorrow borrow = new frmBorrow();
            borrow.Show();
            this.Hide();
        }
    }
}
