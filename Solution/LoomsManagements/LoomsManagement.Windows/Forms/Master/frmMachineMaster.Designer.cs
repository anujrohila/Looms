namespace LoomsManagement.Windows.Forms.Master
{
    partial class frmMachineMaster
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
            this.components = new System.ComponentModel.Container();
            this.txtDescription = new DevExpress.XtraEditors.MemoEdit();
            this.cmbMachineType = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtMachineName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.errorMachineType = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.errorMachineName = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMachineType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMachineName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorMachineType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorMachineName)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Location = new System.Drawing.Point(370, 0);
            this.panelControl1.Size = new System.Drawing.Size(127, 188);
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
            this.panel1.Controls.Add(this.labelControl4);
            this.panel1.Controls.Add(this.labelControl3);
            this.panel1.Controls.Add(this.cmbMachineType);
            this.panel1.Controls.Add(this.labelControl2);
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Controls.Add(this.txtMachineName);
            this.panel1.Controls.Add(this.labelControl14);
            this.panel1.Controls.Add(this.txtDescription);
            this.panel1.Size = new System.Drawing.Size(370, 188);
            // 
            // txtDescription
            // 
            this.errorMachineType.SetIconAlignment(this.txtDescription, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.errorMachineName.SetIconAlignment(this.txtDescription, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.txtDescription.Location = new System.Drawing.Point(125, 81);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(205, 90);
            this.txtDescription.TabIndex = 2;
            this.txtDescription.Enter += new System.EventHandler(this.EnterEvent);
            this.txtDescription.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txtDescription.Leave += new System.EventHandler(this.LeaveEvent);
            // 
            // cmbMachineType
            // 
            this.errorMachineType.SetIconAlignment(this.cmbMachineType, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.errorMachineName.SetIconAlignment(this.cmbMachineType, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.cmbMachineType.Location = new System.Drawing.Point(125, 17);
            this.cmbMachineType.Name = "cmbMachineType";
            this.cmbMachineType.Properties.Appearance.Font = new System.Drawing.Font("Cambria", 11.25F);
            this.cmbMachineType.Properties.Appearance.Options.UseFont = true;
            this.cmbMachineType.Properties.AppearanceDisabled.Font = new System.Drawing.Font("Cambria", 11.25F);
            this.cmbMachineType.Properties.AppearanceDisabled.Options.UseFont = true;
            this.cmbMachineType.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Cambria", 11.25F);
            this.cmbMachineType.Properties.AppearanceDropDown.Options.UseFont = true;
            this.cmbMachineType.Properties.AppearanceDropDownHeader.Font = new System.Drawing.Font("Cambria", 11.25F);
            this.cmbMachineType.Properties.AppearanceDropDownHeader.Options.UseFont = true;
            this.cmbMachineType.Properties.AppearanceFocused.Font = new System.Drawing.Font("Cambria", 11.25F);
            this.cmbMachineType.Properties.AppearanceFocused.Options.UseFont = true;
            this.cmbMachineType.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("Cambria", 11.25F);
            this.cmbMachineType.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.cmbMachineType.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmbMachineType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbMachineType.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MachineTypeID", "MachineTypeID", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TypeName", "Machine Type Name")});
            this.cmbMachineType.Properties.NullText = "";
            this.cmbMachineType.Size = new System.Drawing.Size(205, 26);
            this.cmbMachineType.TabIndex = 0;
            this.cmbMachineType.ToolTip = "Select Machine Type";
            this.cmbMachineType.Enter += new System.EventHandler(this.EnterEvent);
            this.cmbMachineType.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.cmbMachineType.Leave += new System.EventHandler(this.LeaveEvent);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(17, 86);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(73, 17);
            this.labelControl2.TabIndex = 172;
            this.labelControl2.Text = "Description";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(17, 53);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(92, 17);
            this.labelControl1.TabIndex = 171;
            this.labelControl1.Text = "Machine Name";
            // 
            // txtMachineName
            // 
            this.txtMachineName.EditValue = "";
            this.errorMachineName.SetIconAlignment(this.txtMachineName, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.errorMachineType.SetIconAlignment(this.txtMachineName, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.txtMachineName.Location = new System.Drawing.Point(125, 49);
            this.txtMachineName.Name = "txtMachineName";
            this.txtMachineName.Properties.Appearance.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMachineName.Properties.Appearance.Options.UseFont = true;
            this.txtMachineName.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.txtMachineName.Properties.Mask.EditMask = "n2";
            this.txtMachineName.Size = new System.Drawing.Size(205, 26);
            this.txtMachineName.TabIndex = 1;
            this.txtMachineName.ToolTip = "Enter Cheque Number";
            this.txtMachineName.Enter += new System.EventHandler(this.EnterEvent);
            this.txtMachineName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txtMachineName.Leave += new System.EventHandler(this.LeaveEvent);
            // 
            // labelControl14
            // 
            this.labelControl14.Appearance.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl14.Location = new System.Drawing.Point(17, 19);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(88, 17);
            this.labelControl14.TabIndex = 170;
            this.labelControl14.Text = "Machine Type";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl3.Location = new System.Drawing.Point(115, 17);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(6, 17);
            this.labelControl3.TabIndex = 174;
            this.labelControl3.Text = "*";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl4.Location = new System.Drawing.Point(115, 50);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(6, 17);
            this.labelControl4.TabIndex = 175;
            this.labelControl4.Text = "*";
            // 
            // errorMachineType
            // 
            this.errorMachineType.ContainerControl = this;
            // 
            // errorMachineName
            // 
            this.errorMachineName.ContainerControl = this;
            // 
            // frmMachineMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(497, 188);
            this.Name = "frmMachineMaster";
            this.ShowInTaskbar = false;
            this.Text = "Machine Master";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Page_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMachineType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMachineName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorMachineType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorMachineName)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.MemoEdit txtDescription;
        private DevExpress.XtraEditors.LookUpEdit cmbMachineType;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtMachineName;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider errorMachineType;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider errorMachineName;

    }
}
