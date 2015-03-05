namespace LoomsManagement.Windows.Forms.Master
{
    partial class BeamMasterView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BeamMasterView));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.BeemID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CompnayID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.WrapperPartyName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.JobberPartyName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BeemDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.YarnQuality = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GrayQuality = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TarNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Meters = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Taka = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Weight = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ProductionMeters = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ProductionTaka = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PipeWeight = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LoadingDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MinStragy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MachinNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BhidanStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BhidanDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PasaraiName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Count = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IssuDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TakaMeter = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Rate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Amount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MeterConsumption = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RPM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Pick = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Remarks = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnSave);
            this.panelControl1.Location = new System.Drawing.Point(12, 12);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(964, 49);
            this.panelControl1.TabIndex = 1;
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
            // gridControl1
            // 
            this.gridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl1.Location = new System.Drawing.Point(12, 67);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(964, 408);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.BeemID,
            this.CompnayID,
            this.WrapperPartyName,
            this.JobberPartyName,
            this.BeemDate,
            this.YarnQuality,
            this.GrayQuality,
            this.TarNo,
            this.Meters,
            this.Taka,
            this.Weight,
            this.ProductionMeters,
            this.ProductionTaka,
            this.PipeWeight,
            this.LoadingDate,
            this.MinStragy,
            this.MachinNo,
            this.BhidanStatus,
            this.BhidanDate,
            this.PasaraiName,
            this.Count,
            this.IssuDate,
            this.TakaMeter,
            this.Rate,
            this.Amount,
            this.MeterConsumption,
            this.RPM,
            this.Pick,
            this.Remarks});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // BeemID
            // 
            this.BeemID.Caption = "Beem ID";
            this.BeemID.FieldName = "BeemID";
            this.BeemID.Name = "BeemID";
            // 
            // CompnayID
            // 
            this.CompnayID.Caption = "Compnay ID";
            this.CompnayID.FieldName = "CompnayID";
            this.CompnayID.Name = "CompnayID";
            // 
            // WrapperPartyName
            // 
            this.WrapperPartyName.Caption = "Wrapper Party Name";
            this.WrapperPartyName.FieldName = "WrapperPartyName";
            this.WrapperPartyName.Name = "WrapperPartyName";
            this.WrapperPartyName.Visible = true;
            this.WrapperPartyName.VisibleIndex = 0;
            this.WrapperPartyName.Width = 176;
            // 
            // JobberPartyName
            // 
            this.JobberPartyName.Caption = "Jobber Party Name";
            this.JobberPartyName.FieldName = "JobberPartyName";
            this.JobberPartyName.Name = "JobberPartyName";
            this.JobberPartyName.Visible = true;
            this.JobberPartyName.VisibleIndex = 1;
            this.JobberPartyName.Width = 28;
            // 
            // BeemDate
            // 
            this.BeemDate.Caption = "Beem Date";
            this.BeemDate.FieldName = "BeemDate";
            this.BeemDate.Name = "BeemDate";
            this.BeemDate.Visible = true;
            this.BeemDate.VisibleIndex = 2;
            this.BeemDate.Width = 21;
            // 
            // YarnQuality
            // 
            this.YarnQuality.Caption = "Yarn Quality";
            this.YarnQuality.FieldName = "YarnQuality";
            this.YarnQuality.Name = "YarnQuality";
            this.YarnQuality.Visible = true;
            this.YarnQuality.VisibleIndex = 3;
            this.YarnQuality.Width = 20;
            // 
            // GrayQuality
            // 
            this.GrayQuality.Caption = "Gray Quality";
            this.GrayQuality.FieldName = "GrayQuality";
            this.GrayQuality.Name = "GrayQuality";
            this.GrayQuality.Visible = true;
            this.GrayQuality.VisibleIndex = 4;
            this.GrayQuality.Width = 20;
            // 
            // TarNo
            // 
            this.TarNo.Caption = "Tar No";
            this.TarNo.FieldName = "TarNo";
            this.TarNo.Name = "TarNo";
            this.TarNo.Visible = true;
            this.TarNo.VisibleIndex = 5;
            this.TarNo.Width = 20;
            // 
            // Meters
            // 
            this.Meters.Caption = "Meters";
            this.Meters.FieldName = "Meters";
            this.Meters.Name = "Meters";
            this.Meters.Visible = true;
            this.Meters.VisibleIndex = 6;
            this.Meters.Width = 26;
            // 
            // Taka
            // 
            this.Taka.Caption = "Taka";
            this.Taka.FieldName = "Taka";
            this.Taka.Name = "Taka";
            this.Taka.Visible = true;
            this.Taka.VisibleIndex = 7;
            this.Taka.Width = 26;
            // 
            // Weight
            // 
            this.Weight.Caption = "Weight";
            this.Weight.FieldName = "Weight";
            this.Weight.Name = "Weight";
            this.Weight.Visible = true;
            this.Weight.VisibleIndex = 8;
            this.Weight.Width = 26;
            // 
            // ProductionMeters
            // 
            this.ProductionMeters.Caption = "Production Meters";
            this.ProductionMeters.FieldName = "ProductionMeters";
            this.ProductionMeters.Name = "ProductionMeters";
            this.ProductionMeters.Visible = true;
            this.ProductionMeters.VisibleIndex = 9;
            this.ProductionMeters.Width = 20;
            // 
            // ProductionTaka
            // 
            this.ProductionTaka.Caption = "Production Taka";
            this.ProductionTaka.FieldName = "ProductionTaka";
            this.ProductionTaka.Name = "ProductionTaka";
            this.ProductionTaka.Visible = true;
            this.ProductionTaka.VisibleIndex = 10;
            this.ProductionTaka.Width = 26;
            // 
            // PipeWeight
            // 
            this.PipeWeight.Caption = "PipeWeight";
            this.PipeWeight.FieldName = "PipeWeight";
            this.PipeWeight.Name = "PipeWeight";
            this.PipeWeight.Visible = true;
            this.PipeWeight.VisibleIndex = 11;
            this.PipeWeight.Width = 26;
            // 
            // LoadingDate
            // 
            this.LoadingDate.Caption = "Loading Date";
            this.LoadingDate.FieldName = "LoadingDate";
            this.LoadingDate.Name = "LoadingDate";
            this.LoadingDate.Visible = true;
            this.LoadingDate.VisibleIndex = 12;
            this.LoadingDate.Width = 27;
            // 
            // MinStragy
            // 
            this.MinStragy.Caption = "Min Stragy";
            this.MinStragy.FieldName = "MinStragy";
            this.MinStragy.MinWidth = 60;
            this.MinStragy.Name = "MinStragy";
            this.MinStragy.Visible = true;
            this.MinStragy.VisibleIndex = 13;
            this.MinStragy.Width = 60;
            // 
            // MachinNo
            // 
            this.MachinNo.Caption = "Machin No";
            this.MachinNo.FieldName = "MachinNo";
            this.MachinNo.Name = "MachinNo";
            this.MachinNo.Visible = true;
            this.MachinNo.VisibleIndex = 14;
            this.MachinNo.Width = 20;
            // 
            // BhidanStatus
            // 
            this.BhidanStatus.Caption = "Bhidan Status";
            this.BhidanStatus.FieldName = "BhidanStatus";
            this.BhidanStatus.Name = "BhidanStatus";
            this.BhidanStatus.Visible = true;
            this.BhidanStatus.VisibleIndex = 15;
            this.BhidanStatus.Width = 20;
            // 
            // BhidanDate
            // 
            this.BhidanDate.Caption = "Bhidan Date";
            this.BhidanDate.FieldName = "BhidanDate";
            this.BhidanDate.Name = "BhidanDate";
            this.BhidanDate.Visible = true;
            this.BhidanDate.VisibleIndex = 16;
            this.BhidanDate.Width = 40;
            // 
            // PasaraiName
            // 
            this.PasaraiName.Caption = "Pasarai Name";
            this.PasaraiName.FieldName = "PasaraiName";
            this.PasaraiName.Name = "PasaraiName";
            this.PasaraiName.Visible = true;
            this.PasaraiName.VisibleIndex = 17;
            this.PasaraiName.Width = 67;
            // 
            // Count
            // 
            this.Count.Caption = "Count";
            this.Count.FieldName = "Count";
            this.Count.Name = "Count";
            this.Count.Visible = true;
            this.Count.VisibleIndex = 18;
            this.Count.Width = 32;
            // 
            // IssuDate
            // 
            this.IssuDate.Caption = "Issu Date";
            this.IssuDate.FieldName = "IssuDate";
            this.IssuDate.Name = "IssuDate";
            this.IssuDate.Visible = true;
            this.IssuDate.VisibleIndex = 19;
            this.IssuDate.Width = 55;
            // 
            // TakaMeter
            // 
            this.TakaMeter.Caption = "Taka Meter";
            this.TakaMeter.FieldName = "TakaMeter";
            this.TakaMeter.Name = "TakaMeter";
            this.TakaMeter.Visible = true;
            this.TakaMeter.VisibleIndex = 20;
            this.TakaMeter.Width = 20;
            // 
            // Rate
            // 
            this.Rate.Caption = "Rate";
            this.Rate.FieldName = "Rate";
            this.Rate.Name = "Rate";
            this.Rate.Visible = true;
            this.Rate.VisibleIndex = 21;
            this.Rate.Width = 37;
            // 
            // Amount
            // 
            this.Amount.Caption = "Amount";
            this.Amount.FieldName = "Amount";
            this.Amount.Name = "Amount";
            this.Amount.Visible = true;
            this.Amount.VisibleIndex = 22;
            this.Amount.Width = 53;
            // 
            // MeterConsumption
            // 
            this.MeterConsumption.Caption = "Meter Consumption";
            this.MeterConsumption.FieldName = "MeterConsumption";
            this.MeterConsumption.Name = "MeterConsumption";
            this.MeterConsumption.Visible = true;
            this.MeterConsumption.VisibleIndex = 23;
            this.MeterConsumption.Width = 20;
            // 
            // RPM
            // 
            this.RPM.Caption = "RPM";
            this.RPM.FieldName = "RPM";
            this.RPM.Name = "RPM";
            this.RPM.Visible = true;
            this.RPM.VisibleIndex = 24;
            this.RPM.Width = 20;
            // 
            // Pick
            // 
            this.Pick.Caption = "Pick";
            this.Pick.FieldName = "Pick";
            this.Pick.Name = "Pick";
            this.Pick.Visible = true;
            this.Pick.VisibleIndex = 25;
            this.Pick.Width = 20;
            // 
            // Remarks
            // 
            this.Remarks.Caption = "Remarks";
            this.Remarks.FieldName = "Remarks";
            this.Remarks.Name = "Remarks";
            this.Remarks.Visible = true;
            this.Remarks.VisibleIndex = 26;
            this.Remarks.Width = 100;
            // 
            // BeamMasterView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 500);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panelControl1);
            this.Name = "BeamMasterView";
            this.Text = "Beam Master View";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        public DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn BeemID;
        private DevExpress.XtraGrid.Columns.GridColumn CompnayID;
        private DevExpress.XtraGrid.Columns.GridColumn WrapperPartyName;
        private DevExpress.XtraGrid.Columns.GridColumn JobberPartyName;
        private DevExpress.XtraGrid.Columns.GridColumn BeemDate;
        private DevExpress.XtraGrid.Columns.GridColumn YarnQuality;
        private DevExpress.XtraGrid.Columns.GridColumn GrayQuality;
        private DevExpress.XtraGrid.Columns.GridColumn TarNo;
        private DevExpress.XtraGrid.Columns.GridColumn Meters;
        private DevExpress.XtraGrid.Columns.GridColumn Taka;
        private DevExpress.XtraGrid.Columns.GridColumn Weight;
        private DevExpress.XtraGrid.Columns.GridColumn ProductionMeters;
        private DevExpress.XtraGrid.Columns.GridColumn ProductionTaka;
        private DevExpress.XtraGrid.Columns.GridColumn PipeWeight;
        private DevExpress.XtraGrid.Columns.GridColumn LoadingDate;
        private DevExpress.XtraGrid.Columns.GridColumn MinStragy;
        private DevExpress.XtraGrid.Columns.GridColumn MachinNo;
        private DevExpress.XtraGrid.Columns.GridColumn BhidanStatus;
        private DevExpress.XtraGrid.Columns.GridColumn BhidanDate;
        private DevExpress.XtraGrid.Columns.GridColumn PasaraiName;
        private DevExpress.XtraGrid.Columns.GridColumn Count;
        private DevExpress.XtraGrid.Columns.GridColumn IssuDate;
        private DevExpress.XtraGrid.Columns.GridColumn TakaMeter;
        private DevExpress.XtraGrid.Columns.GridColumn Rate;
        private DevExpress.XtraGrid.Columns.GridColumn Amount;
        private DevExpress.XtraGrid.Columns.GridColumn MeterConsumption;
        private DevExpress.XtraGrid.Columns.GridColumn RPM;
        private DevExpress.XtraGrid.Columns.GridColumn Pick;
        private DevExpress.XtraGrid.Columns.GridColumn Remarks;
    }
}