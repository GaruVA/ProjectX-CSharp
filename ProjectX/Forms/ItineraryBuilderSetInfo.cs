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
using System.Xml.Linq;

namespace ProjectX.Forms
{
    public partial class ItineraryBuilderSetInfo : Form
    {
        private Main mainForm;
        private int ItineraryID;
        private bool update;
        private int currentNumDays;
        public ItineraryBuilderSetInfo(Main mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            update = false;
        }
        public ItineraryBuilderSetInfo(Main mainForm,int ItineraryID)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.ItineraryID = ItineraryID;
            update = true;
        }

        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\source\repos\ProjectX\ProjectX\Database.mdf;Integrated Security=True");

        private void btnNext_Click(object sender, EventArgs e)
        {
            string Name = txtName.Texts;
            string description = txtDescription.Texts;

            if (string.IsNullOrEmpty(txtItineraryID.Texts) || string.IsNullOrEmpty(Name) || string.IsNullOrEmpty(description) || string.IsNullOrEmpty(txtNumDays.Texts) || string.IsNullOrEmpty(txtNumPeople.Texts))
            {
                MessageBox.Show("Please fill all input fields.");
                return;
            }
            if (!int.TryParse(txtItineraryID.Texts, out int ItineraryID))
            {
                MessageBox.Show("Invalid ItineraryID format. Please provide an integer.");
                txtItineraryID.Texts = string.Empty;
                return;
            }
            if (!int.TryParse(txtNumDays.Texts, out int NumDays))
            {
                MessageBox.Show("Invalid Number of Days format. Please provide an integer.");
                txtNumDays.Texts = string.Empty;
                return;
            }
            if (!int.TryParse(txtNumPeople.Texts, out int NumPeople))
            {
                MessageBox.Show("Invalid Number of Attendees format. Please provide an integer.");
                txtNumPeople.Texts = string.Empty;
                return;
            }
            if (!update)
            {
                string query = $"SELECT COUNT(*) FROM Itinerary WHERE ItineraryID=@ItineraryID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ItineraryID", ItineraryID);
                try
                {
                    connection.Open();
                    int count = (int)command.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageBox.Show("ItineraryID already exists. Please choose a different ID.");
                        txtItineraryID.Texts = string.Empty;
                        connection.Close();
                        return;
                    }
                    connection.Close();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                query = $"INSERT INTO Itinerary (ItineraryID, Name, Description,NumDays, NumPeople, isTravelPackage) VALUES (@ItineraryID,@Name,@Description,@NumDays, @NumPeople,@isTravelPackage)";
                command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ItineraryID", ItineraryID);
                command.Parameters.AddWithValue("@Name", Name);
                command.Parameters.AddWithValue("@Description", description);
                command.Parameters.AddWithValue("@NumDays", NumDays); 
                command.Parameters.AddWithValue("@NumPeople", NumPeople);
                command.Parameters.AddWithValue("@isTravelPackage", 0);
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                    mainForm.ChangeChildForm(new ItineraryBuilderSelectDestinations(mainForm, ItineraryID));
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                if(currentNumDays != NumDays)
                {
                    for(int i = NumDays; i > currentNumDays; i--)
                    {
                        string deletequery = $"DELETE ItineraryDestinations WHERE ItineraryID=@ItineraryID AND Day=@Day";
                        SqlCommand deletecommand = new SqlCommand(deletequery, connection);
                        deletecommand.Parameters.AddWithValue("@ItineraryID", ItineraryID);
                        deletecommand.Parameters.AddWithValue("@Day", i);
                        try
                        {
                            connection.Open();
                            deletecommand.ExecuteNonQuery();
                            connection.Close();
                        }
                        catch (SqlException ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        deletequery = $"DELETE ItineraryAccommodations WHERE ItineraryID=@ItineraryID AND Day=@Day";
                        deletecommand = new SqlCommand(deletequery, connection);
                        deletecommand.Parameters.AddWithValue("@ItineraryID", ItineraryID);
                        deletecommand.Parameters.AddWithValue("@Day", i-1);
                        try
                        {
                            connection.Open();
                            deletecommand.ExecuteNonQuery();
                            connection.Close();
                        }
                        catch (SqlException ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
                string query = $"UPDATE Itinerary SET Name=@Name, Description=@Description ,NumDays=@NumDays, NumPeople=@NumPeople WHERE ItineraryID=@ItineraryID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ItineraryID", ItineraryID);
                command.Parameters.AddWithValue("@Name", Name);
                command.Parameters.AddWithValue("@Description", description);
                command.Parameters.AddWithValue("@NumDays", NumDays);
                command.Parameters.AddWithValue("@NumPeople", NumPeople);
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                    mainForm.ChangeChildForm(new ItineraryBuilderSelectDestinations(mainForm, ItineraryID));
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            
        }

        private void ItineraryBuilderSetInfo_Load(object sender, EventArgs e)
        {
            if(update)
            {
                string query = "SELECT * FROM Itinerary WHERE ItineraryID=@ItineraryID;";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ItineraryID", ItineraryID);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        txtItineraryID.Texts = ItineraryID.ToString();
                        txtItineraryID.Enabled = false;
                        txtItineraryID.BackColor = Color.WhiteSmoke;
                        txtName.Texts = reader["Name"].ToString();
                        txtDescription.Texts = reader["Description"].ToString();
                        txtNumDays.Texts = reader["NumDays"].ToString();
                        currentNumDays = (int)reader["NumDays"];
                        txtNumPeople.Texts = reader["NumPeople"].ToString();
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
            }
        }
    }
}
