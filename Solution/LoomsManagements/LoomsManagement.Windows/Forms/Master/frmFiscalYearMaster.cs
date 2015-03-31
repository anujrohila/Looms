using LoomsManagement.BAL;
using LoomsManagement.Domain.DTO;
using LoomsManagement.Windows.Classes;
using System;
using System.Windows.Forms;

namespace LoomsManagement.Windows.Forms.Master
{
    public partial class frmFiscalYearMaster : LoomsManagement.Windows.FormDemo1
    {

        #region [Variable]

        public Boolean IsEdit = false;
        public int id = 0;

        #endregion

        #region [Constructor]

        public frmFiscalYearMaster()
        {
            InitializeComponent();
            btnReport.Visible = false;
            this.Paint += frmFiscalYearMaster_Paint;
        }



        #endregion

        #region [Page Event]


        void frmFiscalYearMaster_Paint(object sender, PaintEventArgs e)
        {
            CommanClass.ShowProcessBar();
            SetFlag();
            dpStartDate.Focus();
            CommanClass.HideProcessBar();
        }

        #endregion

        #region  [Control Event]

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!Validation())
                return;

            CommanClass.ShowProcessBar();

            var tblFiscalYearDTO = new tblFiscalYearDTO();
            tblFiscalYearDTO.StartDate = Convert.ToDateTime(dpStartDate.EditValue);
            tblFiscalYearDTO.EndDate = Convert.ToDateTime(dpEndDate.EditValue);
            tblFiscalYearDTO.FiscalName = string.Format("{0}-{1}", tblFiscalYearDTO.StartDate.Year.ToString().Substring(0, 2), tblFiscalYearDTO.EndDate.Year.ToString().Substring(0, 2));
            tblFiscalYearDTO.IsActive = true;
            tblFiscalYearDTO.IsDelete = false;

            if (IsEdit)
            {
                tblFiscalYearDTO.FiscalYearId = id;
                tblFiscalYearDTO.UpdatedBy = CommanClass.UserId;
                tblFiscalYearDTO.UpdatedDateTime = DateTime.Now;
            }
            else
            {
                tblFiscalYearDTO.CreatedBy = CommanClass.UserId;
                tblFiscalYearDTO.CreatedDateTime = DateTime.Now;

            }

            int ReturnValue = FiscalYearBusinessLogic.SavaFiscalYear(tblFiscalYearDTO);

            CommanClass.HideProcessBar();

            if (ReturnValue == 1)
            {
                errorWrongDate.SetError(dpStartDate, "Fiscal Year already exists.");
            }
            else if (ReturnValue == 2)
            {
                errorWrongDate.SetError(dpStartDate, "Error in transaction please try again later.");
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
                if (CompnayBussinesLogic.DeleteCompanyData(id) != 0)
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

        #region [Private Method]

        private void SetFlag()
        {
            if (IsEdit)
            {
                var fiscalYear = FiscalYearBusinessLogic.GetFiscalYear(id);
                dpStartDate.EditValue = fiscalYear.StartDate;
                dpEndDate.EditValue = fiscalYear.EndDate;
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
            DateTime sDate = Convert.ToDateTime(dpStartDate.EditValue);
            DateTime eDate = Convert.ToDateTime(dpEndDate.EditValue);
            ErrorHandlor.SetErrorCount();
            if (sDate > eDate)
            {
                ErrorHandlor.SetTextboxErrorWithCount(errorWrongDate, dpStartDate, "Please enter valid date start date must be less than end date.");
            }

            if (ErrorHandlor.count == 0)
                return true;
            else
                return false;
        }

        private void ClearData()
        {
            //Clear data
            errorWrongDate.SetError(dpStartDate, "");

            dpStartDate.Focus();

        }

        #endregion

    }
}
