using System;
using System.Drawing;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XcentiumChallenge
{
    public partial class LoginHome : Form
    {
        static LoginHome loginHome; // creates static Home Object to be shared
        
        public static LoginHome Instance
        {
            get
            {
                if (loginHome == null)
                {
                    loginHome = new LoginHome();
                }
                return loginHome;
            }
        }

        public Panel MainLoginPanel
        {
            get { return pnlMain; }
            set { pnlMain = value; }
        }
        public LoginHome()
        {
            InitializeComponent();
        }

        private void LoginHome_Load(object sender, EventArgs e)
        {
            loginHome = this;

            XctLogin login = new XctLogin();
            login.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(login);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
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
