using System;
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
using LoomsMana.Forms.Production.Purchase;


namespace LoomsMana
{
    public partial class DashBoard : RibbonForm
    {

        #region [Declaration]

        private bool flag = false;
        int h = 0, w = 0;

        #endregion

        #region constructor

        public DashBoard()
        {
            InitializeComponent();
        }

        #endregion

        #region [Page Event]

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

        private void btnWindowClose_Click(object sender, EventArgs e)
        {
            this.Close();
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
                TabControl.TabPages.Remove((arg.Page as DevExpress.XtraTab.XtraTabPage));
            }
            catch
            { }
            if (TabControl.TabPages.Count == 0)
            {
                TabControl.Visible = false;
                pnlTop.BorderStyle = BorderStyle.FixedSingle;
            }
        }

        private void labelNavigation_Click(object sender, EventArgs e)
        {
            HideShowPnl();
        }

        private void navBankBranch_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            //FillFrm(new frmBankBranchMasterView());
        }

        private void navCompMst_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
           string tagname= ((DevExpress.XtraNavBar.NavBarItem)sender).Name.ToString();

           if (tagname == "")
               return;

           Form Currentform = new Form();

           switch (tagname)
           {
               case "navCompMst":
                   FillFrm(new FrmCompanyView());
                   break;
               case "navOwnerMst":
                   // Currentform = new CustomerMaster();
                   break;
               case "navPartyMst":
                  FillFrm( new frmPartyMasterView());
                   break;
               case "navEmpMst":
                   FillFrm(new frmEmployeeMasterView());
                   break;
               case "navEmpType":
                  FillFrm(new frmEmployeeTypeMasterView());
                   break;
               case "navPanalty":
                  FillFrm( new frmPenaltyMasterView());
                   break;
               case "navYarnType":
                   FillFrm(new frmYarnTypeMasterView());
                   break;
               case "navYarnQty":
                  FillFrm(  Currentform = new frmYarnQualityMasterView());
                   break;
               case "navYarnPkg":
                  FillFrm(  Currentform = new frmYarnPackageTypeMasterView());
                   break;
               case "navMachineType":
                   FillFrm(new frmMachineTypeMasterView());
                   break;
               case "navMachine":
                   FillFrm(new frmMachineMasterView());
                   break;
               case "navBank":
                   FillFrm(new frmBankMasterView());
                   break;
               case "navBankBranch":
                   FillFrm(new frmBankBranchMasterView());
                   break;
               case "navBemType":
                   FillFrm(new frmBeamMasterView());
                   break;
               case "navFiscaYear":
                   FillFrm(new frmFiscalYearView());
                   break;
               case "navPurOrder":
                   FillFrm( Currentform = new frmYarnPurchaseOrder());
                   break;
               case "navPurReturn":
                   FillFrm( Currentform = new frmYarnPurchaseReturn());
                   break;
               case "navSaleOrder":
                   FillFrm( Currentform = new frmSaleOrder());
                   break;
               case "navSaleReturn":
                   FillFrm( Currentform = new frmSaleReturn());
                   break;
               case "navBeamPurchase":
                   FillFrm( Currentform = new frmBeamPurchase());
                   break;
               case "navGrayPurchase":
                   FillFrm( Currentform = new frmGrayPurchase());
                   break;
               case "exit":
                   Close();
                   return;

               default:
                   return;
           }

           bool flag = false;
        }

        #endregion

        #region Public Method

        #endregion

        #region [Private Method]

        /// <summary>
        /// 
        /// </summary>
        private void HideShowPnl()
        {
            if (flag == false)
            {
                while (panelMasterMenuLeft.Width > 10)
                {
                    Thread.Sleep(1);
                    panelMasterMenuLeft.Width -= 20;
                    panelMasterMenuLeft.Refresh();
                }
                labelNavigation.Text = ">>";
                pnlMainBack.Refresh();
                try
                {
                    for (int i = 0; i < TabControl.TabPages.Count; i++)
                    {
                        for (int j = 0; j < TabControl.TabPages[i].Controls.Count; j++)
                        {
                            if (TabControl.TabPages[i].Controls[j].Name.ToString() == "pnl" + TabControl.TabPages[i].Text.ToString())
                            {
                                Panel pnl = (Panel)pnlMainBack.Controls.Find("pnl" + TabControl.TabPages[i].Text.ToString(), true)[0];
                                Form frm = (Form)pnl.Controls.Find(TabControl.TabPages[i].Tag.ToString(), true)[0];
                                pnl.Controls.Remove(pnlMainBack.Controls.Find(TabControl.TabPages[i].Tag.ToString(), true)[0]);
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

                while (panelMasterMenuLeft.Width < 238)
                {
                    Thread.Sleep(1);
                    panelMasterMenuLeft.Width += 20;
                    panelMasterMenuLeft.Refresh();
                }
                labelNavigation.Text = "<<";
                pnlMainBack.Refresh();

                try
                {
                    for (int i = 0; i < TabControl.TabPages.Count; i++)
                    {
                        for (int j = 0; j < TabControl.TabPages[i].Controls.Count; j++)
                        {
                            if (TabControl.TabPages[i].Controls[j].Name.ToString() == "pnl" + TabControl.TabPages[i].Text.ToString())
                            {
                                Panel pnl = (Panel)pnlMainBack.Controls.Find("pnl" + TabControl.TabPages[i].Text.ToString(), true)[0];
                                Form frm = (Form)pnl.Controls.Find(TabControl.TabPages[i].Tag.ToString(), true)[0];
                                pnl.Controls.Remove(pnlMainBack.Controls.Find(TabControl.TabPages[i].Tag.ToString(), true)[0]);
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

        private void FillFrm(Form frm)
        {
            try
            {
                int i = 0;
                foreach (var item in TabControl.TabPages)
                {
                    if (((DevExpress.XtraTab.XtraTabPage)item).Text.ToString() == frm.Text.ToString())
                    {
                        TabControl.SelectedTabPage = ((DevExpress.XtraTab.XtraTabPage)item);
                        return;
                    }
                    i++;
                }
            }
            catch
            { }
            pnlTop.BorderStyle = BorderStyle.None;

            TabControl.Visible = true;
            Panel pnl = new Panel();
            DevExpress.XtraTab.XtraTabPage tbp = new DevExpress.XtraTab.XtraTabPage();
            TabControl.TabPages.Add(tbp);
            tbp.ShowCloseButton = DefaultBoolean.True;
            frm.TopLevel = false;
            tbp.Controls.Add(pnl);
            pnl.Dock = DockStyle.Fill;
            pnl.BackColor = Color.White;
            pnl.Name = "pnl" + frm.Text;
            tbp.Refresh();
            if (TabControl.TabPages.Count == 1)
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
            TabControl.SelectedTabPage = tbp;
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

        #endregion

    }
}