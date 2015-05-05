namespace LoomsManagement.Windows.Forms.Master
{
    partial class frmFiscalYearView
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
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            this.gridViewFiscalYear = new DevExpress.XtraGrid.GridControl();
            this.InnerGrid = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.FiscalYearId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FiscalName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.StartDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EndDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Btn_Edit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.Btn_Delete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.Btn_View = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewFiscalYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InnerGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Delete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_View)).BeginInit();
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
            // gridViewFiscalYear
            // 
            this.gridViewFiscalYear.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridViewFiscalYear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridViewFiscalYear.Location = new System.Drawing.Point(0, 43);
            this.gridViewFiscalYear.MainView = this.InnerGrid;
            this.gridViewFiscalYear.Name = "gridViewFiscalYear";
            this.gridViewFiscalYear.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.Btn_Edit,
            this.Btn_Delete,
            this.Btn_View});
            this.gridViewFiscalYear.Size = new System.Drawing.Size(796, 338);
            this.gridViewFiscalYear.TabIndex = 65;
            this.gridViewFiscalYear.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.InnerGrid});
            // 
            // InnerGrid
            // 
            this.InnerGrid.Appearance.FooterPanel.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InnerGrid.Appearance.FooterPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.InnerGrid.Appearance.FooterPanel.Options.UseFont = true;
            this.InnerGrid.Appearance.FooterPanel.Options.UseForeColor = true;
            this.InnerGrid.Appearance.HeaderPanel.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InnerGrid.Appearance.HeaderPanel.Options.UseFont = true;
            this.InnerGrid.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.InnerGrid.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.InnerGrid.Appearance.Row.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InnerGrid.Appearance.Row.Options.UseFont = true;
            this.InnerGrid.ColumnPanelRowHeight = 25;
            this.InnerGrid.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.FiscalYearId,
            this.FiscalName,
            this.StartDate,
            this.EndDate});
            this.InnerGrid.GridControl = this.gridViewFiscalYear;
            this.InnerGrid.Name = "InnerGrid";
            this.InnerGrid.OptionsBehavior.ReadOnly = true;
            this.InnerGrid.OptionsCustomization.AllowGroup = false;
            this.InnerGrid.OptionsNavigation.UseTabKey = false;
            this.InnerGrid.OptionsView.BestFitUseErrorInfo = DevExpress.Utils.DefaultBoolean.True;
            this.InnerGrid.OptionsView.ShowAutoFilterRow = true;
            this.InnerGrid.OptionsView.ShowFooter = true;
            this.InnerGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InnderGrid_KeyDown);
            // 
            // FiscalYearId
            // 
            this.FiscalYearId.AppearanceCell.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FiscalYearId.AppearanceCell.Options.UseFont = true;
            this.FiscalYearId.Caption = "FiscalYearId";
            this.FiscalYearId.FieldName = "FiscalYearId";
            this.FiscalYearId.Name = "FiscalYearId";
            this.FiscalYearId.OptionsColumn.Printable = DevExpress.Utils.DefaultBoolean.False;
            // 
            // FiscalName
            // 
            this.FiscalName.AppearanceCell.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FiscalName.AppearanceCell.Options.UseFont = true;
            this.FiscalName.Caption = "Fiscal Name";
            this.FiscalName.FieldName = "FiscalName";
            this.FiscalName.Name = "FiscalName";
            this.FiscalName.Visible = true;
            this.FiscalName.VisibleIndex = 0;
            // 
            // StartDate
            // 
            this.StartDate.AppearanceCell.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartDate.AppearanceCell.Options.UseFont = true;
            this.StartDate.Caption = "Start Date";
            this.StartDate.FieldName = "StartDate";
            this.StartDate.Name = "StartDate";
            this.StartDate.Visible = true;
            this.StartDate.VisibleIndex = 1;
            this.StartDate.Width = 117;
            // 
            // EndDate
            // 
            this.EndDate.Caption = "End Date";
            this.EndDate.FieldName = "EndDate";
            this.EndDate.Name = "EndDate";
            this.EndDate.Visible = true;
            this.EndDate.VisibleIndex = 2;
            // 
            // Btn_Edit
            // 
            this.Btn_Edit.AutoHeight = false;
            this.Btn_Edit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, global::LoomsManagement.Windows.Properties.Resources.edit_icon, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.Btn_Edit.Name = "Btn_Edit";
            this.Btn_Edit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.AutoHeight = false;
            this.Btn_Delete.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, global::LoomsManagement.Windows.Properties.Resources.delete, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", null, null, true)});
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // Btn_View
            // 
            this.Btn_View.AutoHeight = false;
            this.Btn_View.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, global::LoomsManagement.Windows.Properties.Resources.viewBtn, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject3, "", null, null, true)});
            this.Btn_View.Name = "Btn_View";
            this.Btn_View.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // frmFiscalYearView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(796, 381);
            this.Controls.Add(this.gridViewFiscalYear);
            this.Name = "frmFiscalYearView";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.frmFiscalYearView_Activated);
            this.Controls.SetChildIndex(this.gridViewFiscalYear, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewFiscalYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InnerGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Delete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_View)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public DevExpress.XtraGrid.GridControl gridViewFiscalYear;
        public DevExpress.XtraGrid.Views.Grid.GridView InnerGrid;
        private DevExpress.XtraGrid.Columns.GridColumn FiscalYearId;
        private DevExpress.XtraGrid.Columns.GridColumn StartDate;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit Btn_View;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit Btn_Edit;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit Btn_Delete;
        private DevExpress.XtraGrid.Columns.GridColumn FiscalName;
        private DevExpress.XtraGrid.Columns.GridColumn EndDate;
    }
}
