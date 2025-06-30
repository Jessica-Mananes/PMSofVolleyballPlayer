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
using PlayerCommon;
using PMSDataPlayer;

namespace PMSPlayer_Desktop
{
    public partial class DeleteProfile : Form
    {
        private readonly PlayerData playerData = new PlayerData();
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
                var players = playerData.GetAllPlayers();
                dgvDeleteProfile.DataSource = players;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading players: {ex.Message}");
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
                bool success = playerData.DeletePlayer(selectedPlayerName);
                if (success)
                {
                    MessageBox.Show("Player deleted successfully!");
                    LoadPlayers();
                    selectedPlayerName = "";
                }
                else
                {
                    MessageBox.Show("Failed to delete player. Please try again.");
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