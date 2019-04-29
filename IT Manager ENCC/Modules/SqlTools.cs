using System.Collections.Generic;
using static IT_Manager_ENCC.Modules.MYSQLConnect;
using IT_Manager_ENCC.Beings;

namespace IT_Manager_ENCC.Modules
{
    public class SqlTools
    {

        public static void RefreshUserList(MainForm mainForm)
        {
            if (IsConnected("SELECT ID,fullname FROM `user` ", false) && myDR.HasRows)
            {
                mainForm.userList.Clear();// = new List<User>();

                while (myDR.Read())
                {
                    User newUser = new User();
                    newUser.Id = int.Parse(myDR.GetString(0));
                    newUser.fullName = myDR.GetString(1);
                    mainForm.userList.Add(newUser);
                }
            }
        }

        public static void RefreshHardwareTypeList(MainForm mainForm)
        {
            if (IsConnected("SELECT id,name FROM `hardwaretypes` ", false) && myDR.HasRows)
            {
                mainForm.hardwareTypeList.Clear();// = new List<HardwareType>();

                while (myDR.Read())
                {
                    HardwareType hardwareType = new HardwareType();
                    hardwareType.id = int.Parse(myDR.GetString(0));
                    hardwareType.name = myDR.GetString(1);
                    mainForm.hardwareTypeList.Add(hardwareType);
                }
            }
        }

        public static void RefreshHardwareStateList(MainForm mainForm)
        {
            if (IsConnected("SELECT id,name FROM `hardwarestates` ", false) && myDR.HasRows)
            {
                mainForm.hardwareStateList.Clear();// = new List<HardwareState>();

                while (myDR.Read())
                {
                    HardwareState hardwareState = new HardwareState();
                    hardwareState.id = int.Parse(myDR.GetString(0));
                    hardwareState.name = myDR.GetString(1);
                    mainForm.hardwareStateList.Add(hardwareState);
                }
            }
        }



    }
}
