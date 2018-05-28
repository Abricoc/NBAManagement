using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diplom
{
    public partial class AdministratorMenuForm : Form
    {
        public AdministratorMenuForm()
        {
            InitializeComponent();
        }

        Boolean closing = true;

        private void BackButton_Click(object sender, EventArgs e)
        {
            closing = false;
            this.Owner.Show();
            this.Close();
        }

        private void AdministratorMenuForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (closing)
                Application.Exit();
        }

        private void GoSeasonsButton_Click(object sender, EventArgs e)
        {
            ManageSeasonsForm manageSeasonsForm = new ManageSeasonsForm();
            manageSeasonsForm.Show(this);
            this.Hide();
        }

        private void GoTeamsButton_Click(object sender, EventArgs e)
        {
            ManageTeamsForm manageTeamsForm = new ManageTeamsForm();
            manageTeamsForm.Show(this);
            this.Hide();
        }

        private void GoPhotosButton_Click(object sender, EventArgs e)
        {
            ManagePhotosForm managePhotosForm = new ManagePhotosForm();
            managePhotosForm.Show(this);
            this.Hide();
        }

        private void AdministratorMenuForm_Load(object sender, EventArgs e)
        {
            label1.Text = Program.Footer;
        }

        private void ManagePlayersButton_Click(object sender, EventArgs e)
        {
            ManagePlayersForm managePlayersForm = new ManagePlayersForm();
            managePlayersForm.Show(this);
            this.Hide();
        }

        private void ManageMatchupsButton_Click(object sender, EventArgs e)
        {
            ManageMatchupsForm manageMatchupsForm = new ManageMatchupsForm();
            manageMatchupsForm.Show(this);
            this.Hide();
        }
     }
}