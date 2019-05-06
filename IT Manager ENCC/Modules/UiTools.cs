using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using IT_Manager_ENCC.Beings;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using static IT_Manager_ENCC.Modules.Tools;

namespace IT_Manager_ENCC.Modules
{
    public class UiTools
    {

        public static void SetUserListComboBox(ComboBoxEdit userComboBox, MainForm mainForm)
        {
            foreach (User U in mainForm.userList)
            {
                userComboBox.Properties.Items.Add(U.fullName);
            }
        }

        public static void SetHardwareTypeListComboBox(ComboBoxEdit hardwareComboBox, MainForm mainForm)
        {
            foreach (HardwareType HT in mainForm.hardwareTypeList)
            {
                hardwareComboBox.Properties.Items.Add(HT.name);
            }
        }

        public static void SetHardwareStateListComboBox(ComboBoxEdit userComboBox, MainForm mainForm)
        {
            foreach (HardwareState HS in mainForm.hardwareStateList)
            {
                userComboBox.Properties.Items.Add(HS.name);
            }
        }

        public static void FillHardwareDataGrid(MySqlDataReader myDR, DataTable table, GridControl grid, MainForm mainForm)
        {
            if (myDR.HasRows)
            {
                while (myDR.Read())
                {
                    DataRow tr = table.NewRow();

                    tr[0] = myDR.GetString(0);
                    //tr[1] = GetUserNameById(myDR.GetString(1), mainForm.userList);
                    // Console.WriteLine(myDR.GetString(1));
                    tr[1] = GetHardwareTypeNameById(myDR.GetString(1), mainForm.hardwareTypeList);
                    tr[2] = GetHardwareStateNameById(myDR.GetString(2), mainForm.hardwareStateList);
                    for (int i = 3; i < table.Columns.Count; i++)
                    {
                        //Console.WriteLine(myDR.GetString(i).ToString());
                        tr[i] = myDR.GetString(i);
                    }

                    table.Rows.Add(tr);
                }

                grid.DataSource = table;
            }
        }

        public static void FillHMovementDataGrid(MySqlDataReader myDR, DataTable table, GridControl grid, MainForm mainForm)
        {
            if (myDR.HasRows)
            {
                while (myDR.Read()) 
                {
                    DataRow tr = table.NewRow();
                    tr[2] = myDR.GetString(0);

                    tr[0] = myDR.GetString(1);
                    tr[1] = GetUserNameById(myDR.GetString(2), mainForm.userList);
                    
                    tr[3] = GetHardwareStateNameById(myDR.GetString(3), mainForm.hardwareStateList);
                    tr[4] = myDR.GetString(4);
                    try { tr[5] = myDR.GetString(5); } catch(Exception E) { } 

                    table.Rows.Add(tr);
                }

                grid.DataSource = table;
            }
        }

        public static void FillEmailDataGrid(MySqlDataReader myDR, DataTable table, GridControl grid, MainForm mainForm)
        {
            if (myDR.HasRows)
            {
                while (myDR.Read())
                {
                    DataRow tr = table.NewRow();

                    tr[0] = myDR.GetString(0);
                    tr[1] = myDR.GetString(1);
                    tr[2] = myDR.GetString(2);
                    tr[3] = myDR.GetString(3);

                    for (int i = 3; i < table.Columns.Count; i++)
                    {
                        tr[i] = myDR.GetString(i);
                    }

                    table.Rows.Add(tr);
                }

                grid.DataSource = table;
            }
        }

    }
}
