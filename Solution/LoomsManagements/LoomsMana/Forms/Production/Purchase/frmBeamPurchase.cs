using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoomsMana.Forms.Production.Purchase
{
    public partial class frmBeamPurchase : LoomsMana.Forms.Master.FrmSimple
    {
        public frmBeamPurchase()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmBeamPurchaseItem form = new frmBeamPurchaseItem();
            form.Show();
        }
    }
}
