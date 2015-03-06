namespace LoomsManagement.Windows.Forms.Master
{
    partial class frmCompanyView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCompanyView));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.CompanyID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CompanyName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ComapnyCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.OwnerName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ContactPersonName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Address = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CreationDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.StartDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.InvestmentAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PANNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CSTNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ECCNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SMSNO = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl1.Location = new System.Drawing.Point(12, 72);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(749, 352);
            this.gridControl1.TabIndex = 61;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.CompanyID,
            this.CompanyName,
            this.ComapnyCode,
            this.OwnerName,
            this.ContactPersonName,
            this.Address,
            this.CreationDate,
            this.StartDate,
            this.InvestmentAmount,
            this.PANNo,
            this.CSTNo,
            this.ECCNo,
            this.SMSNO});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnSave);
            this.panelControl1.Location = new System.Drawing.Point(12, 12);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(749, 54);
            this.panelControl1.TabIndex = 62;
            // 
            // btnSave
            // 
            this.btnSave.Appearance.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(18, 11);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(86, 31);
            this.btnSave.TabIndex = 59;
            this.btnSave.Text = "&Add";
            // 
            // CompanyID
            // 
            this.CompanyID.Caption = "Company ID";
            this.CompanyID.FieldName = "CompanyID";
            this.CompanyID.Name = "CompanyID";
            // 
            // CompanyName
            // 
            this.CompanyName.Caption = "Company Name";
            this.CompanyName.FieldName = "CompanyName";
            this.CompanyName.Name = "CompanyName";
            this.CompanyName.Visible = true;
            this.CompanyName.VisibleIndex = 0;
            this.CompanyName.Width = 83;
            // 
            // ComapnyCode
            // 
            this.ComapnyCode.Caption = "Comapny Code";
            this.ComapnyCode.FieldName = "ComapnyCode";
            this.ComapnyCode.Name = "ComapnyCode";
            this.ComapnyCode.Visible = true;
            this.ComapnyCode.VisibleIndex = 1;
            this.ComapnyCode.Width = 86;
            // 
            // OwnerName
            // 
            this.OwnerName.Caption = "Owner Name";
            this.OwnerName.FieldName = "OwnerName";
            this.OwnerName.Name = "OwnerName";
            this.OwnerName.Visible = true;
            this.OwnerName.VisibleIndex = 2;
            this.OwnerName.Width = 70;
            // 
            // ContactPersonName
            // 
            this.ContactPersonName.Caption = "Contact Person Name";
            this.ContactPersonName.FieldName = "ContactPersonName";
            this.ContactPersonName.Name = "ContactPersonName";
            this.ContactPersonName.Visible = true;
            this.ContactPersonName.VisibleIndex = 3;
            this.ContactPersonName.Width = 114;
            // 
            // Address
            // 
            this.Address.Caption = "Address";
            this.Address.FieldName = "Address";
            this.Address.Name = "Address";
            this.Address.Visible = true;
            this.Address.VisibleIndex = 4;
            this.Address.Width = 48;
            // 
            // CreationDate
            // 
            this.CreationDate.Caption = "Creation Date";
            this.CreationDate.FieldName = "CreationDate";
            this.CreationDate.Name = "CreationDate";
            this.CreationDate.Visible = true;
            this.CreationDate.VisibleIndex = 5;
            this.CreationDate.Width = 74;
            // 
            // StartDate
            // 
            this.StartDate.Caption = "Start Date";
            this.StartDate.FieldName = "StartDate";
            this.StartDate.Name = "StartDate";
            this.StartDate.Visible = true;
            this.StartDate.VisibleIndex = 6;
            this.StartDate.Width = 61;
            // 
            // InvestmentAmount
            // 
            this.InvestmentAmount.Caption = "Investment Amount";
            this.InvestmentAmount.FieldName = "InvestmentAmount";
            this.InvestmentAmount.Name = "InvestmentAmount";
            this.InvestmentAmount.Visible = true;
            this.InvestmentAmount.VisibleIndex = 7;
            this.InvestmentAmount.Width = 85;
            // 
            // PANNo
            // 
            this.PANNo.Caption = "PAN Number";
            this.PANNo.FieldName = "PANNo";
            this.PANNo.Name = "PANNo";
            this.PANNo.Visible = true;
            this.PANNo.VisibleIndex = 8;
            this.PANNo.Width = 54;
            // 
            // CSTNo
            // 
            this.CSTNo.Caption = "CST Number";
            this.CSTNo.FieldName = "CSTNo";
            this.CSTNo.Name = "CSTNo";
            this.CSTNo.Visible = true;
            this.CSTNo.VisibleIndex = 9;
            this.CSTNo.Width = 37;
            // 
            // ECCNo
            // 
            this.ECCNo.Caption = "ECC Number";
            this.ECCNo.FieldName = "ECCNo";
            this.ECCNo.Name = "ECCNo";
            this.ECCNo.Visible = true;
            this.ECCNo.VisibleIndex = 10;
            this.ECCNo.Width = 34;
            // 
            // SMSNO
            // 
            this.SMSNO.Caption = "SMS Number";
            this.SMSNO.FieldName = "SMSNO";
            this.SMSNO.Name = "SMSNO";
            this.SMSNO.Visible = true;
            this.SMSNO.VisibleIndex = 11;
            this.SMSNO.Width = 20;
            // 
            // CompanyView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 436);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "CompanyView";
            this.Text = "CompanyView";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.Columns.GridColumn CompanyID;
        private DevExpress.XtraGrid.Columns.GridColumn CompanyName;
        private DevExpress.XtraGrid.Columns.GridColumn ComapnyCode;
        private DevExpress.XtraGrid.Columns.GridColumn OwnerName;
        private DevExpress.XtraGrid.Columns.GridColumn ContactPersonName;
        private DevExpress.XtraGrid.Columns.GridColumn Address;
        private DevExpress.XtraGrid.Columns.GridColumn CreationDate;
        private DevExpress.XtraGrid.Columns.GridColumn StartDate;
        private DevExpress.XtraGrid.Columns.GridColumn InvestmentAmount;
        private DevExpress.XtraGrid.Columns.GridColumn PANNo;
        private DevExpress.XtraGrid.Columns.GridColumn CSTNo;
        private DevExpress.XtraGrid.Columns.GridColumn ECCNo;
        private DevExpress.XtraGrid.Columns.GridColumn SMSNO;
        public DevExpress.XtraEditors.SimpleButton btnSave;
    }
}