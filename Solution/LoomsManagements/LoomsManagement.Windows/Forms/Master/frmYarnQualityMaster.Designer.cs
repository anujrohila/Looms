namespace LoomsManagement.Windows.Forms.Master
{
    partial class frmYarnQualityMaster
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtYarnQualityName = new DevExpress.XtraEditors.TextEdit();
            this.txtDescription = new DevExpress.XtraEditors.MemoEdit();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btndelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnExist = new DevExpress.XtraEditors.SimpleButton();
            this.btnReport = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.errorYarnQualityName = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtYarnQualityName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorYarnQualityName)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.txtYarnQualityName);
            this.panelControl1.Controls.Add(this.txtDescription);
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(390, 164);
            this.panelControl1.TabIndex = 0;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl3.Location = new System.Drawing.Point(142, 18);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(6, 17);
            this.labelControl3.TabIndex = 175;
            this.labelControl3.Text = "*";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(12, 52);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(73, 17);
            this.labelControl2.TabIndex = 176;
            this.labelControl2.Text = "Description";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(12, 19);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(118, 17);
            this.labelControl1.TabIndex = 175;
            this.labelControl1.Text = "Yarn Quality Name";
            // 
            // txtYarnQualityName
            // 
            this.txtYarnQualityName.EditValue = "";
            this.errorYarnQualityName.SetIconAlignment(this.txtYarnQualityName, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.txtYarnQualityName.Location = new System.Drawing.Point(151, 15);
            this.txtYarnQualityName.Name = "txtYarnQualityName";
            this.txtYarnQualityName.Properties.Appearance.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYarnQualityName.Properties.Appearance.Options.UseFont = true;
            this.txtYarnQualityName.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.txtYarnQualityName.Properties.Mask.EditMask = "n2";
            this.txtYarnQualityName.Size = new System.Drawing.Size(205, 26);
            this.txtYarnQualityName.TabIndex = 0;
            this.txtYarnQualityName.ToolTip = "Enter Cheque Number";
            this.txtYarnQualityName.Enter += new System.EventHandler(this.EnterEvent);
            this.txtYarnQualityName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txtYarnQualityName.Leave += new System.EventHandler(this.LeaveEvent);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(151, 47);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(205, 90);
            this.txtDescription.TabIndex = 1;
            this.txtDescription.Enter += new System.EventHandler(this.EnterEvent);
            this.txtDescription.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txtDescription.Leave += new System.EventHandler(this.LeaveEvent);
            // 
            // btnSave
            // 
            this.btnSave.Appearance.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.Location = new System.Drawing.Point(14, 8);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(103, 31);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "&Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btndelete
            // 
            this.btndelete.Appearance.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold);
            this.btndelete.Appearance.Options.UseFont = true;
            this.btndelete.Image = global::LoomsManagement.Windows.Properties.Resources.Deletebutton;
            this.btndelete.Location = new System.Drawing.Point(14, 45);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(103, 31);
            this.btndelete.TabIndex = 3;
            this.btndelete.Text = "&Delete";
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnExist
            // 
            this.btnExist.Appearance.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnExist.Appearance.Options.UseFont = true;
            this.btnExist.Image = global::LoomsManagement.Windows.Properties.Resources.delete;
            this.btnExist.Location = new System.Drawing.Point(14, 82);
            this.btnExist.Name = "btnExist";
            this.btnExist.Size = new System.Drawing.Size(103, 31);
            this.btnExist.TabIndex = 4;
            this.btnExist.Text = "&Close";
            this.btnExist.Click += new System.EventHandler(this.btnExist_Click);
            // 
            // btnReport
            // 
            this.btnReport.Appearance.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnReport.Appearance.Options.UseFont = true;
            this.btnReport.Image = global::LoomsManagement.Windows.Properties.Resources.printer_icon;
            this.btnReport.Location = new System.Drawing.Point(14, 119);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(103, 31);
            this.btnReport.TabIndex = 5;
            this.btnReport.Text = "&Print";
            // 
            // panelControl4
            // 
            this.panelControl4.Controls.Add(this.btnSave);
            this.panelControl4.Controls.Add(this.btnReport);
            this.panelControl4.Controls.Add(this.btndelete);
            this.panelControl4.Controls.Add(this.btnExist);
            this.panelControl4.Location = new System.Drawing.Point(392, 0);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(128, 164);
            this.panelControl4.TabIndex = 5;
            // 
            // errorYarnQualityName
            // 
            this.errorYarnQualityName.ContainerControl = this;
            // 
            // frmYarnQualityMaster
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 164);
            this.Controls.Add(this.panelControl4);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmYarnQualityMaster";
            this.Text = "Yarn Quality Master";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtYarnQualityName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorYarnQualityName)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtYarnQualityName;
        private DevExpress.XtraEditors.MemoEdit txtDescription;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btndelete;
        private DevExpress.XtraEditors.SimpleButton btnExist;
        private DevExpress.XtraEditors.SimpleButton btnReport;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider errorYarnQualityName;
        private DevExpress.XtraEditors.LabelControl labelControl3;
    }
}