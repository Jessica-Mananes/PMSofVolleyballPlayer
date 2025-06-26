using System;
using System.Data;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace PMSPlayer_Desktop
{
    public partial class DeleteProfile : Form
    {
        private string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=VballPlayerPMSDatabase;Integrated Security=True;Encrypt=False";
        private string selectedPlayerName = "";

        public DeleteProfile()
        {
            InitializeComponent();
            this.Load += DeleteProfile_Load;
        }

        private void DeleteProfile_Load(object sender, EventArgs e)
        {
            LoadPlayers();
        }

        private void LoadPlayers()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "SELECT Name, Age, Position FROM Players";
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        dgvDeleteProfile.DataSource = table;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Database error loading players: {ex.Message}");
            }
        }

        private void dgvDeleteProfile_CellClick(object sender, DataGridViewCellEventArgs e) 
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvDeleteProfile.Rows[e.RowIndex];
                selectedPlayerName = row.Cells["Name"].Value?.ToString(); 
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(selectedPlayerName))
            {
                MessageBox.Show("Please select a player to delete.");
                return;
            }

            DialogResult confirm = MessageBox.Show($"Are you sure you want to delete {selectedPlayerName}?",
                                                   "Confirm Delete",
                                                   MessageBoxButtons.YesNo,
                                                   MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        string query = "DELETE FROM Players WHERE Name = @name"; 
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@name", selectedPlayerName);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Player deleted successfully!");
                            LoadPlayers();
                            selectedPlayerName = "";
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Database error deleting player: {ex.Message}");
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadPlayers();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var home = new HomePage();
            home.Show();
            this.Close();
        }
    }
}