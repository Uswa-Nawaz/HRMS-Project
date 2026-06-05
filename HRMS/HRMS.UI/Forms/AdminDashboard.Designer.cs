namespace HRMS.UI.Forms
{
    partial class AdminDashboard
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
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.picAvatar = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabEmployees = new System.Windows.Forms.TabPage();
            this.pnlEmpActions = new System.Windows.Forms.Panel();
            this.btnPromote = new System.Windows.Forms.Button();
            this.btnDeleteEmp = new System.Windows.Forms.Button();
            this.btnUpdateEmp = new System.Windows.Forms.Button();
            this.dgvEmployees = new System.Windows.Forms.DataGridView();
            this.pnlEmpToolbar = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnAddEmp = new System.Windows.Forms.Button();
            this.tabDepartments = new System.Windows.Forms.TabPage();
            this.dgvDepts = new System.Windows.Forms.DataGridView();
            this.pnlDeptToolbar = new System.Windows.Forms.Panel();
            this.btnDelDept = new System.Windows.Forms.Button();
            this.btnAddDept = new System.Windows.Forms.Button();
            this.txtDeptName = new System.Windows.Forms.TextBox();
            this.lblDeptName = new System.Windows.Forms.Label();
            this.tabPayroll = new System.Windows.Forms.TabPage();
            this.dgvPayroll = new System.Windows.Forms.DataGridView();
            this.pnlPayrollToolbar = new System.Windows.Forms.Panel();
            this.btnGenSlip = new System.Windows.Forms.Button();
            this.lblMonth = new System.Windows.Forms.Label();
            this.txtPayEmpID = new System.Windows.Forms.TextBox();
            this.lblPayEmp = new System.Windows.Forms.Label();
            this.tabLeaves = new System.Windows.Forms.TabPage();
            this.dgvLeaves = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRefLeave = new System.Windows.Forms.Button();
            this.btnReject = new System.Windows.Forms.Button();
            this.btnApprove = new System.Windows.Forms.Button();
            this.tabSchedules = new System.Windows.Forms.TabPage();
            this.dgvSchedules = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAssign = new System.Windows.Forms.Button();
            this.txtEnd = new System.Windows.Forms.TextBox();
            this.lblEnd = new System.Windows.Forms.Label();
            this.txtStart = new System.Windows.Forms.TextBox();
            this.lblStart = new System.Windows.Forms.Label();
            this.txtShift = new System.Windows.Forms.TextBox();
            this.lblShift = new System.Windows.Forms.Label();
            this.txtSchedEmp = new System.Windows.Forms.TextBox();
            this.lblSchedEmp = new System.Windows.Forms.Label();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            this.tabMain.SuspendLayout();
            this.tabEmployees.SuspendLayout();
            this.pnlEmpActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            this.pnlEmpToolbar.SuspendLayout();
            this.tabDepartments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepts)).BeginInit();
            this.pnlDeptToolbar.SuspendLayout();
            this.tabPayroll.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayroll)).BeginInit();
            this.pnlPayrollToolbar.SuspendLayout();
            this.tabLeaves.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeaves)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabSchedules.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedules)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(58)))), ((int)(((byte)(92)))));
            this.pnlHeader.Controls.Add(this.btnLogout);
            this.pnlHeader.Controls.Add(this.lblWelcome);
            this.pnlHeader.Controls.Add(this.picAvatar);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(942, 60);
            this.pnlHeader.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(127)))), ((int)(((byte)(168)))));
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(858, 16);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(80, 30);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(184)))), ((int)(((byte)(212)))));
            this.lblWelcome.Location = new System.Drawing.Point(62, 34);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(300, 17);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "Welcome,";
            // 
            // picAvatar
            // 
            this.picAvatar.BackColor = System.Drawing.Color.Transparent;
            this.picAvatar.Location = new System.Drawing.Point(14, 11);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.Size = new System.Drawing.Size(38, 38);
            this.picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAvatar.TabIndex = 1;
            this.picAvatar.TabStop = false;
            this.picAvatar.Click += new System.EventHandler(this.picAvatar_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(62, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(340, 24);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "HRMS — Admin Dashboard";
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabEmployees);
            this.tabMain.Controls.Add(this.tabDepartments);
            this.tabMain.Controls.Add(this.tabPayroll);
            this.tabMain.Controls.Add(this.tabLeaves);
            this.tabMain.Controls.Add(this.tabSchedules);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabMain.Location = new System.Drawing.Point(0, 60);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(942, 533);
            this.tabMain.TabIndex = 1;
            // 
            // tabEmployees
            // 
            this.tabEmployees.Controls.Add(this.pnlEmpActions);
            this.tabEmployees.Controls.Add(this.dgvEmployees);
            this.tabEmployees.Controls.Add(this.pnlEmpToolbar);
            this.tabEmployees.Location = new System.Drawing.Point(4, 32);
            this.tabEmployees.Name = "tabEmployees";
            this.tabEmployees.Padding = new System.Windows.Forms.Padding(3);
            this.tabEmployees.Size = new System.Drawing.Size(934, 497);
            this.tabEmployees.TabIndex = 0;
            this.tabEmployees.Text = "Employees";
            this.tabEmployees.UseVisualStyleBackColor = true;
            // 
            // pnlEmpActions
            // 
            this.pnlEmpActions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.pnlEmpActions.Controls.Add(this.btnPromote);
            this.pnlEmpActions.Controls.Add(this.btnDeleteEmp);
            this.pnlEmpActions.Controls.Add(this.btnUpdateEmp);
            this.pnlEmpActions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlEmpActions.Location = new System.Drawing.Point(3, 448);
            this.pnlEmpActions.Name = "pnlEmpActions";
            this.pnlEmpActions.Size = new System.Drawing.Size(928, 46);
            this.pnlEmpActions.TabIndex = 2;
            // 
            // btnPromote
            // 
            this.btnPromote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPromote.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPromote.Location = new System.Drawing.Point(284, 8);
            this.btnPromote.Name = "btnPromote";
            this.btnPromote.Size = new System.Drawing.Size(130, 28);
            this.btnPromote.TabIndex = 2;
            this.btnPromote.Text = "Promote / Demote";
            this.btnPromote.UseVisualStyleBackColor = true;
            this.btnPromote.Click += new System.EventHandler(this.btnPromote_Click);
            // 
            // btnDeleteEmp
            // 
            this.btnDeleteEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteEmp.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteEmp.ForeColor = System.Drawing.Color.Red;
            this.btnDeleteEmp.Location = new System.Drawing.Point(146, 8);
            this.btnDeleteEmp.Name = "btnDeleteEmp";
            this.btnDeleteEmp.Size = new System.Drawing.Size(130, 28);
            this.btnDeleteEmp.TabIndex = 1;
            this.btnDeleteEmp.Text = "Delete Selected";
            this.btnDeleteEmp.UseVisualStyleBackColor = true;
            this.btnDeleteEmp.Click += new System.EventHandler(this.btnDeleteEmp_Click);
            // 
            // btnUpdateEmp
            // 
            this.btnUpdateEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateEmp.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateEmp.Location = new System.Drawing.Point(8, 8);
            this.btnUpdateEmp.Name = "btnUpdateEmp";
            this.btnUpdateEmp.Size = new System.Drawing.Size(130, 28);
            this.btnUpdateEmp.TabIndex = 0;
            this.btnUpdateEmp.Text = "Update Selected";
            this.btnUpdateEmp.UseVisualStyleBackColor = true;
            this.btnUpdateEmp.Click += new System.EventHandler(this.btnUpdateEmp_Click);
            // 
            // dgvEmployees
            // 
            this.dgvEmployees.AllowUserToAddRows = false;
            this.dgvEmployees.AllowUserToDeleteRows = false;
            this.dgvEmployees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmployees.BackgroundColor = System.Drawing.Color.White;
            this.dgvEmployees.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEmployees.Location = new System.Drawing.Point(3, 49);
            this.dgvEmployees.MultiSelect = false;
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.ReadOnly = true;
            this.dgvEmployees.RowHeadersVisible = false;
            this.dgvEmployees.RowHeadersWidth = 51;
            this.dgvEmployees.RowTemplate.Height = 24;
            this.dgvEmployees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployees.Size = new System.Drawing.Size(928, 445);
            this.dgvEmployees.TabIndex = 1;
            this.dgvEmployees.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployees_CellContentClick);
            // 
            // pnlEmpToolbar
            // 
            this.pnlEmpToolbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.pnlEmpToolbar.Controls.Add(this.btnSearch);
            this.pnlEmpToolbar.Controls.Add(this.txtSearch);
            this.pnlEmpToolbar.Controls.Add(this.btnRefresh);
            this.pnlEmpToolbar.Controls.Add(this.btnAddEmp);
            this.pnlEmpToolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEmpToolbar.Location = new System.Drawing.Point(3, 3);
            this.pnlEmpToolbar.Name = "pnlEmpToolbar";
            this.pnlEmpToolbar.Size = new System.Drawing.Size(928, 46);
            this.pnlEmpToolbar.TabIndex = 0;
            this.pnlEmpToolbar.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlEmpToolbar_Paint);
            // 
            // btnSearch
            // 
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(478, 8);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(76, 28);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(270, 10);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(200, 27);
            this.txtSearch.TabIndex = 2;
            // 
            // btnRefresh
            // 
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(136, 8);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(80, 28);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnAddEmp
            // 
            this.btnAddEmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(58)))), ((int)(((byte)(92)))));
            this.btnAddEmp.FlatAppearance.BorderSize = 0;
            this.btnAddEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddEmp.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEmp.ForeColor = System.Drawing.Color.White;
            this.btnAddEmp.Location = new System.Drawing.Point(8, 8);
            this.btnAddEmp.Name = "btnAddEmp";
            this.btnAddEmp.Size = new System.Drawing.Size(120, 28);
            this.btnAddEmp.TabIndex = 0;
            this.btnAddEmp.Text = "+ Add Employee";
            this.btnAddEmp.UseVisualStyleBackColor = false;
            this.btnAddEmp.Click += new System.EventHandler(this.btnAddEmp_Click);
            // 
            // tabDepartments
            // 
            this.tabDepartments.Controls.Add(this.dgvDepts);
            this.tabDepartments.Controls.Add(this.pnlDeptToolbar);
            this.tabDepartments.Location = new System.Drawing.Point(4, 32);
            this.tabDepartments.Name = "tabDepartments";
            this.tabDepartments.Padding = new System.Windows.Forms.Padding(3);
            this.tabDepartments.Size = new System.Drawing.Size(934, 497);
            this.tabDepartments.TabIndex = 1;
            this.tabDepartments.Text = "Departments";
            this.tabDepartments.UseVisualStyleBackColor = true;
            // 
            // dgvDepts
            // 
            this.dgvDepts.AllowUserToAddRows = false;
            this.dgvDepts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDepts.BackgroundColor = System.Drawing.Color.White;
            this.dgvDepts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDepts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDepts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDepts.Location = new System.Drawing.Point(3, 49);
            this.dgvDepts.Name = "dgvDepts";
            this.dgvDepts.ReadOnly = true;
            this.dgvDepts.RowHeadersVisible = false;
            this.dgvDepts.RowHeadersWidth = 51;
            this.dgvDepts.RowTemplate.Height = 24;
            this.dgvDepts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDepts.Size = new System.Drawing.Size(928, 445);
            this.dgvDepts.TabIndex = 1;
            // 
            // pnlDeptToolbar
            // 
            this.pnlDeptToolbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.pnlDeptToolbar.Controls.Add(this.btnDelDept);
            this.pnlDeptToolbar.Controls.Add(this.btnAddDept);
            this.pnlDeptToolbar.Controls.Add(this.txtDeptName);
            this.pnlDeptToolbar.Controls.Add(this.lblDeptName);
            this.pnlDeptToolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDeptToolbar.Location = new System.Drawing.Point(3, 3);
            this.pnlDeptToolbar.Name = "pnlDeptToolbar";
            this.pnlDeptToolbar.Size = new System.Drawing.Size(928, 46);
            this.pnlDeptToolbar.TabIndex = 0;
            // 
            // btnDelDept
            // 
            this.btnDelDept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelDept.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelDept.ForeColor = System.Drawing.Color.Red;
            this.btnDelDept.Location = new System.Drawing.Point(407, 10);
            this.btnDelDept.Name = "btnDelDept";
            this.btnDelDept.Size = new System.Drawing.Size(70, 28);
            this.btnDelDept.TabIndex = 3;
            this.btnDelDept.Text = "Delete";
            this.btnDelDept.UseVisualStyleBackColor = true;
            this.btnDelDept.Click += new System.EventHandler(this.btnDelDept_Click);
            // 
            // btnAddDept
            // 
            this.btnAddDept.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(58)))), ((int)(((byte)(92)))));
            this.btnAddDept.FlatAppearance.BorderSize = 0;
            this.btnAddDept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDept.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDept.ForeColor = System.Drawing.Color.White;
            this.btnAddDept.Location = new System.Drawing.Point(329, 10);
            this.btnAddDept.Name = "btnAddDept";
            this.btnAddDept.Size = new System.Drawing.Size(70, 28);
            this.btnAddDept.TabIndex = 2;
            this.btnAddDept.Text = "+ Add";
            this.btnAddDept.UseVisualStyleBackColor = false;
            this.btnAddDept.Click += new System.EventHandler(this.btnAddDept_Click);
            // 
            // txtDeptName
            // 
            this.txtDeptName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeptName.Location = new System.Drawing.Point(142, 10);
            this.txtDeptName.Name = "txtDeptName";
            this.txtDeptName.Size = new System.Drawing.Size(180, 27);
            this.txtDeptName.TabIndex = 1;
            // 
            // lblDeptName
            // 
            this.lblDeptName.AutoSize = true;
            this.lblDeptName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeptName.Location = new System.Drawing.Point(8, 14);
            this.lblDeptName.Name = "lblDeptName";
            this.lblDeptName.Size = new System.Drawing.Size(136, 20);
            this.lblDeptName.TabIndex = 0;
            this.lblDeptName.Text = "Department Name:";
            // 
            // tabPayroll
            // 
            this.tabPayroll.Controls.Add(this.dgvPayroll);
            this.tabPayroll.Controls.Add(this.pnlPayrollToolbar);
            this.tabPayroll.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.tabPayroll.Location = new System.Drawing.Point(4, 32);
            this.tabPayroll.Name = "tabPayroll";
            this.tabPayroll.Padding = new System.Windows.Forms.Padding(3);
            this.tabPayroll.Size = new System.Drawing.Size(934, 497);
            this.tabPayroll.TabIndex = 2;
            this.tabPayroll.Text = "Payroll";
            this.tabPayroll.UseVisualStyleBackColor = true;
            this.tabPayroll.Click += new System.EventHandler(this.tabPayroll_Click);
            // 
            // dgvPayroll
            // 
            this.dgvPayroll.AllowUserToAddRows = false;
            this.dgvPayroll.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPayroll.BackgroundColor = System.Drawing.Color.White;
            this.dgvPayroll.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPayroll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPayroll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPayroll.Location = new System.Drawing.Point(3, 49);
            this.dgvPayroll.Name = "dgvPayroll";
            this.dgvPayroll.ReadOnly = true;
            this.dgvPayroll.RowHeadersVisible = false;
            this.dgvPayroll.RowHeadersWidth = 51;
            this.dgvPayroll.RowTemplate.Height = 24;
            this.dgvPayroll.Size = new System.Drawing.Size(928, 445);
            this.dgvPayroll.TabIndex = 1;
            // 
            // pnlPayrollToolbar
            // 
            this.pnlPayrollToolbar.Controls.Add(this.cmbMonth);
            this.pnlPayrollToolbar.Controls.Add(this.btnGenSlip);
            this.pnlPayrollToolbar.Controls.Add(this.lblMonth);
            this.pnlPayrollToolbar.Controls.Add(this.txtPayEmpID);
            this.pnlPayrollToolbar.Controls.Add(this.lblPayEmp);
            this.pnlPayrollToolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPayrollToolbar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnlPayrollToolbar.Location = new System.Drawing.Point(3, 3);
            this.pnlPayrollToolbar.Name = "pnlPayrollToolbar";
            this.pnlPayrollToolbar.Size = new System.Drawing.Size(928, 46);
            this.pnlPayrollToolbar.TabIndex = 0;
            // 
            // btnGenSlip
            // 
            this.btnGenSlip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(58)))), ((int)(((byte)(92)))));
            this.btnGenSlip.FlatAppearance.BorderSize = 0;
            this.btnGenSlip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenSlip.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenSlip.ForeColor = System.Drawing.Color.White;
            this.btnGenSlip.Location = new System.Drawing.Point(396, 10);
            this.btnGenSlip.Name = "btnGenSlip";
            this.btnGenSlip.Size = new System.Drawing.Size(110, 28);
            this.btnGenSlip.TabIndex = 4;
            this.btnGenSlip.Text = "Generate Slip";
            this.btnGenSlip.UseVisualStyleBackColor = false;
            this.btnGenSlip.Click += new System.EventHandler(this.btnGenSlip_Click);
            // 
            // lblMonth
            // 
            this.lblMonth.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonth.Location = new System.Drawing.Point(220, 14);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(55, 20);
            this.lblMonth.TabIndex = 2;
            this.lblMonth.Text = "Month:";
            // 
            // txtPayEmpID
            // 
            this.txtPayEmpID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPayEmpID.Location = new System.Drawing.Point(102, 10);
            this.txtPayEmpID.Name = "txtPayEmpID";
            this.txtPayEmpID.Size = new System.Drawing.Size(110, 27);
            this.txtPayEmpID.TabIndex = 1;
            // 
            // lblPayEmp
            // 
            this.lblPayEmp.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayEmp.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPayEmp.Location = new System.Drawing.Point(8, 14);
            this.lblPayEmp.Name = "lblPayEmp";
            this.lblPayEmp.Size = new System.Drawing.Size(100, 20);
            this.lblPayEmp.TabIndex = 0;
            this.lblPayEmp.Text = "Employee ID:";
            // 
            // tabLeaves
            // 
            this.tabLeaves.Controls.Add(this.dgvLeaves);
            this.tabLeaves.Controls.Add(this.panel1);
            this.tabLeaves.Location = new System.Drawing.Point(4, 32);
            this.tabLeaves.Name = "tabLeaves";
            this.tabLeaves.Padding = new System.Windows.Forms.Padding(3);
            this.tabLeaves.Size = new System.Drawing.Size(934, 497);
            this.tabLeaves.TabIndex = 3;
            this.tabLeaves.Text = "Leaves";
            this.tabLeaves.UseVisualStyleBackColor = true;
            // 
            // dgvLeaves
            // 
            this.dgvLeaves.AllowUserToAddRows = false;
            this.dgvLeaves.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLeaves.BackgroundColor = System.Drawing.Color.White;
            this.dgvLeaves.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLeaves.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLeaves.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLeaves.Location = new System.Drawing.Point(3, 49);
            this.dgvLeaves.Name = "dgvLeaves";
            this.dgvLeaves.ReadOnly = true;
            this.dgvLeaves.RowHeadersVisible = false;
            this.dgvLeaves.RowHeadersWidth = 51;
            this.dgvLeaves.RowTemplate.Height = 24;
            this.dgvLeaves.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLeaves.Size = new System.Drawing.Size(928, 445);
            this.dgvLeaves.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.panel1.Controls.Add(this.btnRefLeave);
            this.panel1.Controls.Add(this.btnReject);
            this.panel1.Controls.Add(this.btnApprove);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(928, 46);
            this.panel1.TabIndex = 0;
            // 
            // btnRefLeave
            // 
            this.btnRefLeave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefLeave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefLeave.Location = new System.Drawing.Point(204, 8);
            this.btnRefLeave.Name = "btnRefLeave";
            this.btnRefLeave.Size = new System.Drawing.Size(80, 28);
            this.btnRefLeave.TabIndex = 2;
            this.btnRefLeave.Text = "Refresh";
            this.btnRefLeave.UseVisualStyleBackColor = true;
            this.btnRefLeave.Click += new System.EventHandler(this.btnRefLeave_Click);
            // 
            // btnReject
            // 
            this.btnReject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnReject.FlatAppearance.BorderSize = 0;
            this.btnReject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReject.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReject.ForeColor = System.Drawing.Color.White;
            this.btnReject.Location = new System.Drawing.Point(106, 8);
            this.btnReject.Name = "btnReject";
            this.btnReject.Size = new System.Drawing.Size(90, 28);
            this.btnReject.TabIndex = 1;
            this.btnReject.Text = "Reject";
            this.btnReject.UseVisualStyleBackColor = false;
            this.btnReject.Click += new System.EventHandler(this.btnReject_Click);
            // 
            // btnApprove
            // 
            this.btnApprove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(110)))), ((int)(((byte)(86)))));
            this.btnApprove.FlatAppearance.BorderSize = 0;
            this.btnApprove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApprove.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApprove.ForeColor = System.Drawing.Color.White;
            this.btnApprove.Location = new System.Drawing.Point(8, 8);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(90, 28);
            this.btnApprove.TabIndex = 0;
            this.btnApprove.Text = "Approve";
            this.btnApprove.UseVisualStyleBackColor = false;
            this.btnApprove.Click += new System.EventHandler(this.btnApprove_Click);
            // 
            // tabSchedules
            // 
            this.tabSchedules.Controls.Add(this.dgvSchedules);
            this.tabSchedules.Controls.Add(this.panel2);
            this.tabSchedules.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabSchedules.Location = new System.Drawing.Point(4, 32);
            this.tabSchedules.Name = "tabSchedules";
            this.tabSchedules.Size = new System.Drawing.Size(934, 497);
            this.tabSchedules.TabIndex = 0;
            this.tabSchedules.Text = "Schedules";
            this.tabSchedules.UseVisualStyleBackColor = true;
            // 
            // dgvSchedules
            // 
            this.dgvSchedules.AllowUserToAddRows = false;
            this.dgvSchedules.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSchedules.BackgroundColor = System.Drawing.Color.White;
            this.dgvSchedules.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSchedules.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSchedules.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSchedules.Location = new System.Drawing.Point(0, 46);
            this.dgvSchedules.Name = "dgvSchedules";
            this.dgvSchedules.ReadOnly = true;
            this.dgvSchedules.RowHeadersVisible = false;
            this.dgvSchedules.RowHeadersWidth = 51;
            this.dgvSchedules.RowTemplate.Height = 24;
            this.dgvSchedules.Size = new System.Drawing.Size(934, 451);
            this.dgvSchedules.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.panel2.Controls.Add(this.btnAssign);
            this.panel2.Controls.Add(this.txtEnd);
            this.panel2.Controls.Add(this.lblEnd);
            this.panel2.Controls.Add(this.txtStart);
            this.panel2.Controls.Add(this.lblStart);
            this.panel2.Controls.Add(this.txtShift);
            this.panel2.Controls.Add(this.lblShift);
            this.panel2.Controls.Add(this.txtSchedEmp);
            this.panel2.Controls.Add(this.lblSchedEmp);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(934, 46);
            this.panel2.TabIndex = 0;
            // 
            // btnAssign
            // 
            this.btnAssign.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(58)))), ((int)(((byte)(92)))));
            this.btnAssign.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAssign.FlatAppearance.BorderSize = 0;
            this.btnAssign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssign.ForeColor = System.Drawing.Color.White;
            this.btnAssign.Location = new System.Drawing.Point(554, 10);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(75, 28);
            this.btnAssign.TabIndex = 8;
            this.btnAssign.Text = "Assign";
            this.btnAssign.UseVisualStyleBackColor = false;
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click);
            // 
            // txtEnd
            // 
            this.txtEnd.Location = new System.Drawing.Point(476, 10);
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.Size = new System.Drawing.Size(70, 27);
            this.txtEnd.TabIndex = 7;
            // 
            // lblEnd
            // 
            this.lblEnd.Location = new System.Drawing.Point(442, 14);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(40, 18);
            this.lblEnd.TabIndex = 6;
            this.lblEnd.Text = "End:";
            // 
            // txtStart
            // 
            this.txtStart.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStart.Location = new System.Drawing.Point(364, 10);
            this.txtStart.Name = "txtStart";
            this.txtStart.Size = new System.Drawing.Size(70, 27);
            this.txtStart.TabIndex = 5;
            // 
            // lblStart
            // 
            this.lblStart.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStart.Location = new System.Drawing.Point(322, 14);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(44, 18);
            this.lblStart.TabIndex = 4;
            this.lblStart.Text = "Start:";
            // 
            // txtShift
            // 
            this.txtShift.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShift.Location = new System.Drawing.Point(204, 10);
            this.txtShift.Name = "txtShift";
            this.txtShift.Size = new System.Drawing.Size(110, 27);
            this.txtShift.TabIndex = 3;
            // 
            // lblShift
            // 
            this.lblShift.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShift.Location = new System.Drawing.Point(164, 14);
            this.lblShift.Name = "lblShift";
            this.lblShift.Size = new System.Drawing.Size(44, 18);
            this.lblShift.TabIndex = 2;
            this.lblShift.Text = "Shift:";
            // 
            // txtSchedEmp
            // 
            this.txtSchedEmp.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchedEmp.Location = new System.Drawing.Point(66, 10);
            this.txtSchedEmp.Name = "txtSchedEmp";
            this.txtSchedEmp.Size = new System.Drawing.Size(90, 27);
            this.txtSchedEmp.TabIndex = 1;
            // 
            // lblSchedEmp
            // 
            this.lblSchedEmp.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSchedEmp.Location = new System.Drawing.Point(8, 14);
            this.lblSchedEmp.Name = "lblSchedEmp";
            this.lblSchedEmp.Size = new System.Drawing.Size(65, 18);
            this.lblSchedEmp.TabIndex = 0;
            this.lblSchedEmp.Text = "Emp ID:";
            // 
            // cmbMonth
            // 
            this.cmbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMonth.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMonth.FormattingEnabled = true;
            this.cmbMonth.Location = new System.Drawing.Point(274, 10);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(110, 28);
            this.cmbMonth.TabIndex = 5;
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(942, 593);
            this.Controls.Add(this.tabMain);
            this.Controls.Add(this.pnlHeader);
            this.MaximumSize = new System.Drawing.Size(960, 640);
            this.MinimumSize = new System.Drawing.Size(960, 640);
            this.Name = "AdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HRMS — Admin Dashboard";
            this.Load += new System.EventHandler(this.AdminDashboard_Load);
            this.pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            this.tabMain.ResumeLayout(false);
            this.tabEmployees.ResumeLayout(false);
            this.pnlEmpActions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            this.pnlEmpToolbar.ResumeLayout(false);
            this.pnlEmpToolbar.PerformLayout();
            this.tabDepartments.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepts)).EndInit();
            this.pnlDeptToolbar.ResumeLayout(false);
            this.pnlDeptToolbar.PerformLayout();
            this.tabPayroll.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayroll)).EndInit();
            this.pnlPayrollToolbar.ResumeLayout(false);
            this.pnlPayrollToolbar.PerformLayout();
            this.tabLeaves.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeaves)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tabSchedules.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedules)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.PictureBox picAvatar;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabEmployees;
        private System.Windows.Forms.TabPage tabDepartments;
        private System.Windows.Forms.TabPage tabPayroll;
        private System.Windows.Forms.TabPage tabSchedules;
        private System.Windows.Forms.Panel pnlEmpToolbar;
        private System.Windows.Forms.Button btnAddEmp;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvEmployees;
        private System.Windows.Forms.Panel pnlEmpActions;
        private System.Windows.Forms.Button btnUpdateEmp;
        private System.Windows.Forms.Button btnPromote;
        private System.Windows.Forms.Button btnDeleteEmp;
        private System.Windows.Forms.Panel pnlDeptToolbar;
        private System.Windows.Forms.TextBox txtDeptName;
        private System.Windows.Forms.Label lblDeptName;
        private System.Windows.Forms.Button btnAddDept;
        private System.Windows.Forms.Button btnDelDept;
        private System.Windows.Forms.DataGridView dgvDepts;
        private System.Windows.Forms.Panel pnlPayrollToolbar;
        private System.Windows.Forms.Label lblPayEmp;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.TextBox txtPayEmpID;
        private System.Windows.Forms.Button btnGenSlip;
        private System.Windows.Forms.DataGridView dgvPayroll;
        private System.Windows.Forms.TabPage tabLeaves;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnReject;
        private System.Windows.Forms.Button btnApprove;
        private System.Windows.Forms.DataGridView dgvLeaves;
        private System.Windows.Forms.Button btnRefLeave;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblSchedEmp;
        private System.Windows.Forms.TextBox txtSchedEmp;
        private System.Windows.Forms.Label lblShift;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.TextBox txtShift;
        private System.Windows.Forms.TextBox txtStart;
        private System.Windows.Forms.TextBox txtEnd;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.Button btnAssign;
        private System.Windows.Forms.DataGridView dgvSchedules;
        private System.Windows.Forms.ComboBox cmbMonth;
    }
}