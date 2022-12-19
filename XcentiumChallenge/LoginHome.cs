using System;
using System.Drawing;
using System.Windows.Forms;

namespace XcentiumChallenge
{
    public partial class LoginHome : Form
    {
        static LoginHome loginHome; // creates static Home Object to be shared

        public LoginHome()
        {
            InitializeComponent();
        }

        private void LoginHome_Load(object sender, EventArgs e)
        {
            loginHome = this;
            // loads new login
            XctLogin login = new XctLogin();
            login.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(login);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // exit button closes window on click
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            // minimize button on click
            this.WindowState = FormWindowState.Minimized;
        }

        bool mouseDown;
        private Point offset;

        private void mouseDown_Event(object sender, MouseEventArgs e)
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

    }
}