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
    public partial class frmEmployeeTypeMaster : LoomsManagement.Windows.FormDemo1
    {

        #region [Variable]
        public Boolean IsEdit = false;
        public int id = 0;
        #endregion

        #region [Constructor]
        public frmEmployeeTypeMaster()
        {
            InitializeComponent();
            this.Load += frmEmployeeTypeMaster_Load;
        }

        
        #endregion

        #region [Page Event]

        void frmEmployeeTypeMaster_Load(object sender, EventArgs e)
        {
            SetFlag();
            txtEmployeeTypeName.Focus();
        }

        #endregion

        #region  [Control Event]

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!Validation())
                return;

            CommanClass.ShowProcessBar();

            var tblEmployeeTypeMSTDTO = new tblEmployeeTypeMSTDTO();
            tblEmployeeTypeMSTDTO.TypeName = txtEmployeeTypeName.Text;
            tblEmployeeTypeMSTDTO.Description = txtDescription.Text;
            tblEmployeeTypeMSTDTO.CreatedBy = CommanClass.UserId;
            tblEmployeeTypeMSTDTO.CreatedDateTime = DateTime.Now;
            tblEmployeeTypeMSTDTO.IsActive = true;
            tblEmployeeTypeMSTDTO.IsDelete = false;

            if (IsEdit)
            {
                tblEmployeeTypeMSTDTO.EmployeeTypeID = id;
                tblEmployeeTypeMSTDTO.UpdatedBy = CommanClass.UserId;
                tblEmployeeTypeMSTDTO.UpdatedDateTime = DateTime.Now;
            }
            else
            {
                tblEmployeeTypeMSTDTO.CreatedBy = CommanClass.UserId;
                tblEmployeeTypeMSTDTO.CreatedDateTime = DateTime.Now;
            }

            int ReturnValue = EmployeeBusinessLogic.SaveEmployeeType(tblEmployeeTypeMSTDTO);

            CommanClass.HideProcessBar();

            if (ReturnValue == 1)
            {
                errorEmployeeTypeName.SetError(txtEmployeeTypeName, "Employee Type Already Exist");
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
                if (EmployeeBusinessLogic.DeleteEmployeeType(id) != 0)
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

        #endregion

        #region [Private Method]

        private void SetFlag()
        {
            if (IsEdit)
            {
                var employeetypeData = EmployeeBusinessLogic.GetEmployeeTypeDetails(id);
                txtEmployeeTypeName.Text = employeetypeData.TypeName;
                txtDescription.Text = employeetypeData.Description;
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
            ErrorHandlor.SetTextboxErrorWithCount(errorEmployeeTypeName, txtEmployeeTypeName, "Enter Employee Type");
           

            if (ErrorHandlor.count == 0)
                return true;
            else
                return false;
        }

        private void ClearData()
        {
            //Clear data
            txtEmployeeTypeName.Text = "";
            txtDescription.Text = "";

            //Reset BackGround Color
            txtEmployeeTypeName.BackColor = CommanClass.m_tbcolorleave;
            txtDescription.BackColor = CommanClass.m_tbcolorleave;
           

            //Reset error 
            errorEmployeeTypeName.SetError(txtEmployeeTypeName, "");
            txtEmployeeTypeName.Focus();

        }

        #endregion

        #region KeyEvent

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
