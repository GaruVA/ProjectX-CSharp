using System;
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
    public partial class ItineraryBuilderTransportation : UserControl
    {
        public int ID;
        private string name;
        private string description;
        private string type;
        private string capacity;
        private string pricePerKM;
        private string basePrice;
        private string image;
        public ItineraryBuilderTransportation()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\source\repos\ProjectX\ProjectX\Database.mdf;Integrated Security=True");
        public ItineraryBuilderTransportation(int ID)
        {
            InitializeComponent();
            this.ID = ID;
            string query = $"SELECT * FROM Transportation WHERE TransportationID={ID}";
            SqlCommand command = new SqlCommand(query, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    this.name = reader["Name"].ToString();
                    this.type = reader["Type"].ToString();
                    this.description = reader["Description"].ToString();
                    this.capacity = reader["Capacity"].ToString();
                    this.pricePerKM = reader["PricePerKM"].ToString();
                    this.basePrice = reader["BasePrice"].ToString();
                    this.image = reader["Image"].ToString();
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
        public event EventHandler Delete;

        private void ItineraryBuilderTransportation_Load(object sender, EventArgs e)
        {
            lblName.Text = name;
            lblDescription.Text = description;
            lblCapacity.Text += capacity;
            lblType.Text = type;
            lblBasePrice.Text += basePrice;
            lblPricePerKM.Text += pricePerKM;
            if (image != null)
            {
                picImage.Image = Image.FromFile(image);
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            lblName.Name = ID.ToString();
            Delete?.Invoke(lblName, e);
        }
    }
}
