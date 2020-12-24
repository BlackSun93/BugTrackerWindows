using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Bugtracker
{
    class SqlBug
    {
        public static string GetBugs(string id)
        {
            string query = $"SELECT * FROM bug WHERE project = '{id}' ORDER BY timePosted ASC";
            return query;
        }
    }
}
