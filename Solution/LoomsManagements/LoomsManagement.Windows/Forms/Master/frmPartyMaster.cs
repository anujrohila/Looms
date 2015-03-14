using LoomsManagement.BAL;
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
    public partial class frmPartyMaster : LoomsManagement.Windows.FormDemo1
    {
        #region Variable

        public Boolean IsEdit = false;
        public int id = 0;

        #endregion

        #region Constructor
        public frmPartyMaster()
        {
            InitializeComponent();
            this.Load += frmPartyMaster_Load;
        }

        #endregion

        #region Page Event

        void frmPartyMaster_Load(object sender, EventArgs e)
        {
            LoadCompanyCode();
        }

        #endregion

        #region Control Event
        #endregion

        # region Private Method 

        private void LoadCompanyCode()
        {
            cmbCompanyCode.Properties.DataSource = PartyMasterBusinessLogic.GetCompanyCode();
            cmbCompanyCode.Properties.ValueMember = "CompanyID";
            cmbCompanyCode.Properties.DisplayMember = "ComapnyCode";
        }

        private void SetFlag()
        {
            if (IsEdit)
            {
                var objPartyMst = PartyMasterBusinessLogic.GetPartyDetails(id);
                cmbCompanyCode.EditValue = objPartyMst.CompanyCode;
                txtCity.Text = objPartyMst.City;
                txtContactPersonName.Text = objPartyMst.ContactPersonName;
                txtCSTNo.Text = objPartyMst.CSTTINNo;
                txtECCNo.Text = objPartyMst.ECCNo;
                txtEmail.Text = objPartyMst.EmailID;
                txtExtraDetails.Text = objPartyMst.ExtraDetails;
                txtMobileNo.Text = objPartyMst.MobileNo;
                txtofficeAddress.Text = objPartyMst.OfficeAddress;
                txtPANNo.Text = objPartyMst.PANNO;
                txtPartyName.Text = objPartyMst.PartyName;
                txtPhoneNo.Text = objPartyMst.PhoneNo;
                txtRefPersonMobNo.Text = objPartyMst.ReferencePersonMobileNo;
                txtRefPersonName.Text = objPartyMst.ReferencePersonName;
                txtShippingAddress.Text = objPartyMst.ShippingAddress;
                txtState.Text = objPartyMst.State;
                txtTINNo.Text = objPartyMst.TINNo;
                dpCSTDate.DateTime = Convert.ToDateTime(objPartyMst.CSTDate);
                dpTINDate.DateTime = Convert.ToDateTime(objPartyMst.TINDate);

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
            ErrorHandlor.SetTextboxErrorWithCount(errorPartyName, txtPartyName, "Enter Party Party Name");
            ErrorHandlor.SetLookUPErrorWithCount(errorCompanyCode, cmbCompanyCode, "Select Company Code");
            ErrorHandlor.SetTextboxErrorWithCount(errorOfficeAddress, txtofficeAddress, "Enter Office Address");
            ErrorHandlor.SetTextboxErrorWithCount(errorShippingAddress, txtShippingAddress, "Enter Shipping Address");
            ErrorHandlor.SetTextboxErrorWithCount(errorCity, txtCity, "Enter City Name");
            ErrorHandlor.SetTextboxErrorWithCount(errorState, txtState, "Enter State Name");
            ErrorHandlor.SetTextboxErrorWithCount(errorMobileNo, txtMobileNo, "Enter Mobile Number");
            ErrorHandlor.SetTextboxErrorWithCount(errorPhoneNo, txtPhoneNo, "Enter Phone Number");
            ErrorHandlor.SetTextboxErrorWithCount(errorShippingAddress, txtShippingAddress, "Enter Shipping Address");
            ErrorHandlor.SetTextboxErrorWithCount(errorShippingAddress, txtShippingAddress, "Enter Shipping Address");


            if (ErrorHandlor.count == 0)
                return true;
            else
                return false;
        }

        private void ClearData()
        {
            //Clear data
            cmbCompanyCode.EditValue = 0;
            txtCity.Text = "";
            txtContactPersonName.Text = "";
            txtCSTNo.Text = "";
            txtECCNo.Text = "";
            txtPartyName.Text = "";
            txtofficeAddress.Text = "";
            txtShippingAddress.Text = "";
            txtState.Text = "";
            txtMobileNo.Text = "";
            txtPhoneNo.Text = "";
            txtEmail.Text = "";
            txtTINNo.Text = "";
            dpTINDate.DateTime = DateTime.Now;
            dpCSTDate.DateTime = DateTime.Now;
            txtRefPersonMobNo.Text = "";
            txtRefPersonMobNo.Text = "";
            txtExtraDetails.Text = "";

            //Reset BackGround Color
            cmbCompanyCode.BackColor = CommanClass.m_tbcolorleave;
            txtPartyName.BackColor = CommanClass.m_tbcolorleave;
            txtContactPersonName.BackColor = CommanClass.m_tbcolorleave;
            txtofficeAddress.BackColor = CommanClass.m_tbcolorleave;
            txtShippingAddress.BackColor = CommanClass.m_tbcolorleave;
            txtCity.BackColor = CommanClass.m_tbcolorleave;
            txtState.BackColor = CommanClass.m_tbcolorleave;
            txtMobileNo.BackColor = CommanClass.m_tbcolorleave;
            txtPhoneNo.BackColor = CommanClass.m_tbcolorleave;
            txtEmail.BackColor = CommanClass.m_tbcolorleave;
            txtTINNo.BackColor = CommanClass.m_tbcolorleave;
            dpTINDate.BackColor = CommanClass.m_tbcolorleave;
            txtPANNo.BackColor = CommanClass.m_tbcolorleave;
            txtCSTNo.BackColor = CommanClass.m_tbcolorleave;
            dpCSTDate.BackColor = CommanClass.m_tbcolorleave;
            txtECCNo.BackColor = CommanClass.m_tbcolorleave;
            txtRefPersonName.BackColor = CommanClass.m_tbcolorleave;
            txtRefPersonMobNo.BackColor = CommanClass.m_tbcolorleave;
            txtExtraDetails.BackColor = CommanClass.m_tbcolorleave;


            //Reset error 
            errorCompanyCode.SetError(cmbCompanyCode, "");
            errorPartyName.SetError(txtPartyName, "");
            errorContactPersonName.SetError(txtContactPersonName, "");
            errorOfficeAddress.SetError(txtofficeAddress, "");
            errorShippingAddress.SetError(txtShippingAddress, "");
            errorCity.SetError(txtCity, "");
            errorState.SetError(txtState, "");
            errorMobileNo.SetError(txtMobileNo, "");
            errorPhoneNo.SetError(txtPhoneNo, "");
            errorEmail.SetError(txtEmail, "");
            errorTINNo.SetError(txtTINNo, "");
            errorTINDate.SetError(dpTINDate, "");
            errorPANNo.SetError(txtPANNo, "");
            errorCSTNo.SetError(txtCSTNo, "");
            errorCSTDate.SetError(dpCSTDate, "");
            errorECCNo.SetError(txtECCNo, "");
            errorRefPersonName.SetError(txtRefPersonName, "");
            errorRefPersonMobileNo.SetError(txtRefPersonMobNo, "");
            cmbCompanyCode.Focus();
        }

        #endregion

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
    }
}
