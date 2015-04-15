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
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRequestForKey
            // 
            this.btnRequestForKey.Location = new System.Drawing.Point(125, 59);
            this.btnRequestForKey.Margin = new System.Windows.Forms.Padding(4);
            this.btnRequestForKey.Name = "btnRequestForKey";
            this.btnRequestForKey.Size = new System.Drawing.Size(120, 28);
            this.btnRequestForKey.TabIndex = 0;
            this.btnRequestForKey.Text = "Request for Key";
            this.btnRequestForKey.UseVisualStyleBackColor = true;
            this.btnRequestForKey.Click += new System.EventHandler(this.btnRequestForKey_Click);
            // 
            // btnRequestSerialKey
            // 
            this.btnRequestSerialKey.Location = new System.Drawing.Point(123, 136);
            this.btnRequestSerialKey.Margin = new System.Windows.Forms.Padding(4);
            this.btnRequestSerialKey.Name = "btnRequestSerialKey";
            this.btnRequestSerialKey.Size = new System.Drawing.Size(145, 28);
            this.btnRequestSerialKey.TabIndex = 1;
            this.btnRequestSerialKey.Text = "Generate Serial Key";
            this.btnRequestSerialKey.UseVisualStyleBackColor = true;
            this.btnRequestSerialKey.Click += new System.EventHandler(this.btnRequestSerialKey_Click);
            // 
            // txtHardDiskID
            // 
            this.txtHardDiskID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHardDiskID.Location = new System.Drawing.Point(125, 26);
            this.txtHardDiskID.Margin = new System.Windows.Forms.Padding(4);
            this.txtHardDiskID.Name = "txtHardDiskID";
            this.txtHardDiskID.ReadOnly = true;
            this.txtHardDiskID.Size = new System.Drawing.Size(540, 22);
            this.txtHardDiskID.TabIndex = 2;
            // 
            // txtRequestedKey
            // 
            this.txtRequestedKey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRequestedKey.Location = new System.Drawing.Point(123, 106);
            this.txtRequestedKey.Margin = new System.Windows.Forms.Padding(4);
            this.txtRequestedKey.Name = "txtRequestedKey";
            this.txtRequestedKey.ReadOnly = true;
            this.txtRequestedKey.Size = new System.Drawing.Size(540, 22);
            this.txtRequestedKey.TabIndex = 3;
            this.txtRequestedKey.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Hard Disk ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 109);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Request Key";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 182);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Serial Key";
            // 
            // txtSerialKey
            // 
            this.txtSerialKey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSerialKey.Location = new System.Drawing.Point(125, 179);
            this.txtSerialKey.Margin = new System.Windows.Forms.Padding(4);
            this.txtSerialKey.Name = "txtSerialKey";
            this.txtSerialKey.ReadOnly = true;
            this.txtSerialKey.Size = new System.Drawing.Size(540, 22);
            this.txtSerialKey.TabIndex = 7;
            this.txtSerialKey.TabStop = false;
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 231);
            this.Controls.Add(this.txtSerialKey);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRequestedKey);
            this.Controls.Add(this.txtHardDiskID);
            this.Controls.Add(this.btnRequestSerialKey);
            this.Controls.Add(this.btnRequestForKey);
            this.Margin = new System.Windows.Forms.Padding(4);
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
    }
}

