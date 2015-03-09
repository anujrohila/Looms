namespace LoomsManagement.Windows.Forms.Master
{
    partial class FormCompanyView
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
            this.Form_GridData = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.CompanyID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CompanyName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ComapnyCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.OwnerName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.OpeningDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SMSNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PanNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CSTNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ECCNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Address = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ContactPersonName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.InvestmentAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Btn_Edit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.Btn_Delete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.Btn_View = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.Form_GridData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Delete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_View)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_pdf
            // 
            this.btn_pdf.Appearance.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pdf.Appearance.Options.UseFont = true;
            this.btn_pdf.Click += new System.EventHandler(this.btn_pdf_Click);
            // 
            // btnAddRecord
            // 
            this.btnAddRecord.Appearance.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRecord.Appearance.Options.UseFont = true;
            this.btnAddRecord.Click += new System.EventHandler(this.btnAddRecord_Click);
            // 
            // btn_print
            // 
            this.btn_print.Appearance.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_print.Appearance.Options.UseFont = true;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // txt_export
            // 
            this.txt_export.Appearance.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_export.Appearance.Options.UseFont = true;
            this.txt_export.Click += new System.EventHandler(this.btn_export_Click);
            // 
            // Form_GridData
            // 
            this.Form_GridData.Cursor = System.Windows.Forms.Cursors.Default;
            this.Form_GridData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Form_GridData.Location = new System.Drawing.Point(0, 43);
            this.Form_GridData.MainView = this.gridView2;
            this.Form_GridData.Name = "Form_GridData";
            this.Form_GridData.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.Btn_Edit,
            this.Btn_Delete,
            this.Btn_View});
            this.Form_GridData.Size = new System.Drawing.Size(796, 338);
            this.Form_GridData.TabIndex = 65;
            this.Form_GridData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Appearance.FooterPanel.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView2.Appearance.FooterPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gridView2.Appearance.FooterPanel.Options.UseFont = true;
            this.gridView2.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gridView2.Appearance.HeaderPanel.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView2.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView2.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView2.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView2.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridView2.Appearance.Row.Font = new System.Drawing.Font("Cambria", 8.5F);
            this.gridView2.Appearance.Row.Options.UseFont = true;
            this.gridView2.ColumnPanelRowHeight = 25;
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.CompanyID,
            this.CompanyName,
            this.ComapnyCode,
            this.OwnerName,
            this.OpeningDate,
            this.SMSNO,
            this.PanNo,
            this.CSTNo,
            this.ECCNo,
            this.Address,
            this.ContactPersonName,
            this.InvestmentAmount});
            this.gridView2.GridControl = this.Form_GridData;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.ReadOnly = true;
            this.gridView2.OptionsCustomization.AllowGroup = false;
            this.gridView2.OptionsNavigation.UseTabKey = false;
            this.gridView2.OptionsView.BestFitUseErrorInfo = DevExpress.Utils.DefaultBoolean.True;
            this.gridView2.OptionsView.ShowAutoFilterRow = true;
            this.gridView2.OptionsView.ShowFooter = true;
            this.gridView2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridView2_KeyDown);
            // 
            // CompanyID
            // 
            this.CompanyID.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompanyID.AppearanceCell.Options.UseFont = true;
            this.CompanyID.Caption = "CompanyID";
            this.CompanyID.FieldName = "CompanyID";
            this.CompanyID.Name = "CompanyID";
            this.CompanyID.OptionsColumn.Printable = DevExpress.Utils.DefaultBoolean.False;
            // 
            // CompanyName
            // 
            this.CompanyName.Caption = "CompanyName";
            this.CompanyName.FieldName = "CompanyName";
            this.CompanyName.Name = "CompanyName";
            this.CompanyName.Visible = true;
            this.CompanyName.VisibleIndex = 0;
            // 
            // ComapnyCode
            // 
            this.ComapnyCode.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComapnyCode.AppearanceCell.Options.UseFont = true;
            this.ComapnyCode.Caption = "Code";
            this.ComapnyCode.FieldName = "ComapnyCode";
            this.ComapnyCode.Name = "ComapnyCode";
            this.ComapnyCode.Visible = true;
            this.ComapnyCode.VisibleIndex = 1;
            this.ComapnyCode.Width = 117;
            // 
            // OwnerName
            // 
            this.OwnerName.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OwnerName.AppearanceCell.Options.UseFont = true;
            this.OwnerName.Caption = "Owner Name";
            this.OwnerName.FieldName = "OwnerName";
            this.OwnerName.Name = "OwnerName";
            this.OwnerName.Visible = true;
            this.OwnerName.VisibleIndex = 2;
            this.OwnerName.Width = 117;
            // 
            // OpeningDate
            // 
            this.OpeningDate.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpeningDate.AppearanceCell.Options.UseFont = true;
            this.OpeningDate.Caption = "Opening Date";
            this.OpeningDate.FieldName = "StartDate";
            this.OpeningDate.Name = "OpeningDate";
            this.OpeningDate.Visible = true;
            this.OpeningDate.VisibleIndex = 3;
            this.OpeningDate.Width = 117;
            // 
            // SMSNO
            // 
            this.SMSNO.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SMSNO.AppearanceCell.Options.UseFont = true;
            this.SMSNO.Caption = "SMS NO";
            this.SMSNO.FieldName = "SMSNO";
            this.SMSNO.Name = "SMSNO";
            this.SMSNO.Visible = true;
            this.SMSNO.VisibleIndex = 4;
            this.SMSNO.Width = 129;
            // 
            // PanNo
            // 
            this.PanNo.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanNo.AppearanceCell.Options.UseFont = true;
            this.PanNo.Caption = "Pan No.";
            this.PanNo.FieldName = "PANNo";
            this.PanNo.Name = "PanNo";
            this.PanNo.Visible = true;
            this.PanNo.VisibleIndex = 5;
            this.PanNo.Width = 65;
            // 
            // CSTNo
            // 
            this.CSTNo.Caption = "CSTNo";
            this.CSTNo.FieldName = "CSTNo";
            this.CSTNo.Name = "CSTNo";
            // 
            // ECCNo
            // 
            this.ECCNo.Caption = "ECCNo";
            this.ECCNo.FieldName = "ECCNo";
            this.ECCNo.Name = "ECCNo";
            // 
            // Address
            // 
            this.Address.Caption = "Address";
            this.Address.FieldName = "Address";
            this.Address.Name = "Address";
            // 
            // ContactPersonName
            // 
            this.ContactPersonName.Caption = "ContactPersonName";
            this.ContactPersonName.FieldName = "ContactPersonName";
            this.ContactPersonName.Name = "ContactPersonName";
            // 
            // InvestmentAmount
            // 
            this.InvestmentAmount.Caption = "InvestmentAmount";
            this.InvestmentAmount.Name = "InvestmentAmount";
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
            // FormCompanyView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(796, 381);
            this.Controls.Add(this.Form_GridData);
            this.Name = "FormCompanyView";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Controls.SetChildIndex(this.Form_GridData, 0);
            ((System.ComponentModel.ISupportInitialize)(this.Form_GridData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Delete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_View)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public DevExpress.XtraGrid.GridControl Form_GridData;
        public DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn CompanyID;
        private DevExpress.XtraGrid.Columns.GridColumn ComapnyCode;
        private DevExpress.XtraGrid.Columns.GridColumn OwnerName;
        private DevExpress.XtraGrid.Columns.GridColumn OpeningDate;
        private DevExpress.XtraGrid.Columns.GridColumn SMSNO;
        private DevExpress.XtraGrid.Columns.GridColumn PanNo;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit Btn_View;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit Btn_Edit;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit Btn_Delete;
        private DevExpress.XtraGrid.Columns.GridColumn CompanyName;
        private DevExpress.XtraGrid.Columns.GridColumn CSTNo;
        private DevExpress.XtraGrid.Columns.GridColumn ECCNo;
        private DevExpress.XtraGrid.Columns.GridColumn Address;
        private DevExpress.XtraGrid.Columns.GridColumn ContactPersonName;
        private DevExpress.XtraGrid.Columns.GridColumn InvestmentAmount;
    }
}
