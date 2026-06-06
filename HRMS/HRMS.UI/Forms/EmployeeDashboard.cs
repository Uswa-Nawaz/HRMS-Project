using HRMS.Library.BL;
using HRMS.Library.DL;
using HRMS.Library.Utility;
using HRMS.UI.Forms.SubForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRMS.UI.Forms
{
    public partial class EmployeeDashboard : Form
    {
        private string empID;
        private string username;
        public EmployeeDashboard(string empID, string username)
        {
            InitializeComponent();
            this.empID = empID;
            this.username = username;
        }

        private void lblLeaveError_Click(object sender, EventArgs e)
        {

        }

        private void EmployeeDashboard_Load(object sender, EventArgs e)
        {
            DrawAvatar();
            lblWelcome.Text = "Welcome, " + username;
            LoadProfile();
            LoadSalary();
            LoadLeaves();
        }

        // ═══════════════════════════════════════════
        //  HEADER AVATAR
        // ═══════════════════════════════════════════

        private void DrawAvatar()
        {
            Bitmap bmp = new Bitmap(38, 38);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.SmoothingMode =
                    System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                g.Clear(Color.FromArgb(26, 58, 92));
                using (SolidBrush b =
                    new SolidBrush(Color.FromArgb(120, 255, 255, 255)))
                    g.FillEllipse(b, 1, 1, 35, 35);
                using (Pen p =
                    new Pen(Color.FromArgb(180, 255, 255, 255), 1.5f))
                    g.DrawEllipse(p, 1, 1, 35, 35);
                using (Font f = new Font("Arial", 15, FontStyle.Bold))
                using (SolidBrush tb = new SolidBrush(Color.White))
                {
                    StringFormat sf = new StringFormat
                    {
                        Alignment = StringAlignment.Center,
                        LineAlignment = StringAlignment.Center
                    };
                    string letter = username.Length > 0
                        ? username[0].ToString().ToUpper() : "E";
                    g.DrawString(letter, f, tb,
                        new RectangleF(0, 0, 38, 38), sf);
                }
            }
            picAvatar.Image = bmp;
            picAvatar.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        // Draws the larger initials avatar on the profile tab
        private void DrawProfileAvatar(string fullName)
        {
            string initials = GetInitials(fullName);
            Bitmap bmp = new Bitmap(56, 56);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.SmoothingMode =
                    System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                g.Clear(Color.FromArgb(232, 240, 254));
                using (Font f = new Font("Arial", 18, FontStyle.Bold))
                using (SolidBrush tb =
                    new SolidBrush(Color.FromArgb(26, 58, 92)))
                {
                    StringFormat sf = new StringFormat
                    {
                        Alignment = StringAlignment.Center,
                        LineAlignment = StringAlignment.Center
                    };
                    g.DrawString(initials, f, tb,
                        new RectangleF(0, 0, 56, 56), sf);
                }
            }
            picEmpAvatar.Image = bmp;
            picEmpAvatar.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private string GetInitials(string fullName)
        {
            if (string.IsNullOrWhiteSpace(fullName)) return "?";
            string[] parts = fullName.Trim().Split(' ');
            if (parts.Length == 1)
                return parts[0][0].ToString().ToUpper();
            return (parts[0][0].ToString() +
                    parts[parts.Length - 1][0].ToString()).ToUpper();
        }

        // ═══════════════════════════════════════════
        //  MY PROFILE TAB
        // ═══════════════════════════════════════════

        private void LoadProfile()
        {
            EmployeeDL empDL = new EmployeeDL();
            DataTable dt = empDL.GetByID(empID);
            if (dt.Rows.Count == 0) return;

            DataRow row = dt.Rows[0];

            string name = row["Name"].ToString();
            string desig = row["Designation"].ToString();
            string dept = row["DeptName"].ToString();

            // Header labels
            lblEmpFullName.Text = name;
            lblEmpDesigDept.Text = desig + "  ·  " + dept + " Department";
            lblEmpIDDisplay.Text = empID;

            // Info cards
            lblEmpEmail.Text = row["Email"].ToString();
            lblEmpPhone.Text = row["Phone"].ToString();
            lblEmpSalary.Text = "PKR " +
                Convert.ToDouble(row["Salary"]).ToString("N0");

            // Shift
            DataTable sched = ScheduleDL.GetScheduleByEmpID(empID);
            if (sched.Rows.Count > 0)
                lblEmpShift.Text =
                    sched.Rows[0]["ShiftName"] + "  ·  " +
                    sched.Rows[0]["StartTime"] + " – " +
                    sched.Rows[0]["EndTime"];
            else
                lblEmpShift.Text = "Not assigned yet";

            DrawProfileAvatar(name);
        }

        // ═══════════════════════════════════════════
        //  SALARY TAB
        // ═══════════════════════════════════════════

        private void LoadSalary()
        {
            dgvSalary.DataSource = SalaryDL.GetSlipsByEmpID(empID);
            StyleGrid(dgvSalary);
        }

        private void btnViewSlip_Click(object sender, EventArgs e)
        {
            if (dgvSalary.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a salary slip to view.",
                                "No Selection", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                return;
            }

            // Get data from the selected row
            DataRow row = ((DataRowView)dgvSalary.SelectedRows[0]
                          .DataBoundItem).Row;

            // Get employee name and dept for the slip header
            EmployeeDL empDL = new EmployeeDL();
            DataTable empDT = empDL.GetByID(empID);
            string name = empDT.Rows.Count > 0
                          ? empDT.Rows[0]["Name"].ToString() : username;
            string dept = empDT.Rows.Count > 0
                          ? empDT.Rows[0]["DeptName"].ToString() : "---";

            SalarySlipForm slip = new SalarySlipForm(
                empID,
                name,
                dept,
                row["Month"].ToString(),
                Convert.ToDouble(row["GrossSalary"]),
                Convert.ToDouble(row["TaxAmount"]),
                Convert.ToDouble(row["NetSalary"]));

            slip.ShowDialog();
        }

        // ═══════════════════════════════════════════
        //  LEAVES TAB
        // ═══════════════════════════════════════════

        private void LoadLeaves()
        {
            dgvLeaves.DataSource = new LeaveDL().GetByID(empID);
            StyleGrid(dgvLeaves);
        }

        private void btnSubmitLeave_Click(object sender, EventArgs e)
        {
            lblLeaveError.Text = "";

            string reason = txtLeaveReason.Text.Trim();
            if (reason == "")
            {
                lblLeaveError.Text = "Please enter a reason for the leave.";
                return;
            }

            // From date must be before or equal to To date
            if (dtpFrom.Value.Date > dtpTo.Value.Date)
            {
                lblLeaveError.Text = "From date cannot be after To date.";
                return;
            }

            LeaveBL leave = new LeaveBL();
            leave.SetEmpID(empID);
            leave.SetReason(reason);
            leave.SetFromDate(dtpFrom.Value.ToString("yyyy-MM-dd"));
            leave.SetToDate(dtpTo.Value.ToString("yyyy-MM-dd"));
            leave.SetStatus("Pending");

            string result = LeaveDL.Save(leave);

            if (result == "True")
            {
                MessageBox.Show(
                    "Leave request submitted successfully!\n" +
                    "You can track its status in the list below.",
                    "Submitted", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                txtLeaveReason.Clear();
                LoadLeaves();
            }
            else
            {
                lblLeaveError.Text = result;
            }
        }

        private void btnShowOld_Click(object sender, EventArgs e)
        {
            txtOldPass.PasswordChar =
                txtOldPass.PasswordChar == '*' ? '\0' : '*';
        }

        private void btnShowNew_Click(object sender, EventArgs e)
        {
            txtNewPass.PasswordChar =
                txtNewPass.PasswordChar == '*' ? '\0' : '*';
        }

        private void btnShowConfirm_Click(object sender, EventArgs e)
        {
            txtConfirmPass.PasswordChar =
               txtConfirmPass.PasswordChar == '*' ? '\0' : '*';
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            lblSecError.Text = "";

            // Confirm new passwords match
            if (txtNewPass.Text != txtConfirmPass.Text)
            {
                lblSecError.Text = "New passwords do not match.";
                return;
            }

            string result = UserDL.UpdatePassword(
                username,
                txtOldPass.Text,
                txtNewPass.Text);

            if (result == "True")
            {
                MessageBox.Show(
                    "Password changed successfully!",
                    "Done", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                txtOldPass.Clear();
                txtNewPass.Clear();
                txtConfirmPass.Clear();
            }
            else
            {
                lblSecError.Text = result;
            }

        }

        // ═══════════════════════════════════════════
        //  LOGOUT
        // ═══════════════════════════════════════════
        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show(
                "Are you sure you want to logout?",
                "Logout", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
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
        //  HELPER
        // ═══════════════════════════════════════════

        private void StyleGrid(DataGridView dgv)
        {
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersDefaultCellStyle.BackColor =
                Color.FromArgb(26, 58, 92);
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
