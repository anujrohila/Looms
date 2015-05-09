namespace LoomsMana.Forms.Master
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dpEndDate = new DevExpress.XtraEditors.DateEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.dpStartDate = new DevExpress.XtraEditors.DateEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.pnlMain.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.xtraScrollableControl1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dpEndDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpEndDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpStartDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpStartDate.Properties)).BeginInit();
            this.SuspendLayout();
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
            this.btnSave.LookAndFeel.SkinName = "VS2010";
            // 
            // btndelete
            // 
            this.btndelete.Appearance.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.Appearance.Options.UseFont = true;
            // 
            // pnlMain
            // 
            this.pnlMain.Location = new System.Drawing.Point(0, 47);
            this.pnlMain.Size = new System.Drawing.Size(377, 115);
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.label3);
            this.pnlHeader.Controls.Add(this.label2);
            this.pnlHeader.Controls.Add(this.label1);
            this.pnlHeader.Controls.Add(this.shapeContainer1);
            this.pnlHeader.Size = new System.Drawing.Size(377, 47);
            this.pnlHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlHeader_Paint);
            // 
            // pnlFooter
            // 
            this.pnlFooter.Location = new System.Drawing.Point(0, 162);
            this.pnlFooter.Size = new System.Drawing.Size(377, 62);
            // 
            // xtraScrollableControl1
            // 
            this.xtraScrollableControl1.Controls.Add(this.groupBox2);
            this.xtraScrollableControl1.Size = new System.Drawing.Size(377, 115);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Lucida Sans Unicode", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(69, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Y";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "iscal    ear";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(16, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "F";
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.rectangleShape1.FillColor = System.Drawing.Color.Blue;
            this.rectangleShape1.FillGradientColor = System.Drawing.Color.Transparent;
            this.rectangleShape1.FillGradientStyle = Microsoft.VisualBasic.PowerPacks.FillGradientStyle.Horizontal;
            this.rectangleShape1.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.rectangleShape1.Location = new System.Drawing.Point(20, 33);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(107, 2);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(377, 47);
            this.shapeContainer1.TabIndex = 8;
            this.shapeContainer1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dpEndDate);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.labelControl2);
            this.groupBox2.Controls.Add(this.dpStartDate);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.labelControl1);
            this.groupBox2.Location = new System.Drawing.Point(21, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(332, 98);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // dpEndDate
            // 
            this.dpEndDate.EditValue = null;
            this.dpEndDate.Location = new System.Drawing.Point(102, 54);
            this.dpEndDate.Name = "dpEndDate";
            this.dpEndDate.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.dpEndDate.Properties.Appearance.Options.UseFont = true;
            this.dpEndDate.Properties.AppearanceFocused.BackColor = System.Drawing.Color.Lavender;
            this.dpEndDate.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.dpEndDate.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.dpEndDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dpEndDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dpEndDate.Size = new System.Drawing.Size(189, 24);
            this.dpEndDate.TabIndex = 93;
            this.dpEndDate.ToolTip = "Select Date.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(78, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 17);
            this.label4.TabIndex = 95;
            this.label4.Text = "*";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelControl2.Location = new System.Drawing.Point(15, 56);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(57, 17);
            this.labelControl2.TabIndex = 94;
            this.labelControl2.Text = "End Date";
            // 
            // dpStartDate
            // 
            this.dpStartDate.EditValue = null;
            this.dpStartDate.Location = new System.Drawing.Point(102, 21);
            this.dpStartDate.Name = "dpStartDate";
            this.dpStartDate.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.dpStartDate.Properties.Appearance.Options.UseFont = true;
            this.dpStartDate.Properties.AppearanceFocused.BackColor = System.Drawing.Color.Lavender;
            this.dpStartDate.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.dpStartDate.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.dpStartDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dpStartDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dpStartDate.Size = new System.Drawing.Size(189, 24);
            this.dpStartDate.TabIndex = 90;
            this.dpStartDate.ToolTip = "Select Date.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(78, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 17);
            this.label5.TabIndex = 92;
            this.label5.Text = "*";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelControl1.Location = new System.Drawing.Point(15, 24);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(62, 17);
            this.labelControl1.TabIndex = 91;
            this.labelControl1.Text = "Strat Date";
            // 
            // frmFiscalYearMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(377, 224);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmFiscalYearMaster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fiscal Year";
            this.pnlMain.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.xtraScrollableControl1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dpEndDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpEndDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpStartDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpStartDate.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.DateEdit dpEndDate;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.DateEdit dpStartDate;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}
