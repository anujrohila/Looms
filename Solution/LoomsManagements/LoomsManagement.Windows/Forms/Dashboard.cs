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

namespace LoomsManagement.Windows.Forms
{
    public partial class Dashboard : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Dashboard()
        {
            InitializeComponent();
           // InitSkinGallery();
        }

      
        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            //frmCompanyView companyview = new frmCompanyView();
            //companyview.MdiParent = this;
            //companyview.Text = "Company Details";
            //companyview.WindowState = FormWindowState.Maximized;
            //companyview.ShowInTaskbar = false;
            //companyview.Show();

            //frmEmployeeTypeMasterView employeeview = new frmEmployeeTypeMasterView();
            //employeeview.MdiParent = this;
            //employeeview.Text = "Employee Type Details";
            //employeeview.WindowState = FormWindowState.Maximized;
            //employeeview.ShowInTaskbar = false;
            //employeeview.Show();

            frmYarnTypeMasterView yarnType = new frmYarnTypeMasterView();
            yarnType.MdiParent = this;
            yarnType.Text = "Yarn Type Master";
            yarnType.WindowState = FormWindowState.Maximized;
            yarnType.ShowInTaskbar = false;
            yarnType.Show();
        }
    }
}