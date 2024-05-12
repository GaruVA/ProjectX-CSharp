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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ProjectX.UserControls
{
    public partial class BookingsTableRow : UserControl
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\source\repos\ProjectX\ProjectX\Database.mdf;Integrated Security=True");

        private int BookingID;
        private int ItineraryID;
        private int CustomerID;
        private DateTime StartDate;
        private DateTime EndDate;
        private string Status;
        public BookingsTableRow()
        {
            InitializeComponent();
        }
        public BookingsTableRow(int BookingID, int ItineraryID, int CustomerID, DateTime StartDate, DateTime EndDate, string Status)
        {
            InitializeComponent();
            this.BookingID = BookingID;
            this.ItineraryID = ItineraryID;
            this.CustomerID = CustomerID;
            this.StartDate = StartDate;
            this.EndDate = EndDate;
            this.Status = Status;
        }
        public event EventHandler RowClick;

        private void HoverEffect_Enter(object sender, EventArgs e)
        {
            lblTableRowBookingID.BackColor = Color.FromArgb(229, 229, 229);
            lblTableRowItineraryID.BackColor = Color.FromArgb(229, 229, 229);
            lblTableRowCustomer.BackColor = Color.FromArgb(229, 229, 229);
            lblTableRowStartDate.BackColor = Color.FromArgb(229, 229, 229);
            lblTableRowEndDate.BackColor = Color.FromArgb(229, 229, 229);
            lblTableRowStatus.BackColor = Color.FromArgb(229, 229, 229);
        }
        private void HoverEffect_Leave(object sender, EventArgs e)
        {
            lblTableRowBookingID.BackColor = Color.White;
            lblTableRowItineraryID.BackColor = Color.White;
            lblTableRowCustomer.BackColor = Color.White;
            lblTableRowStartDate.BackColor = Color.White;
            lblTableRowEndDate.BackColor = Color.White;
            lblTableRowStatus.BackColor = Color.White;
        }
        private void Row_Click(object sender, EventArgs e)
        {
            RowClick?.Invoke(lblTableRowBookingID, e);
        }

        private void BookingsTableRow_Load(object sender, EventArgs e)
        {
            lblTableRowBookingID.Text = BookingID.ToString();
            lblTableRowItineraryID.Text = ItineraryID.ToString();
            lblTableRowStartDate.Text = StartDate.ToString("yyyy-MM-dd");
            lblTableRowEndDate.Text = EndDate.ToString("yyyy-MM-dd");
            lblTableRowStatus.Text = Status;
            string query = $"SELECT * FROM Customers WHERE CustomerID={CustomerID}";
            SqlCommand command = new SqlCommand(query, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string firstName = reader["FirstName"].ToString();
                    string lastName = reader["LastName"].ToString();
                    lblTableRowCustomer.Text = firstName + " " + lastName;
                }
                reader.Close();
                connection.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
