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
    public partial class TeamDetailForm : Form
    {
        Int32 TeamID = 0;
        Int32 SeasonID = 0;

        public TeamDetailForm(Int32 TeamID, Int32 Action)
        {
            InitializeComponent();
            this.TeamID = TeamID;
            TeamTabControl.SelectedIndex = Action;
        }

        private void TeamDetailForm_Load(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(Properties.Settings.Default.ConnectionString);
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Season ORDER BY SeasonId DESC", sqlConnection);
            var Seasons = sqlCommand.ExecuteReader();
            while (Seasons.Read())
            {
                if(SeasonID == 0)
                {
                    SeasonID = Seasons.GetInt32(0);
                }
                SeasonsComboBox.Items.Add(Seasons.GetString(1));
            }
            Seasons.Close();
            SeasonsComboBox.SelectedIndex = 0;

            sqlCommand.CommandText = String.Format("SELECT * FROM Team WHERE TeamId={0}", TeamID);
            var Team = sqlCommand.ExecuteReader();
            if (Team.Read())
            {
                MemoryStream memoryStream = new MemoryStream();
                memoryStream.Write((byte[])Team.GetValue(5), 0, ((byte[])Team.GetValue(5)).Length);
                TeamLogoBox.Image = Image.FromStream(memoryStream);
                label3.Text = Team.GetString(1);
            }
            else
            {
                MessageBox.Show("Ошибка");
            }
            Team.Close();
            sqlConnection.Close();
            RosterLoad();
            MatchupsLoad();
            label1.Text = Program.Footer;
        }

        public void RosterLoad()
        {
            SqlConnection sqlConnection = new SqlConnection(Properties.Settings.Default.ConnectionString);
            sqlConnection.Open();
            SqlCommand RosterCommand = new SqlCommand("SELECT Player.Name AS 'ФИО', Position.Name As 'Позиция', Player.DateOfBirth AS 'Дата рождения', DATEDIFF(YEAR, Player.JoinYear, GETDATE()) AS Опыт, Player.Height AS 'Рост', Player.Weight AS 'Вес' " +
                " FROM Player INNER JOIN " +
                " Position ON Player.PositionId = Position.PositionId " +
                " WHERE Player.TeamId = " + TeamID, sqlConnection);
            SqlDataAdapter RosterDataAdapter = new SqlDataAdapter(RosterCommand);
            DataSet RosterDataSet = new DataSet();
            RosterDataAdapter.Fill(RosterDataSet);
            RosterDataGridView.DataSource = RosterDataSet.Tables[0];
            sqlConnection.Close();
        }

        public void MatchupsLoad()
        {
            SqlConnection sqlConnection = new SqlConnection(Properties.Settings.Default.ConnectionString);
            sqlConnection.Open();
            SqlCommand MatchupCommand = new SqlCommand("SELECT CONVERT(char(10), dbo.Matchup.Starttime, 126) AS Дата, dbo.MatchupType.Name AS [Тип матча], TeamAway.TeamName AS Оппонент, CONVERT(char(5), dbo.Matchup.Starttime, 108) AS 'Время начала', " +
                "CAST(dbo.Matchup.Team_Home_Score AS varchar) + ' - ' + CAST(dbo.Matchup.Team_Away_Score AS varchar) AS Результат " +
                "FROM     dbo.Matchup INNER JOIN " +
                "dbo.MatchupType ON dbo.Matchup.MatchupTypeId = dbo.MatchupType.MatchupTypeId INNER JOIN " +
                "dbo.Team AS TeamAway ON dbo.Matchup.Team_Away = TeamAway.TeamId " +
                "WHERE  (dbo.Matchup.Team_Home = " + TeamID + ") AND (dbo.Matchup.SeasonId = " + SeasonID + ")", sqlConnection);
            SqlDataAdapter MatchupDataAdapter = new SqlDataAdapter(MatchupCommand);
            DataSet MatchupDataSet = new DataSet();
            MatchupDataAdapter.Fill(MatchupDataSet);
            MatchupsDataGridView.DataSource = MatchupDataSet.Tables[0];
            sqlConnection.Close();
        }

        Boolean closing = true;

        private void BackButton_Click(object sender, EventArgs e)
        {
            closing = false;
            this.Owner.Show();
            this.Close();
        }

        private void TeamDetailForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (closing)
                Application.Exit();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            String SeasonText = SeasonsComboBox.SelectedItem.ToString();
            SqlConnection sqlConnection = new SqlConnection(Properties.Settings.Default.ConnectionString);
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(String.Format("SELECT SeasonId FROM Season WHERE Name='{0}'", SeasonText), sqlConnection);
            SeasonID = Convert.ToInt32(sqlCommand.ExecuteScalar());
            sqlConnection.Close();

            RosterLoad();
            MatchupsLoad();
        }
    }
}
