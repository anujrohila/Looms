using DevExpress.XtraGrid.Columns;
using DevExpress.XtraPrinting;
using DevExpress.XtraPrintingLinks;
using DevExpress.XtraSplashScreen;
using LoomsManagement.BAL;
using LoomsManagement.Windows.Classes;
using System;
using System.Windows.Forms;

namespace LoomsManagement.Windows.Forms.Master
{
    public partial class frmFiscalYearView : LoomsManagement.Windows.FormDemoGrid
    {

        #region [Constructor]

        public frmFiscalYearView()
        {
            InitializeComponent();
            this.Paint += frmFiscalYearView_Paint; 
        }

        void frmFiscalYearView_Paint(object sender, EventArgs e)
        {
            CommanClass.ShowProcessBar();
            BindGridData();
            CommanClass.HideProcessBar();
        }

        #endregion

        #region [Page Event]

        private void frmFiscalYearView_Activated(object sender, EventArgs e)
        {
            //BindGridData();
        }

        #endregion

        #region [Control Event]

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var frmCompanyMaster = new frmCompanyMaster();
            frmCompanyMaster.FormClosed += objform_FormClosed;
            frmCompanyMaster.ShowDialog();
        }

        void objform_FormClosed(object sender, FormClosedEventArgs e)
        {
            CommanClass.ShowProcessBar();
            UserContext.GetALLtblFiscalYearDTO();
            BindGridData();
            CommanClass.HideProcessBar();
        }

        private void InnderGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var frmCompanyMaster = new frmCompanyMaster();
                frmCompanyMaster.IsEdit = true;
                frmCompanyMaster.id = Convert.ToInt32(InnerGrid.GetRowCellValue(InnerGrid.FocusedRowHandle, "CompanyID"));
                frmCompanyMaster.FormClosed += objform_FormClosed;
                frmCompanyMaster.ShowDialog();
            }

        }

        #endregion

        #region [Private Method]

        private void BindGridData()
        {
            gridViewFiscalYear.DataSource = UserContext.UserContexttblFiscalYearDTO;
            InnerGrid.BestFitColumns();
        }

        #endregion

        #region [Master Page Event]

        private void BtnMasterPrint_Click(object sender, EventArgs e)
        {
            CompositeLink composLink = new CompositeLink(new PrintingSystem());
            PrintableComponentLink pcLink1 = new PrintableComponentLink();
            pcLink1.Component = this.gridViewFiscalYear;
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
            InnerGrid.ExportToPdf(CommanClass.ExportDataPath + "CompanyDetails.pdf");
            InnerGrid.RestoreLayoutFromXml("tempLayout.xml");
        }

        private void btnMasterExcel_Click(object sender, EventArgs e)
        {
            InnerGrid.SaveLayoutToXml("tempLayout.xml");
            foreach (GridColumn column in InnerGrid.Columns)
            {
                column.Visible = true;
            }
            InnerGrid.ExportToXls(CommanClass.ExportDataPath + "CompanyDetails.xls");
            InnerGrid.RestoreLayoutFromXml("tempLayout.xml");
        }

        #endregion

    }
}
