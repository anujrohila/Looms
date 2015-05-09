namespace LoomsMana.Forms.Master
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gridBroker = new DevExpress.XtraGrid.GridControl();
            this.InnerGrid = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.BrokerID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BrokerName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BrokerFirmName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Address = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MobileNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pnlMain.SuspendLayout();
            this.xtraScrollableControl1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridBroker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InnerGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Size = new System.Drawing.Size(689, 303);
            // 
            // btnAdd
            // 
            this.btnAdd.Appearance.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Appearance.Options.UseFont = true;
            // 
            // btnMasterExcel
            // 
            this.btnMasterExcel.Appearance.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMasterExcel.Appearance.Options.UseFont = true;
            // 
            // BtnMasterPrint
            // 
            this.BtnMasterPrint.Appearance.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMasterPrint.Appearance.Options.UseFont = true;
            // 
            // BtnMasterPDF
            // 
            this.BtnMasterPDF.Appearance.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMasterPDF.Appearance.Options.UseFont = true;
            // 
            // xtraScrollableControl1
            // 
            this.xtraScrollableControl1.Controls.Add(this.groupBox2);
            this.xtraScrollableControl1.Size = new System.Drawing.Size(689, 303);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gridBroker);
            this.groupBox2.Location = new System.Drawing.Point(13, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(670, 291);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // gridBroker
            // 
            this.gridBroker.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridBroker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridBroker.Location = new System.Drawing.Point(3, 16);
            this.gridBroker.MainView = this.InnerGrid;
            this.gridBroker.Name = "gridBroker";
            this.gridBroker.Size = new System.Drawing.Size(664, 272);
            this.gridBroker.TabIndex = 66;
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
            this.ClientSize = new System.Drawing.Size(689, 362);
            this.Name = "frmBrokerMasterView";
            this.pnlMain.ResumeLayout(false);
            this.xtraScrollableControl1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridBroker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InnerGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraGrid.GridControl gridBroker;
        private DevExpress.XtraGrid.Views.Grid.GridView InnerGrid;
        private DevExpress.XtraGrid.Columns.GridColumn BrokerID;
        private DevExpress.XtraGrid.Columns.GridColumn BrokerName;
        private DevExpress.XtraGrid.Columns.GridColumn BrokerFirmName;
        private DevExpress.XtraGrid.Columns.GridColumn Address;
        private DevExpress.XtraGrid.Columns.GridColumn MobileNo;
    }
}
