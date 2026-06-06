using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HRMS.Library.DL;

namespace HRMS.UI.Forms.SubForms
{
    public partial class PromoteDemoteForm : Form
    {
        private string empID;
        // Predefined designations — no free text allowed
        private readonly string[] designations = {
            "Intern",
            "Associate",
            "Senior Associate",
            "Team Lead",
            "Manager",
            "Senior Manager",
            "Director",
            "VP",
            "CEO"
        };
        public PromoteDemoteForm(string empID, string empName,
                                  string currentDesignation)
        {
            InitializeComponent();
            this.empID = empID;
            lblEmpInfo.Text = "Employee: " + empName + "  (" + empID + ")";
            lblCurrValue.Text = currentDesignation;
            // Load dropdown
            cmbDesignation.Items.AddRange(designations);
            // Pre-select current designation if it exists in the list
            int idx = cmbDesignation.FindStringExact(currentDesignation);
            cmbDesignation.SelectedIndex = idx >= 0 ? idx : 0;
        }

        private void PromoteDemoteForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSavePromo_Click(object sender, EventArgs e)
        {
            lblPromoError.Text = "";

            if (cmbDesignation.SelectedItem == null)
            {
                lblPromoError.Text = "Please select a designation.";
                return;
            }
            string newDesig = cmbDesignation.SelectedItem.ToString();

            if (newDesig == lblCurrValue.Text)
            {
                lblPromoError.Text = "New designation is the same as current.";
                return;
            }
            string result = EmployeeDL.UpdateDesignation(empID, newDesig);

            if (result == "True")
            {
                MessageBox.Show(
                    "Designation updated to: " + newDesig,
                    "Done", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                lblPromoError.Text = result;
            }
        }

        private void btnCancelPromo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
