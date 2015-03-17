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
    public partial class frmBrokerMaster : LoomsManagement.Windows.FormDemo1
    {
        #region Variable

        public Boolean IsEdit = false;
        public int id = 0;

        #endregion

        #region Constructor

        public frmBrokerMaster()
        {
            InitializeComponent();
            btnReport.Visible = false;
            this.Paint += frmBrokerMaster_Paint;
        }

      

        #endregion

        #region Page Event
        void frmBrokerMaster_Paint(object sender, PaintEventArgs e)
        {
            CommanClass.ShowProcessBar();
            SetFlag();
            txtBrokerName.Focus();
            CommanClass.HideProcessBar();
        }
        #endregion

        #region Control Event

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!Validation())
                return;
            CommanClass.ShowProcessBar();
            var tblBrokersMSTDTO = new tblBrokersMSTDTO();
            tblBrokersMSTDTO.BrokerName = txtBrokerName.Text;
            tblBrokersMSTDTO.BrokerFirmName = txtBrokerFirmName.Text;
            tblBrokersMSTDTO.Address = txtAddress.Text;
            tblBrokersMSTDTO.ContactNo = txtContactNumber.Text;
            tblBrokersMSTDTO.MobileNo = txtMobileNumber.Text;
            tblBrokersMSTDTO.DealingIn = txtDealingIn.Text;
            tblBrokersMSTDTO.IsActive = true;
            tblBrokersMSTDTO.IsDelete = false;

            if (IsEdit)
            {
                tblBrokersMSTDTO.BrokerID = id;
                tblBrokersMSTDTO.UpdateBy = CommanClass.UserId;
                tblBrokersMSTDTO.UpdationDateTime = DateTime.Now;
            }
            else
            {
                tblBrokersMSTDTO.CreateBy = CommanClass.UserId;
                tblBrokersMSTDTO.CreationDateTime = DateTime.Now;
            }

            int ReturnValue = PartyBusinessLogic.SaveBroker(tblBrokersMSTDTO);
            CommanClass.HideProcessBar();

            if (ReturnValue == 1)
            {
                errorBrokerName.SetError(txtBrokerName, "Broker name already exist");
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
                if (PartyBusinessLogic.DeleteBroker(id) != 0)
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

        private void SetFlag()
        {
            if (IsEdit)
            {
                var brokerMstData = PartyBusinessLogic.GetBrokerDetails(id);
                txtBrokerName.Text = brokerMstData.BrokerName;
                txtBrokerFirmName.Text = brokerMstData.BrokerFirmName;
                txtAddress.Text = brokerMstData.Address;
                txtContactNumber.Text = brokerMstData.ContactNo;
                txtMobileNumber.Text = brokerMstData.MobileNo;
                txtDealingIn.Text = brokerMstData.DealingIn;
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
            ErrorHandlor.SetTextboxErrorWithCount(errorBrokerName, txtBrokerName, "Enter Broker Name");
            ErrorHandlor.SetTextboxErrorWithCount(errorBrokerFirmName, txtBrokerFirmName, "Enter Broker Firm Name");
            ErrorHandlor.SetMemoEditErrorWithCount(errorAddress, txtAddress, "Enter Address");
            ErrorHandlor.SetTextboxErrorWithCount(errorContactNumber, txtContactNumber, "Enter Broker Contact Number.");
            ErrorHandlor.SetTextboxErrorWithCount(errorMobileNumber, txtMobileNumber, "Enter Broker Mobile Number");
            ErrorHandlor.SetMemoEditErrorWithCount(errorDealing, txtDealingIn, "Enter Deal");

            if (ErrorHandlor.count == 0)
                return true;
            else
                return false;
        }

        private void ClearData()
        {
            //Clear data
            txtBrokerFirmName.Text = "";
            txtBrokerName.Text = "";
            txtAddress.Text = "";
            txtContactNumber.Text = "";
            txtMobileNumber.Text = "";
            txtDealingIn.Text = "";

            //Reset BackGround Color
            txtBrokerName.BackColor = CommanClass.m_tbcolorleave;
            txtBrokerFirmName.BackColor = CommanClass.m_tbcolorleave;
            txtAddress.BackColor = CommanClass.m_tbcolorleave;
            txtContactNumber.BackColor = CommanClass.m_tbcolorleave;
            txtMobileNumber.BackColor = CommanClass.m_tbcolorleave;
            txtDealingIn.BackColor = CommanClass.m_tbcolorleave;


            //Reset error 
            errorBrokerName.SetError(txtBrokerName, "");
            errorBrokerFirmName.SetError(txtBrokerFirmName, "");
            errorAddress.SetError(txtAddress, "");
            errorContactNumber.SetError(txtContactNumber, "");
            errorMobileNumber.SetError(txtMobileNumber, "");
            errorDealing.SetError(txtDealingIn, "");
            txtBrokerName.Focus();

        }

        #endregion

       


    }
}
