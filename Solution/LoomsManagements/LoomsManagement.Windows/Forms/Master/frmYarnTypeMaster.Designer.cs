namespace LoomsManagement.Windows.Forms.Master
{
    partial class frmYarnTypeMaster
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
            this.txtYarnQualityName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.cmbYarnQuality = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtDenier = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtNumberOfFilaments = new DevExpress.XtraEditors.TextEdit();
            this.txtDescription = new DevExpress.XtraEditors.MemoEdit();
            this.errorYarnTypeName = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider();
            this.errorYarnQuality = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider();
            this.errorDenier = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider();
            this.errorNumberOfFilamets = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtYarnQualityName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbYarnQuality.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDenier.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumberOfFilaments.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorYarnTypeName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorYarnQuality)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDenier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNumberOfFilamets)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Location = new System.Drawing.Point(407, 0);
            this.panelControl1.Size = new System.Drawing.Size(127, 246);
            // 
            // btnReport
            // 
            this.btnReport.Appearance.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.Appearance.Options.UseFont = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnExit
            // 
            this.btnExit.Appearance.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Appearance.Options.UseFont = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Appearance.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btndelete
            // 
            this.btndelete.Appearance.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.Appearance.Options.UseFont = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelControl8);
            this.panel1.Controls.Add(this.labelControl7);
            this.panel1.Controls.Add(this.labelControl6);
            this.panel1.Controls.Add(this.labelControl5);
            this.panel1.Controls.Add(this.txtDescription);
            this.panel1.Controls.Add(this.txtNumberOfFilaments);
            this.panel1.Controls.Add(this.labelControl4);
            this.panel1.Controls.Add(this.labelControl3);
            this.panel1.Controls.Add(this.txtDenier);
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Controls.Add(this.cmbYarnQuality);
            this.panel1.Controls.Add(this.txtYarnQualityName);
            this.panel1.Controls.Add(this.labelControl2);
            this.panel1.Controls.Add(this.labelControl14);
            this.panel1.Size = new System.Drawing.Size(407, 246);
            // 
            // txtYarnQualityName
            // 
            this.txtYarnQualityName.EditValue = "";
            this.errorDenier.SetIconAlignment(this.txtYarnQualityName, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.errorYarnTypeName.SetIconAlignment(this.txtYarnQualityName, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.errorYarnQuality.SetIconAlignment(this.txtYarnQualityName, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.errorNumberOfFilamets.SetIconAlignment(this.txtYarnQualityName, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.txtYarnQualityName.Location = new System.Drawing.Point(167, 12);
            this.txtYarnQualityName.Name = "txtYarnQualityName";
            this.txtYarnQualityName.Properties.Appearance.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYarnQualityName.Properties.Appearance.Options.UseFont = true;
            this.txtYarnQualityName.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.txtYarnQualityName.Properties.Mask.EditMask = "n2";
            this.txtYarnQualityName.Size = new System.Drawing.Size(205, 26);
            this.txtYarnQualityName.TabIndex = 110;
            this.txtYarnQualityName.Enter += new System.EventHandler(this.EnterEvent);
            this.txtYarnQualityName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txtYarnQualityName.Leave += new System.EventHandler(this.LeaveEvent);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(20, 144);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(73, 17);
            this.labelControl2.TabIndex = 113;
            this.labelControl2.Text = "Description";
            // 
            // labelControl14
            // 
            this.labelControl14.Appearance.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl14.Location = new System.Drawing.Point(20, 16);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(104, 17);
            this.labelControl14.TabIndex = 112;
            this.labelControl14.Text = "Yarn Type Name";
            // 
            // cmbYarnQuality
            // 
            this.errorYarnTypeName.SetIconAlignment(this.cmbYarnQuality, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.errorYarnQuality.SetIconAlignment(this.cmbYarnQuality, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.errorDenier.SetIconAlignment(this.cmbYarnQuality, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.errorNumberOfFilamets.SetIconAlignment(this.cmbYarnQuality, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.cmbYarnQuality.Location = new System.Drawing.Point(167, 44);
            this.cmbYarnQuality.Name = "cmbYarnQuality";
            this.cmbYarnQuality.Properties.Appearance.Font = new System.Drawing.Font("Cambria", 11.25F);
            this.cmbYarnQuality.Properties.Appearance.Options.UseFont = true;
            this.cmbYarnQuality.Properties.AppearanceDisabled.Font = new System.Drawing.Font("Cambria", 11.25F);
            this.cmbYarnQuality.Properties.AppearanceDisabled.Options.UseFont = true;
            this.cmbYarnQuality.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Cambria", 11.25F);
            this.cmbYarnQuality.Properties.AppearanceDropDown.Options.UseFont = true;
            this.cmbYarnQuality.Properties.AppearanceDropDownHeader.Font = new System.Drawing.Font("Cambria", 11.25F);
            this.cmbYarnQuality.Properties.AppearanceDropDownHeader.Options.UseFont = true;
            this.cmbYarnQuality.Properties.AppearanceFocused.Font = new System.Drawing.Font("Cambria", 11.25F);
            this.cmbYarnQuality.Properties.AppearanceFocused.Options.UseFont = true;
            this.cmbYarnQuality.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("Cambria", 11.25F);
            this.cmbYarnQuality.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.cmbYarnQuality.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmbYarnQuality.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbYarnQuality.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("YarnQualityID", "Yarn Quality ID", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("YarnQualityName", 50, "Yarn Quality Name")});
            this.cmbYarnQuality.Properties.NullText = "";
            this.cmbYarnQuality.Size = new System.Drawing.Size(205, 26);
            this.cmbYarnQuality.TabIndex = 160;
            this.cmbYarnQuality.Enter += new System.EventHandler(this.EnterEvent);
            this.cmbYarnQuality.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.cmbYarnQuality.Leave += new System.EventHandler(this.LeaveEvent);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(20, 48);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(79, 17);
            this.labelControl1.TabIndex = 161;
            this.labelControl1.Text = "Yarn Quality";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(20, 79);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(42, 17);
            this.labelControl3.TabIndex = 163;
            this.labelControl3.Text = "Denier";
            // 
            // txtDenier
            // 
            this.txtDenier.EditValue = "";
            this.errorDenier.SetIconAlignment(this.txtDenier, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.errorYarnTypeName.SetIconAlignment(this.txtDenier, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.errorYarnQuality.SetIconAlignment(this.txtDenier, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.errorNumberOfFilamets.SetIconAlignment(this.txtDenier, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.txtDenier.Location = new System.Drawing.Point(167, 76);
            this.txtDenier.Name = "txtDenier";
            this.txtDenier.Properties.Appearance.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDenier.Properties.Appearance.Options.UseFont = true;
            this.txtDenier.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.txtDenier.Properties.Mask.EditMask = "n2";
            this.txtDenier.Size = new System.Drawing.Size(205, 26);
            this.txtDenier.TabIndex = 162;
            this.txtDenier.Enter += new System.EventHandler(this.EnterEvent);
            this.txtDenier.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txtDenier.Leave += new System.EventHandler(this.LeaveEvent);
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Location = new System.Drawing.Point(20, 113);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(133, 17);
            this.labelControl4.TabIndex = 164;
            this.labelControl4.Text = "Number Of Filaments";
            // 
            // txtNumberOfFilaments
            // 
            this.txtNumberOfFilaments.EditValue = "";
            this.errorDenier.SetIconAlignment(this.txtNumberOfFilaments, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.errorYarnTypeName.SetIconAlignment(this.txtNumberOfFilaments, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.errorYarnQuality.SetIconAlignment(this.txtNumberOfFilaments, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.errorNumberOfFilamets.SetIconAlignment(this.txtNumberOfFilaments, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.txtNumberOfFilaments.Location = new System.Drawing.Point(167, 108);
            this.txtNumberOfFilaments.Name = "txtNumberOfFilaments";
            this.txtNumberOfFilaments.Properties.Appearance.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumberOfFilaments.Properties.Appearance.Options.UseFont = true;
            this.txtNumberOfFilaments.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.txtNumberOfFilaments.Properties.Mask.EditMask = "n2";
            this.txtNumberOfFilaments.Size = new System.Drawing.Size(205, 26);
            this.txtNumberOfFilaments.TabIndex = 165;
            this.txtNumberOfFilaments.Enter += new System.EventHandler(this.EnterEvent);
            this.txtNumberOfFilaments.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txtNumberOfFilaments.Leave += new System.EventHandler(this.LeaveEvent);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(167, 141);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(205, 90);
            this.txtDescription.TabIndex = 166;
            this.txtDescription.Enter += new System.EventHandler(this.EnterEvent);
            this.txtDescription.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txtDescription.Leave += new System.EventHandler(this.LeaveEvent);
            // 
            // errorYarnTypeName
            // 
            this.errorYarnTypeName.ContainerControl = this;
            // 
            // errorYarnQuality
            // 
            this.errorYarnQuality.ContainerControl = this;
            // 
            // errorDenier
            // 
            this.errorDenier.ContainerControl = this;
            // 
            // errorNumberOfFilamets
            // 
            this.errorNumberOfFilamets.ContainerControl = this;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl5.Location = new System.Drawing.Point(158, 15);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(6, 17);
            this.labelControl5.TabIndex = 176;
            this.labelControl5.Text = "*";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl6.Location = new System.Drawing.Point(158, 47);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(6, 17);
            this.labelControl6.TabIndex = 177;
            this.labelControl6.Text = "*";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl7.Location = new System.Drawing.Point(158, 79);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(6, 17);
            this.labelControl7.TabIndex = 178;
            this.labelControl7.Text = "*";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl8.Location = new System.Drawing.Point(159, 111);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(6, 17);
            this.labelControl8.TabIndex = 179;
            this.labelControl8.Text = "*";
            // 
            // frmYarnTypeMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(534, 246);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmYarnTypeMaster";
            this.Text = "Yarn Type Master";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtYarnQualityName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbYarnQuality.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDenier.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumberOfFilaments.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorYarnTypeName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorYarnQuality)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDenier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNumberOfFilamets)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtYarnQualityName;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.LookUpEdit cmbYarnQuality;
        private DevExpress.XtraEditors.TextEdit txtNumberOfFilaments;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtDenier;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.MemoEdit txtDescription;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider errorYarnTypeName;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider errorYarnQuality;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider errorDenier;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider errorNumberOfFilamets;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
    }
}
