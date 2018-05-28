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
    public partial class EditPlayerForm : Form
    {
        Int32 ID;

        public EditPlayerForm(Int32 ID)
        {
            InitializeComponent();
            this.ID = ID;
        }

        public void LoadPositions()
        {
            PositionComboBox.Items.Clear();
            SqlConnection sqlConnection = new SqlConnection(Properties.Settings.Default.ConnectionString);
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM [Position]", sqlConnection);
            var Positions = sqlCommand.ExecuteReader();
            while (Positions.Read())
            {
                PositionComboBox.Items.Add(Positions.GetString(1));
            }
            Positions.Close();
            sqlConnection.Close();
            if (PositionComboBox.Items.Count > 0)
            {
                PositionComboBox.SelectedIndex = 0;
            }
        }

        public void LoadTeams()
        {
            TeamsComboBox.Items.Clear();
            SqlConnection sqlConnection = new SqlConnection(Properties.Settings.Default.ConnectionString);
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM [Team]", sqlConnection);
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
        }

        public Int32 GetPositonID(String PositionName)
        {
            Int32 ID = 0;
            try
            {
                SqlConnection sqlConnection = new SqlConnection(Properties.Settings.Default.ConnectionString);
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(String.Format("SELECT [PositionId] FROM [Position] WHERE [Name]='{0}'", PositionName), sqlConnection);
                ID = Convert.ToInt32(sqlCommand.ExecuteScalar());
            }
            catch
            {
                ID = 0;
            }
            return ID;
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

        private void EditPlayerForm_Load(object sender, EventArgs e)
        {
            LoadPositions();
            LoadTeams();
            FooterLabel.Text = Program.Footer;
            BirthDayPicker.MaxDate = DateTime.Now;
            JoinYearPicker.MaxDate = DateTime.Now;
            SqlConnection sqlConnection = new SqlConnection(Properties.Settings.Default.ConnectionString);
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand($"SELECT [Player].[PlayerId], [Player].[Name], [Position].[Name], [JoinYear], [Height], [Weight], [Img], [Team].[TeamName], DateOfBirth FROM [Player] INNER JOIN [Position] ON Player.PositionId=Position.PositionId INNER JOIN [Team] ON [Team].TeamId=[Player].[TeamId] WHERE PlayerId={ID}", sqlConnection);
            var Player = sqlCommand.ExecuteReader();
            if (Player.Read())
            {
                FIOBox.Text = Player.GetString(1);
                PositionComboBox.Text = Player.GetString(2);
                JoinYearPicker.Value = Player.GetDateTime(3);
                HeightBox.Value = Player.GetDecimal(4);
                WeightBox.Value = Player.GetDecimal(5);

                MemoryStream memoryStream = new MemoryStream();
                memoryStream.Write((byte[])Player.GetValue(6), 0, ((byte[])Player.GetValue(6)).Length);
                PhotoBox.Image = Image.FromStream(memoryStream);
                TeamsComboBox.Text = Player.GetString(7);
                BirthDayPicker.Value = Player.GetDateTime(8);
            }
            Player.Close();
            sqlConnection.Close();
        }

        Boolean closing = true;

        private void BackButton_Click(object sender, EventArgs e)
        {
            closing = false;
            this.Owner.Show();
            this.Close();
        }

        private void EditPlayerButton_Click(object sender, EventArgs e)
        {
            String FIO = FIOBox.Text.Trim();
            Int32 PositionID = GetPositonID(PositionComboBox.SelectedItem.ToString());
            Int32 TeamID = GetTeamID(TeamsComboBox.SelectedItem.ToString());
            Decimal Height = HeightBox.Value;
            Decimal Weight = WeightBox.Value;
            DateTime JoinYear = JoinYearPicker.Value;
            DateTime BirthDay = BirthDayPicker.Value;
            if (FIO == String.Empty)
            {
                MessageBox.Show("Введите ФИО");
                return;
            }
            MemoryStream memoryStream = new MemoryStream();
            PhotoBox.Image.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Bmp);
            SqlConnection sqlConnection = new SqlConnection(Properties.Settings.Default.ConnectionString);
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("UPDATE [Player] SET [Name]=@Name, [PositionId]=@Position, [JoinYear]=@JoinYear, [Height]=@Height, [Weight]=@Weight, [DateOfBirth]=@DateOfBirth, [Img]=@Img, [TeamId]=@TeamId WHERE [PlayerId]=@ID" , sqlConnection);
            sqlCommand.Parameters.Add(new SqlParameter("@Name", FIO));
            sqlCommand.Parameters.Add(new SqlParameter("@Position", PositionID));
            sqlCommand.Parameters.Add(new SqlParameter("@JoinYear", JoinYear.ToShortDateString()));
            sqlCommand.Parameters.Add(new SqlParameter("@Height", Height));
            sqlCommand.Parameters.Add(new SqlParameter("@Weight", Weight));
            sqlCommand.Parameters.Add(new SqlParameter("@DateOfBirth", BirthDay.ToShortDateString()));
            sqlCommand.Parameters.Add(new SqlParameter("@Img", memoryStream.ToArray()));
            sqlCommand.Parameters.Add(new SqlParameter("@TeamId", TeamID));
            sqlCommand.Parameters.Add(new SqlParameter("@ID", ID));
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            memoryStream.Close();
            memoryStream.Dispose();
            closing = false;
            (this.Owner as ManagePlayersForm).LoadPlayers();
            this.Owner.Show();
            this.Close();
        }

        private void EditPlayerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (closing)
                Application.Exit();
        }

        private void PhotoBox_Click(object sender, EventArgs e)
        {
            if (PhotoFileDialog.ShowDialog() == DialogResult.OK)
            {
                Image image = Image.FromFile(PhotoFileDialog.FileName);
                PhotoBox.Image = Image.FromHbitmap(Program.ResizeImage(image, 101, 96).GetHbitmap());
            }
        }
    }
}