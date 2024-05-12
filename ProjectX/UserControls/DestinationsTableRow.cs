using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectX.UserControls
{
    public partial class DestinationsTableRow : UserControl
    {
        private int destinationID;
        private string name;
        private string district;
        private string city;
        private string image;
        public DestinationsTableRow()
        {
            InitializeComponent();
        }
        public DestinationsTableRow(int destinationID, string name, string district, string city, string image)
        {
            InitializeComponent();
            this.destinationID = destinationID;
            this.name = name;
            this.district = district;
            this.city = city;
            this.image = image;
        }

        public event EventHandler RowClick;

        private void DestinationsTableRow_Load(object sender, EventArgs e)
        {
            lblTableRowDestinationID.Text = destinationID.ToString();
            lblTableRowName.Text = name;
            lblTableRowDistrict.Text = district;
            lblTableRowCity.Text = city;
            if(image != null)
            {
                picTableRowImage.Image = Image.FromFile(image);
            }
        }
        private void HoverEffect_Enter(object sender, EventArgs e)
        {
            lblTableRowDestinationID.BackColor = Color.FromArgb(229, 229, 229);
            lblTableRowName.BackColor = Color.FromArgb(229, 229, 229);
            lblTableRowDistrict.BackColor = Color.FromArgb(229, 229, 229);
            lblTableRowCity.BackColor = Color.FromArgb(229, 229, 229);
            pnlTableRowImage.BackColor = Color.FromArgb(229, 229, 229);
        }
        private void HoverEffect_Leave(object sender, EventArgs e)
        {
            lblTableRowDestinationID.BackColor = Color.White;
            lblTableRowName.BackColor = Color.White;
            lblTableRowDistrict.BackColor = Color.White;
            lblTableRowCity.BackColor = Color.White;
            pnlTableRowImage.BackColor = Color.White;
        }
        private void Row_Click(object sender, EventArgs e)
        {
            RowClick?.Invoke(lblTableRowDestinationID, e);
        }
    }
}
