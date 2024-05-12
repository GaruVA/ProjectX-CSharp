using ProjectX.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectX.UserControls
{
    public partial class ItineraryBuilderSelectorRow : UserControl
    {
        public int ID;
        private string name;
        private string address;
        public ItineraryBuilderSelectorRow()
        {
            InitializeComponent();
        }
        public ItineraryBuilderSelectorRow(int ID, string name, string address)
        {
            InitializeComponent();
            this.ID = ID;
            this.name = name;
            this.address = address;
        }

        public event EventHandler RowClick;

        private void ItineraryBuilderLibrary_Load(object sender, EventArgs e)
        {
            lblName.Text = name;
            lblName.Name = ID.ToString();
            lblAddress.Text = address;
        }
        private void HoverEffect_Enter(object sender, EventArgs e)
        {
            lblName.BackColor = Color.FromArgb(229, 229, 229);
            lblAddress.BackColor = Color.FromArgb(229, 229, 229);
            this.BackColor = Color.FromArgb(229, 229, 229);
        }
        private void HoverEffect_Leave(object sender, EventArgs e)
        {
            lblName.BackColor = Color.White;
            lblAddress.BackColor = Color.White;
            this.BackColor = Color.White;
        }
        private void Row_Click(object sender, EventArgs e)
        {
            RowClick?.Invoke(lblName, e);
        }

    }
}
