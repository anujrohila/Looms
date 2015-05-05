using LoomsManagement.Windows.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LoomsManagement.Windows.Forms
{
    public partial class frmAddPurchaseReturnItem : LoomsManagement.Windows.FromButtonRight
    {
        public frmAddPurchaseReturnItem()
        {
            InitializeComponent();
            btnReport.Visible = false;
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

        private void Page_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == CommanClass.AddButton)
            {
                btnAdd_Click(null, null);
            }
            if (e.Control && e.KeyCode == CommanClass.SaveButton)
            {
                btnSave_Click(null, null);
            }
            else if (btnReport.Enabled == true && e.Control && e.KeyCode == CommanClass.PrintButton)
            {
                btnReport_Click(null, null);
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

        #region Click Event

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmBeamPurchaseItem beamPurchaseItem = new frmBeamPurchaseItem();
            beamPurchaseItem.ShowDialog();
        }


        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btndelete_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {

        }

        #endregion

    }
}
