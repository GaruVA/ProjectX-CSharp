using ProjectX.Forms;
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
    public partial class TransportationTableRow : UserControl
    {
        private int transportationID;
        private string name;
        private string type;
        private decimal pricePerKM;
        private decimal basePrice;
        private string image;
        public TransportationTableRow()
        {
            InitializeComponent();
        }
        public TransportationTableRow(int transportationID, string name, string type, decimal pricePerKM, decimal basePrice, string image)
        {
            InitializeComponent();
            this.transportationID = transportationID;
            this.name = name;
            this.type = type;
            this.pricePerKM = pricePerKM;
            this.basePrice = basePrice;
            this.image = image;
        }

        public event EventHandler RowClick;

        private void TransportationTableRow_Load(object sender, EventArgs e)
        {
            lblTableRowTransportationID.Text = transportationID.ToString(); 
            lblTableRowName.Text = name;
            lblTableRowType.Text = type;
            lblTableRowPricePerKM.Text = pricePerKM.ToString();
            lblTableRowBasePrice.Text = basePrice.ToString();
            if (image != null)
            {
                picTableRowImage.Image = Image.FromFile(image);
            }
        }
        private void HoverEffect_Enter(object sender, EventArgs e)
        {
            lblTableRowTransportationID.BackColor = Color.FromArgb(229, 229, 229);
            lblTableRowName.BackColor = Color.FromArgb(229, 229, 229);
            lblTableRowType.BackColor = Color.FromArgb(229, 229, 229);
            lblTableRowPricePerKM.BackColor = Color.FromArgb(229, 229, 229);
            lblTableRowBasePrice.BackColor = Color.FromArgb(229, 229, 229);
            pnlTableRowImage.BackColor = Color.FromArgb(229, 229, 229);
        }
        private void HoverEffect_Leave(object sender, EventArgs e)
        {
            lblTableRowTransportationID.BackColor = Color.White;
            lblTableRowName.BackColor = Color.White;
            lblTableRowType.BackColor = Color.White;
            lblTableRowPricePerKM.BackColor = Color.White;
            lblTableRowBasePrice.BackColor = Color.White;
            pnlTableRowImage.BackColor = Color.White;
        }
        private void Row_Click(object sender, EventArgs e)
        {
            RowClick?.Invoke(lblTableRowTransportationID, e);
        }
    }
}
