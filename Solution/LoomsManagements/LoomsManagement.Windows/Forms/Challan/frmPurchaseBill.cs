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
    public partial class frmPurchaseBill : LoomsManagement.Windows.FormDemo1
    {
        #region Variable
        #endregion

        #region Constructor

        public frmPurchaseBill()
        {
            InitializeComponent();
        }

        #endregion

        #region Page Event
        #endregion

        # region Control Event

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
               
        private void btndelete_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {

        }

        #region Key Events

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

        #region Private Method

        private Boolean Validation()
        {

            ErrorHandlor.SetErrorCount();
            ErrorHandlor.SetTextboxErrorWithCount(errorChallanNumber, txtChallanNo, "Enter Challan Number");
            ErrorHandlor.SetDateErrorWithCount(errorBillDate, dpBillDate, "Select Bill Date");
            ErrorHandlor.SetLookUPErrorWithCount(errorPartyName, cmbPartyName, "Select Party Name");
            ErrorHandlor.SetLookUPErrorWithCount(errorBrokerName, cmbBrokerName, "Select Broker Name");
            ErrorHandlor.SetLookUPErrorWithCount(errorQualityTypeName, cmbQualityTypeName, "Enter Quality Type Name");
            ErrorHandlor.SetLookUPErrorWithCount(errorReceivedBy, cmbReceivedBy, "Select Person Name");
            ErrorHandlor.SetTextboxErrorWithCount(errorLotNumber, txtLotNo, "Enter Lot Number");
            ErrorHandlor.SetTextboxErrorWithCount(errorGrade, txtGrade, "Enter Grade");
            ErrorHandlor.SetTextboxErrorWithCount(errorTwistShed, txtTwistShed, "Enter Twist Shed");
            ErrorHandlor.SetLookUPErrorWithCount(errorTaxType, cmbTaxType, "Enter Tax Type");
            ErrorHandlor.SetTextboxErrorWithCount(errorTaxAmount, txtTaxAmount, "Enter Tax Amount");
            ErrorHandlor.SetLookUPErrorWithCount(errorBillNumber, cmbBillNo, "Enter Bill Number");
         
            if (ErrorHandlor.count == 0)
                return true;
            else
                return false;
        }

        private void ClearData()
        {
            //Clear data
            txtChallanNo.Text = "";
            cmbBillNo.EditValue = 0;
            dpBillDate.EditValue = DateTime.Now;
            cmbPartyName.EditValue = 0;
            cmbBrokerName.EditValue = 0;
            cmbQualityTypeName.EditValue = 0;
            txtLotNo.Text = "";
            txtGrade.Text = "";
            txtTwistShed.Text = "";
            cmbReceivedBy.EditValue = "";
            cmbTaxType.EditValue = 0;
            txtTaxAmount.Text = "";
            txtRemarks.Text = "";
            txtFinalAmount.Text = "";



            //Reset BackGround Color
            txtChallanNo.BackColor = CommanClass.m_tbcolorleave;
            cmbBillNo.BackColor = CommanClass.m_tbcolorleave;
            dpBillDate.BackColor = CommanClass.m_tbcolorleave;
            cmbPartyName.BackColor = CommanClass.m_tbcolorleave;
            cmbBrokerName.BackColor = CommanClass.m_tbcolorleave;
            cmbQualityTypeName.BackColor = CommanClass.m_tbcolorleave;
            txtLotNo.BackColor = CommanClass.m_tbcolorleave;
            txtGrade.BackColor = CommanClass.m_tbcolorleave;
            txtTwistShed.BackColor = CommanClass.m_tbcolorleave;
            cmbReceivedBy.BackColor = CommanClass.m_tbcolorleave;
            cmbTaxType.BackColor = CommanClass.m_tbcolorleave;
            txtTaxAmount.BackColor = CommanClass.m_tbcolorleave;
            txtRemarks.BackColor = CommanClass.m_tbcolorleave;
            txtFinalAmount.BackColor = CommanClass.m_tbcolorleave;



            //Reset error 
            errorBillDate.SetError(dpBillDate, "");
            errorBrokerName.SetError(cmbBrokerName, "");
            errorLotNumber.SetError(txtLotNo, "");
            errorTwistShed.SetError(txtTwistShed, "");
            errorTaxType.SetError(cmbTaxType, "");
            errorQualityTypeName.SetError(cmbQualityTypeName, "");
            errorChallanNumber.SetError(txtChallanNo, "");
            errorBillNumber.SetError(cmbBillNo, "");
            errorGrade.SetError(txtGrade, "");
            errorReceivedBy.SetError(cmbReceivedBy, "");
            errorTaxAmount.SetError(txtTaxAmount, "");
            errorPartyName.SetError(cmbPartyName, "");
            txtChallanNo.Focus();

        }

        #endregion


    }
}
