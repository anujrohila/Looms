﻿namespace LoomsManagement.Windows.Forms.Master
{
    partial class frmAttandanceMasterView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAttandanceMasterView));
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.AttendanceID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EmployeeID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.StartTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EndTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MeterWorked = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridAttandanceMaster = new DevExpress.XtraGrid.GridControl();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridAttandanceMaster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
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
            // gridAttandanceMaster
            // 
            this.gridAttandanceMaster.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridAttandanceMaster.Location = new System.Drawing.Point(6, 61);
            this.gridAttandanceMaster.MainView = this.gridView1;
            this.gridAttandanceMaster.Name = "gridAttandanceMaster";
            this.gridAttandanceMaster.Size = new System.Drawing.Size(553, 315);
            this.gridAttandanceMaster.TabIndex = 6;
            this.gridAttandanceMaster.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // btnSave
            // 
            this.btnSave.Appearance.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(14, 9);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(86, 31);
            this.btnSave.TabIndex = 58;
            this.btnSave.Text = "&Add";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnSave);
            this.panelControl1.Location = new System.Drawing.Point(6, 5);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(553, 49);
            this.panelControl1.TabIndex = 5;
            // 
            // frmAttandanceMasterView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 393);
            this.Controls.Add(this.gridAttandanceMaster);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmAttandanceMasterView";
            this.Text = "Attandance Master View";
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridAttandanceMaster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn AttendanceID;
        private DevExpress.XtraGrid.Columns.GridColumn EmployeeID;
        private DevExpress.XtraGrid.Columns.GridColumn StartTime;
        private DevExpress.XtraGrid.Columns.GridColumn EndTime;
        private DevExpress.XtraGrid.Columns.GridColumn MeterWorked;
        private DevExpress.XtraGrid.GridControl gridAttandanceMaster;
        public DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.PanelControl panelControl1;

    }
}