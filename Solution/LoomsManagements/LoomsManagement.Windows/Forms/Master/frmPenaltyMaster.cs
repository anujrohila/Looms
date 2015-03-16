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
    public partial class frmPenaltyMaster : LoomsManagement.Windows.FormDemo1
    {

        #region Variable

        public Boolean IsEdit = false;
        public int id = 0;

        #endregion

        #region Constructor
        public frmPenaltyMaster()
        {
            InitializeComponent();
            btnReport.Visible = false;
            this.Paint += frmPenaltyMaster_Paint;
        }

                     
        #endregion

        #region Page Event

        void frmPenaltyMaster_Paint(object sender, PaintEventArgs e)
        {
            CommanClass.ShowProcessBar();
            SetFlag();
            txtPenaltyCode.Focus();
            CommanClass.HideProcessBar();
        }

       #endregion

        #region Control Event

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!Validation())
                return;
             CommanClass.ShowProcessBar();

             var tblPenaltyMSTDTO = new tblPenaltyMSTDTO();
             tblPenaltyMSTDTO.PenaltyCode = txtPenaltyCode.Text;
             tblPenaltyMSTDTO.PenaltyName = txtPenaltyName.Text;
             tblPenaltyMSTDTO.Description = txtDescription.Text;
             tblPenaltyMSTDTO.IsActive = true;
             tblPenaltyMSTDTO.IsDelete = false;

             if (IsEdit)
             {
                 tblPenaltyMSTDTO.PenaltyID = id;
                 tblPenaltyMSTDTO.UpdateBy = CommanClass.UserId;
                 tblPenaltyMSTDTO.UpdationDateTime = DateTime.Now;
             }
             else
             {
                 tblPenaltyMSTDTO.CreateBy = CommanClass.UserId;
                 tblPenaltyMSTDTO.CreationDateTime = DateTime.Now;
             }

             int ReturnValue = EmployeeBusinessLogic.SavePenalty(tblPenaltyMSTDTO);
             CommanClass.HideProcessBar();
             if (ReturnValue == 1)
             {
                 errorPenaltyName.SetError(txtPenaltyName, "Penalty Name Already Exist.");
             }
             else if (ReturnValue == 2)
             {
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
                if (EmployeeBusinessLogic.DeletePenalty(id) != 0)
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

        # region Private Method

        private void SetFlag()
        {
            if (IsEdit)
            {
                var penaltyData = EmployeeBusinessLogic.GetPenaltyDetails(id);
                txtPenaltyCode.Text = penaltyData.PenaltyCode;
                txtPenaltyName.Text = penaltyData.PenaltyName;
                txtDescription.Text = penaltyData.Description;
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
            ErrorHandlor.SetTextboxErrorWithCount(errorPenaltyCode, txtPenaltyCode, "Enter Penalty Code");
            ErrorHandlor.SetTextboxErrorWithCount(errorPenaltyName, txtPenaltyName, "Enter PenaltyName");
          
            if (ErrorHandlor.count == 0)
                return true;
            else
                return false;
        }

        private void ClearData()
        {
            //Clear data
            txtPenaltyCode.Text = "";
            txtDescription.Text = "";
            txtPenaltyName.Text = "";
           

            //Reset BackGround Color
            txtPenaltyCode.BackColor = CommanClass.m_tbcolorleave;
            txtPenaltyName.BackColor = CommanClass.m_tbcolorleave;
            txtDescription.BackColor = CommanClass.m_tbcolorleave;
           

            //Reset error 
            errorPenaltyCode.SetError(txtPenaltyCode, "");
            errorPenaltyName.SetError(txtPenaltyName, "");
            txtPenaltyCode.Focus();

        }

        #endregion
    }
}
