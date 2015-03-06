namespace LoomsManagement.Windows.Forms.Master
{
    partial class frmWithdrawnMaster
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWithdrawnMaster));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtWithdrawnAmount = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.comboEmployeeName = new DevExpress.XtraEditors.LookUpEdit();
            this.date_WithdrawnDate = new DevExpress.XtraEditors.DateEdit();
            this.dateReturnDate = new DevExpress.XtraEditors.DateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtWithdrawnAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboEmployeeName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_WithdrawnDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_WithdrawnDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateReturnDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateReturnDate.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.dateReturnDate);
            this.groupControl1.Controls.Add(this.date_WithdrawnDate);
            this.groupControl1.Controls.Add(this.comboEmployeeName);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txtWithdrawnAmount);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.labelControl14);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(377, 176);
            this.groupControl1.TabIndex = 102;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(12, 101);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(126, 17);
            this.labelControl2.TabIndex = 105;
            this.labelControl2.Text = "Withdrawn Amount";
            this.labelControl2.Click += new System.EventHandler(this.labelControl2_Click);
            // 
            // txtWithdrawnAmount
            // 
            this.txtWithdrawnAmount.EditValue = "";
            this.txtWithdrawnAmount.Location = new System.Drawing.Point(146, 97);
            this.txtWithdrawnAmount.Name = "txtWithdrawnAmount";
            this.txtWithdrawnAmount.Properties.Appearance.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWithdrawnAmount.Properties.Appearance.Options.UseFont = true;
            this.txtWithdrawnAmount.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.txtWithdrawnAmount.Properties.Mask.EditMask = "n2";
            this.txtWithdrawnAmount.Size = new System.Drawing.Size(205, 26);
            this.txtWithdrawnAmount.TabIndex = 2;
            this.txtWithdrawnAmount.ToolTip = "Enter Cheque Number";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(12, 69);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(104, 17);
            this.labelControl1.TabIndex = 103;
            this.labelControl1.Text = "Withdrawn Date";
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
            this.panelControl1.Location = new System.Drawing.Point(12, 194);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(377, 54);
            this.panelControl1.TabIndex = 101;
            // 
            // btnSave
            // 
            this.btnSave.Appearance.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(80, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(86, 31);
            this.btnSave.TabIndex = 4;
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
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "&Cancel";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(12, 133);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(75, 17);
            this.labelControl3.TabIndex = 107;
            this.labelControl3.Text = "Return Date";
            // 
            // comboEmployeeName
            // 
            this.comboEmployeeName.Location = new System.Drawing.Point(146, 33);
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
            // date_WithdrawnDate
            // 
            this.date_WithdrawnDate.EditValue = null;
            this.date_WithdrawnDate.Location = new System.Drawing.Point(146, 65);
            this.date_WithdrawnDate.Name = "date_WithdrawnDate";
            this.date_WithdrawnDate.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.date_WithdrawnDate.Properties.Appearance.Options.UseFont = true;
            this.date_WithdrawnDate.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.date_WithdrawnDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date_WithdrawnDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.date_WithdrawnDate.Size = new System.Drawing.Size(205, 26);
            this.date_WithdrawnDate.TabIndex = 1;
            this.date_WithdrawnDate.ToolTip = "Select Date.";
            // 
            // dateReturnDate
            // 
            this.dateReturnDate.EditValue = null;
            this.dateReturnDate.Location = new System.Drawing.Point(146, 129);
            this.dateReturnDate.Name = "dateReturnDate";
            this.dateReturnDate.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.dateReturnDate.Properties.Appearance.Options.UseFont = true;
            this.dateReturnDate.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.dateReturnDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateReturnDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateReturnDate.Size = new System.Drawing.Size(205, 26);
            this.dateReturnDate.TabIndex = 3;
            this.dateReturnDate.ToolTip = "Select Date.";
            // 
            // frmWithdrawnMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 259);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmWithdrawnMaster";
            this.Text = "Withdrawn Master";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtWithdrawnAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.comboEmployeeName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_WithdrawnDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_WithdrawnDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateReturnDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateReturnDate.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtWithdrawnAmount;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        public DevExpress.XtraEditors.SimpleButton btnSave;
        public DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.LookUpEdit comboEmployeeName;
        private DevExpress.XtraEditors.DateEdit date_WithdrawnDate;
        private DevExpress.XtraEditors.DateEdit dateReturnDate;
    }
}