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
    public partial class CustomerProfilesCreate : Form
    {
        private Main mainForm;
        public CustomerProfilesCreate(Main mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\source\repos\ProjectX\ProjectX\Database.mdf;Integrated Security=True");

        private void btnBack_Click(object sender, EventArgs e)
        {
            mainForm.ChangeChildForm(new CustomerProfiles(mainForm));
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Texts;
            string lastName = txtLastName.Texts;
            string email = txtEmail.Texts;
            string address = txtAddress.Texts;
            string phone = txtPhone.Texts;

            if (string.IsNullOrEmpty(txtCustomerID.Texts) || string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(address) || string.IsNullOrEmpty(phone))
            {
                MessageBox.Show("Please fill all input fields.");
                return;
            }

            if (!int.TryParse(txtCustomerID.Texts, out int customerID))
            {
                MessageBox.Show("Invalid CustomerID format. Please provide an integer.");
                txtCustomerID.Texts = string.Empty;
                return;
            }

            string query = $"SELECT COUNT(*) FROM Customers WHERE CustomerID=@CustomerID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CustomerID", customerID);
            try
            {
                connection.Open();
                int count = (int)command.ExecuteScalar();

                if (count > 0)
                {
                    MessageBox.Show("Customer ID already exists. Please choose a different ID.");
                    txtCustomerID.Texts = string.Empty;
                    connection.Close();
                    return;
                }
                connection.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            query = $"INSERT INTO Customers (CustomerID, FirstName, LastName, Email, Address, Phone) VALUES (@CustomerID,@FirstName,@LastName,@Email,@Address,@Phone)";
            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CustomerID", customerID);
            command.Parameters.AddWithValue("@FirstName", firstName);
            command.Parameters.AddWithValue("@LastName", lastName);
            command.Parameters.AddWithValue("@Email", email);
            command.Parameters.AddWithValue("@Address", address);
            command.Parameters.AddWithValue("@Phone", phone);
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show($"Success: Customer \"{firstName}\" has been added.");
                mainForm.ChangeChildForm(new CustomerProfiles(mainForm));
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
