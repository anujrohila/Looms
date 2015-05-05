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
    public partial class frmEmployeeMaster : LoomsManagement.Windows.FromButtonRight
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
            this.Paint += frmEmployeeMaster_Paint;
        }


        #endregion

        #region [Page Event]

        private void frmEmployeeMaster_Paint(object sender, PaintEventArgs e)
        {
            SetFlag();
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
            objEmployee.MiddleName = txtMiddleName.Text.Trim();
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
            objEmployee.CompanyID = Convert.ToInt32(cmbCompanyCode.EditValue);
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
                objEmployee.BankName = txtBankName.Text;
                objEmployee.BranchName = "";
                objEmployee.AccountNo = txtAccountNo.Text;
                objEmployee.RTGSNo = txtRTGSNo.Text;
                objEmployee.IFSCCode = txtIFSCCode.Text;
            }
            objEmployee.OpeningBalance = Convert.ToDouble(txtOpeningBalance.Text);

            objEmployee.IsActive = true;
            objEmployee.IsDelete = false;
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
                MessageBox.Show("Data saved successfully.");
                ClearData();
                if (IsEdit)
                {
                    this.Close();
                }
            }


        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to delete this record ?", "Delete Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (EmployeeBusinessLogic.DeleteEmployeeData(id) != 0)
                {
                    MessageBox.Show("Transaction fail.");
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
                txtBankName.Enabled = false;
                txtAccountNo.Enabled = false;
                txtIFSCCode.Enabled = false;
                txtRTGSNo.Enabled = false;
            }
            else
            {
                txtBankName.Enabled = true;
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

        private void Page_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == CommanClass.SaveButton)
            {
                btnSave_Click(null, null);
            }
            else if (btnReport.Enabled == true && e.Control && e.KeyCode == CommanClass.PrintButton)
            {
            }
            else if (btndelete.Enabled == true && e.KeyCode == CommanClass.DeleteButton)
            {
                btndelete_Click(null, null);
            }
            else if (e.Control && e.KeyCode == CommanClass.CloseButton)
            {
                btnExit_Click(null, null);
            }
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
                var employeeData = EmployeeBusinessLogic.GetEmployeeDetails(id);
                txtFirstName.Text = employeeData.FirstName;
                txtMiddleName.Text = employeeData.MiddleName;
                txtLastName.Text = employeeData.LastName;
                if (rbMale.Checked)
                    employeeData.Gender = "male";
                else
                    employeeData.Gender = "femail";
                dpDOB.DateTime = Convert.ToDateTime(employeeData.DOB);
                txtMobileNo.Text = employeeData.MobileNo;
                txtResidentialAddress.Text = employeeData.ResidentialAddress;
                txtPermanentAddress.Text = employeeData.PermanentAddress;
                txtEmail.Text = employeeData.EmailID;
                cmbProfeType.EditValue = employeeData.IDProfe;
                txtProfeNo.Text = employeeData.IDProfeNo;
                cmbCompanyCode.EditValue = employeeData.CompanyID;
                cmbEmployeeType.EditValue = employeeData.EmployeeTypeID;
                txtEmployeeCode.Text = employeeData.EmployeeCode;
                txtJobTitle.Text = employeeData.JobTitle;
                dpDOJ.DateTime = Convert.ToDateTime(employeeData.JoinDate);

                if (rbMorning.Checked)
                    employeeData.Shift = "m";
                else
                    employeeData.Shift = "e";

                if (employeeData.SponsorsID != 0)
                {
                    chkIsSponsorer_CheckedChanged(null, null);
                    chkIsSponsorer.Checked = true;
                    cmdEmployeeName.EditValue = employeeData.SponsorsID;
                }



                txtSalary.Text = (employeeData.Salary).ToString();
                txtPerDayWorkingHours.Text = (employeeData.PerDayWorkingHours).ToString();
                txtPerHourSalary.Text = (employeeData.PerHourSalary).ToString();

                if (!employeeData.PaymentType.Value)
                {
                    rbBank.Checked = true;
                    Paymenttype_CheckedChanged(null, null);
                    txtBankName.Text = employeeData.BankName;
                    txtAccountNo.Text = employeeData.AccountNo;
                    txtRTGSNo.Text = employeeData.RTGSNo;
                    txtIFSCCode.Text = employeeData.IFSCCode;
                }
                else
                {
                    rbCash.Checked = true;
                }


                txtOpeningBalance.Text = (employeeData.OpeningBalance).ToString();



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
            ErrorHandlor.SetTextboxErrorWithCount(errorFirstName, txtFirstName, "Enter First Name");
            ErrorHandlor.SetTextboxErrorWithCount(errorMiddleName, txtMiddleName, "Enter Middle Name");
            ErrorHandlor.SetTextboxErrorWithCount(errorLastName, txtLastName, "Enter Last Name");
            ErrorHandlor.SetDateErrorWithCount(errorDateofBirth, dpDOB, "Select Date of birth.");
            ErrorHandlor.SetTextboxErrorWithCount(errorMobileno, txtMobileNo, "Enter Mobile number");
            ErrorHandlor.SetMemoEditErrorWithCount(errorResidentialAddress, txtResidentialAddress, "Enter Residential Address.");
            ErrorHandlor.SetMemoEditErrorWithCount(errorPermanentAddress, txtPermanentAddress, "Enter Permenant Address.");
            ErrorHandlor.SetLookUPErrorWithCount(errorCompanyName, cmbCompanyCode, "Select Company name");
            ErrorHandlor.SetLookUPErrorWithCount(errorEmployeeType, cmbEmployeeType, "Select Employee Type");
            ErrorHandlor.SetTextboxErrorWithCount(errorEmployeeCode, txtEmployeeCode, "EnterEmployee Code");
            ErrorHandlor.SetTextboxErrorWithCount(errorJobTitle, txtJobTitle, "Enter Job title.");
            ErrorHandlor.SetDateErrorWithCount(errorDateOfJoining, dpDOJ, "Select Employee Joining Date.");
            ErrorHandlor.SetTextboxErrorWithCount(errorEmailId, txtEmail, "Enter Email");
            ErrorHandlor.SetLookUPErrorWithCount(errorIdProfType, cmbProfeType, "Select ID Profe");
            ErrorHandlor.SetTextboxErrorWithCount(errorIdProfeNo, txtProfeNo, "Enter Profe Number");

            if (chkIsSponsorer.Checked)
                ErrorHandlor.SetLookUPErrorWithCount(errorEmployeeName, cmdEmployeeName, "Select Employee Name");

            ErrorHandlor.SetTextboxErrorWithCount(errorSalary, txtSalary, "Enter Employee Salary");
            ErrorHandlor.SetTextboxErrorWithCount(errorPerDayWorkingHour, txtPerDayWorkingHours, "Enter per day working hours.");
            ErrorHandlor.SetTextboxErrorWithCount(errorPerHourSalary, txtPerHourSalary, "Enter per hour salary.");
            if (rbBank.Checked)
            {
                ErrorHandlor.SetTextboxErrorWithCount(errorBankName, txtBankName, "Enter Bank Name");
                ErrorHandlor.SetTextboxErrorWithCount(errorAccountNo, txtAccountNo, "Enter Account Number");
                ErrorHandlor.SetTextboxErrorWithCount(errorRTGSNo, txtRTGSNo, "Enter RTGS Number");
                ErrorHandlor.SetTextboxErrorWithCount(errorIFSCCode, txtIFSCCode, "Enter IFSC Code");
            }
            ErrorHandlor.SetTextboxErrorWithCount(errorOpeningBalance, txtOpeningBalance, "Enter RTGS Number");


            if (ErrorHandlor.count == 0)
                return true;
            else
                return false;
        }

        private void ClearData()
        {
            //Clear data
            txtFirstName.Text = "";
            txtMiddleName.Text = "";
            txtLastName.Text = "";
            rbMale.AutoCheck = true;
            dpDOB.DateTime = DateTime.Now;
            txtMobileNo.Text = "";
            txtResidentialAddress.Text = "";
            txtPermanentAddress.Text = "";
            txtEmail.Text = "";
            cmbProfeType.EditValue = 0;
            txtProfeNo.Text = "";
            cmbCompanyCode.EditValue = 0;
            cmbEmployeeType.EditValue = 0;
            txtEmployeeCode.Text = "";
            txtJobTitle.Text = "";
            dpDOJ.DateTime = DateTime.Now;
            rbMorning.AutoCheck = true;

            cmdEmployeeName.EditValue = 0;
            txtSalary.Text = "";
            txtPerDayWorkingHours.Text = "";
            txtPerHourSalary.Text = "";
            rbCash.AutoCheck = true;
            txtBankName.Text = "";
            txtAccountNo.Text = "";
            txtRTGSNo.Text = "";
            txtIFSCCode.Text = "";
            txtOpeningBalance.Text = "";




            ////Reset BackGround Color
            txtFirstName.BackColor = CommanClass.m_tbcolorleave;
            txtMiddleName.BackColor = CommanClass.m_tbcolorleave;
            txtLastName.BackColor = CommanClass.m_tbcolorleave;
            dpDOB.BackColor = CommanClass.m_tbcolorleave;
            txtMobileNo.BackColor = CommanClass.m_tbcolorleave;
            txtResidentialAddress.BackColor = CommanClass.m_tbcolorleave;
            txtPermanentAddress.BackColor = CommanClass.m_tbcolorleave;
            txtEmail.BackColor = CommanClass.m_tbcolorleave;
            cmbProfeType.BackColor = CommanClass.m_tbcolorleave;
            txtProfeNo.BackColor = CommanClass.m_tbcolorleave;
            cmbCompanyCode.BackColor = CommanClass.m_tbcolorleave;
            cmbEmployeeType.BackColor = CommanClass.m_tbcolorleave;
            txtEmployeeCode.BackColor = CommanClass.m_tbcolorleave;
            txtJobTitle.BackColor = CommanClass.m_tbcolorleave;
            dpDOJ.BackColor = CommanClass.m_tbcolorleave;
            cmdEmployeeName.BackColor = CommanClass.m_tbcolorleave;
            txtSalary.BackColor = CommanClass.m_tbcolorleave;
            txtPerDayWorkingHours.BackColor = CommanClass.m_tbcolorleave;
            txtPerHourSalary.BackColor = CommanClass.m_tbcolorleave;
            txtBankName.BackColor = CommanClass.m_tbcolorleave;
            txtAccountNo.BackColor = CommanClass.m_tbcolorleave;
            txtRTGSNo.BackColor = CommanClass.m_tbcolorleave;
            txtIFSCCode.BackColor = CommanClass.m_tbcolorleave;
            txtOpeningBalance.BackColor = CommanClass.m_tbcolorleave;

            //Reset error 
            errorFirstName.SetError(txtFirstName, "");
            errorMiddleName.SetError(txtMiddleName, "");
            errorLastName.SetError(txtLastName, "");
            errorDateofBirth.SetError(dpDOB, "");
            errorMobileno.SetError(txtMobileNo, "");
            errorResidentialAddress.SetError(txtResidentialAddress, "");
            errorPermanentAddress.SetError(txtPermanentAddress, "");
            errorEmailId.SetError(txtEmail, "");
            errorIdProfType.SetError(cmbProfeType, "");
            errorIdProfeNo.SetError(txtProfeNo, "");
            errorCompanyName.SetError(cmbCompanyCode, "");

            errorEmployeeType.SetError(cmbProfeType, "");
            errorEmployeeCode.SetError(txtEmployeeCode, "");
            errorJobTitle.SetError(txtJobTitle, "");
            errorDateOfJoining.SetError(dpDOJ, "");
            errorEmployeeName.SetError(cmdEmployeeName, "");
            errorSalary.SetError(txtSalary, "");
            errorPerDayWorkingHour.SetError(txtPerDayWorkingHours, "");
            errorPerHourSalary.SetError(txtPerHourSalary, "");
            errorAccountNo.SetError(txtBankName, "");
            errorAccountNo.SetError(txtAccountNo, "");
            errorRTGSNo.SetError(txtRTGSNo, "");
            errorIFSCCode.SetError(txtIFSCCode, "");
            errorOpeningBalance.SetError(txtOpeningBalance, "");

            SetFlag();
            txtFirstName.Focus();

        }

        private void LoadCompanyDetails()
        {
            cmbCompanyCode.Properties.DataSource = UserContext.UserContexttblCompanyDTO;
            cmbCompanyCode.Properties.ValueMember = "CompanyID";
            cmbCompanyCode.Properties.DisplayMember = "CompanyName";
        }

        private void LoadEmployeeDetails()
        {
            cmdEmployeeName.Properties.DataSource = UserContext.UserContexttblEmployeeDTO;
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

      

      

    }
}
