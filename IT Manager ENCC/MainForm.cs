using IT_Manager_ENCC.Beings;
using IT_Manager_ENCC.Forms;
using IT_Manager_ENCC.Forms.Park;
using IT_Manager_ENCC.Forms.SQL;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static IT_Manager_ENCC.Modules.SqlTools;

namespace IT_Manager_ENCC
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private ticketNew TicketForm;
        private settingUsers UsersForm;
        private settingAdmins AdminsForm;
        private ticketDaily DailyTicketsForm;
        private ticketSearch SearchTicketsForm;
        private reportUsersTickets UsersTicketsForm;
        private reportAdminRepairs AdminRepairsForm;
        private hardwareNew newHardwareForm;
        private hardwareList hardwareListForm;
        private hardwareSearch hardwareSearchForm;
        private hardwareMovement hardwareMovementForm;
        private reportsRepairs reportsRepairsForm;
        private connectionChangeServer changeServerForm;
        private insertionsNewDbFromFile newDbFromFileForm;
        private insertionsNewDbExisting newDbExistingForm;
        private usersAddUser AddUserForm;
        private usersRemoveUser removeUserForm;
        private resetsRemoveAuthentification RemoveAuthentificationForm;
        private resetsAddAuthentification AddAuthentificationForm;
        private resetsResetPermitions ResetPermitionsForm;
        private backupDatabase BackupDatabaseForm;

        public int num = 0;        
        public List<User> userList = new List<User>();
        public List<HardwareType> hardwareTypeList = new List<HardwareType>();
        public List<HardwareState> hardwareStateList = new List<HardwareState>();


        public MainForm()
        {
            InitializeComponent();
            
            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.Skins.SkinManager.EnableMdiFormSkins();
            DevExpress.LookAndFeel.LookAndFeelHelper.ForceDefaultLookAndFeelChanged();

            RefreshUserList(this); // load userList
            RefreshHardwareTypeList(this); // load hardwareTypeList
            RefreshHardwareStateList(this); // load hardwareStateList

            if (num>0) badge1.Visible = true; // insted of num, use ticketList.count from DB
        }

        private void MainFrm_Load(object sender, EventArgs e)
        {
            //if(MYSQLConnect.IsConnected("SELECT * FROM `comptes` ", false))
            //if (MYSQLConnect.myDR.HasRows)
            //{
            //    while (MYSQLConnect.myDR.Read())
            //    {
            //        badge1.Visible = false;
                    
            //       //MessageBox.Show(MYSQLConnect.myDR.GetString("date"));//MYSQLConnect.myDR.GetString(1)
            //    }
            //}

            MdiClient ctlMDI;

            // Loop through all of the form's controls looking
            // for the control of type MdiClient.
            foreach (Control ctl in this.Controls)
            {
                try
                {
                    // Attempt to cast the control to type MdiClient.
                    ctlMDI = (MdiClient)ctl;

                    // Set the BackColor of the MdiClient control.
                    ctlMDI.BackColor = this.BackColor;
                }
                catch (InvalidCastException exc)
                {
                    // Catch and ignore the error if casting failed.
                }
            }
        }



        // SQL operations -----------------------------
        








        // UI -------------------------------
        public void updateBadge() // update when ticket created / deleated
        {
            if (num > 0)
                badge1.Visible = true;
            badge1.Properties.Text = num.ToString();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            TicketForm = new ticketNew(this);
            TicketForm.MdiParent = this;
            TicketForm.Show();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UsersForm = new settingUsers();
            UsersForm.MdiParent = this;
            UsersForm.Show();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AdminsForm = new settingAdmins();
            AdminsForm.MdiParent = this;
            AdminsForm.Show();
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DailyTicketsForm = new ticketDaily();
            DailyTicketsForm.MdiParent = this;
            DailyTicketsForm.Show();
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SearchTicketsForm = new ticketSearch();
            SearchTicketsForm.MdiParent = this;
            SearchTicketsForm.Show();
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UsersTicketsForm = new reportUsersTickets();
            UsersTicketsForm.MdiParent = this;
            UsersTicketsForm.Show();
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AdminRepairsForm = new reportAdminRepairs();
            AdminRepairsForm.MdiParent = this;
            AdminRepairsForm.Show();
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            newHardwareForm = new hardwareNew(this);
            newHardwareForm.MdiParent = this;
            newHardwareForm.Show();
        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            hardwareListForm = new hardwareList(this);
            hardwareListForm.MdiParent = this;
            hardwareListForm.Show();
        }

        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            hardwareSearchForm = new hardwareSearch(this);
            hardwareSearchForm.MdiParent = this;
            hardwareSearchForm.Show();
        }

        private void barButtonItem12_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            hardwareMovementForm = new hardwareMovement(this);
            hardwareMovementForm.MdiParent = this;
            hardwareMovementForm.Show();
        }

        private void barButtonItem11_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            reportsRepairsForm = new reportsRepairs();
            reportsRepairsForm.MdiParent = this;
            reportsRepairsForm.Show();
        }

        private void barButtonItem21_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            changeServerForm = new connectionChangeServer();
           // changeServerForm.MdiParent = this;
            changeServerForm.ShowDialog();
        }


        private void barButtonItem13_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            newDbFromFileForm = new insertionsNewDbFromFile();
            newDbFromFileForm.MdiParent = this;
            newDbFromFileForm.Show();
        }

        private void barButtonItem14_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            newDbExistingForm = new insertionsNewDbExisting();
            newDbExistingForm.MdiParent = this;
            newDbExistingForm.Show();
        }

        private void barButtonItem15_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AddUserForm = new usersAddUser();
            AddUserForm.MdiParent = this;
            AddUserForm.Show();
        }

        private void barButtonItem16_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            removeUserForm = new usersRemoveUser();
            removeUserForm.MdiParent = this;
            removeUserForm.Show();
        }

        private void barButtonItem18_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RemoveAuthentificationForm = new resetsRemoveAuthentification();
            RemoveAuthentificationForm.MdiParent = this;
            RemoveAuthentificationForm.Show();
        }

        private void barButtonItem19_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AddAuthentificationForm = new resetsAddAuthentification();
            AddAuthentificationForm.MdiParent = this;
            AddAuthentificationForm.Show();
        }

        private void barButtonItem20_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ResetPermitionsForm = new resetsResetPermitions();
            ResetPermitionsForm.MdiParent = this;
            ResetPermitionsForm.Show();
        }

        private void barButtonItem17_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            BackupDatabaseForm = new backupDatabase();
            //BackupDatabaseForm.MdiParent = this;
            BackupDatabaseForm.ShowDialog();
        }
    }
}
 