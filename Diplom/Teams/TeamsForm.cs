using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diplom
{
    public partial class TeamsForm : Form
    {
        public TeamsForm()
        {
            InitializeComponent();
        }

        public void LoadTeams()
        {
            SqlConnection ConferenciesConnection = new SqlConnection(Properties.Settings.Default.ConnectionString);
            ConferenciesConnection.Open();
            SqlCommand ConferenciesCommand = new SqlCommand("SELECT * FROM Conference", ConferenciesConnection);
            var Conferencies = ConferenciesCommand.ExecuteReader();
            for(int i = 0; Conferencies.Read(); i++)
            {
                TeamsTabControl.TabPages.Add(Conferencies.GetString(1));
                SqlConnection DivisionsConnection = new SqlConnection(Properties.Settings.Default.ConnectionString);
                DivisionsConnection.Open();
                SqlCommand DivisionsCommand = new SqlCommand(String.Format("SELECT * FROM Division WHERE ConferenceId={0}", Conferencies.GetInt32(0)), DivisionsConnection);
                var Divisions = DivisionsCommand.ExecuteReader();
                for (int j = 0; Divisions.Read(); j++)
                {
                    //Основная панель дивизиона
                    Panel DivisionPanel = new Panel();
                    DivisionPanel.Size = new Size(300, 470);
                    DivisionPanel.BorderStyle = BorderStyle.FixedSingle;
                    DivisionPanel.Location = new Point(10 + (10 * j) + 300 * j, 20);
                    DivisionPanel.AutoScroll = true;
                    //Заголовок панели
                    Panel DivisionTitlePanel = new Panel();
                    DivisionTitlePanel.Dock = DockStyle.Top;
                    DivisionTitlePanel.Size = new Size(DivisionTitlePanel.Size.Width, 25);
                    DivisionTitlePanel.BorderStyle = BorderStyle.FixedSingle;
                    DivisionTitlePanel.BackColor = Color.DarkGray;
                    Label DivisionTitleLabel = new Label();
                    DivisionTitleLabel.Dock = DockStyle.Fill;
                    DivisionTitleLabel.TextAlign = ContentAlignment.MiddleCenter;
                    DivisionTitleLabel.Text = Divisions.GetString(1);
                    DivisionTitlePanel.Controls.Add(DivisionTitleLabel);
                    DivisionPanel.Controls.Add(DivisionTitlePanel);
                    SqlConnection TeamsConnection = new SqlConnection(Properties.Settings.Default.ConnectionString);
                    TeamsConnection.Open();
                    SqlCommand TeamsCommand = new SqlCommand(String.Format("SELECT * FROM Team WHERE DivisionId={0}", Divisions.GetInt32(0)), TeamsConnection);
                    var Teams = TeamsCommand.ExecuteReader();
                    for (int k = 0; Teams.Read(); k++)
                    {
                        Panel TeamPanel = new Panel();
                        TeamPanel.Size = new Size(275, 85);
                        TeamPanel.BorderStyle = BorderStyle.FixedSingle;
                        TeamPanel.Location = new Point(0, (88 * k) + 26);
                        PictureBox LogoTeam = new PictureBox();
                        MemoryStream memoryStream = new MemoryStream();       
                        memoryStream.Write((byte[])Teams.GetValue(5), 0, ((byte[])Teams.GetValue(5)).Length);
                        LogoTeam.Image = Image.FromStream(memoryStream);
                        LogoTeam.SizeMode = PictureBoxSizeMode.StretchImage;
                        LogoTeam.Size = new Size(80, 80);
                        LogoTeam.Location = new Point(0, 0);
                        TeamPanel.Controls.Add(LogoTeam);

                        Label TeamTitleLabel = new Label();
                        TeamTitleLabel.Text = Teams.GetString(1);
                        TeamTitleLabel.AutoSize = true;
                        TeamTitleLabel.ForeColor = Color.Gray;
                        TeamTitleLabel.Location = new Point(95, 10);
                        TeamTitleLabel.Font = new Font(TeamTitleLabel.Font, FontStyle.Bold);
                        TeamPanel.Controls.Add(TeamTitleLabel);


                        Label RosterLabel = new Label();
                        RosterLabel.Text = "Список";
                        RosterLabel.AutoSize = true;
                        RosterLabel.ForeColor = Color.DeepSkyBlue;
                        RosterLabel.Location = new Point(85, 55);
                        TeamPanel.Controls.Add(RosterLabel);
                        RosterLabel.Tag = Teams.GetInt32(0);
                        RosterLabel.Click += RosterLabel_Click;

                        Label MatchupLabel = new Label();
                        MatchupLabel.AutoSize = true;
                        MatchupLabel.Text = "Матчи";
                        MatchupLabel.ForeColor = Color.DeepSkyBlue;
                        MatchupLabel.Location = new Point(140, 55);
                        MatchupLabel.Click += MatchupLabel_Click;
                        MatchupLabel.Tag = Teams.GetInt32(0);
                        TeamPanel.Controls.Add(MatchupLabel);

                        DivisionPanel.Controls.Add(TeamPanel);
                    }
                    Teams.Close();
                    TeamsConnection.Close();
                    TeamsTabControl.TabPages[i].Controls.Add(DivisionPanel);
                }
                Divisions.Close();
                DivisionsConnection.Close();
            }
            Conferencies.Close();
            ConferenciesConnection.Close();
        }

        private void FirstLineUpLabel_Click(object sender, EventArgs e)
        {
            TeamDetailForm teamDetailForm = new TeamDetailForm(Convert.ToInt32((sender as Label).Tag), 2);
            teamDetailForm.Show(this);
            this.Hide();
        }

        private void MatchupLabel_Click(object sender, EventArgs e)
        {
            TeamDetailForm teamDetailForm = new TeamDetailForm(Convert.ToInt32((sender as Label).Tag), 1);
            teamDetailForm.Show(this);
            this.Hide();
        }

        private void RosterLabel_Click(object sender, EventArgs e)
        {
            TeamDetailForm teamDetailForm = new TeamDetailForm(Convert.ToInt32((sender as Label).Tag), 0);
            teamDetailForm.Show(this);
            this.Hide();
        }

        private void TeamsForm_Load(object sender, EventArgs e)
        {
            LoadTeams();
            label1.Text = Program.Footer;
        }

        Boolean closing = true;

        private void TeamsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (closing)
                Application.Exit();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            closing = false;
            this.Owner.Show();
            this.Close();
        }
    }
}