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
    public partial class frmBankBranchMaster : LoomsManagement.Windows.FormDemo1
    {

        #region Variable

        public Boolean IsEdit = false;
        public int id = 0;

        #endregion

        #region Constructor
        public frmBankBranchMaster()
        {
            InitializeComponent();
            btnReport.Visible = false;
            this.Paint += frmBankBranchMaster_Paint;
        }


        #endregion

        #region Page Event
      
        void frmBankBranchMaster_Paint(object sender, PaintEventArgs e)
        {
            CommanClass.ShowProcessBar();
            LoadBankName();
            SetFlag();
             cmbBankName.Focus();
            CommanClass.HideProcessBar();
        }
        #endregion

        #region Control Event

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!Validation())
                return;
            CommanClass.ShowProcessBar();

            var tblBranchMSTDTO = new tblBranchMSTDTO();
            tblBranchMSTDTO.BankID = Convert.ToInt32(cmbBankName.EditValue);
            tblBranchMSTDTO.BranchName = txtBranchName.Text;
            tblBranchMSTDTO.Address = txtAddress.Text;
            tblBranchMSTDTO.IsActive = true;
            tblBranchMSTDTO.IsDelete = false;

            if (IsEdit)
            {
                tblBranchMSTDTO.BranchID = id;
                tblBranchMSTDTO.UpdateBy = CommanClass.UserId;
                tblBranchMSTDTO.UpdationDateTime = DateTime.Now;
            }
            else
            {
                tblBranchMSTDTO.CreateBy = CommanClass.UserId;
                tblBranchMSTDTO.CreationDateTime = DateTime.Now;
            }

            int ReturnValue = BankBusinessLogic.SaveBranch(tblBranchMSTDTO);
            CommanClass.HideProcessBar();

            if (ReturnValue == 1)
            {
                errorBranchName.SetError(txtBranchName, "Branch Name already Exist");
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
                if (BankBusinessLogic.DeleteBranch(id) != 0)
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
            cmbBankName.Properties.DataSource = UserContext.UserContexttblBankMSTDTO;
            cmbBankName.Properties.ValueMember = "BankID";
            cmbBankName.Properties.DisplayMember = "BankName";
        }

        private void SetFlag()
        {
            if (IsEdit)
            {
                var branchData = BankBusinessLogic.GetBranchDetails(id);
                cmbBankName.EditValue = branchData.BankID;
                txtBranchName.Text = branchData.BranchName;
                txtAddress.Text = branchData.Address;
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
            ErrorHandlor.SetLookUPErrorWithCount(errorBankName, cmbBankName, "Select Bank Name");
            ErrorHandlor.SetTextboxErrorWithCount(errorBranchName, txtBranchName, "Enter Branch Name");
            ErrorHandlor.SetMemoEditErrorWithCount(errorAddress, txtAddress, "Enter Branch Address");
            
            if (ErrorHandlor.count == 0)
                return true;
            else
                return false;
        }

        private void ClearData()
        {
            //Clear data
            cmbBankName.EditValue = 0;
            txtBranchName.Text = "";
            txtAddress.Text = "";
           

            //Reset BackGround Color
            cmbBankName.BackColor = CommanClass.m_tbcolorleave;
            txtBranchName.BackColor = CommanClass.m_tbcolorleave;
            txtAddress.BackColor = CommanClass.m_tbcolorleave;
           

            //Reset error 
            errorBankName.SetError(cmbBankName, "");
            errorBankName.SetError(txtBranchName, "");
            errorAddress.SetError(txtAddress, "");
            cmbBankName.Focus();

        }

        #endregion        
    }
}
