using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LoomsManagement.Windows.Forms.Returns
{
    public partial class frmYarnPurchaseReturn : LoomsManagement.Windows.FormDemo1
    {
        public frmYarnPurchaseReturn()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddPurchaseReturnItem objPurchaseItem = new frmAddPurchaseReturnItem();
            objPurchaseItem.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

      
    }
}
