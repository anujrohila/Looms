﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using DevExpress.UserSkins;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Helpers;
using System.Threading;
using DevExpress.XtraNavBar;
using LoomsMana.Forms.Master;
using DevExpress.Utils;
using LoomsMana.Forms;


namespace LoomsMana
{
    public partial class DashBoard : RibbonForm
    {
        public DashBoard()
        {
            InitializeComponent();
            InitSkinGallery();
          
        }
        void InitSkinGallery()
        {
            
        }

        private void windowsUIButtonPanel1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        bool flag = false;
        public void HideShowPnl()
        {
            if (flag == false)
            {
                while (pnlLeft.Width > 10)
                {
                    Thread.Sleep(1);
                    pnlLeft.Width -= 20;
                    pnlLeft.Refresh();
                }
                lblNav.Text = ">>";
                pnlMainBack.Refresh();
                try
                {
                    for (int i = 0; i < tabControl1.TabPages.Count; i++)
                    {
                        for (int j = 0; j < tabControl1.TabPages[i].Controls.Count; j++)
                        {
                            if (tabControl1.TabPages[i].Controls[j].Name.ToString() == "pnl" + tabControl1.TabPages[i].Text.ToString())
                            {
                                Panel pnl = (Panel)pnlMainBack.Controls.Find("pnl" + tabControl1.TabPages[i].Text.ToString(), true)[0];
                                Form frm = (Form)pnl.Controls.Find(tabControl1.TabPages[i].Tag.ToString(), true)[0];
                                pnl.Controls.Remove(pnlMainBack.Controls.Find(tabControl1.TabPages[i].Tag.ToString(), true)[0]);
                                frm.Parent = null;
                                frm.Height = pnl.Height;
                                frm.Width = pnl.Width;
                                pnl.Controls.Add(frm);
                                frm.Location = new Point(pnl.Width / 2 - frm.Size.Width / 2, pnl.Height / 2 - frm.Size.Height / 2);
                                //frm.Dock = DockStyle.Fill;
                                frm.Visible = true;
                            }
                        }

                    }

                }
                catch { }

                flag = true;
            }
            else
            {
                flag = true;

                while (pnlLeft.Width < 238)
                {
                    Thread.Sleep(1);
                    pnlLeft.Width += 20;
                    pnlLeft.Refresh();
                }
                lblNav.Text = "<<";
                pnlMainBack.Refresh();

                try
                {
                    for (int i = 0; i < tabControl1.TabPages.Count; i++)
                    {
                        for (int j = 0; j < tabControl1.TabPages[i].Controls.Count; j++)
                        {
                            if (tabControl1.TabPages[i].Controls[j].Name.ToString() == "pnl" + tabControl1.TabPages[i].Text.ToString())
                            {
                                Panel pnl = (Panel)pnlMainBack.Controls.Find("pnl" + tabControl1.TabPages[i].Text.ToString(), true)[0];
                                Form frm = (Form)pnl.Controls.Find(tabControl1.TabPages[i].Tag.ToString(), true)[0];
                                pnl.Controls.Remove(pnlMainBack.Controls.Find(tabControl1.TabPages[i].Tag.ToString(), true)[0]);
                                frm.Parent = null;
                                frm.Height = pnl.Height;
                                frm.Width = pnl.Width;
                                pnl.Controls.Add(frm);
                                frm.Location = new Point(pnl.Width / 2 - frm.Size.Width / 2, pnl.Height / 2 - frm.Size.Height / 2);
                                //frm.Dock = DockStyle.Fill;
                                frm.Visible = true;
                            }
                        }

                    }

                }
                catch { }
                flag = false;

            }

        }

        private void label5_Click(object sender, EventArgs e)
        {
            HideShowPnl();
        }

