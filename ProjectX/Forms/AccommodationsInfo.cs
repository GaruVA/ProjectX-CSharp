using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ProjectX.Forms
{
    public partial class AccommodationsInfo : Form
    {
        private Main mainForm;
        private int AccommodationID;
        private string name;
        private string imageFolder = @"C:\Users\User\source\repos\ProjectX\ProjectX\Images";
        private string imagePath;
        private bool imageChanged = false;
        public AccommodationsInfo(Main mainForm, int AccommodationID)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.AccommodationID = AccommodationID;
        }

        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\source\repos\ProjectX\ProjectX\Database.mdf;Integrated Security=True");
        private void btnBack_Click(object sender, EventArgs e)
        {
            mainForm.ChangeChildForm(new Accommodations(mainForm));
        }

        private void AccommodationsInfo_Load(object sender, EventArgs e)
        {
            string query = $"SELECT * FROM Accommodations WHERE AccommodationID=@AccommodationID;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@AccommodationID", AccommodationID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    txtAccommodationID.Text = AccommodationID.ToString();
                    name = reader["Name"].ToString();
                    txtName.Texts = name;
                    txtDescription.Texts = reader["Description"].ToString();
                    txtAddress.Texts = reader["Address"].ToString();
                    cmbCategory.Texts = reader["Category"].ToString();
                }
                reader.Close();
                connection.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            cmbCategory.Items.Add("Hotel");
            cmbCategory.Items.Add("House");
            cmbCategory.Items.Add("Resort");
            query = "SELECT RoomTypeID, Name, Description, Quantity ,Capacity, PricePerNight FROM RoomTypes WHERE AccommodationID = @AccommodationID";
            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@AccommodationID", AccommodationID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                dgvRoomType.Rows.Clear();

                while (reader.Read())
                {
                    int roomTypeID = reader.GetInt32(0);
                    string name = reader.GetString(1);
                    string description = reader.GetString(2);
                    int quantity = reader.GetInt32(3);
                    int capacity = reader.GetInt32(4);
                    decimal pricePerNight = reader.GetDecimal(5);

                    int rowIndex = dgvRoomType.Rows.Add();
                    dgvRoomType.Rows[rowIndex].Cells["RoomTypeID"].Value = roomTypeID;
                    dgvRoomType.Rows[rowIndex].Cells["RoomName"].Value = name;
                    dgvRoomType.Rows[rowIndex].Cells["Description"].Value = description;
                    dgvRoomType.Rows[rowIndex].Cells["Quantity"].Value = quantity;
                    dgvRoomType.Rows[rowIndex].Cells["Capacity"].Value = capacity;
                    dgvRoomType.Rows[rowIndex].Cells["PricePerNight"].Value = pricePerNight;
                }

                reader.Close();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string query = $"DELETE FROM RoomTypes WHERE AccommodationID=@AccommodationID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@AccommodationID", AccommodationID);
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
            query = $"DELETE FROM Accommodations WHERE AccommodationID=@AccommodationID";
            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@AccommodationID", AccommodationID);
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show($"Success: Accommodation \"{name}\" has been deleted.");
                mainForm.ChangeChildForm(new Accommodations(mainForm));
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string Name = txtName.Texts;
            string Description = txtDescription.Texts;
            string Address = txtAddress.Texts;
            string Category = cmbCategory.Texts;
            if (string.IsNullOrEmpty(Name) || string.IsNullOrEmpty(Description) || string.IsNullOrEmpty(Address) || string.IsNullOrEmpty(Category))
            {
                MessageBox.Show("Please fill all input fields.");
                return;
            }
            foreach (DataGridViewRow row in dgvRoomType.Rows)
            {
                if (!row.IsNewRow)
                {
                    if (string.IsNullOrEmpty(row.Cells["RoomName"].Value?.ToString()) || string.IsNullOrEmpty(row.Cells["Description"].Value?.ToString()) || string.IsNullOrEmpty(row.Cells["Quantity"].Value?.ToString()) || string.IsNullOrEmpty(row.Cells["Capacity"].Value?.ToString()) || string.IsNullOrEmpty(row.Cells["PricePerNight"].Value?.ToString()))
                    {
                        MessageBox.Show("Please fill all input fields.");
                        return;
                    }

                    int quantity;
                    if (!int.TryParse(row.Cells["Quantity"].Value?.ToString(), out quantity))
                    {
                        MessageBox.Show("Please enter a valid quantity for the room type.");
                        return;
                    }
                    else if (quantity <= 0)
                    {
                        MessageBox.Show("Quantity must be greater than 0.");
                    }

                    int capacity;
                    if (!int.TryParse(row.Cells["Capacity"].Value?.ToString(), out capacity))
                    {
                        MessageBox.Show("Please enter a valid capacity for the room type.");
                        return;
                    }
                    else if (capacity <= 0)
                    {
                        MessageBox.Show("Capacity must be greater than 0.");
                        return;
                    }

                    decimal price;
                    if (!decimal.TryParse(row.Cells["PricePerNight"].Value?.ToString(), out price))
                    {
                        MessageBox.Show("Please enter a valid price per night for the room type.");
                        return;
                    }
                    else if (price <= 0)
                    {
                        MessageBox.Show("Price per night must be greater than 0.");
                        return;
                    }
                    string query = "UPDATE RoomTypes SET Name = @Name, Description = @Description, Quantity=@Quantity ,Capacity = @Capacity, PricePerNight = @PricePerNight WHERE RoomTypeID = @RoomTypeID AND AccommodationID = @AccommodationID";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@RoomTypeID", int.Parse(row.Cells["RoomTypeID"].Value?.ToString()));
                    command.Parameters.AddWithValue("@Name", row.Cells["RoomName"].Value);
                    command.Parameters.AddWithValue("@Description", row.Cells["Description"].Value);
                    command.Parameters.AddWithValue("@Quantity", quantity);
                    command.Parameters.AddWithValue("@Capacity", capacity);
                    command.Parameters.AddWithValue("@PricePerNight", price);
                    command.Parameters.AddWithValue("@AccommodationID", AccommodationID);
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
                string query = $"UPDATE Accommodations SET Name=@Name, Description=@Description, Address=@Address, Category=@Category, Image=@Image WHERE AccommodationID=@AccommodationID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@Description", Description);
                command.Parameters.AddWithValue("@Address", Address);
                command.Parameters.AddWithValue("@Category", Category);
                command.Parameters.AddWithValue("@Image", imagePath);
                command.Parameters.AddWithValue("@AccommodationID", AccommodationID);
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                    File.Copy(txtImage.Text, imagePath, true);
                    MessageBox.Show($"Success: Accommodation \"{name}\" has been updated.");
                    mainForm.ChangeChildForm(new Accommodations(mainForm));
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                string query = $"UPDATE Accommodations SET Name=@Name, Description=@Description, Address=@Address, Category=@Category WHERE AccommodationID=@AccommodationID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@Description", Description);
                command.Parameters.AddWithValue("@Address", Address);
                command.Parameters.AddWithValue("@Category", Category);
                command.Parameters.AddWithValue("@AccommodationID", AccommodationID);
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show($"Success: Accommodation \"{name}\" has been updated.");
                    mainForm.ChangeChildForm(new Accommodations(mainForm));
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
