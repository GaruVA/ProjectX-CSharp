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
    public partial class ItineraryBuilderSummary : Form
    {
        private Main mainForm;
        private int ItineraryID;
        public ItineraryBuilderSummary(Main mainForm, int ItineraryID)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.ItineraryID = ItineraryID;
        }
        public ItineraryBuilderSummary()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\source\repos\ProjectX\ProjectX\Database.mdf;Integrated Security=True");

        private void ItineraryBuilderSummary_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Itinerary WHERE ItineraryID=@ItineraryID;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ItineraryID", ItineraryID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    txtItineraryID.Texts = ItineraryID.ToString();
                    txtName.Texts = reader["Name"].ToString();
                    txtDescription.Texts = reader["Description"].ToString();
                    txtNumDays.Texts = reader["NumDays"].ToString();
                    txtNumPeople.Texts = reader["NumPeople"].ToString();
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
            decimal TotalPrice = 0;
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
                        dgvCostSummary.Rows[rowIndex].Cells["Name"].Value = $"{Name} X {txtNumPeople.Texts}";
                        TotalPrice += Convert.ToInt32(txtNumPeople.Texts) * PricePerPerson;
                        dgvCostSummary.Rows[rowIndex].Cells["Price"].Value = Convert.ToInt32(txtNumPeople.Texts) * PricePerPerson;

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
                        TotalPrice += NumberOfRooms[i] * PricePerNight;
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
                        TotalPrice += BasePrice;
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
            txtTotalCost.Texts = TotalPrice.ToString();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            mainForm.ChangeChildForm(new ItineraryBuilderSelectTransportation(mainForm, ItineraryID));
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            decimal TotalCost = Convert.ToDecimal(txtTotalCost.Texts);
            string query = $"UPDATE Itinerary SET TotalCost=@TotalCost WHERE ItineraryID=@ItineraryID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ItineraryID", ItineraryID);
            command.Parameters.AddWithValue("@TotalCost", TotalCost);
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                mainForm.ChangeChildForm(new BookingsCreate(mainForm, ItineraryID));
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string query = $"UPDATE Itinerary SET isTravelPackage=@isTravelPackage WHERE ItineraryID=@ItineraryID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ItineraryID", ItineraryID);
            command.Parameters.AddWithValue("@isTravelPackage", 1);
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Success: Itinerary is saved as a Travel Package");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
