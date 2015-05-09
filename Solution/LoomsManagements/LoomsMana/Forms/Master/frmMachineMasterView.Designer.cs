namespace LoomsMana.Forms.Master
{
    partial class frmMachineMasterView
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
            this.gridMachineMaster = new DevExpress.XtraGrid.GridControl();
            this.InnerGrid = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MachineID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MachineTypeID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MachineName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.AboutMachine = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pnlMain.SuspendLayout();
            this.xtraScrollableControl1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridMachineMaster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InnerGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Size = new System.Drawing.Size(689, 307);
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
            this.xtraScrollableControl1.Size = new System.Drawing.Size(689, 307);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gridMachineMaster);
            this.groupBox2.Location = new System.Drawing.Point(13, 1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(664, 289);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // gridMachineMaster
            // 
            this.gridMachineMaster.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridMachineMaster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridMachineMaster.Location = new System.Drawing.Point(3, 16);
            this.gridMachineMaster.MainView = this.InnerGrid;
            this.gridMachineMaster.Name = "gridMachineMaster";
            this.gridMachineMaster.Size = new System.Drawing.Size(658, 270);
            this.gridMachineMaster.TabIndex = 66;
            this.gridMachineMaster.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.InnerGrid});
            // 
            // InnerGrid
            // 
            this.InnerGrid.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MachineID,
            this.MachineTypeID,
            this.MachineName,
            this.AboutMachine});
            this.InnerGrid.GridControl = this.gridMachineMaster;
            this.InnerGrid.Name = "InnerGrid";
            // 
            // MachineID
            // 
            this.MachineID.Caption = "MachineID";
            this.MachineID.FieldName = "MachineID";
            this.MachineID.Name = "MachineID";
            // 
            // MachineTypeID
            // 
            this.MachineTypeID.Caption = "MachineTypeID";
            this.MachineTypeID.FieldName = "MachineTypeID";
            this.MachineTypeID.Name = "MachineTypeID";
            // 
            // MachineName
            // 
            this.MachineName.Caption = "Machine Name";
            this.MachineName.FieldName = "MachineName";
            this.MachineName.Name = "MachineName";
            this.MachineName.Visible = true;
            this.MachineName.VisibleIndex = 0;
            // 
            // AboutMachine
            // 
            this.AboutMachine.Caption = "About Machine";
            this.AboutMachine.FieldName = "AboutMachine";
            this.AboutMachine.Name = "AboutMachine";
            this.AboutMachine.Visible = true;
            this.AboutMachine.VisibleIndex = 1;
            // 
            // frmMachineMasterView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(689, 366);
            this.Name = "frmMachineMasterView";
            this.pnlMain.ResumeLayout(false);
            this.xtraScrollableControl1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridMachineMaster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InnerGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraGrid.GridControl gridMachineMaster;
        private DevExpress.XtraGrid.Views.Grid.GridView InnerGrid;
        private DevExpress.XtraGrid.Columns.GridColumn MachineID;
        private DevExpress.XtraGrid.Columns.GridColumn MachineTypeID;
        private DevExpress.XtraGrid.Columns.GridColumn MachineName;
        private DevExpress.XtraGrid.Columns.GridColumn AboutMachine;
    }
}
