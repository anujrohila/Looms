using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LoomsManagement.Windows.Forms.Returns
{
    public partial class frmAddSalesReturnItem : LoomsManagement.Windows.FormDemo1
    {
        public frmAddSalesReturnItem()
        {
            InitializeComponent();
            btnReport.Visible = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