        private void DashBoard_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Environment.Exit(0);
            }
            else if (ModifierKeys.HasFlag(Keys.Control) && e.KeyCode == Keys.Q)
            {
                HideShowPnl();
            }
        }

        private void navBarControl1_GroupExpanded(object sender, DevExpress.XtraNavBar.NavBarGroupEventArgs e)
        {
            foreach (NavBarGroup nbg in navBarControl.Groups)
            {
                if (nbg.Name != e.Group.Name)
                {
                    nbg.Expanded = false;
                }
            }
        }

        private void navBarControl_MouseClick(object sender, MouseEventArgs e)
        {
            NavBarHitInfo hi = navBarControl.CalcHitInfo(e.Location);
            try
            {
                foreach (NavBarGroup nbg in navBarControl.Groups)
                {
                    if (nbg.Name != hi.Group.Name)
                    {
                        nbg.Expanded = false;
                    }
                }
                hi.Group.Expanded = true;
            }
            catch
            { }
        }
        int h = 0, w = 0;
        public void FillFrm(Form frm)
        {
            try
            {
                int i = 0;
                foreach (var item in tabControl1.TabPages)
                {
                    if (((DevExpress.XtraTab.XtraTabPage)item).Text.ToString() == frm.Text.ToString())
                    {
                        tabControl1.SelectedTabPage = ((DevExpress.XtraTab.XtraTabPage)item);
                        return;
                    }
                    i++;
                }
            }
            catch
            { }
            pnlTop.BorderStyle = BorderStyle.None;

            tabControl1.Visible = true;
            Panel pnl = new Panel();
            DevExpress.XtraTab.XtraTabPage tbp = new DevExpress.XtraTab.XtraTabPage();
            tabControl1.TabPages.Add(tbp);
            tbp.ShowCloseButton = DefaultBoolean.True;
            frm.TopLevel = false;
            tbp.Controls.Add(pnl);
            pnl.Dock = DockStyle.Fill;
            pnl.BackColor = Color.White;
            pnl.Name = "pnl" + frm.Text;
            tbp.Refresh();
            if (tabControl1.TabPages.Count == 1)
            {
                frm.Height = pnl.Height;
                frm.Width = tbp.Width;
                h = pnl.Height;
                w = pnl.Width;
            }
            else
            {
                frm.Height = h;
                frm.Width = w;
            }
            frm.Anchor = AnchorStyles.None;
            frm.FormBorderStyle = FormBorderStyle.None;
           
            tbp.BackColor = Color.White;
            pnl.Controls.Add(frm);
            tabControl1.SelectedTabPage = tbp;
            frm.Visible = true;
            tbp.Focus();
            tbp.Tag = frm.Name.ToString();
            tbp.Text = frm.Text;

            frm.Location = new Point(pnl.Width / 2 - frm.Size.Width / 2, pnl.Height / 2 - frm.Size.Height / 2);

            pnl.Refresh();
            //frm.TopLevel = false;
            //pnlMain.Controls.Add(frm);
            //frm.Location = new Point(
            //pnlMain.Width / 2 - frm.Size.Width / 2,
            //pnlMain.Height / 2 - frm.Size.Height / 2);
            //frm.Anchor = AnchorStyles.None;
            //frm.Visible = true;
            //frm.BringToFront();
            //frm.Focus();

            //pnlMainBack.Refresh();
            //scrollMail.Refresh();
            //pnlMain.Height = frm.Height;
            //pnlMain.Width = frm.Width;
            //frm.TopLevel = false;
            //frm.FormBorderStyle = FormBorderStyle.None;
            //pnlMain.Controls.Clear();
            //pnlMain.Controls.Add(frm);
            //frm.Visible = true;
            //frm.Dock = DockStyle.Fill;

            //pnlMain.Location = new Point(
            //pnlMainBack.Width / 2 - pnlMain.Size.Width / 2,
            //pnlMainBack.Height / 2 - pnlMain.Size.Height / 2);
            //pnlMain.Anchor = AnchorStyles.None;
        }

        private void DashBoard_Shown(object sender, EventArgs e)
        {
            navBarProduction.Expanded = false;
        }

        private void tabControl1_CloseButtonClick(object sender, EventArgs e)
        {
            try
            {
                DevExpress.XtraTab.ViewInfo.ClosePageButtonEventArgs arg = e as DevExpress.XtraTab.ViewInfo.ClosePageButtonEventArgs;
                (arg.Page as DevExpress.XtraTab.XtraTabPage).PageVisible = false;
                tabControl1.TabPages.Remove((arg.Page as DevExpress.XtraTab.XtraTabPage));
            }
            catch
            { }
            if (tabControl1.TabPages.Count == 0)
            {
                tabControl1.Visible = false;
                pnlTop.BorderStyle = BorderStyle.FixedSingle;
            }
        }

        private void lblNav_Click(object sender, EventArgs e)
        {
            HideShowPnl();
        }

       
        #region Control Event

        private void Menulink_Click(object sender, NavBarLinkEventArgs e)
        {
            string tagname = e.Link.Caption.ToString().Trim();
            if (tagname == "")
                return;

            Form Currentform = new Form();

            switch (tagname)
            {
                case "Bank Branch":
                    Currentform = new frmBankBranchMasterView();
                    break;
                //case "Owner Master View":
                //    // Currentform = new CustomerMaster();
                //    break;
                //case "Party Master View":
                //    Currentform = new frmPartyMasterView();
                //    break;
                //case "Employee Type Master View":
                //    Currentform = new frmEmployeeTypeMasterView();
                //    break;
                //case "Employee Master View":
                //    Currentform = new frmEmployeeMasterView();
                //    break;
                //case "Panalty Master View":
                //    Currentform = new frmPenaltyMasterView();
                //    break;
                //case "Yarn Type Master View":
                //    Currentform = new frmYarnTypeMasterView();
                //    break;
                //case "Yarn Quality Master View":
                //    Currentform = new frmYarnQualityMasterView();
                //    break;
                //case "Machine Type Master View":
                //    Currentform = new frmMachineTypeMasterView();
                //    break;
                //case "Machine Master View":
                //    Currentform = new frmMachineMasterView();
                //    break;
                //case "Bank Master View":
                //    Currentform = new frmBankMasterView();
                //    break;
                //case "Bank Branch Master View":
                //    Currentform = new frmBankBranchMasterView();
                //    break;
                //case "Yarn Package Type View":
                //    Currentform = new frmYarnPackageTypeMasterView();
                //    break;
                //case "Beam Master":
                //    Currentform = new frmBeamMasterView();
                //    break;
                //case "Fiscal Year":
                //    Currentform = new frmFiscalYearView();
                //    break;
                //case "Sales Order":
                //    Currentform = new frmSalesOrder();
                //    break;
                //case "Purchase Order":
                //    Currentform = new frmYarnPurchaseOrder();
                //    break;
                //case "Sales Bill":
                //    Currentform = new frmSalesBill();
                //    break;
                //case "Purchase Bill":
                //    Currentform = new frmPurchaseBill();
                //    break;
                //case "Sales Challan":
                //    Currentform = new frmSalesChallan();
                //    break;
                //case "Sales Return":
                //    Currentform = new frmSalesReturn();
                //    break;
                //case "Purchase Return":
                //    Currentform = new frmYarnPurchaseReturn();
                //    break;

                //case "Beam Purchase":
                //    Currentform = new frmBeamPurchase();
                //    break;
                //case "Gray Purchase":
                //    Currentform = new frmGrayPurchase();
                //    break;
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

        #endregion

        private void navBankBranch_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            FillFrm(new frmBankBranchMasterView());
        }

    }
}