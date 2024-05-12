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
    public partial class CustomerProfilesInfo : Form
    {
        private Main mainForm;
        private int CustomerID;
        private string FirstName;
        public CustomerProfilesInfo(Main mainForm, int CustomerID)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.CustomerID = CustomerID;
        }

        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\source\repos\ProjectX\ProjectX\Database.mdf;Integrated Security=True");

        private void CustomerProfilesInfo_Load(object sender, EventArgs e)
        {
            string query = $"SELECT * FROM Customers WHERE CustomerID=@CustomerID;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CustomerID", CustomerID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    txtCustomerID.Text = CustomerID.ToString();
                    FirstName = reader["FirstName"].ToString();
                    txtFirstName.Texts = FirstName;
                    txtLastName.Texts = reader["LastName"].ToString();
                    txtEmail.Texts = reader["Email"].ToString();
                    txtAddress.Texts = reader["Address"].ToString();
                    txtPhone.Texts = reader["Phone"].ToString();
                }
                reader.Close();
                connection.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string query = $"DELETE FROM Customers WHERE CustomerID=@CustomerID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CustomerID", CustomerID);
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show($"Success: Customer \"{FirstName}\" has been deleted.");
                mainForm.ChangeChildForm(new CustomerProfiles(mainForm));
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            mainForm.ChangeChildForm(new CustomerProfiles(mainForm));
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Texts;
            string lastName = txtLastName.Texts;
            string email = txtEmail.Texts;
            string address = txtAddress.Texts;
            string phone = txtPhone.Texts;

            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(address) || string.IsNullOrEmpty(phone))
            {
                MessageBox.Show("Please fill all input fields.");
                return;
            }

            string query = $"UPDATE Customers SET FirstName=@FirstName, LastName=@LastName, Email=@Email, Address=@Address, Phone=@Phone WHERE CustomerID=@CustomerID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@FirstName", firstName);
            command.Parameters.AddWithValue("@LastName", lastName);
            command.Parameters.AddWithValue("@Email", email);
            command.Parameters.AddWithValue("@Address", address);
            command.Parameters.AddWithValue("@Phone", phone);
            command.Parameters.AddWithValue("@CustomerID", CustomerID);
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show($"Success: Customer \"{FirstName}\" has been updated.");
                mainForm.ChangeChildForm(new CustomerProfiles(mainForm));
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
