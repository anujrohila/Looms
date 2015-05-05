namespace LoomsManagement.Windows.Forms.Master
{
    partial class frmBeamMasterView
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
            this.gridBeamMaster = new DevExpress.XtraGrid.GridControl();
            this.InnerGrid = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.BeamID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CompanyName = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridBeamMaster)).BeginInit();
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
            // gridBeamMaster
            // 
            this.gridBeamMaster.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridBeamMaster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridBeamMaster.Location = new System.Drawing.Point(0, 43);
            this.gridBeamMaster.MainView = this.InnerGrid;
            this.gridBeamMaster.Name = "gridBeamMaster";
            this.gridBeamMaster.Size = new System.Drawing.Size(796, 338);
            this.gridBeamMaster.TabIndex = 65;
            this.gridBeamMaster.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.InnerGrid});
            // 
            // InnerGrid
            // 
            this.InnerGrid.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.BeamID,
            this.CompanyName});
            this.InnerGrid.GridControl = this.gridBeamMaster;
            this.InnerGrid.Name = "InnerGrid";
            this.InnerGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InnerGrid_KeyDown);
            // 
            // BeamID
            // 
            this.BeamID.Caption = "BeamID";
            this.BeamID.FieldName = "BeamID";
            this.BeamID.Name = "BeamID";
            // 
            // CompanyName
            // 
            this.CompanyName.Caption = "Company Name";
            this.CompanyName.FieldName = "CompanyName";
            this.CompanyName.Name = "CompanyName";
            this.CompanyName.Visible = true;
            this.CompanyName.VisibleIndex = 0;
            // 
            // frmBeamMasterView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(796, 381);
            this.Controls.Add(this.gridBeamMaster);
            this.Name = "frmBeamMasterView";
            this.Text = "Beam Master Detail";
            this.Controls.SetChildIndex(this.gridBeamMaster, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gridBeamMaster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InnerGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridBeamMaster;
        private DevExpress.XtraGrid.Views.Grid.GridView InnerGrid;
        private DevExpress.XtraGrid.Columns.GridColumn BeamID;
        private DevExpress.XtraGrid.Columns.GridColumn CompanyName;
    }
}
