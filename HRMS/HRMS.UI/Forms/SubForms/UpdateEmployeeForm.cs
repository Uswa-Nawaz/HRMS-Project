using HRMS.Library.BL;
using HRMS.Library.DL;
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
    public partial class UpdateEmployeeForm : Form
    {
        private string empID;
        public UpdateEmployeeForm(string empID)
        {
            InitializeComponent();
            this.empID = empID;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void UpdateEmployeeForm_Load(object sender, EventArgs e)
        {
            LoadDepartments();
            LoadEmployeeData();
        }

        private void LoadDepartments()
        {
            DepartmentDL deptDL = new DepartmentDL();
            DataTable depts = deptDL.GetAll();
            cmbUpdDept.DataSource = depts;
            cmbUpdDept.DisplayMember = "DeptName";
            cmbUpdDept.ValueMember = "DeptID";
        }


        private void LoadEmployeeData()
        {
            EmployeeDL empDL = new EmployeeDL();
            DataTable dt = empDL.GetByID(empID);
            if (dt.Rows.Count == 0) return;

            DataRow row = dt.Rows[0];
            txtUpdName.Text = row["Name"].ToString();
            txtUpdEmail.Text = row["Email"].ToString();
            txtUpdPhone.Text = row["Phone"].ToString();
            txtUpdSalary.Text = row["Salary"].ToString();

            // Set the department dropdown to match current dept
            string deptName = row["DeptName"].ToString();
            foreach (DataRowView item in cmbUpdDept.Items)
            {
                if (item["DeptName"].ToString() == deptName)
                {
                    cmbUpdDept.SelectedItem = item;
                    break;
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            lblUpdError.Text = "";

            double salary = 0;
            if (!double.TryParse(txtUpdSalary.Text.Trim(), out salary))
            {
                lblUpdError.Text = "Salary must be a valid number.";
                return;
            }

            EmployeeBL emp = new EmployeeBL();
            emp.SetEmpID(empID);
            emp.SetName(txtUpdName.Text.Trim());
            emp.SetEmail(txtUpdEmail.Text.Trim());
            emp.SetPhone(txtUpdPhone.Text.Trim());
            emp.SetAddress("N/A");
            emp.SetSalary(salary);

            if (cmbUpdDept.SelectedValue != null)
                emp.SetDeptID(Convert.ToInt32(cmbUpdDept.SelectedValue));

            string result = EmployeeDL.Update(emp);

            if (result == "True")
            {
                MessageBox.Show("Employee updated successfully!",
                                "Done", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                lblUpdError.Text = result;
            }
        }

        private void btnCancelUpd_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
