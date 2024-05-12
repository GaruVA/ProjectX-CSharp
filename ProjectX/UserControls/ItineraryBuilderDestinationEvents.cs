using ProjectX.Forms;
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

namespace ProjectX.UserControls
{
    public partial class ItineraryBuilderDestinationEvents : UserControl
    {
        public int EventID;
        private int ItineraryID;
        private string name;
        private string description;
        private DateTime startDate;
        private DateTime endDate;
        private decimal price;
        private int currentDay;
        private int DestinationID;
        public ItineraryBuilderDestinationEvents()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\source\repos\ProjectX\ProjectX\Database.mdf;Integrated Security=True");
        public ItineraryBuilderDestinationEvents(int EventID, int DestinationID, int ItineraryID, int currentDay)
        {
            InitializeComponent();
            this.EventID = EventID;
            this.DestinationID = DestinationID;
            this.ItineraryID = ItineraryID;
            this.currentDay = currentDay;
            string query = $"SELECT * FROM Events WHERE EventID={EventID} AND DestinationID={DestinationID}";
            SqlCommand command = new SqlCommand(query, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    this.name = reader["Name"].ToString();
                    this.description = reader["Description"].ToString();
                    this.startDate = (DateTime)reader["StartDate"];
                    this.endDate = (DateTime)reader["EndDate"];
                    this.price = (decimal)reader["PricePerPerson"];
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
        public event EventHandler Add;

        private void ItineraryBuilderDestinationEvents_Load(object sender, EventArgs e)
        {
            lblName.Text = name;
            lblDescription.Text = description;
            lblStartDate.Text = "Start Date: " + startDate.ToString("yyyy-MM-dd");
            lblEndDate.Text = "End Date: " + endDate.ToString("yyyy-MM-dd");
            lblPrice.Text = "Price (Per Person): " + price.ToString();

            string query = $"SELECT Checked FROM ItineraryDestinations WHERE ItineraryID=@ItineraryID AND Day=@Day AND DestinationID=@DestinationID AND EventID=EventID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ItineraryID", ItineraryID);
            command.Parameters.AddWithValue("@Day", currentDay);
            command.Parameters.AddWithValue("@DestinationID", DestinationID);
            command.Parameters.AddWithValue("@EventID", EventID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if (reader["Checked"].ToString() == "True")
                    {
                        chkAdd.Checked = true;
                    }
                    if (reader["Checked"].ToString() == "False")
                    {
                        chkAdd.Checked = false;
                    }
                }
                reader.Close();
            }

            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
            }
        }

        private void chkAdd_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = chkAdd.Checked.ToString();
            label1.Name = DestinationID.ToString() + "," + EventID.ToString();
            Add?.Invoke(label1, e);
        }
    }
}
