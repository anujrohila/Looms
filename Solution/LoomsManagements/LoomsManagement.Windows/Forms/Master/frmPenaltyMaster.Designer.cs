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
            this.components = new System.ComponentModel.Container();
            this.txtPenaltyName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtPenaltyCode = new DevExpress.XtraEditors.TextEdit();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.txtDescription = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.errorPenaltyCode = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.errorPenaltyName = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPenaltyName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPenaltyCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPenaltyCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPenaltyName)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Location = new System.Drawing.Point(367, 0);
            this.panelControl1.Size = new System.Drawing.Size(125, 183);
            // 
            // btnReport
            // 
            this.btnReport.Appearance.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.Appearance.Options.UseFont = true;
            this.btnReport.TabIndex = 6;
            this.btnReport.Visible = false;
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
            this.panel1.Controls.Add(this.labelControl3);
            this.panel1.Controls.Add(this.labelControl5);
            this.panel1.Controls.Add(this.txtDescription);
            this.panel1.Controls.Add(this.txtPenaltyName);
            this.panel1.Controls.Add(this.labelControl2);
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Controls.Add(this.txtPenaltyCode);
            this.panel1.Controls.Add(this.labelControl14);
            this.panel1.Size = new System.Drawing.Size(367, 183);
            // 
            // txtPenaltyName
            // 
            this.txtPenaltyName.EditValue = "";
            this.errorPenaltyCode.SetIconAlignment(this.txtPenaltyName, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.errorPenaltyName.SetIconAlignment(this.txtPenaltyName, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.txtPenaltyName.Location = new System.Drawing.Point(122, 46);
            this.txtPenaltyName.Name = "txtPenaltyName";
            this.txtPenaltyName.Properties.Appearance.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPenaltyName.Properties.Appearance.Options.UseFont = true;
            this.txtPenaltyName.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.txtPenaltyName.Properties.Mask.EditMask = "n2";
            this.txtPenaltyName.Size = new System.Drawing.Size(205, 26);
            this.txtPenaltyName.TabIndex = 1;
            this.txtPenaltyName.ToolTip = "Enter Cheque Number";
            this.txtPenaltyName.Enter += new System.EventHandler(this.EnterEvent);
            this.txtPenaltyName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txtPenaltyName.Leave += new System.EventHandler(this.LeaveEvent);
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
            this.errorPenaltyCode.SetIconAlignment(this.txtPenaltyCode, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.errorPenaltyName.SetIconAlignment(this.txtPenaltyCode, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.txtPenaltyCode.Location = new System.Drawing.Point(122, 14);
            this.txtPenaltyCode.Name = "txtPenaltyCode";
            this.txtPenaltyCode.Properties.Appearance.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPenaltyCode.Properties.Appearance.Options.UseFont = true;
            this.txtPenaltyCode.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.txtPenaltyCode.Properties.Mask.EditMask = "n2";
            this.txtPenaltyCode.Size = new System.Drawing.Size(205, 26);
            this.txtPenaltyCode.TabIndex = 0;
            this.txtPenaltyCode.ToolTip = "Enter Cheque Number";
            this.txtPenaltyCode.Enter += new System.EventHandler(this.EnterEvent);
            this.txtPenaltyCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txtPenaltyCode.Leave += new System.EventHandler(this.LeaveEvent);
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
            // txtDescription
            // 
            this.errorPenaltyCode.SetIconAlignment(this.txtDescription, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.errorPenaltyName.SetIconAlignment(this.txtDescription, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.txtDescription.Location = new System.Drawing.Point(122, 78);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(205, 90);
            this.txtDescription.TabIndex = 2;
            this.txtDescription.Enter += new System.EventHandler(this.EnterEvent);
            this.txtDescription.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txtDescription.Leave += new System.EventHandler(this.LeaveEvent);
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl5.Location = new System.Drawing.Point(110, 13);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(6, 17);
            this.labelControl5.TabIndex = 177;
            this.labelControl5.Text = "*";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl3.Location = new System.Drawing.Point(110, 46);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(6, 17);
            this.labelControl3.TabIndex = 178;
            this.labelControl3.Text = "*";
            // 
            // errorPenaltyCode
            // 
            this.errorPenaltyCode.ContainerControl = this;
            // 
            // errorPenaltyName
            // 
            this.errorPenaltyName.ContainerControl = this;
            // 
            // frmPenaltyMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(492, 183);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPenaltyMaster";
            this.Text = "Penalty Master";
            this.Enter += new System.EventHandler(this.EnterEvent);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.Leave += new System.EventHandler(this.LeaveEvent);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPenaltyName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPenaltyCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPenaltyCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPenaltyName)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtPenaltyName;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtPenaltyCode;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.MemoEdit txtDescription;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider errorPenaltyCode;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider errorPenaltyName;

    }
}
