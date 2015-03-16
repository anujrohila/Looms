using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace LoomsManagement.Windows.Classes
{
    public static class CommanClass
    {

        #region [Variable]
        
        #endregion

        #region [Methods]
        
        #endregion

        public static int UserId = 1;
        public static System.Drawing.Color m_tbcolorenter = Color.FromArgb(233, 240, 173);
        public static System.Drawing.Color m_tbcolorleave = System.Drawing.Color.White;
        public static System.Drawing.Color m_tbcolorerror = Color.FromArgb(255, 189, 186);
        public static DateTime newdata = new DateTime(2016, 2, 1);

        public static string ExportDataPath = "D:\\ExportData\\" + DateTime.Today.ToShortDateString() + "-";

        public static void EnterEvents(object sender, EventArgs e)
        {
            if ((sender as DateEdit) is DateEdit)
            {
                (sender as DateEdit).BackColor = CommanClass.m_tbcolorenter;
            }
            else
                if ((sender as LookUpEdit) is LookUpEdit)
                {
                    (sender as LookUpEdit).BackColor = CommanClass.m_tbcolorenter;
                }
                else
                    if ((sender as TextEdit) is TextEdit)
                    {
                        (sender as TextEdit).BackColor = CommanClass.m_tbcolorenter;
                    }
                    else
                        if ((sender as MemoEdit) is MemoEdit)
                        {
                            (sender as MemoEdit).BackColor = CommanClass.m_tbcolorenter;
                        }
        }

        public static void LeaveEvents(object sender, EventArgs e)
        {
            if ((sender as DateEdit) is DateEdit)
            {
                (sender as DateEdit).BackColor = CommanClass.m_tbcolorleave;
            }
            else
                if ((sender as LookUpEdit) is LookUpEdit)
                {
                    (sender as LookUpEdit).BackColor = CommanClass.m_tbcolorleave;
                }
                else
                    if ((sender as TextEdit) is TextEdit)
                    {
                        (sender as TextEdit).BackColor = CommanClass.m_tbcolorleave;
                    }
                    else
                        if ((sender as MemoEdit) is MemoEdit)
                        {
                            (sender as MemoEdit).BackColor = CommanClass.m_tbcolorleave;
                        }
        }

        public static void ShowProcessBar()
        {
            try
            {
                SplashScreenManager.ShowForm(typeof(WaitForm1));
            }
            catch (Exception)
            {
            }
           
        }

        public static void HideProcessBar()
        {
            try
            {
              SplashScreenManager.CloseForm();
            }
            catch (Exception)
            {
            }
        }


    }
}
