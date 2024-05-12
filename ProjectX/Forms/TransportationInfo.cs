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

namespace ProjectX.Forms
{
    public partial class TransportationInfo : Form
    {
        private Main mainForm;
        private int TransportationID;
        private string name;
        private string imageFolder = @"C:\Users\User\source\repos\ProjectX\ProjectX\Images";
        private string imagePath;
        private bool imageChanged = false;
        public TransportationInfo(Main mainForm, int TransportationID)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.TransportationID = TransportationID;
        }
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\source\repos\ProjectX\ProjectX\Database.mdf;Integrated Security=True");

        private void btnBack_Click(object sender, EventArgs e)
        {
            mainForm.ChangeChildForm(new Transportation(mainForm));
        }

        private void TransportationInfo_Load(object sender, EventArgs e)
        {
            string query = $"SELECT * FROM Transportation WHERE TransportationID=@TransportationID;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TransportationID", TransportationID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    txtTransportationID.Text = TransportationID.ToString();
                    name = reader["Name"].ToString();
                    txtName.Texts = name;
                    txtDescription.Texts = reader["Description"].ToString();
                    cmbType.Texts = reader["Type"].ToString();
                    txtCapacity.Texts = reader["Capacity"].ToString();
                    txtPricePerKM.Texts = reader["PricePerKM"].ToString();
                    txtBasePrice.Texts = reader["BasePrice"].ToString();
                }
                reader.Close();
                connection.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            cmbType.Items.Add("Car");
            cmbType.Items.Add("Van");
            cmbType.Items.Add("Bus");
            cmbType.Items.Add("MPV");
            cmbType.Items.Add("4WD");
            cmbType.Items.Add("SUV");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string query = $"DELETE FROM Transportation WHERE TransportationID=@TransportationID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TransportationID", TransportationID);
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show($"Success: Transportation \"{name}\" has been deleted.");
                mainForm.ChangeChildForm(new Transportation(mainForm));
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
            string Type = cmbType.Texts;
            if (string.IsNullOrEmpty(Name) || string.IsNullOrEmpty(Description) || string.IsNullOrEmpty(Type) || string.IsNullOrEmpty(txtCapacity.Texts) || string.IsNullOrEmpty(txtPricePerKM.Texts) || string.IsNullOrEmpty(txtBasePrice.Texts))
            {
                MessageBox.Show("Please fill all input fields.");
                return;
            }
            if (!int.TryParse(txtCapacity.Texts, out int Capacity))
            {
                MessageBox.Show("Invalid Capacity format. Please provide an integer.");
                txtCapacity.Texts = string.Empty;
                return;
            }
            if (!decimal.TryParse(txtPricePerKM.Texts, out decimal PricePerKM))
            {
                MessageBox.Show("Invalid PricePerKM format. Please provide an decimal.");
                txtPricePerKM.Texts = string.Empty;
                return;
            }
            if (!decimal.TryParse(txtBasePrice.Texts, out decimal BasePrice))
            {
                MessageBox.Show("Invalid BasePrice format. Please provide an decimal.");
                txtBasePrice.Texts = string.Empty;
                return;
            }
            if (imageChanged)
            {
                string query = $"UPDATE Transportation SET Name=@Name, Description=@Description, Type=@Type, Capacity=@Capacity, PricePerKM=@PricePerKM, BasePrice=@BasePrice ,Image=@Image WHERE TransportationID=@TransportationID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@Description", Description);
                command.Parameters.AddWithValue("@Type", Type);
                command.Parameters.AddWithValue("@Capacity", Capacity);
                command.Parameters.AddWithValue("@PricePerKM", PricePerKM);
                command.Parameters.AddWithValue("@BasePrice", BasePrice);
                command.Parameters.AddWithValue("@Image", imagePath);
                command.Parameters.AddWithValue("@TransportationID", TransportationID);
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                    File.Copy(txtImage.Text, imagePath, true);
                    MessageBox.Show($"Success: Transportation \"{name}\" has been updated.");
                    mainForm.ChangeChildForm(new Transportation(mainForm));
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                string query = $"UPDATE Transportation SET Name=@Name, Description=@Description, Type=@Type, Capacity=@Capacity, PricePerKM=@PricePerKM, BasePrice=@BasePrice WHERE TransportationID=@TransportationID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@Description", Description);
                command.Parameters.AddWithValue("@Type", Type);
                command.Parameters.AddWithValue("@Capacity", Capacity);
                command.Parameters.AddWithValue("@PricePerKM", PricePerKM);
                command.Parameters.AddWithValue("@BasePrice", BasePrice);
                command.Parameters.AddWithValue("@TransportationID", TransportationID);
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show($"Success: Transportation \"{name}\" has been updated.");
                    mainForm.ChangeChildForm(new Transportation(mainForm));
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
