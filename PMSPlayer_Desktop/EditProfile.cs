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
using PlayerCommon;
using PMSDataPlayer;

namespace PMSPlayer_Desktop
{
    public partial class EditProfile : Form
    {
        private readonly PlayerData playerData = new PlayerData();
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
                var players = playerData.GetAllPlayers();
                dgvData.DataSource = players;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading players: {ex.Message}");
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

            Player updatedPlayer = new Player
            {
                Name = txbName.Text.Trim(),
                Age = int.Parse(txbAge.Text.Trim()),
                Position = cmbPosition.Text.Trim()
            };

            bool success = playerData.UpdatePlayer(originalName, updatedPlayer);
            if (success)
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
