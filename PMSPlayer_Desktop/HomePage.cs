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
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            CreateProfile createForm = new CreateProfile();
            createForm.Show();
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditProfile editForm = new EditProfile();
            editForm.Show();
            this.Close();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            ViewProfile viewForm = new ViewProfile();
            viewForm.Show();
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteProfile deleteForm = new DeleteProfile();
            deleteForm.Show();
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchProfile searchForm = new SearchProfile();
            searchForm.Show();
            this.Close();
        }

    }
}
