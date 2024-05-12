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
    public partial class Bookings : Form
    {
        private Main mainForm;
        public Bookings(Main mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\source\repos\ProjectX\ProjectX\Database.mdf;Integrated Security=True");
        private void Bookings_Load(object sender, EventArgs e)
        {
            string query = $"SELECT * FROM Bookings";
            SqlCommand command = new SqlCommand(query, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int BookingID = (int)reader["BookingID"];
                    int ItineraryID = (int)reader["ItineraryID"];
                    int CustomerID = (int)reader["CustomerID"];
                    DateTime StartDate = (DateTime)reader["StartDate"];
                    DateTime EndDate = (DateTime)reader["EndDate"];
                    string Status = reader["Status"].ToString();

                    CreateAndAddTableRow(BookingID, ItineraryID, CustomerID, StartDate, EndDate, Status);
                }
                reader.Close();
                connection.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void CreateAndAddTableRow(int BookingID, int ItineraryID, int CustomerID, DateTime StartDate, DateTime EndDate, string Status)
        {
            UserControls.BookingsTableRow row = new UserControls.BookingsTableRow(BookingID, ItineraryID, CustomerID, StartDate, EndDate, Status);
            pnlTableContent.Controls.Add(row);
            row.Dock = DockStyle.Top;
            row.BringToFront();
            row.Cursor = Cursors.Hand;
            row.RowClick += Row_Click;
        }

        private void Row_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Label label = sender as System.Windows.Forms.Label;
            int bookingID = Convert.ToInt32(label.Text);
            mainForm.ChangeChildForm(new BookingsInfo(mainForm, bookingID));
        }
    }
}
