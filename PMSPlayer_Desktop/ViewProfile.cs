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
using PMSDataPlayer;
using PlayerCommon;

namespace PMSPlayer_Desktop
{
    public partial class ViewProfile : Form
    {
        private readonly PlayerData playerData = new PlayerData();

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
                List<Player> players = playerData.GetAllPlayers();
                dgbViewProfile.DataSource = players;
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
