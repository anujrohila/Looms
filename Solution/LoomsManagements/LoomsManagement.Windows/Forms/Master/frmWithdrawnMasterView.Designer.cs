namespace LoomsManagement.Windows.Forms.Master
{
    partial class frmWithdrawnMasterView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWithdrawnMasterView));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.gridWithdrawnMaster = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.WithdrownID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EmployeeID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.WithdrownDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.WithdrownAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Remarks = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridWithdrawnMaster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnSave);
            this.panelControl1.Location = new System.Drawing.Point(12, 12);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(452, 49);
            this.panelControl1.TabIndex = 3;
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
            // gridWithdrawnMaster
            // 
            this.gridWithdrawnMaster.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridWithdrawnMaster.Location = new System.Drawing.Point(12, 67);
            this.gridWithdrawnMaster.MainView = this.gridView1;
            this.gridWithdrawnMaster.Name = "gridWithdrawnMaster";
            this.gridWithdrawnMaster.Size = new System.Drawing.Size(452, 249);
            this.gridWithdrawnMaster.TabIndex = 4;
            this.gridWithdrawnMaster.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.WithdrownID,
            this.EmployeeID,
            this.WithdrownDate,
            this.WithdrownAmount,
            this.Remarks});
            this.gridView1.GridControl = this.gridWithdrawnMaster;
            this.gridView1.Name = "gridView1";
            // 
            // WithdrownID
            // 
            this.WithdrownID.Caption = "Withdrown ID";
            this.WithdrownID.FieldName = "WithdrownID";
            this.WithdrownID.Name = "WithdrownID";
            // 
            // EmployeeID
            // 
            this.EmployeeID.Caption = "Employee ID";
            this.EmployeeID.FieldName = "EmployeeID";
            this.EmployeeID.Name = "EmployeeID";
            // 
            // WithdrownDate
            // 
            this.WithdrownDate.Caption = "Withdrown Date";
            this.WithdrownDate.FieldName = "WithdrownDate";
            this.WithdrownDate.Name = "WithdrownDate";
            this.WithdrownDate.Visible = true;
            this.WithdrownDate.VisibleIndex = 0;
            this.WithdrownDate.Width = 100;
            // 
            // WithdrownAmount
            // 
            this.WithdrownAmount.Caption = "Withdrown Amount";
            this.WithdrownAmount.FieldName = "WithdrownAmount";
            this.WithdrownAmount.Name = "WithdrownAmount";
            this.WithdrownAmount.Visible = true;
            this.WithdrownAmount.VisibleIndex = 1;
            this.WithdrownAmount.Width = 100;
            // 
            // Remarks
            // 
            this.Remarks.Caption = "Remarks";
            this.Remarks.FieldName = "Remarks";
            this.Remarks.Name = "Remarks";
            this.Remarks.Visible = true;
            this.Remarks.VisibleIndex = 2;
            this.Remarks.Width = 100;
            // 
            // frmWithdrawnMasterView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 328);
            this.Controls.Add(this.gridWithdrawnMaster);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmWithdrawnMasterView";
            this.Text = "Withdrawn Master View";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridWithdrawnMaster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        public DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraGrid.GridControl gridWithdrawnMaster;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn WithdrownID;
        private DevExpress.XtraGrid.Columns.GridColumn EmployeeID;
        private DevExpress.XtraGrid.Columns.GridColumn WithdrownDate;
        private DevExpress.XtraGrid.Columns.GridColumn WithdrownAmount;
        private DevExpress.XtraGrid.Columns.GridColumn Remarks;
    }
}