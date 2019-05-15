using System;
using System.Data;
using System.Windows.Forms;
using static IT_Manager_ENCC.Modules.MYSQLConnect;
using static IT_Manager_ENCC.Modules.UiTools;
using static IT_Manager_ENCC.Modules.Tools;

namespace IT_Manager_ENCC.Forms
{
    public partial class hardwareList : DevExpress.XtraEditors.XtraForm
    {
        private MainForm mainForm;
        private DataTable hardwares = new DataTable();
        private string focussedUserId;
        //Boolean found;
        //int index;

        public hardwareList(MainForm mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();

            hardwares.Columns.Add("Id");
            hardwares.Columns.Add("Type");
            hardwares.Columns.Add("State");
            hardwares.Columns.Add("Office");
            hardwares.Columns.Add("Inventory Code");
            hardwares.Columns.Add("Serial number");
            hardwares.Columns.Add("Manufacturer");
            hardwares.Columns.Add("Model");
            hardwares.Columns.Add("Description");
            hardwares.Columns.Add("Creation date");

            // SetUserListComboBox(userComboBox, mainForm);
            SetHardwareTypeListComboBox(typeComboBox, mainForm);
            SetHardwareStateListComboBox(stateComboBox, mainForm);

            LoadHardwares();
            
            editBtn.Enabled = false;
            
        }

        // SQL operations ------------


        private void LoadHardwares()
        {
            hardwares.Rows.Clear();

            if (IsConnected("SELECT * FROM `hardware` ", false))
                FillHardwareDataGrid(myDR, hardwares, hardwareGrid, mainForm);
        }

        private void RemoveHardware(string hardwareId)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete ?", "Remove confirmation message", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                IsConnected("DELETE FROM `hardware` WHERE Id = '" + addSlash(hardwareId) + "' LIMIT 1;", true);
                LoadHardwares();
            }
        }
        
        private void EditHardware(string hardwareId)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to edit ?", "Edit confirmation message", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //Console.WriteLine();
                // Console.WriteLine(typeComboBox.SelectedIndex.ToString() + "    " + stateComboBox.SelectedIndex.ToString());
                if (IsConnected(addSlash("UPDATE hardware SET" +
                // " ID_User='" + mainForm.userList[userComboBox.SelectedIndex].Id + "'," +
                " Type='" + mainForm.hardwareTypeList[typeComboBox.SelectedIndex].id.ToString() + "'," +
                " State='" + mainForm.hardwareStateList[stateComboBox.SelectedIndex].id.ToString()  + "'," +
                " Office='" + officeTxt.Text + "'," +
                " inventorycode='" + inventoryCodeTxt.Text + "'," +
                " serialcode='" + serialTxt.Text + "'," +
                " Manufacturer='" + manufacturerTxt.Text + "'," +
                " Model='" + modelTxt.Text + "'," +
                " description='" + descriptionTxt.Text + "'" +
                " WHERE hardware.id = '" + hardwareId + "' Limit 1;" +
                ""), true))
                {
                    LoadHardwares(); // refresh list
                    MessageBox.Show("hardware updated successfully");

                    // change add button to edit
                    editBtn.Enabled = false;

                    // empty text boxes
                    foreach (Control c in hardwareFormContainer.Controls)
                    {
                        if (c.GetType() == typeof(DevExpress.XtraEditors.TextEdit) ||
                            c.GetType() == typeof(DevExpress.XtraEditors.ComboBoxEdit))
                        {
                            c.Text = "";
                        }
                    }
                }
                else
                { 
                    MessageBox.Show("an error has occured during update");
                }
            }

        }
        







        // User input -----------------

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            hardwareGrid.ContextMenuStrip = hardwaresMenu;
        }

        private void gridView1_LostFocus(object sender, EventArgs e)
        {
            hardwareGrid.ContextMenuStrip = null;
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // copy user data to text fields
            typeComboBox.Text = gridView1.GetFocusedRowCellValue("Type").ToString();
            //typeComboBox.SelectedText = hardwares.Rows[gridView1.GetSelectedRows()[0]][1].ToString();
            stateComboBox.Text = gridView1.GetFocusedRowCellValue("State").ToString();
            //stateComboBox.SelectedText = hardwares.Rows[gridView1.GetSelectedRows()[0]][2].ToString();

            officeTxt.Text = hardwares.Rows[gridView1.GetSelectedRows()[0]][3].ToString();
            inventoryCodeTxt.Text = hardwares.Rows[gridView1.GetSelectedRows()[0]][4].ToString();
            serialTxt.Text = hardwares.Rows[gridView1.GetSelectedRows()[0]][5].ToString();
            manufacturerTxt.Text = hardwares.Rows[gridView1.GetSelectedRows()[0]][6].ToString();
            modelTxt.Text = hardwares.Rows[gridView1.GetSelectedRows()[0]][7].ToString();
            descriptionTxt.Text = hardwares.Rows[gridView1.GetSelectedRows()[0]][8].ToString();

            // change add button to edit
            editBtn.Enabled = true;

            // save current user id
            focussedUserId = gridView1.GetFocusedRowCellValue("Id").ToString();
        }

        private void deleateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveHardware(gridView1.GetFocusedRowCellValue("Id").ToString());
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            if (typeComboBox.Text == string.Empty ||
                manufacturerTxt.Text == string.Empty ||
                modelTxt.Text == string.Empty ||
                stateComboBox.Text == string.Empty ||
                // userComboBox.Text == string.Empty ||
                officeTxt.Text == string.Empty ||
                inventoryCodeTxt.Text == string.Empty)
            {
                MessageBox.Show("There are empty fields");
            }
            else
            {
                EditHardware(focussedUserId);
            }
        }
    }
}