using System;
using System.Data;
using static IT_Manager_ENCC.Modules.UiTools;
using static IT_Manager_ENCC.Modules.MYSQLConnect;
using IT_Manager_ENCC.Modules;
using System.Windows.Forms;

namespace IT_Manager_ENCC.Forms
{
    public partial class hardwareMovement : DevExpress.XtraEditors.XtraForm
    {
        private MainForm mainForm;
        private DataTable hardwareMovementList = new DataTable();

        public hardwareMovement(MainForm mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();

            // SetUserListComboBox(userComboBox, mainForm);

            hardwareMovementList.Columns.Add("Id");
            hardwareMovementList.Columns.Add("User");
            hardwareMovementList.Columns.Add("Hardware");
            hardwareMovementList.Columns.Add("State");
            hardwareMovementList.Columns.Add("Assignment date");
            hardwareMovementList.Columns.Add("Return date");

            LoadHardwareMovements();

            SetUserListComboBox(userComboBox, mainForm);
            SetHardwareStateListComboBox(statusComboBox, mainForm);
        }

        private void hardwareMovement_Load(object sender, EventArgs e)
        {
            // -----------------------------------------
            // DOCUMENT DECHARGE GENEREE AUTOMATIQUEMENT
            // -----------------------------------------
        }


        // SQL operations ------------

        private void LoadHardwareMovements()
        {
            hardwareMovementList.Rows.Clear();
            
            if (IsConnected("SELECT id_hardware,id,id_user,status, max(assignment_date) as date,return_date FROM `hardwaremovement` GROUP BY id_hardware ORDER BY date DESC;", false))
                FillHMovementDataGrid(myDR, hardwareMovementList, movementGrid, mainForm);
        }

        
        void AddHardware()
        {
            if (MYSQLConnect.IsConnected(MYSQLConnect.addSlash("Insert into hardwaremovement VALUES (NULL, '" +
                mainForm.userList[userComboBox.SelectedIndex].Id + "','" +
                hardwareIdTxt.Text + "','" +
                mainForm.hardwareStateList[statusComboBox.SelectedIndex].id + "'," + "NOW(), NULL)"), true))
            {
                // empty text boxes
                foreach (Control c in hardwareMovementFormContainer.Controls)
                {
                    if (c.GetType() == typeof(DevExpress.XtraEditors.TextEdit) ||
                        c.GetType() == typeof(DevExpress.XtraEditors.ComboBoxEdit))
                    {
                        c.Text = "";
                    }
                }

                LoadHardwareMovements();

                MessageBox.Show("movement added successfully");
            }
            else
            {
                MessageBox.Show("an error has occured during insertion");
            }
        }


        private void EditHardware(string movementId)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to return ?", "Edit confirmation message", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (IsConnected(addSlash("UPDATE hardwaremovement SET return_date = NOW() WHERE hardwaremovement.id = '" + movementId + "' Limit 1;"), true))
                {
                    LoadHardwareMovements(); // refresh list
                    MessageBox.Show("movement updated successfully");
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
            movementGrid.ContextMenuStrip = movementMenu;
        }

        private void gridView1_LostFocus(object sender, EventArgs e)
        {
            movementGrid.ContextMenuStrip = null;
        }

        private void searchTxt_EditValueChanged(object sender, EventArgs e)
        {
            gridView1.FindFilterText=searchTxt.Text;
        }

        private void addMovementBtn_Click(object sender, EventArgs e)
        {
            if (userComboBox.Text == string.Empty ||
                hardwareIdTxt.Text == string.Empty ||
                statusComboBox.Text == string.Empty)
            {
                MessageBox.Show("There are empty fields");
            }
            else
            {
                AddHardware();
            }

        }

        private void returnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditHardware(gridView1.GetFocusedRowCellValue("Id").ToString());
        }
    }
}