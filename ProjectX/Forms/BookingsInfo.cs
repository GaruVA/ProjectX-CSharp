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
using System.Windows.Input;

namespace ProjectX.Forms
{
    public partial class BookingsInfo : Form
    {
        private Main mainForm;
        private int BookingID;
        private int ItineraryID;
        public BookingsInfo(Main mainForm, int BookingID)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.BookingID = BookingID;
        }
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\source\repos\ProjectX\ProjectX\Database.mdf;Integrated Security=True");

        private void BookingsInfo_Load(object sender, EventArgs e)
        {
            int CustomerID = 0;
            string query = $"SELECT * FROM Bookings WHERE BookingID={BookingID}";
            SqlCommand command = new SqlCommand(query, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    ItineraryID = (int)reader["ItineraryID"];
                    CustomerID = (int)reader["CustomerID"];
                    string TotalCost = reader["TotalCost"].ToString();
                    string PaymentMethod = reader["PaymentMethod"].ToString();
                    string Status = reader["Status"].ToString();
                    txtBookingID.Texts = BookingID.ToString();
                    txtItineraryID.Texts = ItineraryID.ToString();
                    txtTotalCost.Texts = TotalCost;
                    txtStartDate.Texts = ((DateTime)reader["StartDate"]).ToString("yyyy-MM-dd");
                    txtEndDate.Texts = ((DateTime)reader["EndDate"]).ToString("yyyy-MM-dd");
                    cmbPaymentMethod.Texts = PaymentMethod;
                    cmbStatus.Texts = Status;
                }
                reader.Close();
                connection.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            query = $"SELECT * FROM Customers WHERE CustomerID={CustomerID}";
            command = new SqlCommand(query, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string FirstName = reader["FirstName"].ToString();
                    string LastName = reader["LastName"].ToString();
                    cmbCustomer.Texts = $"{CustomerID} - {FirstName} {LastName}";
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            mainForm.ChangeChildForm(new Bookings(mainForm));
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string Status = cmbStatus.Texts;
            if (string.IsNullOrEmpty(Status))
            {
                MessageBox.Show("Please fill all input fields.");
                return;
            }
            string query = $"UPDATE Bookings SET Status=@Status WHERE BookingID=@BookingID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@BookingID", BookingID);
            command.Parameters.AddWithValue("@Status", Status);
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show($"Success: Booking {BookingID} has been updated.");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
