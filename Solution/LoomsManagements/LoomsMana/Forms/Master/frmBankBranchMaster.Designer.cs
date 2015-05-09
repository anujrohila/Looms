namespace LoomsMana.Forms.Master
{
    partial class frmBankBranchMaster
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
            this.txtAddress = new DevExpress.XtraEditors.MemoEdit();
            this.cmbBankName = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtBranchName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.pnlMain.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.xtraScrollableControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbBankName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBranchName.Properties)).BeginInit();
            this.groupBox2.SuspendLayout();
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
            this.pnlMain.Location = new System.Drawing.Point(0, 46);
            this.pnlMain.Size = new System.Drawing.Size(385, 150);
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.label3);
            this.pnlHeader.Controls.Add(this.label2);
            this.pnlHeader.Controls.Add(this.label1);
            this.pnlHeader.Controls.Add(this.shapeContainer1);
            this.pnlHeader.Size = new System.Drawing.Size(385, 46);
            // 
            // pnlFooter
            // 
            this.pnlFooter.Location = new System.Drawing.Point(0, 196);
            this.pnlFooter.Size = new System.Drawing.Size(385, 62);
            // 
            // xtraScrollableControl1
            // 
            this.xtraScrollableControl1.Controls.Add(this.groupBox2);
            this.xtraScrollableControl1.Size = new System.Drawing.Size(385, 150);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(119, 79);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Properties.AppearanceFocused.BackColor = System.Drawing.Color.Lavender;
            this.txtAddress.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtAddress.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.txtAddress.Size = new System.Drawing.Size(205, 49);
            this.txtAddress.TabIndex = 174;
            // 
            // cmbBankName
            // 
            this.cmbBankName.Location = new System.Drawing.Point(119, 14);
            this.cmbBankName.Name = "cmbBankName";
            this.cmbBankName.Properties.Appearance.Font = new System.Drawing.Font("Cambria", 11.25F);
            this.cmbBankName.Properties.Appearance.Options.UseFont = true;
            this.cmbBankName.Properties.AppearanceDisabled.Font = new System.Drawing.Font("Cambria", 11.25F);
            this.cmbBankName.Properties.AppearanceDisabled.Options.UseFont = true;
            this.cmbBankName.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Cambria", 11.25F);
            this.cmbBankName.Properties.AppearanceDropDown.Options.UseFont = true;
            this.cmbBankName.Properties.AppearanceDropDownHeader.Font = new System.Drawing.Font("Cambria", 11.25F);
            this.cmbBankName.Properties.AppearanceDropDownHeader.Options.UseFont = true;
            this.cmbBankName.Properties.AppearanceFocused.BackColor = System.Drawing.Color.Lavender;
            this.cmbBankName.Properties.AppearanceFocused.Font = new System.Drawing.Font("Cambria", 11.25F);
            this.cmbBankName.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.cmbBankName.Properties.AppearanceFocused.Options.UseFont = true;
            this.cmbBankName.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("Cambria", 11.25F);
            this.cmbBankName.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.cmbBankName.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.cmbBankName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbBankName.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BankID", "BankID", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BankName", " Bank Name")});
            this.cmbBankName.Properties.NullText = "";
            this.cmbBankName.Size = new System.Drawing.Size(205, 24);
            this.cmbBankName.TabIndex = 172;
            this.cmbBankName.ToolTip = "Select Bank Name.";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelControl2.Location = new System.Drawing.Point(15, 81);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(50, 17);
            this.labelControl2.TabIndex = 177;
            this.labelControl2.Text = "Address";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelControl1.Location = new System.Drawing.Point(15, 50);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(84, 17);
            this.labelControl1.TabIndex = 176;
            this.labelControl1.Text = "Branch Name";
            // 
            // txtBranchName
            // 
            this.txtBranchName.EditValue = "";
            this.txtBranchName.Location = new System.Drawing.Point(119, 46);
            this.txtBranchName.Name = "txtBranchName";
            this.txtBranchName.Properties.Appearance.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBranchName.Properties.Appearance.Options.UseFont = true;
            this.txtBranchName.Properties.AppearanceFocused.BackColor = System.Drawing.Color.Lavender;
            this.txtBranchName.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtBranchName.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.txtBranchName.Properties.Mask.EditMask = "n2";
            this.txtBranchName.Size = new System.Drawing.Size(205, 24);
            this.txtBranchName.TabIndex = 173;
            this.txtBranchName.ToolTip = "Enter Cheque Number";
            // 
            // labelControl14
            // 
            this.labelControl14.Appearance.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl14.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelControl14.Location = new System.Drawing.Point(15, 19);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(71, 17);
            this.labelControl14.TabIndex = 175;
            this.labelControl14.Text = "Bank Name";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Lucida Sans Unicode", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(76, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "M";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "ranch      aster";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(11, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "B";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelControl14);
            this.groupBox2.Controls.Add(this.cmbBankName);
            this.groupBox2.Controls.Add(this.txtAddress);
            this.groupBox2.Controls.Add(this.txtBranchName);
            this.groupBox2.Controls.Add(this.labelControl2);
            this.groupBox2.Controls.Add(this.labelControl1);
            this.groupBox2.Location = new System.Drawing.Point(16, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(357, 142);
            this.groupBox2.TabIndex = 181;
            this.groupBox2.TabStop = false;
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.rectangleShape1.FillColor = System.Drawing.Color.Blue;
            this.rectangleShape1.FillGradientColor = System.Drawing.Color.Transparent;
            this.rectangleShape1.FillGradientStyle = Microsoft.VisualBasic.PowerPacks.FillGradientStyle.Horizontal;
            this.rectangleShape1.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.rectangleShape1.Location = new System.Drawing.Point(17, 33);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(121, 2);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(385, 46);
            this.shapeContainer1.TabIndex = 8;
            this.shapeContainer1.TabStop = false;
            // 
            // frmBankBranchMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(385, 258);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmBankBranchMaster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Branch Master";
            this.pnlMain.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.xtraScrollableControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbBankName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBranchName.Properties)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.MemoEdit txtAddress;
        private DevExpress.XtraEditors.LookUpEdit cmbBankName;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtBranchName;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
    }
}
