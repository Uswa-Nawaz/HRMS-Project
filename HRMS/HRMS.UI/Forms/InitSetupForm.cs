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
using HRMS.Library.BL;

namespace HRMS.UI.Forms
{
    public partial class InitSetupForm : Form
    {
        public InitSetupForm()
        {
            InitializeComponent();
        }

        private void InitSetupForm_Load(object sender, EventArgs e)
        {
            DrawHeaderIcon();
        }

        private void DrawHeaderIcon()
        {
            Bitmap bmp = new Bitmap(48, 48);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                // Fill with navy background first
                g.Clear(Color.FromArgb(26, 58, 92));

                // Lighter circle overlay
                using (SolidBrush brush = new SolidBrush(Color.FromArgb(120, 255, 255, 255))) 
                    g.FillEllipse(brush, 1, 1, 45, 45);

                // White border
                using (Pen pen = new Pen(Color.FromArgb(180, 255, 255, 255), 1.5f))
                    g.DrawEllipse(pen, 1, 1, 45, 45);

                // Letter S
                using (Font f = new Font("Arial", 20, FontStyle.Bold))
                using (SolidBrush tb = new SolidBrush(Color.White))
                {
                    StringFormat sf = new StringFormat
                    {
                        Alignment = StringAlignment.Center,
                        LineAlignment = StringAlignment.Center
                    };
                    g.DrawString("S", f, tb, new RectangleF(0, 0, 48, 48), sf);
                }
            }
            picIcon.Image = bmp;
            picIcon.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void chkShow_CheckedChanged(object sender, EventArgs e)
        {
            char ch = chkShow.Checked ? '\0' : '*';
            txtPassword.PasswordChar = ch;
            txtConfirm.PasswordChar = ch;
        }

        private void btnShowPass_Click(object sender, EventArgs e)
        {
            chkShow.Checked = !chkShow.Checked;
        }

        private void btnShowConfirm_Click(object sender, EventArgs e)
        {
            chkShow.Checked = !chkShow.Checked;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            lblError.Text = "";

            // Confirm passwords match before anything else
            if (txtPassword.Text != txtConfirm.Text)
            {
                lblError.Text = "Passwords do not match.";
                return;
            }

            // Build AdminBL — setters just assign, DL validates
            AdminBL admin = new AdminBL();
            admin.SetName(txtName.Text.Trim());
            admin.SetUsername(txtUsername.Text.Trim());
            admin.SetPassword(txtPassword.Text);
            admin.SetRole("Admin");
            admin.SetAdminID("ADM-1001");

            // DL handles validation + SQL
            string result = UserDL.RegisterAdmin(admin);

            if (result == "True")
            {
                MessageBox.Show(
                    "Admin account created successfully!\nYou can now log in.",
                    "Setup Complete",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                lblError.Text = result;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show(
                "Exit without completing setup? The system cannot run without an admin account.",
                "Exit Setup",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
                Application.Exit();
        }
    }
}
