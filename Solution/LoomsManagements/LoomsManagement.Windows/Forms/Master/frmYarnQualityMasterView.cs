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
    public partial class frmYarnQualityMasterView : LoomsManagement.Windows.FormDemoGrid
    {

        #region Constructor
        public frmYarnQualityMasterView()
        {
            InitializeComponent();
        }
        #endregion

        #region Page Event
        #endregion

        #region Control Event

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var frmYarnQualityMaster = new frmYarnQualityMaster();
            frmYarnQualityMaster.FormClosed += frmYarnQualityMaster_FormClosed;
            frmYarnQualityMaster.ShowDialog();
        }

        void frmYarnQualityMaster_FormClosed(object sender, FormClosedEventArgs e)
        {
            CommanClass.ShowProcessBar();
            BindGridData();
            CommanClass.HideProcessBar();
        }

        private void InnerGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var frmYarnQualityMaster = new frmYarnQualityMaster();
                frmYarnQualityMaster.IsEdit = true;
                frmYarnQualityMaster.id = Convert.ToInt32(InnerGrid.GetRowCellValue(InnerGrid.FocusedRowHandle, "YarnQualityID"));
                frmYarnQualityMaster.FormClosed+=frmYarnQualityMaster_FormClosed;
                frmYarnQualityMaster.ShowDialog();
            }
        }

        #endregion

        #region Private Method

        private void BindGridData()
        {
            gridViewYarnQualityMaster.DataSource = YarnQualityMasterBusinessLogic.GetAllYarnQualityDetails();
            InnerGrid.BestFitColumns();
        }

        #endregion

        #region Master Page Event

        private void BtnMasterPrint_Click(object sender, EventArgs e)
        {
            CompositeLink composLink = new CompositeLink(new PrintingSystem());
            PrintableComponentLink pcLink1 = new PrintableComponentLink();
            pcLink1.Component = this.gridViewYarnQualityMaster;
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
            InnerGrid.ExportToPdf(CommanClass.ExportDataPath + "YarnQualityDetails.pdf");
            InnerGrid.RestoreLayoutFromXml("tempLayout.xml");
        }

        private void btnMasterExcel_Click(object sender, EventArgs e)
        {
            InnerGrid.SaveLayoutToXml("tempLayout.xml");
            foreach (GridColumn column in InnerGrid.Columns)
            {
                column.Visible = true;
            }
            InnerGrid.ExportToXls(CommanClass.ExportDataPath + "YarnQualityDetails.xls");
            InnerGrid.RestoreLayoutFromXml("tempLayout.xml");
        }

        #endregion

      

    }
}
