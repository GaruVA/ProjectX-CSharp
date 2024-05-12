using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectX.UserControls
{
    public partial class ItineraryBuilderAccommodationRooms : UserControl
    {
        public int RoomTypeID;
        private int ItineraryID;
        private string name;
        private string description;
        private int capacity;
        private decimal price;
        public int NumberOfRooms;
        private int Quantity;
        private int currentDay;
        private int currentAccommodation;

        public ItineraryBuilderAccommodationRooms()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\source\repos\ProjectX\ProjectX\Database.mdf;Integrated Security=True");

        public ItineraryBuilderAccommodationRooms(int RoomTypeID, int ItineraryID, int currentDay)
        {
            InitializeComponent();
            this.RoomTypeID = RoomTypeID;
            this.ItineraryID = ItineraryID;
            this.currentDay = currentDay;
            string query = $"SELECT * FROM RoomTypes WHERE RoomTypeID={RoomTypeID}";
            SqlCommand command = new SqlCommand(query, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    this.currentAccommodation = (int)reader["AccommodationID"];
                    this.name = reader["Name"].ToString();
                    this.description = reader["Description"].ToString();
                    this.capacity = (int)reader["Capacity"];
                    this.price = (decimal)reader["PricePerNight"];
                }
                reader.Close();
                connection.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
            }
        }

        public event EventHandler SelectedAmount;
        private void ItineraryBuilderAccommodationRooms_Load(object sender, EventArgs e)
        {
            lblName.Text = name;
            lblDescription.Text = description;
            lblCapacity.Text = "Max. Number of Guest: " + capacity.ToString();
            lblPrice.Text = "Price (Per Night): " + price.ToString();
            string query = "SELECT * FROM RoomTypes WHERE RoomTypeID=@RoomTypeID;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@RoomTypeID", RoomTypeID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    this.Quantity = (int)reader["Quantity"];
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
            for(int i = 0;i< Quantity + 1; i++)
            {
                cmbSelectAmount.Items.Add(i.ToString());
            }
            cmbSelectAmount.SelectedIndex = 0;
            query = $"SELECT NumberOfRooms FROM ItineraryAccommodations WHERE ItineraryID=@ItineraryID AND Day=@Day AND AccommodationID=@AccommodationID AND RoomtypeID=@RoomtypeID";
            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ItineraryID", ItineraryID);
            command.Parameters.AddWithValue("@Day", currentDay);
            command.Parameters.AddWithValue("@AccommodationID", currentAccommodation);
            command.Parameters.AddWithValue("@RoomtypeID", RoomTypeID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                   cmbSelectAmount.SelectedIndex = (int)reader["NumberOfRooms"];
                }
                reader.Close();
            }

            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
            }
        }

        private void cmbSelectAmount_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text = cmbSelectAmount.SelectedItem.ToString();
            label1.Name = RoomTypeID.ToString();
            SelectedAmount?.Invoke(label1, e);
        }
    }
}
