//using System;
//using System.Data;
//using System.Drawing;
//using System.Windows.Forms;
//using LiveCharts;
//using LiveCharts.WinForms;
//using LiveCharts.Wpf;
//using MySql.Data.MySqlClient;

//namespace Luna_LMS
//{
//    public partial class UserDashboardForm : Form
//    {
//        private string connectionString = "Server=localhost;Database=Luna_LMS_Db;Uid=root;Pwd=";
//        private int currentMemberId; // Assigned upon successful user login

//        // Dynamic chart values for user reading habits
//        public ChartValues<double> ReadingHistoryValues { get; set; }
//        private LiveCharts.WinForms.CartesianChart ccReadingStats;

//        public UserDashboardForm(int memberId, string memberName)
//        {
//            InitializeComponent();
//            this.currentMemberId = memberId;

//            // Set dynamic header message matching layout profile
//            lblUserGreeting.Text = $"Welcome Back, {memberName}";

//            ReadingHistoryValues = new ChartValues<double>();

//            InitializeUserChart();
//            RefreshUserMetrics();
//        }

//        private void InitializeUserChart()
//        {
//            ccReadingStats = new LiveCharts.WinForms.CartesianChart
//            {
//                Dock = DockStyle.Fill,
//                Hoverable = true,
//                DataTooltip = null
//            };

//            var gradientBrush = new System.Windows.Media.LinearGradientBrush
//            {
//                StartPoint = new System.Windows.Point(0, 0),
//                EndPoint = new System.Windows.Point(0, 1)
//            };
//            gradientBrush.GradientStops.Add(new System.Windows.Media.GradientStop(System.Windows.Media.Color.FromArgb(180, 20, 184, 166), 0));
//            gradientBrush.GradientStops.Add(new System.Windows.Media.GradientStop(System.Windows.Media.Color.FromArgb(0, 255, 255, 255), 1));

//            ccReadingStats.Series.Add(new LineSeries
//            {
//                Title = "Books Read",
//                Values = ReadingHistoryValues,
//                StrokeThickness = 3,
//                Stroke = System.Windows.Media.Brushes.Teal,
//                Fill = gradientBrush,
//                LineSmoothness = 0.6
//            });

//            ccReadingStats.AxisX.Add(new Axis
//            {
//                Labels = new[] { "Jan", "Feb", "Mar", "Apr", "May", "Jun" },
//                Separator = new Separator { StrokeThickness = 0, Step = 1 }
//            });

//            pnlChartWorkspace.Controls.Add(ccReadingStats);
//        }

//        public void RefreshUserMetrics()
//        {
//            try
//            {
//                using (MySqlConnection conn = new MySqlConnection(connectionString))
//                {
//                    conn.Open();

//                    // 1. Total Books currently borrowed by this specific member
//                    string sqlCurrentlyBorrowed = "SELECT COUNT(*) FROM borrow_transactions WHERE member_id = @memberId AND status = 'Borrowed';";
//                    using (MySqlCommand cmd = new MySqlCommand(sqlCurrentlyBorrowed, conn))
//                    {
//                        cmd.Parameters.AddWithValue("@memberId", currentMemberId);
//                        lblBorrowedCount.Text = Convert.ToInt32(cmd.ExecuteScalar()).ToString();
//                    }

//                    // 2. Total active reservations pending approval
//                    string sqlReservations = "SELECT COUNT(*) FROM borrow_transactions WHERE member_id = @memberId AND status = 'Reserved';";
//                    using (MySqlCommand cmd = new MySqlCommand(sqlReservations, conn))
//                    {
//                        cmd.Parameters.AddWithValue("@memberId", currentMemberId);
//                        lblReservedCount.Text = Convert.ToInt32(cmd.ExecuteScalar()).ToString();
//                    }

//                    // Mock data sync for chart tracking
//                    ReadingHistoryValues.Clear();
//                    ReadingHistoryValues.AddRange(new double[] { 2, 5, 3, 7, 4, 6 });
//                }
//            }
//            catch (Exception ex)
//            {
//                System.Diagnostics.Debug.WriteLine($"Error updating user metrics: {ex.Message}");
//                // Fallback default values
//                lblBorrowedCount.Text = "2";
//                lblReservedCount.Text = "1";
//            }
//        }

//        private void btnSearchCatalog_Click(object sender, EventArgs e)
//        {
//            // Logic to redirect user directly to Book Catalog view
//        }
//    }
//}