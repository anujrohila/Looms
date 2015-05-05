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
    public partial class frmYarnPackageTypeMasterView : LoomsManagement.Windows.FormDemoGrid
    {
        #region Constructor
        public frmYarnPackageTypeMasterView()
        {
            InitializeComponent();
            this.Paint += frmYarnPackageTypeMasterView_Paint;
        }

        #endregion

        # region Page Event

        void frmYarnPackageTypeMasterView_Paint(object sender, PaintEventArgs e)
        {
            CommanClass.ShowProcessBar();
            BindDataGrid();
            CommanClass.HideProcessBar();
        }

        #endregion

        # region Control Event

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var frmYarnPackageTypeMaster = new frmYarnPackageTypeMaster();
            frmYarnPackageTypeMaster.FormClosed += frmYarnPackageTypeMaster_FormClosed;
            frmYarnPackageTypeMaster.ShowDialog();
        }

        void frmYarnPackageTypeMaster_FormClosed(object sender, FormClosedEventArgs e)
        {
            CommanClass.ShowProcessBar();
            UserContext.GetALLtblYarnPackageTypeDTO();
            BindDataGrid();
            CommanClass.HideProcessBar();
        }

        private void InnerGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var frmYarnPackageTypeMaster = new frmYarnPackageTypeMaster();
                frmYarnPackageTypeMaster.IsEdit=true;
                frmYarnPackageTypeMaster.id=Convert.ToInt32(InnerGrid.GetRowCellValue(InnerGrid.FocusedRowHandle,"YarnPackageTypeID"));
                frmYarnPackageTypeMaster.FormClosed+=frmYarnPackageTypeMaster_FormClosed;
                frmYarnPackageTypeMaster.ShowDialog();
            }
        }

        #endregion

        #region Private Method

        private void BindDataGrid()
        {
            gridViewYarnPackageType.DataSource = UserContext.UserContexttblYarnPackageTypeDTO;
            InnerGrid.BestFitColumns();
        }

        #endregion

        #region Master Page Event

        private void BtnMasterPrint_Click(object sender, EventArgs e)
        {
            CompositeLink composLink = new CompositeLink(new PrintingSystem());
            PrintableComponentLink pcLink1 = new PrintableComponentLink();
            pcLink1.Component = this.gridViewYarnPackageType;
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
            InnerGrid.ExportToPdf(CommanClass.ExportDataPath + "YarnPackageTypeDetails.pdf");
            InnerGrid.RestoreLayoutFromXml("tempLayout.xml");
        }

        private void btnMasterExcel_Click(object sender, EventArgs e)
        {
            InnerGrid.SaveLayoutToXml("tempLayout.xml");
            foreach (GridColumn column in InnerGrid.Columns)
            {
                column.Visible = true;
            }
            InnerGrid.ExportToXls(CommanClass.ExportDataPath + "YarnPackageTypeDetails.xls");
            InnerGrid.RestoreLayoutFromXml("tempLayout.xml");
        }

        #endregion

       

    }
}
