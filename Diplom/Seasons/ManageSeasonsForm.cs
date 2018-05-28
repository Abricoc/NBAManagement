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
    public partial class ManageSeasonsForm : Form
    {
        public ManageSeasonsForm()
        {
            InitializeComponent();
        }

        private void LoadSeasons()
        {
            SeasonsListBox.Items.Clear();
            SqlConnection sqlConnection = new SqlConnection(Properties.Settings.Default.ConnectionString);
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Season", sqlConnection);
            var Seasons = sqlCommand.ExecuteReader();
            while (Seasons.Read())
            {
                SeasonsListBox.Items.Add(Seasons.GetString(1));
            }
            Seasons.Close();
            sqlConnection.Close();
        }

        private void ManageSeasonsForm_Load(object sender, EventArgs e)
        {
            LoadSeasons();
            label1.Text = Program.Footer;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            String SeasonText = SeasonTextBox.Text.Trim();
            if (SeasonText == String.Empty)
            {
                MessageBox.Show("Заполните поля");
            }
            else
            {
                try
                {
                    SqlConnection sqlConnection = new SqlConnection(Properties.Settings.Default.ConnectionString);
                    sqlConnection.Open();
                    SqlCommand sqlCommand = new SqlCommand(String.Format("INSERT INTO [Season] ([Name]) VALUES ('{0}')", SeasonText), sqlConnection);
                    sqlCommand.ExecuteNonQuery();
                    sqlConnection.Close();
                }
                catch
                {
                    MessageBox.Show("Сезон с таким названием уже существует");
                }
            }
            LoadSeasons();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if(SeasonsListBox.SelectedIndex != -1)
            {
                String SeasonText = SeasonTextBox.Text.Trim();
                if (SeasonText == String.Empty)
                {
                    MessageBox.Show("Заполните поле с названием сезона");
                }
                else
                {
                    SqlConnection sqlConnection = new SqlConnection(Properties.Settings.Default.ConnectionString);
                    sqlConnection.Open();
                    SqlCommand sqlCommand = new SqlCommand(String.Format("UPDATE [Season] SET [Name]='{0}' WHERE [Name]='{1}'", SeasonText, SeasonsListBox.SelectedItem.ToString()), sqlConnection);
                    sqlCommand.ExecuteNonQuery();
                    sqlConnection.Close();
                }
                LoadSeasons();
            }
            else
            {
                MessageBox.Show("Для изменения, необходимо сначала выбрать сезон из списка слева");
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {

            try
            {
                if (SeasonsListBox.SelectedIndex != -1)
                {

                    if (MessageBox.Show("Вы уверены, что хотите удалить?", "Внимание", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        SqlConnection sqlConnection = new SqlConnection(Properties.Settings.Default.ConnectionString);
                        sqlConnection.Open();
                        SqlCommand sqlCommand = new SqlCommand(String.Format("DELETE [Season] WHERE [Name]='{0}'", SeasonsListBox.SelectedItem.ToString()), sqlConnection);
                        sqlCommand.ExecuteNonQuery();
                        sqlConnection.Close();
                        LoadSeasons();
                    }
                }
                else
                {
                    MessageBox.Show("Для изменения, необходимо сначала выбрать сезон из списка слева");
                }
            }
            catch
            {
                MessageBox.Show("Невозможно удалить данный сезон. Для начала удалите всю информацию связанную с этим сезоном");
            }
        }

        Boolean closing = true;

        private void BackButton_Click(object sender, EventArgs e)
        {
            closing = false;
            this.Owner.Show();
            this.Close();
        }

        private void ManageSeasonsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (closing)
                Application.Exit();
        }

        private void SeasonsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SeasonTextBox.Text = SeasonsListBox.Items[SeasonsListBox.SelectedIndex].ToString();
            }
            catch
            {
                
            }
        }

        private void SeasonTextBox_TextChanged(object sender, EventArgs e)
        {
            if(SeasonTextBox.Text == String.Empty)
            {
                SeasonsListBox.SelectedIndex = -1;
            }
        }
    }
}
