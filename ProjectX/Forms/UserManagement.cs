using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace ProjectX.Forms
{
    public partial class UserManagement : Form
    {
        private Main mainForm;
        public UserManagement(Main mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\source\repos\ProjectX\ProjectX\Database.mdf;Integrated Security=True");

        private void UserManagement_Load(object sender, EventArgs e)
        {
            string query = $"SELECT * FROM Users";
            SqlCommand command = new SqlCommand(query, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int userID = (int)reader["UserID"];
                    string username = reader["Username"].ToString();
                    string firstName = reader["FirstName"].ToString();
                    string lastName = reader["LastName"].ToString();
                    string email = reader["Email"].ToString();
                    string role = reader["Role"].ToString();

                    CreateAndAddTableRow(userID, username, firstName, lastName, email, role);
                }
                reader.Close();
                connection.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CreateAndAddTableRow(int userID, string username, string firstName, string lastName, string email, string role)
        {
            UserControls.UserManagementTableRow row = new UserControls.UserManagementTableRow(userID,username,firstName,lastName,email,role);
            pnlTableContent.Controls.Add(row);
            row.Dock = DockStyle.Top;
            row.BringToFront();
            row.Cursor = Cursors.Hand;
            row.RowClick += Row_Click;
        }

        private void Row_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Label label = sender as System.Windows.Forms.Label;
            int userID = Convert.ToInt32(label.Text);
            mainForm.ChangeChildForm(new UserManagementInfo(mainForm,userID));
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            mainForm.ChangeChildForm(new UserManagementCreate(mainForm));
        }
    }
}
