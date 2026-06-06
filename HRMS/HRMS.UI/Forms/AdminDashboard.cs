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
using HRMS.UI.Forms.SubForms;
using Microsoft.VisualBasic;

namespace HRMS.UI.Forms
{
    public partial class AdminDashboard : Form
    {
        private string loggedInUsername;
        private EmployeeDL empDL = new EmployeeDL();
        private DepartmentDL deptDL = new DepartmentDL();
        private LeaveDL leaveDL = new LeaveDL();

        public AdminDashboard(string username)
        {
            InitializeComponent();
            loggedInUsername = username;
        }

        private void picAvatar_Click(object sender, EventArgs e)
        {

        }

        private void pnlEmpToolbar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPayroll_Click(object sender, EventArgs e)
        {

        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            DrawAvatar();
            lblWelcome.Text = "Welcome, " + loggedInUsername;
            LoadEmployees();
            LoadDepartments();
            LoadLeaves();
            LoadSchedules();
            LoadMonths();
            LoadScheduleDropdowns();

        }

        private void dgvEmployees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DrawAvatar()
        {
            Bitmap bmp = new Bitmap(38, 38);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                g.Clear(Color.FromArgb(26, 58, 92));
                using (SolidBrush b = new SolidBrush(Color.FromArgb(120, 255, 255, 255)))
                    g.FillEllipse(b, 1, 1, 35, 35);
                using (Pen p = new Pen(Color.FromArgb(180, 255, 255, 255), 1.5f))
                    g.DrawEllipse(p, 1, 1, 35, 35);
                using (Font f = new Font("Arial", 15, FontStyle.Bold))
                using (SolidBrush tb = new SolidBrush(Color.White))
                {
                    StringFormat sf = new StringFormat
                    {
                        Alignment = StringAlignment.Center,
                        LineAlignment = StringAlignment.Center
                    };
                    // Show first letter of username
                    string letter = loggedInUsername.Length > 0
                        ? loggedInUsername[0].ToString().ToUpper()
                        : "A";
                    g.DrawString(letter, f, tb, new RectangleF(0, 0, 38, 38), sf);
                }
            }
            picAvatar.Image = bmp;
            picAvatar.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        // ═══════════════════════════════════════════
        //  EMPLOYEES TAB
        // ═══════════════════════════════════════════

        private void LoadEmployees()
        {
            dgvEmployees.DataSource = empDL.GetAll();
            StyleGrid(dgvEmployees);
        }

        private void btnAddEmp_Click(object sender, EventArgs e)
        {
            AddEmployeeForm addForm = new AddEmployeeForm();
            addForm.ShowDialog();
            LoadEmployees();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            LoadEmployees();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string kw = txtSearch.Text.Trim();
            if (kw == "")
            {
                LoadEmployees();
                return;
            }
            dgvEmployees.DataSource = EmployeeDL.Search(kw);
            StyleGrid(dgvEmployees);
        }

        private void btnUpdateEmp_Click(object sender, EventArgs e)
        {
            if (dgvEmployees.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an employee first.",
                                "No Selection", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                return;
            }
            string empID = dgvEmployees.SelectedRows[0]
                           .Cells["EmpID"].Value.ToString();
            UpdateEmployeeForm upd = new UpdateEmployeeForm(empID);
            upd.ShowDialog();
            LoadEmployees();
        }

        private void btnDeleteEmp_Click(object sender, EventArgs e)
        {
            if (dgvEmployees.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an employee first.",
                                "No Selection", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                return;
            }

            string empID = dgvEmployees.SelectedRows[0]
                           .Cells["EmpID"].Value.ToString();
            string name = dgvEmployees.SelectedRows[0]
                           .Cells["Name"].Value.ToString();

            DialogResult confirm = MessageBox.Show(
                "Delete employee " + name + " (" + empID + ")?\nThis cannot be undone.",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                bool done = empDL.Delete(empID);
                MessageBox.Show(done ? "Employee deleted successfully."
                                     : "Could not delete employee.",
                                done ? "Done" : "Error",
                                MessageBoxButtons.OK,
                                done ? MessageBoxIcon.Information
                                     : MessageBoxIcon.Error);
                LoadEmployees();
            }
        }

