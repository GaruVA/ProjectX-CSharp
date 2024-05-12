using ProjectX.Forms;
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

namespace ProjectX.UserControls
{
    public partial class AccommodationsTableRow : UserControl
    {
        private int accommodationID;
        private string name;
        private string address;
        private string category;
        private string image;
        public AccommodationsTableRow()
        {
            InitializeComponent();
        }

        public AccommodationsTableRow(int accommodationID, string name, string address, string category, string image)
        {
            InitializeComponent();
            this.accommodationID = accommodationID;
            this.name = name;
            this.category = category;
            this.image = image;
            this.address = address;
        }
        public event EventHandler RowClick;

        private void AccommodationsTableRow_Load(object sender, EventArgs e)
        {
            lblTableRowAccommodationID.Text = accommodationID.ToString();
            lblTableRowName.Text = name;
            lblTableRowAddress.Text = address;
            lblTableRowCategory.Text = category;
            if (image != null)
            {
                picTableRowImage.Image = Image.FromFile(image);
            }
        }
        private void HoverEffect_Enter(object sender, EventArgs e)
        {
            lblTableRowAccommodationID.BackColor = Color.FromArgb(229, 229, 229);
            lblTableRowName.BackColor = Color.FromArgb(229, 229, 229);
            lblTableRowAddress.BackColor = Color.FromArgb(229, 229, 229);
            lblTableRowCategory.BackColor = Color.FromArgb(229, 229, 229);
            pnlTableRowImage.BackColor = Color.FromArgb(229, 229, 229);
        }
        private void HoverEffect_Leave(object sender, EventArgs e)
        {
            lblTableRowAccommodationID.BackColor = Color.White;
            lblTableRowName.BackColor = Color.White;
            lblTableRowAddress.BackColor = Color.White;
            lblTableRowCategory.BackColor = Color.White;
            pnlTableRowImage.BackColor = Color.White;
        }
        private void Row_Click(object sender, EventArgs e)
        {
            RowClick?.Invoke(lblTableRowAccommodationID, e);
        }
    }
}
