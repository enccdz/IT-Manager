using System;
using System.Data;
using System.Windows.Forms;
using IT_Manager_ENCC.Modules;

namespace IT_Manager_ENCC.Forms
{
    public partial class settingUsers : DevExpress.XtraEditors.XtraForm
    {
        private DataTable userList;
        private bool isEdit = false;
        private string focussedUserId;

        public settingUsers()
        {
            InitializeComponent();
        }

        private void settingUsers_Load(object sender, EventArgs e)
        {
            LoadUser();
        }


        // ----- SQL Operations -----
        private void LoadUser()
        {
            userList = new DataTable();
            userList.Columns.Add("Id");
            userList.Columns.Add("Username");
            userList.Columns.Add("Password");
            userList.Columns.Add("Fullname");
            userList.Columns.Add("Email");
            userList.Columns.Add("Local email");
            userList.Columns.Add("Phone");
            userList.Columns.Add("Direction");
            userList.Columns.Add("Job");
            userList.Columns.Add("Entry date");

            if (MYSQLConnect.IsConnected("SELECT * FROM `user` ", false))
                if (MYSQLConnect.myDR.HasRows)
                {
                    while (MYSQLConnect.myDR.Read())
                    {
                        //badge1.Visible = false;
                        DataRow tr = userList.NewRow();
                        for (int i = 0; i < userList.Columns.Count; i++)
                        {
                            tr[i] = MYSQLConnect.myDR.GetString(i);
                        }

                        userList.Rows.Add(tr);

                        //MessageBox.Show(MYSQLConnect.myDR.GetString("date"));//MYSQLConnect.myDR.GetString(1)
                    }

                    usersGrid.DataSource = userList;
                    // usersGrid.
                }
        }

        private void RemoveUser(string userId)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete ?", "Remove confirmation message", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MYSQLConnect.IsConnected("DELETE FROM `user` WHERE Id = '" + MYSQLConnect.addSlash(userId) + "' LIMIT 1;", true);
                LoadUser();
            }

        }

        private void AddUser()
        {
            if (MYSQLConnect.IsConnected("Insert into user VALUES (NULL, '" +
                MYSQLConnect.addSlash(userNameTxt.Text) + "','" +
                MYSQLConnect.addSlash(passwordTxt.Text) + "','" +
                MYSQLConnect.addSlash(fulNameTxt.Text) + "','" +
                MYSQLConnect.addSlash(emailTxt.Text) + "','" +
                MYSQLConnect.addSlash(localEmailTxt.Text) + "','" +
                MYSQLConnect.addSlash(numTelTxt.Text) + "','" +
                MYSQLConnect.addSlash(directionTxt.Text) + "','" +
                MYSQLConnect.addSlash(jobTxt.Text) + "',NOW())", true))
            {

                // empty text boxes
                foreach (Control c in AddUserFormContainer.Controls)
                {
                    if (c.GetType() == typeof(DevExpress.XtraEditors.TextEdit))
                    {
                        c.Text = "";
                    }
                }

                LoadUser(); // refresh list

                MessageBox.Show("user added successfully");
            }
            else
            {
                MessageBox.Show("an error has occured during insertion");
            }
        }

        private void EditUser(string userId)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to edit ?", "Edit confirmation message", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (MYSQLConnect.IsConnected("UPDATE user SET" +
                " username='" + MYSQLConnect.addSlash(userNameTxt.Text) + "'," +
                " password='" + MYSQLConnect.addSlash(passwordTxt.Text) + "'," +
                " fullname='" + MYSQLConnect.addSlash(fulNameTxt.Text) + "'," +
                " email='" + MYSQLConnect.addSlash(emailTxt.Text) + "'," +
                " localemail='" + MYSQLConnect.addSlash(localEmailTxt.Text) + "'," +
                " phone='" + MYSQLConnect.addSlash(numTelTxt.Text) + "'," +
                " direction='" + MYSQLConnect.addSlash(directionTxt.Text) + "'," +
                " job='" + MYSQLConnect.addSlash(jobTxt.Text) + "'" +
                " WHERE user.id = '" + MYSQLConnect.addSlash(userId) + "' Limit 1;" +
                "", true))
                {
                    // empty text boxes
                    foreach (Control c in AddUserFormContainer.Controls)
                    {
                        if (c.GetType() == typeof(DevExpress.XtraEditors.TextEdit))
                        {
                            c.Text = "";
                        }
                    }

                    LoadUser(); // refresh list

                    addUserBtn.Text = "Add user";
                    isEdit = false;

                    MessageBox.Show("user updated successfully");
                }
                else
                {
                    MessageBox.Show("an error has occured during update");
                }
            }

        }




        // ----- Input Events -----
        private void addUserBtn_Click(object sender, EventArgs e)
        {
            if ( fulNameTxt.Text == string.Empty || 
                userNameTxt.Text == string.Empty || 
                passwordTxt.Text == string.Empty)
            {
                MessageBox.Show("There are empty fields");
            }
            else if (userNameTxt.Text.Length < 4 ||
                     passwordTxt.Text.Length < 7)
            {
                MessageBox.Show("Field text too short");
            }
            else
            {
                if (isEdit) EditUser(focussedUserId);
                else AddUser();
            }
        }

        private void userNameTxt_EditValueChanged(object sender, EventArgs e)
        {
            localEmailTxt.Text = userNameTxt.Text + "@encc.local";
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            usersGrid.ContextMenuStrip = usersMenu;
        }

        private void gridView1_LostFocus(object sender, EventArgs e)
        {
            usersGrid.ContextMenuStrip = null;
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveUser(gridView1.GetFocusedRowCellValue("Id").ToString());
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // coppy user data to text fields
            userNameTxt.Text = userList.Rows[gridView1.GetSelectedRows()[0]][1].ToString();
            passwordTxt.Text = userList.Rows[gridView1.GetSelectedRows()[0]][2].ToString();
            fulNameTxt.Text = userList.Rows[gridView1.GetSelectedRows()[0]][3].ToString();
            emailTxt.Text = userList.Rows[gridView1.GetSelectedRows()[0]][4].ToString();
            localEmailTxt.Text = userList.Rows[gridView1.GetSelectedRows()[0]][5].ToString();
            numTelTxt.Text = userList.Rows[gridView1.GetSelectedRows()[0]][6].ToString();
            directionTxt.Text = userList.Rows[gridView1.GetSelectedRows()[0]][7].ToString();
            jobTxt.Text = userList.Rows[gridView1.GetSelectedRows()[0]][8].ToString();

            // change add button to edit
            addUserBtn.Text = "Edit user";
            isEdit = true;

            // save current user id
            focussedUserId = gridView1.GetFocusedRowCellValue("Id").ToString();
        }


    }
}