using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace XcentiumChallenge
{
    public partial class Home : UserControl
    {
        // retrieve database from app.config 
        string db = ConfigurationManager.ConnectionStrings["XctLogin"].ConnectionString;
        public Home()
        {
            InitializeComponent();
        }

        private void UserProfile_Load(object sender, EventArgs e)
        {
            // Establish connection
            using (SqlConnection conn =
              new SqlConnection(db))
            {
                // SQL query to retrieve user Id
                string query = "SELECT * FROM Users WHERE Id = @Id";

                SqlCommand cmd =
                  new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@Id", LoggedInUser.Id);

                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    // store User's Name
                    LoggedInUser.Name = (string)reader["Name"] + "!";
                }

                reader.Close();
                // update lblUser to display users name on page
                lblUser.Text = LoggedInUser.Name.ToString();

                conn.Close();
            }
        }
    }
}