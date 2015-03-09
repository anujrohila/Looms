using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using LoomsManagement.Windows.Forms.Master;

namespace LoomsManagement.Windows.Forms.Master
{
    public partial class frmCompanyView : DevExpress.XtraEditors.XtraForm
    {
        public frmCompanyView()
        {
            InitializeComponent();
        }

        private void btnAddRecord_Click(object sender, EventArgs e)
        {
            frmCompanyMaster objform = new frmCompanyMaster();
            objform.ShowDialog();
            objform.FormClosed += objform_FormClosed;
        }

        void objform_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        public void RefreshGridData()
        {

        }
    }
}