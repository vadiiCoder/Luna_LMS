//// =========================================================================
//// DashboardForm.Designer.cs (OPTIMIZED DESIGNER CODE)
//// =========================================================================
//using System.Drawing;
//using System.Windows.Forms;

//namespace Luna_LMS
//{
//    // Fix 1: Ensure the namespace and class name "DashboardForm" perfectly match the logic file.
//    partial class DashboardForm
//    {
//        private System.ComponentModel.IContainer components = null;

//        // Form Layout Panels
//        private Panel pnlHeaderBar;
//        private Panel pnlBorrowingContainer;
//        private Panel pnlQuickBorrowReturn;
//        private Panel pnlReservationsPending;
//        private Panel pnlPopularThisMonth;
//        private Panel pnlSystemNotifications;

//        // Custom code-only chart and component references
//        // Fix 2: Define CartesianChart explicitly as LiveCharts.WinForms to stop ambiguity.
//        private LiveCharts.WinForms.CartesianChart cartesianChart1;
//        private Label lblTotalBooksValue;
//        private Label lblActiveMembersValue;
//        private Label lblCurrentBorrowsValue;
//        private Label lblOverdueCountValue;

//        // Senior architecture cleaning procedure
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
//            this.pnlHeaderBar = new System.Windows.Forms.Panel();
//            this.pnlBorrowingContainer = new System.Windows.Forms.Panel();
//            this.pnlQuickBorrowReturn = new System.Windows.Forms.Panel();
//            this.pnlReservationsPending = new System.Windows.Forms.Panel();
//            this.pnlPopularThisMonth = new System.Windows.Forms.Panel();
//            this.pnlSystemNotifications = new System.Windows.Forms.Panel();
//            this.flpBorrowingContainer = new Guna.UI2.WinForms.Guna2Panel();
//            this.flpBorrowingContainer.SuspendLayout();
//            this.SuspendLayout();
//            // 
//            // pnlHeaderBar
//            // 
//            this.pnlHeaderBar.Location = new System.Drawing.Point(0, 0);
//            this.pnlHeaderBar.Name = "pnlHeaderBar";
//            this.pnlHeaderBar.Size = new System.Drawing.Size(200, 100);
//            this.pnlHeaderBar.TabIndex = 0;
//            // 
//            // pnlBorrowingContainer
//            // 
//            this.pnlBorrowingContainer.Location = new System.Drawing.Point(0, 0);
//            this.pnlBorrowingContainer.Name = "pnlBorrowingContainer";
//            this.pnlBorrowingContainer.Size = new System.Drawing.Size(200, 100);
//            this.pnlBorrowingContainer.TabIndex = 1;
//            // 
//            // pnlQuickBorrowReturn
//            // 
//            this.pnlQuickBorrowReturn.Location = new System.Drawing.Point(0, 0);
//            this.pnlQuickBorrowReturn.Name = "pnlQuickBorrowReturn";
//            this.pnlQuickBorrowReturn.Size = new System.Drawing.Size(200, 100);
//            this.pnlQuickBorrowReturn.TabIndex = 0;
//            // 
//            // pnlReservationsPending
//            // 
//            this.pnlReservationsPending.Location = new System.Drawing.Point(0, 0);
//            this.pnlReservationsPending.Name = "pnlReservationsPending";
//            this.pnlReservationsPending.Size = new System.Drawing.Size(200, 100);
//            this.pnlReservationsPending.TabIndex = 0;
//            // 
//            // pnlPopularThisMonth
//            // 
//            this.pnlPopularThisMonth.Location = new System.Drawing.Point(0, 0);
//            this.pnlPopularThisMonth.Name = "pnlPopularThisMonth";
//            this.pnlPopularThisMonth.Size = new System.Drawing.Size(200, 100);
//            this.pnlPopularThisMonth.TabIndex = 0;
//            // 
//            // pnlSystemNotifications
//            // 
//            this.pnlSystemNotifications.Location = new System.Drawing.Point(0, 0);
//            this.pnlSystemNotifications.Name = "pnlSystemNotifications";
//            this.pnlSystemNotifications.Size = new System.Drawing.Size(200, 100);
//            this.pnlSystemNotifications.TabIndex = 0;
//            // 
//            // flpBorrowingContainer
//            // 
//            //this.flpBorrowingContainer.Controls.Add(this.cartesianChart1);
//            this.flpBorrowingContainer.Location = new System.Drawing.Point(105, 152);
//            this.flpBorrowingContainer.Name = "flpBorrowingContainer";
//            this.flpBorrowingContainer.Size = new System.Drawing.Size(413, 275);
//            this.flpBorrowingContainer.TabIndex = 2;
//            // 
//            // cartesianChart1
//            // 
//            //this.cartesianChart1.Dock = System.Windows.Forms.DockStyle.Fill;
//            //this.cartesianChart1.Location = new System.Drawing.Point(0, 0);
//            //this.cartesianChart1.Name = "cartesianChart1";
//            //this.cartesianChart1.Size = new System.Drawing.Size(413, 275);
//            //this.cartesianChart1.TabIndex = 0;
//            //this.cartesianChart1.Text = "cartesianChart1";
//            // 
//            // DashboardForm
//            // 
//            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
//            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
//            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
//            this.ClientSize = new System.Drawing.Size(1280, 720);
//            this.Controls.Add(this.flpBorrowingContainer);
//            this.Controls.Add(this.pnlHeaderBar);
//            this.Controls.Add(this.pnlBorrowingContainer);
//            this.Name = "DashboardForm";
//            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
//            this.Text = "Dashboard V1.0";
//            this.flpBorrowingContainer.ResumeLayout(false);
//            this.ResumeLayout(false);

//        }

//        private Guna.UI2.WinForms.Guna2Panel flpBorrowingContainer;
//        //private LiveCharts.WinForms.CartesianChart cartesianChart1;
//    }
//}