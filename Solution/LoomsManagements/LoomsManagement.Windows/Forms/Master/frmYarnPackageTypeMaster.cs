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
    public partial class frmYarnPackageTypeMaster : LoomsManagement.Windows.FormDemo1
    {
        #region Variable

        public Boolean IsEdit = false;
        public int id = 0;

        #endregion

        #region Constrcotr
        public frmYarnPackageTypeMaster()
        {
            InitializeComponent();
            btnReport.Visible = false;
            this.Paint += frmYarnPackageTypeMaster_Paint;
        }

       

       
        #endregion

        #region Page Event

        
        void frmYarnPackageTypeMaster_Paint(object sender, PaintEventArgs e)
        {
            CommanClass.ShowProcessBar();
            SetFlag();
            txtYarnPackageType.Focus();
            CommanClass.HideProcessBar();
        }

        #endregion

        #region Control Event

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!Validation())
                return;
            CommanClass.ShowProcessBar();
            var tblYarnPackageTypeDTO = new tblYarnPackageTypeDTO();
            tblYarnPackageTypeDTO.TypeName = txtYarnPackageType.Text;
            tblYarnPackageTypeDTO.IsActive = true;
            tblYarnPackageTypeDTO.IsDelete = false;

            if (IsEdit)
            {
                tblYarnPackageTypeDTO.YarnPackageTypeID = id;
                tblYarnPackageTypeDTO.UpdatedBy = CommanClass.UserId;
                tblYarnPackageTypeDTO.UpdatedDateTime = DateTime.Now;
            }
            else
            {
                tblYarnPackageTypeDTO.CreatedBy= CommanClass.UserId;
                tblYarnPackageTypeDTO.CreatedDateTime = DateTime.Now;
                
            }
            int ReturnValue = YarnBusinessLogic.SaveYarnPackageType(tblYarnPackageTypeDTO);
            CommanClass.HideProcessBar();
            if (ReturnValue == 1)
            {
                errorYarnPackageType.SetError(txtYarnPackageType, "Yarn Package Type Already Exist.");
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
                if (YarnBusinessLogic.DeleteYarnPackageType(id) != 0)
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
                var yarnPackageType = YarnBusinessLogic.GetYarnPackageTypeDetails(id);
                txtYarnPackageType.Text = yarnPackageType.TypeName;
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
            ErrorHandlor.SetTextboxErrorWithCount(errorYarnPackageType, txtYarnPackageType, "Enter Yarn Package Type");
           
            if (ErrorHandlor.count == 0)
                return true;
            else
                return false;
        }

        private void ClearData()
        {
            //Clear data
            txtYarnPackageType.Text = "";
           

            //Reset BackGround Color
            txtYarnPackageType.BackColor = CommanClass.m_tbcolorleave;
         
            //Reset error 
            errorYarnPackageType.SetError(txtYarnPackageType, "");
            txtYarnPackageType.Focus();

        }

        #endregion

      

    }
}
