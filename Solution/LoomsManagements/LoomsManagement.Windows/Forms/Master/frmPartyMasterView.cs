using LoomsManagement.BAL;
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
    public partial class frmPartyMasterView : LoomsManagement.Windows.FormDemoGrid
    {
        #region Constractor
        public frmPartyMasterView()
        {
            InitializeComponent();
           
        }
        #endregion

        #region Page Event
       
        #endregion

        #region Control Event

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var frmPartyMaster = new frmPartyMaster();
            frmPartyMaster.FormClosed += frmPartyMaster_FormClosed;
            frmPartyMaster.ShowDialog();
        }

        void frmPartyMaster_FormClosed(object sender, FormClosedEventArgs e)
        {
            CommanClass.ShowProcessBar();
            UserContext.GetALLtblPartysMSTDTO();
            BindGridData();
            CommanClass.HideProcessBar();
        }

        private void InnerGrid_KeyDown(object sender, KeyEventArgs e)
        {
            var frmPartyMaster = new frmPartyMaster();
            frmPartyMaster.IsEdit = true;
            frmPartyMaster.id = Convert.ToInt32(InnerGrid.GetRowCellValue(InnerGrid.FocusedRowHandle, "PartyID"));
            frmPartyMaster.FormClosed+=frmPartyMaster_FormClosed;
            frmPartyMaster.ShowDialog();
        }

        #endregion

        #region Private method

        private void BindGridData()
        {
            gridViewCompany.DataSource = UserContext.UserContexttblPartysMSTDTO;
            InnerGrid.BestFitColumns();
        }

        #endregion

        #region Master Page Event

        private void BtnMasterPrint_Click(object sender, EventArgs e)
        {

        }

        private void BtnMasterPDF_Click(object sender, EventArgs e)
        {

        }

        private void btnMasterExcel_Click(object sender, EventArgs e)
        {

        }

        #endregion

       

    }
}
