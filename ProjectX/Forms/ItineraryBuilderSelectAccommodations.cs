using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace ProjectX.Forms
{
    public partial class ItineraryBuilderSelectAccommodations : Form
    {
        private Main mainForm;
        private int ItineraryID;
        private int Days = 1;
        private int currentDay = 1;
        private RoundButton btnDay;
        private int currentAccommodation;
        private bool dayChanged = false;
        public ItineraryBuilderSelectAccommodations()
        {
            InitializeComponent();
            btnDay = btnDayDefault;
        }
        public ItineraryBuilderSelectAccommodations(Main mainForm, int ItineraryID)
        {
            InitializeComponent();
            btnDay = btnDayDefault;
            this.mainForm = mainForm;
            this.ItineraryID = ItineraryID;
        }

        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\source\repos\ProjectX\ProjectX\Database.mdf;Integrated Security=True");

        private void btnDay_Click(object sender, EventArgs e)
        {
            RoundButton btn = sender as RoundButton;
            currentDay = Convert.ToInt32(btn.Text.Substring(btn.Text.LastIndexOf(' ') + 1));
            btn.Enabled = false;
            btn.BackgroundColor = System.Drawing.Color.White;
            btn.Cursor = Cursors.Default;
            if (btnDay != null)
            {
                btnDay.Enabled = true;
                btnDay.BackgroundColor = System.Drawing.Color.FromArgb(238, 238, 238);
                btnDay.Cursor = Cursors.Hand;
            }
            btnDay = btn;
            LoadPnlItineraryBuilder();
        }

        private void CreateAndAddTableRow(int ID, string name, string address)
        {
            UserControls.ItineraryBuilderSelectorRow row = new UserControls.ItineraryBuilderSelectorRow(ID, name, address);
            pnlSelectorContent.Controls.Add(row);
            row.Dock = DockStyle.Top;
            row.BringToFront();
            row.Cursor = Cursors.Hand;
            row.RowClick += Row_Click;
        }

        private void Row_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Label label = sender as System.Windows.Forms.Label;
            int accommodationID = Convert.ToInt32(label.Name);
            currentAccommodation = accommodationID;
            string query = $"DELETE ItineraryAccommodations WHERE ItineraryID=@ItineraryID AND Day=@Day";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ItineraryID", ItineraryID);
            command.Parameters.AddWithValue("@Day", currentDay);
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { connection.Close(); }
            var RoomTypeIDs = new List<int>();
            query = "SELECT * FROM RoomTypes WHERE AccommodationID=@AccommodationID;";
            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@AccommodationID", accommodationID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    RoomTypeIDs.Add((int)reader["RoomTypeID"]);
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
            for (int i = 0; i < RoomTypeIDs.Count; i++)
            {
                query = "INSERT INTO ItineraryAccommodations (ItineraryID,Day,AccommodationID,RoomTypeID,NumberOfRooms) VALUES (@ItineraryID,@Day,@AccommodationID,@RoomTypeID,@NumberOfRooms)";
                command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ItineraryID", ItineraryID);
                command.Parameters.AddWithValue("@Day", currentDay);
                command.Parameters.AddWithValue("@AccommodationID", accommodationID);
                command.Parameters.AddWithValue("@RoomTypeID", RoomTypeIDs[i]);
                command.Parameters.AddWithValue("@NumberOfRooms", 0);
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
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
            pnlItineraryBuilder.Controls.Clear();
            
            CreateAndAddItineraryRow(accommodationID);
            query = $"SELECT * FROM RoomTypes WHERE AccommodationID=@AccommodationID";
            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@AccommodationID", accommodationID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int ID = (int)reader["RoomTypeID"];
                    CreateAndAddItineraryRowRooms(ID, ItineraryID, currentDay);
                }
                reader.Close();
                connection.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void CreateAndAddItineraryRow(int ID)
        {
            UserControls.ItineraryBuilderAccommodations row = new UserControls.ItineraryBuilderAccommodations(ID);
            pnlItineraryBuilder.Controls.Add(row);
            row.Dock = DockStyle.Top;
            row.BringToFront();
            row.Delete += Row_Delete;

        }

        private void CreateAndAddItineraryRowRooms(int ID ,int ItineraryID,int currentDay)
        {
            UserControls.ItineraryBuilderAccommodationRooms row = new UserControls.ItineraryBuilderAccommodationRooms(ID, ItineraryID, currentDay);
            pnlItineraryBuilder.Controls.Add(row);
            row.Dock = DockStyle.Top;
            row.BringToFront();
            row.SelectedAmount += Row_SelectedAmount;

        }

        private void Row_SelectedAmount(object sender, EventArgs e)
        {
            System.Windows.Forms.Label label = sender as System.Windows.Forms.Label;
            int Amount = Convert.ToInt32(label.Text);
            int RoomtypeID = Convert.ToInt32(label.Name);
            string query = $"DELETE ItineraryAccommodations WHERE ItineraryID=@ItineraryID AND Day=@Day AND AccommodationID=@AccommodationID AND RoomTypeID=@RoomTypeID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ItineraryID", ItineraryID);
            command.Parameters.AddWithValue("@Day", currentDay);
            command.Parameters.AddWithValue("@AccommodationID", currentAccommodation);
            command.Parameters.AddWithValue("@RoomtypeID", RoomtypeID);
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
            query = $"INSERT INTO ItineraryAccommodations (ItineraryID, Day, AccommodationID,RoomtypeID,NumberOfRooms) VALUES (@ItineraryID,@Day,@AccommodationID,@RoomtypeID,@NumberOfRooms)";
            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ItineraryID", ItineraryID);
            command.Parameters.AddWithValue("@Day", currentDay);
            command.Parameters.AddWithValue("@AccommodationID", currentAccommodation);
            command.Parameters.AddWithValue("@RoomtypeID", RoomtypeID);
            command.Parameters.AddWithValue("@NumberOfRooms", Amount);
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
        }

        private void Row_Delete(object sender, EventArgs e)
        {
            string query = $"DELETE ItineraryAccommodations WHERE ItineraryID=@ItineraryID AND Day=@Day AND AccommodationID=@AccommodationID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ItineraryID", ItineraryID);
            command.Parameters.AddWithValue("@Day", currentDay);
            command.Parameters.AddWithValue("@AccommodationID", currentAccommodation);
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
            pnlItineraryBuilder.Controls.Clear();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if(ValidateRooms())
            {
                mainForm.ChangeChildForm(new ItineraryBuilderSelectDestinations(mainForm, ItineraryID));
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (ValidateRooms())
            {
                mainForm.ChangeChildForm(new ItineraryBuilderSelectTransportation(mainForm, ItineraryID));
            }
        }

        private void txtSelector__TextChanged(object sender, EventArgs e)
        {
            string text = txtSelector.Texts;
            pnlSelectorContent.Controls.Clear();
            if (text == "Search by name")
            {
                text = "";
            }
            string query = $"SELECT * FROM Accommodations WHERE Name LIKE '%{text}%'";
            SqlCommand command = new SqlCommand(query, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int AccommodationID = (int)reader["AccommodationID"];
                    string name = reader["Name"].ToString();
                    string address = reader["Address"].ToString();

                    CreateAndAddTableRow(AccommodationID, name, address);
                }
                reader.Close();
                connection.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ItineraryBuilderSelectAccommodations_Load(object sender, EventArgs e)
        {
            pnlSelectorContent.Controls.Clear();
            string query = $"SELECT * FROM Accommodations";
            SqlCommand command = new SqlCommand(query, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int AccommodationID = (int)reader["AccommodationID"];
                    string name = reader["Name"].ToString();
                    string address = reader["Address"].ToString();

                    CreateAndAddTableRow(AccommodationID, name, address);
                }
                reader.Close();
                connection.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            LoadPnlItineraryBuilder();
            query = $"SELECT * FROM Itinerary WHERE ItineraryID=@ItineraryID";
            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ItineraryID", ItineraryID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {

                    int NumDays = (int)reader["NumDays"];
                    for (int i = 0; i < NumDays - 2; i++)
                    {
                        RoundButton btn = new RoundButton();
                        Days += 1;
                        btn.Text = "NIGHT " + Days.ToString();
                        btn.BackgroundColor = System.Drawing.Color.FromArgb(238, 238, 238);
                        btn.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        btn.Size = new System.Drawing.Size(100, 40);
                        btn.TextColor = System.Drawing.Color.Black;
                        btn.Cursor = Cursors.Hand;
                        pnlDay.Controls.Add(btn);
                        btn.Dock = DockStyle.Top;
                        btn.BringToFront();
                        btn.Click += btnDay_Click;
                    }
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
            
            HashSet<int> DayList = new HashSet<int>();
            query = "SELECT * FROM ItineraryAccommodations WHERE ItineraryID=@ItineraryID;";
            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ItineraryID", ItineraryID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    DayList.Add((int)reader["Day"]);
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
            foreach (int Day in DayList)
            {
                var RoomTypeIDs = new List<int>();
                var NumberOfRooms = new List<int>();
                query = "SELECT * FROM ItineraryAccommodations WHERE ItineraryID=@ItineraryID AND Day=@Day;";
                command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ItineraryID", ItineraryID);
                command.Parameters.AddWithValue("@Day", Day);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
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
                int totalCapacity = 0;
                for (int i = 0;i < RoomTypeIDs.Count;i++)
                {
                    query = $"SELECT * FROM RoomTypes WHERE RoomTypeID=@RoomTypeID";
                    command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@RoomTypeID", RoomTypeIDs[i]);
                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            int Capacity = (int)reader["Capacity"];
                            totalCapacity += Capacity * NumberOfRooms[i];
                        }
                        reader.Close();
                        connection.Close();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                if(totalCapacity < NumPeople)
                {
                    MessageBox.Show("Insufficient Rooms: Please select more rooms to accommodate all participants.");

                    return false;
                }
            }
            return true;
        }

        private void LoadPnlItineraryBuilder()
        {
            pnlItineraryBuilder.Controls.Clear();
            string query = $"SELECT * FROM ItineraryAccommodations WHERE ItineraryID=@ItineraryID AND Day=@Day";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ItineraryID", ItineraryID);
            command.Parameters.AddWithValue("@Day", currentDay);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    int ID = (int)reader["AccommodationID"];
                    dayChanged = true;
                    currentAccommodation = ID;
                    CreateAndAddItineraryRow(ID);
                }
                reader.Close();
                connection.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (dayChanged)
            {
                query = $"SELECT * FROM RoomTypes WHERE AccommodationID=@AccommodationID";
                command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@AccommodationID", currentAccommodation);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        int ID = (int)reader["RoomTypeID"];
                        CreateAndAddItineraryRowRooms(ID, ItineraryID, currentDay);
                    }
                    reader.Close();
                    connection.Close();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            dayChanged = false;
        }
    }
}
