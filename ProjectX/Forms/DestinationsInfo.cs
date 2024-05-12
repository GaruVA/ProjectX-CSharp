using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ProjectX.Forms
{
    public partial class DestinationsInfo : Form
    {
        private Main mainForm;
        private int DestinationID;
        private string name;
        private string imageFolder = @"C:\Users\User\source\repos\ProjectX\ProjectX\Images";
        private string imagePath;
        private bool imageChanged = false;
        public DestinationsInfo(Main mainForm, int DestinationID)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.DestinationID = DestinationID;
        }
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\source\repos\ProjectX\ProjectX\Database.mdf;Integrated Security=True");

        private void DestinationsInfo_Load(object sender, EventArgs e)
        {
            string query = $"SELECT * FROM Destinations WHERE DestinationID=@DestinationID;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@DestinationID", DestinationID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    txtDestinationID.Text = DestinationID.ToString();
                    name = reader["Name"].ToString();
                    txtName.Texts = name;
                    txtDescription.Texts = reader["Description"].ToString();
                    txtDistrict.Texts = reader["District"].ToString();
                    txtCity.Texts = reader["City"].ToString();
                }
                reader.Close();
                connection.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            query = "SELECT EventID, Name, Description, StartDate ,EndDate, PricePerPerson FROM Events WHERE DestinationID = @DestinationID";
            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@DestinationID", DestinationID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                dgvEvents.Rows.Clear();

                while (reader.Read())
                {
                    int EventID = reader.GetInt32(0);
                    string name = reader.GetString(1);
                    string description = reader.GetString(2);
                    DateTime StartDate = reader.GetDateTime(3);
                    DateTime EndDate = reader.GetDateTime(4);
                    decimal PricePerPerson = reader.GetDecimal(5);

                    int rowIndex = dgvEvents.Rows.Add();
                    dgvEvents.Rows[rowIndex].Cells["EventID"].Value = EventID;
                    dgvEvents.Rows[rowIndex].Cells["EventName"].Value = name;
                    dgvEvents.Rows[rowIndex].Cells["Description"].Value = description;
                    dgvEvents.Rows[rowIndex].Cells["StartDate"].Value = StartDate.ToString("yyyy-MM-dd");
                    dgvEvents.Rows[rowIndex].Cells["EndDate"].Value = EndDate.ToString("yyyy-MM-dd");
                    dgvEvents.Rows[rowIndex].Cells["PricePerPerson"].Value = PricePerPerson;
                }

                reader.Close();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            mainForm.ChangeChildForm(new Destinations(mainForm));
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string query = $"DELETE FROM Events WHERE DestinationID=@DestinationID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@DestinationID", DestinationID);
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            query = $"DELETE FROM Destinations WHERE DestinationID=@DestinationID";
            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@DestinationID", DestinationID);
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show($"Success: Destination \"{name}\" has been deleted.");
                mainForm.ChangeChildForm(new Destinations(mainForm));
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string name = txtName.Texts;
            string description = txtDescription.Texts;
            string district = txtDistrict.Texts;
            string city = txtCity.Texts;
            

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(description) || string.IsNullOrEmpty(district) || string.IsNullOrEmpty(city))
            {
                MessageBox.Show("Please fill all input fields.");
                return;
            }

            foreach (DataGridViewRow row in dgvEvents.Rows)
            {
                if (!row.IsNewRow)
                {
                    if (string.IsNullOrEmpty(row.Cells["EventID"].Value?.ToString()) || string.IsNullOrEmpty(row.Cells["name"].Value?.ToString()) || string.IsNullOrEmpty(row.Cells["Description"].Value?.ToString()) || string.IsNullOrEmpty(row.Cells["StartDate"].Value?.ToString()) || string.IsNullOrEmpty(row.Cells["EndDate"].Value?.ToString()) || string.IsNullOrEmpty(row.Cells["PricePerPerson"].Value?.ToString()))
                    {
                        MessageBox.Show("Please fill all input fields.");
                        return;
                    }
                    if (!DateTime.TryParseExact(row.Cells["StartDate"].Value?.ToString(), "yyyy-MM-dd", null, System.Globalization.DateTimeStyles.None, out DateTime StartDate))
                    {
                        MessageBox.Show("Invalid start date format. Please enter the date in yyyy-MM-dd format.");
                        return;
                    }
                    if (!DateTime.TryParseExact(row.Cells["EndDate"].Value?.ToString(), "yyyy-MM-dd", null, System.Globalization.DateTimeStyles.None, out DateTime EndDate))
                    {
                        MessageBox.Show("Invalid end date format. Please enter the date in yyyy-MM-dd format.");
                        return;
                    }

                    decimal price;
                    if (!decimal.TryParse(row.Cells["PricePerPerson"].Value?.ToString(), out price))
                    {
                        MessageBox.Show("Please enter a valid price per person for the event.");
                        return;
                    }
                    else if (price <= 0)
                    {
                        MessageBox.Show("Price per person must be greater than 0.");
                        return;
                    }
                    string query = "UPDATE Events SET Name = @Name, Description = @Description, StartDate=@StartDate ,EndDate = @EndDate, PricePerPerson = @PricePerPerson WHERE EventID = @EventID AND DestinationID = @DestinationID";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@EventID", int.Parse(row.Cells["EventID"].Value?.ToString()));
                    command.Parameters.AddWithValue("@Name", row.Cells["RoomName"].Value);
                    command.Parameters.AddWithValue("@Description", row.Cells["Description"].Value);
                    command.Parameters.AddWithValue("@StartDate", StartDate);
                    command.Parameters.AddWithValue("@EndDate", EndDate);
                    command.Parameters.AddWithValue("@PricePerPerson", price);
                    command.Parameters.AddWithValue("@DestinationID", DestinationID);
                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
            }

            if (imageChanged)
            {
                string query = $"UPDATE Destinations SET Name=@Name, Description=@Description, District=@District, City=@City, Image=@Image WHERE DestinationID=@DestinationID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@Description", description);
                command.Parameters.AddWithValue("@District", district);
                command.Parameters.AddWithValue("@City", city);
                command.Parameters.AddWithValue("@Image", imagePath);
                command.Parameters.AddWithValue("@DestinationID", DestinationID);
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                    File.Copy(txtImage.Text, imagePath, true);
                    MessageBox.Show($"Success: Destination \"{name}\" has been updated.");
                    mainForm.ChangeChildForm(new Destinations(mainForm));
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                string query = $"UPDATE Destinations SET Name=@Name, Description=@Description, District=@District, City=@City WHERE DestinationID=@DestinationID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@Description", description);
                command.Parameters.AddWithValue("@District", district);
                command.Parameters.AddWithValue("@City", city);
                command.Parameters.AddWithValue("@DestinationID", DestinationID);
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show($"Success: Destination \"{name}\" has been updated.");
                    mainForm.ChangeChildForm(new Destinations(mainForm));
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files(*.jpg; *.jpeg; *.png;)|*.jpg; *.jpeg; *.png;";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string fileName = ofd.FileName;
                txtImage.Text = fileName;
                imagePath = Path.Combine(imageFolder, Path.GetFileName(fileName));
                imageChanged = true;
            }
        }
    }
}
