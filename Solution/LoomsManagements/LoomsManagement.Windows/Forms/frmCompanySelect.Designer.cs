namespace LoomsManagement.Windows.Forms
{
    partial class frmCompanySelect
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCompanySelect));
            this.cmbCompanyCode = new DevExpress.XtraEditors.LookUpEdit();
            this.label13 = new System.Windows.Forms.Label();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.error_CompanyCode = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.cmbCompanyCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_CompanyCode)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbCompanyCode
            // 
            this.cmbCompanyCode.Location = new System.Drawing.Point(35, 43);
            this.cmbCompanyCode.Name = "cmbCompanyCode";
            this.cmbCompanyCode.Properties.Appearance.Font = new System.Drawing.Font("Cambria", 11.25F);
            this.cmbCompanyCode.Properties.Appearance.Options.UseFont = true;
            this.cmbCompanyCode.Properties.AppearanceDisabled.Font = new System.Drawing.Font("Cambria", 11.25F);
            this.cmbCompanyCode.Properties.AppearanceDisabled.Options.UseFont = true;
            this.cmbCompanyCode.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Cambria", 11.25F);
            this.cmbCompanyCode.Properties.AppearanceDropDown.Options.UseFont = true;
            this.cmbCompanyCode.Properties.AppearanceDropDownHeader.Font = new System.Drawing.Font("Cambria", 11.25F);
            this.cmbCompanyCode.Properties.AppearanceDropDownHeader.Options.UseFont = true;
            this.cmbCompanyCode.Properties.AppearanceFocused.Font = new System.Drawing.Font("Cambria", 11.25F);
            this.cmbCompanyCode.Properties.AppearanceFocused.Options.UseFont = true;
            this.cmbCompanyCode.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("Cambria", 11.25F);
            this.cmbCompanyCode.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.cmbCompanyCode.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmbCompanyCode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbCompanyCode.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CompanyID", "CompanyID", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CompanyName", "CompanyName"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ComapnyCode", "ComapnyCode")});
            this.cmbCompanyCode.Properties.NullText = "";
            this.cmbCompanyCode.Size = new System.Drawing.Size(201, 26);
            this.cmbCompanyCode.TabIndex = 192;
            this.cmbCompanyCode.ToolTip = "Select Company Name";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(20, 45);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(13, 17);
            this.label13.TabIndex = 194;
            this.label13.Text = "*";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Location = new System.Drawing.Point(85, 14);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(98, 17);
            this.labelControl6.TabIndex = 193;
            this.labelControl6.Text = "Company Name";
            // 
            // btnSave
            // 
            this.btnSave.Appearance.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(47, 93);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(84, 31);
            this.btnSave.TabIndex = 195;
            this.btnSave.Text = "&Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnExit
            // 
            this.btnExit.Appearance.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Appearance.Options.UseFont = true;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(137, 93);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(84, 31);
            this.btnExit.TabIndex = 196;
            this.btnExit.Text = "&Close";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // error_CompanyCode
            // 
            this.error_CompanyCode.ContainerControl = this;
            // 
            // frmCompanySelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 146);
            this.ControlBox = false;
            this.Controls.Add(this.cmbCompanyCode);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.labelControl6);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCompanySelect";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Company";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.cmbCompanyCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_CompanyCode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LookUpEdit cmbCompanyCode;
        private System.Windows.Forms.Label label13;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        public DevExpress.XtraEditors.SimpleButton btnSave;
        public DevExpress.XtraEditors.SimpleButton btnExit;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider error_CompanyCode;
    }
}