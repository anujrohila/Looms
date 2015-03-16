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
    public partial class frmPenaltyMasterView : LoomsManagement.Windows.FormDemoGrid
    {

        #region Constructor
        public frmPenaltyMasterView()
        {
            InitializeComponent();
            this.Paint += frmPenaltyMasterView_Paint;
        }

        #endregion

        #region PageEvent

        void frmPenaltyMasterView_Paint(object sender, PaintEventArgs e)
        {
            CommanClass.ShowProcessBar();
            BindGridData();
            CommanClass.HideProcessBar();
        }

        #endregion

        #region ControlEvent

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var frmPenaltyMaster = new frmPenaltyMaster();
            frmPenaltyMaster.FormClosed += frmPenaltyMaster_FormClosed;
            frmPenaltyMaster.ShowDialog();
 
        }

        void frmPenaltyMaster_FormClosed(object sender, FormClosedEventArgs e)
        {
            CommanClass.ShowProcessBar();
            UserContext.GetALLtblPenaltyMSTDTO();
            BindGridData();
            CommanClass.HideProcessBar();
        }

        private void InnerGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var frmPenaltyMaster = new frmPenaltyMaster();
                frmPenaltyMaster.IsEdit = true;
                frmPenaltyMaster.id=Convert.ToInt32(InnerGrid.GetRowCellValue(InnerGrid.FocusedRowHandle,"PenaltyID"));
                frmPenaltyMaster.FormClosed += frmPenaltyMaster_FormClosed;
                frmPenaltyMaster.ShowDialog();
            }
        }

        #endregion

        #region Private Method

        /// <summary>
        /// Fill all Penalty Master data
        /// </summary>
        private void BindGridData()
        {
            gridViewPenaltyMaster.DataSource = UserContext.UserContexttblPenaltyMSTDTO;
            InnerGrid.BestFitColumns();
        }

        #endregion

        #region Master Page Event

        private void BtnMasterPrint_Click(object sender, EventArgs e)
        {
            CompositeLink composLink = new CompositeLink(new PrintingSystem());
            PrintableComponentLink pcLink1 = new PrintableComponentLink();
            pcLink1.Component = this.gridViewPenaltyMaster;
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
            InnerGrid.ExportToPdf(CommanClass.ExportDataPath + "PenaltyMasterDetail.pdf");
            InnerGrid.RestoreLayoutFromXml("tempLayout.xml");
        }

        private void btnMasterExcel_Click(object sender, EventArgs e)
        {
            InnerGrid.SaveLayoutToXml("tempLayout.xml");
            foreach (GridColumn column in InnerGrid.Columns)
            {
                column.Visible = true;
            }
            InnerGrid.ExportToXls(CommanClass.ExportDataPath + "YarnTypeDetails.xls");
            InnerGrid.RestoreLayoutFromXml("tempLayout.xml");
        }

        #endregion

        
    }
}
