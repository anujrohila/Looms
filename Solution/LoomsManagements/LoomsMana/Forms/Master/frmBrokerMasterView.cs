using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LoomsMana.Forms.Master
{
    public partial class frmBrokerMasterView : LoomsMana.Forms.Master.FrmGrid
    {
        public frmBrokerMasterView()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmBrokerMaster frm = new frmBrokerMaster();
            frm.ShowDialog();
        }
    }
}
