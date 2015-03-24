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
    public partial class frmProofMaster : LoomsManagement.Windows.FormDemo1
    {

        #region Variable

        public Boolean IsEdit = false;
        public int id = 0;

        #endregion

        #region Constructor

        public frmProofMaster()
        {
            InitializeComponent();
            btnReport.Visible = false;
            this.Paint += frmProofMaster_Paint;
        }

        
        #endregion

        #region Page Event

        void frmProofMaster_Paint(object sender, PaintEventArgs e)
        {
            CommanClass.ShowProcessBar();
            SetFlag();
            txtProofName.Focus();
            CommanClass.HideProcessBar();
        }

        #endregion

        #region Control Event

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!Validation())
                return;
            CommanClass.ShowProcessBar();

            var tblProfeListMstDTO = new tblProfeListMstDTO();
            tblProfeListMstDTO.Name = txtProofName.Text;
            tblProfeListMstDTO.IsActive = true;
            tblProfeListMstDTO.IsDelete = false;

            if (IsEdit)
            {
                tblProfeListMstDTO.ProfeID = id;
                tblProfeListMstDTO.UpdateBy = CommanClass.UserId;
                tblProfeListMstDTO.UpdateDateTime = DateTime.Now;
            }
            else
            {
                tblProfeListMstDTO.CreatedBy = CommanClass.UserId;
                tblProfeListMstDTO.CreatedDateTime = DateTime.Now;
            }

            int ReturnValue = ProofBusinessLogic.SaveProof(tblProfeListMstDTO);

            if (ReturnValue == 1)
            {
                errorProofName.SetError(txtProofName, "Proof Name already exist");
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
                if (ProofBusinessLogic.DeleteProof(id) != 0)
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

        private void SetFlag()
        {
            if (IsEdit)
            {
                var proofMstData = ProofBusinessLogic.GetProofDetails(id);
                txtProofName.Text = proofMstData.Name;
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
            ErrorHandlor.SetTextboxErrorWithCount(errorProofName, txtProofName, "Enter Proof Name.");

            if (ErrorHandlor.count == 0)
                return true;
            else
                return false;
        }

        private void ClearData()
        {
            //Clear data
            txtProofName.Text = "";
           
            //Reset BackGround Color
            txtProofName.BackColor = CommanClass.m_tbcolorleave;
          

            //Reset error 
            errorProofName.SetError(txtProofName, "");
            txtProofName.Focus();

        }

        #endregion

       

      
    }
}
