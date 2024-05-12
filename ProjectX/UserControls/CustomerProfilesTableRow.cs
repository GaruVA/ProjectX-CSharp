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
    public partial class CustomerProfilesTableRow : UserControl
    {
        private int customerID;
        private string firstName;
        private string lastName;
        private string email;
        private string phone;

        public CustomerProfilesTableRow()
        {
            InitializeComponent();
        }
        public CustomerProfilesTableRow(int customerID, string firstName, string lastName, string email, string phone)
        {
            InitializeComponent();
            this.customerID = customerID;
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.phone = phone;
        }
        public event EventHandler RowClick;

        private void CustomerProfilesTableRow_Load(object sender, EventArgs e)
        {
            lblTableRowCustomerID.Text = customerID.ToString();
            lblTableRowFirstName.Text = firstName;
            lblTableRowLastName.Text = lastName;
            lblTableRowEmail.Text = email;
            lblTableRowPhone.Text = phone;
        }
        private void HoverEffect_Enter(object sender, EventArgs e)
        {
            lblTableRowCustomerID.BackColor = Color.FromArgb(229, 229, 229);
            lblTableRowFirstName.BackColor = Color.FromArgb(229, 229, 229);
            lblTableRowLastName.BackColor = Color.FromArgb(229, 229, 229);
            lblTableRowEmail.BackColor = Color.FromArgb(229, 229, 229);
            lblTableRowPhone.BackColor = Color.FromArgb(229, 229, 229);
        }
        private void HoverEffect_Leave(object sender, EventArgs e)
        {
            lblTableRowCustomerID.BackColor = Color.White;
            lblTableRowFirstName.BackColor = Color.White;
            lblTableRowLastName.BackColor = Color.White;
            lblTableRowEmail.BackColor = Color.White;
            lblTableRowPhone.BackColor = Color.White;
        }
        private void Row_Click(object sender, EventArgs e)
        {
            RowClick?.Invoke(lblTableRowCustomerID, e);
        }
    }
}
