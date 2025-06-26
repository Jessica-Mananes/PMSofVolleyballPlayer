using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace PMSPlayer_Desktop
{
    public partial class EditProfile : Form
    {
        private string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=VballPlayerPMSDatabase;Integrated Security=True;Encrypt=False";
        private string originalName = "";

        public EditProfile()
        {
            InitializeComponent();
        }

        private void EditProfile_Load(object sender, EventArgs e)
        {
            LoadPlayers();

            cmbPosition.Items.AddRange(new string[]
            {
                "Setter", "Libero", "Opposite Hitter", "Blocker", "Middle Hitter", "Opposite Spiker", "Spiker"
            });
        }

        private void LoadPlayers()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT Name, Age, Position FROM Players";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dgvData.DataSource = table;
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
            if (string.IsNullOrWhiteSpace(originalName))
            {
                MessageBox.Show("Please select a player from the list first.");
                return;
            }

            string newName = txbName.Text.Trim();
            string ageText = txbAge.Text.Trim();
            string position = cmbPosition.Text.Trim();

            if (string.IsNullOrWhiteSpace(newName) || string.IsNullOrWhiteSpace(ageText) || string.IsNullOrWhiteSpace(position))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            if (!int.TryParse(ageText, out int age))
            {
                MessageBox.Show("Age must be a valid number.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE Players SET Name = @NewName, Age = @Age, Position = @Position WHERE Name = @OriginalName";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@NewName", newName);
                    cmd.Parameters.AddWithValue("@Age", age);
                    cmd.Parameters.AddWithValue("@Position", position);
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
                            MessageBox.Show("Update failed. Please ensure the player exists.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Database error: " + ex.Message);
                    }
                }
            }
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
