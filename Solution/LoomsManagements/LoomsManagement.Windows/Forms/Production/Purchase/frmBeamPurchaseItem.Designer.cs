namespace LoomsManagement.Windows.Forms
{
    partial class frmBeamPurchaseItem
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
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtAmount = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtRate = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl18 = new DevExpress.XtraEditors.LabelControl();
            this.txxtEnds = new DevExpress.XtraEditors.TextEdit();
            this.labelControl29 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl32 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl30 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl34 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl36 = new DevExpress.XtraEditors.LabelControl();
            this.txtWeight = new DevExpress.XtraEditors.TextEdit();
            this.txtLength = new DevExpress.XtraEditors.TextEdit();
            this.txtQuality = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txxtEnds.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWeight.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLength.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuality.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Location = new System.Drawing.Point(328, 0);
            this.panelControl1.Size = new System.Drawing.Size(127, 212);
            // 
            // btnReport
            // 
            this.btnReport.Appearance.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.Appearance.Options.UseFont = true;
            this.btnReport.Visible = false;
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
            this.panel1.Controls.Add(this.txtQuality);
            this.panel1.Controls.Add(this.labelControl5);
            this.panel1.Controls.Add(this.txtAmount);
            this.panel1.Controls.Add(this.labelControl6);
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Controls.Add(this.txtRate);
            this.panel1.Controls.Add(this.labelControl8);
            this.panel1.Controls.Add(this.labelControl2);
            this.panel1.Controls.Add(this.labelControl3);
            this.panel1.Controls.Add(this.labelControl18);
            this.panel1.Controls.Add(this.txxtEnds);
            this.panel1.Controls.Add(this.labelControl29);
            this.panel1.Controls.Add(this.labelControl32);
            this.panel1.Controls.Add(this.labelControl30);
            this.panel1.Controls.Add(this.labelControl34);
            this.panel1.Controls.Add(this.labelControl36);
            this.panel1.Controls.Add(this.txtWeight);
            this.panel1.Controls.Add(this.txtLength);
            this.panel1.Size = new System.Drawing.Size(328, 212);
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl5.Location = new System.Drawing.Point(76, 174);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(6, 17);
            this.labelControl5.TabIndex = 327;
            this.labelControl5.Text = "*";
            // 
            // txtAmount
            // 
            this.txtAmount.EditValue = "";
            this.txtAmount.Location = new System.Drawing.Point(85, 171);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Properties.Appearance.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Properties.Appearance.Options.UseFont = true;
            this.txtAmount.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.txtAmount.Properties.Mask.EditMask = "n2";
            this.txtAmount.Size = new System.Drawing.Size(205, 26);
            this.txtAmount.TabIndex = 326;
            this.txtAmount.ToolTip = "Enter Broker Name";
            this.txtAmount.Enter += new System.EventHandler(this.EnterEvent);
            this.txtAmount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txtAmount.Leave += new System.EventHandler(this.LeaveEvent);
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Location = new System.Drawing.Point(10, 170);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(51, 17);
            this.labelControl6.TabIndex = 325;
            this.labelControl6.Text = "Amount";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl1.Location = new System.Drawing.Point(77, 142);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(6, 17);
            this.labelControl1.TabIndex = 322;
            this.labelControl1.Text = "*";
            // 
            // txtRate
            // 
            this.txtRate.EditValue = "";
            this.txtRate.Location = new System.Drawing.Point(86, 139);
            this.txtRate.Name = "txtRate";
            this.txtRate.Properties.Appearance.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRate.Properties.Appearance.Options.UseFont = true;
            this.txtRate.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.txtRate.Properties.Mask.EditMask = "n2";
            this.txtRate.Size = new System.Drawing.Size(205, 26);
            this.txtRate.TabIndex = 321;
            this.txtRate.ToolTip = "Enter Broker Name";
            this.txtRate.Enter += new System.EventHandler(this.EnterEvent);
            this.txtRate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txtRate.Leave += new System.EventHandler(this.LeaveEvent);
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Location = new System.Drawing.Point(11, 138);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(28, 17);
            this.labelControl8.TabIndex = 320;
            this.labelControl8.Text = "Rate";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl2.Location = new System.Drawing.Point(77, 110);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(6, 17);
            this.labelControl2.TabIndex = 317;
            this.labelControl2.Text = "*";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl3.Location = new System.Drawing.Point(77, 78);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(6, 17);
            this.labelControl3.TabIndex = 316;
            this.labelControl3.Text = "*";
            // 
            // labelControl18
            // 
            this.labelControl18.Appearance.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl18.Location = new System.Drawing.Point(11, 76);
            this.labelControl18.Name = "labelControl18";
            this.labelControl18.Size = new System.Drawing.Size(46, 17);
            this.labelControl18.TabIndex = 315;
            this.labelControl18.Text = "Weight";
            // 
            // txxtEnds
            // 
            this.txxtEnds.EditValue = "";
            this.txxtEnds.Location = new System.Drawing.Point(86, 43);
            this.txxtEnds.Name = "txxtEnds";
            this.txxtEnds.Properties.Appearance.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txxtEnds.Properties.Appearance.Options.UseFont = true;
            this.txxtEnds.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.txxtEnds.Properties.Mask.EditMask = "n2";
            this.txxtEnds.Size = new System.Drawing.Size(205, 26);
            this.txxtEnds.TabIndex = 314;
            this.txxtEnds.ToolTip = "Enter Broker Name";
            this.txxtEnds.Enter += new System.EventHandler(this.EnterEvent);
            this.txxtEnds.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txxtEnds.Leave += new System.EventHandler(this.LeaveEvent);
            // 
            // labelControl29
            // 
            this.labelControl29.Appearance.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl29.Location = new System.Drawing.Point(11, 45);
            this.labelControl29.Name = "labelControl29";
            this.labelControl29.Size = new System.Drawing.Size(31, 17);
            this.labelControl29.TabIndex = 308;
            this.labelControl29.Text = "Ends";
            // 
            // labelControl32
            // 
            this.labelControl32.Appearance.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl32.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl32.Location = new System.Drawing.Point(77, 14);
            this.labelControl32.Name = "labelControl32";
            this.labelControl32.Size = new System.Drawing.Size(6, 17);
            this.labelControl32.TabIndex = 313;
            this.labelControl32.Text = "*";
            // 
            // labelControl30
            // 
            this.labelControl30.Appearance.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl30.Location = new System.Drawing.Point(11, 107);
            this.labelControl30.Name = "labelControl30";
            this.labelControl30.Size = new System.Drawing.Size(43, 17);
            this.labelControl30.TabIndex = 307;
            this.labelControl30.Text = "Length";
            // 
            // labelControl34
            // 
            this.labelControl34.Appearance.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl34.Location = new System.Drawing.Point(11, 14);
            this.labelControl34.Name = "labelControl34";
            this.labelControl34.Size = new System.Drawing.Size(46, 17);
            this.labelControl34.TabIndex = 310;
            this.labelControl34.Text = "Quality";
            // 
            // labelControl36
            // 
            this.labelControl36.Appearance.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl36.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl36.Location = new System.Drawing.Point(77, 46);
            this.labelControl36.Name = "labelControl36";
            this.labelControl36.Size = new System.Drawing.Size(6, 17);
            this.labelControl36.TabIndex = 311;
            this.labelControl36.Text = "*";
            // 
            // txtWeight
            // 
            this.txtWeight.EditValue = "";
            this.txtWeight.Location = new System.Drawing.Point(85, 75);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Properties.Appearance.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWeight.Properties.Appearance.Options.UseFont = true;
            this.txtWeight.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.txtWeight.Properties.Mask.EditMask = "n2";
            this.txtWeight.Size = new System.Drawing.Size(206, 26);
            this.txtWeight.TabIndex = 306;
            this.txtWeight.ToolTip = "Enter Broker Name";
            this.txtWeight.Enter += new System.EventHandler(this.EnterEvent);
            this.txtWeight.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txtWeight.Leave += new System.EventHandler(this.LeaveEvent);
            // 
            // txtLength
            // 
            this.txtLength.EditValue = "";
            this.txtLength.Location = new System.Drawing.Point(86, 107);
            this.txtLength.Name = "txtLength";
            this.txtLength.Properties.Appearance.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLength.Properties.Appearance.Options.UseFont = true;
            this.txtLength.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.txtLength.Properties.Mask.EditMask = "n2";
            this.txtLength.Size = new System.Drawing.Size(205, 26);
            this.txtLength.TabIndex = 305;
            this.txtLength.ToolTip = "Enter Broker Name";
            this.txtLength.Enter += new System.EventHandler(this.EnterEvent);
            this.txtLength.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txtLength.Leave += new System.EventHandler(this.LeaveEvent);
            // 
            // txtQuality
            // 
            this.txtQuality.EditValue = "";
            this.txtQuality.Location = new System.Drawing.Point(86, 10);
            this.txtQuality.Name = "txtQuality";
            this.txtQuality.Properties.Appearance.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuality.Properties.Appearance.Options.UseFont = true;
            this.txtQuality.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.txtQuality.Properties.Mask.EditMask = "n2";
            this.txtQuality.Size = new System.Drawing.Size(205, 26);
            this.txtQuality.TabIndex = 328;
            this.txtQuality.ToolTip = "Enter Broker Name";
            this.txtQuality.Enter += new System.EventHandler(this.EnterEvent);
            this.txtQuality.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txtQuality.Leave += new System.EventHandler(this.LeaveEvent);
            // 
            // frmBeamPurchaseItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(455, 212);
            this.Name = "frmBeamPurchaseItem";
            this.Text = "Beam Purchase Item";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Page_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txxtEnds.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWeight.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLength.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuality.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtQuality;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtAmount;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtRate;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl18;
        private DevExpress.XtraEditors.TextEdit txxtEnds;
        private DevExpress.XtraEditors.LabelControl labelControl29;
        private DevExpress.XtraEditors.LabelControl labelControl32;
        private DevExpress.XtraEditors.LabelControl labelControl30;
        private DevExpress.XtraEditors.LabelControl labelControl34;
        private DevExpress.XtraEditors.LabelControl labelControl36;
        private DevExpress.XtraEditors.TextEdit txtWeight;
        private DevExpress.XtraEditors.TextEdit txtLength;
    }
}
