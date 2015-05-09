using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LoomsMana.Forms.Master
{
    public partial class frmEmployeeTypeMasterView : LoomsMana.Forms.Master.FrmGrid
    {
        public frmEmployeeTypeMasterView()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmEmployeeTypeMaster frm = new frmEmployeeTypeMaster();
            frm.ShowDialog();
        }
    }
}
