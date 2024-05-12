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

namespace ProjectX
{
    public partial class Main : Form
    {
        private Login loginForm;
        private Form currentChildForm;
        private string Username;
        private string AccountType;
        public Main()
        {
            InitializeComponent();
        }
        public Main(Login loginForm, string Username, string AccountType)
        {
            InitializeComponent();
            this.loginForm = loginForm;
            this.Username = Username;
            this.AccountType = AccountType;
            lblWelcomeUser.Text = $"WELCOME, {this.Username.ToUpper()}";
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(childForm);
            pnlMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTopBar.Text = childForm.Text;
        }

        public void ChangeChildForm(Form childForm)
        {
            OpenChildForm(childForm);
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (loginForm != null)
            {
                loginForm.Close();
            }
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Properties.Settings.Default.Username = "";
            Properties.Settings.Default.Password = "";
            Properties.Settings.Default.Save();
            loginForm.Show();
        }

        private void btnUserManagement_Click(object sender, EventArgs e)
        {
            if (AccountType == "Administrator")
            {
                OpenChildForm(new UserManagement(this));
            }
            else
            {
                MessageBox.Show("Access Denied: You do not have permission to access this resource.");
            }
        }

        private void btnCustomerProfiles_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CustomerProfiles(this));
        }

        private void btnDestinations_Click(object sender, EventArgs e)
        {
            if (AccountType == "Administrator")
            {
                OpenChildForm(new Destinations(this));
            }
            else
            {
                MessageBox.Show("Access Denied: You do not have permission to access this resource.");
            }
        }

        private void btnAccommodations_Click(object sender, EventArgs e)
        {
            if (AccountType == "Administrator")
            {
                OpenChildForm(new Accommodations(this));
            }
            else
            {
                MessageBox.Show("Access Denied: You do not have permission to access this resource.");
            }
        }

        private void btnTransportation_Click(object sender, EventArgs e)
        {
            if (AccountType == "Administrator")
            {
                OpenChildForm(new Transportation(this));
            }
            else
            {
                MessageBox.Show("Access Denied: You do not have permission to access this resource.");
            }
        }

        private void btnItineraryBuilder_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ItineraryBuilderSetInfo(this));
        }

        private void btnBookings_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Bookings(this));
        }

        private void btnTravelPackages_Click(object sender, EventArgs e)
        {
            OpenChildForm(new TravelPackages(this));
        }

        private void btnReportsAnalytics_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ReportAnalytics(this));
        }
    }
}
