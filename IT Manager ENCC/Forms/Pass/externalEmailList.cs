using System;
using System.Data;
using static IT_Manager_ENCC.Modules.MYSQLConnect;
using static IT_Manager_ENCC.Modules.UiTools;

namespace IT_Manager_ENCC.Forms.Pass
{
    public partial class externalEmailList : DevExpress.XtraEditors.XtraForm
    {
        private externalEmailAdd externalEmailAddForm;
        public MainForm mainForm;
        private DataTable emails = new DataTable();

        public externalEmailList(MainForm mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();

            emails.Columns.Add("Id");
            emails.Columns.Add("Email");
            emails.Columns.Add("Password");
            emails.Columns.Add("Creation date");


            LoadEmails();
        }

        public void LoadEmails()
        {
            emails.Rows.Clear();

            if (IsConnected("SELECT * FROM `externalemails` ", false))
                FillEmailDataGrid(myDR, emails, hardwareGrid, mainForm);
        }

        private void addEmailBtn_Click(object sender, EventArgs e)
        {
            externalEmailAddForm = new externalEmailAdd(this);
            externalEmailAddForm.Show();
        }

    }
}