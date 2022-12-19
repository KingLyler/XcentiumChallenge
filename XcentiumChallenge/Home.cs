using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XcentiumChallenge
{
    public partial class Home : UserControl
    {

        string db = ConfigurationManager.ConnectionStrings["XctLogin"].ConnectionString;
        public Home()
        {
            InitializeComponent();
        }

        private void UserProfile_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = 
                new SqlConnection(db))
            {
                string query = "SELECT * FROM Users WHERE Id = @Id";

                SqlCommand cmd =
                    new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@Id", LoggedInUser.Id);
                

                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    LoggedInUser.Name = (string)reader["Name"]+"!";
                }

                reader.Close();

                lblUser.Text = LoggedInUser.Name.ToString();

                conn.Close();
            }
        }
    }
}
