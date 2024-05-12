using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectX.Forms
{
    public partial class Reports : Form
    {
        private Main mainForm;
        public Reports(Main mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            mainForm.ChangeChildForm(new ReportAnalytics(mainForm));
        }
    }
}
