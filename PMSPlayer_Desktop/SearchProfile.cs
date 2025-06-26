using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace PMSPlayer_Desktop
{
    public partial class SearchProfile : Form
    {
        private string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=VballPlayerPMSDatabase;Integrated Security=True;Encrypt=False";

        public SearchProfile()
        {
            InitializeComponent();
            this.Load += SearchForm_Load;
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {
            LoadPlayers();
        }

        private void LoadPlayers(string searchTerm = "")
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT Name, Age, Position FROM Players WHERE Name LIKE @searchTerm";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@searchTerm", $"%{searchTerm}%");

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dgvSearch.DataSource = table;

                    if (searchTerm != "" && table.Rows.Count == 0)
                    {
                        MessageBox.Show("No player found with the given name.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadPlayers(txbSearchArea.Text);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadPlayers();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            var home = new HomePage();
            home.Show();
            this.Close();
        }
    }
}