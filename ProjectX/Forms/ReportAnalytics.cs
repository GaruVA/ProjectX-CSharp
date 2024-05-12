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
    public partial class ReportAnalytics : Form
    {
        private Main mainForm;
        public ReportAnalytics(Main mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\source\repos\ProjectX\ProjectX\Database.mdf;Integrated Security=True");


        private void ReportAnalytics_Load(object sender, EventArgs e)
        {
            this.bookingsTableAdapter.Fill(this.databaseDataSet.Bookings);
            string query1 = $"SELECT COUNT (*) FROM Bookings";
            connection.Open();
            SqlCommand command1 = new SqlCommand(query1, connection);
            var count1 = command1.ExecuteScalar();
            bookingNo.Text = count1.ToString();
            connection.Close();

            string query2 = $"SELECT COUNT (*) FROM Customers";
            connection.Open();
            SqlCommand command2 = new SqlCommand(query2, connection);
            var count2 = command2.ExecuteScalar();
            customerNo.Text = count2.ToString();
            connection.Close();

            string query3 = $"SELECT COUNT (*) FROM Itinerary";
            connection.Open();
            SqlCommand command3 = new SqlCommand(query3, connection);
            var count3 = command3.ExecuteScalar();
            itineraryNo.Text = count3.ToString();
            connection.Close();

            string query4 = $"SELECT COUNT (*) FROM ItineraryTransportation";
            connection.Open();
            SqlCommand command4 = new SqlCommand(query4, connection);
            var count4 = command4.ExecuteScalar();
            transportationNo.Text = count4.ToString();
            connection.Close();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            salesChart.Series[0].XValueMember = "BookingID";
            salesChart.Series[0].YValueMembers = "TotalCost";
            salesChart.DataSource = databaseDataSet.Bookings;
            salesChart.DataBind();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            mainForm.ChangeChildForm(new Reports(mainForm));
        }
    }
}