        private void btnPromote_Click(object sender, EventArgs e)
        {
            if (dgvEmployees.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an employee first.",
                                "No Selection", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                return;
            }

            string empID = dgvEmployees.SelectedRows[0].Cells["EmpID"].Value.ToString();
            string name = dgvEmployees.SelectedRows[0].Cells["Name"].Value.ToString();
            string current = dgvEmployees.SelectedRows[0].Cells["Designation"].Value.ToString();

            PromoteDemoteForm form = new PromoteDemoteForm(empID, name, current);
            form.ShowDialog();
            LoadEmployees(); // refresh grid either way
        }

        // ═══════════════════════════════════════════
        //  DEPARTMENTS TAB
        // ═══════════════════════════════════════════

        private void LoadDepartments()
        {
            dgvDepts.DataSource = deptDL.GetAll();
            StyleGrid(dgvDepts);
        }

        private void btnAddDept_Click(object sender, EventArgs e)
        {
            string name = txtDeptName.Text.Trim();
            string result = DepartmentDL.Save(name);

            if (result == "True")
            {
                txtDeptName.Clear();
                LoadDepartments();
                MessageBox.Show("Department added!", "Done",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(result, "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
        }

        private void btnDelDept_Click(object sender, EventArgs e)
        {
            if (dgvDepts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a department.",
                                "No Selection", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                return;
            }

            string deptID = dgvDepts.SelectedRows[0]
                              .Cells["DeptID"].Value.ToString();
            string deptName = dgvDepts.SelectedRows[0]
                              .Cells["DeptName"].Value.ToString();

            DialogResult confirm = MessageBox.Show(
                "Delete department '" + deptName + "'?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                bool done = deptDL.Delete(deptID);
                if (done)
                    LoadDepartments();
                else
                    MessageBox.Show(
                        "Cannot delete '" + deptName +
                        "'.\nEmployees are currently assigned to this department.",
                        "Cannot Delete",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
            }
        }

        // ═══════════════════════════════════════════
        //  PAYROLL TAB
        // ═══════════════════════════════════════════

        private void LoadPayroll(string empID)
        {
            dgvPayroll.DataSource = SalaryDL.GetSlipsByEmpID(empID);
            StyleGrid(dgvPayroll);
        }

        private void btnGenSlip_Click(object sender, EventArgs e)
        {
            string empID = txtPayEmpID.Text.Trim();
            string month = cmbMonth.SelectedItem != null
                           ? cmbMonth.SelectedItem.ToString()
                           : "";

            if (empID == "" || month == "")
            {
                MessageBox.Show("Please enter Employee ID and select a Month.",
                                "Missing Info", MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            // Get employee data
            DataTable dt = empDL.GetByID(empID);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Employee ID not found.",
                                "Not Found", MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            double salary = Convert.ToDouble(dt.Rows[0]["Salary"]);
            string name = dt.Rows[0]["Name"].ToString();
            string dept = dt.Rows[0]["DeptName"].ToString();

            // Build and save the slip
            SalarySlipBL slip = new SalarySlipBL();
            slip.SetEmpID(empID);
            slip.SetMonth(month);
            slip.SetGrossSalary(salary);

            string result = SalaryDL.GenerateSlip(slip);

            if (result == "True")
            {
                // Show the professional slip form
                SalarySlipForm slipForm = new SalarySlipForm(
                    empID, name, dept, month,
                    slip.GetGrossSalary(),
                    slip.GetTaxAmount(),
                    slip.GetNetSalary());
                slipForm.ShowDialog();

                // Refresh payroll grid to show the new record
                LoadPayroll(empID);
            }
            else
            {
                MessageBox.Show(result, "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }

        }

        private void LoadMonths()
        {
            string[] months = {
        "January", "February", "March", "April",
        "May", "June", "July", "August",
        "September", "October", "November", "December"
    };
            cmbMonth.Items.AddRange(months);
            cmbMonth.SelectedIndex = DateTime.Now.Month - 1; // default to current month
        }

        private void LoadLeaves()
        {
            dgvLeaves.DataSource = leaveDL.GetAll();
            StyleGrid(dgvLeaves);
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            UpdateLeaveStatus("Approved");
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            UpdateLeaveStatus("Rejected");
        }

        private void btnRefLeave_Click(object sender, EventArgs e)
        {
            LoadLeaves();
        }

        private void UpdateLeaveStatus(string status)
        {
            if (dgvLeaves.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a leave request.",
                                "No Selection", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                return;
            }

            // Only allow action on Pending requests
            string currentStatus = dgvLeaves.SelectedRows[0]
                                   .Cells["Status"].Value.ToString();
            if (currentStatus != "Pending")
            {
                MessageBox.Show("This request has already been " +
                                currentStatus.ToLower() + ".",
                                "Already Processed",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                return;
            }

            int leaveID = Convert.ToInt32(
                dgvLeaves.SelectedRows[0].Cells["LeaveID"].Value);

            string result = LeaveDL.UpdateStatus(leaveID, status);

            if (result == "True")
                LoadLeaves();
            else
                MessageBox.Show(result, "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
        }

        // ═══════════════════════════════════════════
        //  SCHEDULES TAB
        // ═══════════════════════════════════════════

        private void LoadSchedules()
        {
            dgvSchedules.DataSource = ScheduleDL.GetAll();
            StyleGrid(dgvSchedules);
        }

        private void LoadScheduleDropdowns()
        {
            cmbShift.Items.AddRange(new string[]
            {
        "Morning Shift",
        "Evening Shift",
        "Night Shift"
            });
            cmbShift.SelectedIndex = 0;

            cmbStart.Items.AddRange(new string[]
            {
        "08:00 AM", "09:00 AM", "10:00 AM", "11:00 AM",
        "12:00 PM", "01:00 PM", "02:00 PM", "03:00 PM",
        "04:00 PM", "05:00 PM"
            });
            cmbStart.SelectedIndex = 0;

            cmbEnd.Items.AddRange(new string[]
            {
        "04:00 PM", "05:00 PM", "06:00 PM", "07:00 PM",
        "08:00 PM", "09:00 PM", "10:00 PM", "11:00 PM",
        "12:00 AM"
            });
            cmbEnd.SelectedIndex = 0;
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            string empID = txtSchedEmp.Text.Trim();

            if (empID == "")
            {
                MessageBox.Show("Please enter an Employee ID.",
                                "Missing Info", MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            string shift = cmbShift.SelectedItem.ToString();
            string start = cmbStart.SelectedItem.ToString();
            string end = cmbEnd.SelectedItem.ToString();

            string result = ScheduleDL.AssignSchedule(empID, shift, start, end);

            if (result == "True")
            {
                MessageBox.Show("Schedule assigned successfully!",
                                "Done", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                txtSchedEmp.Clear();
                LoadSchedules();
            }
            else
            {
                MessageBox.Show(result, "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show(
        "Are you sure you want to logout?",
        "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                // Show the hidden login form again
                foreach (Form f in Application.OpenForms)
                {
                    if (f is LoginForm)
                    {
                        f.Show();
                        break;
                    }
                }
                this.Close();
            }
        }

        // ═══════════════════════════════════════════
        //  HELPER — makes every DataGridView look clean
        // ═══════════════════════════════════════════

        private void StyleGrid(DataGridView dgv)
        {
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(26, 58, 92);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font =
                new Font("Microsoft Sans Serif", 9f, FontStyle.Bold);
            dgv.ColumnHeadersHeight = 32;
            dgv.AlternatingRowsDefaultCellStyle.BackColor =
                Color.FromArgb(232, 240, 254);
            dgv.DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(26, 58, 92);
            dgv.DefaultCellStyle.SelectionForeColor = Color.White;
            dgv.RowTemplate.Height = 26;
            dgv.GridColor = Color.FromArgb(220, 225, 235);
        }

        private void cmbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
