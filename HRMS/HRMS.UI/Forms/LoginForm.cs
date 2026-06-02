using HRMS.Library.DL;
using HRMS.Library.Utility;
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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        // Runs when the form first loads
        private void LoginForm_Load(object sender, EventArgs e)
        {
            // Check if this is a brand new system
            if (!UserDL.IsAdminExists())
            {
                // No admin found — show init setup first
                InitSetupForm setup = new InitSetupForm();
                setup.ShowDialog(); // blocks until setup is done
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            int strength = Validations.GetPasswordStrength(txtPassword.Text);
            pbStrength.Value = strength;

            if (strength == 0)
            {
                lblStrength.Text = "Weak";
                lblStrength.ForeColor = Color.Red;
            }

            else if (strength == 1)
            {
                lblStrength.Text = "Medium";
                lblStrength.ForeColor = Color.Orange;
            }
            else
            {
                lblStrength.Text = "Strong";
                lblStrength.ForeColor = Color.Green;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            lblError.Text = "";

            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            // Basic empty check
            if (username == "" || password == "")
            {
                lblError.Text = "Please enter username and password.";
                return;
            }

            // Ask DL to check credentials
            string role = UserDL.CheckLogin(username, password);

            if (role == "Admin")
            {
                AdminDashboard admin = new AdminDashboard(username);
                admin.Show();
                this.Hide();
            }
            else if (role == "Employee")
            {
                // Get the EmpID so dashboard knows who is logged in
                string empID = UserDL.GetEmpIDByUsername(username);
                EmployeeDashboard emp = new EmployeeDashboard(empID, username);
                emp.Show();
                this.Hide();
            }
            else
            {
                lblError.Text = "Invalid credentials. Please try again.";
            }
        }

        private void txtPassword_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
