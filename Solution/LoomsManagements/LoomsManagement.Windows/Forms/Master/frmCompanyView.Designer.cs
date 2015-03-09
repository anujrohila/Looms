namespace LoomsManagement.Windows.Forms.Master
{
    partial class frmCompanyView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCompanyView));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddRecord = new DevExpress.XtraEditors.SimpleButton();
            this.grd_Customer = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.CompanyID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Code = new DevExpress.XtraGrid.Columns.GridColumn();
            this.OwnerName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.OpeningDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SMSNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PanNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.View = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Btn_View = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.Edit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Btn_Edit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.Delete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Btn_Delete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_Customer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Delete)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.simpleButton1);
            this.panelControl1.Controls.Add(this.btnAddRecord);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(773, 43);
            this.panelControl1.TabIndex = 62;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(675, 6);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(86, 31);
            this.simpleButton1.TabIndex = 60;
            this.simpleButton1.Text = "&Exports";
            // 
            // btnAddRecord
            // 
            this.btnAddRecord.Appearance.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRecord.Appearance.Options.UseFont = true;
            this.btnAddRecord.Image = ((System.Drawing.Image)(resources.GetObject("btnAddRecord.Image")));
            this.btnAddRecord.Location = new System.Drawing.Point(9, 6);
            this.btnAddRecord.Name = "btnAddRecord";
            this.btnAddRecord.Size = new System.Drawing.Size(86, 31);
            this.btnAddRecord.TabIndex = 59;
            this.btnAddRecord.Text = "&Add";
            this.btnAddRecord.Click += new System.EventHandler(this.btnAddRecord_Click);
            // 
            // grd_Customer
            // 
            this.grd_Customer.Cursor = System.Windows.Forms.Cursors.Default;
            this.grd_Customer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_Customer.Location = new System.Drawing.Point(0, 43);
            this.grd_Customer.MainView = this.gridView2;
            this.grd_Customer.Name = "grd_Customer";
            this.grd_Customer.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.Btn_Edit,
            this.Btn_Delete,
            this.Btn_View});
            this.grd_Customer.Size = new System.Drawing.Size(773, 393);
            this.grd_Customer.TabIndex = 63;
            this.grd_Customer.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
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
            this.Name,
            this.Code,
            this.OwnerName,
            this.OpeningDate,
            this.SMSNO,
            this.PanNo,
            this.View,
            this.Edit,
            this.Delete});
            this.gridView2.GridControl = this.grd_Customer;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.ReadOnly = true;
            this.gridView2.OptionsNavigation.UseTabKey = false;
            this.gridView2.OptionsView.ShowAutoFilterRow = true;
            this.gridView2.OptionsView.ShowFooter = true;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // CompanyID
            // 
            this.CompanyID.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompanyID.AppearanceCell.Options.UseFont = true;
            this.CompanyID.Caption = "CompanyID";
            this.CompanyID.Name = "CompanyID";
            // 
            // Name
            // 
            this.Name.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name.AppearanceCell.Options.UseFont = true;
            this.Name.Caption = "Name";
            this.Name.Name = "Name";
            this.Name.Visible = true;
            this.Name.VisibleIndex = 0;
            this.Name.Width = 117;
            // 
            // Code
            // 
            this.Code.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Code.AppearanceCell.Options.UseFont = true;
            this.Code.Caption = "Code";
            this.Code.Name = "Code";
            this.Code.Visible = true;
            this.Code.VisibleIndex = 1;
            this.Code.Width = 117;
            // 
            // OwnerName
            // 
            this.OwnerName.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OwnerName.AppearanceCell.Options.UseFont = true;
            this.OwnerName.Caption = "Owner Name";
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
            this.PanNo.Name = "PanNo";
            this.PanNo.Visible = true;
            this.PanNo.VisibleIndex = 5;
            this.PanNo.Width = 65;
            // 
            // View
            // 
            this.View.ColumnEdit = this.Btn_View;
            this.View.Name = "View";
            this.View.Visible = true;
            this.View.VisibleIndex = 6;
            this.View.Width = 30;
            // 
            // Btn_View
            // 
            this.Btn_View.AutoHeight = false;
            this.Btn_View.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, global::LoomsManagement.Windows.Properties.Resources.viewBtn, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.Btn_View.Name = "Btn_View";
            this.Btn_View.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // Edit
            // 
            this.Edit.ColumnEdit = this.Btn_Edit;
            this.Edit.Name = "Edit";
            this.Edit.OptionsFilter.AllowFilter = false;
            this.Edit.Visible = true;
            this.Edit.VisibleIndex = 7;
            this.Edit.Width = 30;
            // 
            // Btn_Edit
            // 
            this.Btn_Edit.AutoHeight = false;
            this.Btn_Edit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, global::LoomsManagement.Windows.Properties.Resources.edit_icon, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", null, null, true)});
            this.Btn_Edit.Name = "Btn_Edit";
            this.Btn_Edit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // Delete
            // 
            this.Delete.ColumnEdit = this.Btn_Delete;
            this.Delete.Name = "Delete";
            this.Delete.Visible = true;
            this.Delete.VisibleIndex = 8;
            this.Delete.Width = 30;
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.AutoHeight = false;
            this.Btn_Delete.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, global::LoomsManagement.Windows.Properties.Resources.delete, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject3, "", null, null, true)});
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // frmCompanyView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 436);
            this.ControlBox = false;
            this.Controls.Add(this.grd_Customer);
            this.Controls.Add(this.panelControl1);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.None;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
             this.Text = "Company Details";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd_Customer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Delete)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        public DevExpress.XtraEditors.SimpleButton btnAddRecord;
        public DevExpress.XtraGrid.GridControl grd_Customer;
        public DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn Edit;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit Btn_Edit;
        private DevExpress.XtraGrid.Columns.GridColumn Delete;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit Btn_Delete;
        private DevExpress.XtraGrid.Columns.GridColumn View;
        private DevExpress.XtraGrid.Columns.GridColumn Name;
        private DevExpress.XtraGrid.Columns.GridColumn Code;
        private DevExpress.XtraGrid.Columns.GridColumn OwnerName;
        private DevExpress.XtraGrid.Columns.GridColumn OpeningDate;
        private DevExpress.XtraGrid.Columns.GridColumn SMSNO;
        private DevExpress.XtraGrid.Columns.GridColumn CompanyID;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit Btn_View;
        private DevExpress.XtraGrid.Columns.GridColumn PanNo;
        public DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}