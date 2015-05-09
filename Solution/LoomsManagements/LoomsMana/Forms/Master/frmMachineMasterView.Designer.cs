namespace LoomsMana.Forms.Master
{
    partial class frmMachineMasterView
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
            this.gridMachineMaster = new DevExpress.XtraGrid.GridControl();
            this.InnerGrid = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MachineID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MachineTypeID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MachineName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.AboutMachine = new DevExpress.XtraGrid.Columns.GridColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.gridMachineMaster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InnerGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Location = new System.Drawing.Point(0, 98);
            this.pnlMain.Size = new System.Drawing.Size(689, 268);
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.label3);
            this.pnlHeader.Controls.Add(this.label2);
            this.pnlHeader.Controls.Add(this.label1);
            this.pnlHeader.Controls.Add(this.shapeContainer1);
            this.pnlHeader.Size = new System.Drawing.Size(689, 98);
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
            this.xtraScrollableControl1.Size = new System.Drawing.Size(689, 268);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(6, 45);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gridMachineMaster);
            this.groupBox2.Location = new System.Drawing.Point(13, 1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(664, 289);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // gridMachineMaster
            // 
            this.gridMachineMaster.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridMachineMaster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridMachineMaster.Location = new System.Drawing.Point(3, 16);
            this.gridMachineMaster.MainView = this.InnerGrid;
            this.gridMachineMaster.Name = "gridMachineMaster";
            this.gridMachineMaster.Size = new System.Drawing.Size(658, 270);
            this.gridMachineMaster.TabIndex = 66;
            this.gridMachineMaster.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.InnerGrid});
            // 
            // InnerGrid
            // 
            this.InnerGrid.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MachineID,
            this.MachineTypeID,
            this.MachineName,
            this.AboutMachine});
            this.InnerGrid.GridControl = this.gridMachineMaster;
            this.InnerGrid.Name = "InnerGrid";
            // 
            // MachineID
            // 
            this.MachineID.Caption = "MachineID";
            this.MachineID.FieldName = "MachineID";
            this.MachineID.Name = "MachineID";
            // 
            // MachineTypeID
            // 
            this.MachineTypeID.Caption = "MachineTypeID";
            this.MachineTypeID.FieldName = "MachineTypeID";
            this.MachineTypeID.Name = "MachineTypeID";
            // 
            // MachineName
            // 
            this.MachineName.Caption = "Machine Name";
            this.MachineName.FieldName = "MachineName";
            this.MachineName.Name = "MachineName";
            this.MachineName.Visible = true;
            this.MachineName.VisibleIndex = 0;
            // 
            // AboutMachine
            // 
            this.AboutMachine.Caption = "About Machine";
            this.AboutMachine.FieldName = "AboutMachine";
            this.AboutMachine.Name = "AboutMachine";
            this.AboutMachine.Visible = true;
            this.AboutMachine.VisibleIndex = 1;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Lucida Sans Unicode", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(90, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 29);
            this.label3.TabIndex = 21;
            this.label3.Text = "V";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 21);
            this.label2.TabIndex = 23;
            this.label2.Text = "achine     iew";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(16, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 29);
            this.label1.TabIndex = 22;
            this.label1.Text = "M";
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.rectangleShape1.FillColor = System.Drawing.Color.Blue;
            this.rectangleShape1.FillGradientColor = System.Drawing.Color.Transparent;
            this.rectangleShape1.FillGradientStyle = Microsoft.VisualBasic.PowerPacks.FillGradientStyle.Horizontal;
            this.rectangleShape1.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.rectangleShape1.Location = new System.Drawing.Point(23, 37);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(120, 2);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(689, 98);
            this.shapeContainer1.TabIndex = 24;
            this.shapeContainer1.TabStop = false;
            // 
            // frmMachineMasterView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(689, 366);
            this.Name = "frmMachineMasterView";
            this.Text = "Machine";
            this.pnlMain.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.xtraScrollableControl1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridMachineMaster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InnerGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraGrid.GridControl gridMachineMaster;
        private DevExpress.XtraGrid.Views.Grid.GridView InnerGrid;
        private DevExpress.XtraGrid.Columns.GridColumn MachineID;
        private DevExpress.XtraGrid.Columns.GridColumn MachineTypeID;
        private DevExpress.XtraGrid.Columns.GridColumn MachineName;
        private DevExpress.XtraGrid.Columns.GridColumn AboutMachine;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
    }
}
