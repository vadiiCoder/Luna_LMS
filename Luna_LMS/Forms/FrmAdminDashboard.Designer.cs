using System.Windows.Forms;

namespace Luna_LMS.Forms
{
    partial class FrmAdminDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdminDashboard));
            this.pnl_Navbar = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.guna2Button6 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button7 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button5 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.btn_dash = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel13 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.hide_logo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pnl_header = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.maximize = new Guna.UI2.WinForms.Guna2ControlBox();
            this.label9 = new System.Windows.Forms.Label();
            this.close = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2CirclePictureBox2 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2CirclePictureBox3 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.guna2Panel10 = new Guna.UI2.WinForms.Guna2Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.guna2Panel9 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel8 = new Guna.UI2.WinForms.Guna2Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnl_browed = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2CircleButton5 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.lblTotalBorrowed = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2Panel7 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2CircleButton2 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.guna2Panel5 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.guna2Panel6 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);

            this.pnl_Navbar.SuspendLayout();
            this.guna2Panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hide_logo)).BeginInit();
            this.pnl_header.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox3)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnl_browed.SuspendLayout();
            this.guna2Panel7.SuspendLayout();
            this.guna2Panel5.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();

            // ==========================================
            // FORM & ELIPSE CONFIG
            // ==========================================
            this.guna2Elipse1.BorderRadius = 40;
            this.guna2Elipse1.TargetControl = this;

            // ==========================================
            // SIDEBAR NAVIGATION PANEL (pnl_Navbar)
            // ==========================================
            this.pnl_Navbar.BackColor = System.Drawing.Color.Transparent;
            this.pnl_Navbar.Controls.Add(this.guna2Separator1);
            this.pnl_Navbar.Controls.Add(this.guna2Button6);
            this.pnl_Navbar.Controls.Add(this.guna2Button1);
            this.pnl_Navbar.Controls.Add(this.guna2Button7);
            this.pnl_Navbar.Controls.Add(this.guna2Button4);
            this.pnl_Navbar.Controls.Add(this.guna2Button5);
            this.pnl_Navbar.Controls.Add(this.guna2Button3);
            this.pnl_Navbar.Controls.Add(this.guna2Button2);
            this.pnl_Navbar.Controls.Add(this.btn_dash);
            this.pnl_Navbar.Controls.Add(this.guna2Panel13);
            this.pnl_Navbar.Controls.Add(this.guna2Panel4);
            this.pnl_Navbar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_Navbar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            this.pnl_Navbar.Location = new System.Drawing.Point(0, 0);
            this.pnl_Navbar.Name = "pnl_Navbar";
            this.pnl_Navbar.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.pnl_Navbar.Size = new System.Drawing.Size(240, 884);
            this.pnl_Navbar.TabIndex = 32;

            this.guna2Separator1.Location = new System.Drawing.Point(13, 558);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(200, 10);
            this.guna2Separator1.TabIndex = 76;

            // --- BUTTONS ---
            this.guna2Button6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Button6.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.guna2Button6.ForeColor = System.Drawing.Color.White;
            this.guna2Button6.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button6.Image")));
            this.guna2Button6.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button6.ImageOffset = new System.Drawing.Point(5, 0);
            this.guna2Button6.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2Button6.Location = new System.Drawing.Point(10, 768);
            this.guna2Button6.Margin = new System.Windows.Forms.Padding(5);
            this.guna2Button6.Name = "guna2Button6";
            this.guna2Button6.Size = new System.Drawing.Size(220, 58);
            this.guna2Button6.TabIndex = 75;
            this.guna2Button6.Text = "  Settings";
            this.guna2Button6.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;

            this.guna2Button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Button1.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.ForeColor = System.Drawing.Color.Red;
            this.guna2Button1.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button1.Image")));
            this.guna2Button1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button1.ImageOffset = new System.Drawing.Point(5, 0);
            this.guna2Button1.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2Button1.Location = new System.Drawing.Point(10, 826);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(5);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(220, 58);
            this.guna2Button1.TabIndex = 74;
            this.guna2Button1.Text = "  Log Out";
            this.guna2Button1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;

            this.guna2Button7.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Button7.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.guna2Button7.ForeColor = System.Drawing.Color.White;
            this.guna2Button7.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button7.Image")));
            this.guna2Button7.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button7.ImageOffset = new System.Drawing.Point(5, 0);
            this.guna2Button7.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2Button7.Location = new System.Drawing.Point(10, 432);
            this.guna2Button7.Margin = new System.Windows.Forms.Padding(5);
            this.guna2Button7.Name = "guna2Button7";
            this.guna2Button7.Size = new System.Drawing.Size(220, 58);
            this.guna2Button7.TabIndex = 73;
            this.guna2Button7.Text = "  Reports";
            this.guna2Button7.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;

            this.guna2Button4.BorderRadius = 20;
            this.guna2Button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Button4.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.guna2Button4.ForeColor = System.Drawing.Color.White;
            this.guna2Button4.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button4.Image")));
            this.guna2Button4.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button4.ImageOffset = new System.Drawing.Point(5, 0);
            this.guna2Button4.ImageSize = new System.Drawing.Size(25, 25);
            this.guna2Button4.Location = new System.Drawing.Point(10, 374);
            this.guna2Button4.Margin = new System.Windows.Forms.Padding(5);
            this.guna2Button4.Name = "guna2Button4";
            this.guna2Button4.Size = new System.Drawing.Size(220, 58);
            this.guna2Button4.TabIndex = 72;
            this.guna2Button4.Text = "  Reservations";
            this.guna2Button4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;

            this.guna2Button5.BorderRadius = 20;
            this.guna2Button5.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Button5.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.guna2Button5.ForeColor = System.Drawing.Color.White;
            this.guna2Button5.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button5.Image")));
            this.guna2Button5.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button5.ImageOffset = new System.Drawing.Point(5, 0);
            this.guna2Button5.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2Button5.Location = new System.Drawing.Point(10, 316);
            this.guna2Button5.Margin = new System.Windows.Forms.Padding(5);
            this.guna2Button5.Name = "guna2Button5";
            this.guna2Button5.Size = new System.Drawing.Size(220, 58);
            this.guna2Button5.TabIndex = 71;
            this.guna2Button5.Text = "  Borrow/Return";
            this.guna2Button5.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;

            this.guna2Button3.BorderRadius = 20;
            this.guna2Button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Button3.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.guna2Button3.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button3.Image")));
            this.guna2Button3.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button3.ImageOffset = new System.Drawing.Point(5, 0);
            this.guna2Button3.ImageSize = new System.Drawing.Size(25, 25);
            this.guna2Button3.Location = new System.Drawing.Point(10, 258);
            this.guna2Button3.Margin = new System.Windows.Forms.Padding(5);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.Size = new System.Drawing.Size(220, 58);
            this.guna2Button3.TabIndex = 70;
            this.guna2Button3.Text = "  Users";
            this.guna2Button3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;

            this.guna2Button2.BorderRadius = 20;
            this.guna2Button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Button2.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button2.Image")));
            this.guna2Button2.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button2.ImageOffset = new System.Drawing.Point(5, 0);
            this.guna2Button2.ImageSize = new System.Drawing.Size(25, 25);
            this.guna2Button2.Location = new System.Drawing.Point(10, 200);
            this.guna2Button2.Margin = new System.Windows.Forms.Padding(5);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(220, 58);
            this.guna2Button2.TabIndex = 69;
            this.guna2Button2.Text = "  Books";
            this.guna2Button2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;

            this.btn_dash.BorderRadius = 10;
            this.btn_dash.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_dash.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(107)))), ((int)(((byte)(128)))));
            this.btn_dash.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btn_dash.ForeColor = System.Drawing.Color.White;
            this.btn_dash.Image = ((System.Drawing.Image)(resources.GetObject("btn_dash.Image")));
            this.btn_dash.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_dash.ImageOffset = new System.Drawing.Point(5, 0);
            this.btn_dash.ImageSize = new System.Drawing.Size(25, 25);
            this.btn_dash.Location = new System.Drawing.Point(10, 142);
            this.btn_dash.Margin = new System.Windows.Forms.Padding(5);
            this.btn_dash.Name = "btn_dash";
            this.btn_dash.Size = new System.Drawing.Size(220, 58);
            this.btn_dash.TabIndex = 68;
            this.btn_dash.Text = "  Dashboard";
            this.btn_dash.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;

            this.guna2Panel13.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel13.Location = new System.Drawing.Point(10, 86);
            this.guna2Panel13.Name = "guna2Panel13";
            this.guna2Panel13.Size = new System.Drawing.Size(220, 56);
            this.guna2Panel13.TabIndex = 49;

            this.guna2Panel4.Controls.Add(this.hide_logo);
            this.guna2Panel4.Controls.Add(this.label2);
            this.guna2Panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            this.guna2Panel4.Location = new System.Drawing.Point(10, 0);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.Size = new System.Drawing.Size(220, 86);
            this.guna2Panel4.TabIndex = 0;

            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(85, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 28);
            this.label2.TabIndex = 56;
            this.label2.Text = "Luna LMS";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.hide_logo.Image = ((System.Drawing.Image)(resources.GetObject("hide_logo.Image")));
            this.hide_logo.Location = new System.Drawing.Point(3, 12);
            this.hide_logo.Name = "hide_logo";
            this.hide_logo.Size = new System.Drawing.Size(80, 64);
            this.hide_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.hide_logo.TabIndex = 0;
            this.hide_logo.TabStop = false;

            // ==========================================
            // TOP HEADER PANEL (pnl_header)
            // ==========================================
            this.pnl_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            this.pnl_header.Controls.Add(this.guna2ImageButton1);
            this.pnl_header.Controls.Add(this.guna2ControlBox2);
            this.pnl_header.Controls.Add(this.maximize);
            this.pnl_header.Controls.Add(this.label9);
            this.pnl_header.Controls.Add(this.close);
            this.pnl_header.Controls.Add(this.guna2TextBox1);
            this.pnl_header.Controls.Add(this.guna2Panel3);
            this.pnl_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_header.Location = new System.Drawing.Point(240, 0);
            this.pnl_header.Name = "pnl_header";
            this.pnl_header.Size = new System.Drawing.Size(1214, 121);
            this.pnl_header.TabIndex = 33;

            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox2.Location = new System.Drawing.Point(1008, 0);
            this.guna2ControlBox2.Size = new System.Drawing.Size(71, 40);

            this.maximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximize.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.maximize.FillColor = System.Drawing.Color.Transparent;
            this.maximize.IconColor = System.Drawing.Color.White;
            this.maximize.Location = new System.Drawing.Point(1073, 0);
            this.maximize.Size = new System.Drawing.Size(71, 40);

            this.close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.close.HoverState.FillColor = System.Drawing.Color.Red;
            this.close.IconColor = System.Drawing.Color.White;
            this.close.Location = new System.Drawing.Point(1143, 0);
            this.close.Size = new System.Drawing.Size(71, 40);

            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(64, 64);
            this.label9.Size = new System.Drawing.Size(132, 31);
            this.label9.Text = "Dashboard";

            this.guna2TextBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2TextBox1.BorderRadius = 8;
            this.guna2TextBox1.FillColor = System.Drawing.Color.WhiteSmoke;
            this.guna2TextBox1.IconRight = ((System.Drawing.Image)(resources.GetObject("guna2TextBox1.IconRight")));
            this.guna2TextBox1.Location = new System.Drawing.Point(399, 46);
            this.guna2TextBox1.Size = new System.Drawing.Size(400, 36);
            this.guna2TextBox1.PlaceholderText = "Search anything..";

            // --- Header Sub-panels ---
            this.guna2Panel3.Controls.Add(this.guna2CirclePictureBox2);
            this.guna2Panel3.Controls.Add(this.guna2CirclePictureBox3);
            this.guna2Panel3.Controls.Add(this.lblTitle);
            this.guna2Panel3.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(200, 100);

            // ==========================================
            // MAIN BODY CONTAINER (guna2Panel1)
            // ==========================================
            this.guna2Panel1.Controls.Add(this.tableLayoutPanel2);
            this.guna2Panel1.Controls.Add(this.tableLayoutPanel1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(240, 121);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1214, 763);
            this.guna2Panel1.TabIndex = 34;

            // ==========================================
            // METRIC CARDS GRID (tableLayoutPanel1)
            // ==========================================
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.34F));
            this.tableLayoutPanel1.Controls.Add(this.pnl_browed, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.guna2Panel7, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.guna2Panel5, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1214, 140);
            this.tableLayoutPanel1.TabIndex = 0;

            // --- Card 1: Total Books ---
            this.guna2Panel5.BorderRadius = 15;
            this.guna2Panel5.FillColor = System.Drawing.Color.White;
            this.guna2Panel5.Controls.Add(this.guna2CircleButton1);
            this.guna2Panel5.Controls.Add(this.label3);
            this.guna2Panel5.Controls.Add(this.label6);
            this.guna2Panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel5.Margin = new System.Windows.Forms.Padding(15);

            this.label6.Text = "Total Books";
            this.label6.Location = new System.Drawing.Point(90, 20);
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label6.AutoSize = true;

            this.label3.Name = "lblTotalBooks";
            this.label3.AutoSize = false;
            this.label3.Location = new System.Drawing.Point(150, 60);
            this.label3.Size = new System.Drawing.Size(200, 40);
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.label3.Text = "1,284";

            // --- Card 2: Total Users ---
            this.guna2Panel7.BorderRadius = 15;
            this.guna2Panel7.FillColor = System.Drawing.Color.White;
            this.guna2Panel7.Controls.Add(this.guna2CircleButton2);
            this.guna2Panel7.Controls.Add(this.label7);
            this.guna2Panel7.Controls.Add(this.label8);
            this.guna2Panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel7.Margin = new System.Windows.Forms.Padding(15);

            this.label8.Text = "Total Users";
            this.label8.Location = new System.Drawing.Point(90, 20);
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label8.AutoSize = true;

            this.label7.Name = "lblTotalUsers";
            this.label7.AutoSize = false;
            this.label7.Location = new System.Drawing.Point(150, 60);
            this.label7.Size = new System.Drawing.Size(200, 40);
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.label7.Text = "1,284";

            // --- Card 3: Total Borrowed ---
            this.pnl_browed.BorderRadius = 15;
            this.pnl_browed.FillColor = System.Drawing.Color.White;
            this.pnl_browed.Controls.Add(this.guna2CircleButton5);
            this.pnl_browed.Controls.Add(this.lblTotalBorrowed);
            this.pnl_browed.Controls.Add(this.label4);
            this.pnl_browed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_browed.Margin = new System.Windows.Forms.Padding(15);

            this.label4.Text = "Total Borrowed";
            this.label4.Location = new System.Drawing.Point(90, 20);
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label4.AutoSize = true;

            this.lblTotalBorrowed.AutoSize = false;
            this.lblTotalBorrowed.Location = new System.Drawing.Point(150, 60);
            this.lblTotalBorrowed.Size = new System.Drawing.Size(200, 40);
            this.lblTotalBorrowed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalBorrowed.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTotalBorrowed.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTotalBorrowed.Text = "1,284";

            // ==========================================
            // MIDDLE CONTENT PANELS LAYOUT (tableLayoutPanel2)
            // ==========================================
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24F));
            this.tableLayoutPanel2.Controls.Add(this.guna2Panel6, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.guna2Panel8, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.guna2Panel9, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.guna2Panel2, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 140);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1214, 623);
            this.tableLayoutPanel2.TabIndex = 1;

            this.guna2Panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel6.FillColor = System.Drawing.Color.White;
            this.guna2Panel6.Margin = new System.Windows.Forms.Padding(15);

            this.guna2Panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel8.FillColor = System.Drawing.Color.White;
            this.guna2Panel8.Margin = new System.Windows.Forms.Padding(15);

            this.guna2Panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel9.FillColor = System.Drawing.Color.White;
            this.guna2Panel9.Margin = new System.Windows.Forms.Padding(15);
            this.tableLayoutPanel2.SetRowSpan(this.guna2Panel9, 2);

            this.guna2Panel2.Controls.Add(this.label1);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel2.FillColor = System.Drawing.Color.White;
            this.guna2Panel2.Margin = new System.Windows.Forms.Padding(15);
            this.tableLayoutPanel2.SetColumnSpan(this.guna2Panel2, 2);

            // Extra inner layouts initialized safely
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.Size = new System.Drawing.Size(100, 100);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.Size = new System.Drawing.Size(100, 100);
            this.guna2Panel10.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel10.Name = "guna2Panel10";
            this.guna2Panel10.Size = new System.Drawing.Size(100, 100);

            // --- Final Initialization Finisher ---
            this.pnl_Navbar.ResumeLayout(false);
            this.guna2Panel4.ResumeLayout(false);
            this.guna2Panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hide_logo)).EndInit();
            this.pnl_header.ResumeLayout(false);
            this.pnl_header.PerformLayout();
            this.guna2Panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox3)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        // ==========================================
        // COMPONENT VARIABLE FIELDS
        // ==========================================
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Panel pnl_Navbar;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2Button guna2Button6;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button guna2Button7;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private Guna.UI2.WinForms.Guna2Button guna2Button5;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button btn_dash;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel13;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2PictureBox hide_logo;
        private Guna.UI2.WinForms.Guna2Panel pnl_header;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox maximize;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2ControlBox close;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox2;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox3;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel10;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel9;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Guna.UI2.WinForms.Guna2Panel pnl_browed;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton5;
        private System.Windows.Forms.Label lblTotalBorrowed;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel7;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel5;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel6;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
    }
}