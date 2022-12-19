using System;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace XcentiumChallenge
{
    public partial class XctLogin : UserControl
    {
        // retrieve database from app.config
        string db = ConfigurationManager.ConnectionStrings["XctLogin"].ConnectionString;
        public XctLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            var usernameBlank = string.IsNullOrEmpty(username);
            var passwordBlank = string.IsNullOrEmpty(password);

            // query to ensure match between username and password
            String query = "SELECT Id FROM Users where Username = @Username and Password = @Password";
            // query to ensure username exists
            String uniqueUser = "SELECT COUNT(*) FROM Users WHERE Username = @username";

            // establish connection
            using (SqlConnection conn =
              new SqlConnection(db))
            {
                SqlCommand command = new SqlCommand(query, conn);
                SqlCommand uU = new SqlCommand(uniqueUser, conn);
                // user input from txtUsername text box fills @Username parameter of our query
                command.Parameters.AddWithValue("@Username", username);
                // user input from txtPassword text box fills @Password parameter of our query
                command.Parameters.AddWithValue("@Password", password);
                // user input from txtUsername text box fills @Username parameter of uU
                uU.Parameters.AddWithValue("@Username", username);

                conn.Open();
                // executes uU
                int userRecords = (int)uU.ExecuteScalar();
                if (userRecords == 0) // if username doesn't already exist
                {
                    MessageBox.Show("Please enter a valid username");
                    conn.Close();
                }
                else if (usernameBlank && passwordBlank)
                {
                    MessageBox.Show("Please enter a username and password");
                }
                else if (passwordBlank)
                {
                    MessageBox.Show("Please enter a password");
                }
                else if (usernameBlank)
                {
                    MessageBox.Show("Please enter a username");
                }
                else // otherwise
                {
                    // execute query
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        // Call Read before accessing data
                        while (reader.Read())
                        {
                            // store user Id data
                            LoggedInUser.Id = (int)reader["Id"];

                        }
                        // close reader
                        reader.Close();
                        // close connection
                        conn.Close();
                        // create new Home form
                        ApplicationHome home = new ApplicationHome();
                        // hide login form
                        ((LoginHome)TopLevelControl).Hide();

                        home.ShowDialog();
                        //close login form
                        ((LoginHome)TopLevelControl).Close();
                    }
                    // display message if password is incorrect
                    else if (LoggedInUser.Password != password)
                    {
                        MessageBox.Show("Password is incorrect", "Uh-Oh!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
        }

        private void btnShowPassword_Click(object sender, EventArgs e)
        {
            // Shows password, replaces show password button with hide password button
            txtPassword.UseSystemPasswordChar = false;
            btnShowPassword.Visible = false;
            btnHidePassword.Visible = true;
        }

        private void btnHidePassword_Click(object sender, EventArgs e)
        {
            // Hides password, replaces hide password button with show password button
            txtPassword.UseSystemPasswordChar = true;
            btnHidePassword.Visible = false;
            btnShowPassword.Visible = true;
        }

    }
}