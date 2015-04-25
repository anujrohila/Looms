using LoomsManagement.Windows.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LoomsManagement.Windows.Forms.Challan
{
    public partial class frmSalesChallan : LoomsManagement.Windows.FormDemo1
    {

        #region Variable

        #endregion

        #region Constructor

        public frmSalesChallan()
        {
            InitializeComponent();
        }

        #endregion

        #region Page Event
        #endregion

        #region Control Event

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
       
        private void btndelete_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {

        }

        private void btnReport_Click(object sender, EventArgs e)
        {

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


        # region Private Method

        private void LoadBankName()
        {
            //cmbBankName.Properties.DataSource = UserContext.UserContexttblBankMSTDTO;
            //cmbBankName.Properties.ValueMember = "BankID";
            //cmbBankName.Properties.DisplayMember = "BankName";
        }

        //private void SetFlag()
        //{
        //    if (IsEdit)
        //    {
        //        var branchData = BankBusinessLogic.GetBranchDetails(id);
        //        cmbBankName.EditValue = branchData.BankID;
        //        txtBranchName.Text = branchData.BranchName;
        //        txtAddress.Text = branchData.Address;
        //        btndelete.Enabled = true;
        //        btnReport.Enabled = true;
        //    }
        //    else
        //    {
        //        btndelete.Enabled = false;
        //        btnReport.Enabled = false;
        //    }
        //}

        private Boolean Validation()
        {

            ErrorHandlor.SetErrorCount();
            ErrorHandlor.SetLookUPErrorWithCount(errorChallanNumber, cmbChallanNo, "Select Challan Number");
            ErrorHandlor.SetDateErrorWithCount(errorChallanDate, dpChallanDate, "Select Challan Date");
            ErrorHandlor.SetLookUPErrorWithCount(errorOrderNo, cmbOrderName, "Select Order Name");
            ErrorHandlor.SetLookUPErrorWithCount(errorPartyname, cmbPartyName, "Select Party Name");
            ErrorHandlor.SetLookUPErrorWithCount(errorBrokerName, cmbBrokerName, "Select Broker Name");
            ErrorHandlor.SetLookUPErrorWithCount(errorCheckedBy, cmbCheckedBy, "Select Person Name");
            ErrorHandlor.SetLookUPErrorWithCount(errorQualityTypeName, cmbQualityTypeName, "Enter Quality Type Name");
            ErrorHandlor.SetTextboxErrorWithCount(errorLRNumber, txtLRNo, "Enter LR Number");
            ErrorHandlor.SetTextboxErrorWithCount(errorTransport, txtTransport, "Enter Transport Number");
            ErrorHandlor.SetDateErrorWithCount(errorDeliveryDate, dpDeliveryDate, "Enter Delivery Date");
            ErrorHandlor.SetDateErrorWithCount(errorDeliveredDate, dpDeliveredDate, "Enter Delivered Date");

            if (ErrorHandlor.count == 0)
                return true;
            else
                return false;
        }                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           

        private void ClearData()
        {
            //Clear data
            cmbPartyName.EditValue = 0;
            cmbBrokerName.EditValue = 0;
            cmbChallanNo.EditValue = 0;
            dpChallanDate.EditValue = DateTime.Now;
            cmbOrderName.EditValue = 0;
            cmbQualityTypeName.EditValue = 0;
            txtLRNo.Text = "";
            txtTransport.Text = "";
            txtTruckNo.Text = "";
            cmbCheckedBy.EditValue = 0;
            dpDeliveryDate.EditValue = DateTime.Now;
            dpDeliveredDate.EditValue = DateTime.Now;
            txtRemark.Text = "";



            //Reset BackGround Color
            cmbPartyName.BackColor = CommanClass.m_tbcolorleave;
            cmbBrokerName.BackColor = CommanClass.m_tbcolorleave;
            cmbChallanNo.BackColor = CommanClass.m_tbcolorleave;
            dpChallanDate.BackColor = CommanClass.m_tbcolorleave;
            cmbOrderName.BackColor = CommanClass.m_tbcolorleave;
            cmbQualityTypeName.BackColor = CommanClass.m_tbcolorleave;
            txtLRNo.BackColor = CommanClass.m_tbcolorleave;
            txtTransport.BackColor = CommanClass.m_tbcolorleave;
            txtTruckNo.BackColor = CommanClass.m_tbcolorleave;
            cmbCheckedBy.BackColor = CommanClass.m_tbcolorleave;
            dpDeliveryDate.BackColor = CommanClass.m_tbcolorleave;
            dpDeliveredDate.BackColor = CommanClass.m_tbcolorleave;
            txtRemark.BackColor = CommanClass.m_tbcolorleave;
           


            //Reset error 
            errorChallanNumber.SetError(cmbChallanNo, "");
            errorChallanDate.SetError(dpChallanDate, "");
            errorOrderNo.SetError(cmbOrderName, "");
            errorPartyname.SetError(cmbOrderName, "");
            errorBrokerName.SetError(cmbBrokerName, "");
            errorQualityTypeName.SetError(cmbQualityTypeName,"");
            errorLRNumber.SetError(txtLRNo, "");
            errorTransport.SetError(txtTransport, "");
            errorTruckNo.SetError(txtTruckNo, "");
            errorCheckedBy.SetError(cmbCheckedBy, "");
            errorDeliveryDate.SetError(dpDeliveryDate, "");
            errorDeliveredDate.SetError(dpDeliveredDate, "");
            cmbChallanNo.Focus();

        }

        #endregion        


    }
}
