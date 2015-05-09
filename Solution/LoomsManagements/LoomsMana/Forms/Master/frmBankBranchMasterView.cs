using LoomsMana.Forms.Master;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LoomsMana.Forms
{
    public partial class frmBankBranchMasterView : LoomsMana.Forms.Master.FrmGrid
    {
        public frmBankBranchMasterView()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmBankBranchMaster frm = new frmBankBranchMaster();
            frm.ShowDialog();
        }
    }
}
