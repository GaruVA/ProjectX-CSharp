using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectX.Forms
{
    public partial class BookingsCreate : Form
    {
        private Main mainForm;
        private int ItineraryID;
        private int NumDays;
        public BookingsCreate(Main mainForm, int ItineraryID)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.ItineraryID = ItineraryID;
        }
        public BookingsCreate()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\source\repos\ProjectX\ProjectX\Database.mdf;Integrated Security=True");
        private void BookingsCreate_Load(object sender, EventArgs e)
        {
            string query = $"SELECT * FROM Customers";
            SqlCommand command = new SqlCommand(query, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int CustomerID = (int)reader["CustomerID"];
                    string FirstName = reader["FirstName"].ToString();
                    string LastName = reader["LastName"].ToString();
                    cmbCustomer.Items.Add($"{CustomerID} - {FirstName} {LastName}");
                }
                reader.Close();
                connection.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            int NumPeople = 0;
            query = "SELECT * FROM Itinerary WHERE ItineraryID=@ItineraryID;";
            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ItineraryID", ItineraryID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    txtItineraryID.Texts = ItineraryID.ToString();
                    NumDays = (int)reader["NumDays"];
                    txtTotalCost.Texts = reader["TotalCost"].ToString();
                    NumPeople = (int)reader["NumPeople"];
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            var EventIDs = new List<int>();
            var DestinationIDs = new List<int>();
            var AccommodationIDs = new List<int>();
            var RoomTypeIDs = new List<int>();
            var NumberOfRooms = new List<int>();

            query = "SELECT * FROM ItineraryDestinations WHERE ItineraryID=@ItineraryID AND Checked=@Checked;";
            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ItineraryID", ItineraryID);
            command.Parameters.AddWithValue("@Checked", true);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    EventIDs.Add((int)reader["EventID"]);
                    DestinationIDs.Add((int)reader["DestinationID"]);
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            for (int i = 0; i < EventIDs.Count; i++)
            {
                query = "SELECT * FROM Events WHERE EventID=@EventID AND DestinationID=@DestinationID;";
                command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@DestinationID", DestinationIDs[i]);
                command.Parameters.AddWithValue("@EventID", EventIDs[i]);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        string Name = reader["Name"].ToString();
                        decimal PricePerPerson = (decimal)reader["PricePerPerson"];
                        int rowIndex = dgvCostSummary.Rows.Add();
                        dgvCostSummary.Rows[rowIndex].Cells["Name"].Value = $"{Name} X {NumPeople}";
                        dgvCostSummary.Rows[rowIndex].Cells["Price"].Value = Convert.ToInt32(NumPeople) * PricePerPerson;

                    }
                    reader.Close();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
            query = "SELECT * FROM ItineraryAccommodations WHERE ItineraryID=@ItineraryID;";
            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ItineraryID", ItineraryID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    AccommodationIDs.Add((int)reader["AccommodationID"]);
                    RoomTypeIDs.Add((int)reader["RoomTypeID"]);
                    NumberOfRooms.Add((int)reader["NumberOfRooms"]);
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            for (int i = 0; i < AccommodationIDs.Count; i++)
            {
                query = "SELECT * FROM RoomTypes WHERE AccommodationID=@AccommodationID AND RoomTypeID=@RoomTypeID;";
                command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@AccommodationID", AccommodationIDs[i]);
                command.Parameters.AddWithValue("@RoomTypeID", RoomTypeIDs[i]);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        string Name = reader["Name"].ToString();
                        decimal PricePerNight = (decimal)reader["PricePerNight"];
                        int rowIndex = dgvCostSummary.Rows.Add();
                        dgvCostSummary.Rows[rowIndex].Cells["Name"].Value = $"{Name} X {NumberOfRooms[i]}";
                        dgvCostSummary.Rows[rowIndex].Cells["Price"].Value = NumberOfRooms[i] * PricePerNight;

                    }
                    reader.Close();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
            var TransportationIDs = new List<int>();
            query = "SELECT * FROM ItineraryTransportation WHERE ItineraryID=@ItineraryID;";
            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ItineraryID", ItineraryID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    TransportationIDs.Add((int)reader["TransportationID"]);
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            for (int i = 0; i < TransportationIDs.Count; i++)
            {
                query = "SELECT * FROM Transportation WHERE TransportationID=@TransportationID;";
                command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@TransportationID", TransportationIDs[i]);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        string Name = reader["Name"].ToString();
                        decimal BasePrice = (decimal)reader["BasePrice"];
                        int rowIndex = dgvCostSummary.Rows.Add();
                        dgvCostSummary.Rows[rowIndex].Cells["Name"].Value = $"{Name}";
                        dgvCostSummary.Rows[rowIndex].Cells["Price"].Value = BasePrice;

                    }
                    reader.Close();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {

            string Customer = cmbCustomer.Texts;
            decimal TotalCost = Convert.ToDecimal(txtTotalCost.Texts);
            string PaymentMethod = cmbPaymentMethod.Texts;
            string Status = cmbStatus.Texts;
            if (string.IsNullOrEmpty(txtBookingID.Texts) || string.IsNullOrEmpty(Customer) || string.IsNullOrEmpty(txtStartDate.Texts) || string.IsNullOrEmpty(PaymentMethod) || string.IsNullOrEmpty(Status))
            {
                MessageBox.Show("Please fill all input fields.");
                return;
            }
            if (!int.TryParse(txtBookingID.Texts, out int BookingID))
            {
                MessageBox.Show("Invalid BookingID format. Please provide an integer.");
                txtBookingID.Texts = string.Empty;
                return;
            }
            string query = $"SELECT COUNT(*) FROM Bookings WHERE BookingID=@BookingID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@BookingID", BookingID);
            try
            {
                connection.Open();
                int count = (int)command.ExecuteScalar();
                if (count > 0)
                {
                    MessageBox.Show("BookingID already exists. Please choose a different ID.");
                    txtBookingID.Texts = string.Empty;
                    connection.Close();
                    return;
                }
                connection.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            int CustomerID = Convert.ToInt32(Customer.Substring(0, Customer.IndexOf(' ')));

            if (!DateTime.TryParseExact(txtStartDate.Texts, "yyyy-MM-dd", null, System.Globalization.DateTimeStyles.None, out DateTime StartDate))
            {
                MessageBox.Show("Invalid start date format. Please enter the date in yyyy-MM-dd format.");
                txtStartDate.Texts = "yyyy-MM-dd";
                txtEndDate.ForeColor = Color.FromArgb(115, 115, 115);
                return;
            }
            if (!DateTime.TryParseExact(txtEndDate.Texts, "yyyy-MM-dd", null, System.Globalization.DateTimeStyles.None, out DateTime EndDate))
            {
                MessageBox.Show("Invalid end date format. Please enter the date in yyyy-MM-dd format.");
                txtEndDate.Texts = "yyyy-MM-dd";
                txtEndDate.ForeColor = Color.FromArgb(115, 115, 115);
                return;
            }

            query = $"INSERT INTO Bookings (BookingID, ItineraryID, CustomerID , StartDate, EndDate, TotalCost , PaymentMethod, Status, BookingDate) VALUES (@BookingID, @ItineraryID, @CustomerID, @StartDate, @EndDate, @TotalCost, @PaymentMethod, @Status, @BookingDate)";  
            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@BookingID", BookingID);
            command.Parameters.AddWithValue("@ItineraryID", ItineraryID);
            command.Parameters.AddWithValue("@CustomerID ", CustomerID);
            command.Parameters.AddWithValue("@StartDate ", StartDate);
            command.Parameters.AddWithValue("@EndDate ", EndDate);
            command.Parameters.AddWithValue("@TotalCost ", TotalCost);
            command.Parameters.AddWithValue("@PaymentMethod ", PaymentMethod);
            command.Parameters.AddWithValue("@Status", Status);
            command.Parameters.AddWithValue("@BookingDate", DateTime.Now);
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show($"Success: Booking {BookingID} has been added.");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtStartDate__TextChanged(object sender, EventArgs e)
        {
            if (!DateTime.TryParseExact(txtStartDate.Texts, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime startDate))
            {
                txtEndDate.Texts = string.Empty;
                return;
            }
            if (startDate < DateTime.Now)
            {
                txtEndDate.Texts = string.Empty;
                return;
            }
            DateTime endDate = startDate.AddDays(NumDays);
            txtEndDate.Texts = endDate.ToString("yyyy-MM-dd");
        }
    }
}
