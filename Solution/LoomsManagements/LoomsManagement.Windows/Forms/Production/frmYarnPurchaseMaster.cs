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

namespace LoomsManagement.Windows.Forms.Production
{
    public partial class frmYarnPurchaseMaster : LoomsManagement.Windows.FormDemo1
    {
        #region Variable

        public Boolean IsEdit = false;
        public int id = 0;

        #endregion

        #region Constructor

        public frmYarnPurchaseMaster()
        {
            InitializeComponent();
            this.Paint += frmYarnPurchaseMaster_Paint;
        }

        #endregion

        #region Page Event

        void frmYarnPurchaseMaster_Paint(object sender, PaintEventArgs e)
        {
            CommanClass.ShowProcessBar();
            SetFlag();
            LoadCompanyName();
            LoadPartyName();
            LoadBrokerName();
            LoadYear();
            LoadEmployeeName();
            txtSerialNumber.Focus();
            CommanClass.HideProcessBar();
        }

        #endregion

        #region Control Event
               

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!Validation())
                return;
            CommanClass.ShowProcessBar();

            var tblYarnPurchaseDTO = new tblYarnPurchaseDTO();
            tblYarnPurchaseDTO.SRNo = Convert.ToInt32(txtSerialNumber.Text);
            tblYarnPurchaseDTO.CompanyID = Convert.ToInt32(cmbCompanyName.EditValue);
            tblYarnPurchaseDTO.PartyID = Convert.ToInt32(cmbPartyName.EditValue);
            tblYarnPurchaseDTO.BrokerID = Convert.ToInt32(cmbBrokertName.EditValue);
            tblYarnPurchaseDTO.YearID = Convert.ToInt32(cmbYear.EditValue);
            tblYarnPurchaseDTO.EmployeeId = Convert.ToInt32(cmbEmployeeName.EditValue);
            tblYarnPurchaseDTO.PurchaseDate = Convert.ToDateTime(dpPurchaseDate.EditValue);
            tblYarnPurchaseDTO.ChallanNo = txtChallanNumber.Text;
            tblYarnPurchaseDTO.LRNo = txtLRNumber.Text;
            tblYarnPurchaseDTO.RecieveAt = txtReceive.Text;
            tblYarnPurchaseDTO.Grade = txtGrade.Text;
            tblYarnPurchaseDTO.IsActive = true;
            tblYarnPurchaseDTO.IsDelete = false;

            if (IsEdit)
            {
                tblYarnPurchaseDTO.PurchaseID = id;
                tblYarnPurchaseDTO.UpdatedBy = CommanClass.UserId;
                tblYarnPurchaseDTO.UpDatedDateTime = DateTime.Now;
            }
            else
            {
                tblYarnPurchaseDTO.CreatedBy = CommanClass.UserId;
                tblYarnPurchaseDTO.CreatedDateTime = DateTime.Now;
            }

            int ReturnValue = YarnPurchaseBusinessLogic.SaveYarnPurchase(tblYarnPurchaseDTO);
            CommanClass.HideProcessBar();

            if (ReturnValue == 1)
            {
                errorSerialNumber.SetError(txtSerialNumber, "Serial Number already exist");
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
                if (YarnPurchaseBusinessLogic.DeleteYarPurchase(id) != 0)
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
            this.Close(); ClearData();
            this.Close();
        }

        #region Key Event

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



        #region Private Method

       private void LoadCompanyName()
        {
            cmbCompanyName.Properties.DataSource = UserContext.UserContexttblCompanyDTO;
            cmbCompanyName.Properties.ValueMember = "CompanyID";
            cmbCompanyName.Properties.DisplayMember = "CompanyName";
        }

        private void LoadPartyName()
        {
            cmbPartyName.Properties.DataSource = UserContext.UserContexttblPartysMSTDTO;
            cmbPartyName.Properties.ValueMember = "PartyID";
            cmbPartyName.Properties.DisplayMember = "PartyName";
        }

        private void LoadBrokerName()
        {
            cmbBrokertName.Properties.DataSource = UserContext.UserContexttblBrokersMSTDTO;
            cmbBrokertName.Properties.ValueMember = "BrokerID";
            cmbBrokertName.Properties.DisplayMember = "BrokerName";
        }

        private void LoadYear()
        {
            cmbYear.Properties.DataSource = UserContext.UserContexttblWorkingYearDTO;
            cmbYear.Properties.ValueMember = "YearID";
            cmbYear.Properties.DisplayMember = "YearName";
        }

