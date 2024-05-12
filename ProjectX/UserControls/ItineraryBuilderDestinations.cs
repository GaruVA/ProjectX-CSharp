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
    public partial class ItineraryBuilderDestinations : UserControl
    {
        public int ID;
        private string name;
        private string description;
        private string address;
        private string image;
        public ItineraryBuilderDestinations()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\source\repos\ProjectX\ProjectX\Database.mdf;Integrated Security=True");

        public ItineraryBuilderDestinations(int ID)
        {
            InitializeComponent();
            this.ID = ID;
            string query = $"SELECT * FROM Destinations WHERE DestinationID={ID}";
            SqlCommand command = new SqlCommand(query, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    this.name = reader["Name"].ToString();
                    string district = reader["District"].ToString();
                    string city = reader["City"].ToString();
                    this.address = city + ", " + district;
                    this.description = reader["Description"].ToString();
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

        public event EventHandler RowClick;
        public event EventHandler Delete;
        private void Row_Click(object sender, EventArgs e)
        {
            RowClick?.Invoke(ID, e);
        }

        private void ItineraryBuilderDestinations_Load(object sender, EventArgs e)
        {
            lblName.Text = name;
            lblDescription.Text = description;
            lblAdress.Text = address;
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
