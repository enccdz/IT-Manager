using IT_Manager_ENCC.Beings;
using System;
using System.Collections.Generic;

namespace IT_Manager_ENCC.Modules
{
    public class Tools
    {
        public static String GetUserNameById(String index, List<User> userList)
        {
            Console.WriteLine(index);
            int i = 0;
            Boolean found = false;
            while(!found && i< userList.Count)
            {
                if (userList[i].Id.ToString().Equals(index))
                    return userList[i].fullName;
                i++;
            }
            return "--";
        }

        public static String GetHardwareTypeNameById(String index, List<HardwareType> hardwareTypeList)
        {
            int i = 0;
            Boolean found = false;
            while (!found && i < hardwareTypeList.Count)
            {
                if (hardwareTypeList[i].id.ToString().Equals(index))
                    return hardwareTypeList[i].name;
                i++;
            }
            return "--";
        }

        public static String GetHardwareStateNameById(String index, List<HardwareState> hardwareStateList)
        {
            int i = 0;
            Boolean found = false;
            while (!found && i < hardwareStateList.Count)
            {
                if (hardwareStateList[i].id.ToString().Equals(index))
                    return hardwareStateList[i].name;
                i++;
            }
            return "--";
        }

    }
}
