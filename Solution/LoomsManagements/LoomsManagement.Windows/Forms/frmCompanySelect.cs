using LoomsManagement.Windows.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoomsManagement.Windows.Forms
{
    public partial class frmCompanySelect : Form
    {
        public frmCompanySelect()
        {
            InitializeComponent();
            this.Paint += frmCompanySelect_Paint;
        }

        void frmCompanySelect_Paint(object sender, PaintEventArgs e)
        {
            cmbCompanyCode.Properties.DataSource = UserContext.UserContexttblCompanyDTO;
            cmbCompanyCode.Properties.DisplayMember = "CompanyName";
            cmbCompanyCode.Properties.ValueMember = "CompanyID";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!Validation())
                return;
            UserContext.SelectedCompanyCode = Convert.ToInt32(cmbCompanyCode.EditValue);
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (UserContext.SelectedCompanyCode != 0)
            {
                this.Close();
            }
        }

        private Boolean Validation()
        {
            ErrorHandlor.SetErrorCount();
            ErrorHandlor.SetLookUPErrorWithCount(error_CompanyCode, cmbCompanyCode, "Select Company Code");

            if (ErrorHandlor.count == 0)
                return true;
            else
                return false;
        }
    }
}
