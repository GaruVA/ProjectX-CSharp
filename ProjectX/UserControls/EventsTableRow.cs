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
    public partial class EventsTableRow : UserControl
    {
        private int eventID;
        private string name;
        private string startDate;
        private string endDate;
        private decimal pricePerPerson;
        private string image;
        public EventsTableRow()
        {
            InitializeComponent();
        }
        public EventsTableRow(int eventID, string name, string startDate, string endDate, decimal pricePerPerson, string image)
        {
            InitializeComponent();
            this.eventID = eventID;
            this.name = name;
            this.startDate = startDate;
            this.endDate = endDate;
            this.pricePerPerson = pricePerPerson;
            this.image = image;
        }
        public event EventHandler RowClick;

        private void EventsTableRow_Load(object sender, EventArgs e)
        {
            lblTableRowEventID.Text = eventID.ToString();
            lblTableRowName.Text = name;
            lblTableRowStartDate.Text = startDate;
            lblTableRowEndDate.Text = endDate;
            lblTableRowPricePerPerson.Text = pricePerPerson.ToString();
            if (image != null)
            {
                picTableRowImage.Image = Image.FromFile(image);
            }
        }
        private void HoverEffect_Enter(object sender, EventArgs e)
        {
            lblTableRowEventID.BackColor = Color.FromArgb(229, 229, 229);
            lblTableRowName.BackColor = Color.FromArgb(229, 229, 229);
            lblTableRowStartDate.BackColor = Color.FromArgb(229, 229, 229);
            lblTableRowEndDate.BackColor = Color.FromArgb(229, 229, 229);
            lblTableRowPricePerPerson.BackColor = Color.FromArgb(229, 229, 229);
            pnlTableRowImage.BackColor = Color.FromArgb(229, 229, 229);
        }
        private void HoverEffect_Leave(object sender, EventArgs e)
        {
            lblTableRowEventID.BackColor = Color.White;
            lblTableRowName.BackColor = Color.White;
            lblTableRowStartDate.BackColor = Color.White;
            lblTableRowEndDate.BackColor = Color.White;
            lblTableRowPricePerPerson.BackColor = Color.White;
            pnlTableRowImage.BackColor = Color.White;
        }
        private void Row_Click(object sender, EventArgs e)
        {
            RowClick?.Invoke(lblTableRowEventID, e);
        }
    }
}
