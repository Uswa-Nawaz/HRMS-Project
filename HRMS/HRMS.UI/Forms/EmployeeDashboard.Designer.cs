namespace HRMS.UI.Forms
{
    partial class EmployeeDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.picAvatar = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.tabEmp = new System.Windows.Forms.TabControl();
            this.tabProfile = new System.Windows.Forms.TabPage();
            this.tabSalary = new System.Windows.Forms.TabPage();
            this.tabLeaves = new System.Windows.Forms.TabPage();
            this.tabSecurity = new System.Windows.Forms.TabPage();
            this.pnlProfileTop = new System.Windows.Forms.Panel();
            this.picEmpAvatar = new System.Windows.Forms.PictureBox();
            this.lblEmpFullName = new System.Windows.Forms.Label();
            this.lblEmpDesigDept = new System.Windows.Forms.Label();
            this.lblEmpIDDisplay = new System.Windows.Forms.Label();
            this.pnlInfoCards = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblEmpEmail = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblEmpPhone = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblEmpShift = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblEmpSalary = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnViewSlip = new System.Windows.Forms.Button();
            this.dgvSalary = new System.Windows.Forms.DataGridView();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtLeaveReason = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.btnSubmitLeave = new System.Windows.Forms.Button();
            this.lblLeaveError = new System.Windows.Forms.Label();
            this.dgvLeaves = new System.Windows.Forms.DataGridView();
            this.pnlSecurity = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtOldPass = new System.Windows.Forms.TextBox();
            this.btnShowOld = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.btnShowNew = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.txtConfirmPass = new System.Windows.Forms.TextBox();
            this.btnShowConfirm = new System.Windows.Forms.Button();
            this.lblSecError = new System.Windows.Forms.Label();
            this.btnChangePass = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            this.tabEmp.SuspendLayout();
            this.tabProfile.SuspendLayout();
            this.tabSalary.SuspendLayout();
            this.tabLeaves.SuspendLayout();
            this.tabSecurity.SuspendLayout();
            this.pnlProfileTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEmpAvatar)).BeginInit();
            this.pnlInfoCards.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalary)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeaves)).BeginInit();
            this.pnlSecurity.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(58)))), ((int)(((byte)(92)))));
            this.pnlHeader.Controls.Add(this.btnLogout);
            this.pnlHeader.Controls.Add(this.lblWelcome);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.picAvatar);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(762, 60);
            this.pnlHeader.TabIndex = 0;
            // 
            // picAvatar
            // 
            this.picAvatar.BackColor = System.Drawing.Color.Transparent;
            this.picAvatar.Location = new System.Drawing.Point(14, 11);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.Size = new System.Drawing.Size(38, 38);
            this.picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAvatar.TabIndex = 0;
            this.picAvatar.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(62, 6);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(380, 28);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "HRMS — Employee Dashboard";
            // 
            // lblWelcome
            // 
            this.lblWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(184)))), ((int)(((byte)(212)))));
            this.lblWelcome.Location = new System.Drawing.Point(62, 36);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(300, 18);
            this.lblWelcome.TabIndex = 2;
            this.lblWelcome.Text = "Welcome,";
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(127)))), ((int)(((byte)(168)))));
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(668, 14);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(80, 35);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // tabEmp
            // 
            this.tabEmp.Controls.Add(this.tabProfile);
            this.tabEmp.Controls.Add(this.tabSalary);
            this.tabEmp.Controls.Add(this.tabLeaves);
            this.tabEmp.Controls.Add(this.tabSecurity);
            this.tabEmp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabEmp.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabEmp.Location = new System.Drawing.Point(0, 60);
            this.tabEmp.Name = "tabEmp";
            this.tabEmp.SelectedIndex = 0;
            this.tabEmp.Size = new System.Drawing.Size(762, 473);
            this.tabEmp.TabIndex = 1;
            // 
            // tabProfile
            // 
            this.tabProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.tabProfile.Controls.Add(this.pnlInfoCards);
            this.tabProfile.Controls.Add(this.pnlProfileTop);
            this.tabProfile.Location = new System.Drawing.Point(4, 32);
            this.tabProfile.Name = "tabProfile";
            this.tabProfile.Padding = new System.Windows.Forms.Padding(3);
            this.tabProfile.Size = new System.Drawing.Size(754, 437);
            this.tabProfile.TabIndex = 0;
            this.tabProfile.Text = "My Profile";
            // 
            // tabSalary
            // 
            this.tabSalary.Controls.Add(this.dgvSalary);
            this.tabSalary.Controls.Add(this.panel5);
            this.tabSalary.Location = new System.Drawing.Point(4, 32);
            this.tabSalary.Name = "tabSalary";
            this.tabSalary.Padding = new System.Windows.Forms.Padding(3);
            this.tabSalary.Size = new System.Drawing.Size(754, 437);
            this.tabSalary.TabIndex = 1;
            this.tabSalary.Text = "Salary";
            this.tabSalary.UseVisualStyleBackColor = true;
            // 
            // tabLeaves
            // 
            this.tabLeaves.Controls.Add(this.dgvLeaves);
            this.tabLeaves.Controls.Add(this.panel6);
            this.tabLeaves.Location = new System.Drawing.Point(4, 32);
            this.tabLeaves.Name = "tabLeaves";
            this.tabLeaves.Padding = new System.Windows.Forms.Padding(3);
            this.tabLeaves.Size = new System.Drawing.Size(754, 437);
            this.tabLeaves.TabIndex = 2;
            this.tabLeaves.Text = "Leaves";
            this.tabLeaves.UseVisualStyleBackColor = true;
            // 
            // tabSecurity
            // 
            this.tabSecurity.Controls.Add(this.pnlSecurity);
            this.tabSecurity.Location = new System.Drawing.Point(4, 32);
            this.tabSecurity.Name = "tabSecurity";
            this.tabSecurity.Padding = new System.Windows.Forms.Padding(3);
            this.tabSecurity.Size = new System.Drawing.Size(754, 437);
            this.tabSecurity.TabIndex = 3;
            this.tabSecurity.Text = "Security";
            this.tabSecurity.UseVisualStyleBackColor = true;
            // 
            // pnlProfileTop
            // 
            this.pnlProfileTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.pnlProfileTop.Controls.Add(this.lblEmpIDDisplay);
            this.pnlProfileTop.Controls.Add(this.lblEmpDesigDept);
            this.pnlProfileTop.Controls.Add(this.lblEmpFullName);
            this.pnlProfileTop.Controls.Add(this.picEmpAvatar);
            this.pnlProfileTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlProfileTop.Location = new System.Drawing.Point(3, 3);
            this.pnlProfileTop.Name = "pnlProfileTop";
            this.pnlProfileTop.Size = new System.Drawing.Size(748, 90);
            this.pnlProfileTop.TabIndex = 0;
            // 
            // picEmpAvatar
            // 
            this.picEmpAvatar.BackColor = System.Drawing.Color.Transparent;
            this.picEmpAvatar.Location = new System.Drawing.Point(20, 17);
            this.picEmpAvatar.Name = "picEmpAvatar";
            this.picEmpAvatar.Size = new System.Drawing.Size(56, 56);
            this.picEmpAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picEmpAvatar.TabIndex = 0;
            this.picEmpAvatar.TabStop = false;
            // 
            // lblEmpFullName
            // 
            this.lblEmpFullName.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpFullName.Location = new System.Drawing.Point(90, 18);
            this.lblEmpFullName.Name = "lblEmpFullName";
            this.lblEmpFullName.Size = new System.Drawing.Size(300, 26);
            this.lblEmpFullName.TabIndex = 1;
            this.lblEmpFullName.Text = "---";
            // 
            // lblEmpDesigDept
            // 
            this.lblEmpDesigDept.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpDesigDept.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(99)))), ((int)(((byte)(104)))));
            this.lblEmpDesigDept.Location = new System.Drawing.Point(90, 48);
            this.lblEmpDesigDept.Name = "lblEmpDesigDept";
            this.lblEmpDesigDept.Size = new System.Drawing.Size(300, 18);
            this.lblEmpDesigDept.TabIndex = 2;
            this.lblEmpDesigDept.Text = "---";
            // 
            // lblEmpIDDisplay
            // 
            this.lblEmpIDDisplay.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpIDDisplay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(99)))), ((int)(((byte)(104)))));
            this.lblEmpIDDisplay.Location = new System.Drawing.Point(90, 68);
            this.lblEmpIDDisplay.Name = "lblEmpIDDisplay";
            this.lblEmpIDDisplay.Size = new System.Drawing.Size(200, 16);
            this.lblEmpIDDisplay.TabIndex = 3;
            this.lblEmpIDDisplay.Text = "---";
            // 
            // pnlInfoCards
            // 
            this.pnlInfoCards.Controls.Add(this.panel4);
            this.pnlInfoCards.Controls.Add(this.panel3);
            this.pnlInfoCards.Controls.Add(this.panel2);
            this.pnlInfoCards.Controls.Add(this.panel1);
            this.pnlInfoCards.Location = new System.Drawing.Point(16, 98);
            this.pnlInfoCards.Name = "pnlInfoCards";
            this.pnlInfoCards.Size = new System.Drawing.Size(730, 130);
            this.pnlInfoCards.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.panel1.Controls.Add(this.lblEmpEmail);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(355, 58);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(99)))), ((int)(((byte)(104)))));
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email";
            // 
            // lblEmpEmail
            // 
            this.lblEmpEmail.Location = new System.Drawing.Point(12, 26);
            this.lblEmpEmail.Name = "lblEmpEmail";
            this.lblEmpEmail.Size = new System.Drawing.Size(330, 22);
            this.lblEmpEmail.TabIndex = 1;
            this.lblEmpEmail.Text = "---";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.panel2.Controls.Add(this.lblEmpPhone);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(365, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(355, 58);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(99)))), ((int)(((byte)(104)))));
            this.label2.Location = new System.Drawing.Point(12, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Phone";
            // 
            // lblEmpPhone
            // 
            this.lblEmpPhone.Location = new System.Drawing.Point(12, 26);
            this.lblEmpPhone.Name = "lblEmpPhone";
            this.lblEmpPhone.Size = new System.Drawing.Size(330, 22);
            this.lblEmpPhone.TabIndex = 2;
            this.lblEmpPhone.Text = "---";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblEmpShift);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(0, 68);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(355, 58);
            this.panel3.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(99)))), ((int)(((byte)(104)))));
            this.label3.Location = new System.Drawing.Point(12, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Work Shift";
            // 
            // lblEmpShift
            // 
            this.lblEmpShift.Location = new System.Drawing.Point(12, 26);
            this.lblEmpShift.Name = "lblEmpShift";
            this.lblEmpShift.Size = new System.Drawing.Size(330, 22);
            this.lblEmpShift.TabIndex = 3;
            this.lblEmpShift.Text = "Not assigned";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.panel4.Controls.Add(this.lblEmpSalary);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Location = new System.Drawing.Point(365, 68);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(355, 58);
            this.panel4.TabIndex = 3;
            // 
            // lblEmpSalary
            // 
            this.lblEmpSalary.Location = new System.Drawing.Point(12, 27);
            this.lblEmpSalary.Name = "lblEmpSalary";
            this.lblEmpSalary.Size = new System.Drawing.Size(330, 22);
            this.lblEmpSalary.TabIndex = 2;
            this.lblEmpSalary.Text = "---";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(99)))), ((int)(((byte)(104)))));
            this.label5.Location = new System.Drawing.Point(12, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 18);
            this.label5.TabIndex = 1;
            this.label5.Text = "Monthly Salary";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.panel5.Controls.Add(this.btnViewSlip);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(748, 46);
            this.panel5.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "My Salary Slips";
            // 
            // btnViewSlip
            // 
            this.btnViewSlip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(58)))), ((int)(((byte)(92)))));
            this.btnViewSlip.FlatAppearance.BorderSize = 0;
            this.btnViewSlip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewSlip.ForeColor = System.Drawing.Color.White;
            this.btnViewSlip.Location = new System.Drawing.Point(300, 8);
            this.btnViewSlip.Name = "btnViewSlip";
            this.btnViewSlip.Size = new System.Drawing.Size(190, 30);
            this.btnViewSlip.TabIndex = 1;
            this.btnViewSlip.Text = "View Selected Slip";
            this.btnViewSlip.UseVisualStyleBackColor = false;
            this.btnViewSlip.Click += new System.EventHandler(this.btnViewSlip_Click);
            // 
            // dgvSalary
            // 
            this.dgvSalary.AllowUserToAddRows = false;
            this.dgvSalary.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSalary.BackgroundColor = System.Drawing.Color.White;
            this.dgvSalary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSalary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSalary.Location = new System.Drawing.Point(3, 49);
            this.dgvSalary.Name = "dgvSalary";
            this.dgvSalary.ReadOnly = true;
            this.dgvSalary.RowHeadersVisible = false;
            this.dgvSalary.RowHeadersWidth = 51;
            this.dgvSalary.RowTemplate.Height = 24;
            this.dgvSalary.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSalary.Size = new System.Drawing.Size(748, 385);
            this.dgvSalary.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.panel6.Controls.Add(this.btnSubmitLeave);
            this.panel6.Controls.Add(this.lblLeaveError);
            this.panel6.Controls.Add(this.dtpTo);
            this.panel6.Controls.Add(this.label9);
            this.panel6.Controls.Add(this.dtpFrom);
            this.panel6.Controls.Add(this.label8);
            this.panel6.Controls.Add(this.txtLeaveReason);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(3, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(748, 125);
            this.panel6.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(200, 22);
            this.label6.TabIndex = 0;
            this.label6.Text = "Submit Leave Request";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 18);
            this.label7.TabIndex = 1;
            this.label7.Text = "Reason:";
            // 
            // txtLeaveReason
            // 
            this.txtLeaveReason.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLeaveReason.Location = new System.Drawing.Point(76, 36);
            this.txtLeaveReason.Name = "txtLeaveReason";
            this.txtLeaveReason.Size = new System.Drawing.Size(260, 27);
            this.txtLeaveReason.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(14, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 20);
            this.label8.TabIndex = 3;
            this.label8.Text = "From:";
            // 
            // dtpFrom
            // 
            this.dtpFrom.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.Location = new System.Drawing.Point(68, 66);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(130, 25);
            this.dtpFrom.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(210, 68);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 20);
            this.label9.TabIndex = 5;
            this.label9.Text = "To:";
            // 
            // dtpTo
            // 
            this.dtpTo.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTo.Location = new System.Drawing.Point(248, 66);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(130, 25);
            this.dtpTo.TabIndex = 6;
            // 
            // btnSubmitLeave
            // 
            this.btnSubmitLeave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(58)))), ((int)(((byte)(92)))));
            this.btnSubmitLeave.FlatAppearance.BorderSize = 0;
            this.btnSubmitLeave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmitLeave.ForeColor = System.Drawing.Color.White;
            this.btnSubmitLeave.Location = new System.Drawing.Point(474, 10);
            this.btnSubmitLeave.Name = "btnSubmitLeave";
            this.btnSubmitLeave.Size = new System.Drawing.Size(169, 35);
            this.btnSubmitLeave.TabIndex = 7;
            this.btnSubmitLeave.Text = "Submit Request";
            this.btnSubmitLeave.UseVisualStyleBackColor = false;
            this.btnSubmitLeave.Click += new System.EventHandler(this.btnSubmitLeave_Click);
            // 
            // lblLeaveError
            // 
            this.lblLeaveError.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeaveError.ForeColor = System.Drawing.Color.Red;
            this.lblLeaveError.Location = new System.Drawing.Point(12, 102);
            this.lblLeaveError.Name = "lblLeaveError";
            this.lblLeaveError.Size = new System.Drawing.Size(500, 18);
            this.lblLeaveError.TabIndex = 8;
            this.lblLeaveError.Text = "|";
            this.lblLeaveError.Click += new System.EventHandler(this.lblLeaveError_Click);
            // 
            // dgvLeaves
            // 
            this.dgvLeaves.AllowUserToAddRows = false;
            this.dgvLeaves.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLeaves.BackgroundColor = System.Drawing.Color.White;
            this.dgvLeaves.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLeaves.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLeaves.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLeaves.Location = new System.Drawing.Point(3, 128);
            this.dgvLeaves.Name = "dgvLeaves";
            this.dgvLeaves.ReadOnly = true;
            this.dgvLeaves.RowHeadersVisible = false;
            this.dgvLeaves.RowHeadersWidth = 51;
            this.dgvLeaves.RowTemplate.Height = 24;
            this.dgvLeaves.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLeaves.Size = new System.Drawing.Size(748, 306);
            this.dgvLeaves.TabIndex = 9;
            // 
            // pnlSecurity
            // 
            this.pnlSecurity.BackColor = System.Drawing.Color.White;
            this.pnlSecurity.Controls.Add(this.btnChangePass);
            this.pnlSecurity.Controls.Add(this.lblSecError);
            this.pnlSecurity.Controls.Add(this.btnShowConfirm);
            this.pnlSecurity.Controls.Add(this.txtConfirmPass);
            this.pnlSecurity.Controls.Add(this.label14);
            this.pnlSecurity.Controls.Add(this.btnShowNew);
            this.pnlSecurity.Controls.Add(this.txtNewPass);
            this.pnlSecurity.Controls.Add(this.label13);
            this.pnlSecurity.Controls.Add(this.btnShowOld);
            this.pnlSecurity.Controls.Add(this.txtOldPass);
            this.pnlSecurity.Controls.Add(this.label12);
            this.pnlSecurity.Controls.Add(this.label11);
            this.pnlSecurity.Controls.Add(this.label10);
            this.pnlSecurity.Location = new System.Drawing.Point(180, 30);
            this.pnlSecurity.Name = "pnlSecurity";
            this.pnlSecurity.Size = new System.Drawing.Size(400, 340);
            this.pnlSecurity.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1, 1);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(398, 26);
            this.label10.TabIndex = 0;
            this.label10.Text = "Change Password";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(99)))), ((int)(((byte)(104)))));
            this.label11.Location = new System.Drawing.Point(1, 30);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(278, 23);
            this.label11.TabIndex = 1;
            this.label11.Text = "Update your login password below.";
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(1, 66);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(160, 18);
            this.label12.TabIndex = 2;
            this.label12.Text = "Current Password";
            // 
            // txtOldPass
            // 
            this.txtOldPass.Location = new System.Drawing.Point(1, 86);
            this.txtOldPass.Name = "txtOldPass";
            this.txtOldPass.PasswordChar = '*';
            this.txtOldPass.Size = new System.Drawing.Size(368, 30);
            this.txtOldPass.TabIndex = 3;
            // 
            // btnShowOld
            // 
            this.btnShowOld.FlatAppearance.BorderSize = 0;
            this.btnShowOld.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowOld.Location = new System.Drawing.Point(372, 86);
            this.btnShowOld.Name = "btnShowOld";
            this.btnShowOld.Size = new System.Drawing.Size(28, 28);
            this.btnShowOld.TabIndex = 4;
            this.btnShowOld.Text = "👁";
            this.btnShowOld.UseVisualStyleBackColor = true;
            this.btnShowOld.Click += new System.EventHandler(this.btnShowOld_Click);
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(1, 126);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(160, 18);
            this.label13.TabIndex = 5;
            this.label13.Text = "New Password";
            // 
            // txtNewPass
            // 
            this.txtNewPass.Location = new System.Drawing.Point(1, 146);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.PasswordChar = '*';
            this.txtNewPass.Size = new System.Drawing.Size(368, 30);
            this.txtNewPass.TabIndex = 6;
            // 
            // btnShowNew
            // 
            this.btnShowNew.FlatAppearance.BorderSize = 0;
            this.btnShowNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowNew.Location = new System.Drawing.Point(372, 146);
            this.btnShowNew.Name = "btnShowNew";
            this.btnShowNew.Size = new System.Drawing.Size(28, 28);
            this.btnShowNew.TabIndex = 7;
            this.btnShowNew.Text = "👁";
            this.btnShowNew.UseVisualStyleBackColor = true;
            this.btnShowNew.Click += new System.EventHandler(this.btnShowNew_Click);
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(1, 186);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(200, 18);
            this.label14.TabIndex = 8;
            this.label14.Text = "Confirm New Password";
            // 
            // txtConfirmPass
            // 
            this.txtConfirmPass.Location = new System.Drawing.Point(1, 206);
            this.txtConfirmPass.Name = "txtConfirmPass";
            this.txtConfirmPass.PasswordChar = '*';
            this.txtConfirmPass.Size = new System.Drawing.Size(368, 30);
            this.txtConfirmPass.TabIndex = 9;
            // 
            // btnShowConfirm
            // 
            this.btnShowConfirm.FlatAppearance.BorderSize = 0;
            this.btnShowConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowConfirm.Location = new System.Drawing.Point(372, 206);
            this.btnShowConfirm.Name = "btnShowConfirm";
            this.btnShowConfirm.Size = new System.Drawing.Size(28, 28);
            this.btnShowConfirm.TabIndex = 10;
            this.btnShowConfirm.Text = "👁";
            this.btnShowConfirm.UseVisualStyleBackColor = true;
            this.btnShowConfirm.Click += new System.EventHandler(this.btnShowConfirm_Click);
            // 
            // lblSecError
            // 
            this.lblSecError.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecError.ForeColor = System.Drawing.Color.Red;
            this.lblSecError.Location = new System.Drawing.Point(1, 244);
            this.lblSecError.Name = "lblSecError";
            this.lblSecError.Size = new System.Drawing.Size(400, 36);
            this.lblSecError.TabIndex = 11;
            this.lblSecError.Text = "|";
            this.lblSecError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnChangePass
            // 
            this.btnChangePass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(58)))), ((int)(((byte)(92)))));
            this.btnChangePass.FlatAppearance.BorderSize = 0;
            this.btnChangePass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePass.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePass.ForeColor = System.Drawing.Color.White;
            this.btnChangePass.Location = new System.Drawing.Point(1, 288);
            this.btnChangePass.Name = "btnChangePass";
            this.btnChangePass.Size = new System.Drawing.Size(400, 36);
            this.btnChangePass.TabIndex = 12;
            this.btnChangePass.Text = "Change Password";
            this.btnChangePass.UseVisualStyleBackColor = false;
            this.btnChangePass.Click += new System.EventHandler(this.btnChangePass_Click);
            // 
            // EmployeeDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(762, 533);
            this.Controls.Add(this.tabEmp);
            this.Controls.Add(this.pnlHeader);
            this.MaximumSize = new System.Drawing.Size(780, 580);
            this.MinimumSize = new System.Drawing.Size(780, 580);
            this.Name = "EmployeeDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HRMS — Employee Dashboard";
            this.Load += new System.EventHandler(this.EmployeeDashboard_Load);
            this.pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            this.tabEmp.ResumeLayout(false);
            this.tabProfile.ResumeLayout(false);
            this.tabSalary.ResumeLayout(false);
            this.tabLeaves.ResumeLayout(false);
            this.tabSecurity.ResumeLayout(false);
            this.pnlProfileTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picEmpAvatar)).EndInit();
            this.pnlInfoCards.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalary)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeaves)).EndInit();
            this.pnlSecurity.ResumeLayout(false);
            this.pnlSecurity.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox picAvatar;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.TabControl tabEmp;
        private System.Windows.Forms.TabPage tabProfile;
        private System.Windows.Forms.TabPage tabSalary;
        private System.Windows.Forms.TabPage tabLeaves;
        private System.Windows.Forms.TabPage tabSecurity;
        private System.Windows.Forms.Panel pnlProfileTop;
        private System.Windows.Forms.PictureBox picEmpAvatar;
        private System.Windows.Forms.Label lblEmpFullName;
        private System.Windows.Forms.Label lblEmpIDDisplay;
        private System.Windows.Forms.Label lblEmpDesigDept;
        private System.Windows.Forms.Panel pnlInfoCards;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblEmpPhone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblEmpEmail;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblEmpSalary;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblEmpShift;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvSalary;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnViewSlip;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtLeaveReason;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSubmitLeave;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Label lblLeaveError;
        private System.Windows.Forms.DataGridView dgvLeaves;
        private System.Windows.Forms.Panel pnlSecurity;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnShowOld;
        private System.Windows.Forms.TextBox txtOldPass;
        private System.Windows.Forms.TextBox txtConfirmPass;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnShowNew;
        private System.Windows.Forms.TextBox txtNewPass;
        private System.Windows.Forms.Button btnShowConfirm;
        private System.Windows.Forms.Button btnChangePass;
        private System.Windows.Forms.Label lblSecError;
    }
}