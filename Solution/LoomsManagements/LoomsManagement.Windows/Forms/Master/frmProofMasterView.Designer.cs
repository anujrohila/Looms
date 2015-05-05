namespace LoomsManagement.Windows.Forms.Master
{
    partial class frmProofMasterView
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
            this.gridProofMaster = new DevExpress.XtraGrid.GridControl();
            this.InnerGrid = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ProfeID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Name = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridProofMaster)).BeginInit();
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
            // gridProofMaster
            // 
            this.gridProofMaster.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridProofMaster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridProofMaster.Location = new System.Drawing.Point(0, 43);
            this.gridProofMaster.MainView = this.InnerGrid;
            this.gridProofMaster.Name = "gridProofMaster";
            this.gridProofMaster.Size = new System.Drawing.Size(796, 232);
            this.gridProofMaster.TabIndex = 65;
            this.gridProofMaster.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.InnerGrid});
            // 
            // InnerGrid
            // 
            this.InnerGrid.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ProfeID,
            this.Name});
            this.InnerGrid.GridControl = this.gridProofMaster;
            this.InnerGrid.Name = "InnerGrid";
            this.InnerGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InnerGrid_KeyDown);
            // 
            // ProfeID
            // 
            this.ProfeID.Caption = "ProfeID";
            this.ProfeID.FieldName = "ProfeID";
            this.ProfeID.Name = "ProfeID";
            // 
            // Name
            // 
            this.Name.Caption = "Name";
            this.Name.FieldName = "Name";
            this.Name.Name = "Name";
            this.Name.Visible = true;
            this.Name.VisibleIndex = 0;
            // 
            // frmProofMasterView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(796, 275);
            this.Controls.Add(this.gridProofMaster);
           
            this.Tag = "Proof Master View";
            this.Text = "Proof Master Details";
            this.Controls.SetChildIndex(this.gridProofMaster, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gridProofMaster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InnerGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridProofMaster;
        private DevExpress.XtraGrid.Views.Grid.GridView InnerGrid;
        private DevExpress.XtraGrid.Columns.GridColumn ProfeID;
        private DevExpress.XtraGrid.Columns.GridColumn Name;
    }
}
