namespace LoomsMana.Forms.Master
{
    partial class FrmCompanyView
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
            this.gridViewCompany = new DevExpress.XtraGrid.GridControl();
            this.InnerGrid = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.CompanyID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CompanyName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ComapnyCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.OwnerName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.OpeningDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ContactPersonName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Address = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SMSNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PanNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CSTNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ECCNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.InvestmentAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Btn_Edit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.Btn_Delete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.Btn_View = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCompany)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InnerGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Delete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_View)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Location = new System.Drawing.Point(0, 92);
            this.pnlMain.Size = new System.Drawing.Size(884, 285);
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.label3);
            this.pnlHeader.Controls.Add(this.label2);
            this.pnlHeader.Controls.Add(this.label1);
            this.pnlHeader.Controls.Add(this.shapeContainer1);
            this.pnlHeader.Size = new System.Drawing.Size(884, 92);
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
            this.xtraScrollableControl1.Size = new System.Drawing.Size(884, 285);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(10, 38);
            this.groupBox1.Size = new System.Drawing.Size(864, 46);
            // 
            // panelControl2
            // 
            this.panelControl2.Location = new System.Drawing.Point(556, 10);
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
            this.gridViewCompany.Size = new System.Drawing.Size(858, 248);
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
            this.CompanyID,
            this.CompanyName,
            this.ComapnyCode,
            this.OwnerName,
            this.OpeningDate,
            this.ContactPersonName,
            this.Address,
            this.SMSNO,
            this.PanNo,
            this.CSTNo,
            this.ECCNo,
            this.InvestmentAmount});
            this.InnerGrid.GridControl = this.gridViewCompany;
            this.InnerGrid.Name = "InnerGrid";
            this.InnerGrid.OptionsBehavior.ReadOnly = true;
            this.InnerGrid.OptionsCustomization.AllowGroup = false;
            this.InnerGrid.OptionsNavigation.UseTabKey = false;
            this.InnerGrid.OptionsView.BestFitUseErrorInfo = DevExpress.Utils.DefaultBoolean.True;
            this.InnerGrid.OptionsView.ShowAutoFilterRow = true;
            this.InnerGrid.OptionsView.ShowFooter = true;
            // 
            // CompanyID
            // 
            this.CompanyID.AppearanceCell.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompanyID.AppearanceCell.Options.UseFont = true;
            this.CompanyID.Caption = "CompanyID";
            this.CompanyID.FieldName = "CompanyID";
            this.CompanyID.Name = "CompanyID";
            this.CompanyID.OptionsColumn.Printable = DevExpress.Utils.DefaultBoolean.False;
            // 
            // CompanyName
            // 
            this.CompanyName.AppearanceCell.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompanyName.AppearanceCell.Options.UseFont = true;
            this.CompanyName.Caption = "CompanyName";
            this.CompanyName.FieldName = "CompanyName";
            this.CompanyName.Name = "CompanyName";
            this.CompanyName.Visible = true;
            this.CompanyName.VisibleIndex = 0;
            // 
            // ComapnyCode
            // 
            this.ComapnyCode.AppearanceCell.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.OwnerName.AppearanceCell.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.OpeningDate.AppearanceCell.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpeningDate.AppearanceCell.Options.UseFont = true;
            this.OpeningDate.Caption = "Opening Date";
            this.OpeningDate.FieldName = "StartDate";
            this.OpeningDate.Name = "OpeningDate";
            this.OpeningDate.Visible = true;
            this.OpeningDate.VisibleIndex = 3;
            this.OpeningDate.Width = 117;
            // 
            // ContactPersonName
            // 
            this.ContactPersonName.AppearanceCell.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContactPersonName.AppearanceCell.Options.UseFont = true;
            this.ContactPersonName.Caption = "ContactPersonName";
            this.ContactPersonName.FieldName = "ContactPersonName";
            this.ContactPersonName.Name = "ContactPersonName";
            this.ContactPersonName.Visible = true;
            this.ContactPersonName.VisibleIndex = 4;
            // 
            // Address
            // 
            this.Address.AppearanceCell.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Address.AppearanceCell.Options.UseFont = true;
            this.Address.Caption = "Address";
            this.Address.FieldName = "Address";
            this.Address.Name = "Address";
            this.Address.Visible = true;
            this.Address.VisibleIndex = 5;
            // 
            // SMSNO
            // 
            this.SMSNO.AppearanceCell.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SMSNO.AppearanceCell.Options.UseFont = true;
            this.SMSNO.Caption = "SMS NO";
            this.SMSNO.FieldName = "SMSNO";
            this.SMSNO.Name = "SMSNO";
            this.SMSNO.Visible = true;
            this.SMSNO.VisibleIndex = 6;
            this.SMSNO.Width = 129;
            // 
            // PanNo
            // 
            this.PanNo.AppearanceCell.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanNo.AppearanceCell.Options.UseFont = true;
            this.PanNo.Caption = "Pan No.";
            this.PanNo.FieldName = "PANNo";
            this.PanNo.Name = "PanNo";
            this.PanNo.Visible = true;
            this.PanNo.VisibleIndex = 7;
            this.PanNo.Width = 65;
            // 
            // CSTNo
            // 
            this.CSTNo.AppearanceCell.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CSTNo.AppearanceCell.Options.UseFont = true;
            this.CSTNo.Caption = "CST No";
            this.CSTNo.FieldName = "CSTNo";
            this.CSTNo.Name = "CSTNo";
            this.CSTNo.Visible = true;
            this.CSTNo.VisibleIndex = 8;
            // 
            // ECCNo
            // 
            this.ECCNo.AppearanceCell.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ECCNo.AppearanceCell.Options.UseFont = true;
            this.ECCNo.Caption = "ECC No";
            this.ECCNo.FieldName = "ECCNo";
            this.ECCNo.Name = "ECCNo";
            this.ECCNo.Visible = true;
            this.ECCNo.VisibleIndex = 9;
            // 
            // InvestmentAmount
            // 
            this.InvestmentAmount.AppearanceCell.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvestmentAmount.AppearanceCell.Options.UseFont = true;
            this.InvestmentAmount.Caption = "Investment Amount";
            this.InvestmentAmount.FieldName = "InvestmentAmount";
            this.InvestmentAmount.Name = "InvestmentAmount";
            this.InvestmentAmount.Visible = true;
            this.InvestmentAmount.VisibleIndex = 10;
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
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.gridViewCompany);
            this.groupBox2.Location = new System.Drawing.Point(10, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(864, 267);
            this.groupBox2.TabIndex = 68;
            this.groupBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Lucida Sans Unicode", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(98, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 29);
            this.label3.TabIndex = 21;
            this.label3.Text = "V";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 21);
            this.label2.TabIndex = 23;
            this.label2.Text = "ompany     iew";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(17, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 29);
            this.label1.TabIndex = 22;
            this.label1.Text = "C";
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.rectangleShape1.FillColor = System.Drawing.Color.Blue;
            this.rectangleShape1.FillGradientColor = System.Drawing.Color.Transparent;
            this.rectangleShape1.FillGradientStyle = Microsoft.VisualBasic.PowerPacks.FillGradientStyle.Horizontal;
            this.rectangleShape1.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.rectangleShape1.Location = new System.Drawing.Point(22, 33);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(128, 2);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(884, 92);
            this.shapeContainer1.TabIndex = 24;
            this.shapeContainer1.TabStop = false;
            // 
            // FrmCompanyView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 377);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmCompanyView";
            this.Text = "Company";
            this.pnlMain.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.xtraScrollableControl1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCompany)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InnerGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Delete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_View)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public DevExpress.XtraGrid.GridControl gridViewCompany;
        public DevExpress.XtraGrid.Views.Grid.GridView InnerGrid;
        private DevExpress.XtraGrid.Columns.GridColumn CompanyID;
        private DevExpress.XtraGrid.Columns.GridColumn CompanyName;
        private DevExpress.XtraGrid.Columns.GridColumn ComapnyCode;
        private DevExpress.XtraGrid.Columns.GridColumn OwnerName;
        private DevExpress.XtraGrid.Columns.GridColumn OpeningDate;
        private DevExpress.XtraGrid.Columns.GridColumn ContactPersonName;
        private DevExpress.XtraGrid.Columns.GridColumn Address;
        private DevExpress.XtraGrid.Columns.GridColumn SMSNO;
        private DevExpress.XtraGrid.Columns.GridColumn PanNo;
        private DevExpress.XtraGrid.Columns.GridColumn CSTNo;
        private DevExpress.XtraGrid.Columns.GridColumn ECCNo;
        private DevExpress.XtraGrid.Columns.GridColumn InvestmentAmount;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit Btn_Edit;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit Btn_Delete;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit Btn_View;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;

    }
}