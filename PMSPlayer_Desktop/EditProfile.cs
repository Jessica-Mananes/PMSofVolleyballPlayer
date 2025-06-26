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
    public partial class EditProfile : Form
    {
        private string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=VballPlayerPMSDatabase;Integrated Security=True;Encrypt=False";
        private string originalName = "";

        public EditProfile()
        {
            InitializeComponent();
            PopulatePositions();
            this.Load += EditProfile_Load;
        }

        private void EditProfile_Load(object sender, EventArgs e)
        {
            LoadPlayers();
        }

        private void PopulatePositions()
        {
            cmbPosition.Items.Clear(); 
            cmbPosition.Items.AddRange(new string[]
            {
                "Setter", "Libero", "Opposite Hitter", "Blocker", "Middle Hitter", "Opposite Spiker", "Spiker"
            });
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
                        dgvData.DataSource = table;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Database error loading players: {ex.Message}");
            }
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvData.Rows[e.RowIndex];
                originalName = row.Cells["Name"].Value?.ToString();
                txbName.Text = originalName;
                txbAge.Text = row.Cells["Age"].Value?.ToString();
                cmbPosition.Text = row.Cells["Position"].Value?.ToString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE Players SET Name = @NewName, Age = @Age, Position = @Position WHERE Name = @OriginalName";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@NewName", txbName.Text.Trim());
                    cmd.Parameters.AddWithValue("@Age", int.Parse(txbAge.Text.Trim()));
                    cmd.Parameters.AddWithValue("@Position", cmbPosition.Text.Trim());
                    cmd.Parameters.AddWithValue("@OriginalName", originalName);

                    try
                    {
                        conn.Open();
                        int result = cmd.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Player updated successfully!");
                            LoadPlayers();
                            ClearFields();
                        }
                        else
                        {
                            MessageBox.Show("Update failed. Player not found or no changes made.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Database error: {ex.Message}");
                    }
                }
            }
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(originalName))
            {
                MessageBox.Show("Please select a player from the list first.");
                return false;
            }

            string newName = txbName.Text.Trim();
            string ageText = txbAge.Text.Trim();
            string position = cmbPosition.Text.Trim();

            if (string.IsNullOrWhiteSpace(newName) || string.IsNullOrWhiteSpace(ageText) || string.IsNullOrWhiteSpace(position))
            {
                MessageBox.Show("Please fill in all fields.");
                return false;
            }

            if (!int.TryParse(ageText, out int age))
            {
                MessageBox.Show("Age must be a valid number.");
                return false;
            }

            return true;
        }

        private void ClearFields()
        {
            txbName.Clear();
            txbAge.Clear();
            cmbPosition.SelectedIndex = -1;
            originalName = "";
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadPlayers();
            ClearFields();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var home = new HomePage();
            home.Show();
            this.Close();
        }
    }
}
