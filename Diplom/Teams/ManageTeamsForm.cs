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
    public partial class ManageTeamsForm : Form
    {
        public ManageTeamsForm()
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

        private void ManageTeamsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (closing)
                Application.Exit();
        }

        public void LoadTeams()
        {
            SqlConnection sqlConnection = new SqlConnection(Properties.Settings.Default.ConnectionString);
            sqlConnection.Open();
            SqlCommand TeamsCommand = new SqlCommand("SELECT [TeamId], [Logo] AS 'Логотип', [TeamName] AS 'Название команды', [Division].[Name] AS 'Дивизион', [Abbr] AS 'Короткое название', [Coach] AS 'Тренер' FROM [Team] INNER JOIN Division ON Team.DivisionId = Division.DivisionId", sqlConnection);
            SqlDataAdapter TeamsDataAdapter = new SqlDataAdapter(TeamsCommand);
            DataSet TeamsDataSet = new DataSet();
            TeamsDataAdapter.Fill(TeamsDataSet);
            TeamsDataGridView.DataSource = TeamsDataSet.Tables[0];
            sqlConnection.Close();
            TeamsDataGridView.Columns[0].Visible = false;
        }

        private void ManageTeamsForm_Load(object sender, EventArgs e)
        {
            LoadTeams();
            label1.Text = Program.Footer;
        }

        private void DeleteTeamButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите удалить?", "Внимание", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    SqlConnection sqlConnection = new SqlConnection(Properties.Settings.Default.ConnectionString);
                    sqlConnection.Open();
                    SqlCommand sqlCommand = new SqlCommand(String.Format("DELETE [Team] WHERE [TeamId]='{0}'", TeamsDataGridView.SelectedRows[0].Cells[0].Value), sqlConnection);
                    sqlCommand.ExecuteNonQuery();
                    sqlConnection.Close();
                }
                catch
                {
                    MessageBox.Show("Невозможно удалить команду, для удаления команды удалите игроков из этой команды");
                }
                LoadTeams();
            }
        }

        private void AddTeamButton_Click(object sender, EventArgs e)
        {
            AddTeamForm addTeamForm = new AddTeamForm();
            addTeamForm.Show(this);
            this.Hide();
        }

        private void EditTeamButton_Click(object sender, EventArgs e)
        {
            EditTeamForm editTeamForm = new EditTeamForm(Convert.ToInt32(TeamsDataGridView.SelectedRows[0].Cells[0].Value));
            editTeamForm.Show(this);
            this.Hide();
        }
    }
}
