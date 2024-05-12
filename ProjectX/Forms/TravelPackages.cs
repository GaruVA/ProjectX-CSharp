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
    public partial class TravelPackages : Form
    {
        private Main mainForm;
        public TravelPackages(Main mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\source\repos\ProjectX\ProjectX\Database.mdf;Integrated Security=True");

        private void TravelPackages_Load(object sender, EventArgs e)
        {
            pnlContent.Controls.Clear();
            string query = $"SELECT * FROM Itinerary WHERE isTravelPackage={1}";
            SqlCommand command = new SqlCommand(query, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int ItineraryID = (int)reader["ItineraryID"];
                    string name = reader["Name"].ToString();
                    string description = reader["Description"].ToString();
                    int numDays = (int)reader["NumDays"];
                    int numPeople = (int)reader["NumPeople"];

                    CreateAndAddTravelPackage(ItineraryID, name, description, numDays, numPeople);
                }
                reader.Close();
                connection.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void CreateAndAddTravelPackage(int ItineraryID, string name, string description, int numDays, int numPeople)
        {
            UserControls.TravelPackage package = new UserControls.TravelPackage(ItineraryID, name, description, numDays, numPeople);
            pnlContent.Controls.Add(package);
            package.Dock = DockStyle.Top;
            package.BringToFront();
            package.Cursor = Cursors.Hand;
            package.BookNowClick += Package_BookNowClick;
            package.EditClick += Package_EditClick;

        }

        private void Package_EditClick(object sender, EventArgs e)
        {
            System.Windows.Forms.Label label = sender as System.Windows.Forms.Label;
            int ItineraryID = Convert.ToInt32(label.Text);
            mainForm.ChangeChildForm(new ItineraryBuilderSetInfo(mainForm, ItineraryID));
        }

        private void Package_BookNowClick(object sender, EventArgs e)
        {
            System.Windows.Forms.Label label = sender as System.Windows.Forms.Label;
            int ItineraryID = Convert.ToInt32(label.Text);
            mainForm.ChangeChildForm(new BookingsCreate(mainForm, ItineraryID));
        }
    }
}
