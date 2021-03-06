﻿using LoomsManagement.BAL;
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
    public partial class frmYarnQualityMaster : LoomsManagement.Windows.FromButtonRight
    {
        #region Variable

        public Boolean IsEdit = false;
        public int id = 0;

        #endregion


        #region Constructor

        public frmYarnQualityMaster()
        {
            InitializeComponent();
            btnReport.Visible = false;
            this.Paint += frmYarnQualityMaster_Paint;
        }

        #endregion

        #region Page Event

        void frmYarnQualityMaster_Paint(object sender, PaintEventArgs e)
        {
            CommanClass.ShowProcessBar();
            SetFlag();
            txtYarnQualityName.Focus();
            CommanClass.HideProcessBar();
        }

        #endregion

        #region Control Event

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (!Validation())
                return;
            CommanClass.ShowProcessBar();
            var YarnQualityMstDTO = new tblYarnQualityMSTDTO();
            YarnQualityMstDTO.YarnQualityName = txtYarnQualityName.Text;
            YarnQualityMstDTO.Description = txtDescription.Text;
            YarnQualityMstDTO.IsActive = true;
            YarnQualityMstDTO.IsDelete = false;

            if (IsEdit)
            {
                YarnQualityMstDTO.YarnQualityID = id;
                YarnQualityMstDTO.UpdateBy = CommanClass.UserId;
                YarnQualityMstDTO.UpdationDateTime = DateTime.Now;
            }
            else
            {
                YarnQualityMstDTO.CreateBy = CommanClass.UserId;
                YarnQualityMstDTO.CreationDateTime = DateTime.Now;
            }

            int ReturnValue = YarnBusinessLogic.SavaYarnQuality(YarnQualityMstDTO);
            CommanClass.HideProcessBar();
            if (ReturnValue == 1)
            {
                errorYarnQualityName.SetError(txtYarnQualityName, "Yarn Quality Name Already Exists.");
            }
            else if (ReturnValue == 2)
            {
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
                if (YarnBusinessLogic.DeleteYarnQuality(id) != 0)
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
                var yarnQualityMst = YarnBusinessLogic.GetYarnQualityDetails(id);
                txtYarnQualityName.Text = yarnQualityMst.YarnQualityName;
                txtDescription.Text = yarnQualityMst.Description;
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
            ErrorHandlor.SetTextboxErrorWithCount(errorYarnQualityName, txtYarnQualityName, "Enter Yarn Quality Name");

            if (ErrorHandlor.count == 0)
                return true;
            else
                return false;
        }

        private void ClearData()
        {
            //Clear data
            txtYarnQualityName.Text = "";
            txtDescription.Text = "";


            //Reset BackGround Color
            txtYarnQualityName.BackColor = CommanClass.m_tbcolorleave;
            txtDescription.BackColor = CommanClass.m_tbcolorleave;



            //Reset error 
            errorYarnQualityName.SetError(txtYarnQualityName, "");
            txtYarnQualityName.Focus();

        }

        #endregion

      

       

       
    }
}
