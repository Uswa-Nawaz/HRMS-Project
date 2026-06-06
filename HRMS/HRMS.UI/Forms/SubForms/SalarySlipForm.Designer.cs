namespace HRMS.UI.Forms.SubForms
{
    partial class SalarySlipForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.lblSlipEmpID = new System.Windows.Forms.Label();
            this.lblSlipName = new System.Windows.Forms.Label();
            this.lblSlipDept = new System.Windows.Forms.Label();
            this.lblSlipMonth = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblGross = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblNet = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCloseSlip = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.pnlInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(58)))), ((int)(((byte)(92)))));
            this.pnlHeader.Controls.Add(this.label2);
            this.pnlHeader.Controls.Add(this.label1);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(402, 70);
            this.pnlHeader.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(60, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "SALARY SLIP";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(184)))), ((int)(((byte)(212)))));
            this.label2.Location = new System.Drawing.Point(60, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(300, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Human Resource Management System";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlInfo
            // 
            this.pnlInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.pnlInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlInfo.Controls.Add(this.lblSlipMonth);
            this.pnlInfo.Controls.Add(this.lblSlipDept);
            this.pnlInfo.Controls.Add(this.lblSlipName);
            this.pnlInfo.Controls.Add(this.lblSlipEmpID);
            this.pnlInfo.Location = new System.Drawing.Point(22, 72);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(358, 100);
            this.pnlInfo.TabIndex = 1;
            this.pnlInfo.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlInfo_Paint);
            // 
            // lblSlipEmpID
            // 
            this.lblSlipEmpID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSlipEmpID.Location = new System.Drawing.Point(10, 10);
            this.lblSlipEmpID.Name = "lblSlipEmpID";
            this.lblSlipEmpID.Size = new System.Drawing.Size(338, 18);
            this.lblSlipEmpID.TabIndex = 0;
            this.lblSlipEmpID.Click += new System.EventHandler(this.lblSlipEmpID_Click);
            // 
            // lblSlipName
            // 
            this.lblSlipName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSlipName.Location = new System.Drawing.Point(10, 37);
            this.lblSlipName.Name = "lblSlipName";
            this.lblSlipName.Size = new System.Drawing.Size(338, 18);
            this.lblSlipName.TabIndex = 1;
            this.lblSlipName.Click += new System.EventHandler(this.lblSlipName_Click);
            // 
            // lblSlipDept
            // 
            this.lblSlipDept.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSlipDept.Location = new System.Drawing.Point(10, 64);
            this.lblSlipDept.Name = "lblSlipDept";
            this.lblSlipDept.Size = new System.Drawing.Size(180, 18);
            this.lblSlipDept.TabIndex = 2;
            this.lblSlipDept.Click += new System.EventHandler(this.lblSlipDept_Click);
            // 
            // lblSlipMonth
            // 
            this.lblSlipMonth.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSlipMonth.Location = new System.Drawing.Point(200, 64);
            this.lblSlipMonth.Name = "lblSlipMonth";
            this.lblSlipMonth.Size = new System.Drawing.Size(148, 18);
            this.lblSlipMonth.TabIndex = 3;
            this.lblSlipMonth.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.label3.Location = new System.Drawing.Point(22, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(358, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "─────────────────────────────────────────";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Gross Salary";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblGross
            // 
            this.lblGross.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGross.Location = new System.Drawing.Point(230, 190);
            this.lblGross.Name = "lblGross";
            this.lblGross.Size = new System.Drawing.Size(138, 20);
            this.lblGross.TabIndex = 4;
            this.lblGross.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblGross.Click += new System.EventHandler(this.lblGross_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Tax Deduction (7%)";
            // 
            // lblTax
            // 
            this.lblTax.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTax.ForeColor = System.Drawing.Color.Red;
            this.lblTax.Location = new System.Drawing.Point(230, 218);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(138, 20);
            this.lblTax.TabIndex = 6;
            this.lblTax.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.label6.Location = new System.Drawing.Point(22, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(358, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "─────────────────────────────────────────";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(30, 264);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 24);
            this.label7.TabIndex = 8;
            this.label7.Text = "Net Salary";
            // 
            // lblNet
            // 
            this.lblNet.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(110)))), ((int)(((byte)(86)))));
            this.lblNet.Location = new System.Drawing.Point(230, 264);
            this.lblNet.Name = "lblNet";
            this.lblNet.Size = new System.Drawing.Size(138, 24);
            this.lblNet.TabIndex = 9;
            this.lblNet.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.label8.Location = new System.Drawing.Point(19, 405);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(358, 39);
            this.label8.TabIndex = 10;
            this.label8.Text = "This is a computer-generated slip and does not require a signature.";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCloseSlip
            // 
            this.btnCloseSlip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(58)))), ((int)(((byte)(92)))));
            this.btnCloseSlip.FlatAppearance.BorderSize = 0;
            this.btnCloseSlip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseSlip.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseSlip.ForeColor = System.Drawing.Color.White;
            this.btnCloseSlip.Location = new System.Drawing.Point(22, 356);
            this.btnCloseSlip.Name = "btnCloseSlip";
            this.btnCloseSlip.Size = new System.Drawing.Size(358, 38);
            this.btnCloseSlip.TabIndex = 11;
            this.btnCloseSlip.Text = "Close";
            this.btnCloseSlip.UseVisualStyleBackColor = false;
            this.btnCloseSlip.Click += new System.EventHandler(this.btnCloseSlip_Click);
            // 
            // SalarySlipForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(402, 453);
            this.Controls.Add(this.btnCloseSlip);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblNet);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblTax);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblGross);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pnlInfo);
            this.Controls.Add(this.pnlHeader);
            this.MaximumSize = new System.Drawing.Size(420, 500);
            this.MinimumSize = new System.Drawing.Size(420, 500);
            this.Name = "SalarySlipForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Salary Slip";
            this.Load += new System.EventHandler(this.SalarySlipForm_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlInfo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.Label lblSlipName;
        private System.Windows.Forms.Label lblSlipEmpID;
        private System.Windows.Forms.Label lblSlipDept;
        private System.Windows.Forms.Label lblSlipMonth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblGross;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblNet;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCloseSlip;
    }
}