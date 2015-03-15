namespace LoomsManagement.Windows.Forms.Master
{
    partial class frmYarnPackageTypeMaster
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
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtYarnPackageType = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.errorYarnPackageType = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtYarnPackageType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorYarnPackageType)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Location = new System.Drawing.Point(392, 0);
            this.panelControl1.Size = new System.Drawing.Size(127, 152);
            // 
            // btnReport
            // 
            this.btnReport.Appearance.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.Appearance.Options.UseFont = true;
            this.btnReport.TabIndex = 4;
            // 
            // btnExit
            // 
            this.btnExit.Appearance.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Appearance.Options.UseFont = true;
            this.btnExit.TabIndex = 3;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Appearance.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.TabIndex = 1;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btndelete
            // 
            this.btndelete.Appearance.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.Appearance.Options.UseFont = true;
            this.btndelete.TabIndex = 2;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelControl5);
            this.panel1.Controls.Add(this.labelControl6);
            this.panel1.Controls.Add(this.txtYarnPackageType);
            this.panel1.Size = new System.Drawing.Size(392, 152);
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Location = new System.Drawing.Point(13, 14);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(120, 17);
            this.labelControl6.TabIndex = 62;
            this.labelControl6.Text = "Yarn Package Type";
            // 
            // txtYarnPackageType
            // 
            this.txtYarnPackageType.EditValue = "";
            this.errorYarnPackageType.SetIconAlignment(this.txtYarnPackageType, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.txtYarnPackageType.Location = new System.Drawing.Point(154, 10);
            this.txtYarnPackageType.Name = "txtYarnPackageType";
            this.txtYarnPackageType.Properties.Appearance.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYarnPackageType.Properties.Appearance.Options.UseFont = true;
            this.txtYarnPackageType.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.txtYarnPackageType.Properties.Mask.EditMask = "n2";
            this.txtYarnPackageType.Size = new System.Drawing.Size(205, 26);
            this.txtYarnPackageType.TabIndex = 0;
            this.txtYarnPackageType.Enter += new System.EventHandler(this.EnterEvent);
            this.txtYarnPackageType.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txtYarnPackageType.Leave += new System.EventHandler(this.LeaveEvent);
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl5.Location = new System.Drawing.Point(145, 13);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(6, 17);
            this.labelControl5.TabIndex = 178;
            this.labelControl5.Text = "*";
            // 
            // errorYarnPackageType
            // 
            this.errorYarnPackageType.ContainerControl = this;
            // 
            // frmYarnPackageTypeMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(519, 152);
            this.Name = "frmYarnPackageTypeMaster";
            this.Text = "Yarn Package Type";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtYarnPackageType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorYarnPackageType)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtYarnPackageType;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider errorYarnPackageType;
    }
}
