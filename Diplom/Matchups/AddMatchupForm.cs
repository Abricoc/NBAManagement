using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diplom
{
    public partial class AddMatchupForm : Form
    {
        public AddMatchupForm()
        {
            InitializeComponent();
        }

        public void LoadSeasons()
        {
            SeasonsComboBox.Items.Clear();
            SqlConnection sqlConnection = new SqlConnection(Properties.Settings.Default.ConnectionString);
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Season", sqlConnection);
            var Seasons = sqlCommand.ExecuteReader();
            while (Seasons.Read())
            {
                SeasonsComboBox.Items.Add(Seasons.GetString(1));
            }
            Seasons.Close();
            sqlConnection.Close();
            if (SeasonsComboBox.Items.Count > 0)
            {
                SeasonsComboBox.SelectedIndex = 0;
            }
        }

        public void LoadMatchupTypes()
        {
            MatchupTypesComboBox.Items.Clear();
            SqlConnection sqlConnection = new SqlConnection(Properties.Settings.Default.ConnectionString);
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM MatchupType", sqlConnection);
            var MatchupTypes = sqlCommand.ExecuteReader();
            while (MatchupTypes.Read())
            {
                MatchupTypesComboBox.Items.Add(MatchupTypes.GetString(1));
            }
            MatchupTypes.Close();
            sqlConnection.Close();
            if(MatchupTypesComboBox.Items.Count > 0)
            {
                MatchupTypesComboBox.SelectedIndex = 0;
            }
        }

        public void LoadTeams()
        {
            TeamsHomeComboBox.Items.Clear();
            TeamsAwayComboBox.Items.Clear();
            SqlConnection sqlConnection = new SqlConnection(Properties.Settings.Default.ConnectionString);
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM [Team]", sqlConnection);
            var Teams = sqlCommand.ExecuteReader();
            while (Teams.Read())
            {
                TeamsHomeComboBox.Items.Add(Teams.GetString(1));
                TeamsAwayComboBox.Items.Add(Teams.GetString(1));
            }
            Teams.Close();
            sqlConnection.Close();
            if (TeamsHomeComboBox.Items.Count > 0)
            {
                TeamsHomeComboBox.SelectedIndex = 0;
                TeamsAwayComboBox.SelectedIndex = 0;
            }
        }

        private void AddMatchupForm_Load(object sender, EventArgs e)
        {
            FooterLabel.Text = Program.Footer;
            LoadSeasons();
            LoadMatchupTypes();
            LoadTeams();
            BeginMatchupPicker.MaxDate = DateTime.Now.AddYears(2);
        }

        public Int32 GetTeamID(String TeamName)
        {
            Int32 ID = 0;
            try
            {
                SqlConnection sqlConnection = new SqlConnection(Properties.Settings.Default.ConnectionString);
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(String.Format("SELECT [TeamId] FROM [Team] WHERE [TeamName]='{0}'", TeamName), sqlConnection);
                ID = Convert.ToInt32(sqlCommand.ExecuteScalar());
            }
            catch
            {
                ID = 0;
            }
            return ID;
        }

        public Int32 GetSeasonID(String SeasonName)
        {
            Int32 ID = 0;
            try
            {
                SqlConnection sqlConnection = new SqlConnection(Properties.Settings.Default.ConnectionString);
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(String.Format("SELECT [SeasonId] FROM [Season] WHERE [Name]='{0}'", SeasonName), sqlConnection);
                ID = Convert.ToInt32(sqlCommand.ExecuteScalar());
            }
            catch
            {
                ID = 0;
            }
            return ID;
        }

        public Int32 GetMatchupTypeID(String MatchupType)
        {
            Int32 ID = 0;
            try
            {
                SqlConnection sqlConnection = new SqlConnection(Properties.Settings.Default.ConnectionString);
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(String.Format("SELECT [MatchupTypeId] FROM [MatchupType] WHERE [Name]='{0}'", MatchupType), sqlConnection);
                ID = Convert.ToInt32(sqlCommand.ExecuteScalar());
            }
            catch
            {
                ID = 0;
            }
            return ID;
        }

        private void AddPlayerButton_Click(object sender, EventArgs e)
        {
           
            
        }

        Boolean closing = true;

        private void BackButton_Click(object sender, EventArgs e)
        {
            closing = false;
            this.Owner.Show();
            this.Close();
        }

        private void AddMatchupForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (closing)
                Application.Exit();
        }

        private void AddMatchupButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.HomeScore.Text.Trim() == String.Empty)
                {
                    MessageBox.Show("Введите счёт домашней команды");
                    return;
                }
                if (this.AwayScore.Text.Trim() == String.Empty)
                {
                    MessageBox.Show("Введите счёт гостевой команды");
                    return;
                }
                if (TeamsHomeComboBox.SelectedItem.ToString() == TeamsAwayComboBox.SelectedItem.ToString())
                {
                    MessageBox.Show("Команда дома и гостей не может совпадать");
                    return;
                }
                Int32 SeasonId = GetSeasonID(SeasonsComboBox.SelectedItem.ToString());
                Int32 MatchupTypeId = GetMatchupTypeID(MatchupTypesComboBox.SelectedItem.ToString());
                DateTime BeginDate = BeginMatchupPicker.Value;
                Int32 HomeTeam = GetTeamID(TeamsHomeComboBox.SelectedItem.ToString());
                Int32 AwayTeam = GetTeamID(TeamsAwayComboBox.SelectedItem.ToString());
                Int32 HomeScore = Convert.ToInt32(this.HomeScore.Text);
                Int32 AwayScore = Convert.ToInt32(this.AwayScore.Text);

                SqlConnection sqlConnection = new SqlConnection(Properties.Settings.Default.ConnectionString);
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand($"INSERT INTO [dbo].[Matchup] ([SeasonId], [MatchupTypeId], [Team_Away], [Team_Home], [Starttime], [Team_Away_Score], [Team_Home_Score]) " +
                    $"     VALUES (" +
                    $"@SeasonID, " +
                    $"@MatchTypeID, " +
                    $"@AwayTeam, " +
                    $"@HomeTeam, " +
                    $"@BeginDate, " +
                    $"@AwayScore, " +
                    $"@HomeScore )", sqlConnection);
                sqlCommand.Parameters.Add(new SqlParameter("@SeasonID", SeasonId));
                sqlCommand.Parameters.Add(new SqlParameter("@MatchTypeID", MatchupTypeId));
                sqlCommand.Parameters.Add(new SqlParameter("@AwayTeam", AwayTeam));
                sqlCommand.Parameters.Add(new SqlParameter("@HomeTeam", HomeTeam));
                sqlCommand.Parameters.Add(new SqlParameter("@BeginDate", BeginDate));
                sqlCommand.Parameters.Add(new SqlParameter("@AwayScore", AwayScore));
                sqlCommand.Parameters.Add(new SqlParameter("@HomeScore", HomeScore));
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                (this.Owner as ManageMatchupsForm).LoadMatchups();
                BackButton_Click(sender, new EventArgs());
            }
            catch
            {
                MessageBox.Show("Ошибка");
            }
        }

        private void HomeScore_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
    }
}
