using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace ProjectX.Forms
{
    public partial class ItineraryBuilderSelectTransportation : Form
    {
        private Main mainForm;
        private int ItineraryID;
        public ItineraryBuilderSelectTransportation(Main mainForm, int ItineraryID)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.ItineraryID = ItineraryID;
        }

        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\source\repos\ProjectX\ProjectX\Database.mdf;Integrated Security=True");

        private void ItineraryBuilderSelectTransportation_Load(object sender, EventArgs e)
        {
            pnlSelectorContent.Controls.Clear();
            string query = $"SELECT * FROM Transportation";
            SqlCommand command = new SqlCommand(query, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int TransportationID = (int)reader["TransportationID"];
                    string name = reader["Name"].ToString();
                    string Type = reader["Type"].ToString();

                    CreateAndAddTableRow(TransportationID, name, Type);
                }
                reader.Close();
                connection.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            LoadPnlItineraryBuilder();
        }
        private void txtSelector__TextChanged(object sender, EventArgs e)
        {
            string text = txtSelector.Texts;
            pnlSelectorContent.Controls.Clear();
            if (text == "Search by name")
            {
                text = "";
            }
            string query = $"SELECT * FROM Transportation WHERE Name LIKE '%{text}%'";
            SqlCommand command = new SqlCommand(query, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int TransportationID = (int)reader["TransportationID"];
                    string name = reader["Name"].ToString();
                    string Type = reader["Type"].ToString();

                    CreateAndAddTableRow(TransportationID, name, Type);
                }
                reader.Close();
                connection.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CreateAndAddTableRow(int ID, string name, string type)
        {
            UserControls.ItineraryBuilderSelectorRow row = new UserControls.ItineraryBuilderSelectorRow(ID, name, type);
            pnlSelectorContent.Controls.Add(row);
            row.Dock = DockStyle.Top;
            row.BringToFront();
            row.Cursor = Cursors.Hand;
            row.RowClick += Row_Click;
        }

        private void Row_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Label label = sender as System.Windows.Forms.Label;
            int TransportationID = Convert.ToInt32(label.Name);
            string queryNew = "";
            string query = $"SELECT COUNT(*) FROM ItineraryTransportation WHERE ItineraryID=@ItineraryID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ItineraryID", ItineraryID);
            try
            {
                connection.Open();
                int count = (int)command.ExecuteScalar();
                if (count > 0)
                {
                    queryNew = $"UPDATE ItineraryTransportation SET TransportationID=@TransportationID WHERE ItineraryID=@ItineraryID";
                }else
                {
                    queryNew = $"INSERT INTO ItineraryTransportation (ItineraryID, TransportationID) VALUES (@ItineraryID,@TransportationID)";
                }

                connection.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
            }
            
            SqlCommand commandNumVehicles = new SqlCommand(queryNew, connection);
            commandNumVehicles.Parameters.AddWithValue("@ItineraryID", ItineraryID);
            commandNumVehicles.Parameters.AddWithValue("@TransportationID", TransportationID);
            try
            {
                connection.Open();
                commandNumVehicles.ExecuteNonQuery();
                connection.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
            }


            pnlItineraryBuilder.Controls.Clear();
            CreateAndAddItineraryRow(TransportationID);
        }
        private void CreateAndAddItineraryRow(int ID)
        {
            UserControls.ItineraryBuilderTransportation row = new UserControls.ItineraryBuilderTransportation(ID);
            pnlItineraryBuilder.Controls.Add(row);
            row.Dock = DockStyle.Top;
            row.BringToFront();
            row.Delete += Row_Delete;

        }

        private void Row_Delete(object sender, EventArgs e)
        {
            System.Windows.Forms.Label label = sender as System.Windows.Forms.Label;
            int TransportationID = Convert.ToInt32(label.Name);

            string query = $"DELETE ItineraryTransportation WHERE ItineraryID=@ItineraryID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ItineraryID", ItineraryID);
            command.Parameters.AddWithValue("@TransportationID", TransportationID);
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
            }
            LoadPnlItineraryBuilder();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (ValidateRooms())
            {
                mainForm.ChangeChildForm(new ItineraryBuilderSelectAccommodations(mainForm, ItineraryID));
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if(ValidateRooms())
            {
                mainForm.ChangeChildForm(new ItineraryBuilderSummary(mainForm, ItineraryID));
            }
        }
        private void LoadPnlItineraryBuilder()
        {
            pnlItineraryBuilder.Controls.Clear();
            string query = $"SELECT * FROM ItineraryTransportation WHERE ItineraryID=@ItineraryID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ItineraryID", ItineraryID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int ID = (int)reader["TransportationID"];
                    CreateAndAddItineraryRow(ID);
                }
                reader.Close();
                connection.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool ValidateRooms()
        {
            int NumPeople = 0;
            string query = "SELECT * FROM Itinerary WHERE ItineraryID=@ItineraryID;";
            SqlCommand command = new SqlCommand(query, connection);
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
            int TransportationID=0;
            query = "SELECT * FROM ItineraryTransportation WHERE ItineraryID=@ItineraryID;";
            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ItineraryID", ItineraryID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    TransportationID = (int)reader["TransportationID"];
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
            query = $"SELECT * FROM Transportation WHERE TransportationID=@TransportationID";
            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TransportationID", TransportationID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int Capacity = (int)reader["Capacity"];
                    if (Capacity < NumPeople)
                    {
                        MessageBox.Show("Insufficient Transportation: Please select a larger vehicle to accommodate all participants.");
                        connection.Close();
                        return false;
                    }
                }
                reader.Close();
                connection.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return true;
        }
    }
}
