namespace LoomsManagement.Windows.Forms.Master
{
    partial class frmSalaryMaster
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSalaryMaster));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.dateEndDate = new DevExpress.XtraEditors.DateEdit();
            this.dateSalaryDate = new DevExpress.XtraEditors.DateEdit();
            this.comboEmployeeName = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtWorkHour = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.dateStartDate = new DevExpress.XtraEditors.DateEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.comboWithdrawnID = new DevExpress.XtraEditors.LookUpEdit();
            this.txtTotalPenalty = new DevExpress.XtraEditors.TextEdit();
            this.txtBonus = new DevExpress.XtraEditors.TextEdit();
            this.txtWithdrawnAmount = new DevExpress.XtraEditors.TextEdit();
            this.txtNetSalary = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEndDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEndDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateSalaryDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateSalaryDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboEmployeeName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWorkHour.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateStartDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateStartDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboWithdrawnID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalPenalty.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBonus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWithdrawnAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNetSalary.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtNetSalary);
            this.groupControl1.Controls.Add(this.txtWithdrawnAmount);
            this.groupControl1.Controls.Add(this.txtBonus);
            this.groupControl1.Controls.Add(this.txtTotalPenalty);
            this.groupControl1.Controls.Add(this.comboWithdrawnID);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.dateStartDate);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.dateEndDate);
            this.groupControl1.Controls.Add(this.dateSalaryDate);
            this.groupControl1.Controls.Add(this.comboEmployeeName);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txtWorkHour);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.labelControl14);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(389, 379);
            this.groupControl1.TabIndex = 104;
            // 
            // dateEndDate
            // 
            this.dateEndDate.EditValue = null;
            this.dateEndDate.Location = new System.Drawing.Point(155, 129);
            this.dateEndDate.Name = "dateEndDate";
            this.dateEndDate.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.dateEndDate.Properties.Appearance.Options.UseFont = true;
            this.dateEndDate.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.dateEndDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEndDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateEndDate.Size = new System.Drawing.Size(205, 26);
            this.dateEndDate.TabIndex = 3;
            this.dateEndDate.ToolTip = "Select Date.";
            // 
            // dateSalaryDate
            // 
            this.dateSalaryDate.EditValue = null;
            this.dateSalaryDate.Location = new System.Drawing.Point(155, 65);
            this.dateSalaryDate.Name = "dateSalaryDate";
            this.dateSalaryDate.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.dateSalaryDate.Properties.Appearance.Options.UseFont = true;
            this.dateSalaryDate.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.dateSalaryDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateSalaryDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateSalaryDate.Size = new System.Drawing.Size(205, 26);
            this.dateSalaryDate.TabIndex = 1;
            this.dateSalaryDate.ToolTip = "Select Date.";
            // 
            // comboEmployeeName
            // 
            this.comboEmployeeName.Location = new System.Drawing.Point(155, 33);
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
            this.labelControl3.Location = new System.Drawing.Point(12, 166);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(71, 17);
            this.labelControl3.TabIndex = 107;
            this.labelControl3.Text = "Work Hour";
            this.labelControl3.Click += new System.EventHandler(this.labelControl3_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(12, 101);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(62, 17);
            this.labelControl2.TabIndex = 105;
            this.labelControl2.Text = "Start Date";
            // 
            // txtWorkHour
            // 
            this.txtWorkHour.EditValue = "";
            this.txtWorkHour.Location = new System.Drawing.Point(155, 162);
            this.txtWorkHour.Name = "txtWorkHour";
            this.txtWorkHour.Properties.Appearance.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWorkHour.Properties.Appearance.Options.UseFont = true;
            this.txtWorkHour.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.txtWorkHour.Properties.Mask.EditMask = "n2";
            this.txtWorkHour.Size = new System.Drawing.Size(205, 26);
            this.txtWorkHour.TabIndex = 4;
            this.txtWorkHour.ToolTip = "Enter Cheque Number";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(12, 69);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(29, 17);
            this.labelControl1.TabIndex = 103;
            this.labelControl1.Text = "Date";
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
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnSave);
            this.panelControl1.Controls.Add(this.btnCancel);
            this.panelControl1.Location = new System.Drawing.Point(12, 397);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(389, 54);
            this.panelControl1.TabIndex = 103;
            // 
            // btnSave
            // 
            this.btnSave.Appearance.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(80, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(86, 31);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "&Save";
            // 
            // btnCancel
            // 
            this.btnCancel.Appearance.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Appearance.Options.UseFont = true;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(172, 12);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(86, 31);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "&Cancel";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Location = new System.Drawing.Point(12, 134);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(57, 17);
            this.labelControl4.TabIndex = 108;
            this.labelControl4.Text = "End Date";
            // 
            // dateStartDate
            // 
            this.dateStartDate.EditValue = null;
            this.dateStartDate.Location = new System.Drawing.Point(155, 96);
            this.dateStartDate.Name = "dateStartDate";
            this.dateStartDate.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.dateStartDate.Properties.Appearance.Options.UseFont = true;
            this.dateStartDate.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.dateStartDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateStartDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateStartDate.Size = new System.Drawing.Size(205, 26);
            this.dateStartDate.TabIndex = 2;
            this.dateStartDate.ToolTip = "Select Date.";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Location = new System.Drawing.Point(12, 296);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(126, 17);
            this.labelControl5.TabIndex = 114;
            this.labelControl5.Text = "Withdrawn Amount";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Location = new System.Drawing.Point(12, 328);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(64, 17);
            this.labelControl6.TabIndex = 113;
            this.labelControl6.Text = "Net Salary";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Location = new System.Drawing.Point(12, 263);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(90, 17);
            this.labelControl7.TabIndex = 112;
            this.labelControl7.Text = "Withdrawn ID";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Location = new System.Drawing.Point(12, 231);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(39, 17);
            this.labelControl8.TabIndex = 111;
            this.labelControl8.Text = "Bonus";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Location = new System.Drawing.Point(12, 199);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(84, 17);
            this.labelControl9.TabIndex = 110;
            this.labelControl9.Text = "Total Penalty";
            // 
            // comboWithdrawnID
            // 
            this.comboWithdrawnID.Location = new System.Drawing.Point(155, 259);
            this.comboWithdrawnID.Name = "comboWithdrawnID";
            this.comboWithdrawnID.Properties.Appearance.Font = new System.Drawing.Font("Cambria", 11.25F);
            this.comboWithdrawnID.Properties.Appearance.Options.UseFont = true;
            this.comboWithdrawnID.Properties.AppearanceDisabled.Font = new System.Drawing.Font("Cambria", 11.25F);
            this.comboWithdrawnID.Properties.AppearanceDisabled.Options.UseFont = true;
            this.comboWithdrawnID.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Cambria", 11.25F);
            this.comboWithdrawnID.Properties.AppearanceDropDown.Options.UseFont = true;
            this.comboWithdrawnID.Properties.AppearanceDropDownHeader.Font = new System.Drawing.Font("Cambria", 11.25F);
            this.comboWithdrawnID.Properties.AppearanceDropDownHeader.Options.UseFont = true;
            this.comboWithdrawnID.Properties.AppearanceFocused.Font = new System.Drawing.Font("Cambria", 11.25F);
            this.comboWithdrawnID.Properties.AppearanceFocused.Options.UseFont = true;
            this.comboWithdrawnID.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("Cambria", 11.25F);
            this.comboWithdrawnID.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.comboWithdrawnID.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.comboWithdrawnID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboWithdrawnID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BackID", "ID", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BankName", "Bank Name"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("AccountNo", "Account No")});
            this.comboWithdrawnID.Properties.NullText = "";
            this.comboWithdrawnID.Size = new System.Drawing.Size(205, 26);
            this.comboWithdrawnID.TabIndex = 7;
            this.comboWithdrawnID.ToolTip = "Select Bank Name.";
            // 
            // txtTotalPenalty
            // 
            this.txtTotalPenalty.EditValue = "";
            this.txtTotalPenalty.Location = new System.Drawing.Point(155, 195);
            this.txtTotalPenalty.Name = "txtTotalPenalty";
            this.txtTotalPenalty.Properties.Appearance.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPenalty.Properties.Appearance.Options.UseFont = true;
            this.txtTotalPenalty.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.txtTotalPenalty.Properties.Mask.EditMask = "n2";
            this.txtTotalPenalty.Size = new System.Drawing.Size(205, 26);
            this.txtTotalPenalty.TabIndex = 5;
            this.txtTotalPenalty.ToolTip = "Enter Cheque Number";
            // 
            // txtBonus
            // 
            this.txtBonus.EditValue = "";
            this.txtBonus.Location = new System.Drawing.Point(155, 227);
            this.txtBonus.Name = "txtBonus";
            this.txtBonus.Properties.Appearance.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBonus.Properties.Appearance.Options.UseFont = true;
            this.txtBonus.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.txtBonus.Properties.Mask.EditMask = "n2";
            this.txtBonus.Size = new System.Drawing.Size(205, 26);
            this.txtBonus.TabIndex = 6;
            this.txtBonus.ToolTip = "Enter Cheque Number";
            // 
            // txtWithdrawnAmount
            // 
            this.txtWithdrawnAmount.EditValue = "";
            this.txtWithdrawnAmount.Location = new System.Drawing.Point(155, 292);
            this.txtWithdrawnAmount.Name = "txtWithdrawnAmount";
            this.txtWithdrawnAmount.Properties.Appearance.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWithdrawnAmount.Properties.Appearance.Options.UseFont = true;
            this.txtWithdrawnAmount.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.txtWithdrawnAmount.Properties.Mask.EditMask = "n2";
            this.txtWithdrawnAmount.Size = new System.Drawing.Size(205, 26);
            this.txtWithdrawnAmount.TabIndex = 8;
            this.txtWithdrawnAmount.ToolTip = "Enter Cheque Number";
            // 
            // txtNetSalary
            // 
            this.txtNetSalary.EditValue = "";
            this.txtNetSalary.Location = new System.Drawing.Point(155, 324);
            this.txtNetSalary.Name = "txtNetSalary";
            this.txtNetSalary.Properties.Appearance.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNetSalary.Properties.Appearance.Options.UseFont = true;
            this.txtNetSalary.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.txtNetSalary.Properties.Mask.EditMask = "n2";
            this.txtNetSalary.Size = new System.Drawing.Size(205, 26);
            this.txtNetSalary.TabIndex = 9;
            this.txtNetSalary.ToolTip = "Enter Cheque Number";
            // 
            // frmSalaryMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 460);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmSalaryMaster";
            this.Text = "Salary Master";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEndDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEndDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateSalaryDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateSalaryDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboEmployeeName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWorkHour.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dateStartDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateStartDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboWithdrawnID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalPenalty.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBonus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWithdrawnAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNetSalary.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.DateEdit dateEndDate;
        private DevExpress.XtraEditors.DateEdit dateSalaryDate;
        private DevExpress.XtraEditors.LookUpEdit comboEmployeeName;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtWorkHour;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        public DevExpress.XtraEditors.SimpleButton btnSave;
        public DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.DateEdit dateStartDate;
        private DevExpress.XtraEditors.TextEdit txtNetSalary;
        private DevExpress.XtraEditors.TextEdit txtWithdrawnAmount;
        private DevExpress.XtraEditors.TextEdit txtBonus;
        private DevExpress.XtraEditors.TextEdit txtTotalPenalty;
        private DevExpress.XtraEditors.LookUpEdit comboWithdrawnID;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl9;
    }
}