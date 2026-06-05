namespace HRMS.UI.Forms.SubForms
{
    partial class UpdateEmployeeForm
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
            this.btnCancelUpd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblUpdError = new System.Windows.Forms.Label();
            this.cmbUpdDept = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtUpdSalary = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtUpdPhone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUpdEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUpdName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(58)))), ((int)(((byte)(92)))));
            this.pnlHeader.Controls.Add(this.label1);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(402, 50);
            this.pnlHeader.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Update Employee Details";
            // 
            // btnCancelUpd
            // 
            this.btnCancelUpd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelUpd.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelUpd.ForeColor = System.Drawing.Color.Red;
            this.btnCancelUpd.Location = new System.Drawing.Point(265, 348);
            this.btnCancelUpd.Name = "btnCancelUpd";
            this.btnCancelUpd.Size = new System.Drawing.Size(108, 36);
            this.btnCancelUpd.TabIndex = 36;
            this.btnCancelUpd.Text = "Cancel";
            this.btnCancelUpd.UseVisualStyleBackColor = true;
            this.btnCancelUpd.Click += new System.EventHandler(this.btnCancelUpd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(58)))), ((int)(((byte)(92)))));
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(25, 348);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(230, 36);
            this.btnUpdate.TabIndex = 35;
            this.btnUpdate.Text = "Save Changes";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblUpdError
            // 
            this.lblUpdError.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdError.ForeColor = System.Drawing.Color.Red;
            this.lblUpdError.Location = new System.Drawing.Point(30, 297);
            this.lblUpdError.Name = "lblUpdError";
            this.lblUpdError.Size = new System.Drawing.Size(348, 36);
            this.lblUpdError.TabIndex = 34;
            this.lblUpdError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbUpdDept
            // 
            this.cmbUpdDept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUpdDept.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUpdDept.FormattingEnabled = true;
            this.cmbUpdDept.Location = new System.Drawing.Point(210, 250);
            this.cmbUpdDept.Name = "cmbUpdDept";
            this.cmbUpdDept.Size = new System.Drawing.Size(168, 28);
            this.cmbUpdDept.TabIndex = 33;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(210, 230);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 18);
            this.label8.TabIndex = 32;
            this.label8.Text = "Department:";
            // 
            // txtUpdSalary
            // 
            this.txtUpdSalary.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpdSalary.Location = new System.Drawing.Point(30, 250);
            this.txtUpdSalary.Name = "txtUpdSalary";
            this.txtUpdSalary.Size = new System.Drawing.Size(160, 27);
            this.txtUpdSalary.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(30, 230);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 18);
            this.label7.TabIndex = 30;
            this.label7.Text = "Salary:";
            // 
            // txtUpdPhone
            // 
            this.txtUpdPhone.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpdPhone.Location = new System.Drawing.Point(30, 194);
            this.txtUpdPhone.Name = "txtUpdPhone";
            this.txtUpdPhone.Size = new System.Drawing.Size(348, 27);
            this.txtUpdPhone.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 18);
            this.label6.TabIndex = 28;
            this.label6.Text = "Phone:";
            // 
            // txtUpdEmail
            // 
            this.txtUpdEmail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpdEmail.Location = new System.Drawing.Point(30, 138);
            this.txtUpdEmail.Name = "txtUpdEmail";
            this.txtUpdEmail.Size = new System.Drawing.Size(348, 27);
            this.txtUpdEmail.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 18);
            this.label5.TabIndex = 26;
            this.label5.Text = "Email:";
            // 
            // txtUpdName
            // 
            this.txtUpdName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpdName.Location = new System.Drawing.Point(30, 82);
            this.txtUpdName.Name = "txtUpdName";
            this.txtUpdName.Size = new System.Drawing.Size(348, 27);
            this.txtUpdName.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 18);
            this.label2.TabIndex = 19;
            this.label2.Text = "Full Name:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // UpdateEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(402, 433);
            this.Controls.Add(this.btnCancelUpd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblUpdError);
            this.Controls.Add(this.cmbUpdDept);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtUpdSalary);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtUpdPhone);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtUpdEmail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtUpdName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pnlHeader);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(420, 480);
            this.MinimumSize = new System.Drawing.Size(420, 480);
            this.Name = "UpdateEmployeeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Update Employee";
            this.Load += new System.EventHandler(this.UpdateEmployeeForm_Load);
            this.pnlHeader.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelUpd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblUpdError;
        private System.Windows.Forms.ComboBox cmbUpdDept;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtUpdSalary;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtUpdPhone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtUpdEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUpdName;
        private System.Windows.Forms.Label label2;
    }
}