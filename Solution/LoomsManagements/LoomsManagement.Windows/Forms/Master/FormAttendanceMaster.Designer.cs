namespace LoomsManagement.Windows.Forms.Master
{
    partial class FormAttendanceMaster
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAttendanceMaster));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.dateStartDate = new DevExpress.XtraEditors.DateEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.dateEndDate = new DevExpress.XtraEditors.DateEdit();
            this.comboEmployeeName = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtMeterWorked = new DevExpress.XtraEditors.TextEdit();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.errorEmployeeName = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.errorStartDate = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.errorEndDate = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.errorMeterWorked = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateStartDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateStartDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEndDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEndDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboEmployeeName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMeterWorked.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorEmployeeName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorStartDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorEndDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorMeterWorked)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReport
            // 
            this.btnReport.Appearance.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.Appearance.Options.UseFont = true;
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
            this.panel1.Controls.Add(this.groupControl1);
            this.panel1.Controls.Add(this.panelControl2);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.dateStartDate);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.dateEndDate);
            this.groupControl1.Controls.Add(this.comboEmployeeName);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txtMeterWorked);
            this.groupControl1.Controls.Add(this.labelControl14);
            this.groupControl1.Location = new System.Drawing.Point(3, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(365, 160);
            this.groupControl1.TabIndex = 108;
            // 
            // dateStartDate
            // 
            this.dateStartDate.EditValue = null;
            this.errorStartDate.SetIconAlignment(this.dateStartDate, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.errorMeterWorked.SetIconAlignment(this.dateStartDate, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.errorEmployeeName.SetIconAlignment(this.dateStartDate, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.errorEndDate.SetIconAlignment(this.dateStartDate, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.dateStartDate.Location = new System.Drawing.Point(126, 63);
            this.dateStartDate.Name = "dateStartDate";
            this.dateStartDate.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.dateStartDate.Properties.Appearance.Options.UseFont = true;
            this.dateStartDate.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.dateStartDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateStartDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateStartDate.Size = new System.Drawing.Size(205, 26);
            this.dateStartDate.TabIndex = 1;
            this.dateStartDate.ToolTip = "Select Date.";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Location = new System.Drawing.Point(12, 97);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(57, 17);
            this.labelControl4.TabIndex = 108;
            this.labelControl4.Text = "End Date";
            // 
            // dateEndDate
            // 
            this.dateEndDate.EditValue = null;
            this.errorStartDate.SetIconAlignment(this.dateEndDate, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.errorMeterWorked.SetIconAlignment(this.dateEndDate, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.errorEmployeeName.SetIconAlignment(this.dateEndDate, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.errorEndDate.SetIconAlignment(this.dateEndDate, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.dateEndDate.Location = new System.Drawing.Point(126, 92);
            this.dateEndDate.Name = "dateEndDate";
            this.dateEndDate.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.dateEndDate.Properties.Appearance.Options.UseFont = true;
            this.dateEndDate.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.dateEndDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEndDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateEndDate.Size = new System.Drawing.Size(205, 26);
            this.dateEndDate.TabIndex = 2;
            this.dateEndDate.ToolTip = "Select Date.";
            // 
            // comboEmployeeName
            // 
            this.errorEmployeeName.SetIconAlignment(this.comboEmployeeName, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.errorStartDate.SetIconAlignment(this.comboEmployeeName, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.errorEndDate.SetIconAlignment(this.comboEmployeeName, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.errorMeterWorked.SetIconAlignment(this.comboEmployeeName, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.comboEmployeeName.Location = new System.Drawing.Point(126, 33);
            this.comboEmployeeName.Name = "comboEmployeeName";
            this.comboEmployeeName.Properties.Appearance.Font = new System.Drawing.Font("Cambria", 11.25F);
            this.comboEmployeeName.Properties.Appearance.Options.UseFont = true;
            this.comboEmployeeName.Properties.AppearanceDisabled.Font = new System.Drawing.Font("Cambria", 11.25F);
            this.comboEmployeeName.Properties.AppearanceDisabled.Options.UseFont = true;
            this.comboEmployeeName.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Cambria", 11.25F);
            this.comboEmployeeName.Properties.AppearanceDropDown.Options.UseFont = true;
            this.comboEmployeeName.Properties.AppearanceDropDownHeader.Font = new System.Drawing.Font("Cambria", 11.25F);
            this.comboEmployeeName.Properties.AppearanceDropDownHeader.Options.UseFont = true;
            this.comboEmployeeName.Properties.AppearanceFocused.Font = new System.Drawing.Font("Cambria", 11.25F);
            this.comboEmployeeName.Properties.AppearanceFocused.Options.UseFont = true;
            this.comboEmployeeName.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("Cambria", 11.25F);
            this.comboEmployeeName.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.comboEmployeeName.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.comboEmployeeName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboEmployeeName.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BackID", "ID", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BankName", "Bank Name"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("AccountNo", "Account No")});
            this.comboEmployeeName.Properties.NullText = "";
            this.comboEmployeeName.Size = new System.Drawing.Size(205, 26);
            this.comboEmployeeName.TabIndex = 0;
            this.comboEmployeeName.ToolTip = "Select Bank Name.";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(12, 126);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(91, 17);
            this.labelControl3.TabIndex = 107;
            this.labelControl3.Text = "Meter Worked";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(12, 68);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(62, 17);
            this.labelControl2.TabIndex = 105;
            this.labelControl2.Text = "Start Date";
            // 
            // txtMeterWorked
            // 
            this.txtMeterWorked.EditValue = "";
            this.errorEndDate.SetIconAlignment(this.txtMeterWorked, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.errorEmployeeName.SetIconAlignment(this.txtMeterWorked, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.errorStartDate.SetIconAlignment(this.txtMeterWorked, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.errorMeterWorked.SetIconAlignment(this.txtMeterWorked, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.txtMeterWorked.Location = new System.Drawing.Point(126, 122);
            this.txtMeterWorked.Name = "txtMeterWorked";
            this.txtMeterWorked.Properties.Appearance.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMeterWorked.Properties.Appearance.Options.UseFont = true;
            this.txtMeterWorked.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.txtMeterWorked.Properties.Mask.EditMask = "n2";
            this.txtMeterWorked.Size = new System.Drawing.Size(205, 26);
            this.txtMeterWorked.TabIndex = 3;
            this.txtMeterWorked.ToolTip = "Enter Cheque Number";
            // 
            // labelControl14
            // 
            this.labelControl14.Appearance.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl14.Location = new System.Drawing.Point(12, 37);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(102, 17);
            this.labelControl14.TabIndex = 101;
            this.labelControl14.Text = "Employee Name";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(153, 8);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(86, 31);
            this.simpleButton1.TabIndex = 4;
            this.simpleButton1.Text = "&Save";
            // 
            // btnCancel
            // 
            this.btnCancel.Appearance.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Appearance.Options.UseFont = true;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(245, 8);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(86, 31);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "&Cancel";
            // 
            // errorEmployeeName
            // 
            this.errorEmployeeName.ContainerControl = this;
            // 
            // errorStartDate
            // 
            this.errorStartDate.ContainerControl = this;
            // 
            // errorEndDate
            // 
            this.errorEndDate.ContainerControl = this;
            // 
            // errorMeterWorked
            // 
            this.errorMeterWorked.ContainerControl = this;
            // 
            // panelControl2
            // 
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.panelControl2.Controls.Add(this.simpleButton1);
            this.panelControl2.Controls.Add(this.btnCancel);
            this.panelControl2.Location = new System.Drawing.Point(3, 170);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(365, 48);
            this.panelControl2.TabIndex = 107;
            // 
            // FormAttendanceMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(681, 356);
            this.Name = "FormAttendanceMaster";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateStartDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateStartDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEndDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEndDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboEmployeeName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMeterWorked.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorEmployeeName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorStartDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorEndDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorMeterWorked)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.DateEdit dateStartDate;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider errorStartDate;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider errorMeterWorked;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider errorEmployeeName;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider errorEndDate;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.DateEdit dateEndDate;
        private DevExpress.XtraEditors.LookUpEdit comboEmployeeName;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtMeterWorked;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        public DevExpress.XtraEditors.SimpleButton simpleButton1;
        public DevExpress.XtraEditors.SimpleButton btnCancel;
    }
}
