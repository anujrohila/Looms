using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LoomsManagement.Windows.Forms
{
    public partial class frmAddSalesReturnItem : LoomsManagement.Windows.FromButtonRight
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
