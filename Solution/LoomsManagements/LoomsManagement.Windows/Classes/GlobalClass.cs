using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace DaryInventory.Classes
{
    public static class GlobalClass
    {
        public static int userid = 1;
        public static System.Drawing.Color m_tbcolorenter = Color.FromArgb(233, 240, 173);
        public static System.Drawing.Color m_tbcolorleave = System.Drawing.Color.White;
        public static System.Drawing.Color m_tbcolorerror = Color.FromArgb(255, 189, 186);
        public static DateTime newdata = new DateTime(2016, 2, 1);

        public static string ExportDataPath = "D:\\ExportData\\" + DateTime.Today.ToShortDateString() + "-";

        public static void EnterEvents(object sender, EventArgs e)
        {
            if ((sender as DateEdit) is DateEdit)
            {
                (sender as DateEdit).BackColor = GlobalClass.m_tbcolorenter;
            }
            else
                if ((sender as LookUpEdit) is LookUpEdit)
                {
                    (sender as LookUpEdit).BackColor = GlobalClass.m_tbcolorenter;
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

        public static void LeaveEvents(object sender, EventArgs e)
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
    }
}
