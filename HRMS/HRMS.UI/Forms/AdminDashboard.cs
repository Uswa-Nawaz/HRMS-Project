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

            string empID = dgvEmployees.SelectedRows[0]
                             .Cells["EmpID"].Value.ToString();
            string current = dgvEmployees.SelectedRows[0]
                             .Cells["Designation"].Value.ToString();

            string newDesig = Microsoft.VisualBasic.Interaction.InputBox(
                "Employee: " + empID +
                "\nCurrent designation: " + current +
                "\n\nEnter new designation:",
                "Promote / Demote", current);

            if (newDesig.Trim() == "") return;

            string result = EmployeeDL.UpdateDesignation(empID, newDesig.Trim());
            MessageBox.Show(result == "True" ? "Designation updated!"
                                             : result,
                            result == "True" ? "Done" : "Error",
                            MessageBoxButtons.OK,
                            result == "True" ? MessageBoxIcon.Information
                                             : MessageBoxIcon.Error);
            LoadEmployees();
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
            string month = txtMonth.Text.Trim();

            if (empID == "" || month == "")
            {
                MessageBox.Show("Please enter both Employee ID and Month.",
                                "Missing Info", MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            // Get salary from DB
            DataTable dt = empDL.GetByID(empID);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Employee ID not found.",
                                "Not Found", MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            double salary = Convert.ToDouble(dt.Rows[0]["Salary"]);

            SalarySlipBL slip = new SalarySlipBL();
            slip.SetEmpID(empID);
            slip.SetMonth(month);
            slip.SetGrossSalary(salary);

            string result = SalaryDL.GenerateSlip(slip);

            if (result == "True")
            {
                MessageBox.Show("Salary slip generated!\nGross: " + salary +
                                "\nTax (7%): " + slip.GetTaxAmount() +
                                "\nNet: " + slip.GetNetSalary(),
                                "Slip Generated",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                LoadPayroll(empID);
            }
            else
            {
                MessageBox.Show(result, "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
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

        private void btnAssign_Click(object sender, EventArgs e)
        {
            string result = ScheduleDL.AssignSchedule(
                txtSchedEmp.Text.Trim(),
                txtShift.Text.Trim(),
                txtStart.Text.Trim(),
                txtEnd.Text.Trim());

            if (result == "True")
            {
                MessageBox.Show("Schedule assigned successfully!",
                                "Done", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                // Clear fields
                txtSchedEmp.Clear();
                txtShift.Clear();
                txtStart.Clear();
                txtEnd.Clear();
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
               "Logout",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                LoginForm login = new LoginForm();
                login.Show();
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

    }
}
