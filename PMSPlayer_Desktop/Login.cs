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
    public partial class Login : Form
    {

        private string txbUsername = "batakmagvball";
        private string txbPassword = "jess";

        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string enteredUsername = tbxUsername.Text.Trim();
            string enteredPassword = tbxPassword.Text.Trim();

            if (enteredUsername == txbUsername && enteredPassword == txbPassword)
            {
                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                HomePage home = new HomePage();
                home.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                tbxUsername.Clear();
                tbxPassword.Clear();
                tbxUsername.Focus();
            }
        }

        private void lblSystemName_Click(object sender, EventArgs e)
        {
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
