namespace LoomsManagement.Windows.Forms.Master
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
            this.gridMachineMaster = new DevExpress.XtraGrid.GridControl();
            this.InnerGrid = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MachineID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MachineTypeID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MachineName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.AboutMachine = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridMachineMaster)).BeginInit();
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
            // gridMachineMaster
            // 
            this.gridMachineMaster.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridMachineMaster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridMachineMaster.Location = new System.Drawing.Point(0, 43);
            this.gridMachineMaster.MainView = this.InnerGrid;
            this.gridMachineMaster.Name = "gridMachineMaster";
            this.gridMachineMaster.Size = new System.Drawing.Size(796, 338);
            this.gridMachineMaster.TabIndex = 65;
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
            this.InnerGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InnerGrid_KeyDown);
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
            this.ClientSize = new System.Drawing.Size(796, 381);
            this.Controls.Add(this.gridMachineMaster);
            this.Name = "frmMachineMasterView";
            this.Text = "Machine Master Details";
            this.Controls.SetChildIndex(this.gridMachineMaster, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gridMachineMaster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InnerGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridMachineMaster;
        private DevExpress.XtraGrid.Views.Grid.GridView InnerGrid;
        private DevExpress.XtraGrid.Columns.GridColumn MachineID;
        private DevExpress.XtraGrid.Columns.GridColumn MachineTypeID;
        private DevExpress.XtraGrid.Columns.GridColumn MachineName;
        private DevExpress.XtraGrid.Columns.GridColumn AboutMachine;
    }
}
