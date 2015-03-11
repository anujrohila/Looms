namespace LoomsManagement.Windows.Forms.Master
{
    partial class frmCompanyMaster
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
            this.txtaddress = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.dpOpeningDate = new DevExpress.XtraEditors.DateEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtCompanyName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.txtContactPerrsonName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.txtCompanyCode = new DevExpress.XtraEditors.TextEdit();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.txtOwnerName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtSMSNo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtInvestmentAmount = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txtPANNo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtECCNo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtCST = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.errorcompanyName = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.errorcompanyCode = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.errorOwnername = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.erroropeningdate = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.errorinvestmentamount = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.error_contactpersoanname = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.error_address = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.error_panno = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.errorcst = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.errorecc = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.errorsms = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtaddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dpOpeningDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpOpeningDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCompanyName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContactPerrsonName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCompanyCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOwnerName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSMSNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInvestmentAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPANNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtECCNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCST.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorcompanyName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorcompanyCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorOwnername)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erroropeningdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorinvestmentamount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_contactpersoanname)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_address)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_panno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorcst)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorecc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorsms)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Location = new System.Drawing.Point(731, 0);
            this.panelControl1.Size = new System.Drawing.Size(123, 228);
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
            this.panel1.Controls.Add(this.panelControl2);
            this.panel1.Size = new System.Drawing.Size(731, 228);
            // 
            // txtaddress
            // 
            this.errorecc.SetIconAlignment(this.txtaddress, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.error_address.SetIconAlignment(this.txtaddress, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.error_panno.SetIconAlignment(this.txtaddress, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.errorcompanyCode.SetIconAlignment(this.txtaddress, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.errorinvestmentamount.SetIconAlignment(this.txtaddress, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.error_contactpersoanname.SetIconAlignment(this.txtaddress, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.errorcompanyName.SetIconAlignment(this.txtaddress, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.erroropeningdate.SetIconAlignment(this.txtaddress, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.errorcst.SetIconAlignment(this.txtaddress, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.errorOwnername.SetIconAlignment(this.txtaddress, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.errorsms.SetIconAlignment(this.txtaddress, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.txtaddress.Location = new System.Drawing.Point(481, 16);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(205, 49);
            this.txtaddress.TabIndex = 6;
            this.txtaddress.Enter += new System.EventHandler(this.EnterEvent);
            this.txtaddress.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txtaddress.Leave += new System.EventHandler(this.LeaveEvent);
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Location = new System.Drawing.Point(397, 73);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(48, 17);
            this.labelControl9.TabIndex = 82;
            this.labelControl9.Text = "Pan No.";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.txtaddress);
            this.panelControl2.Controls.Add(this.dpOpeningDate);
            this.panelControl2.Controls.Add(this.labelControl6);
            this.panelControl2.Controls.Add(this.labelControl9);
            this.panelControl2.Controls.Add(this.txtCompanyName);
            this.panelControl2.Controls.Add(this.labelControl10);
            this.panelControl2.Controls.Add(this.txtContactPerrsonName);
            this.panelControl2.Controls.Add(this.labelControl11);
            this.panelControl2.Controls.Add(this.txtCompanyCode);
            this.panelControl2.Controls.Add(this.labelControl12);
            this.panelControl2.Controls.Add(this.txtOwnerName);
            this.panelControl2.Controls.Add(this.labelControl4);
            this.panelControl2.Controls.Add(this.txtSMSNo);
            this.panelControl2.Controls.Add(this.labelControl7);
            this.panelControl2.Controls.Add(this.txtInvestmentAmount);
            this.panelControl2.Controls.Add(this.labelControl8);
            this.panelControl2.Controls.Add(this.txtPANNo);
            this.panelControl2.Controls.Add(this.labelControl3);
            this.panelControl2.Controls.Add(this.txtECCNo);
            this.panelControl2.Controls.Add(this.labelControl2);
            this.panelControl2.Controls.Add(this.txtCST);
            this.panelControl2.Controls.Add(this.labelControl1);
            this.panelControl2.Location = new System.Drawing.Point(12, 12);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(713, 208);
            this.panelControl2.TabIndex = 64;
            // 
            // dpOpeningDate
            // 
            this.dpOpeningDate.EditValue = null;
            this.errorecc.SetIconAlignment(this.dpOpeningDate, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.error_panno.SetIconAlignment(this.dpOpeningDate, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.error_address.SetIconAlignment(this.dpOpeningDate, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.errorcst.SetIconAlignment(this.dpOpeningDate, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.errorinvestmentamount.SetIconAlignment(this.dpOpeningDate, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.errorOwnername.SetIconAlignment(this.dpOpeningDate, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.error_contactpersoanname.SetIconAlignment(this.dpOpeningDate, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.erroropeningdate.SetIconAlignment(this.dpOpeningDate, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.errorcompanyCode.SetIconAlignment(this.dpOpeningDate, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.errorcompanyName.SetIconAlignment(this.dpOpeningDate, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.errorsms.SetIconAlignment(this.dpOpeningDate, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.dpOpeningDate.Location = new System.Drawing.Point(156, 105);
            this.dpOpeningDate.Name = "dpOpeningDate";
            this.dpOpeningDate.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.dpOpeningDate.Properties.Appearance.Options.UseFont = true;
            this.dpOpeningDate.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.dpOpeningDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dpOpeningDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dpOpeningDate.Size = new System.Drawing.Size(205, 26);
            this.dpOpeningDate.TabIndex = 3;
            this.dpOpeningDate.ToolTip = "Select Date.";
            this.dpOpeningDate.Enter += new System.EventHandler(this.EnterEvent);
            this.dpOpeningDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.dpOpeningDate.Leave += new System.EventHandler(this.LeaveEvent);
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Location = new System.Drawing.Point(11, 16);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(98, 17);
            this.labelControl6.TabIndex = 60;
            this.labelControl6.Text = "Company Name";
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.EditValue = "";
            this.errorinvestmentamount.SetIconAlignment(this.txtCompanyName, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.errorcompanyCode.SetIconAlignment(this.txtCompanyName, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.errorcst.SetIconAlignment(this.txtCompanyName, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.errorecc.SetIconAlignment(this.txtCompanyName, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.error_contactpersoanname.SetIconAlignment(this.txtCompanyName, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.errorcompanyName.SetIconAlignment(this.txtCompanyName, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.error_panno.SetIconAlignment(this.txtCompanyName, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.errorOwnername.SetIconAlignment(this.txtCompanyName, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.erroropeningdate.SetIconAlignment(this.txtCompanyName, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.error_address.SetIconAlignment(this.txtCompanyName, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.errorsms.SetIconAlignment(this.txtCompanyName, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.txtCompanyName.Location = new System.Drawing.Point(156, 12);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Properties.Appearance.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompanyName.Properties.Appearance.Options.UseFont = true;
            this.txtCompanyName.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.txtCompanyName.Properties.Mask.EditMask = "n2";
            this.txtCompanyName.Size = new System.Drawing.Size(205, 26);
            this.txtCompanyName.TabIndex = 0;
            this.txtCompanyName.Enter += new System.EventHandler(this.EnterEvent);
            this.txtCompanyName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txtCompanyName.Leave += new System.EventHandler(this.LeaveEvent);
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl10.Location = new System.Drawing.Point(397, 110);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(48, 17);
            this.labelControl10.TabIndex = 81;
            this.labelControl10.Text = "CST No.";
            // 
            // txtContactPerrsonName
            // 
            this.txtContactPerrsonName.EditValue = "";
            this.errorinvestmentamount.SetIconAlignment(this.txtContactPerrsonName, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.errorcompanyCode.SetIconAlignment(this.txtContactPerrsonName, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.errorcst.SetIconAlignment(this.txtContactPerrsonName, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.errorecc.SetIconAlignment(this.txtContactPerrsonName, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.error_contactpersoanname.SetIconAlignment(this.txtContactPerrsonName, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.errorcompanyName.SetIconAlignment(this.txtContactPerrsonName, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.error_panno.SetIconAlignment(this.txtContactPerrsonName, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.errorOwnername.SetIconAlignment(this.txtContactPerrsonName, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.erroropeningdate.SetIconAlignment(this.txtContactPerrsonName, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.error_address.SetIconAlignment(this.txtContactPerrsonName, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.errorsms.SetIconAlignment(this.txtContactPerrsonName, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.txtContactPerrsonName.Location = new System.Drawing.Point(156, 167);
            this.txtContactPerrsonName.Name = "txtContactPerrsonName";
            this.txtContactPerrsonName.Properties.Appearance.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContactPerrsonName.Properties.Appearance.Options.UseFont = true;
            this.txtContactPerrsonName.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.txtContactPerrsonName.Properties.Mask.EditMask = "n2";
            this.txtContactPerrsonName.Size = new System.Drawing.Size(205, 26);
            this.txtContactPerrsonName.TabIndex = 5;
            this.txtContactPerrsonName.Enter += new System.EventHandler(this.EnterEvent);
            this.txtContactPerrsonName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txtContactPerrsonName.Leave += new System.EventHandler(this.LeaveEvent);
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl11.Location = new System.Drawing.Point(396, 140);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(49, 17);
            this.labelControl11.TabIndex = 80;
            this.labelControl11.Text = "ECC No.";
            // 
            // txtCompanyCode
            // 
            this.txtCompanyCode.EditValue = "";
            this.errorinvestmentamount.SetIconAlignment(this.txtCompanyCode, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.errorcompanyCode.SetIconAlignment(this.txtCompanyCode, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.errorcst.SetIconAlignment(this.txtCompanyCode, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.errorecc.SetIconAlignment(this.txtCompanyCode, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.error_contactpersoanname.SetIconAlignment(this.txtCompanyCode, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.errorcompanyName.SetIconAlignment(this.txtCompanyCode, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.error_panno.SetIconAlignment(this.txtCompanyCode, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.errorOwnername.SetIconAlignment(this.txtCompanyCode, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.erroropeningdate.SetIconAlignment(this.txtCompanyCode, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.error_address.SetIconAlignment(this.txtCompanyCode, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.errorsms.SetIconAlignment(this.txtCompanyCode, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.txtCompanyCode.Location = new System.Drawing.Point(156, 43);
            this.txtCompanyCode.Name = "txtCompanyCode";
            this.txtCompanyCode.Properties.Appearance.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompanyCode.Properties.Appearance.Options.UseFont = true;
            this.txtCompanyCode.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.txtCompanyCode.Properties.Mask.EditMask = "n2";
            this.txtCompanyCode.Size = new System.Drawing.Size(205, 26);
            this.txtCompanyCode.TabIndex = 1;
            this.txtCompanyCode.Enter += new System.EventHandler(this.EnterEvent);
            this.txtCompanyCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txtCompanyCode.Leave += new System.EventHandler(this.LeaveEvent);
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl12.Location = new System.Drawing.Point(11, 140);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(125, 17);
            this.labelControl12.TabIndex = 79;
            this.labelControl12.Text = "Investment Amount";
            // 
            // txtOwnerName
            // 
            this.txtOwnerName.EditValue = "";
            this.errorinvestmentamount.SetIconAlignment(this.txtOwnerName, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.errorcompanyCode.SetIconAlignment(this.txtOwnerName, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.errorcst.SetIconAlignment(this.txtOwnerName, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.errorecc.SetIconAlignment(this.txtOwnerName, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.error_contactpersoanname.SetIconAlignment(this.txtOwnerName, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.errorcompanyName.SetIconAlignment(this.txtOwnerName, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.error_panno.SetIconAlignment(this.txtOwnerName, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.errorOwnername.SetIconAlignment(this.txtOwnerName, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.erroropeningdate.SetIconAlignment(this.txtOwnerName, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.error_address.SetIconAlignment(this.txtOwnerName, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.errorsms.SetIconAlignment(this.txtOwnerName, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.txtOwnerName.Location = new System.Drawing.Point(156, 74);
            this.txtOwnerName.Name = "txtOwnerName";
            this.txtOwnerName.Properties.Appearance.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOwnerName.Properties.Appearance.Options.UseFont = true;
            this.txtOwnerName.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.txtOwnerName.Properties.Mask.EditMask = "n2";
            this.txtOwnerName.Size = new System.Drawing.Size(205, 26);
            this.txtOwnerName.TabIndex = 2;
            this.txtOwnerName.Enter += new System.EventHandler(this.EnterEvent);
            this.txtOwnerName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txtOwnerName.Leave += new System.EventHandler(this.LeaveEvent);
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Location = new System.Drawing.Point(11, 171);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(134, 17);
            this.labelControl4.TabIndex = 78;
            this.labelControl4.Text = "Contact Person Name";
            // 
            // txtSMSNo
            // 
            this.txtSMSNo.EditValue = "";
            this.errorinvestmentamount.SetIconAlignment(this.txtSMSNo, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.errorcompanyCode.SetIconAlignment(this.txtSMSNo, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.errorcst.SetIconAlignment(this.txtSMSNo, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.errorecc.SetIconAlignment(this.txtSMSNo, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.error_contactpersoanname.SetIconAlignment(this.txtSMSNo, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.errorcompanyName.SetIconAlignment(this.txtSMSNo, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.error_panno.SetIconAlignment(this.txtSMSNo, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.errorOwnername.SetIconAlignment(this.txtSMSNo, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.erroropeningdate.SetIconAlignment(this.txtSMSNo, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.error_address.SetIconAlignment(this.txtSMSNo, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.errorsms.SetIconAlignment(this.txtSMSNo, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.txtSMSNo.Location = new System.Drawing.Point(481, 167);
            this.txtSMSNo.Name = "txtSMSNo";
            this.txtSMSNo.Properties.Appearance.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSMSNo.Properties.Appearance.Options.UseFont = true;
            this.txtSMSNo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.txtSMSNo.Properties.Mask.EditMask = "d";
            this.txtSMSNo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtSMSNo.Size = new System.Drawing.Size(205, 26);
            this.txtSMSNo.TabIndex = 10;
            this.txtSMSNo.Enter += new System.EventHandler(this.EnterEvent);
            this.txtSMSNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txtSMSNo.Leave += new System.EventHandler(this.LeaveEvent);
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Location = new System.Drawing.Point(397, 171);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(50, 17);
            this.labelControl7.TabIndex = 76;
            this.labelControl7.Text = "SMS No.";
            // 
            // txtInvestmentAmount
            // 
            this.txtInvestmentAmount.EditValue = "";
            this.errorinvestmentamount.SetIconAlignment(this.txtInvestmentAmount, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.errorcompanyCode.SetIconAlignment(this.txtInvestmentAmount, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.errorcst.SetIconAlignment(this.txtInvestmentAmount, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.errorecc.SetIconAlignment(this.txtInvestmentAmount, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.error_contactpersoanname.SetIconAlignment(this.txtInvestmentAmount, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.errorcompanyName.SetIconAlignment(this.txtInvestmentAmount, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.error_panno.SetIconAlignment(this.txtInvestmentAmount, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.errorOwnername.SetIconAlignment(this.txtInvestmentAmount, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.erroropeningdate.SetIconAlignment(this.txtInvestmentAmount, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.error_address.SetIconAlignment(this.txtInvestmentAmount, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.errorsms.SetIconAlignment(this.txtInvestmentAmount, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.txtInvestmentAmount.Location = new System.Drawing.Point(156, 136);
            this.txtInvestmentAmount.Name = "txtInvestmentAmount";
            this.txtInvestmentAmount.Properties.Appearance.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInvestmentAmount.Properties.Appearance.Options.UseFont = true;
            this.txtInvestmentAmount.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.txtInvestmentAmount.Properties.Mask.EditMask = "n";
            this.txtInvestmentAmount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtInvestmentAmount.Size = new System.Drawing.Size(205, 26);
            this.txtInvestmentAmount.TabIndex = 4;
            this.txtInvestmentAmount.Enter += new System.EventHandler(this.EnterEvent);
            this.txtInvestmentAmount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txtInvestmentAmount.Leave += new System.EventHandler(this.LeaveEvent);
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Location = new System.Drawing.Point(395, 16);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(50, 17);
            this.labelControl8.TabIndex = 75;
            this.labelControl8.Text = "Address";
            // 
            // txtPANNo
            // 
            this.txtPANNo.EditValue = "";
            this.errorinvestmentamount.SetIconAlignment(this.txtPANNo, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.errorcompanyCode.SetIconAlignment(this.txtPANNo, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.errorcst.SetIconAlignment(this.txtPANNo, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.errorecc.SetIconAlignment(this.txtPANNo, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.error_contactpersoanname.SetIconAlignment(this.txtPANNo, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.errorcompanyName.SetIconAlignment(this.txtPANNo, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.error_panno.SetIconAlignment(this.txtPANNo, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.errorOwnername.SetIconAlignment(this.txtPANNo, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.erroropeningdate.SetIconAlignment(this.txtPANNo, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.error_address.SetIconAlignment(this.txtPANNo, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.errorsms.SetIconAlignment(this.txtPANNo, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.txtPANNo.Location = new System.Drawing.Point(481, 74);
            this.txtPANNo.Name = "txtPANNo";
            this.txtPANNo.Properties.Appearance.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPANNo.Properties.Appearance.Options.UseFont = true;
            this.txtPANNo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.txtPANNo.Properties.Mask.EditMask = "n2";
            this.txtPANNo.Size = new System.Drawing.Size(205, 26);
            this.txtPANNo.TabIndex = 7;
            this.txtPANNo.Enter += new System.EventHandler(this.EnterEvent);
            this.txtPANNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txtPANNo.Leave += new System.EventHandler(this.LeaveEvent);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(11, 47);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(93, 17);
            this.labelControl3.TabIndex = 74;
            this.labelControl3.Text = "Company Code";
            // 
            // txtECCNo
            // 
            this.txtECCNo.EditValue = "";
            this.errorinvestmentamount.SetIconAlignment(this.txtECCNo, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.errorcompanyCode.SetIconAlignment(this.txtECCNo, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.errorcst.SetIconAlignment(this.txtECCNo, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.errorecc.SetIconAlignment(this.txtECCNo, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.error_contactpersoanname.SetIconAlignment(this.txtECCNo, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.errorcompanyName.SetIconAlignment(this.txtECCNo, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.error_panno.SetIconAlignment(this.txtECCNo, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.errorOwnername.SetIconAlignment(this.txtECCNo, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.erroropeningdate.SetIconAlignment(this.txtECCNo, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.error_address.SetIconAlignment(this.txtECCNo, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.errorsms.SetIconAlignment(this.txtECCNo, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.txtECCNo.Location = new System.Drawing.Point(481, 136);
            this.txtECCNo.Name = "txtECCNo";
            this.txtECCNo.Properties.Appearance.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtECCNo.Properties.Appearance.Options.UseFont = true;
            this.txtECCNo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.txtECCNo.Properties.Mask.EditMask = "n2";
            this.txtECCNo.Size = new System.Drawing.Size(205, 26);
            this.txtECCNo.TabIndex = 9;
            this.txtECCNo.Enter += new System.EventHandler(this.EnterEvent);
            this.txtECCNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txtECCNo.Leave += new System.EventHandler(this.LeaveEvent);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(11, 78);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(82, 17);
            this.labelControl2.TabIndex = 73;
            this.labelControl2.Text = "Owner Name";
            // 
            // txtCST
            // 
            this.txtCST.EditValue = "";
            this.errorinvestmentamount.SetIconAlignment(this.txtCST, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.errorcompanyCode.SetIconAlignment(this.txtCST, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.errorcst.SetIconAlignment(this.txtCST, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.errorecc.SetIconAlignment(this.txtCST, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.error_contactpersoanname.SetIconAlignment(this.txtCST, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.errorcompanyName.SetIconAlignment(this.txtCST, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.error_panno.SetIconAlignment(this.txtCST, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.errorOwnername.SetIconAlignment(this.txtCST, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.erroropeningdate.SetIconAlignment(this.txtCST, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.error_address.SetIconAlignment(this.txtCST, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.errorsms.SetIconAlignment(this.txtCST, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.txtCST.Location = new System.Drawing.Point(481, 105);
            this.txtCST.Name = "txtCST";
            this.txtCST.Properties.Appearance.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCST.Properties.Appearance.Options.UseFont = true;
            this.txtCST.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.txtCST.Properties.Mask.EditMask = "n2";
            this.txtCST.Size = new System.Drawing.Size(205, 26);
            this.txtCST.TabIndex = 8;
            this.txtCST.Enter += new System.EventHandler(this.EnterEvent);
            this.txtCST.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txtCST.Leave += new System.EventHandler(this.LeaveEvent);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(11, 109);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(84, 17);
            this.labelControl1.TabIndex = 72;
            this.labelControl1.Text = "Opening Date";
            // 
            // errorcompanyName
            // 
            this.errorcompanyName.ContainerControl = this;
            // 
            // errorcompanyCode
            // 
            this.errorcompanyCode.ContainerControl = this;
            // 
            // errorOwnername
            // 
            this.errorOwnername.ContainerControl = this;
            // 
            // erroropeningdate
            // 
            this.erroropeningdate.ContainerControl = this;
            // 
            // errorinvestmentamount
            // 
            this.errorinvestmentamount.ContainerControl = this;
            // 
            // error_contactpersoanname
            // 
            this.error_contactpersoanname.ContainerControl = this;
            // 
            // error_address
            // 
            this.error_address.ContainerControl = this;
            // 
            // error_panno
            // 
            this.error_panno.ContainerControl = this;
            // 
            // errorcst
            // 
            this.errorcst.ContainerControl = this;
            // 
            // errorecc
            // 
            this.errorecc.ContainerControl = this;
            // 
            // errorsms
            // 
            this.errorsms.ContainerControl = this;
            // 
            // frmCompanyMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(854, 228);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCompanyMaster";
            this.ShowInTaskbar = false;
            this.Text = "Company Master";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtaddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dpOpeningDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpOpeningDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCompanyName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContactPerrsonName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCompanyCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOwnerName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSMSNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInvestmentAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPANNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtECCNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCST.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorcompanyName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorcompanyCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorOwnername)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erroropeningdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorinvestmentamount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_contactpersoanname)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_address)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_panno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorcst)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorecc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorsms)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.MemoEdit txtaddress;
        private DevExpress.XtraEditors.DateEdit dpOpeningDate;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.TextEdit txtCompanyName;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.TextEdit txtContactPerrsonName;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.TextEdit txtCompanyCode;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.TextEdit txtOwnerName;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtSMSNo;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txtInvestmentAmount;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit txtPANNo;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtECCNo;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtCST;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider errorcompanyName;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider errorcompanyCode;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider errorOwnername;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider erroropeningdate;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider errorinvestmentamount;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider error_contactpersoanname;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider error_address;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider error_panno;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider errorcst;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider errorecc;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider errorsms;
    }
}
