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
    public partial class frmMachineTypeMasterView : LoomsManagement.Windows.FormDemoGrid
    {

        #region [Constructor]

        public frmMachineTypeMasterView()
        {
            InitializeComponent();
        }

        #endregion

        #region PageEvent

        #endregion


        #region ControlEvent

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var frmMachineTypeMaster = new frmMachineTypeMaster();
            frmMachineTypeMaster.FormClosed += frmMachineTypeMaster_FormClosed;
            frmMachineTypeMaster.ShowDialog();
        }

        void frmMachineTypeMaster_FormClosed(object sender, FormClosedEventArgs e)
        {
            CommanClass.ShowProcessBar();
            BindGridData();
            CommanClass.HideProcessBar();
        }

        private void InnerGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var frmMachineTypeMaster = new frmMachineTypeMaster();
                frmMachineTypeMaster.IsEdit = true;
                frmMachineTypeMaster.id = Convert.ToInt32(InnerGrid.GetRowCellValue(InnerGrid.FocusedRowHandle, "YarnTypeID"));
                frmMachineTypeMaster.FormClosed +=frmMachineTypeMaster_FormClosed;
                frmMachineTypeMaster.ShowDialog();
            }
        }


        #endregion

        #region Private Method

        /// <summary>
        /// Fill all Machine type data
        /// </summary>
        private void BindGridData()
        {
            gridMachineType.DataSource = MachineTypeBusinessLogic.GetAllMachineTypeDate();
            InnerGrid.BestFitColumns();
        }

        #endregion

      

       
        #region Master Page Event

        private void BtnMasterPrint_Click(object sender, EventArgs e)
        {
            CompositeLink composLink = new CompositeLink(new PrintingSystem());
            PrintableComponentLink pcLink1 = new PrintableComponentLink();
            pcLink1.Component = this.gridMachineType;
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
            InnerGrid.ExportToPdf(CommanClass.ExportDataPath + "MachineTypeDetails.pdf");
            InnerGrid.RestoreLayoutFromXml("tempLayout.xml");
        }

        private void btnMasterExcel_Click(object sender, EventArgs e)
        {
            InnerGrid.SaveLayoutToXml("tempLayout.xml");
            foreach (GridColumn column in InnerGrid.Columns)
            {
                column.Visible = true;
            }
            InnerGrid.ExportToXls(CommanClass.ExportDataPath + "MachineTypeDetails.xls");
            InnerGrid.RestoreLayoutFromXml("tempLayout.xml");
        }

        #endregion

       
    }
}
