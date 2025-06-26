using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace PMSPlayer_Desktop
{
    public partial class DeleteProfile : Form
    {
        private string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=VBPlayers;Integrated Security=True";
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
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT Name, Age, Position FROM Players";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dgvDeleteProfile.DataSource = table;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvDeleteProfile.Rows[e.RowIndex];
                selectedPlayerName = row.Cells["PlayerName"].Value?.ToString();
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
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM Players WHERE PlayerName = @name";
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
