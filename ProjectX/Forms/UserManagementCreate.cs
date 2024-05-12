using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO.Packaging;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace ProjectX.Forms
{
    public partial class UserManagementCreate : Form
    {
        private Main mainForm;
        public UserManagementCreate(Main mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\source\repos\ProjectX\ProjectX\Database.mdf;Integrated Security=True");

        private void btnBack_Click(object sender, EventArgs e)
        {
            mainForm.ChangeChildForm(new UserManagement(mainForm));
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Texts;
            string password = txtPassword.Texts;
            string firstName = txtFirstName.Texts;
            string lastName = txtLastName.Texts;
            string email = txtEmail.Texts;
            string role = cmbRole.Texts;

            if (string.IsNullOrEmpty(txtUserID.Texts) || string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(role))
            {
                MessageBox.Show("Please fill all input fields.");
                return;
            }

            if (!int.TryParse(txtUserID.Texts, out int userID))
            {
                MessageBox.Show("Invalid UserID format. Please provide an integer.");
                txtUserID.Texts = string.Empty;
                return;
            }

            string query = $"SELECT COUNT(*) FROM Users WHERE UserID=@UserID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserID", userID);
            try
            {
                connection.Open();
                int count = (int)command.ExecuteScalar();

                if (count > 0)
                {
                    MessageBox.Show("User ID already exists. Please choose a different ID.");
                    txtUserID.Texts = string.Empty;
                    connection.Close();
                    return;
                }
                connection.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            query = $"SELECT COUNT(*) FROM Users WHERE Username=@Username";
            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Username", username);
            try
            {
                connection.Open();
                int count = (int)command.ExecuteScalar();

                if (count > 0)
                {
                    MessageBox.Show("Username already exists. Please choose a different username.");
                    txtUsername.Texts = string.Empty;
                    connection.Close();
                    return;
                }
                connection.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            query = $"INSERT INTO Users (UserID, Username, Password, FirstName, LastName, Email, Role) VALUES (@UserID,@Username,@Password,@FirstName,@LastName,@Email,@Role)";
            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserID", userID);
            command.Parameters.AddWithValue("@Username", username);
            command.Parameters.AddWithValue("@Password", password);
            command.Parameters.AddWithValue("@FirstName", firstName);
            command.Parameters.AddWithValue("@LastName", lastName);
            command.Parameters.AddWithValue("@Email", email);
            command.Parameters.AddWithValue("@Role", role);
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show($"Success: User \"{username}\" has been added.");
                mainForm.ChangeChildForm(new UserManagement(mainForm));
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
