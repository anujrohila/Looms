namespace LoomsManagement.Windows.Forms.Master
{
    partial class frmPenaltyMaster
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
            this.txtPenaltyName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtDescription = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtPenaltyCode = new DevExpress.XtraEditors.TextEdit();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPenaltyName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPenaltyCode.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Location = new System.Drawing.Point(353, 0);
            this.panelControl1.Size = new System.Drawing.Size(125, 125);
            // 
            // btnReport
            // 
            this.btnReport.Appearance.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.Appearance.Options.UseFont = true;
            this.btnReport.Visible = false;
            // 
            // btnExit
            // 
            this.btnExit.Appearance.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Appearance.Options.UseFont = true;
            // 
            // btnSave
            // 
            this.btnSave.Appearance.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Appearance.Options.UseFont = true;
            // 
            // btndelete
            // 
            this.btndelete.Appearance.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.Appearance.Options.UseFont = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtPenaltyName);
            this.panel1.Controls.Add(this.labelControl2);
            this.panel1.Controls.Add(this.txtDescription);
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Controls.Add(this.txtPenaltyCode);
            this.panel1.Controls.Add(this.labelControl14);
            this.panel1.Size = new System.Drawing.Size(353, 125);
            // 
            // txtPenaltyName
            // 
            this.txtPenaltyName.EditValue = "";
            this.txtPenaltyName.Location = new System.Drawing.Point(112, 46);
            this.txtPenaltyName.Name = "txtPenaltyName";
            this.txtPenaltyName.Properties.Appearance.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPenaltyName.Properties.Appearance.Options.UseFont = true;
            this.txtPenaltyName.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.txtPenaltyName.Properties.Mask.EditMask = "n2";
            this.txtPenaltyName.Size = new System.Drawing.Size(205, 26);
            this.txtPenaltyName.TabIndex = 107;
            this.txtPenaltyName.ToolTip = "Enter Cheque Number";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(15, 50);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(87, 17);
            this.labelControl2.TabIndex = 111;
            this.labelControl2.Text = "Penalty Name";
            // 
            // txtDescription
            // 
            this.txtDescription.EditValue = "";
            this.txtDescription.Location = new System.Drawing.Point(112, 78);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Properties.Appearance.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Properties.Appearance.Options.UseFont = true;
            this.txtDescription.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.txtDescription.Properties.Mask.EditMask = "n2";
            this.txtDescription.Size = new System.Drawing.Size(205, 26);
            this.txtDescription.TabIndex = 108;
            this.txtDescription.ToolTip = "Enter Cheque Number";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(15, 82);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(67, 17);
            this.labelControl1.TabIndex = 110;
            this.labelControl1.Text = "Decription";
            // 
            // txtPenaltyCode
            // 
            this.txtPenaltyCode.EditValue = "";
            this.txtPenaltyCode.Location = new System.Drawing.Point(112, 14);
            this.txtPenaltyCode.Name = "txtPenaltyCode";
            this.txtPenaltyCode.Properties.Appearance.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPenaltyCode.Properties.Appearance.Options.UseFont = true;
            this.txtPenaltyCode.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.txtPenaltyCode.Properties.Mask.EditMask = "n2";
            this.txtPenaltyCode.Size = new System.Drawing.Size(205, 26);
            this.txtPenaltyCode.TabIndex = 106;
            this.txtPenaltyCode.ToolTip = "Enter Cheque Number";
            // 
            // labelControl14
            // 
            this.labelControl14.Appearance.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl14.Location = new System.Drawing.Point(15, 18);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(82, 17);
            this.labelControl14.TabIndex = 109;
            this.labelControl14.Text = "Penalty Code";
            // 
            // FormPenaltyMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(478, 125);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPenaltyMaster";
            this.Text = "Penalty Master";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPenaltyName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPenaltyCode.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtPenaltyName;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtDescription;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtPenaltyCode;
        private DevExpress.XtraEditors.LabelControl labelControl14;

    }
}
