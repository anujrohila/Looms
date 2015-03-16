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
    public partial class frmEmployeeTypeMasterView : LoomsManagement.Windows.FormDemoGrid
    {
        #region [Constructor]
        public frmEmployeeTypeMasterView()
        {
            InitializeComponent();
        }
        #endregion

        #region [Page Event]
        #endregion

        #region [Control Event]

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var frmEmployeeTypeMaster = new frmEmployeeTypeMaster();
            frmEmployeeTypeMaster.FormClosed += frmEmployeeTypeMaster_FormClosed;
            frmEmployeeTypeMaster.ShowDialog();

        }

        void frmEmployeeTypeMaster_FormClosed(object sender, FormClosedEventArgs e)
        {
            CommanClass.ShowProcessBar();
            UserContext.GetALLEmployeeTypeMSTDTO();
            BindGridData();
            CommanClass.HideProcessBar();

        }

        private void InnerGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var frmEmployeeTypeMaster = new frmEmployeeTypeMaster();
                frmEmployeeTypeMaster.IsEdit = true;
                frmEmployeeTypeMaster.id = Convert.ToInt32(InnerGrid.GetRowCellValue(InnerGrid.FocusedRowHandle, "EmployeeTypeID"));
                frmEmployeeTypeMaster.FormClosed += frmEmployeeTypeMaster_FormClosed;
                frmEmployeeTypeMaster.ShowDialog();
            }
        }

        #endregion

        #region [Private Method]

        private void BindGridData()
        {
            gridViewEmployeeType.DataSource = UserContext.UserContexttblEmployeeTypeMSTDTO;
            InnerGrid.BestFitColumns();
        }
        #endregion

        #region [Master Page Event]

        private void BtnMasterPrint_Click(object sender, EventArgs e)
        {
            CompositeLink composLink = new CompositeLink(new PrintingSystem());
            PrintableComponentLink pcLink1 = new PrintableComponentLink();
            pcLink1.Component = this.gridViewEmployeeType;
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
            InnerGrid.ExportToPdf(CommanClass.ExportDataPath + "EmployeeTypeDetails.pdf");
            InnerGrid.RestoreLayoutFromXml("tempLayout.xml");
        }

        private void btnMasterExcel_Click(object sender, EventArgs e)
        {
            InnerGrid.SaveLayoutToXml("tempLayout.xml");
            foreach (GridColumn column in InnerGrid.Columns)
            {
                column.Visible = true;
            }
            InnerGrid.ExportToXls(CommanClass.ExportDataPath + "EmployeeTypeDetails.xls");
            InnerGrid.RestoreLayoutFromXml("tempLayout.xml");
        }

        #endregion
    }
}
