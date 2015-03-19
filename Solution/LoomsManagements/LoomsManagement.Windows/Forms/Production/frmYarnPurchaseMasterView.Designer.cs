namespace LoomsManagement.Windows.Forms.Production
{
    partial class frmYarnPurchaseMasterView
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
            this.gridPurchaseMasterView = new DevExpress.XtraGrid.GridControl();
            this.InnerGrid = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.PurchaseID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SRNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PurchaseDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ChallanNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LRNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RecieveAt = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridPurchaseMasterView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InnerGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnMasterPDF
            // 
            this.BtnMasterPDF.Appearance.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMasterPDF.Appearance.Options.UseFont = true;
            this.BtnMasterPDF.Click += new System.EventHandler(this.BtnMasterPDF_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Appearance.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Appearance.Options.UseFont = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // BtnMasterPrint
            // 
            this.BtnMasterPrint.Appearance.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMasterPrint.Appearance.Options.UseFont = true;
            this.BtnMasterPrint.Click += new System.EventHandler(this.BtnMasterPrint_Click);
            // 
            // btnMasterExcel
            // 
            this.btnMasterExcel.Appearance.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMasterExcel.Appearance.Options.UseFont = true;
            this.btnMasterExcel.Click += new System.EventHandler(this.btnMasterExcel_Click);
            // 
            // gridPurchaseMasterView
            // 
            this.gridPurchaseMasterView.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridPurchaseMasterView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridPurchaseMasterView.Location = new System.Drawing.Point(0, 43);
            this.gridPurchaseMasterView.MainView = this.InnerGrid;
            this.gridPurchaseMasterView.Name = "gridPurchaseMasterView";
            this.gridPurchaseMasterView.Size = new System.Drawing.Size(796, 338);
            this.gridPurchaseMasterView.TabIndex = 65;
            this.gridPurchaseMasterView.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.InnerGrid});
            // 
            // InnerGrid
            // 
            this.InnerGrid.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.PurchaseID,
            this.SRNo,
            this.PurchaseDate,
            this.ChallanNo,
            this.LRNo,
            this.RecieveAt});
            this.InnerGrid.GridControl = this.gridPurchaseMasterView;
            this.InnerGrid.Name = "InnerGrid";
            this.InnerGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InnerGrid_KeyDown);
            // 
            // PurchaseID
            // 
            this.PurchaseID.Caption = "PurchaseID";
            this.PurchaseID.FieldName = "PurchaseID";
            this.PurchaseID.Name = "PurchaseID";
            // 
            // SRNo
            // 
            this.SRNo.Caption = "Serial Number";
            this.SRNo.FieldName = "SRNo";
            this.SRNo.Name = "SRNo";
            this.SRNo.Visible = true;
            this.SRNo.VisibleIndex = 0;
            // 
            // PurchaseDate
            // 
            this.PurchaseDate.Caption = "Purchase Date";
            this.PurchaseDate.FieldName = "PurchaseDate";
            this.PurchaseDate.Name = "PurchaseDate";
            this.PurchaseDate.Visible = true;
            this.PurchaseDate.VisibleIndex = 1;
            // 
            // ChallanNo
            // 
            this.ChallanNo.Caption = "Challan Number";
            this.ChallanNo.FieldName = "ChallanNo";
            this.ChallanNo.Name = "ChallanNo";
            this.ChallanNo.Visible = true;
            this.ChallanNo.VisibleIndex = 2;
            // 
            // LRNo
            // 
            this.LRNo.Caption = "LRNo";
            this.LRNo.FieldName = "LRNo";
            this.LRNo.Name = "LRNo";
            this.LRNo.Visible = true;
            this.LRNo.VisibleIndex = 3;
            // 
            // RecieveAt
            // 
            this.RecieveAt.Caption = "Recieve At";
            this.RecieveAt.FieldName = "RecieveAt";
            this.RecieveAt.Name = "RecieveAt";
            this.RecieveAt.Visible = true;
            this.RecieveAt.VisibleIndex = 4;
            // 
            // frmYarnPurchaseMasterView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(796, 381);
            this.Controls.Add(this.gridPurchaseMasterView);
            this.Name = "frmYarnPurchaseMasterView";
            this.Text = "Yarn Purchase Master Details";
            this.Controls.SetChildIndex(this.gridPurchaseMasterView, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gridPurchaseMasterView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InnerGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridPurchaseMasterView;
        private DevExpress.XtraGrid.Views.Grid.GridView InnerGrid;
        private DevExpress.XtraGrid.Columns.GridColumn PurchaseID;
        private DevExpress.XtraGrid.Columns.GridColumn SRNo;
        private DevExpress.XtraGrid.Columns.GridColumn PurchaseDate;
        private DevExpress.XtraGrid.Columns.GridColumn ChallanNo;
        private DevExpress.XtraGrid.Columns.GridColumn LRNo;
        private DevExpress.XtraGrid.Columns.GridColumn RecieveAt;
    }
}
