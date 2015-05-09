namespace LoomsMana.Forms.Master
{
    partial class frmBrokerMasterView
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
            this.gridBroker = new DevExpress.XtraGrid.GridControl();
            this.InnerGrid = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.BrokerID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BrokerName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BrokerFirmName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Address = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MobileNo = new DevExpress.XtraGrid.Columns.GridColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.gridBroker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InnerGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Location = new System.Drawing.Point(0, 96);
            this.pnlMain.Size = new System.Drawing.Size(689, 266);
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.label3);
            this.pnlHeader.Controls.Add(this.label2);
            this.pnlHeader.Controls.Add(this.label1);
            this.pnlHeader.Controls.Add(this.shapeContainer1);
            this.pnlHeader.Size = new System.Drawing.Size(689, 96);
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
            this.xtraScrollableControl1.Size = new System.Drawing.Size(689, 266);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(6, 45);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gridBroker);
            this.groupBox2.Location = new System.Drawing.Point(13, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(670, 291);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // gridBroker
            // 
            this.gridBroker.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridBroker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridBroker.Location = new System.Drawing.Point(3, 16);
            this.gridBroker.MainView = this.InnerGrid;
            this.gridBroker.Name = "gridBroker";
            this.gridBroker.Size = new System.Drawing.Size(664, 272);
            this.gridBroker.TabIndex = 66;
            this.gridBroker.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.InnerGrid});
            // 
            // InnerGrid
            // 
            this.InnerGrid.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.BrokerID,
            this.BrokerName,
            this.BrokerFirmName,
            this.Address,
            this.MobileNo});
            this.InnerGrid.GridControl = this.gridBroker;
            this.InnerGrid.Name = "InnerGrid";
            // 
            // BrokerID
            // 
            this.BrokerID.Caption = "BrokerID";
            this.BrokerID.FieldName = "BrokerID";
            this.BrokerID.Name = "BrokerID";
            // 
            // BrokerName
            // 
            this.BrokerName.Caption = "Broker Name";
            this.BrokerName.FieldName = "BrokerName";
            this.BrokerName.Name = "BrokerName";
            this.BrokerName.Visible = true;
            this.BrokerName.VisibleIndex = 0;
            // 
            // BrokerFirmName
            // 
            this.BrokerFirmName.Caption = "Broker Firm Name";
            this.BrokerFirmName.FieldName = "BrokerFirmName";
            this.BrokerFirmName.Name = "BrokerFirmName";
            this.BrokerFirmName.Visible = true;
            this.BrokerFirmName.VisibleIndex = 1;
            // 
            // Address
            // 
            this.Address.Caption = "Address";
            this.Address.FieldName = "Address";
            this.Address.Name = "Address";
            this.Address.Visible = true;
            this.Address.VisibleIndex = 2;
            // 
            // MobileNo
            // 
            this.MobileNo.Caption = "Mobile Number";
            this.MobileNo.FieldName = "MobileNo";
            this.MobileNo.Name = "MobileNo";
            this.MobileNo.Visible = true;
            this.MobileNo.VisibleIndex = 3;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Lucida Sans Unicode", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(73, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 29);
            this.label3.TabIndex = 21;
            this.label3.Text = "V";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 21);
            this.label2.TabIndex = 23;
            this.label2.Text = "roker     iew";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 29);
            this.label1.TabIndex = 22;
            this.label1.Text = "B";
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.rectangleShape1.FillColor = System.Drawing.Color.Blue;
            this.rectangleShape1.FillGradientColor = System.Drawing.Color.Transparent;
            this.rectangleShape1.FillGradientStyle = Microsoft.VisualBasic.PowerPacks.FillGradientStyle.Horizontal;
            this.rectangleShape1.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.rectangleShape1.Location = new System.Drawing.Point(16, 38);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(110, 2);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(689, 96);
            this.shapeContainer1.TabIndex = 24;
            this.shapeContainer1.TabStop = false;
            // 
            // frmBrokerMasterView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(689, 362);
            this.Name = "frmBrokerMasterView";
            this.Text = "Broker";
            this.pnlMain.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.xtraScrollableControl1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridBroker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InnerGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraGrid.GridControl gridBroker;
        private DevExpress.XtraGrid.Views.Grid.GridView InnerGrid;
        private DevExpress.XtraGrid.Columns.GridColumn BrokerID;
        private DevExpress.XtraGrid.Columns.GridColumn BrokerName;
        private DevExpress.XtraGrid.Columns.GridColumn BrokerFirmName;
        private DevExpress.XtraGrid.Columns.GridColumn Address;
        private DevExpress.XtraGrid.Columns.GridColumn MobileNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
    }
}
