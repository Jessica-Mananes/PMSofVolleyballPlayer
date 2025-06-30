using Microsoft.Data.SqlClient;
using PlayerCommon;
using PMSDataPlayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMSPlayer_Desktop
{
    public partial class CreateProfile : Form
    {
        private readonly PlayerData playerData = new PlayerData();

        public CreateProfile()
        {
            InitializeComponent();
        }

        private void CreateProfile_Load(object sender, EventArgs e)
        {
            cmbPosition.Items.AddRange(new string[]
            {
                "Setter", "Libero", "Opposite Hitter", "Blocker", "Middle Hitter", "Opposite Spiker", "Spiker"
            });
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string playerName = txbName.Text.Trim();
            string ageText = txbAge.Text.Trim();
            string position = cmbPosition.Text;

            if (string.IsNullOrWhiteSpace(playerName) ||
                string.IsNullOrWhiteSpace(ageText) ||
                string.IsNullOrWhiteSpace(position))
            {
                MessageBox.Show("Please fill in all fields.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(ageText, out int age))
            {
                MessageBox.Show("Please enter a valid numeric age.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var newPlayer = new Player
            {
                Name = playerName,
                Age = age,
                Position = position
            };

            bool success = playerData.AddPlayer(newPlayer);

            if (success)
            {
                MessageBox.Show("Player added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
            }
            else
            {
                MessageBox.Show("Failed to add player.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ClearFields()
        {
            txbName.Clear();
            txbAge.Clear();
            cmbPosition.SelectedIndex = -1;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var home = new HomePage();
            home.Show();
            this.Close();
        }
    }
}
