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
    public partial class Transportation : Form
    {
        private Main mainForm;
        public Transportation(Main mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\source\repos\ProjectX\ProjectX\Database.mdf;Integrated Security=True");

        private void btnCreate_Click(object sender, EventArgs e)
        {
            mainForm.ChangeChildForm(new TransportationCreate(mainForm));
        }

        private void Transportation_Load(object sender, EventArgs e)
        {
            string query = $"SELECT * FROM Transportation";
            SqlCommand command = new SqlCommand(query, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int TransportationID = (int)reader["TransportationID"];
                    string Name = reader["Name"].ToString();
                    string Type = reader["Type"].ToString();
                    decimal PricePerKM = (decimal)reader["PricePerKM"];
                    decimal BasePrice = (decimal)reader["BasePrice"];
                    string Image = reader["Image"].ToString();

                    CreateAndAddTableRow(TransportationID, Name, Type, PricePerKM, BasePrice, Image);
                }
                reader.Close();
                connection.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void CreateAndAddTableRow(int TransportationID, string Name, string Type, decimal PricePerKM, decimal BasePrice, string image)
        {
            UserControls.TransportationTableRow row = new UserControls.TransportationTableRow(TransportationID, Name, Type, PricePerKM, BasePrice, image);
            pnlTableContent.Controls.Add(row);
            row.Dock = DockStyle.Top;
            row.BringToFront();
            row.Cursor = Cursors.Hand;
            row.RowClick += Row_Click;
        }
        private void Row_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Label label = sender as System.Windows.Forms.Label;
            int TransportationID = Convert.ToInt32(label.Text);
            mainForm.ChangeChildForm(new TransportationInfo(mainForm, TransportationID));
        }
    }
}
