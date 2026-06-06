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
using HRMS.Library.Utility;

namespace HRMS.UI.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            
            DrawHeaderIcon();

            if (!UserDL.IsAdminExists())
            {
                InitSetupForm setup = new InitSetupForm();
                setup.FormClosed += (s, args) =>
                {
                    if (!UserDL.IsAdminExists())
                        Application.Exit();
                };
                setup.ShowDialog();
            }
        }

        // Draws the building icon circle in the header
        private void DrawHeaderIcon()
        {
            Bitmap bmp = new Bitmap(48, 48);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                // Fill with navy so the circle is visible against the header
                g.Clear(Color.FromArgb(26, 58, 92));

                // Draw slightly lighter circle
                using (SolidBrush brush = new SolidBrush(Color.FromArgb(120, 255, 255, 255)))
                    g.FillEllipse(brush, 1, 1, 45, 45);

                // White border ring
                using (Pen pen = new Pen(Color.FromArgb(180, 255, 255, 255), 1.5f))
                    g.DrawEllipse(pen, 1, 1, 45, 45);

                // Letter H
                using (Font f = new Font("Arial", 20, FontStyle.Bold))
                using (SolidBrush tb = new SolidBrush(Color.White))
                {
                    StringFormat sf = new StringFormat
                    {
                        Alignment = StringAlignment.Center,
                        LineAlignment = StringAlignment.Center
                    };
                    g.DrawString("H", f, tb, new RectangleF(0, 0, 48, 48), sf);
                }
            }
            picIcon.Image = bmp;
            picIcon.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            lblError.Text = "";

            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            if (username == "" || password == "")
            {
                lblError.Text = "Please enter username and password.";
                return;
            }

            string role = UserDL.CheckLogin(username, password);

            if (role == "Admin")
            {
                AdminDashboard admin = new AdminDashboard(username);
                admin.Show();
                this.Hide();  // hide login
            }
            else if (role == "Employee")
            {
                string empID = UserDL.GetEmpIDByUsername(username);

                if (empID == null)
                {
                    lblError.Text = "Employee record not found. Contact admin.";
                    return;
                }

                EmployeeDashboard empDash =
                    new EmployeeDashboard(empID, username);
                empDash.Show();
                this.Hide();
            }
            else
            {
                lblError.Text = "Invalid credentials. Please try again.";
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show(
                "Are you sure you want to exit?",
                "Exit HRMS",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
                Application.Exit();
        }

        // Show/hide password via checkbox
        private void chkShow_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = chkShow.Checked ? '\0' : '*';
        }

        // Eye button toggles the checkbox
        private void btnShowPass_Click(object sender, EventArgs e)
        {
            chkShow.Checked = !chkShow.Checked;
        }

        private void lblError_Click(object sender, EventArgs e)
        {

        }
    }
}
