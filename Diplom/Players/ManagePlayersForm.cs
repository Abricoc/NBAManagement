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
    public partial class ManagePlayersForm : Form
    {
        public ManagePlayersForm()
        {
            InitializeComponent();
        }

        public void LoadPlayers()
        {
            SqlConnection sqlConnection = new SqlConnection(Properties.Settings.Default.ConnectionString);
            sqlConnection.Open();
            SqlCommand PlayersCommand = new SqlCommand($"SELECT [Player].[PlayerId],[Img] AS 'Фото', [Player].[Name] AS 'ФИО', [Position].[Name] AS 'Позиция', [Team].TeamName AS 'Название команды', [JoinYear] AS 'Начало карьеры', [Height] AS 'Рост', [Weight] AS 'Вес', [DateOfBirth] AS 'Дата рождения' " +
                $"FROM [Player] " +
                $"INNER JOIN [Position] ON Player.PositionId=Position.PositionId " +
                $"INNER JOIN [Team] ON [Player].[TeamId]=[Team].[TeamId]", sqlConnection);
            SqlDataAdapter PlayersDataAdapter = new SqlDataAdapter(PlayersCommand);
            DataSet PlayersDataSet = new DataSet();
            PlayersDataAdapter.Fill(PlayersDataSet);
            PlayersDataGridView.DataSource = PlayersDataSet.Tables[0];
            sqlConnection.Close();
            PlayersDataGridView.Columns[0].Visible = false;
        }

        public void LoadPlayers(String Search)
        {
            SqlConnection sqlConnection = new SqlConnection(Properties.Settings.Default.ConnectionString);
            sqlConnection.Open();
            SqlCommand PlayersCommand = new SqlCommand($"SELECT [Player].[PlayerId],[Img] AS 'Фото', [Player].[Name] AS 'ФИО', [Position].[Name] AS 'Позиция', [Team].TeamName AS 'Название команды', [JoinYear] AS 'Начало карьеры', [Height] AS 'Рост', [Weight] AS 'Вес', [DateOfBirth] AS 'Дата рождения' " +
                $"FROM [Player] " +
                $"INNER JOIN [Position] ON Player.PositionId=Position.PositionId " +
                $"INNER JOIN [Team] ON [Player].[TeamId]=[Team].[TeamId] " +
                $"WHERE [Player].[Name] LIKE '%{Search}%'", sqlConnection);
            SqlDataAdapter PlayersDataAdapter = new SqlDataAdapter(PlayersCommand);
            DataSet PlayersDataSet = new DataSet();
            PlayersDataAdapter.Fill(PlayersDataSet);
            PlayersDataGridView.DataSource = PlayersDataSet.Tables[0];
            sqlConnection.Close();
            PlayersDataGridView.Columns[0].Visible = false;
        }


        private void ManagePlayersForm_Load(object sender, EventArgs e)
        {
            LoadPlayers();
            label1.Text = Program.Footer;
            SearchTextBox.Text = "Поиск по ФИО";
            SearchTextBox.ForeColor = Color.Gray;
            SearchTextBox.GotFocus += RemoveText;
            SearchTextBox.LostFocus += AddText;
        }

        public void RemoveText(object sender, EventArgs e)
        {
            if(SearchTextBox.Text == "Поиск по ФИО")
            {
                SearchTextBox.Text = "";
                SearchTextBox.ForeColor = Color.Black;
            }
        }

        public void AddText(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(SearchTextBox.Text))
            {
                SearchTextBox.Text = "Поиск по ФИО";
                SearchTextBox.ForeColor = Color.Gray;
            }
        }

        Boolean closing = true;

        private void BackButton_Click(object sender, EventArgs e)
        {
            closing = false;
            this.Owner.Show();
            this.Close();
        }

        private void ManagePlayersForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (closing)
                Application.Exit();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            String Search = SearchTextBox.Text.Trim();
            if(Search == String.Empty)
            {
                LoadPlayers();
            }
            else
            {
                LoadPlayers(Search);
            }
        }

        private void AddPlayerButton_Click(object sender, EventArgs e)
        {
            AddPlayerForm addPlayerForm = new AddPlayerForm();
            addPlayerForm.Show(this);
            this.Hide();
        }

        private void EditPlayerButton_Click(object sender, EventArgs e)
        {
            EditPlayerForm editPlayerForm = new EditPlayerForm(Convert.ToInt32(PlayersDataGridView.SelectedRows[0].Cells[0].Value));
            editPlayerForm.Show(this);
            this.Hide();
        }

        private void PlayersButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите удалить?", "Внимание", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    SqlConnection sqlConnection = new SqlConnection(Properties.Settings.Default.ConnectionString);
                    sqlConnection.Open();
                    SqlCommand sqlCommand = new SqlCommand($"DELETE FROM [Player] WHERE [PlayerId]={PlayersDataGridView.SelectedRows[0].Cells[0].Value}", sqlConnection);
                    sqlCommand.ExecuteNonQuery();
                    sqlConnection.Close();
                    LoadPlayers();
                }
                catch
                {
                    MessageBox.Show("Ошибка");
                }
            }
        }
    }
}
