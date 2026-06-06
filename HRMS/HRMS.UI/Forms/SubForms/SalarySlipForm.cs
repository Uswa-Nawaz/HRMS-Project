using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRMS.UI.Forms.SubForms
{
    public partial class SalarySlipForm : Form
    {
        public SalarySlipForm(string empID, string name, string dept,
                               string month, double gross,
                               double tax, double net)
        {
            InitializeComponent();
            lblSlipEmpID.Text = "Employee ID:  " + empID;
            lblSlipName.Text = name;
            lblSlipDept.Text = "Department:  " + dept;
            lblSlipMonth.Text = "Month:  " + month;
            lblGross.Text = "PKR " + gross.ToString("N0");
            lblTax.Text = "- PKR " + tax.ToString("N0");
            lblNet.Text = "PKR " + net.ToString("N0");
        }

        private void SalarySlipForm_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lblGross_Click(object sender, EventArgs e)
        {

        }

        private void lblSlipDept_Click(object sender, EventArgs e)
        {

        }

        private void lblSlipName_Click(object sender, EventArgs e)
        {

        }

        private void pnlInfo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblSlipEmpID_Click(object sender, EventArgs e)
        {

        }

        private void btnCloseSlip_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
