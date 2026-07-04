using System;
using System.Drawing;
using System.Windows.Forms;

namespace Luna_LMS
{
    public partial class LoginForm : Form
    {
        // Smooth borderless control tracking variables
        private bool isDragging = false;
        private Point mouseOffset;

        public LoginForm()
        {
            InitializeComponent();
            WireFormDragHandlers();
        }

        private void WireFormDragHandlers()
        {
            // Wire mouse handlers directly to the form canvas background for dragging
            this.MouseDown += LoginForm_MouseDown;
            this.MouseMove += LoginForm_MouseMove;
            this.MouseUp += LoginForm_MouseUp;

            // Wire handlers to title to make dragging natural
            this.lblTitle.MouseDown += LoginForm_MouseDown;
            this.lblTitle.MouseMove += LoginForm_MouseMove;
            this.lblTitle.MouseUp += LoginForm_MouseUp;

            // Simple button connections
            this.btnClose.Click += (s, e) => Application.Exit();
            this.btnClose.MouseEnter += (s, e) => btnClose.ForeColor = Color.White;
            this.btnClose.MouseLeave += (s, e) => btnClose.ForeColor = Color.FromArgb(148, 163, 184);
        }

        private void LoginForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                mouseOffset = new Point(e.X, e.Y);
            }
        }

        private void LoginForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                this.Location = new Point(currentScreenPos.X - mouseOffset.X, currentScreenPos.Y - mouseOffset.Y);
            }
        }

        private void LoginForm_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }
    }
}