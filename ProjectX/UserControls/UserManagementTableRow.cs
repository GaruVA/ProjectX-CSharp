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
    public partial class UserManagementTableRow : UserControl
    {
        private int userID;
        private string username;
        private string firstName;
        private string lastName;
        private string email;
        private string role;
        public UserManagementTableRow()
        {
            InitializeComponent();
        }
        public UserManagementTableRow(int userID, string username, string firstName, string lastName, string email, string role)
        {
            InitializeComponent();
            this.userID = userID;
            this.username = username;
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.role = role;
        }

        public event EventHandler RowClick;

        private void UserManagementTableRow_Load(object sender, EventArgs e)
        {
            lblTableRowUserID.Text = userID.ToString();
            lblTableRowUsername.Text = username;
            lblTableRowFirstName.Text = firstName;
            lblTableRowLastName.Text = lastName;
            lblTableRowEmail.Text = email;
            lblTableRowRole.Text = role;
        }

        private void HoverEffect_Enter(object sender, EventArgs e)
        {
            lblTableRowUserID.BackColor = Color.FromArgb(229, 229, 229);
            lblTableRowUsername.BackColor = Color.FromArgb(229, 229, 229);
            lblTableRowFirstName.BackColor = Color.FromArgb(229, 229, 229);
            lblTableRowLastName.BackColor = Color.FromArgb(229, 229, 229);
            lblTableRowEmail.BackColor = Color.FromArgb(229, 229, 229);
            lblTableRowRole.BackColor = Color.FromArgb(229, 229, 229);
        }
        private void HoverEffect_Leave(object sender, EventArgs e)
        {
            lblTableRowUserID.BackColor = Color.White;
            lblTableRowUsername.BackColor = Color.White;
            lblTableRowFirstName.BackColor = Color.White;
            lblTableRowLastName.BackColor = Color.White;
            lblTableRowEmail.BackColor = Color.White;
            lblTableRowRole.BackColor = Color.White;
        }

        private void Row_Click(object sender, EventArgs e)
        {
            RowClick?.Invoke(lblTableRowUserID, e);
        }
    }
}
