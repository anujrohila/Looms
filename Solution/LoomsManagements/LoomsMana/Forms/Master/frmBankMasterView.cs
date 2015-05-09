using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LoomsMana.Forms.Master
{
    public partial class frmBankMasterView : LoomsMana.Forms.Master.FrmGrid
    {
        public frmBankMasterView()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmBankMaster frm = new frmBankMaster();
            frm.ShowDialog();
        }
    }
}
