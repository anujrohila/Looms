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

namespace LoomsManagement.Windows.Forms.Master
{
    public partial class frmBrokerMasterView : LoomsManagement.Windows.FormDemoGrid
    {
        #region [Constructor]

        public frmBrokerMasterView()
        {
            InitializeComponent();
            this.Paint += frmBrokerMasterView_Paint;
        }

        #endregion

        #region PageEvent

        void frmBrokerMasterView_Paint(object sender, PaintEventArgs e)
        {
            CommanClass.ShowProcessBar();
            BindGridData();
            CommanClass.HideProcessBar();
        }

        #endregion

        #region Control Event

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var frmBrokerMaster = new frmBrokerMaster();
            frmBrokerMaster.FormClosed += frmBrokerMaster_FormClosed;
            frmBrokerMaster.ShowDialog();
        }

        void frmBrokerMaster_FormClosed(object sender, FormClosedEventArgs e)
        {
            CommanClass.ShowProcessBar();
            UserContext.GetALLtblBrokersMSTDTO();
            BindGridData();
            CommanClass.HideProcessBar();
        }

        private void InnerGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var frmBrokerMaster = new frmBrokerMaster();
                frmBrokerMaster.IsEdit = true;
                frmBrokerMaster.id = Convert.ToInt32(InnerGrid.GetRowCellValue(InnerGrid.FocusedRowHandle, "BrokerID"));
                frmBrokerMaster.FormClosed+=frmBrokerMaster_FormClosed;
                frmBrokerMaster.ShowDialog();
            }
        }

        #endregion 

        #region Private Method

        /// <summary>
        /// Fill all Broker data
        /// </summary>
        private void BindGridData()
        {
            gridBroker.DataSource = UserContext.UserContexttblBrokersMSTDTO;
            InnerGrid.BestFitColumns();
        }

        #endregion

        #region Master Page Event

        private void BtnMasterPrint_Click(object sender, EventArgs e)
        {
            CompositeLink composLink = new CompositeLink(new PrintingSystem());
            PrintableComponentLink pcLink1 = new PrintableComponentLink();
            pcLink1.Component = this.gridBroker;
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
            InnerGrid.ExportToPdf(CommanClass.ExportDataPath + "BrokerMasterDetails.pdf");
            InnerGrid.RestoreLayoutFromXml("tempLayout.xml");
        }

        private void btnMasterExcel_Click(object sender, EventArgs e)
        {
            InnerGrid.SaveLayoutToXml("tempLayout.xml");
            foreach (GridColumn column in InnerGrid.Columns)
            {
                column.Visible = true;
            }
            InnerGrid.ExportToXls(CommanClass.ExportDataPath + "BrokerMasterDetails.xls");
            InnerGrid.RestoreLayoutFromXml("tempLayout.xml");
        }

        #endregion
    }
}
