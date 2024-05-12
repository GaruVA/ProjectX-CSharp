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
    public partial class TransportationCreate : Form
    {
        private Main mainForm;
        private string imageFolder = @"C:\Users\User\source\repos\ProjectX\ProjectX\Images";
        private string imagePath;
        public TransportationCreate(Main mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\source\repos\ProjectX\ProjectX\Database.mdf;Integrated Security=True");

        private void TransportationCreate_Load(object sender, EventArgs e)
        {
            cmbType.Items.Add("Car");
            cmbType.Items.Add("Van");
            cmbType.Items.Add("Bus");
            cmbType.Items.Add("MPV");
            cmbType.Items.Add("4WD");
            cmbType.Items.Add("SUV");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            mainForm.ChangeChildForm(new Transportation(mainForm));
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
            string Type = cmbType.Texts;
            if (string.IsNullOrEmpty(txtTransportationID.Texts) || string.IsNullOrEmpty(Name) || string.IsNullOrEmpty(Description) || string.IsNullOrEmpty(Type) || string.IsNullOrEmpty(txtCapacity.Texts) || string.IsNullOrEmpty(txtPricePerKM.Texts) || string.IsNullOrEmpty(txtBasePrice.Texts) || string.IsNullOrEmpty(txtImage.Text))
            {
                MessageBox.Show("Please fill all input fields.");
                return;
            }
            if (!int.TryParse(txtTransportationID.Texts, out int TransportationID))
            {
                MessageBox.Show("Invalid TransportationID format. Please provide an integer.");
                txtTransportationID.Texts = string.Empty;
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
            string query = $"SELECT COUNT(*) FROM Transportation WHERE TransportationID=@TransportationID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TransportationID", TransportationID);
            try
            {
                connection.Open();
                int count = (int)command.ExecuteScalar();
                if (count > 0)
                {
                    MessageBox.Show("TransportationID already exists. Please choose a different ID.");
                    txtTransportationID.Texts = string.Empty;
                    connection.Close();
                    return;
                }
                connection.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            query = $"INSERT INTO Transportation (TransportationID, Name, Description, Type, Capacity, PricePerKM, BasePrice, Image) VALUES (@TransportationID,@Name,@Description,@Type,@Capacity,@PricePerKM,@BasePrice,@Image)";
            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TransportationID", TransportationID);
            command.Parameters.AddWithValue("@Name", Name);
            command.Parameters.AddWithValue("@Description", Description);
            command.Parameters.AddWithValue("@Type", Type);
            command.Parameters.AddWithValue("@Capacity", Capacity);
            command.Parameters.AddWithValue("@PricePerKM", PricePerKM);
            command.Parameters.AddWithValue("@BasePrice", BasePrice);
            command.Parameters.AddWithValue("@Image", imagePath);
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                File.Copy(txtImage.Text, imagePath, true);
                MessageBox.Show($"Success: Transportation \"{Name}\" has been added.");
                mainForm.ChangeChildForm(new Transportation(mainForm));
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
