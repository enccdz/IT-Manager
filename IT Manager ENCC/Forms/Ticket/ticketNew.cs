using System;

namespace IT_Manager_ENCC.Forms
{
    public partial class ticketNew : DevExpress.XtraEditors.XtraForm
    {
        private MainForm mainForm;

        public ticketNew(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }


        private void simpleButton1_Click(object sender, EventArgs e)
        {
            mainForm.num++;
            mainForm.updateBadge();
        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {

        }
    }
}