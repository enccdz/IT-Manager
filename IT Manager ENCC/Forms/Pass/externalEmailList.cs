using System;

namespace IT_Manager_ENCC.Forms.Pass
{
    public partial class externalEmailList : DevExpress.XtraEditors.XtraForm
    {
        private externalEmailAdd externalEmailAddForm;

        public externalEmailList()
        {
            InitializeComponent();
        }

        private void addEmailBtn_Click(object sender, EventArgs e)
        {
            externalEmailAddForm = new externalEmailAdd();
            externalEmailAddForm.Show();
        }
    }
}