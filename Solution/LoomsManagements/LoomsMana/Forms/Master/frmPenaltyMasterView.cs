using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LoomsMana.Forms.Master
{
    public partial class frmPenaltyMasterView : LoomsMana.Forms.Master.FrmGrid
    {
        public frmPenaltyMasterView()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmPenaltyMaster FRM = new frmPenaltyMaster();
            FRM.ShowDialog();
        }
    }
}
