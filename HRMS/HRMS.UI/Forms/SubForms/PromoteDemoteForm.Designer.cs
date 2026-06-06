namespace HRMS.UI.Forms.SubForms
{
    partial class PromoteDemoteForm
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
            this.lblEmpInfo = new System.Windows.Forms.Label();
            this.lblCurrent = new System.Windows.Forms.Label();
            this.lblCurrValue = new System.Windows.Forms.Label();
            this.lblNew = new System.Windows.Forms.Label();
            this.cmbDesignation = new System.Windows.Forms.ComboBox();
            this.lblPromoError = new System.Windows.Forms.Label();
            this.btnSavePromo = new System.Windows.Forms.Button();
            this.btnCancelPromo = new System.Windows.Forms.Button();
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
            this.pnlHeader.Size = new System.Drawing.Size(377, 50);
            this.pnlHeader.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Promote / Demote Employee";
            // 
            // lblEmpInfo
            // 
            this.lblEmpInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(99)))), ((int)(((byte)(104)))));
            this.lblEmpInfo.Location = new System.Drawing.Point(30, 68);
            this.lblEmpInfo.Name = "lblEmpInfo";
            this.lblEmpInfo.Size = new System.Drawing.Size(320, 20);
            this.lblEmpInfo.TabIndex = 1;
            // 
            // lblCurrent
            // 
            this.lblCurrent.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrent.Location = new System.Drawing.Point(30, 100);
            this.lblCurrent.Name = "lblCurrent";
            this.lblCurrent.Size = new System.Drawing.Size(160, 18);
            this.lblCurrent.TabIndex = 2;
            this.lblCurrent.Text = "Current Designation:";
            // 
            // lblCurrValue
            // 
            this.lblCurrValue.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(58)))), ((int)(((byte)(92)))));
            this.lblCurrValue.Location = new System.Drawing.Point(30, 124);
            this.lblCurrValue.Name = "lblCurrValue";
            this.lblCurrValue.Size = new System.Drawing.Size(320, 22);
            this.lblCurrValue.TabIndex = 3;
            this.lblCurrValue.Text = "---";
            // 
            // lblNew
            // 
            this.lblNew.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNew.Location = new System.Drawing.Point(30, 158);
            this.lblNew.Name = "lblNew";
            this.lblNew.Size = new System.Drawing.Size(160, 18);
            this.lblNew.TabIndex = 4;
            this.lblNew.Text = "New Designation:";
            // 
            // cmbDesignation
            // 
            this.cmbDesignation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDesignation.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDesignation.FormattingEnabled = true;
            this.cmbDesignation.Location = new System.Drawing.Point(30, 182);
            this.cmbDesignation.Name = "cmbDesignation";
            this.cmbDesignation.Size = new System.Drawing.Size(320, 28);
            this.cmbDesignation.TabIndex = 5;
            // 
            // lblPromoError
            // 
            this.lblPromoError.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromoError.ForeColor = System.Drawing.Color.Red;
            this.lblPromoError.Location = new System.Drawing.Point(30, 216);
            this.lblPromoError.Name = "lblPromoError";
            this.lblPromoError.Size = new System.Drawing.Size(320, 28);
            this.lblPromoError.TabIndex = 6;
            this.lblPromoError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSavePromo
            // 
            this.btnSavePromo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(58)))), ((int)(((byte)(92)))));
            this.btnSavePromo.FlatAppearance.BorderSize = 0;
            this.btnSavePromo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSavePromo.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSavePromo.ForeColor = System.Drawing.Color.White;
            this.btnSavePromo.Location = new System.Drawing.Point(30, 252);
            this.btnSavePromo.Name = "btnSavePromo";
            this.btnSavePromo.Size = new System.Drawing.Size(190, 36);
            this.btnSavePromo.TabIndex = 7;
            this.btnSavePromo.Text = "Save Change";
            this.btnSavePromo.UseVisualStyleBackColor = false;
            this.btnSavePromo.Click += new System.EventHandler(this.btnSavePromo_Click);
            // 
            // btnCancelPromo
            // 
            this.btnCancelPromo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelPromo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelPromo.ForeColor = System.Drawing.Color.Red;
            this.btnCancelPromo.Location = new System.Drawing.Point(230, 252);
            this.btnCancelPromo.Name = "btnCancelPromo";
            this.btnCancelPromo.Size = new System.Drawing.Size(120, 36);
            this.btnCancelPromo.TabIndex = 8;
            this.btnCancelPromo.Text = "Cancel";
            this.btnCancelPromo.UseVisualStyleBackColor = true;
            this.btnCancelPromo.Click += new System.EventHandler(this.btnCancelPromo_Click);
            // 
            // PromoteDemoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(377, 298);
            this.Controls.Add(this.btnCancelPromo);
            this.Controls.Add(this.btnSavePromo);
            this.Controls.Add(this.lblPromoError);
            this.Controls.Add(this.cmbDesignation);
            this.Controls.Add(this.lblNew);
            this.Controls.Add(this.lblCurrValue);
            this.Controls.Add(this.lblCurrent);
            this.Controls.Add(this.lblEmpInfo);
            this.Controls.Add(this.pnlHeader);
            this.MaximumSize = new System.Drawing.Size(395, 345);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(395, 345);
            this.Name = "PromoteDemoteForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Promote / Demote Employee";
            this.Load += new System.EventHandler(this.PromoteDemoteForm_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEmpInfo;
        private System.Windows.Forms.Label lblCurrent;
        private System.Windows.Forms.Label lblCurrValue;
        private System.Windows.Forms.Label lblNew;
        private System.Windows.Forms.ComboBox cmbDesignation;
        private System.Windows.Forms.Label lblPromoError;
        private System.Windows.Forms.Button btnSavePromo;
        private System.Windows.Forms.Button btnCancelPromo;
    }
}