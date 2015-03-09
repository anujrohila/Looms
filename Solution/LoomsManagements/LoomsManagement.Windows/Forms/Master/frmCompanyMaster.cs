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
using DaryInventory.Classes;

namespace LoomsManagement.Windows.Forms.Master
{
    public partial class frmCompanyMaster : DevExpress.XtraEditors.XtraForm
    {
        public frmCompanyMaster()
        {
            InitializeComponent();
        }

        public void SetFlag()
        {

        }

        #region Button Event

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion


        #region Vadidation

        public Boolean Validation()
        {
           
            ErrorHandlor.SetErrorCount();
            ErrorHandlor.SetTextboxErrorWithCount(error_companyName, txt_CompanyName, "Enter Company Name");
            ErrorHandlor.SetTextboxErrorWithCount(error_companyCode, txt_CompanyCode, "Enter Company Code");
            ErrorHandlor.SetTextboxErrorWithCount(error_Ownername, txt_OwnerName, "Enter Owner Name");
            ErrorHandlor.SetTextboxErrorWithCount(error_investmentamount, txt_InvestmentAmount, "Enter Company Name");
            ErrorHandlor.SetTextboxErrorWithCount(error_contactpersoanname, txt_ContactPerrsonName, "Enter Company Name");

            ErrorHandlor.SetTextboxErrorWithCount(error_panno, txt_ContactPerrsonName, "Enter Company Name");
            ErrorHandlor.SetTextboxErrorWithCount(error_cst, txt_ContactPerrsonName, "Enter Company Name");
            
            ErrorHandlor.SetTextboxErrorWithCount(error_ecc, txt_ContactPerrsonName, "Enter Company Name");
            ErrorHandlor.SetTextboxErrorWithCount(error_sms, txt_ContactPerrsonName, "Enter Company Name");


           // ErrorHandlor.SetTextboxErrorWithCount(error_customer, txt_customername, "Enter CustomerName");

            if (ErrorHandlor.count == 0)
                return true;
            else
                return false;
          
        }
        
        #endregion

        #region KeyEvent

        private void EnterEvent(object sender, EventArgs e)
        {
            GlobalClass.EnterEvents(sender, e);
        }

        private void LeaveEvent(object sender, EventArgs e)
        {
            GlobalClass.LeaveEvents(sender, e);
        }

        private void txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }


        #endregion

       
    }
}