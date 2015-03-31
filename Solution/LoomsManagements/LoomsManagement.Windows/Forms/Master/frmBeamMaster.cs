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
    public partial class frmBeamMaster : LoomsManagement.Windows.FormDemo1
    {

        #region Variable

        public Boolean IsEdit = false;
        public int id = 0;

        #endregion

        #region Constructor

        public frmBeamMaster()
        {
            InitializeComponent();
            this.Paint += frmBankMaster_Paint;
            btnReport.Visible = false;
        }



        #endregion

        #region Page Event

        void frmBankMaster_Paint(object sender, PaintEventArgs e)
        {
            CommanClass.ShowProcessBar();
            SetFlag();
            //txtBankName.Focus();
            CommanClass.HideProcessBar();
        }

        #endregion

        #region Control Event

        private void btnSave_Click(object sender, EventArgs e)
        {
            //if (!Validation())
            //    return;
            //CommanClass.ShowProcessBar();

            //var tblBeamMSTDTO = new tblBeamMSTDTO();
            //tblBeamMSTDTO.CompanyID = Convert.ToInt32(cmbCompanyCode.EditValue);
            ////tblBeamMSTDTO.WrapperPartyName =  txtWrapperPartyName.Text;
            //tblBeamMSTDTO.IsActive = true;
            //tblBeamMSTDTO.IsDelete = false;

            //if (IsEdit)
            //{
            //    //tblBeamMSTDTO.BankID = id;
            //    tblBeamMSTDTO.UpdateBy = CommanClass.UserId;
            //    tblBeamMSTDTO.UpdationDateTime = DateTime.Now;
            //}
            //else
            //{
            //    //tblBeamMSTDTO.CreateBy = CommanClass.UserId;
            //    tblBeamMSTDTO.CreationDateTime = DateTime.Now;
            //}

            //int ReturnValue = BankBusinessLogic.SaveBank(tblBeamMSTDTO);
            //CommanClass.HideProcessBar();

            //if (ReturnValue == 1)
            //{
            //    errorWrapperPartyName.SetError(txtWrapperPartyName, "Wrapper party name already exists");
            //}
            //else if (ReturnValue == 2)
            //{
            //    // error_companyName.SetError(txt_CompanyName, "Company Name Already Exist");
            //}
            //else
            //{
            //    MessageBox.Show("Data saved successfully.");
            //    ClearData();
            //    if (IsEdit)
            //    {
            //        this.Close();
            //    }
            //}
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to delete this record ?", "Delete Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (BankBusinessLogic.DeleteBank(id) != 0)
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

        #region Key Event

        private void EnterEvent(object sender, EventArgs e)
        {
            CommanClass.EnterEvents(sender, e);
        }

        private void LeaveEvent(object sender, EventArgs e)
        {
            CommanClass.LeaveEvents(sender, e);
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

        # region Private Method

        private void SetFlag()
        {
            if (IsEdit)
            {
                var bankMstData = BankBusinessLogic.GetBankDetails(id);
                //txtBankName.Text = bankMstData.BankName;
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
            ErrorHandlor.SetTextboxErrorWithCount(errorWrapperPartyName, txtWrapperPartyName, "Enter wrapper party name");

            if (ErrorHandlor.count == 0)
                return true;
            else
                return false;
        }

        private void ClearData()
        {
            //Clear data
            //txtBankName.Text = "";

            //Reset BackGround Color
            //txtBankName.BackColor = CommanClass.m_tbcolorleave;

            //Reset error 
            errorWrapperPartyName.SetError(txtWrapperPartyName, "");
           // txtBankName.Focus();

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


    }
}
