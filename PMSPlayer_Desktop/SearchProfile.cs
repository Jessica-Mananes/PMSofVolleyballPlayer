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
using PMSDataPlayer;
using PlayerCommon;

namespace PMSPlayer_Desktop
{
    public partial class SearchProfile : Form
    {
        private readonly PlayerData playerData = new PlayerData();

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
            try
            {
                List<Player> players;

                if (string.IsNullOrWhiteSpace(searchTerm))
                {
                    players = playerData.GetAllPlayers();
                }
                else
                {
                    players = playerData.SearchPlayersByName(searchTerm);
                    if (players.Count == 0)
                    {
                        MessageBox.Show("No player found with the given name.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                dgvSearch.DataSource = players;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading players: {ex.Message}");
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