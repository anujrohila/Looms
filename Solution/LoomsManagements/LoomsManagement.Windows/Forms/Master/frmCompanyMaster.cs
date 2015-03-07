using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DaryInventory.Classes;

namespace LoomsManagement.Windows.Forms.Master
{
    public partial class frmCompanyMaster : DevExpress.XtraEditors.XtraForm
    {
        public frmCompanyMaster()
        {
            InitializeComponent();
        }


        #region KeyEvent

        private void EnterEvent(object sender, EventArgs e)
        {
            if ((sender as DateEdit) is DateEdit)
            {
                (sender as DateEdit).BackColor = GlobalClass.m_tbcolorleave;
            }
            else
                if ((sender as LookUpEdit) is LookUpEdit)
                {
                    (sender as LookUpEdit).BackColor = GlobalClass.m_tbcolorleave;
                }
                else
                    if ((sender as TextEdit) is TextEdit)
                    {
                        (sender as TextEdit).BackColor = GlobalClass.m_tbcolorenter;
                    }
                    else
                        if ((sender as MemoEdit) is MemoEdit)
                        {
                            (sender as MemoEdit).BackColor = GlobalClass.m_tbcolorenter;
                        }
        }

        private void LeaveEvent(object sender, EventArgs e)
        {
            if ((sender as DateEdit) is DateEdit)
            {
                (sender as DateEdit).BackColor = GlobalClass.m_tbcolorleave;
            }
            else
                if ((sender as LookUpEdit) is LookUpEdit)
                {
                    (sender as LookUpEdit).BackColor = GlobalClass.m_tbcolorleave;
                }
                else
                    if ((sender as TextEdit) is TextEdit)
                    {
                        (sender as TextEdit).BackColor = GlobalClass.m_tbcolorleave;
                    }
                    else
                        if ((sender as MemoEdit) is MemoEdit)
                        {
                            (sender as MemoEdit).BackColor = GlobalClass.m_tbcolorleave;
                        }
        }

        private void txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }


        #endregion

    }
}