using IT_Manager_ENCC.Modules;
using System;
using System.Data;
using System.Windows.Forms;

namespace IT_Manager_ENCC.Forms
{
    public partial class settingAdmins : DevExpress.XtraEditors.XtraForm
    {
        private DataTable adminList;
        private bool isEdit = false;
        private string focussedUserId;

        public settingAdmins()
        {
            InitializeComponent();
        }

        // ---- SQL operations ----
        private void LoadAdmins()
        {
            adminList = new DataTable();
            adminList.Columns.Add("Id");
            adminList.Columns.Add("Fullname");
            adminList.Columns.Add("Username");
            adminList.Columns.Add("Password");
            adminList.Columns.Add("Role");
            adminList.Columns.Add("Creation date");

            if (MYSQLConnect.IsConnected("SELECT * FROM `admin` ", false))
                if (MYSQLConnect.myDR.HasRows)
                {
                    while (MYSQLConnect.myDR.Read())
                    {
                        DataRow tr = adminList.NewRow();
                        for (int i = 0; i < adminList.Columns.Count; i++)
                        {
                            tr[i] = MYSQLConnect.myDR.GetString(i);
                        }
                        adminList.Rows.Add(tr);
                    }

                    adminsGrid.DataSource = adminList;
                }
        }

        private void AddAdmin()
        {
            if (MYSQLConnect.IsConnected("Insert into admin VALUES (NULL, '" +
                MYSQLConnect.addSlash(fullNameTxt.Text) + "','" +
                MYSQLConnect.addSlash(userTxt.Text) + "','" +
                MYSQLConnect.addSlash(passTxt.Text) + "','" +
                MYSQLConnect.addSlash(roleComboBox.Text) + "',NOW())", true))
            {

                // empty text boxes
                foreach (Control c in AdminFormContainer.Controls)
                {
                    if (c.GetType() == typeof(DevExpress.XtraEditors.TextEdit) || 
                        c.GetType() == typeof(DevExpress.XtraEditors.ComboBoxEdit))
                    {
                        c.Text = "";
                    } /*else if(c.GetType() == typeof(DevExpress.XtraEditors.ComboBoxEdit))
                    {
                        c.Text = "";
                    }*/
                }

                LoadAdmins(); // refresh list

                MessageBox.Show("admin added successfully");
            }
            else
            {
                MessageBox.Show("an error has occured during insertion");
            }
        }

        private void EditAdmin(string UserId)
        {
            Console.WriteLine("Admin update");
        }





        // ---- Input events ---
        private void addAdminBtn_Click(object sender, EventArgs e)
        {
            if (fullNameTxt.Text == string.Empty ||
                userTxt.Text == string.Empty ||
                passTxt.Text == string.Empty ||
                roleComboBox.Text == string.Empty)
            {
                MessageBox.Show("There are empty fields");
            }
            else if (userTxt.Text.Length < 4 ||
                     passTxt.Text.Length < 7)
            {
                MessageBox.Show("Field text too short");
            }
            else
            {
                if (isEdit) EditAdmin(focussedUserId);
                else AddAdmin();
            }
        }

        private void settingAdmins_Load(object sender, EventArgs e)
        {
            LoadAdmins();
        }
    }
}