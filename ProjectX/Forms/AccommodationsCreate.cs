using System;
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
    public partial class AccommodationsCreate : Form
    {
        private Main mainForm;
        private string imageFolder = @"C:\Users\User\source\repos\ProjectX\ProjectX\Images";
        private string imagePath;
        public AccommodationsCreate(Main mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\source\repos\ProjectX\ProjectX\Database.mdf;Integrated Security=True"); private void AccommodationsCreate_Load(object sender, EventArgs e)
        {
            cmbCategory.Items.Add("Hotel");
            cmbCategory.Items.Add("House");
            cmbCategory.Items.Add("Resort");
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            mainForm.ChangeChildForm(new Accommodations(mainForm));
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
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string Name = txtName.Texts;
            string Description = txtDescription.Texts;
            string Address = txtAddress.Texts;
            string Category = cmbCategory.Texts;
            if (string.IsNullOrEmpty(txtAccommodationID.Texts) || string.IsNullOrEmpty(Name) || string.IsNullOrEmpty(Description) || string.IsNullOrEmpty(Address) || string.IsNullOrEmpty(Category) || string.IsNullOrEmpty(txtImage.Text))
            {
                MessageBox.Show("Please fill all input fields.");
                return;
            }

            if (!int.TryParse(txtAccommodationID.Texts, out int AccommodationID))
            {
                MessageBox.Show("Invalid AccommodationID format. Please provide an integer.");
                txtAccommodationID.Texts = string.Empty;
                return;
            }
            string query = $"SELECT COUNT(*) FROM Accommodations WHERE AccommodationID=@AccommodationID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@AccommodationID", AccommodationID);
            try
            {
                connection.Open();
                int count = (int)command.ExecuteScalar();
                if (count > 0)
                {
                    MessageBox.Show("AccommodationID already exists. Please choose a different ID.");
                    txtAccommodationID.Texts = string.Empty;
                    connection.Close();
                    return;
                }
                connection.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            foreach (DataGridViewRow row in dgvRoomType.Rows)
            {
                if (!row.IsNewRow)
                {
                    if (string.IsNullOrEmpty(row.Cells["RoomTypeID"].Value?.ToString()) || string.IsNullOrEmpty(row.Cells["name"].Value?.ToString()) || string.IsNullOrEmpty(row.Cells["Description"].Value?.ToString()) || string.IsNullOrEmpty(row.Cells["Quantity"].Value?.ToString()) || string.IsNullOrEmpty(row.Cells["Capacity"].Value?.ToString()) || string.IsNullOrEmpty(row.Cells["PricePerNight"].Value?.ToString()))
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

                    int roomTypeID;
                    if (!int.TryParse(row.Cells["RoomTypeID"].Value?.ToString(), out roomTypeID))
                    {
                        MessageBox.Show("Please enter a valid RoomTypeID for the room type.");
                        return;
                    }
                    query = $"SELECT COUNT(*) FROM RoomTypes WHERE RoomTypeID=@RoomTypeID";
                    command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@RoomTypeID", roomTypeID);
                    try
                    {
                        connection.Open();
                        int count = (int)command.ExecuteScalar();
                        if (count > 0)
                        {
                            MessageBox.Show("RoomTypeID already exists. Please choose a different ID.");
                            row.Cells["RoomTypeID"].Value = string.Empty;
                            connection.Close();
                            return;
                        }
                        connection.Close();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    query = "INSERT INTO RoomTypes (RoomTypeID, AccommodationID, Name, Description, Quantity,Capacity, PricePerNight) VALUES (@RoomTypeID, @AccommodationID, @Name, @Description,@Quantity, @Capacity, @PricePerNight)";
                    command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@RoomTypeID", roomTypeID);
                    command.Parameters.AddWithValue("@Name", row.Cells["name"].Value);
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

            query = $"INSERT INTO Accommodations (AccommodationID, Name, Description, Address, Category, Image) VALUES (@AccommodationID,@Name,@Description,@Address,@Category,@Image)";
            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@AccommodationID", AccommodationID);
            command.Parameters.AddWithValue("@Name", Name);
            command.Parameters.AddWithValue("@Description", Description);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@Category", Category);
            command.Parameters.AddWithValue("@Image", imagePath);
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                File.Copy(txtImage.Text, imagePath, true);
                MessageBox.Show($"Success: Accommodation \"{Name}\" has been added.");
                mainForm.ChangeChildForm(new Accommodations(mainForm));
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            

        }

        
    }
}
