using ProjectX.Forms;
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
    public partial class TravelPackage : UserControl
    {
        private int ItineraryID;
        private string name;
        private string description;
        private int numDays;
        private int numPeople;
        public TravelPackage()
        {
            InitializeComponent();
            picImage.Controls.Add(picBar);
            picBar.Location = new Point(297, 0);
            picBar.Size = new Size(27, 180);
            picBar.BackColor = Color.Transparent;
        }
        public TravelPackage(int ItineraryID, string name, string description, int numDays, int numPeople)
        {
            InitializeComponent();
            picImage.Controls.Add(picBar);
            picBar.Location = new Point(297, 0);
            picBar.Size = new Size(27, 180);
            picBar.BackColor = Color.Transparent;
            this.ItineraryID = ItineraryID;
            this.name = name;
            this.description = description;
            this.numDays = numDays;
            this.numPeople = numPeople;
        }

        public event EventHandler BookNowClick;
        public event EventHandler EditClick;

        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\source\repos\ProjectX\ProjectX\Database.mdf;Integrated Security=True");

        private void TravelPackage_Load(object sender, EventArgs e)
        {
            lblItineraryID.Text = ItineraryID.ToString();
            lblName.Text = name;
            lblDescription.Text = description;
            lblNumDays.Text = $"Number of Days: {numDays}";
            lblNumPeople.Text = $"Number of Attendees: {numPeople}";

            int destinationID = 0;
            string query = $"SELECT * FROM ItineraryDestinations WHERE ItineraryID=@ItineraryID AND Day=@Day";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ItineraryID", ItineraryID);
            command.Parameters.AddWithValue("@Day", 1);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    destinationID = (int)reader["DestinationID"];
                }
                reader.Close();
                connection.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            query = $"SELECT * FROM Destinations WHERE DestinationID={destinationID}";
            command = new SqlCommand(query, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    string image = reader["Image"].ToString();
                    picImage.Image = Image.FromFile(image);
                }
                reader.Close();
                connection.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBookNow_Click(object sender, EventArgs e)
        {
            BookNowClick?.Invoke(lblItineraryID, e);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditClick?.Invoke(lblItineraryID, e);
        }
    }
}
