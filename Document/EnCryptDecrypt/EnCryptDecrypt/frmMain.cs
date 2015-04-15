using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Management;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace EnCryptDecrypt
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            txtHardDiskID.Text = GetHardDiskKey();
        }

        private string GetHardDiskKey()
        {
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
            return hdCollection[0].SerialNo;
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
            if (txtRequestedKey.Text == "")
            {
                MessageBox.Show("Please provide request key generated from PC");
            }
            else
            {
                try
                {
                    string requestedHashKey = txtRequestedKey.Text.Trim();
                    string decryptedText = CryptorEngine.Decrypt(requestedHashKey, true);
                    decryptedText = CryptorEngine.Decrypt(decryptedText, true);
                    decryptedText = CryptorEngine.Decrypt(decryptedText, true);

                    string value = string.Format("{0}-{1}-{2}", dtpStartDate.Value.ToString("ddMMyyyy"), decryptedText, dtpEndDate.Value.ToString("ddMMyyyy"));
                    string serialKey = CryptorEngine.Encrypt(value, true);
                    serialKey = CryptorEngine.Encrypt(serialKey, true);
                    serialKey = CryptorEngine.Encrypt(serialKey, true);

                    txtSerialKey.Text = serialKey;
                }
                catch 
                {
                    MessageBox.Show("Invalid request key");
                }
               
            }
        }

        private void btnActivate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSerialKey.Text == "")
                {
                    MessageBox.Show("Please provide serial key to activate your account.");
                }
                else
                {
                    string decSerialKey = CryptorEngine.Decrypt(txtSerialKey.Text, true);
                    decSerialKey = CryptorEngine.Decrypt(decSerialKey, true);
                    decSerialKey = CryptorEngine.Decrypt(decSerialKey, true);
                    string[] arraySerialKey = decSerialKey.Split('-');
                    if (string.Compare(GetHardDiskKey(), arraySerialKey[1], StringComparison.CurrentCulture) != 0)
                    {
                        MessageBox.Show("Invalid serial key");
                    }
                    else
                    {
                        string sDate = arraySerialKey[0].Substring(0, 2) + "-" + arraySerialKey[0].Substring(2, 2) + "-" + arraySerialKey[0].Substring(4, 4);
                        string eDate = arraySerialKey[2].Substring(0, 2) + "-" + arraySerialKey[2].Substring(2, 2) + "-" + arraySerialKey[2].Substring(4, 4);
                        MessageBox.Show(string.Format("Your account is activatd from {0} to {1}", sDate, eDate));

                    }

                }
            }
            catch
            {
                MessageBox.Show("Invalid serial key"); ;
            }
           
        }

    }
}