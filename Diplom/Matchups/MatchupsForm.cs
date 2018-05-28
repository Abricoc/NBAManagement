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
    public partial class MatchupsForm : Form
    {
        public MatchupsForm()
        {
            InitializeComponent();
        }

        public void LoadMatchups()
        {
            SqlConnection sqlConnection = new SqlConnection(Properties.Settings.Default.ConnectionString);
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand($"SELECT [MatchupId] " +
                $"      ,Season.Name AS 'Сезон'" +
                $"      ,MatchupType.Name AS 'Тип матча' " +
                $"      ,Away.TeamName AS 'Гостевая команда'" +
                $"      ,Home.TeamName AS 'Домашняя команда'" +
                $"      ,[Starttime] AS 'Начало'" +
                $"      ,[Team_Away_Score] AS 'Счёт гостей'" +
                $"      ,[Team_Home_Score] AS 'Счёт дома'" +
                $"  FROM [Matchup]" +
                $"  INNER JOIN Season ON Matchup.SeasonId=Season.SeasonId" +
                $"  INNER JOIN MatchupType ON Matchup.MatchupTypeId=MatchupType.MatchupTypeId" +
                $"  INNER JOIN Team AS Home ON Matchup.Team_Home=Home.TeamId" +
                $"  INNER JOIN Team AS Away ON Matchup.Team_Away=Away.TeamId" +
                $" WHERE Away.TeamName LIKE '%{TeamsAwayComboBox.SelectedItem}%' AND Home.TeamName LIKE '%{TeamsHomeComboBox.SelectedItem}%'", sqlConnection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            MatchupsDataGridView.DataSource = dataSet.Tables[0];
            sqlConnection.Close();
            MatchupsDataGridView.Columns[0].Visible = false;
        }


        public void LoadTeams()
        {
            TeamsHomeComboBox.Items.Clear();
            TeamsHomeComboBox.Items.Add("");
            TeamsAwayComboBox.Items.Clear();
            TeamsAwayComboBox.Items.Add("");
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

        private void MatchupsForm_Load(object sender, EventArgs e)
        {
            label1.Text = Program.Footer;
            LoadTeams();
            LoadMatchups();
        }

        private void TeamsAwayComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMatchups();
        }

        Boolean closing = true;

        private void BackButton_Click(object sender, EventArgs e)
        {
            closing = false;
            this.Owner.Show();
            this.Close();
        }

        private void MatchupsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (closing)
                Application.Exit();
        }
    }
}