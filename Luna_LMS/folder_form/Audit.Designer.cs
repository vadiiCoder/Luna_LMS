//using System.Drawing;
//using System.Windows.Forms;

//namespace Luna_LMS
//{
//    partial class UserDashboardForm
//    {
//        private System.ComponentModel.IContainer components = null;

//        // Structural UI Panels
//        private Panel pnlSidebar;
//        private Panel pnlTopHeader;
//        private Panel pnlMainContent;

//        // Navigation Options (User Version)
//        private Button btnDashboard;
//        private Button btnBrowseBooks;
//        private Button btnMyHistory;
//        private Button btnReservations;
//        private Button btnProfileSettings;
//        private Button btnLogout;

//        // KPI User Performance Cards
//        private Panel cardMyBorrows;
//        private Panel cardMyReservations;
//        private Panel cardOverdueFines;

//        private Label lblUserGreeting;
//        private Label lblBorrowedCount;
//        private Label lblReservedCount;
//        private Label lblFinesValue;

//        // Main dynamic display modules
//        private Panel pnlChartWorkspace;
//        private Panel pnlMyBooksList;
//        private Panel pnlAnnouncements;

//        protected override void Dispose(bool disposing)
//        {
//            if (disposing && (components != null))
//            {
//                components.Dispose();
//            }
//            base.Dispose(disposing);
//        }

//        private void InitializeComponent()
//        {
//            this.pnlSidebar = new Panel();
//            this.pnlTopHeader = new Panel();
//            this.pnlMainContent = new Panel();
//            this.lblUserGreeting = new Label();

//            this.cardMyBorrows = new Panel();
//            this.cardMyReservations = new Panel();
//            this.cardOverdueFines = new Panel();

//            this.lblBorrowedCount = new Label();
//            this.lblReservedCount = new Label();
//            this.lblFinesValue = new Label();

//            this.pnlChartWorkspace = new Panel();
//            this.pnlMyBooksList = new Panel();
//            this.pnlAnnouncements = new Panel();

//            this.SuspendLayout();

//            // 
//            // pnlSidebar: Clean layout matches Admin UI Sidebar Theme
//            // 
//            this.pnlSidebar.BackColor = Color.FromArgb(30, 41, 59); // Charcoal Slate Navy (#1E293B)
//            this.pnlSidebar.Dock = DockStyle.Left;
//            this.pnlSidebar.Width = 240;

//            // ... (Initialize your customized flat buttons: Dashboard, Browse Books, etc. inside pnlSidebar) ...

//            // 
//            // pnlTopHeader: Clean horizontal bar for contextual branding search elements
//            // 
//            this.pnlTopHeader.BackColor = Color.White;
//            this.pnlTopHeader.Dock = DockStyle.Top;
//            this.pnlTopHeader.Height = 70;

//            this.lblUserGreeting.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
//            this.lblUserGreeting.ForeColor = Color.FromArgb(15, 23, 42);
//            this.lblUserGreeting.Location = new Point(20, 20);
//            this.lblUserGreeting.Size = new Size(400, 35);
//            this.pnlTopHeader.Controls.Add(this.lblUserGreeting);

//            // 
//            // pnlMainContent: Fluid background workspace layer
//            // 
//            this.pnlMainContent.BackColor = Color.FromArgb(248, 250, 252); // Muted canvas white (#F8FAFC)
//            this.pnlMainContent.Dock = DockStyle.Fill;
//            this.pnlMainContent.Padding = new Padding(25);

//            // 
//            // cardMyBorrows: Active current checked out assets
//            // 
//            this.cardMyBorrows.BackColor = Color.White;
//            this.cardMyBorrows.Size = new Size(220, 110);
//            this.cardMyBorrows.Location = new Point(25, 25);

//            this.lblBorrowedCount.Font = new Font("Segoe UI", 26F, FontStyle.Bold);
//            this.lblBorrowedCount.ForeColor = Color.FromArgb(20, 184, 166); // Teal theme accent
//            this.lblBorrowedCount.Location = new Point(15, 40);
//            this.cardMyBorrows.Controls.Add(this.lblBorrowedCount);

//            // 
//            // pnlChartWorkspace: Displays User Reading metrics
//            // 
//            this.pnlChartWorkspace.BackColor = Color.White;
//            this.pnlChartWorkspace.Size = new Size(460, 320);
//            this.pnlChartWorkspace.Location = new Point(25, 160);

//            // 
//            // pnlMyBooksList: Custom grid tracking return deadlines
//            // 
//            this.pnlMyBooksList.BackColor = Color.White;
//            this.pnlMyBooksList.Size = new Size(460, 180);
//            this.pnlMyBooksList.Location = new Point(25, 500);

//            // Adding controls into workspace views
//            this.pnlMainContent.Controls.Add(this.cardMyBorrows);
//            this.pnlMainContent.Controls.Add(this.pnlChartWorkspace);
//            this.pnlMainContent.Controls.Add(this.pnlMyBooksList);

//            // 
//            // UserDashboardForm Window definitions
//            // 
//            this.AutoScaleDimensions = new SizeF(8F, 16F);
//            this.AutoScaleMode = AutoScaleMode.Font;
//            this.ClientSize = new Size(1280, 750);
//            this.Controls.Add(this.pnlMainContent);
//            this.Controls.Add(this.pnlTopHeader);
//            this.Controls.Add(this.pnlSidebar);
//            this.MinimumSize = new Size(1024, 728);
//            this.Name = "UserDashboardForm";
//            this.StartPosition = FormStartPosition.CenterScreen;
//            this.Text = "Luna LMS - Member Portal";
//            this.ResumeLayout(false);
//        }
//    }
//}