using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Bugtracker
{
    class SqlUpdate
    {
        public static string GetUpdates(string bugId)
        {
            string query = $"SELECT * FROM update WHERE bug = '{bugId}' ORDER BY timePosted ASC";
            return query;
        }
    }
}
