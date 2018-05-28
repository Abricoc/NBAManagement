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
    public partial class PlayersForm : Form
    {
        public PlayersForm()
        {
            InitializeComponent();
        }

        public void LoadFilters()
        {
            PositionComboBox.Items.Clear();
            PositionComboBox.Items.Add("");
            SqlConnection sqlConnection = new SqlConnection(Properties.Settings.Default.ConnectionString);
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM [Position]", sqlConnection);
            var Positions = sqlCommand.ExecuteReader();
            while (Positions.Read())
            {
                PositionComboBox.Items.Add(Positions.GetString(1));
            }
            Positions.Close();
            TeamsComboBox.Items.Clear();
            TeamsComboBox.Items.Add("");
            sqlCommand.CommandText = "SELECT * FROM [Team]";
            var Teams = sqlCommand.ExecuteReader();
            while (Teams.Read())
            {
                TeamsComboBox.Items.Add(Teams.GetString(1));
            }
            Teams.Close();
            sqlConnection.Close();
            if (TeamsComboBox.Items.Count > 0)
            {
                TeamsComboBox.SelectedIndex = 0;
            }
            if (PositionComboBox.Items.Count > 0)
            {
                PositionComboBox.SelectedIndex = 0;
            }
        }

        public void LoadPlayers()
        {
            if (PositionComboBox.SelectedItem == null || TeamsComboBox.SelectedItem == null) return;
            SqlConnection sqlConnection = new SqlConnection(Properties.Settings.Default.ConnectionString);
            sqlConnection.Open();
            SqlCommand PlayersCommand = new SqlCommand($"SELECT [Player].[PlayerId],[Img] AS 'Фото', [Player].[Name] AS 'ФИО', [Position].[Name] AS 'Позиция', [Team].TeamName AS 'Название команды', [JoinYear] AS 'Начало карьеры', [Height] AS 'Рост', [Weight] AS 'Вес', [DateOfBirth] AS 'Дата рождения' " +
                $"FROM [Player] " +
                $"INNER JOIN [Position] ON Player.PositionId=Position.PositionId " +
                $"INNER JOIN [Team] ON [Player].[TeamId]=[Team].[TeamId] " +
                $"WHERE [Position].[Name] LIKE '%{PositionComboBox.SelectedItem.ToString()}%' AND [Team].[TeamName] LIKE '%{TeamsComboBox.SelectedItem.ToString()}%'", sqlConnection);
            SqlDataAdapter PlayersDataAdapter = new SqlDataAdapter(PlayersCommand);
            DataSet PlayersDataSet = new DataSet();
            PlayersDataAdapter.Fill(PlayersDataSet);
            PlayersDataGridView.DataSource = PlayersDataSet.Tables[0];
            sqlConnection.Close();
            PlayersDataGridView.Columns[0].Visible = false;
        }

        private void PlayersForm_Load(object sender, EventArgs e)
        {
            FooterLabel.Text = Program.Footer;
            LoadFilters();
            LoadPlayers();
        }

        Boolean closing = true;

        private void BackButton_Click(object sender, EventArgs e)
        {
            closing = false;
            this.Owner.Show();
            this.Close();
        }

        private void PlayersForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (closing)
                Application.Exit();
        }

        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadPlayers();
        }
    }
}
