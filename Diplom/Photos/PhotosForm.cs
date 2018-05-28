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
    public partial class PhotosForm : Form
    {
        Int32 Page = 1;
        Int32 LastPage = 0;
        public PhotosForm()
        {
            InitializeComponent();
        }

        private void LoadPictures()
        {
            Page = Convert.ToInt32(PageBox.Text);
            SqlConnection sqlConnection = new SqlConnection(Properties.Settings.Default.ConnectionString);
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(String.Format("SELECT [Id], [Img] FROM [Pictures] ORDER BY [Id] OFFSET {0} ROWS", (Page - 1) * 12), sqlConnection);
            var reader = sqlCommand.ExecuteReader();
            for (int i = 1; i <= 12; i++)
            {
                (PicturesPanel.Controls["pictureBox" + i] as PictureBox).Image = null;
                if (reader.Read())
                {
                    (PicturesPanel.Controls["pictureBox" + i] as PictureBox).BorderStyle = BorderStyle.FixedSingle;
                    try
                    {
                        MemoryStream memoryStream = new MemoryStream();
                        memoryStream.Write((byte[])reader.GetValue(1), 0, ((byte[])reader.GetValue(1)).Length);
                        (PicturesPanel.Controls["pictureBox" + i] as PictureBox).Image = Image.FromStream(memoryStream);
                    }
                    catch
                    {
                        continue;
                    }
                    
                }
                else
                {
                    (PicturesPanel.Controls["pictureBox" + i] as PictureBox).BorderStyle = BorderStyle.None;
                    continue;
                }
            }
            reader.Close();
            sqlConnection.Close();
        }

        private void PhotosForm_Load(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(Properties.Settings.Default.ConnectionString);
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(String.Format("SELECT ROUND(COUNT(*)/12, 0)+1 FROM [NBA].[dbo].[Pictures]"), sqlConnection);
            LastPage = Convert.ToInt32(sqlCommand.ExecuteScalar());
            sqlConnection.Close();
            LoadPictures();
            label1.Text = Program.Footer;
        }

        Boolean closing = true;

        private void BackButton_Click(object sender, EventArgs e)
        {
            closing = false;
            this.Owner.Show();
            this.Close();
        }

        private void PhotosForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (closing)
                Application.Exit();
        }

        private void FirstPageButton_Click(object sender, EventArgs e)
        {
            Page = 1;
            PageBox.Text = Page.ToString();
            LoadPictures();
        }

        private void PrevButton_Click(object sender, EventArgs e)
        {
            Page--;
            if(Page < 1)
            {
                Page = 1;
            }
            PageBox.Text = Page.ToString();
            LoadPictures();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            Page++;
            if(Page > LastPage)
            {
                Page = LastPage;
            }
            PageBox.Text = Page.ToString();
            LoadPictures();
        }

        private void LastPageButton_Click(object sender, EventArgs e)
        {
            Page = LastPage;
            PageBox.Text = Page.ToString();
            LoadPictures();
        }

        private void скачатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.AddExtension = true;
            saveFileDialog.DefaultExt = ".png";
            saveFileDialog.Filter = "Image Files|*.jpg;*.png;*.bmp,*.jpeg";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                (((sender as ToolStripMenuItem).GetCurrentParent() as ContextMenuStrip).SourceControl as PictureBox).Image.Save(saveFileDialog.FileName);
            }
        }

        private void PageBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Int32 Page = Convert.ToInt32(PageBox.Text);
                PrevButton.Enabled = true;
                FirstPageButton.Enabled = true;
                NextButton.Enabled = true;
                LastPageButton.Enabled = true;
                if (Page == 1)
                {
                    PrevButton.Enabled = false;
                    FirstPageButton.Enabled = false;
                }
                if(Page == LastPage)
                {
                    NextButton.Enabled = false;
                    LastPageButton.Enabled = false;
                }
            }
            catch (Exception)
            {
                
            }
        }
    }
}