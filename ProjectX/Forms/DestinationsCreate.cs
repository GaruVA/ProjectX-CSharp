using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Net;

namespace ProjectX.Forms
{
    public partial class DestinationsCreate : Form
    {
        private Main mainForm;
        private string imageFolder = @"C:\Users\User\source\repos\ProjectX\ProjectX\Images";
        private string imagePath;
        public DestinationsCreate(Main mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\source\repos\ProjectX\ProjectX\Database.mdf;Integrated Security=True");

        private void btnImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files(*.jpg; *.jpeg; *.png;)|*.jpg; *.jpeg; *.png;";
            if(ofd.ShowDialog() == DialogResult.OK )
            {
                string fileName = ofd.FileName;
                txtImage.Text = fileName;
                imagePath = Path.Combine(imageFolder, Path.GetFileName(fileName));
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            mainForm.ChangeChildForm(new Destinations(mainForm));
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string name = txtName.Texts;
            string description = txtDescription.Texts;
            string district = txtDistrict.Texts;
            string city = txtCity.Texts;

            if (string.IsNullOrEmpty(txtDestinationID.Texts) || string.IsNullOrEmpty(name) || string.IsNullOrEmpty(description) || string.IsNullOrEmpty(district) || string.IsNullOrEmpty(city) || string.IsNullOrEmpty(txtImage.Text))
            {
                MessageBox.Show("Please fill all input fields.");
                return;
            }

            if (!int.TryParse(txtDestinationID.Texts, out int destinationID))
            {
                MessageBox.Show("Invalid DestinationID format. Please provide an integer.");
                txtDestinationID.Texts = string.Empty;
                return;
            }

            string query = $"SELECT COUNT(*) FROM Destinations WHERE DestinationID=@DestinationID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@DestinationID", destinationID);
            try
            {
                connection.Open();
                int count = (int)command.ExecuteScalar();

                if (count > 0)
                {
                    MessageBox.Show("DestinationID already exists. Please choose a different ID.");
                    txtDestinationID.Texts = string.Empty;
                    connection.Close();
                    return;
                }
                connection.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
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

                    int EventID;
                    if (!int.TryParse(row.Cells["EventID"].Value?.ToString(), out EventID))
                    {
                        MessageBox.Show("Please enter a valid EventID for the room type.");
                        return;
                    }
                    query = $"SELECT COUNT(*) FROM Events WHERE EventID=@EventID";
                    command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@EventID", EventID);
                    try
                    {
                        connection.Open();
                        int count = (int)command.ExecuteScalar();
                        if (count > 0 || EventID==0)
                        {
                            MessageBox.Show("EventID already exists. Please choose a different ID.");
                            row.Cells["EventID"].Value = string.Empty;
                            connection.Close();
                            return;
                        }
                        connection.Close();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    query = "INSERT INTO Events (EventID, DestinationID, Name, Description, StartDate, EndDate, PricePerPerson) VALUES (@EventID, @DestinationID, @Name, @Description, @StartDate, @EndDate ,@PricePerPerson)";
                    command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@EventID", EventID);
                    command.Parameters.AddWithValue("@Name", row.Cells["name"].Value);
                    command.Parameters.AddWithValue("@Description", row.Cells["Description"].Value);
                    command.Parameters.AddWithValue("@StartDate", StartDate);
                    command.Parameters.AddWithValue("@EndDate", EndDate);
                    command.Parameters.AddWithValue("@PricePerPerson", price);
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
                    }
                }
            }

            query = $"INSERT INTO Destinations (DestinationID, Name, Description, District, City, Image) VALUES (@DestinationID,@Name,@Description,@District,@City,@Image)";
            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@DestinationID", destinationID);
            command.Parameters.AddWithValue("@Name", name);
            command.Parameters.AddWithValue("@Description", description);
            command.Parameters.AddWithValue("@District", district);
            command.Parameters.AddWithValue("@City", city);
            command.Parameters.AddWithValue("@Image", imagePath);
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                File.Copy(txtImage.Text, imagePath, true);
                MessageBox.Show($"Success: Destination \"{name}\" has been added.");
                mainForm.ChangeChildForm(new Destinations(mainForm));
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
