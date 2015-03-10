using LoomsManagement.BAL;
using LoomsManagement.Domain.DTO;
using LoomsManagement.Windows.Classes;
using System;
using System.Windows.Forms;

namespace LoomsManagement.Windows.Forms.Master
{
    public partial class frmCompanyMaster : LoomsManagement.Windows.FormDemo1
    {

        #region [Variable]

        public Boolean IsEdit = false;
        public int id = 0;

        #endregion

        #region [Constructor]

        public frmCompanyMaster()
        {
            InitializeComponent();
            this.Load += frmCompanyMaster_Load;
        }

        #endregion

        #region [Page Event]

        void frmCompanyMaster_Load(object sender, EventArgs e)
        {
            SetFlag();
            txtCompanyName.Focus();
        }
        
        #endregion

        #region  [Control Event]

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!Validation())
                return;

            CommanClass.ShowProcessBar();
            
            var tblCompanyDTO = new tblCompanyDTO();
            tblCompanyDTO.CompanyName = txtCompanyName.Text;
            tblCompanyDTO.ComapnyCode = txtCompanyCode.Text;
            tblCompanyDTO.OwnerName = txtOwnerName.Text;
            tblCompanyDTO.StartDate = Convert.ToDateTime(dpOpeningDate.EditValue);
            tblCompanyDTO.InvestmentAmount = Convert.ToDouble(txtInvestmentAmount.Text);
            tblCompanyDTO.ContactPersonName = txtContactPerrsonName.Text;
            tblCompanyDTO.Address = txtaddress.Text;
            tblCompanyDTO.PANNo = txtPANNo.Text;
            tblCompanyDTO.CSTNo = txtCST.Text;
            tblCompanyDTO.ECCNo = txtECCNo.Text;
            tblCompanyDTO.SMSNO = txtSMSNo.Text;
            tblCompanyDTO.IsActive = true;
            tblCompanyDTO.IsDelete = false;

            if (IsEdit)
            {
                tblCompanyDTO.CompanyID = id;
                tblCompanyDTO.UpdatedBy = CommanClass.UserId;
                tblCompanyDTO.UpdatedDateTime = DateTime.Now;
            }
            else
            {
                tblCompanyDTO.CreatedBy = CommanClass.UserId;
                tblCompanyDTO.CreatedDateTime = DateTime.Now;

            }

            int ReturnValue = CompnayBussinesLogic.SaveCompanyData(tblCompanyDTO);
            
            CommanClass.HideProcessBar();
            
            if (ReturnValue == 1)
            {
                errorcompanyName.SetError(txtCompanyName, "Company Name Already Exist");
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
            var result = MessageBox.Show("Are you Sure Delete This Record ?", "Delete Confirmation", MessageBoxButtons.YesNo);
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

        #region KeyEvent

        private void EnterEvent(object sender, EventArgs e)
        {
            CommanClass.EnterEvents(sender, e);
        }

        private void LeaveEvent(object sender, EventArgs e)
        {
            CommanClass.LeaveEvents(sender, e);
        }

        private void txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }


        #endregion

        #endregion

        #region [Private Method]

        private void SetFlag()
        {
            if (IsEdit)
            {
                var companyData =  CompnayBussinesLogic.GetCompanyDetails(id);  
                txtCompanyName.Text = companyData.CompanyName;
                txtCompanyCode.Text = companyData.ComapnyCode;
                txtOwnerName.Text = companyData.OwnerName;
                txtInvestmentAmount.Text = Convert.ToString(companyData.InvestmentAmount);
                txtContactPerrsonName.Text = companyData.ContactPersonName;
                txtPANNo.Text = companyData.PANNo;
                txtCST.Text = companyData.CSTNo;
                txtECCNo.Text = companyData.ECCNo;
                txtSMSNo.Text = companyData.SMSNO;
                dpOpeningDate.EditValue = companyData.StartDate;
                txtaddress.Text = companyData.Address;
                btndelete.Enabled = true;
                btnReport.Enabled = true;
            }
            else
            {
                btndelete.Enabled = false;
                btnReport.Enabled = false;
            }
        }

        private Boolean Validation()
        {

            ErrorHandlor.SetErrorCount();
            ErrorHandlor.SetTextboxErrorWithCount(errorcompanyName, txtCompanyName, "Enter Company Name");
            ErrorHandlor.SetTextboxErrorWithCount(errorcompanyCode, txtCompanyCode, "Enter Company Code");
            ErrorHandlor.SetTextboxErrorWithCount(errorOwnername, txtOwnerName, "Enter Owner Name");
            ErrorHandlor.SetTextboxErrorWithCount(errorinvestmentamount, txtInvestmentAmount, "Enter investment Amount");
            ErrorHandlor.SetTextboxErrorWithCount(error_contactpersoanname, txtContactPerrsonName, "Enter Contact PersonName");
            ErrorHandlor.SetTextboxErrorWithCount(error_panno, txtPANNo, "Enter Pan No");
            ErrorHandlor.SetTextboxErrorWithCount(errorcst, txtCST, "Enter CST No");
            ErrorHandlor.SetTextboxErrorWithCount(errorecc, txtECCNo, "Enter ECC No");
            ErrorHandlor.SetTextboxErrorWithCount(errorsms, txtSMSNo, "Enter Sms No");
            ErrorHandlor.SetDateErrorWithCount(erroropeningdate, dpOpeningDate, "Select Date");
            ErrorHandlor.SetMemoEditErrorWithCount(error_address, txtaddress, "Enter Address");

            if (ErrorHandlor.count == 0)
                return true;
            else
                return false;
        }

        private void ClearData()
        {
            //Clear data
            txtCompanyName.Text = "";
            txtCompanyCode.Text = "";
            txtOwnerName.Text = "";
            txtInvestmentAmount.Text = "";
            txtContactPerrsonName.Text = "";
            txtPANNo.Text = "";
            txtCST.Text = "";
            txtECCNo.Text = "";
            txtSMSNo.Text = "";
            dpOpeningDate.EditValue = "";
            txtaddress.Text = "";

            //Reset BackGround Color
            txtCompanyName.BackColor = CommanClass.m_tbcolorleave;
            txtCompanyCode.BackColor = CommanClass.m_tbcolorleave;
            txtOwnerName.BackColor = CommanClass.m_tbcolorleave;
            txtInvestmentAmount.BackColor = CommanClass.m_tbcolorleave;
            txtContactPerrsonName.BackColor = CommanClass.m_tbcolorleave;
            txtPANNo.BackColor = CommanClass.m_tbcolorleave;
            txtCST.BackColor = CommanClass.m_tbcolorleave;
            txtECCNo.BackColor = CommanClass.m_tbcolorleave;
            txtSMSNo.BackColor = CommanClass.m_tbcolorleave;
            dpOpeningDate.BackColor = CommanClass.m_tbcolorleave;
            txtaddress.BackColor = CommanClass.m_tbcolorleave;

            //Reset error 
            errorcompanyName.SetError(txtCompanyName, "");
            errorcompanyCode.SetError(txtCompanyCode, "");
            errorOwnername.SetError(txtOwnerName, "");
            errorinvestmentamount.SetError(txtInvestmentAmount, "");
            error_contactpersoanname.SetError(txtContactPerrsonName, "");
            error_panno.SetError(txtPANNo, "");
            errorcst.SetError(txtCST, "");
            errorecc.SetError(txtECCNo, "");
            errorsms.SetError(txtSMSNo, "");
            erroropeningdate.SetError(dpOpeningDate, "");
            error_address.SetError(txtaddress, "");

            txtCompanyName.Focus();

        }

        #endregion

    }
}
