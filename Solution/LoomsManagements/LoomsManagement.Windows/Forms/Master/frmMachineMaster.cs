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
    public partial class frmMachineMaster : LoomsManagement.Windows.FormDemo1
    {
        #region Variable

        public Boolean IsEdit = false;
        public int id = 0;

        #endregion

        #region Constructor
        
        public frmMachineMaster()
        {
            InitializeComponent();
            btnReport.Visible = false;
            this.Paint += frmMachineMaster_Paint;
        }

        

        #endregion

        #region Page Event

        void frmMachineMaster_Paint(object sender, PaintEventArgs e)
        {
            CommanClass.ShowProcessBar();
            SetFlag();
            LoadMachineTypeName();
            cmbMachineType.Focus();
            CommanClass.HideProcessBar();
        }

       
        #endregion

        #region Control Event

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!Validation())
                return;
            CommanClass.ShowProcessBar();

            var tblMachineMSTDTO = new tblMachineMSTDTO();
            tblMachineMSTDTO.MachineTypeID = Convert.ToInt32(cmbMachineType.EditValue);
            tblMachineMSTDTO.MachineName = txtMachineName.Text;
            tblMachineMSTDTO.AboutMachine = txtDescription.Text;
            tblMachineMSTDTO.IsActive = true;
            tblMachineMSTDTO.IsDelete = false;
            if (IsEdit)
            {
                tblMachineMSTDTO.MachineID = id;
                tblMachineMSTDTO.UpdatedBy = CommanClass.UserId;
                tblMachineMSTDTO.UpdatedDateTime = DateTime.Now;
            }
            else
            {
                tblMachineMSTDTO.CreatedBy = CommanClass.UserId;
                tblMachineMSTDTO.CreatedDateTime = DateTime.Now;
            }

            int ReturnValue = MachineBusinessLogic.SavaMachine(tblMachineMSTDTO);
            CommanClass.HideProcessBar();

            if (ReturnValue == 1)
            {
                errorMachineName.SetError(txtMachineName, "Machine Name is already exist.");
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
                if (MachineBusinessLogic.DeleteMachine(id) != 0)
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

        private void LoadMachineTypeName()
        {
            cmbMachineType.Properties.DataSource = UserContext.UserContexttblMachineTypeMSTDTO;
            cmbMachineType.Properties.ValueMember = "MachineTypeID";
            cmbMachineType.Properties.DisplayMember = "TypeName";
        }

        private void SetFlag()
        {
            if (IsEdit)
            {
                var machineMst = MachineBusinessLogic.GetMachineDetails(id);
                cmbMachineType.EditValue = machineMst.MachineTypeID;
                txtMachineName.Text = machineMst.MachineName;
                txtDescription.Text = machineMst.AboutMachine;
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
            ErrorHandlor.SetLookUPErrorWithCount(errorMachineType, cmbMachineType, "Select Machine Type");
            ErrorHandlor.SetTextboxErrorWithCount(errorMachineName, txtMachineName, "Enter Machine Name");
           
           if (ErrorHandlor.count == 0)
                return true;
            else
                return false;
        }

        private void ClearData()
        {
            //Clear data
            cmbMachineType.EditValue = 0;
            txtMachineName.Text = "";
            txtDescription.Text = "";
           
            //Reset BackGround Color
            cmbMachineType.BackColor = CommanClass.m_tbcolorleave;
            txtMachineName.BackColor = CommanClass.m_tbcolorleave;
            txtDescription.BackColor = CommanClass.m_tbcolorleave;
           
            //Reset error 
            errorMachineType.SetError(cmbMachineType, "");
            errorMachineName.SetError(txtMachineName, "");
            cmbMachineType.Focus();

        }

        #endregion 

     }
}
