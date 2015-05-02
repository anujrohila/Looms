using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LoomsManagement.Windows.Forms.Returns
{
    public partial class frmSalesReturn : LoomsManagement.Windows.FormDemo1
    {
        public frmSalesReturn()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddSalesReturnItem objSalesItem = new frmAddSalesReturnItem();
            objSalesItem.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
