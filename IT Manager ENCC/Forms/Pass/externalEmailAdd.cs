using IT_Manager_ENCC.Modules;
using System;
using System.Data;
using System.Windows.Forms;
using static IT_Manager_ENCC.Modules.Tools;


namespace IT_Manager_ENCC.Forms.Pass
{
    public partial class externalEmailAdd : DevExpress.XtraEditors.XtraForm
    {
        private externalEmailList externalEmailList;

        public externalEmailAdd(externalEmailList externalEmailList)
        {
            this.externalEmailList = externalEmailList;
            InitializeComponent();
        }

        void addEmail()
        {
            if (MYSQLConnect.IsConnected(MYSQLConnect.addSlash("Insert into externalemails VALUES (NULL, '" +
                emailTxt.Text + "','" +
                passwordTxt.Text + "',NOW())"), true))
            {
                passwordTxt.Text = "";
                emailTxt.Text = "";
                externalEmailList.LoadEmails();
                MessageBox.Show("email added successfully");
            }
            else
            {
                MessageBox.Show("an error has occured during insertion");
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
            else
            {
                addEmail();
            }
        }
    }
}