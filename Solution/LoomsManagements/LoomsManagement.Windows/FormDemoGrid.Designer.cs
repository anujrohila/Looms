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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.txt_export = new DevExpress.XtraEditors.SimpleButton();
            this.btn_print = new DevExpress.XtraEditors.SimpleButton();
            this.btn_pdf = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddRecord = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.panelControl2);
            this.panelControl1.Controls.Add(this.btnAddRecord);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(796, 43);
            this.panelControl1.TabIndex = 64;
            // 
            // panelControl2
            // 
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl2.Controls.Add(this.txt_export);
            this.panelControl2.Controls.Add(this.btn_print);
            this.panelControl2.Controls.Add(this.btn_pdf);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControl2.Location = new System.Drawing.Point(491, 2);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(303, 39);
            this.panelControl2.TabIndex = 62;
            // 
            // txt_export
            // 
            this.txt_export.Appearance.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_export.Appearance.Options.UseFont = true;
            this.txt_export.Image = global::LoomsManagement.Windows.Properties.Resources.icon_excel;
            this.txt_export.Location = new System.Drawing.Point(207, 4);
            this.txt_export.Name = "txt_export";
            this.txt_export.Size = new System.Drawing.Size(86, 31);
            this.txt_export.TabIndex = 62;
            this.txt_export.Text = "&Exports";
            // 
            // btn_print
            // 
            this.btn_print.Appearance.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_print.Appearance.Options.UseFont = true;
            this.btn_print.Image = global::LoomsManagement.Windows.Properties.Resources.printer_icon;
            this.btn_print.Location = new System.Drawing.Point(23, 5);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(86, 31);
            this.btn_print.TabIndex = 61;
            this.btn_print.Text = "&Print";
            // 
            // btn_pdf
            // 
            this.btn_pdf.Appearance.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pdf.Appearance.Options.UseFont = true;
            this.btn_pdf.Image = global::LoomsManagement.Windows.Properties.Resources.i_pdf_icon;
            this.btn_pdf.Location = new System.Drawing.Point(115, 5);
            this.btn_pdf.Name = "btn_pdf";
            this.btn_pdf.Size = new System.Drawing.Size(86, 31);
            this.btn_pdf.TabIndex = 60;
            this.btn_pdf.Text = "&PDF";
            // 
            // btnAddRecord
            // 
            this.btnAddRecord.Appearance.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRecord.Appearance.Options.UseFont = true;
            this.btnAddRecord.Image = global::LoomsManagement.Windows.Properties.Resources.btnAdd;
            this.btnAddRecord.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnAddRecord.Location = new System.Drawing.Point(12, 6);
            this.btnAddRecord.Name = "btnAddRecord";
            this.btnAddRecord.Size = new System.Drawing.Size(86, 31);
            this.btnAddRecord.TabIndex = 59;
            this.btnAddRecord.Text = "&Add";
            // 
            // FormDemoGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 381);
            this.Controls.Add(this.panelControl1);
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
        public DevExpress.XtraEditors.SimpleButton btn_pdf;
        public DevExpress.XtraEditors.SimpleButton btnAddRecord;
        public DevExpress.XtraEditors.SimpleButton btn_print;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        public DevExpress.XtraEditors.SimpleButton txt_export;
    }
}