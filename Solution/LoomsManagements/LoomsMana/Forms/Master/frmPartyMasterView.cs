using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LoomsMana.Forms.Master
{
    public partial class frmPartyMasterView : LoomsMana.Forms.Master.FrmGrid
    {
        public frmPartyMasterView()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmPartyMaster frm = new frmPartyMaster();
            frm.ShowDialog();
        }
    }
}
