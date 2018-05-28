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
    public partial class ManagePhotosForm : Form
    {
        public ManagePhotosForm()
        {
            InitializeComponent();
        }

        private void LoadPhotos()
        {
            PhotosPanel.Controls.Clear();
            SqlConnection sqlConnection = new SqlConnection(Properties.Settings.Default.ConnectionString);
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(String.Format("SELECT [Id], [Img] FROM [Pictures]"), sqlConnection);
            var reader = sqlCommand.ExecuteReader();
            Int32 i = 0;
            while (reader.Read())
            {
                try
                {
                    MemoryStream memoryStream = new MemoryStream();
                    memoryStream.Write((byte[])reader.GetValue(1), 0, ((byte[])reader.GetValue(1)).Length);
                    Panel PicturePanel = new Panel();
                    PicturePanel.BorderStyle = BorderStyle.FixedSingle;
                    PicturePanel.Size = new Size(935, 300);
                    PicturePanel.Location = new Point(0, i * 300 + 1);
                    PictureBox Picture = new PictureBox();
                    Picture.SizeMode = PictureBoxSizeMode.StretchImage;
                    Picture.Image = Image.FromStream(memoryStream);
                    Picture.Size = new Size(510, 295);
                    PicturePanel.Controls.Add(Picture);

                    Button EditButton = new Button();
                    EditButton.Text = "Изменить";
                    EditButton.BackColor = Color.FromArgb(105, 149, 194);
                    EditButton.Size = new Size(170, 65);
                    EditButton.Font = new Font(EditButton.Font.FontFamily, 15);
                    EditButton.Location = new Point(530, 100);
                    EditButton.ForeColor = Color.White;
                    EditButton.Tag = reader.GetInt32(0);
                    EditButton.Click += EditButton_Click;

                    Button DeleteButton = new Button();
                    DeleteButton.Text = "Удалить";
                    DeleteButton.BackColor = Color.FromArgb(105, 149, 194);
                    DeleteButton.Size = new Size(170, 65);
                    DeleteButton.Font = new Font(DeleteButton.Font.FontFamily, 15);
                    DeleteButton.Location = new Point(730, 100);
                    DeleteButton.ForeColor = Color.White;
                    DeleteButton.Tag = reader.GetInt32(0);
                    DeleteButton.Click += DeleteButton_Click;

                    PicturePanel.Controls.Add(EditButton);
                    PicturePanel.Controls.Add(DeleteButton);
                    i++;
                    PhotosPanel.Controls.Add(PicturePanel);
                }
                catch
                {
                    continue;
                }
                
            }
            reader.Close();
            sqlConnection.Close();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            Int32 ID = Convert.ToInt32((sender as Button).Tag);
            if(PhotoFileDialog.ShowDialog() == DialogResult.OK)
            {
                MemoryStream memoryStream = new MemoryStream();
                Image image = Image.FromFile(PhotoFileDialog.FileName);
                image.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Bmp);
                SqlConnection sqlConnection = new SqlConnection(Properties.Settings.Default.ConnectionString);
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(String.Format("UPDATE [Pictures] SET [Img]=@img WHERE [Id]={0}", ID), sqlConnection);
                sqlCommand.Parameters.Add(new SqlParameter("@img", memoryStream.ToArray()));
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                memoryStream.Close();
                memoryStream.Dispose();
            }
            LoadPhotos();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            Int32 ID = Convert.ToInt32((sender as Button).Tag);
            SqlConnection sqlConnection = new SqlConnection(Properties.Settings.Default.ConnectionString);
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(String.Format("DELETE FROM [Pictures] WHERE [Id]={0}", ID), sqlConnection);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            LoadPhotos();
        }

        private void ManagePhotosForm_Load(object sender, EventArgs e)
        {
            label1.Text = Program.Footer;
            LoadPhotos();
        }

        Boolean closing = true;

        private void BackButton_Click(object sender, EventArgs e)
        {
            closing = false;
            this.Owner.Show();
            this.Close();
        }

        private void ManagePhotosForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (closing)
                Application.Exit();
        }
        
        private void AddPhotoButton_Click(object sender, EventArgs e)
        {
            if (PhotoFileDialog.ShowDialog() == DialogResult.OK)
            {
                MemoryStream memoryStream = new MemoryStream();
                Image image = Image.FromFile(PhotoFileDialog.FileName);
                image.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Bmp);
                SqlConnection sqlConnection = new SqlConnection(Properties.Settings.Default.ConnectionString);
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(String.Format("INSERT INTO [Pictures] ([Img]) VALUES (@img)"), sqlConnection);
                sqlCommand.Parameters.Add(new SqlParameter("@img", memoryStream.ToArray()));
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                memoryStream.Close();
                memoryStream.Dispose();
            }
            LoadPhotos();
        }
    }
}