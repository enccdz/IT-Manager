using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace IT_Manager_ENCC.Modules
{
    class MYSQLConnect
    {
        public static MySqlConnection myConn = new MySqlConnection();
        public static MySqlCommand myCmd = new MySqlCommand();
        public static MySqlDataReader myDR;
        public static string instance, username, password, constring;
        public static string serveur = "192.168.0.3";
        public static string DATABASE_NAME = "itmanagerdb";
        public static int user_id = 0;



        public static bool IsConnected(string strQry, bool ver, string con = "")
        {
            // Dim main As New Mainfrm
            Control.CheckForIllegalCrossThreadCalls = false;
            try
            {
                if (myConn.State == ConnectionState.Open)// close open connection if exist
                    myConn.Close();
                // MsgBox("Data Source=" & serveur & "\" & instance & ";Initial Catalog=ALIECO;Persist Security Info=True;User ID=" & username & ";Password=" & password & "")
                // If con <> "" Then
                // myConn.ConnectionString = con
                // Else
                constring = "Server=" + serveur + ";Database=" + DATABASE_NAME + ";Uid=user;Pwd=123456";
                myConn.ConnectionString = constring;
                // End If
                Console.WriteLine(strQry);

                myConn.Open();
                // myCmd.CommandText = "INSERT INTO `informatique_query_log`(`id`,`hostname`,`query_text`,`entry_date`)VALUES(NULL,'" + My.Computer.Name + "','" + mysql_escape_string(strQry).Replace(@"\\", @"\") + "',NOW());" + strQry;
                // Console.WriteLine(myCmd.CommandText)
                myCmd.CommandText = strQry;
                myCmd.Connection = myConn;
                if (ver)
                    myCmd.ExecuteNonQuery(); // For updating query
                else
                    myDR = myCmd.ExecuteReader(); // For reading query

            }
            catch (MySqlException ex)
            {
                Clipboard.SetText(strQry);
                MessageBox.Show("database error" + ex.Message);
                // MessageBoxEx.Show("Erreur dans la connexion au serveur : N° 3377 " & Environment.NewLine & "Veuillez contacter le développeur au 123", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                return false;
            }
            return true;
        }

        public static string addSlash(String s)
        {
            return s.Replace("'","\'");
        }
    }
}
