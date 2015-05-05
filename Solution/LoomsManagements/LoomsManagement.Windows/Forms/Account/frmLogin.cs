using LoomsManagement.Windows.Classes;
using System;
using System.Threading;

namespace LoomsManagement.Windows.Forms.Account
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        public frmLogin()
        {
            InitializeComponent();
            this.Load += frmLogin_Load;
        }

        void frmLogin_Load(object sender, EventArgs e)
        {
          //  Thread.Sleep(5000);
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // UserContext.GetALLtblCompanyDTO();
            var dashboard = new Dashboard();
           
            dashboard.Show();
            this.Hide();
        }
    }
}