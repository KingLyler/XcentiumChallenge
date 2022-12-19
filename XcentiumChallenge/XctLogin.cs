using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace XcentiumChallenge
{
    public partial class XctLogin : UserControl
    {
        string db = ConfigurationManager.ConnectionStrings["XctLogin"].ConnectionString;
        public XctLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String query = "SELECT Id FROM Users where Username = @Username and Password = @Password";

            using (SqlConnection conn =
                new SqlConnection(db))
            {
                SqlCommand command = new SqlCommand(query, conn);

                command.Parameters.AddWithValue("@Username", txtUsername.Text);

                command.Parameters.AddWithValue("@Password", txtPassword.Text);


                conn.Open();

                SqlDataReader reader = command.ExecuteReader();


                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        LoggedInUser.Id = (int)reader["Id"];
                    }

                    reader.Close();

                    conn.Close();

                    ApplicationHome home = new ApplicationHome();

                    ((LoginHome)this.TopLevelControl).Hide();

                    home.ShowDialog();

                    ((LoginHome)this.TopLevelControl).Close();
                }
                else
                {
                    MessageBox.Show("Username/Password is incorrect", "Uh-Oh!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
    
        private void btnShowPassword_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false;
            btnShowPassword.Visible = false;
            btnHidePassword.Visible = true;
        }

        private void btnHidePassword_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
            btnHidePassword.Visible = false;
            btnShowPassword.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
