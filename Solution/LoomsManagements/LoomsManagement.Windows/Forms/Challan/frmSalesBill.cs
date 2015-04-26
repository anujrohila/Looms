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
    

 public partial class frmSalesBill : LoomsManagement.Windows.FormDemo1
 {
     #region Variable
     #endregion

     #region CONSTRUCTION

     public frmSalesBill()
        {
            InitializeComponent();
        }
     #endregion

    #region Page Evvent
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
         ErrorHandlor.SetLookUPErrorWithCount(errorInvoiceNo, cmbInvoiceNo, "Select Invoice Number");
         ErrorHandlor.SetDateErrorWithCount(errorInvoiceDate, dpInvoiceDate, "Select Invoice Date");
         ErrorHandlor.SetLookUPErrorWithCount(errorOrderNo, cmbOrderName, "Select Order Number");
         ErrorHandlor.SetLookUPErrorWithCount(errorBrokerName, cmbBrokerName, "Select Broker Name");
         ErrorHandlor.SetLookUPErrorWithCount(errorQualityTypeName, cmbQualityTypeName, "Enter Quality Type Name");
         ErrorHandlor.SetLookUPErrorWithCount(errorPartyname, cmbPartyName, "Select Party Name");
         ErrorHandlor.SetTextboxErrorWithCount(errorLRNumber, txtLRNo, "Enter LR Number");
         ErrorHandlor.SetTextboxErrorWithCount(errorTransport, txtTransport, "Enter Transport");
         ErrorHandlor.SetTextboxErrorWithCount(errorTruckNo, txtTruckNo, "Enter Truck Number");
         ErrorHandlor.SetLookUPErrorWithCount(errorCheckedBy, cmbCheckedBy, "Select Employee name");
         ErrorHandlor.SetDateErrorWithCount(errorDeliveryDate, dpDeliveryDate, "Enter Delivery date");
         ErrorHandlor.SetDateErrorWithCount(errorDeliveredDate, dpDeliveredDate, "Enter Delivered Date");

         if (ErrorHandlor.count == 0)
             return true;
         else
             return false;
     }

     private void ClearData()
     {
         //Clear data
         cmbOrderName.EditValue = 0;
         cmbInvoiceNo.EditValue = 0;
         dpInvoiceDate.EditValue = DateTime.Now;
         cmbPartyName.EditValue = 0;
         cmbBrokerName.EditValue = 0;
         cmbQualityTypeName.EditValue = 0;
         cmbOrderName.EditValue = 0;
         txtLRNo.Text = "";
         txtTransport.Text = "";
         cmbCheckedBy.EditValue = 0;
         txtTruckNo.Text = "";
         dpDeliveryDate.EditValue = DateTime.Now;
         dpDeliveredDate.EditValue = DateTime.Now;



         //Reset BackGround Color
         cmbOrderName.BackColor = CommanClass.m_tbcolorleave;
         cmbInvoiceNo.BackColor = CommanClass.m_tbcolorleave;
         dpInvoiceDate.BackColor = CommanClass.m_tbcolorleave;
         cmbPartyName.BackColor = CommanClass.m_tbcolorleave;
         cmbBrokerName.BackColor = CommanClass.m_tbcolorleave;
         cmbQualityTypeName.BackColor = CommanClass.m_tbcolorleave;
         cmbOrderName.BackColor = CommanClass.m_tbcolorleave;
         txtLRNo.BackColor = CommanClass.m_tbcolorleave;
         txtTransport.BackColor = CommanClass.m_tbcolorleave;
         cmbCheckedBy.BackColor = CommanClass.m_tbcolorleave;
         txtTruckNo.BackColor = CommanClass.m_tbcolorleave;
         dpDeliveryDate.BackColor = CommanClass.m_tbcolorleave;
         dpDeliveredDate.BackColor = CommanClass.m_tbcolorleave;
         txtRemark.BackColor = CommanClass.m_tbcolorleave;
        

         //Reset error 
         errorBrokerName.SetError(cmbBrokerName, "");
         errorCheckedBy.SetError(cmbCheckedBy, "");
         errorInvoiceDate.SetError(dpInvoiceDate, "");
         errorInvoiceNo.SetError(cmbInvoiceNo, "");
         errorLRNumber.SetError(txtLRNo, "");
         errorQualityTypeName.SetError(cmbQualityTypeName, "");
         errorOrderNo.SetError(cmbOrderName, "");
         errorPartyname.SetError(cmbPartyName, "");
         errorTransport.SetError(txtTransport, "");
         errorTruckNo.SetError(txtTruckNo, "");
         errorDeliveredDate.SetError(dpDeliveredDate, "");
         errorDeliveryDate.SetError(dpDeliveryDate, "");
         cmbInvoiceNo.Focus();

     }

     #endregion
 }
}
