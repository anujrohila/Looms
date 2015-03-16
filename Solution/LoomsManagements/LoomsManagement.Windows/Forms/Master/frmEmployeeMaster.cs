using LoomsManagement.BAL;
using LoomsManagement.Domain.DTO;
using LoomsManagement.Windows.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LoomsManagement.Windows.Forms.Master
{
    public partial class frmEmployeeMaster : LoomsManagement.Windows.FormDemo1
    {

        #region [Variable]

        public Boolean IsEdit = false;
        public int id = 0;
        public List<string> BankPayment;

        #endregion

        #region [Constructor]

        public frmEmployeeMaster()
        {
            InitializeComponent();
            this.Load += frmEmployeeMaster_Load;
        }


        #endregion

        #region [Page Event]

        void frmEmployeeMaster_Load(object sender, EventArgs e)
        {
           // MessageBox.Show("load");
            // SetFlag();
        }

        #endregion

        #region  [Control Event]

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!Validation())
                return;

            CommanClass.ShowProcessBar();

            var objEmployee = new tblEmployeeDTO();
            objEmployee.EmployeeTypeID = Convert.ToInt32(cmbEmployeeType.EditValue);
            objEmployee.EmployeeCode = txtEmployeeCode.Text.Trim();
            objEmployee.JobTitle = txtJobTitle.Text.Trim();
            objEmployee.FirstName = txtFirstName.Text.Trim();
            objEmployee.MiddleName = txtLastName.Text.Trim();
            objEmployee.LastName = txtLastName.Text.Trim();
            objEmployee.ResidentialAddress = txtResidentialAddress.Text.Trim();
            objEmployee.PermanentAddress = txtPermanentAddress.Text.Trim();
            objEmployee.MobileNo = txtMobileNo.Text.Trim();
            objEmployee.EmailID = txtEmail.Text.Trim();
            objEmployee.DOB = Convert.ToDateTime(dpDOB.EditValue);
            if (rbMale.Checked)
                objEmployee.Gender = "male";
            else
                objEmployee.Gender = "female";
            objEmployee.IDProfe = Convert.ToString(cmbProfeType.EditValue);
            objEmployee.IDProfeNo = txtProfeNo.Text.Trim();
            //objEmployee.Photo = ;
            objEmployee.JoinDate = Convert.ToDateTime(dpDOJ.EditValue);
            if (chkIsSponsorer.Checked)
                objEmployee.SponsorsID = Convert.ToInt32(cmdEmployeeName.EditValue);
            else
                objEmployee.SponsorsID = 0;

            if (rbMorning.Checked)
                objEmployee.Shift = "m";
            else
                objEmployee.Shift = "e";

            objEmployee.Salary = Convert.ToDouble(txtSalary.Text);
            objEmployee.PerDayWorkingHours = Convert.ToDouble(txtPerDayWorkingHours.Text);
            objEmployee.PerHourSalary = Convert.ToDouble(txtPerHourSalary.Text);
            objEmployee.PaymentType = rbCash.Checked ? true : false; // 1 for cash 0 for bank
            if (objEmployee.PaymentType.Value)
            {
                objEmployee.BankName = "";
                objEmployee.BranchName = "";
                objEmployee.AccountNo = "";
                objEmployee.RTGSNo = "";
                objEmployee.IFSCCode = "";
            }
            else
            {
                objEmployee.BankName = Convert.ToString(cmdBankName.EditValue);
                objEmployee.BranchName = "";
                objEmployee.AccountNo = txtAccountNo.Text;
                objEmployee.RTGSNo = txtRTGSNo.Text;
                objEmployee.IFSCCode = txtIFSCCode.Text;
            }
            objEmployee.OpeningBalance = Convert.ToDouble(txtOpeningBalance.Text);

            objEmployee.IsActive = true;
            objEmployee.IsDelete = true;
            if (IsEdit)
            {
                objEmployee.EmployeeID = id;
                objEmployee.UpdatedBy = CommanClass.UserId;
                objEmployee.UpdatedDate = DateTime.Now;
            }
            else
            {
                objEmployee.CreatedBY = CommanClass.UserId;
                objEmployee.CreatedDate = DateTime.Now;

            }

            int ReturnValue = EmployeeBusinessLogic.SaveEmployee(objEmployee);

            CommanClass.HideProcessBar();

            if (ReturnValue == 1)
            {
                // errorcompanyName.SetError(txtCompanyName, "Company Name Already Exist");
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
                if (EmployeeBusinessLogic.DeleteEmployeeData(id) != 0)
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

        private void chkAddress_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAddress.Checked)
            {
                txtPermanentAddress.Enabled = false;
                txtPermanentAddress.Text = txtResidentialAddress.Text;
            }
            else
            {
                txtPermanentAddress.Enabled = true;
                txtPermanentAddress.Text = "";
            }
        }

        private void chkIsSponsorer_CheckedChanged(object sender, EventArgs e)
        {
            if (chkIsSponsorer.Checked)
            {
                cmdEmployeeName.Enabled = true;
            }
            else
            {
                cmdEmployeeName.Enabled = false;
            }
        }

        private void Paymenttype_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCash.Checked)
            {
                cmdBankName.Enabled = false;
                txtAccountNo.Enabled = false;
                txtIFSCCode.Enabled = false;
                txtRTGSNo.Enabled = false;
            }
            else
            {
                cmdBankName.Enabled = true;
                txtAccountNo.Enabled = true;
                txtIFSCCode.Enabled = true;
                txtRTGSNo.Enabled = true;
            }
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

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (Form.ModifierKeys == Keys.None && keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            return base.ProcessDialogKey(keyData);
        }

        #endregion

        #endregion

        #region [Private Method]

        private void SetFlag()
        {
            chkAddress_CheckedChanged(null, null);
            chkIsSponsorer_CheckedChanged(null, null);
            Paymenttype_CheckedChanged(null, null);

            LoadCompanyDetails();
            LoadEmployeeDetails();
            LoadEmployeeTypeDetails();
            LoadProfeDetails();
            if (IsEdit)
            {
                var companyData = CompnayBussinesLogic.GetCompanyDetails(id);
                //txtCompanyName.Text = companyData.CompanyName;
                //txtCompanyCode.Text = companyData.ComapnyCode;
                //txtOwnerName.Text = companyData.OwnerName;
                //txtInvestmentAmount.Text = Convert.ToString(companyData.InvestmentAmount);
                //txtContactPerrsonName.Text = companyData.ContactPersonName;
                //txtPANNo.Text = companyData.PANNo;
                //txtCST.Text = companyData.CSTNo;
                //txtECCNo.Text = companyData.ECCNo;
                //txtSMSNo.Text = companyData.SMSNO;
                //dpOpeningDate.EditValue = companyData.StartDate;
                //txtaddress.Text = companyData.Address;
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
            //ErrorHandlor.SetTextboxErrorWithCount(errorcompanyName, txtCompanyName, "Enter Company Name");
            //ErrorHandlor.SetTextboxErrorWithCount(errorcompanyCode, txtCompanyCode, "Enter Company Code");
            //ErrorHandlor.SetTextboxErrorWithCount(errorOwnername, txtOwnerName, "Enter Owner Name");
            //ErrorHandlor.SetTextboxErrorWithCount(errorinvestmentamount, txtInvestmentAmount, "Enter investment Amount");
            //ErrorHandlor.SetTextboxErrorWithCount(error_contactpersoanname, txtContactPerrsonName, "Enter Contact PersonName");
            //ErrorHandlor.SetTextboxErrorWithCount(error_panno, txtPANNo, "Enter Pan No");
            //ErrorHandlor.SetTextboxErrorWithCount(errorcst, txtCST, "Enter CST No");
            //ErrorHandlor.SetTextboxErrorWithCount(errorecc, txtECCNo, "Enter ECC No");
            //ErrorHandlor.SetTextboxErrorWithCount(errorsms, txtSMSNo, "Enter Sms No");
            //ErrorHandlor.SetDateErrorWithCount(erroropeningdate, dpOpeningDate, "Select Date");
            //ErrorHandlor.SetMemoEditErrorWithCount(error_address, txtaddress, "Enter Address");

            if (ErrorHandlor.count == 0)
                return true;
            else
                return false;
        }

        private void ClearData()
        {
            //Clear data
            //txtCompanyName.Text = "";
            //txtCompanyCode.Text = "";
            //txtOwnerName.Text = "";
            //txtInvestmentAmount.Text = "";
            //txtContactPerrsonName.Text = "";
            //txtPANNo.Text = "";
            //txtCST.Text = "";
            //txtECCNo.Text = "";
            //txtSMSNo.Text = "";
            //dpOpeningDate.EditValue = "";
            //txtaddress.Text = "";

            ////Reset BackGround Color
            //txtCompanyName.BackColor = CommanClass.m_tbcolorleave;
            //txtCompanyCode.BackColor = CommanClass.m_tbcolorleave;
            //txtOwnerName.BackColor = CommanClass.m_tbcolorleave;
            //txtInvestmentAmount.BackColor = CommanClass.m_tbcolorleave;
            //txtContactPerrsonName.BackColor = CommanClass.m_tbcolorleave;
            //txtPANNo.BackColor = CommanClass.m_tbcolorleave;
            //txtCST.BackColor = CommanClass.m_tbcolorleave;
            //txtECCNo.BackColor = CommanClass.m_tbcolorleave;
            //txtSMSNo.BackColor = CommanClass.m_tbcolorleave;
            //dpOpeningDate.BackColor = CommanClass.m_tbcolorleave;
            //txtaddress.BackColor = CommanClass.m_tbcolorleave;

            ////Reset error 
            //errorcompanyName.SetError(txtCompanyName, "");
            //errorcompanyCode.SetError(txtCompanyCode, "");
            //errorOwnername.SetError(txtOwnerName, "");
            //errorinvestmentamount.SetError(txtInvestmentAmount, "");
            //error_contactpersoanname.SetError(txtContactPerrsonName, "");
            //error_panno.SetError(txtPANNo, "");
            //errorcst.SetError(txtCST, "");
            //errorecc.SetError(txtECCNo, "");
            //errorsms.SetError(txtSMSNo, "");
            //erroropeningdate.SetError(dpOpeningDate, "");
            //error_address.SetError(txtaddress, "");

            //txtCompanyName.Focus();

        }

        private void LoadCompanyDetails()
        {
            cmbCompanyCode.Properties.DataSource = CompnayBussinesLogic.GetAllCompanyDetails();
            cmbCompanyCode.Properties.ValueMember = "CompanyID";
            cmbCompanyCode.Properties.DisplayMember = "CompanyName";
        }

        private void LoadEmployeeDetails()
        {
            cmdEmployeeName.Properties.DataSource = EmployeeBusinessLogic.GetAllEmployeeDetails();
            cmdEmployeeName.Properties.ValueMember = "EmployeeID";
            cmdEmployeeName.Properties.DisplayMember = "EmployeeCode";
        }

        private void LoadEmployeeTypeDetails()
        {
            cmbEmployeeType.Properties.DataSource = UserContext.UserContexttblEmployeeTypeMSTDTO;
            cmbEmployeeType.Properties.ValueMember = "EmployeeTypeID";
            cmbEmployeeType.Properties.DisplayMember = "TypeName";
        }

        private void LoadProfeDetails()
        {
            cmbProfeType.Properties.DataSource = EmployeeBusinessLogic.GetAllProfeList();
            cmbProfeType.Properties.DisplayMember = "Name";
            cmbProfeType.Properties.ValueMember = "ProfeID";
        }

        #endregion

        private void frmEmployeeMaster_Shown(object sender, EventArgs e)
        {
          //  SetFlag();
           // MessageBox.Show("Shown");
        }

        private void frmEmployeeMaster_Activated(object sender, EventArgs e)
        {
            //SetFlag();
        }

        private void frmEmployeeMaster_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
