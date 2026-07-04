//using System;
//using System.Data;
//using System.Drawing;
//using System.Windows.Forms;
//using LiveCharts; // Required NuGet package
//using LiveCharts.WinForms; // Required NuGet package for CartesianChart
//using LiveCharts.Wpf; // Used for charting style properties
//using MySql.Data.MySqlClient;

//namespace Luna_LMS
//{
//    public partial class DashboardForm : Form
//    {
//        // Target connection string to your MySQL database schema
//        private string connectionString = "Server=localhost;Database=Luna_LMS_Db;Uid=root;Pwd=your_password;";

//        // Observable properties bound directly to the UI (handled by LiveCharts)
//        public ChartValues<double> BorrowingValues { get; set; }
//        public ChartValues<double> PopularBooksValues { get; set; }
//        public string[] DayLabels { get; set; }
//        public string[] BookTitleLabels { get; set; }

//        // Field for ccSmoothLine
//        private LiveCharts.WinForms.CartesianChart ccSmoothLine;

//        public DashboardForm()
//        {
//            InitializeComponent();

//            // Initialization properties needed before LiveCharts renders
//            BorrowingValues = new ChartValues<double>();
//            PopularBooksValues = new ChartValues<double>();

//            // The 'DataContext' property is for WPF. For WinForms LiveCharts, data binding is handled directly on the control properties, so you can remove or comment this line out.
//            // DataContext = this; 

//            // Senior Level implementation: Initialize smooth charting via code (more stable than Designer)
//            InitializeSmoothCharting();
//            InitializePopularBooksChart();

//            // Perform initial metric query sync
//            RefreshDashboardMetrics();
//        }

//        private void InitializeSmoothCharting()
//        {
//            // Create a custom smooth line wave chart inside your flpBorrowingContainer
//            // with a gradient fill under the line to match image composition.
//            var gradientBrush = new System.Windows.Media.LinearGradientBrush
//            {
//                StartPoint = new System.Windows.Point(0, 0),
//                EndPoint = new System.Windows.Point(0, 1)
//            };
//            gradientBrush.GradientStops.Add(new System.Windows.Media.GradientStop(System.Windows.Media.Color.FromArgb(200, 20, 184, 166), 0));
//            gradientBrush.GradientStops.Add(new System.Windows.Media.GradientStop(System.Windows.Media.Color.FromArgb(30, 20, 184, 166), 0.7));
//            gradientBrush.GradientStops.Add(new System.Windows.Media.GradientStop(System.Windows.Media.Color.FromArgb(0, 255, 255, 255), 1));

//            ccSmoothLine = new LiveCharts.WinForms.CartesianChart
//            {
//                Dock = DockStyle.Fill,
//                Hoverable = true,
//                DataTooltip = null, // Disables noisy standard tooltips
//            };

//            ccSmoothLine.Series.Add(new LineSeries
//            {
//                Values = BorrowingValues,
//                StrokeThickness = 3,
//                Stroke = System.Windows.Media.Brushes.Teal,
//                Fill = gradientBrush,
//                PointGeometry = null,
//                LineSmoothness = 0.6 // Gives the identical curved wave look
//            });

//            // Set up X-axis Day 1 to Day 31 labels...
//            ccSmoothLine.AxisX.Add(new Axis
//            {
//                Labels = new[] { "Day 1", "Day 5", "Day 10", "Day 15", "Day 20", "Day 25", "Day 31" },
//                Separator = new Separator { StrokeThickness = 0, Step = 1 } // Only horizontal lines
//            });

//            // If the error 'flpBorrowingContainer does not exist in the current context' persists, double check your designer.cs file. flpBorrowingContainer must be defined and initialized there.
//            // flpBorrowingContainer.Controls.Add(ccSmoothLine);
//        }

//        private void InitializePopularBooksChart()
//        {
//            // Setup the horizontal bar chart inside pnlPopularBooks using the Bright Teal theme.
//            // Map labels and values from the Database query...
//        }

//        public void RefreshDashboardMetrics()
//        {
//            // Parallel SQL queries calculating actual counts from your senior schema
//            // e.g., Total Books count, Active Members count (usingSoftDelete),
//            // Current Borrow count (transactions where return_date IS NULL), etc.

//            // ... Execute MySQL Queries here ...

//            // LIVE Updates: Bind results directly to labels
//            // lblTotalBooksCount.Text = ...

//            // LiveCharts Sync: Perform dynamic smooth update
//            BorrowingValues.Clear();
//            PopularBooksValues.Clear();
//            // ... Load MySQL query results into ChartValues to watch the waves animate! ...
//        }
//    }
//}