namespace LoomsManagement.Windows.Forms.Master
{
    partial class frmBankMasterView
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
            this.gridBankMaster = new DevExpress.XtraGrid.GridControl();
            this.InnerGrid = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.BankID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BankName = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridBankMaster)).BeginInit();
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
            // gridBankMaster
            // 
            this.gridBankMaster.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridBankMaster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridBankMaster.Location = new System.Drawing.Point(0, 43);
            this.gridBankMaster.MainView = this.InnerGrid;
            this.gridBankMaster.Name = "gridBankMaster";
            this.gridBankMaster.Size = new System.Drawing.Size(796, 338);
            this.gridBankMaster.TabIndex = 65;
            this.gridBankMaster.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.InnerGrid});
            // 
            // InnerGrid
            // 
            this.InnerGrid.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.BankID,
            this.BankName});
            this.InnerGrid.GridControl = this.gridBankMaster;
            this.InnerGrid.Name = "InnerGrid";
            this.InnerGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InnerGrid_KeyDown);
            // 
            // BankID
            // 
            this.BankID.Caption = "BankID";
            this.BankID.FieldName = "BankID";
            this.BankID.Name = "BankID";
            // 
            // BankName
            // 
            this.BankName.Caption = "Bank Name";
            this.BankName.FieldName = "BankName";
            this.BankName.Name = "BankName";
            this.BankName.Visible = true;
            this.BankName.VisibleIndex = 0;
            // 
            // frmBankMasterView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(796, 381);
            this.Controls.Add(this.gridBankMaster);
            this.Name = "frmBankMasterView";
            this.Text = "Bank Master Detail";
            this.Controls.SetChildIndex(this.gridBankMaster, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gridBankMaster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InnerGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridBankMaster;
        private DevExpress.XtraGrid.Views.Grid.GridView InnerGrid;
        private DevExpress.XtraGrid.Columns.GridColumn BankID;
        private DevExpress.XtraGrid.Columns.GridColumn BankName;
    }
}
