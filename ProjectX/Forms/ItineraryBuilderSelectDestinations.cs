using ProjectX.UserControls;
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
using System.Windows.Controls;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace ProjectX.Forms
{
    public partial class ItineraryBuilderSelectDestinations : Form
    {
        private Main mainForm;
        private int ItineraryID;
        private int Days = 1;
        private int currentDay = 1;
        private RoundButton btnDay;

        public ItineraryBuilderSelectDestinations(Main mainForm,int ItineraryID)
        {
            InitializeComponent();
            btnDay = btnDayDefault;
            this.mainForm = mainForm;
            this.ItineraryID = ItineraryID;
        }

        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\source\repos\ProjectX\ProjectX\Database.mdf;Integrated Security=True");

        private void ItineraryBuilder_Load(object sender, EventArgs e)
        {
            pnlSelectorContent.Controls.Clear();
            string query = $"SELECT * FROM Destinations";
            SqlCommand command = new SqlCommand(query, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int destinationID = (int)reader["DestinationID"];
                    string name = reader["Name"].ToString();
                    string district = reader["District"].ToString();
                    string city = reader["City"].ToString();
                    string address = city + ", " + district;

                    CreateAndAddTableRow(destinationID, name, address);
                }
                reader.Close();
                connection.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            pnlItineraryBuilder.Controls.Clear();
            HashSet<int> DestinationIDs = new HashSet<int>();
            query = $"SELECT * FROM ItineraryDestinations WHERE ItineraryID=@ItineraryID AND Day=@Day";
            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ItineraryID", ItineraryID);
            command.Parameters.AddWithValue("@Day", currentDay);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    DestinationIDs.Add((int)reader["DestinationID"]);
                }
                reader.Close();
                connection.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            foreach(int DestinationID in DestinationIDs)
            {
                CreateAndAddItineraryRow(DestinationID);
                query = $"SELECT * FROM Events WHERE DestinationID=@DestinationID";
                command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@DestinationID", DestinationID);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {

                        int EventID = (int)reader["EventID"];
                        CreateAndAddItineraryRowEvents(EventID, DestinationID, ItineraryID, currentDay);
                    }
                    reader.Close();
                    connection.Close();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

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
                    for (int i = 0; i < NumDays-1; i++)
                    {
                        RoundButton btn = new RoundButton();
                        Days += 1;
                        btn.Text = "DAY " + Days.ToString();
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


        private void btnDay_Click(object sender, EventArgs e)
        {
            RoundButton btn = sender as RoundButton;
            currentDay = Convert.ToInt32(btn.Text.Substring(btn.Text.LastIndexOf(' ') + 1));
            btn.Enabled = false;
            btn.BackgroundColor = System.Drawing.Color.White;
            btn.Cursor = Cursors.Default;
            if(btnDay != null)
            {
                btnDay.Enabled = true;
                btnDay.BackgroundColor = System.Drawing.Color.FromArgb(238, 238, 238);
                btnDay.Cursor = Cursors.Hand;
            }
            btnDay = btn;
            pnlItineraryBuilder.Controls.Clear();
            HashSet<int> DestinationIDs = new HashSet<int>();
            string query = $"SELECT * FROM ItineraryDestinations WHERE ItineraryID=@ItineraryID AND Day=@Day";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ItineraryID", ItineraryID);
            command.Parameters.AddWithValue("@Day", currentDay);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    DestinationIDs.Add((int)reader["DestinationID"]);
                }
                reader.Close();
                connection.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            foreach (int DestinationID in DestinationIDs)
            {
                CreateAndAddItineraryRow(DestinationID);
                query = $"SELECT * FROM Events WHERE DestinationID=@DestinationID";
                command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@DestinationID", DestinationID);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {

                        int EventID = (int)reader["EventID"];
                        CreateAndAddItineraryRowEvents(EventID, DestinationID, ItineraryID, currentDay);
                    }
                    reader.Close();
                    connection.Close();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
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
            int destinationID = Convert.ToInt32(label.Name);
            string query = $"DELETE ItineraryDestinations WHERE ItineraryID=@ItineraryID AND Day=@Day AND DestinationID=@DestinationID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ItineraryID", ItineraryID);
            command.Parameters.AddWithValue("@Day", currentDay);
            command.Parameters.AddWithValue("@DestinationID", destinationID);
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

            var EventIDs = new List<int>();
            query = "SELECT * FROM Events WHERE DestinationID=@DestinationID;";
            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@DestinationID", destinationID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    EventIDs.Add((int)reader["EventID"]);
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
            if(EventIDs.Count > 0)
            {
                for (int i = 0; i < EventIDs.Count; i++)
                {
                    query = "INSERT INTO ItineraryDestinations (ItineraryID,Day,DestinationID,EventID,Checked) VALUES (@ItineraryID,@Day,@DestinationID,@EventID,@Checked)";
                    command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ItineraryID", ItineraryID);
                    command.Parameters.AddWithValue("@Day", currentDay);
                    command.Parameters.AddWithValue("@DestinationID", destinationID);
                    command.Parameters.AddWithValue("@EventID", EventIDs[i]);
                    command.Parameters.AddWithValue("@Checked", false);
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
            }
            else
            {
                query = "INSERT INTO ItineraryDestinations (ItineraryID,Day,DestinationID,EventID,Checked) VALUES (@ItineraryID,@Day,@DestinationID,@EventID,@Checked)";
                command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ItineraryID", ItineraryID);
                command.Parameters.AddWithValue("@Day", currentDay);
                command.Parameters.AddWithValue("@DestinationID", destinationID);
                command.Parameters.AddWithValue("@EventID", 0);
                command.Parameters.AddWithValue("@Checked", false);
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
            HashSet<int> DestinationIDs = new HashSet<int>();
            query = $"SELECT * FROM ItineraryDestinations WHERE ItineraryID=@ItineraryID AND Day=@Day";
            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ItineraryID", ItineraryID);
            command.Parameters.AddWithValue("@Day", currentDay);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    DestinationIDs.Add((int)reader["DestinationID"]);
                }
                reader.Close();
                connection.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            foreach (int DestinationID in DestinationIDs)
            {
                CreateAndAddItineraryRow(DestinationID);
                query = $"SELECT * FROM Events WHERE DestinationID=@DestinationID";
                command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@DestinationID", DestinationID);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {

                        int EventID = (int)reader["EventID"];
                        CreateAndAddItineraryRowEvents(EventID, DestinationID, ItineraryID, currentDay);
                    }
                    reader.Close();
                    connection.Close();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void CreateAndAddItineraryRow(int ID)
        {
            UserControls.ItineraryBuilderDestinations row = new UserControls.ItineraryBuilderDestinations(ID);
            pnlItineraryBuilder.Controls.Add(row);
            row.Dock = DockStyle.Top;
            row.BringToFront();
            row.Delete += Row_Delete;
        }

        private void CreateAndAddItineraryRowEvents(int EventID,int DestinationID , int ItineraryID, int currentDay)
        {
            UserControls.ItineraryBuilderDestinationEvents row = new UserControls.ItineraryBuilderDestinationEvents(EventID, DestinationID, ItineraryID, currentDay);
            pnlItineraryBuilder.Controls.Add(row);
            row.Dock = DockStyle.Top;
            row.BringToFront();
            row.Add += Row_Add;
        }

        private void Row_Add(object sender, EventArgs e)
        {
            System.Windows.Forms.Label label = sender as System.Windows.Forms.Label;
            string Checked = label.Text;
            int destinationID = Convert.ToInt32(label.Name.Split(',')[0]);
            int eventID = Convert.ToInt32(label.Name.Split(',')[1]);
            string query = $"DELETE ItineraryDestinations WHERE ItineraryID=@ItineraryID AND Day=@Day AND DestinationID=@DestinationID AND EventID=@EventID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ItineraryID", ItineraryID);
            command.Parameters.AddWithValue("@Day", currentDay);
            command.Parameters.AddWithValue("@DestinationID", destinationID);
            command.Parameters.AddWithValue("@EventID", eventID);
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
            query = $"INSERT INTO ItineraryDestinations (ItineraryID, Day, DestinationID,EventID,Checked) VALUES (@ItineraryID,@Day,@DestinationID,@EventID,@Checked)";
            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ItineraryID", ItineraryID);
            command.Parameters.AddWithValue("@Day", currentDay);
            command.Parameters.AddWithValue("@DestinationID", destinationID);
            command.Parameters.AddWithValue("@EventID", eventID);
            command.Parameters.AddWithValue("@Checked", Checked);
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
            System.Windows.Forms.Label label = sender as System.Windows.Forms.Label;
            int destinationID = Convert.ToInt32(label.Name);

            string query = $"DELETE ItineraryDestinations WHERE ItineraryID=@ItineraryID AND Day=@Day AND DestinationID=@DestinationID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ItineraryID", ItineraryID);
            command.Parameters.AddWithValue("@Day", currentDay);
            command.Parameters.AddWithValue("@DestinationID", destinationID);
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
            HashSet<int> DestinationIDs = new HashSet<int>();
            query = $"SELECT * FROM ItineraryDestinations WHERE ItineraryID=@ItineraryID AND Day=@Day";
            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ItineraryID", ItineraryID);
            command.Parameters.AddWithValue("@Day", currentDay);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {

                    DestinationIDs.Add((int)reader["DestinationID"]);
                }
                reader.Close();
                connection.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            foreach (int DestinationID in DestinationIDs)
            {
                CreateAndAddItineraryRow(DestinationID);
                query = $"SELECT * FROM Events WHERE DestinationID=@DestinationID";
                command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@DestinationID", DestinationID);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {

                        int EventID = (int)reader["EventID"];
                        CreateAndAddItineraryRowEvents(EventID, DestinationID, ItineraryID, currentDay);
                    }
                    reader.Close();
                    connection.Close();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            mainForm.ChangeChildForm(new ItineraryBuilderSetInfo(mainForm, ItineraryID));
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            mainForm.ChangeChildForm(new ItineraryBuilderSelectAccommodations(mainForm, ItineraryID));
        }

        private void txtSelector__TextChanged(object sender, EventArgs e)
        {
            string text = txtSelector.Texts;
            pnlSelectorContent.Controls.Clear();
            if (text == "Search by name")
            {
                text = "";
            }
            string query = $"SELECT * FROM Destinations WHERE Name LIKE '%{text}%'";
            SqlCommand command = new SqlCommand(query, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int destinationID = (int)reader["DestinationID"];
                    string name = reader["Name"].ToString();
                    string district = reader["District"].ToString();
                    string city = reader["City"].ToString();
                    string address = city + ", " + district;

                    CreateAndAddTableRow(destinationID, name, address);
                }
                reader.Close();
                connection.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
