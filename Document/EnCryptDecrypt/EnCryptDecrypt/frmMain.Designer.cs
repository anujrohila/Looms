namespace EnCryptDecrypt
{
    partial class frmMain
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
            this.btnRequestForKey = new System.Windows.Forms.Button();
            this.btnRequestSerialKey = new System.Windows.Forms.Button();
            this.txtHardDiskID = new System.Windows.Forms.TextBox();
            this.txtRequestedKey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSerialKey = new System.Windows.Forms.TextBox();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.btnActivate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRequestForKey
            // 
            this.btnRequestForKey.Location = new System.Drawing.Point(94, 48);
            this.btnRequestForKey.Name = "btnRequestForKey";
            this.btnRequestForKey.Size = new System.Drawing.Size(120, 23);
            this.btnRequestForKey.TabIndex = 0;
            this.btnRequestForKey.Text = "Request for Key";
            this.btnRequestForKey.UseVisualStyleBackColor = true;
            this.btnRequestForKey.Click += new System.EventHandler(this.btnRequestForKey_Click);
            // 
            // btnRequestSerialKey
            // 
            this.btnRequestSerialKey.Location = new System.Drawing.Point(94, 184);
            this.btnRequestSerialKey.Name = "btnRequestSerialKey";
            this.btnRequestSerialKey.Size = new System.Drawing.Size(109, 23);
            this.btnRequestSerialKey.TabIndex = 1;
            this.btnRequestSerialKey.Text = "Generate Serial Key";
            this.btnRequestSerialKey.UseVisualStyleBackColor = true;
            this.btnRequestSerialKey.Click += new System.EventHandler(this.btnRequestSerialKey_Click);
            // 
            // txtHardDiskID
            // 
            this.txtHardDiskID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHardDiskID.Location = new System.Drawing.Point(94, 21);
            this.txtHardDiskID.Name = "txtHardDiskID";
            this.txtHardDiskID.Size = new System.Drawing.Size(566, 20);
            this.txtHardDiskID.TabIndex = 2;
            // 
            // txtRequestedKey
            // 
            this.txtRequestedKey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRequestedKey.Location = new System.Drawing.Point(92, 86);
            this.txtRequestedKey.Name = "txtRequestedKey";
            this.txtRequestedKey.Size = new System.Drawing.Size(566, 20);
            this.txtRequestedKey.TabIndex = 3;
            this.txtRequestedKey.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Hard Disk ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Request Key";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Serial Key";
            // 
            // txtSerialKey
            // 
            this.txtSerialKey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSerialKey.Location = new System.Drawing.Point(94, 230);
            this.txtSerialKey.Name = "txtSerialKey";
            this.txtSerialKey.Size = new System.Drawing.Size(566, 20);
            this.txtSerialKey.TabIndex = 7;
            this.txtSerialKey.TabStop = false;
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.CustomFormat = "dd-MM-yyyy";
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartDate.Location = new System.Drawing.Point(93, 158);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(108, 20);
            this.dtpStartDate.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Start Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(230, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "End Date";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.CustomFormat = "dd-MM-yyyy";
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndDate.Location = new System.Drawing.Point(301, 157);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(108, 20);
            this.dtpEndDate.TabIndex = 11;
            // 
            // btnActivate
            // 
            this.btnActivate.Location = new System.Drawing.Point(94, 291);
            this.btnActivate.Name = "btnActivate";
            this.btnActivate.Size = new System.Drawing.Size(109, 23);
            this.btnActivate.TabIndex = 12;
            this.btnActivate.Text = "Activate";
            this.btnActivate.UseVisualStyleBackColor = true;
            this.btnActivate.Click += new System.EventHandler(this.btnActivate_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 344);
            this.Controls.Add(this.btnActivate);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.txtSerialKey);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRequestedKey);
            this.Controls.Add(this.txtHardDiskID);
            this.Controls.Add(this.btnRequestSerialKey);
            this.Controls.Add(this.btnRequestForKey);
            this.Name = "frmMain";
            this.Text = "Main form";
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRequestForKey;
        private System.Windows.Forms.Button btnRequestSerialKey;
        private System.Windows.Forms.TextBox txtHardDiskID;
        private System.Windows.Forms.TextBox txtRequestedKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSerialKey;
        private System.Windows.Forms.ErrorProvider error;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnActivate;
    }
}

