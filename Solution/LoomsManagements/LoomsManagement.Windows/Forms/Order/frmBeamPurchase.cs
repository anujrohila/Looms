﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LoomsManagement.Windows.Forms.Order
{
    public partial class frmBeamPurchase : LoomsManagement.Windows.FormDemo1
    {
        public frmBeamPurchase()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmBeamPurchaseItem objBeamPurchase = new frmBeamPurchaseItem();
            objBeamPurchase.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
    }
}
