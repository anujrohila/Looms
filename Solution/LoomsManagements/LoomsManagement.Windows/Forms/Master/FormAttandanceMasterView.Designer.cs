namespace LoomsManagement.Windows.Forms.Master
{
    partial class FormAttandanceMasterView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAttandanceMasterView));
            this.gridAttandanceMaster = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.AttendanceID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EmployeeID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.StartTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EndTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MeterWorked = new DevExpress.XtraGrid.Columns.GridColumn();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridAttandanceMaster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Size = new System.Drawing.Size(107, 394);
            // 
            // btnReport
            // 
            this.btnReport.Appearance.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.Appearance.Options.UseFont = true;
            // 
            // btnExit
            // 
            this.btnExit.Appearance.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Appearance.Options.UseFont = true;
            // 
            // btnSave
            // 
            this.btnSave.Appearance.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Appearance.Options.UseFont = true;
            // 
            // btndelete
            // 
            this.btndelete.Appearance.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.Appearance.Options.UseFont = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gridAttandanceMaster);
            this.panel1.Controls.Add(this.panelControl2);
            this.panel1.Size = new System.Drawing.Size(574, 394);
            // 
            // gridAttandanceMaster
            // 
            this.gridAttandanceMaster.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridAttandanceMaster.Location = new System.Drawing.Point(12, 71);
            this.gridAttandanceMaster.MainView = this.gridView1;
            this.gridAttandanceMaster.Name = "gridAttandanceMaster";
            this.gridAttandanceMaster.Size = new System.Drawing.Size(553, 315);
            this.gridAttandanceMaster.TabIndex = 8;
            this.gridAttandanceMaster.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.AttendanceID,
            this.EmployeeID,
            this.StartTime,
            this.EndTime,
            this.MeterWorked});
            this.gridView1.GridControl = this.gridAttandanceMaster;
            this.gridView1.Name = "gridView1";
            // 
            // AttendanceID
            // 
            this.AttendanceID.Caption = "Attendance ID";
            this.AttendanceID.FieldName = "AttendanceID";
            this.AttendanceID.Name = "AttendanceID";
            // 
            // EmployeeID
            // 
            this.EmployeeID.Caption = "Employee ID";
            this.EmployeeID.FieldName = "EmployeeID";
            this.EmployeeID.Name = "EmployeeID";
            // 
            // StartTime
            // 
            this.StartTime.Caption = "Start Time";
            this.StartTime.FieldName = "StartTime";
            this.StartTime.Name = "StartTime";
            this.StartTime.Visible = true;
            this.StartTime.VisibleIndex = 0;
            this.StartTime.Width = 100;
            // 
            // EndTime
            // 
            this.EndTime.Caption = "End Time";
            this.EndTime.FieldName = "EndTime";
            this.EndTime.Name = "EndTime";
            this.EndTime.Visible = true;
            this.EndTime.VisibleIndex = 1;
            this.EndTime.Width = 100;
            // 
            // MeterWorked
            // 
            this.MeterWorked.Caption = "Meter Worked";
            this.MeterWorked.FieldName = "MeterWorked";
            this.MeterWorked.Name = "MeterWorked";
            this.MeterWorked.Visible = true;
            this.MeterWorked.VisibleIndex = 2;
            this.MeterWorked.Width = 100;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(14, 9);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(86, 31);
            this.simpleButton1.TabIndex = 58;
            this.simpleButton1.Text = "&Add";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.simpleButton1);
            this.panelControl2.Location = new System.Drawing.Point(12, 15);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(553, 49);
            this.panelControl2.TabIndex = 7;
            // 
            // FormAttandanceMasterView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(681, 394);
            this.Name = "FormAttandanceMasterView";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridAttandanceMaster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridAttandanceMaster;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn AttendanceID;
        private DevExpress.XtraGrid.Columns.GridColumn EmployeeID;
        private DevExpress.XtraGrid.Columns.GridColumn StartTime;
        private DevExpress.XtraGrid.Columns.GridColumn EndTime;
        private DevExpress.XtraGrid.Columns.GridColumn MeterWorked;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        public DevExpress.XtraEditors.SimpleButton simpleButton1;

    }
}
