using LoomsManagement.BAL;
using LoomsManagement.Windows.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using LoomsManagement.Domain.DTO;

namespace LoomsManagement.Windows.Forms.Master
{
    public partial class frmYarnTypeMaster : LoomsManagement.Windows.FromButtonRight
    {
        #region Variable

        public Boolean IsEdit = false;
        public int id = 0;

        #endregion

        #region Constructor
        public frmYarnTypeMaster()
        {
            InitializeComponent();
             btnReport.Visible = false;
            this.Paint += frmYarnTypeMaster_Paint;
        }

       

        #endregion

        #region Page Event

        void frmYarnTypeMaster_Paint(object sender, PaintEventArgs e)
        {
            CommanClass.ShowProcessBar();
            SetFlag();
            LoadYarnQuality();
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
            var tblYarnTypeDTO = new tblYarnTypeMSTDTO();
            tblYarnTypeDTO.YarnTypeName = txtYarnQualityName.Text;
            tblYarnTypeDTO.YarnQualityID = Convert.ToInt32(cmbYarnQuality.EditValue);
            tblYarnTypeDTO.Denier = txtDenier.Text;
            tblYarnTypeDTO.Description = txtDescription.Text;
            tblYarnTypeDTO.NumberOfFilaments = Convert.ToInt32(txtNumberOfFilaments.Text);
            tblYarnTypeDTO.IsActive = true;
            tblYarnTypeDTO.IsDelete = false;

            if (IsEdit)
            {
                tblYarnTypeDTO.YarnTypeID = id;
                tblYarnTypeDTO.UpdateBy = CommanClass.UserId;
                tblYarnTypeDTO.UpdationDateTime = DateTime.Now;
            }
            else
            {
                tblYarnTypeDTO.CreateBy = CommanClass.UserId;
                tblYarnTypeDTO.CreationDateTIme = DateTime.Now;
            }

            int ReturnValue = YarnBusinessLogic.SaveYarnType(tblYarnTypeDTO);
            CommanClass.HideProcessBar();

            if (ReturnValue == 1)
            {
                errorYarnTypeName.SetError(txtYarnQualityName, "Yarn Type Already Exist");
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
                if (YarnBusinessLogic.DeleteYarnType(id) != 0)
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

        private void btnReport_Click(object sender, EventArgs e)
        {

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

        private void LoadYarnQuality()
        {
            cmbYarnQuality.Properties.DataSource = UserContext.UserContexttblYarnQualityMSTDTO;
            cmbYarnQuality.Properties.ValueMember = "YarnQualityID";
            cmbYarnQuality.Properties.DisplayMember = "YarnQualityName";
        }
           
        private void SetFlag()
        {
            if (IsEdit)
            {
                var yarnTypeData = YarnBusinessLogic.GetYarnTypeDetails(id);
                txtYarnQualityName.Text = yarnTypeData.YarnTypeName;
                cmbYarnQuality.EditValue = yarnTypeData.YarnQualityID;
                txtDenier.Text = yarnTypeData.Denier;
                txtNumberOfFilaments.Text = (Convert.ToInt32(yarnTypeData.NumberOfFilaments).ToString());
                txtDescription.Text = yarnTypeData.Description;
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
            ErrorHandlor.SetTextboxErrorWithCount(errorYarnTypeName, txtYarnQualityName, "Enter Yarn Type");
            ErrorHandlor.SetLookUPErrorWithCount(errorYarnQuality, cmbYarnQuality, "Select Yarn Quality");
            ErrorHandlor.SetTextboxErrorWithCount(errorDenier,txtDenier,"Enter Denier");
            ErrorHandlor.SetTextboxErrorWithCount(errorNumberOfFilamets, txtNumberOfFilaments, "Enter Number Of Filaments");


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
            txtDenier.Text = "";
            txtNumberOfFilaments.Text = "";
            cmbYarnQuality.EditValue = 0;

            //Reset BackGround Color
            txtYarnQualityName.BackColor = CommanClass.m_tbcolorleave;
            txtDescription.BackColor = CommanClass.m_tbcolorleave;
            txtDenier.BackColor = CommanClass.m_tbcolorleave;
            txtNumberOfFilaments.BackColor = CommanClass.m_tbcolorleave;
            cmbYarnQuality.BackColor = CommanClass.m_tbcolorleave;


            //Reset error 
            errorYarnTypeName.SetError(txtYarnQualityName, "");
            errorYarnTypeName.SetError(cmbYarnQuality, "");
            errorYarnTypeName.SetError(txtDenier, "");
            errorYarnTypeName.SetError(txtNumberOfFilaments, "");
            errorYarnTypeName.SetError(txtDescription, "");
            txtYarnQualityName.Focus();

        }

        #endregion 

     }
}
