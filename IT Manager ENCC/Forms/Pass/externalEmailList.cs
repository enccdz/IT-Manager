using System;
using System.Data;
using System.Windows.Forms;
using static IT_Manager_ENCC.Modules.MYSQLConnect;
using static IT_Manager_ENCC.Modules.UiTools;

namespace IT_Manager_ENCC.Forms.Pass
{
    public partial class externalEmailList : DevExpress.XtraEditors.XtraForm
    {
        private externalEmailAdd externalEmailAddForm;
        public MainForm mainForm;
        public DataTable emails = new DataTable();

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

        public DevExpress.XtraGrid.Views.Grid.GridView getGridView()
        {
            return gridView1;
        }

        public void LoadEmails()
        {
            emails.Rows.Clear();

            if (IsConnected("SELECT * FROM `externalemails` ", false))
                FillEmailDataGrid(myDR, emails, emailGrid, mainForm);
        }
        private void RemoveHardware(string hardwareId)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete ?", "Remove confirmation message", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                IsConnected("DELETE FROM `externalemails` WHERE Id = '" + addSlash(hardwareId) + "' LIMIT 1;", true);
                LoadEmails();
            }
        }


        private void addEmailBtn_Click(object sender, EventArgs e)
        {
            externalEmailAddForm = new externalEmailAdd(this);
            externalEmailAddForm.Show();
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            emailGrid.ContextMenuStrip = emailsMenu;
        }

        private void gridView1_LostFocus(object sender, EventArgs e)
        {
            emailGrid.ContextMenuStrip = null;
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            externalEmailAddForm = new externalEmailAdd(this, int.Parse(gridView1.GetFocusedRowCellValue("Id").ToString()));
            externalEmailAddForm.Show();
        }

        private void deleateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveHardware(gridView1.GetFocusedRowCellValue("Id").ToString());
        }

        private void searchTxt_EditValueChanged(object sender, EventArgs e)
        {
            gridView1.FindFilterText = searchTxt.Text;
        }
    }
}