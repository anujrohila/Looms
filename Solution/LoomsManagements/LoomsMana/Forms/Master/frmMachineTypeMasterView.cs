﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LoomsMana.Forms.Master
{
    public partial class frmMachineTypeMasterView : LoomsMana.Forms.Master.FrmGrid
    {
        public frmMachineTypeMasterView()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmMachineTypeMaster frm = new frmMachineTypeMaster();
            frm.ShowDialog();
        }
    }
}
