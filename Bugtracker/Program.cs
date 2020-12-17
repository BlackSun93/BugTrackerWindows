using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

        /*
         https://dev.mysql.com/downloads/connector/net/ 
        visual studio dl from mysql too to get the 'mysql' option in new dataconnection dropdown
        mysql workbench
        http://zetcode.com/csharp/mysql/ just some info on connections
        https://www.cdata.com/drivers/mysql/download/ado/ have to get the TRIAL version of mysql ADO (i think? i'm not sure if its used)
         I got mySql workbench for a GUI of the db because VS doesn;t display the db nicely
        right click the project - nuget manager - entityframework 6.4.4 + mysql data.entity 8.0.17 
        8.0.22 fails and is a known bug https://bugs.mysql.com/bug.php?id=97448
        */



namespace Bugtracker
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
