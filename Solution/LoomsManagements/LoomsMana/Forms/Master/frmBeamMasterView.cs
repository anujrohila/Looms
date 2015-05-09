using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LoomsMana.Forms.Master
{
    public partial class frmBeamMasterView : LoomsMana.Forms.Master.FrmGrid
    {
        public frmBeamMasterView()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmBeamMaster frm = new frmBeamMaster();
            frm.ShowDialog();
        }
    }
}
