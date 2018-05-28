using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diplom
{
    public partial class AddTeamForm : Form
    {
        public AddTeamForm()
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

        private void AddTeamForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (closing)
                Application.Exit();
        }

        private void LoadDivisions()
        {
            DivisionBox.Items.Clear();
            SqlConnection sqlConnection = new SqlConnection(Properties.Settings.Default.ConnectionString);
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM [Division]", sqlConnection);
            var Divisions = sqlCommand.ExecuteReader();
            while (Divisions.Read())
            {
                DivisionBox.Items.Add(Divisions.GetString(1));
            }
            Divisions.Close();
            sqlConnection.Close();
            if(DivisionBox.Items.Count > 0)
            {
                DivisionBox.SelectedIndex = 0;
            }
        }

        private void AddTeamForm_Load(object sender, EventArgs e)
        {
            LoadDivisions();
            FooterLabel.Text = Program.Footer;
        }

        private void LogoButton_Click(object sender, EventArgs e)
        {
            
        }

        private Int32 GetDivisionID(String DivisionName)
        {
            Int32 ID = 0;
            try
            {
                SqlConnection sqlConnection = new SqlConnection(Properties.Settings.Default.ConnectionString);
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(String.Format("SELECT [DivisionId] FROM [Division] WHERE [Name]='{0}'", DivisionName), sqlConnection);
                ID = Convert.ToInt32(sqlCommand.ExecuteScalar());
            }
            catch
            {
                ID = 0;
            }
            return ID;
        }

        private void AddTeamButton_Click(object sender, EventArgs e)
        {
            try
            {
                String TeamName = TeamNameBox.Text.Trim();
                String Coach = CoachBox.Text.Trim();
                String Abbr = AbbrBox.Text.Trim();
                Int32 DivisionID = GetDivisionID(DivisionBox.SelectedItem.ToString());
                if (TeamName == String.Empty)
                {
                    MessageBox.Show("Введите название команды");
                    return;
                }
                if (Coach == String.Empty)
                {
                    MessageBox.Show("Введите ФИО тренера");
                    return;
                }
                if (Abbr == String.Empty)
                {
                    MessageBox.Show("Введите короткое название команды");
                    return;
                }
                if (LogoBox.Image == null)
                {
                    MessageBox.Show("Выберите логотип команды");
                    return;
                }
                MemoryStream memoryStream = new MemoryStream();
                LogoBox.Image.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Bmp);
                SqlConnection sqlConnection = new SqlConnection(Properties.Settings.Default.ConnectionString);
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("INSERT INTO [Team] ([TeamName], [DivisionId], [Coach], [Abbr], [Logo]) VALUES (@TeamName, @DivisionID, @Coach, @Abbr, @Logo)", sqlConnection);
                sqlCommand.Parameters.Add(new SqlParameter("@TeamName", TeamName));
                sqlCommand.Parameters.Add(new SqlParameter("@DivisionID", DivisionID));
                sqlCommand.Parameters.Add(new SqlParameter("@Coach", Coach));
                sqlCommand.Parameters.Add(new SqlParameter("@Abbr", Abbr));
                sqlCommand.Parameters.Add(new SqlParameter("@Logo", memoryStream.ToArray()));
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                memoryStream.Close();
                memoryStream.Dispose();
                closing = false;
                (this.Owner as ManageTeamsForm).LoadTeams();
                this.Owner.Show();
                this.Close();
            }
            catch
            {
                MessageBox.Show("Команда с таким названием уже существует");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (LogoFileDialog.ShowDialog() == DialogResult.OK)
            {
                Image image = Image.FromFile(LogoFileDialog.FileName);
                LogoBox.Image = Image.FromHbitmap(Program.ResizeImage(image, 130, 130).GetHbitmap());
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
