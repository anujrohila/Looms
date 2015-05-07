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

        private void navCompMst_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            FillFrm(new FrmCompanyMst());
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

    }
}