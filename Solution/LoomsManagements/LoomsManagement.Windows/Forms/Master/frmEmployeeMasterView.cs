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
    public partial class frmEmployeeMasterView : LoomsManagement.Windows.FormDemoGrid
    {
        #region [Constructor]

        public frmEmployeeMasterView()
        {
            InitializeComponent();
            this.Paint += frmEmployeeMasterView_Paint;
        }

       
        #endregion

        #region [Page Event]

        void frmEmployeeMasterView_Paint(object sender, PaintEventArgs e)
        {
            CommanClass.ShowProcessBar();
            BindGridData();
            CommanClass.HideProcessBar();
        }

        private void frmCompanyView_Activated(object sender, EventArgs e)
        {
            //  BindGridData();
        }

        #endregion

        #region [Control Event]

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var frmEmployeeMaster = new frmEmployeeMaster();
            frmEmployeeMaster.FormClosed += objform_FormClosed;
         
            frmEmployeeMaster.ShowDialog();
        }

        void objform_FormClosed(object sender, FormClosedEventArgs e)
        {
            CommanClass.ShowProcessBar();
            BindGridData();
            CommanClass.HideProcessBar();
        }

        private void InnderGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var frmCompanyMaster = new frmEmployeeMaster();
                frmCompanyMaster.IsEdit = true;
                frmCompanyMaster.id = Convert.ToInt32(InnerGrid.GetRowCellValue(InnerGrid.FocusedRowHandle, "EmployeeID"));
                frmCompanyMaster.FormClosed += objform_FormClosed;
                frmCompanyMaster.ShowDialog();
            }

        }

        #endregion

        #region [Private Method]

        private void BindGridData()
        {
            gridViewCompany.DataSource = EmployeeBusinessLogic.GetAllEmployeeDetails();
            InnerGrid.BestFitColumns();
        }

        #endregion

        #region [Master Page Event]

        private void BtnMasterPrint_Click(object sender, EventArgs e)
        {
            CompositeLink composLink = new CompositeLink(new PrintingSystem());
            PrintableComponentLink pcLink1 = new PrintableComponentLink();
            pcLink1.Component = this.gridViewCompany;
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
            InnerGrid.ExportToPdf(CommanClass.ExportDataPath + "EmployeeDetails.pdf");
            InnerGrid.RestoreLayoutFromXml("tempLayout.xml");
        }

        private void btnMasterExcel_Click(object sender, EventArgs e)
        {
            InnerGrid.SaveLayoutToXml("tempLayout.xml");
            foreach (GridColumn column in InnerGrid.Columns)
            {
                column.Visible = true;
            }
            InnerGrid.ExportToXls(CommanClass.ExportDataPath + "EmployeeDetails.xls");
            InnerGrid.RestoreLayoutFromXml("tempLayout.xml");
        }

        #endregion
    }
}
