﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Helpers;
using LoomsManagement.Windows.Forms.Master;
using LoomsManagement.Windows.Classes;


namespace LoomsManagement.Windows.Forms
{
    public partial class Dashboard : DevExpress.XtraBars.Ribbon.RibbonForm
    {

        #region ControctorConstructor

        public Dashboard()
        {
            InitializeComponent();
            // InitSkinGallery();
            this.Shown += Dashboard_Shown;
        }

        #endregion

        #region PageEvent

        void Dashboard_Shown(object sender, EventArgs e)
        {
            if (UserContext.SelectedCompanyCode == 0)
            {
                //var companyselect = new frmCompanySelect();
                //companyselect.Deactivate += companyselect_Deactivate;
                //companyselect.ShowDialog();
            }

        }



        void companyselect_Deactivate(object sender, EventArgs e)
        {
            if ((sender as Form).DialogResult == System.Windows.Forms.DialogResult.Cancel)
            {
                // MessageBox.Show("hello");
              //  RefreshData();
            }
        }

        #endregion

        #region Control Event

        private void Menulink_Click(object sender, ItemClickEventArgs e)
        {
            string tagname = e.Item.Tag.ToString().Trim();
            if (tagname == "")
                return;

            Form Currentform = new Form();

            switch (tagname)
            {
                case "Company Master View":
                    Currentform = new frmCompanyView();
                    break;
                case "Owner Master View":
                    // Currentform = new CustomerMaster();
                    break;
                case "Party Master View":
                    Currentform = new frmPartyMasterView();
                    break;
                case "Employee Type Master View":
                    Currentform = new frmEmployeeTypeMasterView();
                    break;
                case "Employee Master View":
                    Currentform = new frmEmployeeMasterView();
                    break;
                case "Panalty Master View":
                    Currentform = new frmPenaltyMasterView();
                    break;
                case "Yarn Type Master View":
                    Currentform = new frmYarnTypeMasterView();
                    break;
                case "Yarn Quality Master View":
                    Currentform = new frmYarnQualityMasterView();
                    break;
                case "Machine Type Master View":
                    Currentform = new frmMachineTypeMasterView();
                    break;
                case "Machine Master View":
                    Currentform = new frmMachineMasterView();
                    break;
                case "Bank Master View":
                    Currentform = new frmBankMasterView();
                    break;
                case "Bank Branch Master View":
                    Currentform = new frmBankBranchMasterView();
                    break;
                case "Yarn Package Type View":
                    Currentform = new frmYarnPackageTypeMasterView();
                    break;
                case "Beam Master":
                    Currentform = new frmBeamMasterView();
                    break;
                case "Fiscal Year":
                    Currentform = new frmFiscalYearView();
                    break;
                case "Sales Order":
                    Currentform = new frmSalesOrder();
                   break;
                case "Purchase Order":
                   Currentform = new frmYarnPurchaseOrder();
                    break;
                case "Sales Bill":
                    Currentform = new frmSalesBill();
                    break;
                case "Purchase Bill":
                    Currentform = new frmPurchaseBill();
                    break;
                case "Sales Challan":
                    Currentform = new frmSalesChallan();
                    break;
                case "Sales Return":
                    Currentform = new frmSalesReturn();
                    break;
              case "Purchase Return":
                    Currentform = new frmYarnPurchaseReturn();
                  break;

              case "Beam Purchase":
                  Currentform = new frmBeamPurchase();
                  break;
              case "Gray Purchase":
                  Currentform = new frmGrayPurchase();
                  break;
                //case "payment details list":
                //    Currentform = new PaymentDetailsList();
                //    break;
                //case "lab details":
                //    Currentform = new LabDetails();
                //    break;
              
                case "exit":
                    Close();
                    return;

                default:
                    return;
            }

            bool flag = false;
            foreach (Form form in this.MdiChildren)
            {
                if (tagname == Convert.ToString(form.Text))
                {
                    flag = true;
                    form.Focus();
                    break;
                }
                flag = false;
            }

            if (flag == false)
            {
                Currentform.ShowInTaskbar = false;
                Currentform.MdiParent = this;
                Currentform.StartPosition = FormStartPosition.CenterParent;
                Currentform.WindowState = FormWindowState.Maximized;
                Currentform.Text = tagname;
                Currentform.Show();
            }
        }

        private void btnRefreshData_ItemClick(object sender, ItemClickEventArgs e)
        {
          //  RefreshData();
        }


        #endregion

        #region Private

        private void RefreshData()
        {
            ribbonControl.Enabled = false;
            CommanClass.ShowProcessBar();
            UserContext.LoadAllData();
            cmbCompany.DataSource = UserContext.UserContexttblCompanyDTO;
            cmbCompany.ValueMember = "CompanyID";
            cmbCompany.DisplayMember = "CompanyName";
            CommanClass.HideProcessBar();
            ribbonControl.Enabled = true;
        }

        #endregion

        private void cmbCompany_EditValueChanged(object sender, EventArgs e)
        {

        }

    }
}