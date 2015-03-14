using DevExpress.XtraGrid.Columns;
using DevExpress.XtraPrinting;
using DevExpress.XtraPrintingLinks;
using LoomsManagement.BAL;
using LoomsManagement.Windows.Classes;
using System;
using System.Windows.Forms;

namespace LoomsManagement.Windows.Forms.Master
{
    public partial class frmYarnTypeMasterView : LoomsManagement.Windows.FormDemoGrid
    {

        #region [Constructor]

        public frmYarnTypeMasterView()
        {
            InitializeComponent();
        }

        #endregion

        #region PageEvent

        #endregion

        #region ControlEvent

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var frmYarnTypeMaster = new frmYarnTypeMaster();
            frmYarnTypeMaster.FormClosed += frmYarnTypeMaster_FormClosed;
            frmYarnTypeMaster.ShowDialog();
        }

        void frmYarnTypeMaster_FormClosed(object sender, FormClosedEventArgs e)
        {
            CommanClass.ShowProcessBar();
            BindGridData();
            CommanClass.HideProcessBar();
        }

        private void InnerGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var frmYarnTypeMaster = new frmYarnTypeMaster();
                frmYarnTypeMaster.IsEdit = true;
                frmYarnTypeMaster.id = Convert.ToInt32(InnerGrid.GetRowCellValue(InnerGrid.FocusedRowHandle, "YarnTypeID"));
                frmYarnTypeMaster.FormClosed+=frmYarnTypeMaster_FormClosed;
                frmYarnTypeMaster.ShowDialog();
            }
        }

        #endregion

        #region Private Method

        /// <summary>
        /// Fill all yarn type data
        /// </summary>
        private void BindGridData()
        {
            gridYarnType.DataSource = YarnTypeBusinessLogic.GetAllYarnTypeDetails();
            InnerGrid.BestFitColumns();
        }

        #endregion

        #region Master Page Event

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnMasterPrint_Click(object sender, EventArgs e)
        {
            CompositeLink composLink = new CompositeLink(new PrintingSystem());
            PrintableComponentLink pcLink1 = new PrintableComponentLink();
            pcLink1.Component = this.gridYarnType;
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
            InnerGrid.ExportToPdf(CommanClass.ExportDataPath + "YarnTypeDetails.pdf");
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
