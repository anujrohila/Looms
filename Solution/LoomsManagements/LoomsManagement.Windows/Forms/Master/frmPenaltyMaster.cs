using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LoomsManagement.Windows.Forms.Master
{
    public partial class frmPenaltyMaster : LoomsManagement.Windows.FormDemo1
    {
        public frmPenaltyMaster()
        {
            InitializeComponent();
            btnReport.Visible = false;
            this.Load += FormPenaltyMaster_Load;
        }

        void FormPenaltyMaster_Load(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
