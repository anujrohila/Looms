namespace LoomsMana.Forms.Production.Purchase
{
    partial class frmYarnPurchaseMasterView
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
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gridPurchaseMasterView = new DevExpress.XtraGrid.GridControl();
            this.InnerGrid = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.PurchaseID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SRNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PurchaseDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ChallanNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LRNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RecieveAt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pnlMain.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.xtraScrollableControl1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPurchaseMasterView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InnerGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Location = new System.Drawing.Point(0, 88);
            this.pnlMain.Size = new System.Drawing.Size(802, 312);
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.label5);
            this.pnlHeader.Controls.Add(this.label4);
            this.pnlHeader.Controls.Add(this.label3);
            this.pnlHeader.Controls.Add(this.label1);
            this.pnlHeader.Controls.Add(this.label2);
            this.pnlHeader.Controls.Add(this.shapeContainer1);
            this.pnlHeader.Size = new System.Drawing.Size(802, 88);
            this.pnlHeader.Controls.SetChildIndex(this.shapeContainer1, 0);
            this.pnlHeader.Controls.SetChildIndex(this.groupBox1, 0);
            this.pnlHeader.Controls.SetChildIndex(this.label2, 0);
            this.pnlHeader.Controls.SetChildIndex(this.label1, 0);
            this.pnlHeader.Controls.SetChildIndex(this.label3, 0);
            this.pnlHeader.Controls.SetChildIndex(this.label4, 0);
            this.pnlHeader.Controls.SetChildIndex(this.label5, 0);
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
            this.xtraScrollableControl1.Size = new System.Drawing.Size(802, 312);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(6, 40);
            this.groupBox1.Size = new System.Drawing.Size(1009, 46);
            // 
            // panelControl2
            // 
            this.panelControl2.Location = new System.Drawing.Point(701, 12);
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
            this.rectangleShape1.Size = new System.Drawing.Size(249, 3);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(802, 88);
            this.shapeContainer1.TabIndex = 25;
            this.shapeContainer1.TabStop = false;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Lucida Sans Unicode", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(67, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 29);
            this.label3.TabIndex = 26;
            this.label3.Text = "P";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(22, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 29);
            this.label1.TabIndex = 27;
            this.label1.Text = "Y";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 21);
            this.label2.TabIndex = 28;
            this.label2.Text = "arn    urchase     aster     etails";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Lucida Sans Unicode", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(141, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 29);
            this.label4.TabIndex = 29;
            this.label4.Text = "M";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Lucida Sans Unicode", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(202, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 29);
            this.label5.TabIndex = 30;
            this.label5.Text = "D";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.gridPurchaseMasterView);
            this.groupBox2.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.groupBox2.Location = new System.Drawing.Point(9, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(783, 286);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // gridPurchaseMasterView
            // 
            this.gridPurchaseMasterView.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridPurchaseMasterView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridPurchaseMasterView.Location = new System.Drawing.Point(3, 19);
            this.gridPurchaseMasterView.MainView = this.InnerGrid;
            this.gridPurchaseMasterView.Name = "gridPurchaseMasterView";
            this.gridPurchaseMasterView.Size = new System.Drawing.Size(777, 264);
            this.gridPurchaseMasterView.TabIndex = 66;
            this.gridPurchaseMasterView.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.InnerGrid});
            // 
            // InnerGrid
            // 
            this.InnerGrid.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.PurchaseID,
            this.SRNo,
            this.PurchaseDate,
            this.ChallanNo,
            this.LRNo,
            this.RecieveAt});
            this.InnerGrid.GridControl = this.gridPurchaseMasterView;
            this.InnerGrid.Name = "InnerGrid";
            // 
            // PurchaseID
            // 
            this.PurchaseID.Caption = "PurchaseID";
            this.PurchaseID.FieldName = "PurchaseID";
            this.PurchaseID.Name = "PurchaseID";
            // 
            // SRNo
            // 
            this.SRNo.Caption = "Serial Number";
            this.SRNo.FieldName = "SRNo";
            this.SRNo.Name = "SRNo";
            this.SRNo.Visible = true;
            this.SRNo.VisibleIndex = 0;
            // 
            // PurchaseDate
            // 
            this.PurchaseDate.Caption = "Purchase Date";
            this.PurchaseDate.FieldName = "PurchaseDate";
            this.PurchaseDate.Name = "PurchaseDate";
            this.PurchaseDate.Visible = true;
            this.PurchaseDate.VisibleIndex = 1;
            // 
            // ChallanNo
            // 
            this.ChallanNo.Caption = "Challan Number";
            this.ChallanNo.FieldName = "ChallanNo";
            this.ChallanNo.Name = "ChallanNo";
            this.ChallanNo.Visible = true;
            this.ChallanNo.VisibleIndex = 2;
            // 
            // LRNo
            // 
            this.LRNo.Caption = "LRNo";
            this.LRNo.FieldName = "LRNo";
            this.LRNo.Name = "LRNo";
            this.LRNo.Visible = true;
            this.LRNo.VisibleIndex = 3;
            // 
            // RecieveAt
            // 
            this.RecieveAt.Caption = "Recieve At";
            this.RecieveAt.FieldName = "RecieveAt";
            this.RecieveAt.Name = "RecieveAt";
            this.RecieveAt.Visible = true;
            this.RecieveAt.VisibleIndex = 4;
            // 
            // frmYarnPurchaseMasterView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 400);
            this.Name = "frmYarnPurchaseMasterView";
            this.Text = "Yarn Purchase Master ";
            this.pnlMain.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.xtraScrollableControl1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridPurchaseMasterView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InnerGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraGrid.GridControl gridPurchaseMasterView;
        private DevExpress.XtraGrid.Views.Grid.GridView InnerGrid;
        private DevExpress.XtraGrid.Columns.GridColumn PurchaseID;
        private DevExpress.XtraGrid.Columns.GridColumn SRNo;
        private DevExpress.XtraGrid.Columns.GridColumn PurchaseDate;
        private DevExpress.XtraGrid.Columns.GridColumn ChallanNo;
        private DevExpress.XtraGrid.Columns.GridColumn LRNo;
        private DevExpress.XtraGrid.Columns.GridColumn RecieveAt;
    }
}