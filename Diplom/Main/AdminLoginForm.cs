using Microsoft.Win32;
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
    public partial class AdminLoginForm : Form
    {
        public AdminLoginForm()
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

        private void AdminLoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (closing)
                Application.Exit();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            String Login = LoginTextBox.Text.Trim();
            String Password = PasswordTextBox.Text.Trim();
            Boolean RememberMe = RememberMeCheckBox.Checked;

            if(Login == String.Empty || Password == String.Empty)
            {
                MessageBox.Show("Не все поля заполнены");
            }
            else
            {
                SqlConnection sqlConnection = new SqlConnection(Properties.Settings.Default.ConnectionString);
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(String.Format("SELECT * FROM [Admin] WHERE Jobnumber='{0}' AND Passwords=CONVERT(VARCHAR(32), HashBytes('MD5', '{1}'), 2)", Login, Password), sqlConnection);
                var User = sqlCommand.ExecuteReader();
                if(User.Read())
                {
                    if (RememberMe)
                    {
                        RegistryKey currentUserKey = Registry.CurrentUser;
                        RegistryKey NBAManagement = currentUserKey.CreateSubKey("NBAManagement");
                        NBAManagement.SetValue("Login", Login);
                        NBAManagement.Close();
                        currentUserKey.Close();
                    }
                    AdministratorMenuForm administratorMenuForm = new AdministratorMenuForm();
                    administratorMenuForm.Show(this);
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Неправильно введён логин или пароль");
                }
                User.Close();
                sqlConnection.Close();
            }
        }

        private void AdminLoginForm_Load(object sender, EventArgs e)
        {
                RegistryKey currentUserKey = Registry.CurrentUser;
            RegistryKey NBAManagement = currentUserKey.CreateSubKey("NBAManagement");
            RememberMeCheckBox.Checked = false;
            if (NBAManagement.GetValue("Login") != null)
            {
                LoginTextBox.Text = NBAManagement.GetValue("Login").ToString();
                RememberMeCheckBox.Checked = true;
            }
            NBAManagement.Close();
            currentUserKey.Close();
            label1.Text = Program.Footer;
        }

        private void LoginTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                LoginButton.Focus();
                LoginButton.PerformClick();
            }
        }
    }
}