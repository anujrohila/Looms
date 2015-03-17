namespace LoomsManagement.Windows.Forms.Master
{
    partial class frmBrokerMaster
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
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtBrokerName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtAddress = new DevExpress.XtraEditors.MemoEdit();
            this.txtContactNumber = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtBrokerFirmName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.txtMobileNumber = new DevExpress.XtraEditors.TextEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.txtDealingIn = new DevExpress.XtraEditors.MemoEdit();
            this.errorBrokerName = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.errorBrokerFirmName = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.errorAddress = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.errorContactNumber = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.errorMobileNumber = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.errorDealing = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBrokerName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContactNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBrokerFirmName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMobileNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDealingIn.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorBrokerName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorBrokerFirmName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorContactNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorMobileNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDealing)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Location = new System.Drawing.Point(404, 0);
            this.panelControl1.Size = new System.Drawing.Size(127, 337);
            // 
            // btnReport
            // 
            this.btnReport.Appearance.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.Appearance.Options.UseFont = true;
            this.btnReport.TabIndex = 9;
            // 
            // btnExit
            // 
            this.btnExit.Appearance.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Appearance.Options.UseFont = true;
            this.btnExit.TabIndex = 8;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Appearance.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.TabIndex = 6;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btndelete
            // 
            this.btndelete.Appearance.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.Appearance.Options.UseFont = true;
            this.btndelete.TabIndex = 7;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtDealingIn);
            this.panel1.Controls.Add(this.labelControl11);
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Controls.Add(this.labelControl6);
            this.panel1.Controls.Add(this.labelControl9);
            this.panel1.Controls.Add(this.labelControl10);
            this.panel1.Controls.Add(this.txtMobileNumber);
            this.panel1.Controls.Add(this.labelControl8);
            this.panel1.Controls.Add(this.labelControl7);
            this.panel1.Controls.Add(this.txtAddress);
            this.panel1.Controls.Add(this.txtContactNumber);
            this.panel1.Controls.Add(this.labelControl4);
            this.panel1.Controls.Add(this.labelControl3);
            this.panel1.Controls.Add(this.txtBrokerFirmName);
            this.panel1.Controls.Add(this.labelControl2);
            this.panel1.Controls.Add(this.labelControl5);
            this.panel1.Controls.Add(this.txtBrokerName);
            this.panel1.Controls.Add(this.labelControl14);
            this.panel1.Size = new System.Drawing.Size(404, 337);
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl5.Location = new System.Drawing.Point(150, 15);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(6, 17);
            this.labelControl5.TabIndex = 179;
            this.labelControl5.Text = "*";
            // 
            // txtBrokerName
            // 
            this.txtBrokerName.EditValue = "";
            this.errorBrokerName.SetIconAlignment(this.txtBrokerName, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.errorMobileNumber.SetIconAlignment(this.txtBrokerName, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.errorDealing.SetIconAlignment(this.txtBrokerName, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.errorBrokerFirmName.SetIconAlignment(this.txtBrokerName, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.errorContactNumber.SetIconAlignment(this.txtBrokerName, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.errorAddress.SetIconAlignment(this.txtBrokerName, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.txtBrokerName.Location = new System.Drawing.Point(159, 12);
            this.txtBrokerName.Name = "txtBrokerName";
            this.txtBrokerName.Properties.Appearance.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBrokerName.Properties.Appearance.Options.UseFont = true;
            this.txtBrokerName.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.txtBrokerName.Properties.Mask.EditMask = "n2";
            this.txtBrokerName.Size = new System.Drawing.Size(205, 26);
            this.txtBrokerName.TabIndex = 0;
            this.txtBrokerName.Enter += new System.EventHandler(this.EnterEvent);
            this.txtBrokerName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txtBrokerName.Leave += new System.EventHandler(this.LeaveEvent);
            // 
            // labelControl14
            // 
            this.labelControl14.Appearance.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl14.Location = new System.Drawing.Point(12, 16);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(83, 17);
            this.labelControl14.TabIndex = 178;
            this.labelControl14.Text = "Broker Name";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl8.Location = new System.Drawing.Point(151, 79);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(6, 17);
            this.labelControl8.TabIndex = 187;
            this.labelControl8.Text = "*";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl7.Location = new System.Drawing.Point(150, 47);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(6, 17);
            this.labelControl7.TabIndex = 186;
            this.labelControl7.Text = "*";
            // 
            // txtAddress
            // 
            this.errorBrokerFirmName.SetIconAlignment(this.txtAddress, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.errorAddress.SetIconAlignment(this.txtAddress, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.errorDealing.SetIconAlignment(this.txtAddress, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.errorMobileNumber.SetIconAlignment(this.txtAddress, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.errorContactNumber.SetIconAlignment(this.txtAddress, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.errorBrokerName.SetIconAlignment(this.txtAddress, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.txtAddress.Location = new System.Drawing.Point(159, 74);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(205, 90);
            this.txtAddress.TabIndex = 2;
            this.txtAddress.Enter += new System.EventHandler(this.EnterEvent);
            this.txtAddress.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txtAddress.Leave += new System.EventHandler(this.LeaveEvent);
            // 
            // txtContactNumber
            // 
            this.txtContactNumber.EditValue = "";
            this.errorBrokerName.SetIconAlignment(this.txtContactNumber, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.errorMobileNumber.SetIconAlignment(this.txtContactNumber, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.errorDealing.SetIconAlignment(this.txtContactNumber, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.errorBrokerFirmName.SetIconAlignment(this.txtContactNumber, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.errorContactNumber.SetIconAlignment(this.txtContactNumber, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.errorAddress.SetIconAlignment(this.txtContactNumber, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.txtContactNumber.Location = new System.Drawing.Point(159, 170);
            this.txtContactNumber.Name = "txtContactNumber";
            this.txtContactNumber.Properties.Appearance.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContactNumber.Properties.Appearance.Options.UseFont = true;
            this.txtContactNumber.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.txtContactNumber.Properties.Mask.EditMask = "n2";
            this.txtContactNumber.Size = new System.Drawing.Size(205, 26);
            this.txtContactNumber.TabIndex = 3;
            this.txtContactNumber.Enter += new System.EventHandler(this.EnterEvent);
            this.txtContactNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txtContactNumber.Leave += new System.EventHandler(this.LeaveEvent);
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Location = new System.Drawing.Point(12, 81);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(50, 17);
            this.labelControl4.TabIndex = 183;
            this.labelControl4.Text = "Address";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(12, 47);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(116, 17);
            this.labelControl3.TabIndex = 182;
            this.labelControl3.Text = "Broker Firm Name";
            // 
            // txtBrokerFirmName
            // 
            this.txtBrokerFirmName.EditValue = "";
            this.errorBrokerName.SetIconAlignment(this.txtBrokerFirmName, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.errorMobileNumber.SetIconAlignment(this.txtBrokerFirmName, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.errorDealing.SetIconAlignment(this.txtBrokerFirmName, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.errorBrokerFirmName.SetIconAlignment(this.txtBrokerFirmName, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.errorContactNumber.SetIconAlignment(this.txtBrokerFirmName, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.errorAddress.SetIconAlignment(this.txtBrokerFirmName, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.txtBrokerFirmName.Location = new System.Drawing.Point(159, 43);
            this.txtBrokerFirmName.Name = "txtBrokerFirmName";
            this.txtBrokerFirmName.Properties.Appearance.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBrokerFirmName.Properties.Appearance.Options.UseFont = true;
            this.txtBrokerFirmName.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.txtBrokerFirmName.Properties.Mask.EditMask = "n2";
            this.txtBrokerFirmName.Size = new System.Drawing.Size(205, 26);
            this.txtBrokerFirmName.TabIndex = 1;
            this.txtBrokerFirmName.Enter += new System.EventHandler(this.EnterEvent);
            this.txtBrokerFirmName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txtBrokerFirmName.Leave += new System.EventHandler(this.LeaveEvent);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(12, 174);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(102, 17);
            this.labelControl2.TabIndex = 180;
            this.labelControl2.Text = "Contact Number";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl1.Location = new System.Drawing.Point(151, 237);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(6, 17);
            this.labelControl1.TabIndex = 195;
            this.labelControl1.Text = "*";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl6.Location = new System.Drawing.Point(150, 205);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(6, 17);
            this.labelControl6.TabIndex = 194;
            this.labelControl6.Text = "*";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Location = new System.Drawing.Point(12, 239);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(63, 17);
            this.labelControl9.TabIndex = 191;
            this.labelControl9.Text = "Dealing In";
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl10.Location = new System.Drawing.Point(12, 205);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(97, 17);
            this.labelControl10.TabIndex = 190;
            this.labelControl10.Text = "Mobile Number";
            // 
            // txtMobileNumber
            // 
            this.txtMobileNumber.EditValue = "";
            this.errorBrokerName.SetIconAlignment(this.txtMobileNumber, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.errorMobileNumber.SetIconAlignment(this.txtMobileNumber, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.errorDealing.SetIconAlignment(this.txtMobileNumber, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.errorBrokerFirmName.SetIconAlignment(this.txtMobileNumber, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.errorContactNumber.SetIconAlignment(this.txtMobileNumber, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.errorAddress.SetIconAlignment(this.txtMobileNumber, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.txtMobileNumber.Location = new System.Drawing.Point(159, 202);
            this.txtMobileNumber.Name = "txtMobileNumber";
            this.txtMobileNumber.Properties.Appearance.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMobileNumber.Properties.Appearance.Options.UseFont = true;
            this.txtMobileNumber.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.txtMobileNumber.Properties.Mask.EditMask = "n2";
            this.txtMobileNumber.Size = new System.Drawing.Size(205, 26);
            this.txtMobileNumber.TabIndex = 4;
            this.txtMobileNumber.Enter += new System.EventHandler(this.EnterEvent);
            this.txtMobileNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txtMobileNumber.Leave += new System.EventHandler(this.LeaveEvent);
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl11.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl11.Location = new System.Drawing.Point(150, 173);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(6, 17);
            this.labelControl11.TabIndex = 196;
            this.labelControl11.Text = "*";
            // 
            // txtDealingIn
            // 
            this.errorBrokerFirmName.SetIconAlignment(this.txtDealingIn, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.errorAddress.SetIconAlignment(this.txtDealingIn, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.errorDealing.SetIconAlignment(this.txtDealingIn, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.errorMobileNumber.SetIconAlignment(this.txtDealingIn, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.errorContactNumber.SetIconAlignment(this.txtDealingIn, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.errorBrokerName.SetIconAlignment(this.txtDealingIn, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.txtDealingIn.Location = new System.Drawing.Point(159, 234);
            this.txtDealingIn.Name = "txtDealingIn";
            this.txtDealingIn.Size = new System.Drawing.Size(205, 90);
            this.txtDealingIn.TabIndex = 5;
            this.txtDealingIn.Enter += new System.EventHandler(this.EnterEvent);
            this.txtDealingIn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txtDealingIn.Leave += new System.EventHandler(this.LeaveEvent);
            // 
            // errorBrokerName
            // 
            this.errorBrokerName.ContainerControl = this;
            // 
            // errorBrokerFirmName
            // 
            this.errorBrokerFirmName.ContainerControl = this;
            // 
            // errorAddress
            // 
            this.errorAddress.ContainerControl = this;
            // 
            // errorContactNumber
            // 
            this.errorContactNumber.ContainerControl = this;
            // 
            // errorMobileNumber
            // 
            this.errorMobileNumber.ContainerControl = this;
            // 
            // errorDealing
            // 
            this.errorDealing.ContainerControl = this;
            // 
            // frmBrokerMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(531, 337);
            this.Name = "frmBrokerMaster";
            this.ShowInTaskbar = false;
            this.Text = "Broker Master";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBrokerName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContactNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBrokerFirmName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMobileNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDealingIn.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorBrokerName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorBrokerFirmName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorContactNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorMobileNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDealing)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtBrokerName;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.MemoEdit txtAddress;
        private DevExpress.XtraEditors.TextEdit txtContactNumber;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtBrokerFirmName;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.TextEdit txtMobileNumber;
        private DevExpress.XtraEditors.MemoEdit txtDealingIn;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider errorBrokerName;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider errorBrokerFirmName;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider errorAddress;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider errorContactNumber;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider errorMobileNumber;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider errorDealing;
    }
}
