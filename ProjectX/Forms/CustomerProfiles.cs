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

namespace ProjectX.Forms
{
    public partial class CustomerProfiles : Form
    {
        private Main mainForm;
        public CustomerProfiles(Main mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\source\repos\ProjectX\ProjectX\Database.mdf;Integrated Security=True");

        private void CustomerProfiles_Load(object sender, EventArgs e)
        {
            string query = $"SELECT * FROM Customers";
            SqlCommand command = new SqlCommand(query, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int customerID = (int)reader["CustomerID"];
                    string firstName = reader["FirstName"].ToString();
                    string lastName = reader["LastName"].ToString();
                    string email = reader["Email"].ToString();
                    string phone = reader["Phone"].ToString();

                    CreateAndAddTableRow(customerID, firstName, lastName, email, phone);
                }
                reader.Close();
                connection.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CreateAndAddTableRow(int customerID, string firstName, string lastName, string email, string phone)
        {
            UserControls.CustomerProfilesTableRow row = new UserControls.CustomerProfilesTableRow(customerID, firstName, lastName, email, phone);
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
            mainForm.ChangeChildForm(new CustomerProfilesInfo(mainForm, userID));
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            mainForm.ChangeChildForm(new CustomerProfilesCreate(mainForm));
        }
    }
}
