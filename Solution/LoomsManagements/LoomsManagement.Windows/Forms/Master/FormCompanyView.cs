using LoomsManagement.BAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraPrinting;
using DevExpress.XtraGrid.Columns;
using DaryInventory.Classes;
using DevExpress.XtraPrintingLinks;

namespace LoomsManagement.Windows.Forms.Master
{
    public partial class FormCompanyView : LoomsManagement.Windows.FormDemoGrid
    {
        public FormCompanyView()
        {
            InitializeComponent();
            this.Load += FormCompanyView_Load;
        }

        void FormCompanyView_Load(object sender, EventArgs e)
        {
            BindGridData();
        }


        public void BindGridData()
        {
            Form_GridData.DataSource = CompnayBussinesLogic.GetAllCompanyDetails();
        }

        private void btnAddRecord_Click(object sender, EventArgs e)
        {
            FormCompanyMaster objform = new FormCompanyMaster();
            objform.FormClosed += objform_FormClosed;
            objform.ShowDialog();
        }

        void objform_FormClosed(object sender, FormClosedEventArgs e)
        {
            BindGridData();
        }

        private void gridView2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                FormCompanyMaster objform = new FormCompanyMaster();
                objform.IsEdit = true;
                objform.id = Convert.ToInt32(gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "CompanyID"));
                objform.FormClosed += objform_FormClosed;
                objform.ShowDialog();
            }

        }

        private void btn_export_Click(object sender, EventArgs e)
        {
            gridView2.SaveLayoutToXml("tempLayout.xml");
            foreach (GridColumn column in gridView2.Columns)
            {
                column.Visible = true;
            }
            gridView2.ExportToXls(GlobalClass.ExportDataPath + "CompanyDetails.xls");
            gridView2.RestoreLayoutFromXml("tempLayout.xml");
        }

        private void btn_pdf_Click(object sender, EventArgs e)
        {
            gridView2.SaveLayoutToXml("tempLayout.xml");
            foreach (GridColumn column in gridView2.Columns)
            {
               // column.Visible = true;
            }
            gridView2.ExportToPdf(GlobalClass.ExportDataPath + "CompanyDetails.pdf");
            gridView2.RestoreLayoutFromXml("tempLayout.xml");
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            CompositeLink composLink = new CompositeLink(new PrintingSystem());
            PrintableComponentLink pcLink1 = new PrintableComponentLink();
            pcLink1.Component = this.Form_GridData;
            composLink.Links.Add(pcLink1);
            composLink.ShowPreview();
        }

       
    }
}
