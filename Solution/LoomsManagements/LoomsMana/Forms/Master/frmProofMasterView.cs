﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoomsMana.Forms.Master
{
    public partial class frmProofMasterView : LoomsMana.Forms.Master.FrmGrid
    {
        public frmProofMasterView()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmCompanyMst frm = new FrmCompanyMst();
            frm.ShowDialog();
        }
    }
}
