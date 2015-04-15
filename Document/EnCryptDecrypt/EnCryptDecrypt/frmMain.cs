using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Management;
using System.Text;
using System.Windows.Forms;

namespace EnCryptDecrypt
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();

            List<HardDiskInfo> hdCollection = new List<HardDiskInfo>();
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive");
            foreach (ManagementObject wmi_HD in searcher.Get())
            {
                HardDiskInfo hd = new HardDiskInfo();
                hd.Model = wmi_HD["Model"].ToString();
                hd.Type = wmi_HD["InterfaceType"].ToString();
                if (wmi_HD["SerialNumber"] == null)
                    hd.SerialNo = "None";
                else
                    hd.SerialNo = wmi_HD["SerialNumber"].ToString().Trim();
                hdCollection.Add(hd);
            }
            txtHardDiskID.Text = hdCollection[0].SerialNo;
        }

        private void btnRequestForKey_Click(object sender, EventArgs e)
        {
            if (txtHardDiskID.Text == "")
            {
                error.SetError(txtHardDiskID, "Enter the text you want to encrypt");
            }
            else
            {
                string hardDiskId = txtHardDiskID.Text.Trim();
                string requestedKey = CryptorEngine.Encrypt(hardDiskId, true);
                requestedKey = CryptorEngine.Encrypt(requestedKey, true);
                requestedKey = CryptorEngine.Encrypt(requestedKey, true);
                txtRequestedKey.Text = requestedKey;
            }
        }

        private void btnRequestSerialKey_Click(object sender, EventArgs e)
        {
            string requestedHashKey = txtRequestedKey.Text.Trim();
            string decryptedText = CryptorEngine.Decrypt(requestedHashKey, true);
            decryptedText = CryptorEngine.Decrypt(decryptedText, true);
            decryptedText = CryptorEngine.Decrypt(decryptedText, true);


            
            txtSerialKey.Text = decryptedText;
        }
    }
}