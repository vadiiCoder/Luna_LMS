namespace Luna_LMS.folder_form
{
    partial class SplashScreen
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashScreen));
            this.Splashscreen_elip = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.bg = new Guna.UI2.WinForms.Guna2PictureBox();
            this.Splash_bg_img = new Guna.UI2.WinForms.Guna2Panel();
            this.loadingProgressBar = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.Exit_btn = new Guna.UI2.WinForms.Guna2ControlBox();
            this.lblPercentage = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.loadingTimer = new System.Windows.Forms.Timer(this.components);
            this.form_drag = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bg)).BeginInit();
            this.Splash_bg_img.SuspendLayout();
            this.SuspendLayout();
            // 
            // Splashscreen_elip
            // 
            this.Splashscreen_elip.BorderRadius = 20;
            this.Splashscreen_elip.TargetControl = this;
            // 
            // bg
            // 
            this.bg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bg.Image = ((System.Drawing.Image)(resources.GetObject("bg.Image")));
            this.bg.ImageRotate = 0F;
            this.bg.Location = new System.Drawing.Point(0, 0);
            this.bg.Margin = new System.Windows.Forms.Padding(4);
            this.bg.Name = "bg";
            this.bg.Size = new System.Drawing.Size(1132, 629);
            this.bg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bg.TabIndex = 0;
            this.bg.TabStop = false;
            // 
            // Splash_bg_img
            // 
            this.Splash_bg_img.BackColor = System.Drawing.Color.Transparent;
            this.Splash_bg_img.Controls.Add(this.loadingProgressBar);
            this.Splash_bg_img.Controls.Add(this.Exit_btn);
            this.Splash_bg_img.Controls.Add(this.lblPercentage);
            this.Splash_bg_img.Controls.Add(this.label2);
            this.Splash_bg_img.Controls.Add(this.label1);
            this.Splash_bg_img.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Splash_bg_img.Location = new System.Drawing.Point(0, 0);
            this.Splash_bg_img.Margin = new System.Windows.Forms.Padding(4);
            this.Splash_bg_img.Name = "Splash_bg_img";
            this.Splash_bg_img.Size = new System.Drawing.Size(1132, 629);
            this.Splash_bg_img.TabIndex = 2;
            this.Splash_bg_img.UseTransparentBackground = true;
            // 
            // loadingProgressBar
            // 
            this.loadingProgressBar.BorderRadius = 4;
            this.loadingProgressBar.FillColor = System.Drawing.Color.White;
            this.loadingProgressBar.Location = new System.Drawing.Point(359, 460);
            this.loadingProgressBar.Name = "loadingProgressBar";
            this.loadingProgressBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(48)))), ((int)(((byte)(66)))));
            this.loadingProgressBar.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(127)))), ((int)(((byte)(143)))));
            this.loadingProgressBar.Size = new System.Drawing.Size(447, 15);
            this.loadingProgressBar.TabIndex = 6;
            this.loadingProgressBar.Text = "guna2ProgressBar1";
            this.loadingProgressBar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // Exit_btn
            // 
            this.Exit_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Exit_btn.BackColor = System.Drawing.Color.Transparent;
            this.Exit_btn.BorderRadius = 10;
            this.Exit_btn.FillColor = System.Drawing.Color.Teal;
            this.Exit_btn.IconColor = System.Drawing.Color.White;
            this.Exit_btn.Location = new System.Drawing.Point(1074, 0);
            this.Exit_btn.Name = "Exit_btn";
            this.Exit_btn.Size = new System.Drawing.Size(57, 52);
            this.Exit_btn.TabIndex = 5;
            // 
            // lblPercentage
            // 
            this.lblPercentage.AutoSize = true;
            this.lblPercentage.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercentage.ForeColor = System.Drawing.Color.White;
            this.lblPercentage.Location = new System.Drawing.Point(506, 408);
            this.lblPercentage.Name = "lblPercentage";
            this.lblPercentage.Size = new System.Drawing.Size(120, 33);
            this.lblPercentage.TabIndex = 4;
            this.lblPercentage.Text = "Loading";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(373, 357);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(410, 41);
            this.label2.TabIndex = 3;
            this.label2.Text = "Library Management System";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(471, 311);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 46);
            this.label1.TabIndex = 2;
            this.label1.Text = "\"Luna LMS\"";
            // 
            // loadingTimer
            // 
            this.loadingTimer.Enabled = true;
            this.loadingTimer.Interval = 30;
            this.loadingTimer.Tick += new System.EventHandler(this.loadingTimer_Tick);
            // 
            // form_drag
            // 
            this.form_drag.DockIndicatorTransparencyValue = 0.6D;
            this.form_drag.TargetControl = this.Splash_bg_img;
            this.form_drag.UseTransparentDrag = true;
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 629);
            this.Controls.Add(this.Splash_bg_img);
            this.Controls.Add(this.bg);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SplashScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashScreen";
            ((System.ComponentModel.ISupportInitialize)(this.bg)).EndInit();
            this.Splash_bg_img.ResumeLayout(false);
            this.Splash_bg_img.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse Splashscreen_elip;
        private Guna.UI2.WinForms.Guna2PictureBox bg;
        private Guna.UI2.WinForms.Guna2Panel Splash_bg_img;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPercentage;
        private System.Windows.Forms.Timer loadingTimer;
        private Guna.UI2.WinForms.Guna2ControlBox Exit_btn;
        private Guna.UI2.WinForms.Guna2ProgressBar loadingProgressBar;
        private Guna.UI2.WinForms.Guna2DragControl form_drag;
    }
}