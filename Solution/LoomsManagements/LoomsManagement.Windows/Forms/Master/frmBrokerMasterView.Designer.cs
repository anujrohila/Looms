namespace LoomsManagement.Windows.Forms.Master
{
    partial class frmBrokerMasterView
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
            this.gridBroker = new DevExpress.XtraGrid.GridControl();
            this.InnerGrid = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.BrokerID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BrokerName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BrokerFirmName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Address = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MobileNo = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridBroker)).BeginInit();
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
            // gridBroker
            // 
            this.gridBroker.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridBroker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridBroker.Location = new System.Drawing.Point(0, 43);
            this.gridBroker.MainView = this.InnerGrid;
            this.gridBroker.Name = "gridBroker";
            this.gridBroker.Size = new System.Drawing.Size(796, 338);
            this.gridBroker.TabIndex = 65;
            this.gridBroker.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.InnerGrid});
            // 
            // InnerGrid
            // 
            this.InnerGrid.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.BrokerID,
            this.BrokerName,
            this.BrokerFirmName,
            this.Address,
            this.MobileNo});
            this.InnerGrid.GridControl = this.gridBroker;
            this.InnerGrid.Name = "InnerGrid";
            this.InnerGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InnerGrid_KeyDown);
            // 
            // BrokerID
            // 
            this.BrokerID.Caption = "BrokerID";
            this.BrokerID.FieldName = "BrokerID";
            this.BrokerID.Name = "BrokerID";
            // 
            // BrokerName
            // 
            this.BrokerName.Caption = "Broker Name";
            this.BrokerName.FieldName = "BrokerName";
            this.BrokerName.Name = "BrokerName";
            this.BrokerName.Visible = true;
            this.BrokerName.VisibleIndex = 0;
            // 
            // BrokerFirmName
            // 
            this.BrokerFirmName.Caption = "Broker Firm Name";
            this.BrokerFirmName.FieldName = "BrokerFirmName";
            this.BrokerFirmName.Name = "BrokerFirmName";
            this.BrokerFirmName.Visible = true;
            this.BrokerFirmName.VisibleIndex = 1;
            // 
            // Address
            // 
            this.Address.Caption = "Address";
            this.Address.FieldName = "Address";
            this.Address.Name = "Address";
            this.Address.Visible = true;
            this.Address.VisibleIndex = 2;
            // 
            // MobileNo
            // 
            this.MobileNo.Caption = "Mobile Number";
            this.MobileNo.FieldName = "MobileNo";
            this.MobileNo.Name = "MobileNo";
            this.MobileNo.Visible = true;
            this.MobileNo.VisibleIndex = 3;
            // 
            // frmBrokerMasterView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(796, 381);
            this.Controls.Add(this.gridBroker);
            this.Name = "frmBrokerMasterView";
            this.Tag = "Broker Master View";
            this.Text = "Broker Master Details";
            this.Controls.SetChildIndex(this.gridBroker, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gridBroker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InnerGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridBroker;
        private DevExpress.XtraGrid.Views.Grid.GridView InnerGrid;
        private DevExpress.XtraGrid.Columns.GridColumn BrokerID;
        private DevExpress.XtraGrid.Columns.GridColumn BrokerName;
        private DevExpress.XtraGrid.Columns.GridColumn BrokerFirmName;
        private DevExpress.XtraGrid.Columns.GridColumn Address;
        private DevExpress.XtraGrid.Columns.GridColumn MobileNo;
    }
}
