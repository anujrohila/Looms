namespace LoomsManagement.Windows
{
    partial class FormDemoGrid
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDemoGrid));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnMasterExcel = new DevExpress.XtraEditors.SimpleButton();
            this.BtnMasterPrint = new DevExpress.XtraEditors.SimpleButton();
            this.BtnMasterPDF = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.panelControl2);
            this.panelControl1.Controls.Add(this.btnAdd);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(796, 43);
            this.panelControl1.TabIndex = 64;
            // 
            // panelControl2
            // 
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl2.Controls.Add(this.btnMasterExcel);
            this.panelControl2.Controls.Add(this.BtnMasterPrint);
            this.panelControl2.Controls.Add(this.BtnMasterPDF);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControl2.Location = new System.Drawing.Point(491, 2);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(303, 39);
            this.panelControl2.TabIndex = 62;
            // 
            // btnMasterExcel
            // 
            this.btnMasterExcel.Appearance.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMasterExcel.Appearance.Options.UseFont = true;
            this.btnMasterExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnMasterExcel.Image")));
            this.btnMasterExcel.Location = new System.Drawing.Point(207, 4);
            this.btnMasterExcel.Name = "btnMasterExcel";
            this.btnMasterExcel.Size = new System.Drawing.Size(86, 31);
            this.btnMasterExcel.TabIndex = 62;
            this.btnMasterExcel.Text = "&Exports";
            // 
            // BtnMasterPrint
            // 
            this.BtnMasterPrint.Appearance.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMasterPrint.Appearance.Options.UseFont = true;
            this.BtnMasterPrint.Image = ((System.Drawing.Image)(resources.GetObject("BtnMasterPrint.Image")));
            this.BtnMasterPrint.Location = new System.Drawing.Point(23, 5);
            this.BtnMasterPrint.Name = "BtnMasterPrint";
            this.BtnMasterPrint.Size = new System.Drawing.Size(86, 31);
            this.BtnMasterPrint.TabIndex = 61;
            this.BtnMasterPrint.Text = "&Print";
            // 
            // BtnMasterPDF
            // 
            this.BtnMasterPDF.Appearance.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMasterPDF.Appearance.Options.UseFont = true;
            this.BtnMasterPDF.Image = ((System.Drawing.Image)(resources.GetObject("BtnMasterPDF.Image")));
            this.BtnMasterPDF.Location = new System.Drawing.Point(115, 5);
            this.BtnMasterPDF.Name = "BtnMasterPDF";
            this.BtnMasterPDF.Size = new System.Drawing.Size(86, 31);
            this.BtnMasterPDF.TabIndex = 60;
            this.BtnMasterPDF.Text = "&PDF";
            // 
            // btnAdd
            // 
            this.btnAdd.Appearance.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Appearance.Options.UseFont = true;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(12, 6);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(86, 31);
            this.btnAdd.TabIndex = 59;
            this.btnAdd.Text = "&Add";
            // 
            // FormDemoGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 381);
            this.Controls.Add(this.panelControl1);
            this.KeyPreview = true;
            this.Name = "FormDemoGrid";
            this.Text = "FormDemoGrid";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        public DevExpress.XtraEditors.SimpleButton BtnMasterPDF;
        public DevExpress.XtraEditors.SimpleButton btnAdd;
        public DevExpress.XtraEditors.SimpleButton BtnMasterPrint;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        public DevExpress.XtraEditors.SimpleButton btnMasterExcel;
    }
}