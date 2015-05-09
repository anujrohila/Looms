using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LoomsMana.Forms.Master
{
    public partial class frmFiscalYearView : LoomsMana.Forms.Master.FrmGrid
    {
        public frmFiscalYearView()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmFiscalYearMaster frm = new frmFiscalYearMaster();
            frm.ShowDialog();
        }
    }
}
