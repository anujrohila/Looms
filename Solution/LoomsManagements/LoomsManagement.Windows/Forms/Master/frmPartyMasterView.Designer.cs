namespace LoomsManagement.Windows.Forms.Master
{
    partial class frmPartyMasterView
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
            this.gridViewCompany = new DevExpress.XtraGrid.GridControl();
            this.InnerGrid = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.PartyID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CompanyCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PartyName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ContactPersonName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EmailID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PhoneNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MobileNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.City = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ECCNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TINNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PANNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CSTTINNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Btn_Edit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.Btn_Delete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.Btn_View = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCompany)).BeginInit();
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
            // gridViewCompany
            // 
            this.gridViewCompany.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridViewCompany.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridViewCompany.Location = new System.Drawing.Point(0, 43);
            this.gridViewCompany.MainView = this.InnerGrid;
            this.gridViewCompany.Name = "gridViewCompany";
            this.gridViewCompany.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.Btn_Edit,
            this.Btn_Delete,
            this.Btn_View});
            this.gridViewCompany.Size = new System.Drawing.Size(960, 437);
            this.gridViewCompany.TabIndex = 66;
            this.gridViewCompany.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
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
            this.PartyID,
            this.CompanyCode,
            this.PartyName,
            this.ContactPersonName,
            this.EmailID,
            this.PhoneNo,
            this.MobileNo,
            this.City,
            this.ECCNo,
            this.TINNo,
            this.PANNO,
            this.CSTTINNo});
            this.InnerGrid.GridControl = this.gridViewCompany;
            this.InnerGrid.Name = "InnerGrid";
            this.InnerGrid.OptionsBehavior.ReadOnly = true;
            this.InnerGrid.OptionsCustomization.AllowGroup = false;
            this.InnerGrid.OptionsNavigation.UseTabKey = false;
            this.InnerGrid.OptionsView.BestFitUseErrorInfo = DevExpress.Utils.DefaultBoolean.True;
            this.InnerGrid.OptionsView.ShowAutoFilterRow = true;
            this.InnerGrid.OptionsView.ShowFooter = true;
            this.InnerGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InnerGrid_KeyDown);
            // 
            // PartyID
            // 
            this.PartyID.AppearanceCell.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartyID.AppearanceCell.Options.UseFont = true;
            this.PartyID.Caption = "PartyID";
            this.PartyID.FieldName = "PartyID";
            this.PartyID.Name = "PartyID";
            this.PartyID.OptionsColumn.Printable = DevExpress.Utils.DefaultBoolean.False;
            // 
            // CompanyCode
            // 
            this.CompanyCode.Caption = "CompanyCode";
            this.CompanyCode.FieldName = "CompanyCode";
            this.CompanyCode.Name = "CompanyCode";
            this.CompanyCode.Visible = true;
            this.CompanyCode.VisibleIndex = 0;
            // 
            // PartyName
            // 
            this.PartyName.Caption = "PartyName";
            this.PartyName.FieldName = "PartyName";
            this.PartyName.Name = "PartyName";
            this.PartyName.Visible = true;
            this.PartyName.VisibleIndex = 1;
            // 
            // ContactPersonName
            // 
            this.ContactPersonName.Caption = "ContactPersonName";
            this.ContactPersonName.FieldName = "ContactPersonName";
            this.ContactPersonName.Name = "ContactPersonName";
            this.ContactPersonName.Visible = true;
            this.ContactPersonName.VisibleIndex = 2;
            // 
            // EmailID
            // 
            this.EmailID.Caption = "EmailID";
            this.EmailID.FieldName = "EmailID";
            this.EmailID.Name = "EmailID";
            this.EmailID.Visible = true;
            this.EmailID.VisibleIndex = 3;
            // 
            // PhoneNo
            // 
            this.PhoneNo.Caption = "PhoneNo";
            this.PhoneNo.FieldName = "PhoneNo";
            this.PhoneNo.Name = "PhoneNo";
            this.PhoneNo.Visible = true;
            this.PhoneNo.VisibleIndex = 4;
            // 
            // MobileNo
            // 
            this.MobileNo.Caption = "MobileNo";
            this.MobileNo.FieldName = "MobileNo";
            this.MobileNo.Name = "MobileNo";
            this.MobileNo.Visible = true;
            this.MobileNo.VisibleIndex = 5;
            // 
            // City
            // 
            this.City.Caption = "City";
            this.City.FieldName = "City";
            this.City.Name = "City";
            this.City.Visible = true;
            this.City.VisibleIndex = 6;
            // 
            // ECCNo
            // 
            this.ECCNo.Caption = "ECCNo";
            this.ECCNo.Name = "ECCNo";
            this.ECCNo.Visible = true;
            this.ECCNo.VisibleIndex = 7;
            // 
            // TINNo
            // 
            this.TINNo.Caption = "TINNo";
            this.TINNo.FieldName = "TINNo";
            this.TINNo.Name = "TINNo";
            this.TINNo.Visible = true;
            this.TINNo.VisibleIndex = 8;
            // 
            // PANNO
            // 
            this.PANNO.Caption = "PANNO";
            this.PANNO.FieldName = "PANNO";
            this.PANNO.Name = "PANNO";
            this.PANNO.Visible = true;
            this.PANNO.VisibleIndex = 9;
            // 
            // CSTTINNo
            // 
            this.CSTTINNo.Caption = "CSTTINNo";
            this.CSTTINNo.FieldName = "CSTTINNo";
            this.CSTTINNo.Name = "CSTTINNo";
            this.CSTTINNo.Visible = true;
            this.CSTTINNo.VisibleIndex = 10;
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
            // frmPartyMasterView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(960, 480);
            this.Controls.Add(this.gridViewCompany);
            this.Name = "frmPartyMasterView";
            this.Controls.SetChildIndex(this.gridViewCompany, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCompany)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InnerGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Delete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_View)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public DevExpress.XtraGrid.GridControl gridViewCompany;
        public DevExpress.XtraGrid.Views.Grid.GridView InnerGrid;
        private DevExpress.XtraGrid.Columns.GridColumn PartyID;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit Btn_Edit;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit Btn_Delete;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit Btn_View;
        private DevExpress.XtraGrid.Columns.GridColumn CompanyCode;
        private DevExpress.XtraGrid.Columns.GridColumn PartyName;
        private DevExpress.XtraGrid.Columns.GridColumn ContactPersonName;
        private DevExpress.XtraGrid.Columns.GridColumn EmailID;
        private DevExpress.XtraGrid.Columns.GridColumn PhoneNo;
        private DevExpress.XtraGrid.Columns.GridColumn MobileNo;
        private DevExpress.XtraGrid.Columns.GridColumn City;
        private DevExpress.XtraGrid.Columns.GridColumn ECCNo;
        private DevExpress.XtraGrid.Columns.GridColumn TINNo;
        private DevExpress.XtraGrid.Columns.GridColumn PANNO;
        private DevExpress.XtraGrid.Columns.GridColumn CSTTINNo;
    }
}
