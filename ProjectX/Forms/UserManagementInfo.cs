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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ProjectX.Forms
{
    public partial class UserManagementInfo : Form
    {
        private Main mainForm;
        private int UserID;
        private string Username;
        public UserManagementInfo(Main mainForm, int userID)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            UserID = userID;
        }

        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\source\repos\ProjectX\ProjectX\Database.mdf;Integrated Security=True");

        private void UserManagementInfo_Load(object sender, EventArgs e)
        {
            string query = $"SELECT * FROM Users WHERE UserID=@UserID;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserID", UserID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    txtUserID.Text = UserID.ToString();
                    Username = reader["Username"].ToString();
                    txtUsername.Texts = Username;
                    txtPassword.Texts = reader["Password"].ToString();
                    txtFirstName.Texts = reader["FirstName"].ToString();
                    txtLastName.Texts = reader["LastName"].ToString();
                    txtEmail.Texts = reader["Email"].ToString();
                    cmbRole.Texts = reader["Role"].ToString();
                }
                reader.Close();
                connection.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Texts;
            string password = txtPassword.Texts;
            string firstName = txtFirstName.Texts;
            string lastName = txtLastName.Texts;
            string email = txtEmail.Texts;
            string role = cmbRole.Texts;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(role))
            {
                MessageBox.Show("Please fill all input fields.");
                return;
            }
            if(username != Username)
            {
                string queryUserName = $"SELECT COUNT(*) FROM Users WHERE Username=@Username";
                SqlCommand commandUserName = new SqlCommand(queryUserName, connection);
                commandUserName.Parameters.AddWithValue("@Username", username);
                try
                {
                    connection.Open();
                    int count = (int)commandUserName.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show("Username already exists.");
                        txtUsername.Texts = Username;
                        connection.Close();
                        return;
                    }
                    connection.Close();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            string query = $"UPDATE Users SET Username=@Username, Password=@Password, FirstName=@FirstName, LastName=@LastName, Email=@Email, Role=@Role WHERE UserID=@UserID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Username", username);
            command.Parameters.AddWithValue("@Password", password);
            command.Parameters.AddWithValue("@FirstName", firstName);
            command.Parameters.AddWithValue("@LastName", lastName);
            command.Parameters.AddWithValue("@Email", email);
            command.Parameters.AddWithValue("@Role", role);
            command.Parameters.AddWithValue("@UserID", UserID);
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show($"Success: User \"{Username}\" has been Updated.");
                mainForm.ChangeChildForm(new UserManagement(mainForm));
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string query = $"DELETE FROM Users WHERE UserID=@UserID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserID", UserID);
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show($"Success: User \"{Username}\" has been deleted.");
                mainForm.ChangeChildForm(new UserManagement(mainForm));
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            mainForm.ChangeChildForm(new UserManagement(mainForm));
        }
    }
}
