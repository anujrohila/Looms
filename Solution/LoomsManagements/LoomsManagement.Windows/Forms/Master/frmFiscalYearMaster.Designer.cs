namespace LoomsManagement.Windows.Forms.Master
{
    partial class frmFiscalYearMaster
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
            this.components = new System.ComponentModel.Container();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.dpStartDate = new DevExpress.XtraEditors.DateEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.errorWrongDate = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.dpEndDate = new DevExpress.XtraEditors.DateEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dpStartDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpStartDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorWrongDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpEndDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpEndDate.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Location = new System.Drawing.Point(414, 0);
            this.panelControl1.Size = new System.Drawing.Size(123, 160);
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
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Appearance.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btndelete
            // 
            this.btndelete.Appearance.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.Appearance.Options.UseFont = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelControl2);
            this.panel1.Size = new System.Drawing.Size(414, 160);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.dpEndDate);
            this.panelControl2.Controls.Add(this.label1);
            this.panelControl2.Controls.Add(this.labelControl2);
            this.panelControl2.Controls.Add(this.dpStartDate);
            this.panelControl2.Controls.Add(this.label4);
            this.panelControl2.Controls.Add(this.labelControl1);
            this.panelControl2.Location = new System.Drawing.Point(12, 12);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(390, 135);
            this.panelControl2.TabIndex = 64;
            // 
            // dpStartDate
            // 
            this.dpStartDate.EditValue = null;
            this.errorWrongDate.SetIconAlignment(this.dpStartDate, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.dpStartDate.Location = new System.Drawing.Point(137, 14);
            this.dpStartDate.Name = "dpStartDate";
            this.dpStartDate.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.dpStartDate.Properties.Appearance.Options.UseFont = true;
            this.dpStartDate.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.dpStartDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dpStartDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dpStartDate.Size = new System.Drawing.Size(189, 26);
            this.dpStartDate.TabIndex = 3;
            this.dpStartDate.ToolTip = "Select Date.";
            this.dpStartDate.Enter += new System.EventHandler(this.EnterEvent);
            this.dpStartDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.dpStartDate.Leave += new System.EventHandler(this.LeaveEvent);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(73, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 17);
            this.label4.TabIndex = 86;
            this.label4.Text = "*";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(10, 17);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(62, 17);
            this.labelControl1.TabIndex = 72;
            this.labelControl1.Text = "Strat Date";
            // 
            // errorWrongDate
            // 
            this.errorWrongDate.ContainerControl = this;
            // 
            // dpEndDate
            // 
            this.dpEndDate.EditValue = null;
            this.errorWrongDate.SetIconAlignment(this.dpEndDate, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.dpEndDate.Location = new System.Drawing.Point(137, 63);
            this.dpEndDate.Name = "dpEndDate";
            this.dpEndDate.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.dpEndDate.Properties.Appearance.Options.UseFont = true;
            this.dpEndDate.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.dpEndDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dpEndDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dpEndDate.Size = new System.Drawing.Size(189, 26);
            this.dpEndDate.TabIndex = 87;
            this.dpEndDate.ToolTip = "Select Date.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(73, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 17);
            this.label1.TabIndex = 89;
            this.label1.Text = "*";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(10, 65);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(57, 17);
            this.labelControl2.TabIndex = 88;
            this.labelControl2.Text = "End Date";
            // 
            // frmFiscalYearMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(537, 160);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFiscalYearMaster";
            this.ShowInTaskbar = false;
            this.Text = "Fiscal Year";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Page_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dpStartDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpStartDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorWrongDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpEndDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpEndDate.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.DateEdit dpStartDate;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider errorWrongDate;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.DateEdit dpEndDate;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}
