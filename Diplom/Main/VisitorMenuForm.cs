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
    public partial class VisitorMenuForm : Form
    {
        public VisitorMenuForm()
        {
            InitializeComponent();
        }

        private void VisitorMenu_Load(object sender, EventArgs e)
        {
            FooterLabel.Text = Program.Footer;
        }

        private void VisitorMenuForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(closing)
                Application.Exit();
        }

        Boolean closing = true;

        private void BackButton_Click(object sender, EventArgs e)
        {
            closing = false;
            this.Owner.Show();
            this.Close();
        }

        private void TeamButton_Click(object sender, EventArgs e)
        {
            TeamsForm teamsForm = new TeamsForm();
            teamsForm.Show(this);
            this.Hide();
        }

        private void PhotosButton_Click(object sender, EventArgs e)
        {
            PhotosForm photosForm = new PhotosForm();
            photosForm.Show(this);
            this.Hide();
        }

        private void PlayersButton_Click(object sender, EventArgs e)
        {
            PlayersForm playersForm = new PlayersForm();
            playersForm.Show(this);
            this.Hide();
        }

        private void MatchupsButton_Click(object sender, EventArgs e)
        {
            MatchupsForm matchupsForm = new MatchupsForm();
            matchupsForm.Show(this);
            this.Hide();
        }
    }
}