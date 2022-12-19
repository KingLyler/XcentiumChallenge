using System;
using System.Drawing;
using System.Windows.Forms;

namespace XcentiumChallenge
{
    public partial class ApplicationHome : Form
    {

        static ApplicationHome applicationHome;

        public ApplicationHome()
        {
            InitializeComponent();
        }

        private void ApplicationHome_Load(object sender, EventArgs e)
        {
            applicationHome = this;
            // create new Home object and dock in ApplicationHome pnlMain
            Home home = new Home();
            home.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(home);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        bool mouseDown;
        private Point offset;

        private void mouseDown_Event(object sender, MouseEventArgs e)
        {
            offset.X = e.X;
            offset.Y = e.Y;
            mouseDown = true;
        }

        private void mouseMove_Event(object sender, MouseEventArgs e)
        {
            if (mouseDown == true)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new Point(currentScreenPos.X - offset.X, currentScreenPos.Y - offset.Y);
            }
        }

        private void mouseUp_Event(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            // create new Login form object, hide and close ApplicationHome
            LoginHome login = new LoginHome();
            this.Hide();
            login.ShowDialog();
            this.Close();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            // create new Home, dock in pnlMain
            Home home = new Home();
            home.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(home);
            home.BringToFront();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            // create new About, dock in pnlMain
            About about = new About();
            about.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(about);
            about.BringToFront();
        }
    }
}