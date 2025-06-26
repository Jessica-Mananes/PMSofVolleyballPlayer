using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace PMSPlayer_Desktop
{
    public partial class ViewProfile : Form
    {
        private string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=VballPlayerPMSDatabase;Integrated Security=True;Encrypt=False";

        public ViewProfile()
        {
            InitializeComponent();
            this.Load += ViewProfile_Load;
        }

        private void ViewProfile_Load(object sender, EventArgs e)
        {
            LoadProfileData();
        }

        private void LoadProfileData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT Name, Age, Position FROM Players";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dgbViewProfile.DataSource= table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var home = new HomePage();
            home.Show();
            this.Close();
        }   
    }
}
