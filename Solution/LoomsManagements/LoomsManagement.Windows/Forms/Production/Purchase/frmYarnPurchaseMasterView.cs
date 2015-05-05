using DevExpress.XtraGrid.Columns;
using DevExpress.XtraPrinting;
using DevExpress.XtraPrintingLinks;
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
    public partial class frmYarnPurchaseMasterView : LoomsManagement.Windows.FormDemoGrid
    {

        #region [Constructor]

        public frmYarnPurchaseMasterView()
        {
            InitializeComponent();
            this.Paint += frmPurchaseMasterView_Paint;
        }

        #endregion

        #region PageEvent

        void frmPurchaseMasterView_Paint(object sender, PaintEventArgs e)
        {
            CommanClass.ShowProcessBar();
            BindGridData();
            CommanClass.HideProcessBar();
        }
        #endregion

        #region ControlEvent

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var frmYarnPurchaseMaster = new frmYarnPurchaseMaster();
            frmYarnPurchaseMaster.FormClosed += frmYarnPurchaseMaster_FormClosed;
            frmYarnPurchaseMaster.ShowDialog();
        }

        void frmYarnPurchaseMaster_FormClosed(object sender, FormClosedEventArgs e)
        {
            CommanClass.ShowProcessBar();
            UserContext.GetALLtblYarnPurchaseDTO();
            BindGridData();
            CommanClass.HideProcessBar();
        }

        private void InnerGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var frmYarnPurchaseMaster = new frmYarnPurchaseMaster();
                frmYarnPurchaseMaster.IsEdit = true;
                frmYarnPurchaseMaster.id = Convert.ToInt32(InnerGrid.GetRowCellValue(InnerGrid.FocusedRowHandle, "PurchaseID"));
                frmYarnPurchaseMaster.FormClosed += frmYarnPurchaseMaster_FormClosed;
                frmYarnPurchaseMaster.ShowDialog();
            }
        }

        #endregion

        #region Private Method

        /// <summary>
        /// Fill all Yarn Purchase
        /// </summary>
        private void BindGridData()
        {
            gridPurchaseMasterView.DataSource = UserContext.UserContexttblYarnPurchaseDTO;
            InnerGrid.BestFitColumns();
        }

        #endregion 

        #region Master Page Event

        private void BtnMasterPrint_Click(object sender, EventArgs e)
        {
            CompositeLink composLink = new CompositeLink(new PrintingSystem());
            PrintableComponentLink pcLink1 = new PrintableComponentLink();
            pcLink1.Component = this.gridPurchaseMasterView;
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
            InnerGrid.ExportToPdf(CommanClass.ExportDataPath + "PurchaseMasterDetails.pdf");
            InnerGrid.RestoreLayoutFromXml("tempLayout.xml");
        }

        private void btnMasterExcel_Click(object sender, EventArgs e)
        {
            InnerGrid.SaveLayoutToXml("tempLayout.xml");
            foreach (GridColumn column in InnerGrid.Columns)
            {
                column.Visible = true;
            }
            InnerGrid.ExportToXls(CommanClass.ExportDataPath + "PurchaseMasterDetails.xls");
            InnerGrid.RestoreLayoutFromXml("tempLayout.xml");
        }

        #endregion
    }
}
