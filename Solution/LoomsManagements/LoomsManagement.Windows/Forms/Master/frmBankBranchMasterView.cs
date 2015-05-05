using DevExpress.XtraGrid.Columns;
using DevExpress.XtraPrinting;
using DevExpress.XtraPrintingLinks;
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
    public partial class frmBankBranchMasterView : LoomsManagement.Windows.FormDemoGrid
    {

        #region [Constructor]

        public frmBankBranchMasterView()
        {
            InitializeComponent();
            this.Paint += frmBankBranchMasterView_Paint;
        }

        #endregion

        #region PageEvent

        void frmBankBranchMasterView_Paint(object sender, PaintEventArgs e)
        {
            CommanClass.ShowProcessBar();
            BindGridData();
            CommanClass.HideProcessBar();
        }
        #endregion

        #region ControlEvent

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var frmBankBranchMaster = new frmBankBranchMaster();
            frmBankBranchMaster.FormClosed += frmBankBranchMaster_FormClosed;
            frmBankBranchMaster.ShowDialog();
        }

        void frmBankBranchMaster_FormClosed(object sender, FormClosedEventArgs e)
        {
            CommanClass.ShowProcessBar();
            UserContext.GetALLtblBranchMSTDTO();
            BindGridData();
            CommanClass.HideProcessBar();
        }

        private void InnerGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var frmBankBranchMaster = new frmBankBranchMaster();
                frmBankBranchMaster.IsEdit = true;
                frmBankBranchMaster.id = Convert.ToInt32(InnerGrid.GetRowCellValue(InnerGrid.FocusedRowHandle, "BranchID"));
                frmBankBranchMaster.FormClosed +=frmBankBranchMaster_FormClosed;
                frmBankBranchMaster.ShowDialog();
            }
        }

        #endregion

        #region Private Method

        /// <summary>
        /// Fill all Branch data
        /// </summary>
        private void BindGridData()
        {
            gridViewBranchMaster.DataSource = UserContext.UserContexttblBranchMSTDTO;
            InnerGrid.BestFitColumns();
        }

        #endregion
       
        #region Master Page Event

        private void BtnMasterPrint_Click(object sender, EventArgs e)
        {
            CompositeLink composLink = new CompositeLink(new PrintingSystem());
            PrintableComponentLink pcLink1 = new PrintableComponentLink();
            pcLink1.Component = this.gridViewBranchMaster;
            composLink.Links.Add(pcLink1);
            composLink.ShowPreview();
        }

        private void BtnMasterPDF_Click(object sender, EventArgs e)
        {
            InnerGrid.SaveLayoutToXml("tempLayout.xml");
            foreach (GridColumn column in InnerGrid.Columns)
            {
                // column.Visible = true;
            }
            InnerGrid.ExportToPdf(CommanClass.ExportDataPath + "BranchMasterDetail.pdf");
            InnerGrid.RestoreLayoutFromXml("tempLayout.xml");
        }

        private void btnMasterExcel_Click(object sender, EventArgs e)
        {
            InnerGrid.SaveLayoutToXml("tempLayout.xml");
            foreach (GridColumn column in InnerGrid.Columns)
            {
                column.Visible = true;
            }
            InnerGrid.ExportToXls(CommanClass.ExportDataPath + "BranchMasterDetail.xls");
            InnerGrid.RestoreLayoutFromXml("tempLayout.xml");
        }


        #endregion

    }
}
