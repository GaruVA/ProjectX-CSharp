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

namespace ProjectX.Forms
{
    public partial class Destinations : Form
    {
        private Main mainForm;
        public Destinations(Main mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\source\repos\ProjectX\ProjectX\Database.mdf;Integrated Security=True");

        private void btnCreate_Click(object sender, EventArgs e)
        {
            mainForm.ChangeChildForm(new DestinationsCreate(mainForm));
        }

        private void Destinations_Load(object sender, EventArgs e)
        {
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
                    string image = reader["Image"].ToString();

                    CreateAndAddTableRow(destinationID, name, district, city, image);
                }
                reader.Close();
                connection.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CreateAndAddTableRow(int destinationID, string name, string district, string city, string image)
        {
            UserControls.DestinationsTableRow row = new UserControls.DestinationsTableRow(destinationID, name, district, city, image);
            pnlTableContent.Controls.Add(row);
            row.Dock = DockStyle.Top;
            row.BringToFront();
            row.Cursor = Cursors.Hand;
            row.RowClick += Row_Click;
        }

        private void Row_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Label label = sender as System.Windows.Forms.Label;
            int destinationID = Convert.ToInt32(label.Text);
            mainForm.ChangeChildForm(new DestinationsInfo(mainForm, destinationID));
        }
    }
}
