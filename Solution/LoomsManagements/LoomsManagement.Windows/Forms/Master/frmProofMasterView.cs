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
    public partial class frmProofMasterView : LoomsManagement.Windows.FormDemoGrid
    {

        #region [Constructor]

        public frmProofMasterView()
        {
            InitializeComponent();
            this.Paint += frmProofMasterView_Paint;
        }

        #endregion

        #region PageEvent

        void frmProofMasterView_Paint(object sender, PaintEventArgs e)
        {
            CommanClass.ShowProcessBar();
            BindGridData();
            CommanClass.HideProcessBar();
        }

        #endregion

        #region Control Event       

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var frmProofMaster = new frmProofMaster();
            frmProofMaster.FormClosed += frmProofMaster_FormClosed;
            frmProofMaster.ShowDialog();
        }

        void frmProofMaster_FormClosed(object sender, FormClosedEventArgs e)
        {
            CommanClass.ShowProcessBar();
            UserContext.GetALLtblProofMSTDTO();
            BindGridData();
            CommanClass.HideProcessBar();
        }

        private void InnerGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var frmProofMaster = new frmProofMaster();
                frmProofMaster.IsEdit = true;
                frmProofMaster.id = Convert.ToInt32(InnerGrid.GetRowCellValue(InnerGrid.FocusedRowHandle, "ProfeID"));
                frmProofMaster.FormClosed += frmProofMaster_FormClosed;
                frmProofMaster.ShowDialog();
            }
        }

        #endregion
             
        #region Private Method

        /// <summary>
        /// Fill all Proof Master data
        /// </summary>
        private void BindGridData()
        {
            gridProofMaster.DataSource = UserContext.UserContexttblProofMSTDTO;
            InnerGrid.BestFitColumns();
        }

        #endregion

        #region Master Page Event

        private void BtnMasterPrint_Click(object sender, EventArgs e)
        {
            CompositeLink composLink = new CompositeLink(new PrintingSystem());
            PrintableComponentLink pcLink1 = new PrintableComponentLink();
            pcLink1.Component = this.gridProofMaster;
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
            InnerGrid.ExportToPdf(CommanClass.ExportDataPath + "ProofMasterDetails.pdf");
            InnerGrid.RestoreLayoutFromXml("tempLayout.xml");
        }

        private void btnMasterExcel_Click(object sender, EventArgs e)
        {
            InnerGrid.SaveLayoutToXml("tempLayout.xml");
            foreach (GridColumn column in InnerGrid.Columns)
            {
                column.Visible = true;
            }
            InnerGrid.ExportToXls(CommanClass.ExportDataPath + "ProofMasterDetails.xls");
            InnerGrid.RestoreLayoutFromXml("tempLayout.xml");
        }

        #endregion

    }
}
