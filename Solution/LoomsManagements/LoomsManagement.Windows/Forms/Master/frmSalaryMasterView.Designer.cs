namespace LoomsManagement.Windows.Forms.Master
{
    partial class frmSalaryMasterView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSalaryMasterView));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.gridSalaryMaster = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.SalaryID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EmployeeID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.StartDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EndDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.WorkedHours = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TotalPenalty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Bonus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.WithdrownAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NetSalary = new DevExpress.XtraGrid.Columns.GridColumn();
            this.WithdrownID = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSalaryMaster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnSave);
            this.panelControl1.Location = new System.Drawing.Point(12, 12);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(565, 49);
            this.panelControl1.TabIndex = 4;
            // 
            // btnSave
            // 
            this.btnSave.Appearance.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(15, 9);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(86, 31);
            this.btnSave.TabIndex = 58;
            this.btnSave.Text = "&Add";
            // 
            // gridSalaryMaster
            // 
            this.gridSalaryMaster.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridSalaryMaster.Location = new System.Drawing.Point(12, 67);
            this.gridSalaryMaster.MainView = this.gridView1;
            this.gridSalaryMaster.Name = "gridSalaryMaster";
            this.gridSalaryMaster.Size = new System.Drawing.Size(565, 381);
            this.gridSalaryMaster.TabIndex = 5;
            this.gridSalaryMaster.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.SalaryID,
            this.EmployeeID,
            this.WithdrownID,
            this.Date,
            this.StartDate,
            this.EndDate,
            this.WorkedHours,
            this.TotalPenalty,
            this.Bonus,
            this.WithdrownAmount,
            this.NetSalary});
            this.gridView1.GridControl = this.gridSalaryMaster;
            this.gridView1.Name = "gridView1";
            // 
            // SalaryID
            // 
            this.SalaryID.Caption = "Salary ID";
            this.SalaryID.FieldName = "SalaryID";
            this.SalaryID.Name = "SalaryID";
            // 
            // EmployeeID
            // 
            this.EmployeeID.Caption = "Employee ID";
            this.EmployeeID.FieldName = "EmployeeID";
            this.EmployeeID.Name = "EmployeeID";
            // 
            // Date
            // 
            this.Date.Caption = "Salary Date";
            this.Date.FieldName = "Date";
            this.Date.Name = "Date";
            this.Date.Visible = true;
            this.Date.VisibleIndex = 0;
            // 
            // StartDate
            // 
            this.StartDate.Caption = "Start Date";
            this.StartDate.FieldName = "StartDate";
            this.StartDate.Name = "StartDate";
            this.StartDate.Visible = true;
            this.StartDate.VisibleIndex = 1;
            // 
            // EndDate
            // 
            this.EndDate.Caption = "End Date";
            this.EndDate.FieldName = "EndDate";
            this.EndDate.Name = "EndDate";
            this.EndDate.Visible = true;
            this.EndDate.VisibleIndex = 2;
            // 
            // WorkedHours
            // 
            this.WorkedHours.Caption = "Worked Hours";
            this.WorkedHours.FieldName = "WorkedHours";
            this.WorkedHours.Name = "WorkedHours";
            this.WorkedHours.Visible = true;
            this.WorkedHours.VisibleIndex = 3;
            // 
            // TotalPenalty
            // 
            this.TotalPenalty.Caption = "Total Penalty";
            this.TotalPenalty.FieldName = "TotalPenalty";
            this.TotalPenalty.Name = "TotalPenalty";
            this.TotalPenalty.Visible = true;
            this.TotalPenalty.VisibleIndex = 4;
            // 
            // Bonus
            // 
            this.Bonus.Caption = "Bonus";
            this.Bonus.FieldName = "Bonus";
            this.Bonus.Name = "Bonus";
            this.Bonus.Visible = true;
            this.Bonus.VisibleIndex = 5;
            // 
            // WithdrownAmount
            // 
            this.WithdrownAmount.Caption = "Withdrown Amount";
            this.WithdrownAmount.FieldName = "WithdrownAmount";
            this.WithdrownAmount.Name = "WithdrownAmount";
            this.WithdrownAmount.Visible = true;
            this.WithdrownAmount.VisibleIndex = 6;
            // 
            // NetSalary
            // 
            this.NetSalary.Caption = "Net Salary";
            this.NetSalary.FieldName = "NetSalary";
            this.NetSalary.Name = "NetSalary";
            this.NetSalary.Visible = true;
            this.NetSalary.VisibleIndex = 7;
            // 
            // WithdrownID
            // 
            this.WithdrownID.Caption = "Withdrown ID";
            this.WithdrownID.FieldName = "WithdrownID";
            this.WithdrownID.Name = "WithdrownID";
            // 
            // frmSalaryMasterView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 460);
            this.Controls.Add(this.gridSalaryMaster);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmSalaryMasterView";
            this.Text = "Salary Master View";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridSalaryMaster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        public DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraGrid.GridControl gridSalaryMaster;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn SalaryID;
        private DevExpress.XtraGrid.Columns.GridColumn EmployeeID;
        private DevExpress.XtraGrid.Columns.GridColumn WithdrownID;
        private DevExpress.XtraGrid.Columns.GridColumn Date;
        private DevExpress.XtraGrid.Columns.GridColumn StartDate;
        private DevExpress.XtraGrid.Columns.GridColumn EndDate;
        private DevExpress.XtraGrid.Columns.GridColumn WorkedHours;
        private DevExpress.XtraGrid.Columns.GridColumn TotalPenalty;
        private DevExpress.XtraGrid.Columns.GridColumn Bonus;
        private DevExpress.XtraGrid.Columns.GridColumn WithdrownAmount;
        private DevExpress.XtraGrid.Columns.GridColumn NetSalary;
    }
}