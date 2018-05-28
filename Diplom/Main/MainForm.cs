using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diplom
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        Int32 NumberOfPictures = 0;
        Int32 LastNumberOfPictures = 0;

        public static Int32 CurrentSeason;

        public void LoadFooter()
        {
            SqlConnection sqlConnection = new SqlConnection(Properties.Settings.Default.ConnectionString);
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(String.Format("SELECT TOP 1 [Name] FROM [Season] ORDER BY SeasonId DESC"), sqlConnection);
            String Season = sqlCommand.ExecuteScalar().ToString();
            sqlCommand.CommandText = String.Format("SELECT TOP 1 [SeasonId] FROM [Season] ORDER BY SeasonId DESC");
            CurrentSeason = Convert.ToInt32(sqlCommand.ExecuteScalar());
            Int32 CurrentYear = DateTime.Now.Year;
            Int32 NumberOfNBA = CurrentYear - 1946;
            Program.Footer = $"Текущий сезон {Season} | История NBA насчитывает {NumberOfNBA} лет";
            FooterLabel.Text = Program.Footer;
            sqlConnection.Close();
        }

        public void LoadPictures()
        {
            SqlConnection sqlConnection = new SqlConnection(Properties.Settings.Default.ConnectionString);
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(String.Format("SELECT [Id], [Img] FROM [Pictures] ORDER BY [Id] OFFSET {0} ROWS", NumberOfPictures), sqlConnection);
            var reader = sqlCommand.ExecuteReader();
            for (int i = 1; i <= 3; i++)
            {
                if (reader.Read())
                {
                    try
                    {
                        MemoryStream memoryStream = new MemoryStream();
                        memoryStream.Write((byte[])reader.GetValue(1), 0, ((byte[])reader.GetValue(1)).Length);
                        (panel3.Controls["Image" + i] as PictureBox).Image = Image.FromStream(memoryStream);
                    }
                    catch
                    {
                        continue;
                    }
                }
            }
            reader.Close();
            sqlConnection.Close();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(Properties.Settings.Default.ConnectionString);
            try
            {   
                sqlConnection.Open();
            }
            catch
            {
                MessageBox.Show("Не удаётся подключится к базе данных!!!");
                Application.Exit();
                return;
            }
            
            SqlCommand sqlCommand = new SqlCommand("SELECT COUNT(*) FROM [Pictures]", sqlConnection);
            LastNumberOfPictures = (Int32)sqlCommand.ExecuteScalar();
            sqlConnection.Close();
            LoadPictures();
            LoadFooter();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            NumberOfPictures++;
            if (NumberOfPictures + 4 > LastNumberOfPictures)
            {
                NumberOfPictures = LastNumberOfPictures - 3;
            }
            LoadPictures();
        }

        private void ForwardButton_Click(object sender, EventArgs e)
        {
            NumberOfPictures--;
            if(NumberOfPictures <= 0)
            {
                NumberOfPictures = 0;
            }
            LoadPictures();
        }

        private void VisitorButton_Click(object sender, EventArgs e)
        {
            VisitorMenuForm visitorMenuForm = new VisitorMenuForm();
            visitorMenuForm.Show(this);
            this.Hide();
        }

        private void AdminButton_Click(object sender, EventArgs e)
        {
            AdminLoginForm adminLoginForm = new AdminLoginForm();
            adminLoginForm.Show(this);
            this.Hide();
        }
    }
}