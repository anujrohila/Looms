﻿namespace LoomsMana.Forms.Master
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.pnlMain.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.xtraScrollableControl1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCompany)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InnerGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Delete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_View)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Location = new System.Drawing.Point(0, 101);
            this.pnlMain.Size = new System.Drawing.Size(1238, 389);
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.label3);
            this.pnlHeader.Controls.Add(this.label2);
            this.pnlHeader.Controls.Add(this.label1);
            this.pnlHeader.Controls.Add(this.shapeContainer1);
            this.pnlHeader.Size = new System.Drawing.Size(1238, 101);
            this.pnlHeader.Controls.SetChildIndex(this.shapeContainer1, 0);
            this.pnlHeader.Controls.SetChildIndex(this.groupBox1, 0);
            this.pnlHeader.Controls.SetChildIndex(this.label1, 0);
            this.pnlHeader.Controls.SetChildIndex(this.label2, 0);
            this.pnlHeader.Controls.SetChildIndex(this.label3, 0);
            // 
            // btnAdd
            // 
            this.btnAdd.Appearance.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Appearance.Options.UseFont = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
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
            this.xtraScrollableControl1.Size = new System.Drawing.Size(1238, 389);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(6, 43);
            this.groupBox1.Size = new System.Drawing.Size(1086, 46);
            // 
            // panelControl2
            // 
            this.panelControl2.Location = new System.Drawing.Point(778, 10);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gridViewCompany);
            this.groupBox2.Location = new System.Drawing.Point(6, -2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1223, 337);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // gridViewCompany
            // 
            this.gridViewCompany.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridViewCompany.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridViewCompany.Location = new System.Drawing.Point(3, 16);
            this.gridViewCompany.MainView = this.InnerGrid;
            this.gridViewCompany.Name = "gridViewCompany";
            this.gridViewCompany.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.Btn_Edit,
            this.Btn_Delete,
            this.Btn_View});
            this.gridViewCompany.Size = new System.Drawing.Size(1217, 318);
            this.gridViewCompany.TabIndex = 67;
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
            // 
            // TINNo
            // 
            this.TINNo.Caption = "TINNo";
            this.TINNo.FieldName = "TINNo";
            this.TINNo.Name = "TINNo";
            // 
            // PANNO
            // 
            this.PANNO.Caption = "PANNO";
            this.PANNO.FieldName = "PANNO";
            this.PANNO.Name = "PANNO";
            this.PANNO.Visible = true;
            this.PANNO.VisibleIndex = 7;
            // 
            // CSTTINNo
            // 
            this.CSTTINNo.Caption = "CSTTINNo";
            this.CSTTINNo.FieldName = "CSTTINNo";
            this.CSTTINNo.Name = "CSTTINNo";
            // 
            // Btn_Edit
            // 
            this.Btn_Edit.AutoHeight = false;
            this.Btn_Edit.Name = "Btn_Edit";
            this.Btn_Edit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.AutoHeight = false;
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // Btn_View
            // 
            this.Btn_View.AutoHeight = false;
            this.Btn_View.Name = "Btn_View";
            this.Btn_View.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Lucida Sans Unicode", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(73, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 29);
            this.label3.TabIndex = 21;
            this.label3.Text = "V";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 21);
            this.label2.TabIndex = 23;
            this.label2.Text = "arty      iew";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(21, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 29);
            this.label1.TabIndex = 22;
            this.label1.Text = "P";
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.rectangleShape1.FillColor = System.Drawing.Color.Blue;
            this.rectangleShape1.FillGradientColor = System.Drawing.Color.Transparent;
            this.rectangleShape1.FillGradientStyle = Microsoft.VisualBasic.PowerPacks.FillGradientStyle.Horizontal;
            this.rectangleShape1.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.rectangleShape1.Location = new System.Drawing.Point(25, 37);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(112, 2);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(1238, 101);
            this.shapeContainer1.TabIndex = 24;
            this.shapeContainer1.TabStop = false;
            // 
            // frmPartyMasterView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1238, 490);
            this.Name = "frmPartyMasterView";
            this.Text = "Party";
            this.pnlMain.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.xtraScrollableControl1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCompany)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InnerGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Delete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_View)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        public DevExpress.XtraGrid.GridControl gridViewCompany;
        public DevExpress.XtraGrid.Views.Grid.GridView InnerGrid;
        private DevExpress.XtraGrid.Columns.GridColumn PartyID;
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
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit Btn_Edit;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit Btn_Delete;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit Btn_View;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
    }
}
