namespace LoomsManagement.Windows.Forms.Master
{
    partial class PartyMasterView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PartyMasterView));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.PartyID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CompanyCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PartyName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ContactPersonName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.OfficeAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ShippingAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.City = new DevExpress.XtraGrid.Columns.GridColumn();
            this.State = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MobileNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PhoneNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SMSNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ReferencePersonName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ReferencePersonMobileNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EmailID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ExtraDetails = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TINNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TINDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PANNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CSTTINNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CSTDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ECCNo = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnSave);
            this.panelControl1.Location = new System.Drawing.Point(8, 6);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(964, 49);
            this.panelControl1.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Appearance.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(15, 9);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(86, 31);
            this.btnSave.TabIndex = 58;
            this.btnSave.Text = "&Add";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.gridControl1);
            this.panelControl2.Location = new System.Drawing.Point(12, 61);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(964, 389);
            this.panelControl2.TabIndex = 1;
            // 
            // gridControl1
            // 
            this.gridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl1.Location = new System.Drawing.Point(5, 5);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(954, 379);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.PartyID,
            this.CompanyCode,
            this.PartyName,
            this.ContactPersonName,
            this.OfficeAddress,
            this.ShippingAddress,
            this.City,
            this.State,
            this.MobileNo,
            this.PhoneNo,
            this.SMSNo,
            this.ReferencePersonName,
            this.ReferencePersonMobileNo,
            this.EmailID,
            this.ExtraDetails,
            this.TINNo,
            this.TINDate,
            this.PANNO,
            this.CSTTINNo,
            this.CSTDate,
            this.ECCNo});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // PartyID
            // 
            this.PartyID.Caption = "Party ID";
            this.PartyID.FieldName = "PartyID";
            this.PartyID.Name = "PartyID";
            this.PartyID.Visible = true;
            this.PartyID.VisibleIndex = 0;
            // 
            // CompanyCode
            // 
            this.CompanyCode.Caption = "Company Code";
            this.CompanyCode.FieldName = "CompanyCode";
            this.CompanyCode.Name = "CompanyCode";
            this.CompanyCode.Visible = true;
            this.CompanyCode.VisibleIndex = 1;
            // 
            // PartyName
            // 
            this.PartyName.Caption = "Party Name";
            this.PartyName.FieldName = "PartyName";
            this.PartyName.Name = "PartyName";
            this.PartyName.Visible = true;
            this.PartyName.VisibleIndex = 2;
            // 
            // ContactPersonName
            // 
            this.ContactPersonName.Caption = "Contact Person Name";
            this.ContactPersonName.FieldName = "ContactPersonName";
            this.ContactPersonName.Name = "ContactPersonName";
            this.ContactPersonName.Visible = true;
            this.ContactPersonName.VisibleIndex = 3;
            // 
            // OfficeAddress
            // 
            this.OfficeAddress.Caption = "Office Address";
            this.OfficeAddress.FieldName = "OfficeAddress";
            this.OfficeAddress.Name = "OfficeAddress";
            this.OfficeAddress.Visible = true;
            this.OfficeAddress.VisibleIndex = 4;
            // 
            // ShippingAddress
            // 
            this.ShippingAddress.Caption = "Shipping Address";
            this.ShippingAddress.FieldName = "ShippingAddress";
            this.ShippingAddress.Name = "ShippingAddress";
            this.ShippingAddress.Visible = true;
            this.ShippingAddress.VisibleIndex = 5;
            // 
            // City
            // 
            this.City.Caption = "City";
            this.City.FieldName = "City";
            this.City.Name = "City";
            this.City.Visible = true;
            this.City.VisibleIndex = 6;
            // 
            // State
            // 
            this.State.Caption = "State";
            this.State.FieldName = "State";
            this.State.Name = "State";
            this.State.Visible = true;
            this.State.VisibleIndex = 7;
            // 
            // MobileNo
            // 
            this.MobileNo.Caption = "Mobile No";
            this.MobileNo.FieldName = "MobileNo";
            this.MobileNo.Name = "MobileNo";
            this.MobileNo.Visible = true;
            this.MobileNo.VisibleIndex = 8;
            // 
            // PhoneNo
            // 
            this.PhoneNo.Caption = "Phone No.";
            this.PhoneNo.FieldName = "PhoneNo";
            this.PhoneNo.Name = "PhoneNo";
            this.PhoneNo.Visible = true;
            this.PhoneNo.VisibleIndex = 9;
            // 
            // SMSNo
            // 
            this.SMSNo.Caption = "SMS No.";
            this.SMSNo.FieldName = "SMSNo";
            this.SMSNo.Name = "SMSNo";
            this.SMSNo.Visible = true;
            this.SMSNo.VisibleIndex = 10;
            // 
            // ReferencePersonName
            // 
            this.ReferencePersonName.Caption = "Reference Person Name";
            this.ReferencePersonName.FieldName = "ReferencePersonName";
            this.ReferencePersonName.Name = "ReferencePersonName";
            this.ReferencePersonName.Visible = true;
            this.ReferencePersonName.VisibleIndex = 11;
            // 
            // ReferencePersonMobileNo
            // 
            this.ReferencePersonMobileNo.Caption = "Reference Person Mobile No";
            this.ReferencePersonMobileNo.FieldName = "ReferencePersonMobileNo";
            this.ReferencePersonMobileNo.Name = "ReferencePersonMobileNo";
            this.ReferencePersonMobileNo.Visible = true;
            this.ReferencePersonMobileNo.VisibleIndex = 12;
            // 
            // EmailID
            // 
            this.EmailID.Caption = "Email ID";
            this.EmailID.FieldName = "EmailID";
            this.EmailID.Name = "EmailID";
            this.EmailID.Visible = true;
            this.EmailID.VisibleIndex = 13;
            // 
            // ExtraDetails
            // 
            this.ExtraDetails.Caption = "ExtraDetails";
            this.ExtraDetails.FieldName = "ExtraDetails";
            this.ExtraDetails.Name = "ExtraDetails";
            this.ExtraDetails.Visible = true;
            this.ExtraDetails.VisibleIndex = 14;
            // 
            // TINNo
            // 
            this.TINNo.Caption = "TIN No.";
            this.TINNo.FieldName = "TINNo";
            this.TINNo.Name = "TINNo";
            this.TINNo.Visible = true;
            this.TINNo.VisibleIndex = 15;
            // 
            // TINDate
            // 
            this.TINDate.Caption = "TIN Date";
            this.TINDate.FieldName = "TINDate";
            this.TINDate.Name = "TINDate";
            this.TINDate.Visible = true;
            this.TINDate.VisibleIndex = 16;
            // 
            // PANNO
            // 
            this.PANNO.Caption = "PAN No.";
            this.PANNO.FieldName = "PANNO";
            this.PANNO.Name = "PANNO";
            this.PANNO.Visible = true;
            this.PANNO.VisibleIndex = 17;
            // 
            // CSTTINNo
            // 
            this.CSTTINNo.Caption = "CST TIN No";
            this.CSTTINNo.FieldName = "CSTTINNo";
            this.CSTTINNo.Name = "CSTTINNo";
            this.CSTTINNo.Visible = true;
            this.CSTTINNo.VisibleIndex = 18;
            // 
            // CSTDate
            // 
            this.CSTDate.Caption = "CST Date";
            this.CSTDate.FieldName = "CSTDate";
            this.CSTDate.Name = "CSTDate";
            this.CSTDate.Visible = true;
            this.CSTDate.VisibleIndex = 19;
            // 
            // ECCNo
            // 
            this.ECCNo.Caption = "ECC No.";
            this.ECCNo.FieldName = "ECCNo";
            this.ECCNo.Name = "ECCNo";
            this.ECCNo.Visible = true;
            this.ECCNo.VisibleIndex = 20;
            // 
            // PartyMasterView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 471);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "PartyMasterView";
            this.Text = "Party Master View";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        public DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraGrid.Columns.GridColumn PartyID;
        private DevExpress.XtraGrid.Columns.GridColumn CompanyCode;
        private DevExpress.XtraGrid.Columns.GridColumn PartyName;
        private DevExpress.XtraGrid.Columns.GridColumn ContactPersonName;
        private DevExpress.XtraGrid.Columns.GridColumn OfficeAddress;
        private DevExpress.XtraGrid.Columns.GridColumn ShippingAddress;
        private DevExpress.XtraGrid.Columns.GridColumn City;
        private DevExpress.XtraGrid.Columns.GridColumn State;
        private DevExpress.XtraGrid.Columns.GridColumn MobileNo;
        private DevExpress.XtraGrid.Columns.GridColumn PhoneNo;
        private DevExpress.XtraGrid.Columns.GridColumn SMSNo;
        private DevExpress.XtraGrid.Columns.GridColumn ReferencePersonName;
        private DevExpress.XtraGrid.Columns.GridColumn ReferencePersonMobileNo;
        private DevExpress.XtraGrid.Columns.GridColumn EmailID;
        private DevExpress.XtraGrid.Columns.GridColumn ExtraDetails;
        private DevExpress.XtraGrid.Columns.GridColumn TINNo;
        private DevExpress.XtraGrid.Columns.GridColumn TINDate;
        private DevExpress.XtraGrid.Columns.GridColumn PANNO;
        private DevExpress.XtraGrid.Columns.GridColumn CSTTINNo;
        private DevExpress.XtraGrid.Columns.GridColumn CSTDate;
        private DevExpress.XtraGrid.Columns.GridColumn ECCNo;
    }
}