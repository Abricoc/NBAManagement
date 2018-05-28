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
    public partial class ManageMatchupsForm : Form
    {
        public ManageMatchupsForm()
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
                $"  INNER JOIN Team AS Away ON Matchup.Team_Away=Away.TeamId", sqlConnection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            MatchupsDataGridView.DataSource = dataSet.Tables[0];
            sqlConnection.Close();
            MatchupsDataGridView.Columns[0].Visible = false;
        }

        private void ManageMatchupsForm_Load(object sender, EventArgs e)
        {
            label1.Text = Program.Footer;
            LoadMatchups();
        }

        Boolean closing = true;

        private void BackButton_Click(object sender, EventArgs e)
        {
            closing = false;
            this.Owner.Show();
            this.Close();
        }

        private void ManageMatchupsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (closing)
                Application.Exit();
        }

        private void DeleteMatchupButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите удалить?", "Внимание", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    SqlConnection sqlConnection = new SqlConnection(Properties.Settings.Default.ConnectionString);
                    sqlConnection.Open();
                    SqlCommand sqlCommand = new SqlCommand($"DELETE FROM [Matchup] WHERE MatchupId={MatchupsDataGridView.SelectedRows[0].Cells[0].Value}", sqlConnection);
                    sqlCommand.ExecuteNonQuery();
                    LoadMatchups();
                }
                catch
                {
                    MessageBox.Show("Ошибка");
                }
            }
        }

        private void AddMatchupButton_Click(object sender, EventArgs e)
        {
            AddMatchupForm addMatchupForm = new AddMatchupForm();
            addMatchupForm.Show(this);
            this.Hide();
        }

        private void EditMatchupButton_Click(object sender, EventArgs e)
        {
            EditMatchupForm editMatchupForm = new EditMatchupForm(Convert.ToInt32(MatchupsDataGridView.SelectedRows[0].Cells[0].Value));
            editMatchupForm.Show(this);
            this.Hide();
        }
    }
}
