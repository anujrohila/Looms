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
    public partial class frmEmployeeMasterView : LoomsMana.Forms.Master.FrmGrid
    {
        public frmEmployeeMasterView()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmEmployeeMaster frm = new frmEmployeeMaster();
            frm.ShowDialog();
        }
    }
}
