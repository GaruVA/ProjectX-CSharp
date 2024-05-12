using System;
using System.Data.SqlClient;
using System.Net;
using System.Windows.Forms;

namespace ProjectX.Forms
{
    public partial class Accommodations : Form
    {
        private Main mainForm;
        public Accommodations(Main mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\source\repos\ProjectX\ProjectX\Database.mdf;Integrated Security=True");

        private void btnCreate_Click(object sender, EventArgs e)
        {
            mainForm.ChangeChildForm(new AccommodationsCreate(mainForm));
        }

        private void Accommodations_Load(object sender, EventArgs e)
        {
            string query = $"SELECT * FROM Accommodations";
            SqlCommand command = new SqlCommand(query, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int AccommodationID = (int)reader["AccommodationID"];
                    string Name = reader["Name"].ToString();
                    string Address = reader["Address"].ToString();
                    string Category = reader["Category"].ToString();
                    string Image = reader["Image"].ToString();

                    CreateAndAddTableRow(AccommodationID, Name, Address, Category, Image);
                }
                reader.Close();
                connection.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void CreateAndAddTableRow(int AccommodationID, string Name, string Address, string Category, string image)
        {
            UserControls.AccommodationsTableRow row = new UserControls.AccommodationsTableRow(AccommodationID, Name, Address, Category, image);
            pnlTableContent.Controls.Add(row);
            row.Dock = DockStyle.Top;
            row.BringToFront();
            row.Cursor = Cursors.Hand;
            row.RowClick += Row_Click;
        }
        private void Row_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Label label = sender as System.Windows.Forms.Label;
            int AccommodationID = Convert.ToInt32(label.Text);
            mainForm.ChangeChildForm(new AccommodationsInfo(mainForm, AccommodationID));
        }
    }
}
