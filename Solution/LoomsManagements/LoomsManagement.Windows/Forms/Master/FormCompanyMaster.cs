using DaryInventory.Classes;
using LoomsManagement.BAL;
using LoomsManagement.Domain.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LoomsManagement.Windows.Forms.Master
{
    public partial class FormCompanyMaster : LoomsManagement.Windows.FormDemo1
    {
        public Boolean IsEdit = false;
        public int id = 0;


        public FormCompanyMaster()
        {
            InitializeComponent();
            this.Load += FormCompanyMaster_Load;
        }

        void FormCompanyMaster_Load(object sender, EventArgs e)
        {
            SetFlag();
            txt_CompanyName.Focus();
        }

        #region Button Event

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!Validation())
                return;

            tblCompanyDTO tblCompanyDTO = new tblCompanyDTO();
            tblCompanyDTO.CompanyName = txt_CompanyName.Text;
            tblCompanyDTO.ComapnyCode = txt_CompanyCode.Text;
            tblCompanyDTO.OwnerName = txt_OwnerName.Text;
            tblCompanyDTO.StartDate =Convert.ToDateTime(dp_Date.EditValue);
            tblCompanyDTO.InvestmentAmount =Convert.ToDouble(txt_InvestmentAmount.Text);
            tblCompanyDTO.ContactPersonName = txt_ContactPerrsonName.Text;
            tblCompanyDTO.Address = txt_address.Text;
            tblCompanyDTO.PANNo = txt_PANNo.Text;
            tblCompanyDTO.CSTNo = txt_CST.Text;
            tblCompanyDTO.ECCNo = txt_ECCNo.Text;
            tblCompanyDTO.SMSNO = txt_SMSNo.Text;
            tblCompanyDTO.IsActive = true;
            tblCompanyDTO.IsDelete = false;
            
            if (IsEdit)
            {
                tblCompanyDTO.CompanyID = id;
                 tblCompanyDTO.UpdatedBy = GlobalClass.userid;
                tblCompanyDTO.UpdatedDateTime = DateTime.Now;
            }
            else
            {
                tblCompanyDTO.CreatedBy = GlobalClass.userid;
                tblCompanyDTO.CreatedDateTime = DateTime.Now;
             
            }

            int ReturnValue = CompnayBussinesLogic.SaveCompanyData(tblCompanyDTO);

            if (ReturnValue == 1)
            {
               error_companyName.SetError(txt_CompanyName, "Company Name Already Exist");
            }
            else if (ReturnValue == 2)
            {
               // error_companyName.SetError(txt_CompanyName, "Company Name Already Exist");
            }
            else
            {
                MessageBox.Show("Successfully Save Data");
                ClearData();
                if (IsEdit)
                {
                    this.Close();
                }
            }
           

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you Sure Delete This Record ?", "Delete Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (CompnayBussinesLogic.DeleteCompanyData(id) != 0)
                {
                    MessageBox.Show("Tramsaction fail");
                }
                else
                {
                    this.Close();
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ClearData();
            this.Close();
        }

        #endregion


        #region UserDefine Function


        public void SetFlag()
        {
            if (IsEdit)
            {
                tblCompanyDTO companyData =  CompnayBussinesLogic.GetCompanyDetails(id);  
                txt_CompanyName.Text = companyData.CompanyName;
                txt_CompanyCode.Text = companyData.ComapnyCode;
                txt_OwnerName.Text = companyData.OwnerName;
                txt_InvestmentAmount.Text = Convert.ToString(companyData.InvestmentAmount);
                txt_ContactPerrsonName.Text = companyData.ContactPersonName;
                txt_PANNo.Text = companyData.PANNo;
                txt_CST.Text = companyData.CSTNo;
                txt_ECCNo.Text = companyData.ECCNo;
                txt_SMSNo.Text = companyData.SMSNO;
                dp_Date.EditValue = companyData.StartDate;
                txt_address.Text = companyData.Address;
                btndelete.Enabled = true;
                btnReport.Enabled = true;
            }
            else
            {
                btndelete.Enabled = false;
                btnReport.Enabled = false;
            }
        }


        public Boolean Validation()
        {

            ErrorHandlor.SetErrorCount();
            ErrorHandlor.SetTextboxErrorWithCount(error_companyName, txt_CompanyName, "Enter Company Name");
            ErrorHandlor.SetTextboxErrorWithCount(error_companyCode, txt_CompanyCode, "Enter Company Code");
            ErrorHandlor.SetTextboxErrorWithCount(error_Ownername, txt_OwnerName, "Enter Owner Name");
            ErrorHandlor.SetTextboxErrorWithCount(error_investmentamount, txt_InvestmentAmount, "Enter investment Amount");
            ErrorHandlor.SetTextboxErrorWithCount(error_contactpersoanname, txt_ContactPerrsonName, "Enter Contact PersonName");
            ErrorHandlor.SetTextboxErrorWithCount(error_panno, txt_PANNo, "Enter Pan No");
            ErrorHandlor.SetTextboxErrorWithCount(error_cst, txt_CST, "Enter CST No");
            ErrorHandlor.SetTextboxErrorWithCount(error_ecc, txt_ECCNo, "Enter ECC No");
            ErrorHandlor.SetTextboxErrorWithCount(error_sms, txt_SMSNo, "Enter Sms No");
            ErrorHandlor.SetDateErrorWithCount(error_openingdate, dp_Date, "Select Date");
            ErrorHandlor.SetMemoEditErrorWithCount(error_address, txt_address, "Enter Address");

            if (ErrorHandlor.count == 0)
                return true;
            else
                return false;
        }

        public void ClearData()
        {
            //Clear data
            txt_CompanyName.Text = "";
            txt_CompanyCode.Text = "";
            txt_OwnerName.Text = "";
            txt_InvestmentAmount.Text = "";
            txt_ContactPerrsonName.Text = "";
            txt_PANNo.Text = "";
            txt_CST.Text = "";
            txt_ECCNo.Text = "";
            txt_SMSNo.Text = "";
            dp_Date.EditValue = "";
            txt_address.Text = "";

            //Reset BackGround Color
            txt_CompanyName.BackColor = GlobalClass.m_tbcolorleave;
            txt_CompanyCode.BackColor = GlobalClass.m_tbcolorleave;
            txt_OwnerName.BackColor = GlobalClass.m_tbcolorleave;
            txt_InvestmentAmount.BackColor = GlobalClass.m_tbcolorleave;
            txt_ContactPerrsonName.BackColor = GlobalClass.m_tbcolorleave;
            txt_PANNo.BackColor = GlobalClass.m_tbcolorleave;
            txt_CST.BackColor = GlobalClass.m_tbcolorleave;
            txt_ECCNo.BackColor = GlobalClass.m_tbcolorleave;
            txt_SMSNo.BackColor = GlobalClass.m_tbcolorleave;
            dp_Date.BackColor = GlobalClass.m_tbcolorleave;
            txt_address.BackColor = GlobalClass.m_tbcolorleave;

            //Reset error 
            error_companyName.SetError(txt_CompanyName, "");
            error_companyCode.SetError(txt_CompanyCode, "");
            error_Ownername.SetError(txt_OwnerName, "");
            error_investmentamount.SetError(txt_InvestmentAmount, "");
            error_contactpersoanname.SetError(txt_ContactPerrsonName, "");
            error_panno.SetError(txt_PANNo, "");
            error_cst.SetError(txt_CST, "");
            error_ecc.SetError(txt_ECCNo, "");
            error_sms.SetError(txt_SMSNo, "");
            error_openingdate.SetError(dp_Date, "");
            error_address.SetError(txt_address, "");

            txt_CompanyName.Focus();

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
