using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Bugtracker
{
    //CALLING TABLE UPDATE WAS A BAD IDEA, IF YOU NEED TO USE TABLE NAME, SURROUND WITH `` AS UPDATE IS KEYWORD
    class SqlUpdate
    {
        public static string GetUpdates(string bugId)
        {
            string query = $"SELECT * FROM `update` WHERE bug = '{bugId}'"; // ORDER BY timePosted ASC";
            return query;
        }

        private MySqlCommand _insertUpdate = new MySqlCommand("INSERT INTO `update` " +
         "(postedBy, comment, bug, newStatus) VALUES (@postedBy, @comment, @bug, @newStatus)", Connection.connToDb);

        public void InsertUpdate(string postedBy, string comment, string bug, string status)
        {
            // Set parameters
            _insertUpdate.Parameters.Clear();
            _insertUpdate.Parameters.AddWithValue("@postedBy", postedBy);
            _insertUpdate.Parameters.AddWithValue("@comment", comment);
            _insertUpdate.Parameters.AddWithValue("@bug", bug);
            _insertUpdate.Parameters.AddWithValue("@newStatus", status);

            using (Connection.connToDb = new MySqlConnection(Connection.connStr))
            {
                try
                {
                    _insertUpdate.Connection.Open();
                    _insertUpdate.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    //Will trial this with a .ToString of the sql query (i have no idea if this will work)
                    MessageBox.Show("This query will fail " + e.Message + _insertUpdate.ToString());
                }

            }

        }
    }
}
