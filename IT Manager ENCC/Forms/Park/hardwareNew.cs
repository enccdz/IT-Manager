using System;
using System.Windows.Forms;
using IT_Manager_ENCC.Modules;
using static IT_Manager_ENCC.Modules.UiTools;

namespace IT_Manager_ENCC.Forms
{
    public partial class hardwareNew : DevExpress.XtraEditors.XtraForm
    {
        private MainForm mainForm;

        public hardwareNew(MainForm mainForm)
        {
            this.mainForm = mainForm;

            InitializeComponent();

            // SetUserListComboBox(userComboBox, mainForm);
            SetHardwareTypeListComboBox(typeComboBox, mainForm);
            SetHardwareStateListComboBox(stateComboBox, mainForm);
        }

        // SQL operations -----------------------------

        void AddHardware()
        {
            if (MYSQLConnect.IsConnected(MYSQLConnect.addSlash("Insert into hardware VALUES (NULL, '" +
                mainForm.hardwareTypeList[typeComboBox.SelectedIndex].id + "','" +
                mainForm.hardwareStateList[stateComboBox.SelectedIndex].id + "','" +
                officeTxt.Text+ "','" +
                inventoryCodeTxt.Text + "','" +
                serialTxt.Text + "','" +
                manufacturerTxt.Text + "','" +
                modelTxt.Text + "','" +
                descriptionTxt.Text + "',NOW())"), true))
            {

                // empty text boxes
                foreach (Control c in addhardwareFormContainer.Controls)
                {
                    if (c.GetType() == typeof(DevExpress.XtraEditors.TextEdit) || 
                        c.GetType() == typeof(DevExpress.XtraEditors.ComboBoxEdit))
                    {
                        c.Text = "";
                    }
                }

                MessageBox.Show("hardware added successfully");
            }
            else
            {
                MessageBox.Show("an error has occured during insertion");
            }
        }



        // User input ---------------------------------
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (typeComboBox.Text == string.Empty ||
                manufacturerTxt.Text == string.Empty ||
                modelTxt.Text == string.Empty ||
                stateComboBox.Text == string.Empty ||
                officeTxt.Text == string.Empty ||
                inventoryCodeTxt.Text == string.Empty)
            {
                MessageBox.Show("There are empty fields");
            }
            else
            {
                AddHardware();
            }
        }
        
    }
}