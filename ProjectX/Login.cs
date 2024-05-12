using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProjectX
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\source\repos\ProjectX\ProjectX\Database.mdf;Integrated Security=True");

        private void Login_Load(object sender, EventArgs e)
        {
            if(Properties.Settings.Default.Username != string.Empty)
            {
                txtUsername.Texts = Properties.Settings.Default.Username;
                txtUsername.ForeColor = Color.Black;
                txtPassword.Texts = Properties.Settings.Default.Password;
                txtPassword.ForeColor = Color.Black;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(chkRememberMe.Checked)
            {
                Properties.Settings.Default.Username = txtUsername.Texts;
                Properties.Settings.Default.Password = txtPassword.Texts;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.Username = "";
                Properties.Settings.Default.Password = "";
                Properties.Settings.Default.Save();
            }
            string Username = txtUsername.Texts;
            string password = txtPassword.Texts;
            if (Username != "Username" && password != "Password")
            {
                string query = $"SELECT * FROM Users WHERE Username=@Username AND Password=@Password";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", Username);
                command.Parameters.AddWithValue("@Password", password);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        txtUsername.Texts = "Username";
                        txtUsername.ForeColor = Color.FromArgb(115, 115, 115);
                        txtPassword.Texts = "Password";
                        txtPassword.ForeColor = Color.FromArgb(115, 115, 115);
                        string AccountType = reader["Role"].ToString();
                        string UserName = reader["Username"].ToString();
                        Main main = new Main(this, UserName, AccountType);
                        main.Show();
                        this.Hide();
                    }
                    else
                    {
                        txtUsername.Texts = "Username";
                        lblUsernameError.Text = "Please enter your Trip Wizard username.";
                        txtUsername.BorderColor = Color.FromArgb(176, 0, 32);
                        txtUsername.BorderFocusColor = Color.FromArgb(176, 0, 32);
                        txtPassword.Texts = "Password";
                        lblPasswordError.Text = "Please enter your password.";
                        txtPassword.BorderColor = Color.FromArgb(176, 0, 32);
                        txtPassword.BorderFocusColor = Color.FromArgb(176, 0, 32);
                    }
                    connection.Close();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                if (txtUsername.Texts == "Username")
                {
                    lblUsernameError.Text = "Please enter your Trip Wizard username.";
                    txtUsername.BorderColor = Color.FromArgb(176, 0, 32);
                    txtUsername.BorderFocusColor = Color.FromArgb(176, 0, 32);
                }
                else
                {
                    lblUsernameError.Text = "";
                    txtUsername.BorderColor = Color.FromArgb(115, 115, 115);
                    txtUsername.BorderFocusColor = Color.FromArgb(115, 115, 115);
                }
                if (txtPassword.Texts == "Password")
                {
                    lblPasswordError.Text = "Please enter your password.";
                    txtPassword.BorderColor = Color.FromArgb(176, 0, 32);
                    txtPassword.BorderFocusColor = Color.FromArgb(176, 0, 32);
                }
                else
                {
                    lblPasswordError.Text = "";
                    txtPassword.BorderColor = Color.FromArgb(115, 115, 115);
                    txtPassword.BorderFocusColor = Color.FromArgb(115, 115, 115);
                }
            }
        }

        
    }
}