        private void LoadEmployeeName()
        {
            cmbEmployeeName.Properties.DataSource = UserContext.UserContexttblEmployeeDTO;
            cmbEmployeeName.Properties.ValueMember = "EmployeeID";
            cmbEmployeeName.Properties.DisplayMember = "FirstName";
        }

        private void SetFlag()
        {
            if (IsEdit)
            {
                var yarnPurchase = YarnPurchaseBusinessLogic.GetYarnPurchase(id);
                txtSerialNumber.Text = (yarnPurchase.SRNo).ToString();
                cmbCompanyName.EditValue = yarnPurchase.CompanyID;
                cmbPartyName.EditValue = yarnPurchase.PartyID;
                cmbBrokertName.EditValue = yarnPurchase.BrokerID;
                cmbYear.EditValue = yarnPurchase.YearID;
                cmbEmployeeName.EditValue = yarnPurchase.EmployeeId;
                dpPurchaseDate.DateTime = DateTime.Now;
                txtChallanNumber.Text = yarnPurchase.ChallanNo;
                txtLRNumber.Text = yarnPurchase.LRNo;
                txtReceive.Text = yarnPurchase.LRNo;
                txtGrade.Text = yarnPurchase.Grade;

               
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
            ErrorHandlor.SetTextboxErrorWithCount(errorSerialNumber, txtSerialNumber, "Enter Serial Number");
            ErrorHandlor.SetLookUPErrorWithCount(errorCompanyName, cmbCompanyName, "Select Company Name");
            ErrorHandlor.SetLookUPErrorWithCount(errorPartyName, cmbPartyName, "Select Pary Name");
            ErrorHandlor.SetLookUPErrorWithCount(errorBrokerName, cmbBrokertName, "Select Broker Name");
            ErrorHandlor.SetLookUPErrorWithCount(errorYear, cmbYear, "Select Year");
            ErrorHandlor.SetLookUPErrorWithCount(errorEmployeeName, cmbEmployeeName, "Select Employee Name");
            ErrorHandlor.SetDateErrorWithCount(errorPurchaseDate, dpPurchaseDate, "Select Date");
            ErrorHandlor.SetTextboxErrorWithCount(errorChallanNo, txtChallanNumber, "Enter Challan Number");
            ErrorHandlor.SetTextboxErrorWithCount(errorLRNumber, txtLRNumber, "Enter LR Number");
            ErrorHandlor.SetTextboxErrorWithCount(errorReceive, txtReceive, "Enter Receive At.");
          
            if (ErrorHandlor.count == 0)
                return true;
            else
                return false;
        }

        private void ClearData()
        {
            //Clear data
            txtSerialNumber.Text = "";
            cmbCompanyName.EditValue = "";
            cmbPartyName.EditValue = "";
            cmbBrokertName.EditValue = "";
            cmbYear.EditValue = 0;
            cmbEmployeeName.EditValue = "";
            txtChallanNumber.Text = "";
            txtLRNumber.Text = "";
            txtReceive.Text = "";
            txtGrade.Text = "";

            //Reset BackGround Color
            txtSerialNumber.BackColor = CommanClass.m_tbcolorleave;
            cmbCompanyName.BackColor = CommanClass.m_tbcolorleave;
            cmbPartyName.BackColor = CommanClass.m_tbcolorleave;
            cmbBrokertName.BackColor = CommanClass.m_tbcolorleave;
            cmbYear.BackColor = CommanClass.m_tbcolorleave;
            cmbEmployeeName.BackColor = CommanClass.m_tbcolorleave;
            txtChallanNumber.BackColor = CommanClass.m_tbcolorleave;
            txtLRNumber.BackColor = CommanClass.m_tbcolorleave;
            txtReceive.BackColor = CommanClass.m_tbcolorleave;
            txtGrade.BackColor = CommanClass.m_tbcolorleave;


            //Reset error 
            errorSerialNumber.SetError(txtSerialNumber, "");
            errorCompanyName.SetError(cmbCompanyName, "");
            errorPartyName.SetError(cmbPartyName, "");
            errorBrokerName.SetError(cmbBrokertName, "");
            errorYear.SetError(cmbYear, "");
            errorEmployeeName.SetError(cmbEmployeeName, "");
            errorPurchaseDate.SetError(dpPurchaseDate, "");
            errorChallanNo.SetError(txtChallanNumber, "");
            errorLRNumber.SetError(txtLRNumber, "");
            errorReceive.SetError(txtReceive, "");
            txtSerialNumber.Focus();

        }

        #endregion 
    }
}
