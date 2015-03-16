namespace LoomsManagement.Windows.Forms.Master
{
    partial class frmBankBranchMaster
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
            this.txtBranchName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.cmbBankName = new DevExpress.XtraEditors.LookUpEdit();
            this.errorBankName = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider();
            this.txtAddress = new DevExpress.XtraEditors.MemoEdit();
            this.errorBranchName = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider();
            this.errorAddress = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBranchName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbBankName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorBankName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorBranchName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorAddress)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Location = new System.Drawing.Point(376, 0);
            this.panelControl1.Size = new System.Drawing.Size(127, 185);
            // 
            // btnReport
            // 
            this.btnReport.Appearance.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.Appearance.Options.UseFont = true;
            this.btnReport.TabIndex = 6;
            // 
            // btnExit
            // 
            this.btnExit.Appearance.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Appearance.Options.UseFont = true;
            this.btnExit.TabIndex = 5;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Appearance.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.TabIndex = 3;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btndelete
            // 
            this.btndelete.Appearance.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.Appearance.Options.UseFont = true;
            this.btndelete.TabIndex = 4;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelControl5);
            this.panel1.Controls.Add(this.labelControl4);
            this.panel1.Controls.Add(this.labelControl3);
            this.panel1.Controls.Add(this.txtAddress);
            this.panel1.Controls.Add(this.cmbBankName);
            this.panel1.Controls.Add(this.labelControl2);
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Controls.Add(this.txtBranchName);
            this.panel1.Controls.Add(this.labelControl14);
            this.panel1.Size = new System.Drawing.Size(376, 185);
            // 
            // txtBranchName
            // 
            this.txtBranchName.EditValue = "";
            this.errorAddress.SetIconAlignment(this.txtBranchName, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.errorBankName.SetIconAlignment(this.txtBranchName, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.errorBranchName.SetIconAlignment(this.txtBranchName, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.txtBranchName.Location = new System.Drawing.Point(121, 46);
            this.txtBranchName.Name = "txtBranchName";
            this.txtBranchName.Properties.Appearance.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBranchName.Properties.Appearance.Options.UseFont = true;
            this.txtBranchName.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.txtBranchName.Properties.Mask.EditMask = "n2";
            this.txtBranchName.Size = new System.Drawing.Size(205, 26);
            this.txtBranchName.TabIndex = 1;
            this.txtBranchName.ToolTip = "Enter Cheque Number";
            this.txtBranchName.Enter += new System.EventHandler(this.EnterEvent);
            this.txtBranchName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txtBranchName.Leave += new System.EventHandler(this.LeaveEvent);
            // 
            // labelControl14
            // 
            this.labelControl14.Appearance.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl14.Location = new System.Drawing.Point(15, 19);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(71, 17);
            this.labelControl14.TabIndex = 111;
            this.labelControl14.Text = "Bank Name";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(15, 48);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(84, 17);
            this.labelControl1.TabIndex = 112;
            this.labelControl1.Text = "Branch Name";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(15, 82);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(50, 17);
            this.labelControl2.TabIndex = 113;
            this.labelControl2.Text = "Address";
            // 
            // cmbBankName
            // 
            this.errorAddress.SetIconAlignment(this.cmbBankName, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.errorBankName.SetIconAlignment(this.cmbBankName, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.errorBranchName.SetIconAlignment(this.cmbBankName, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.cmbBankName.Location = new System.Drawing.Point(121, 14);
            this.cmbBankName.Name = "cmbBankName";
            this.cmbBankName.Properties.Appearance.Font = new System.Drawing.Font("Cambria", 11.25F);
            this.cmbBankName.Properties.Appearance.Options.UseFont = true;
            this.cmbBankName.Properties.AppearanceDisabled.Font = new System.Drawing.Font("Cambria", 11.25F);
            this.cmbBankName.Properties.AppearanceDisabled.Options.UseFont = true;
            this.cmbBankName.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Cambria", 11.25F);
            this.cmbBankName.Properties.AppearanceDropDown.Options.UseFont = true;
            this.cmbBankName.Properties.AppearanceDropDownHeader.Font = new System.Drawing.Font("Cambria", 11.25F);
            this.cmbBankName.Properties.AppearanceDropDownHeader.Options.UseFont = true;
            this.cmbBankName.Properties.AppearanceFocused.Font = new System.Drawing.Font("Cambria", 11.25F);
            this.cmbBankName.Properties.AppearanceFocused.Options.UseFont = true;
            this.cmbBankName.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("Cambria", 11.25F);
            this.cmbBankName.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.cmbBankName.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmbBankName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbBankName.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BankID", "BankID", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BankName", " Bank Name")});
            this.cmbBankName.Properties.NullText = "";
            this.cmbBankName.Size = new System.Drawing.Size(205, 26);
            this.cmbBankName.TabIndex = 0;
            this.cmbBankName.ToolTip = "Select Bank Name.";
            this.cmbBankName.Enter += new System.EventHandler(this.EnterEvent);
            this.cmbBankName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.cmbBankName.Leave += new System.EventHandler(this.LeaveEvent);
            // 
            // errorBankName
            // 
            this.errorBankName.ContainerControl = this;
            // 
            // txtAddress
            // 
            this.errorAddress.SetIconAlignment(this.txtAddress, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.errorBankName.SetIconAlignment(this.txtAddress, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.errorBranchName.SetIconAlignment(this.txtAddress, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.txtAddress.Location = new System.Drawing.Point(121, 79);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(205, 90);
            this.txtAddress.TabIndex = 2;
            this.txtAddress.Enter += new System.EventHandler(this.EnterEvent);
            this.txtAddress.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txtAddress.Leave += new System.EventHandler(this.LeaveEvent);
            // 
            // errorBranchName
            // 
            this.errorBranchName.ContainerControl = this;
            // 
            // errorAddress
            // 
            this.errorAddress.ContainerControl = this;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl3.Location = new System.Drawing.Point(109, 82);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(6, 17);
            this.labelControl3.TabIndex = 169;
            this.labelControl3.Text = "*";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl4.Location = new System.Drawing.Point(109, 48);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(6, 17);
            this.labelControl4.TabIndex = 170;
            this.labelControl4.Text = "*";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl5.Location = new System.Drawing.Point(109, 12);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(6, 17);
            this.labelControl5.TabIndex = 171;
            this.labelControl5.Text = "*";
            // 
            // frmBankBranchMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(503, 185);
            this.Name = "frmBankBranchMaster";
            this.ShowInTaskbar = false;
            this.Text = "Bank Branch Master";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmBankBranchMaster_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBranchName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbBankName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorBankName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorBranchName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorAddress)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtBranchName;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LookUpEdit cmbBankName;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider errorBankName;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider errorBranchName;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider errorAddress;
        private DevExpress.XtraEditors.MemoEdit txtAddress;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
    }
}
