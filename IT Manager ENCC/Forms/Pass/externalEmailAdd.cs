using IT_Manager_ENCC.Modules;
using System;
using System.Data;
using System.Windows.Forms;
using static IT_Manager_ENCC.Modules.Tools;
using static IT_Manager_ENCC.Modules.MYSQLConnect;


namespace IT_Manager_ENCC.Forms.Pass
{
    public partial class externalEmailAdd : DevExpress.XtraEditors.XtraForm
    {
        private externalEmailList externalEmailList;
        private int focussedEmailId;

        public externalEmailAdd(externalEmailList externalEmailList, int focussedEmailId=-1)
        {
            this.externalEmailList = externalEmailList;
            this.focussedEmailId = focussedEmailId;
            InitializeComponent();

            if(focussedEmailId != -1) {
                confirmBtn.Text = "Edit Email";
                emailTxt.Text = externalEmailList.emails.Rows[externalEmailList.getGridView().GetSelectedRows()[0]][1].ToString();
                passwordTxt.Text = externalEmailList.emails.Rows[externalEmailList.getGridView().GetSelectedRows()[0]][2].ToString();
            }
        }

        void addEmail()
        {
            if (IsConnected(addSlash("Insert into externalemails VALUES (NULL, '" +
                emailTxt.Text + "','" +
                passwordTxt.Text + "',NOW())"), true))
            {
                passwordTxt.Text = "";
                emailTxt.Text = "";
                externalEmailList.LoadEmails(); //refresh email list
                MessageBox.Show("email added successfully");
            }
            else
            {
                MessageBox.Show("an error has occured during insertion");
            }
        }


        private void editEmail(string emailId)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to edit ?", "Edit confirmation message", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (IsConnected(addSlash("UPDATE externalemails SET" +
                " email='" + emailTxt.Text + "'," +
                " password='" + passwordTxt.Text + "'" +
                " WHERE externalemails.id = '" + emailId + "' Limit 1;"), true))
                {
                    externalEmailList.LoadEmails(); //refresh email list
                    MessageBox.Show("email updated successfully");
                }
                else
                {
                    MessageBox.Show("an error has occured during update");
                }
            }

        }





        private void generatePasswordBtn_Click(object sender, EventArgs e)
        {
            passwordTxt.Text = GeneratePassword(externalEmailList.mainForm.PasswordCharacters,16);
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            if (passwordTxt.Text == string.Empty ||
                emailTxt.Text == string.Empty)
            {
                MessageBox.Show("There are empty fields");
            }
            else if (passwordTxt.Text.Length<16)
            {
                MessageBox.Show("Password too short");
            }
            else if (!IsEmailValid(emailTxt.Text))
            {
                MessageBox.Show("Email invalid");
            }
            else if (focussedEmailId == -1) // is edit email form ?
                addEmail();
            else
            {
                editEmail(focussedEmailId.ToString());
            }
        }
    }
}