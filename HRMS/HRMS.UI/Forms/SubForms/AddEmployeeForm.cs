using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HRMS.Library.BL;
using HRMS.Library.DL;

namespace HRMS.UI.Forms.SubForms
{
    public partial class AddEmployeeForm : Form
    {
        public AddEmployeeForm()
        {
            InitializeComponent();
        }

        private void AddEmployeeForm_Load(object sender, EventArgs e)
        {
            LoadDepartments();
        }

        private void LoadDepartments()
        {
            DepartmentDL deptDL = new DepartmentDL();
            DataTable depts = deptDL.GetAll();
            cmbDept.DataSource = depts;
            cmbDept.DisplayMember = "DeptName";
            cmbDept.ValueMember = "DeptID";
        }

        private void btnSaveEmp_Click(object sender, EventArgs e)
        {
            lblAddError.Text = "";

            // Parse salary first — give clear error if not a number
            double salary = 0;
            if (!double.TryParse(txtEmpSalary.Text.Trim(), out salary))
            {
                lblAddError.Text = "Salary must be a valid number.";
                return;
            }

            // Build the BL object — setters just assign, DL validates
            EmployeeBL emp = new EmployeeBL();
            emp.SetEmpID(EmployeeDL.GenerateEmpID());
            emp.SetName(txtEmpName.Text.Trim());
            emp.SetUsername(txtEmpUser.Text.Trim());
            emp.SetPassword(txtEmpPass.Text);
            emp.SetEmail(txtEmpEmail.Text.Trim());
            emp.SetPhone(txtEmpPhone.Text.Trim());
            emp.SetAddress("N/A"); // address not on this form — can add later
            emp.SetSalary(salary);
            emp.SetDesignation("Associate"); // default on add
            emp.SetRole("Employee");

            if (cmbDept.SelectedValue != null)
                emp.SetDeptID(Convert.ToInt32(cmbDept.SelectedValue));

            string result = EmployeeDL.Save(emp);

            if (result == "True")
            {
                MessageBox.Show(
                    "Employee added!\nID assigned: " + emp.GetEmpID(),
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                lblAddError.Text = result;
            }
        }

        private void btnEmpShow_Click(object sender, EventArgs e)
        {
            txtEmpPass.PasswordChar = txtEmpPass.PasswordChar == '*' ? '\0' : '*';
            btnEmpShow.Text = txtEmpPass.PasswordChar == '\0' ? "🙈" : "👁";
        }

        private void btnCancelAdd_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
