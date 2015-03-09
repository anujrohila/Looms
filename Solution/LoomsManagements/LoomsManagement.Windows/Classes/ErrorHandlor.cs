using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace DaryInventory.Classes
{
    public static class ErrorHandlor
    {
        public static int count;

        public static void SetTextboxErrorWithCount(DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider ep, DevExpress.XtraEditors.TextEdit c, string message)
        {

            if (c.Text.Trim() == "")
            {
                ep.SetError(c, message);
                c.BackColor = GlobalClass.m_tbcolorerror;
                if (count == 0)
                    c.Focus();
                count++;

            }
            else
            {
                ep.SetError(c, "");
                c.BackColor = GlobalClass.m_tbcolorleave;

            }
        }

        public static void SetLookUPErrorWithCount(DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider ep, DevExpress.XtraEditors.LookUpEdit c, string message)
        {

            if (c.ItemIndex == -1)
            {
                ep.SetError(c, message);
                c.BackColor = GlobalClass.m_tbcolorerror;
                if (count == 0)
                    c.Focus();
                count++;
            }
            else
            {
                ep.SetError(c, "");
                c.BackColor = GlobalClass.m_tbcolorleave;

            }
        }

        public static void SetDateErrorWithCount(DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider ep, DevExpress.XtraEditors.DateEdit c, string message)
        {

            if (c.Text.Trim() == "")
            {
                ep.SetError(c, message);
                c.BackColor = GlobalClass.m_tbcolorerror;
                if (count == 0)
                    c.Focus();
                count++;
            }
            else
            {
                ep.SetError(c, "");
                c.BackColor = GlobalClass.m_tbcolorleave;

            }
        }

        public static void SetMemoEditErrorWithCount(DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider ep, DevExpress.XtraEditors.MemoEdit c, string message)
        {

            if (c.Text.Trim() == "")
            {
                ep.SetError(c, message);
                c.BackColor = GlobalClass.m_tbcolorerror;
                if (count == 0)
                    c.Focus();
                count++;
            }
            else
            {
                ep.SetError(c, "");
                c.BackColor = GlobalClass.m_tbcolorleave;

            }
        }


        public static void SetErrorCount()
        {
            count = 0;
        }

        public static int GetErrorCount()
        {
            return count;
        }
    }
}
