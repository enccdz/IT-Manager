using System;
using System.Data;
using static IT_Manager_ENCC.Modules.MYSQLConnect;
using static IT_Manager_ENCC.Modules.UiTools;

namespace IT_Manager_ENCC.Forms.Park
{
    public partial class hardwareSearch : DevExpress.XtraEditors.XtraForm
    {
        private DataTable hardwares;
        private String SearchQuerry = "";
        private MainForm mainForm;

        public hardwareSearch(MainForm mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();

            // Initialise Data table
            hardwares = new DataTable();
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

            LoadFilteredHardwares();
        }

        // SQL Operations -----------------
        private void LoadFilteredHardwares()
        {
            hardwares.Rows.Clear();

            // building search querry
            if(!String.IsNullOrEmpty(SearchTxt.Text))
            {
                SearchQuerry = "SELECT hardware.* FROM hardware,hardwaretypes,hardwarestates WHERE ";
                SearchQuerry += "hardware.Type = hardwaretypes.id AND hardware.State = hardwarestates.id AND (";
                //SearchQuerry += "hardwaretypes.name LIKE '%" + SearchTxt.Text + "%' OR "; 
                //SearchQuerry += "hardwarestates.name LIKE '%" + SearchTxt.Text + "%' OR ";
                SearchQuerry += "hardware.inventorycode LIKE '%" + SearchTxt.Text + "%' OR ";
                SearchQuerry += "hardware.serialcode LIKE '%" + SearchTxt.Text + "%' OR ";
                SearchQuerry += "hardware.Manufacturer LIKE '%" + SearchTxt.Text + "%' OR ";
                SearchQuerry += "hardware.Model LIKE '%" + SearchTxt.Text + "%' OR ";
                SearchQuerry += "hardware.description LIKE '%" + SearchTxt.Text + "%' OR ";
                SearchQuerry += "hardware.office LIKE '%" + SearchTxt.Text + "%')";
            }
            else
            {
                SearchQuerry = "SELECT hardware.* FROM hardware";
                if (!String.IsNullOrEmpty(startDateBox.Text) || !String.IsNullOrEmpty(endDateBox.Text))
                {
                    SearchQuerry += " WHERE 1";
                }
            }

            if (!String.IsNullOrEmpty(startDateBox.Text) || !String.IsNullOrEmpty(endDateBox.Text))
            {
                if (!String.IsNullOrEmpty(startDateBox.Text))
                    SearchQuerry += " AND hardware.creationdate >= '" + startDateBox.DateTime.ToString("yyyy-MM-dd HH:mm:ss") + "'";

                if (!String.IsNullOrEmpty(endDateBox.Text))
                    SearchQuerry += " AND hardware.creationdate <= '" + endDateBox.DateTime.ToString("yyyy-MM-dd HH:mm:ss") + "'";
            }
            
            

            SearchQuerry += ";";

            if (IsConnected(SearchQuerry, false))
                FillHardwareDataGrid(myDR, hardwares, hardwareGrid, mainForm);
        }



        // Ui input -----------------------

        private void SearchTxt_EditValueChanged(object sender, EventArgs e)
        {
            LoadFilteredHardwares();
        }

        private void DateBox_EditValueChanged(object sender, EventArgs e)
        {
            LoadFilteredHardwares();

            // Console.WriteLine(startDateBox.Text +"          "+endDateBox.Text);

            /*if (!String.IsNullOrEmpty(startDateBox.Text) && !String.IsNullOrEmpty(endDateBox.Text))
            {
                DateTime startDate = Convert.ToDateTime(startDateBox.Text);
                DateTime endDate = Convert.ToDateTime(endDateBox.Text);

                if (startDate < endDate)
                {
                    Console.WriteLine("start < X < end");
                }
                else if (startDate > endDate)
                {
                    Console.WriteLine(" Error ");
                }
                else
                {
                    Console.WriteLine("start = X = end");
                }
            }
            else if (!String.IsNullOrEmpty(startDateBox.Text))
            {
                Console.WriteLine("start < X");
            }
            else if (!String.IsNullOrEmpty(endDateBox.Text))
            {
                Console.WriteLine("X < end");
            }
            else
            {
                Console.WriteLine("NOTHING");
            }
            */
        }
    }
}