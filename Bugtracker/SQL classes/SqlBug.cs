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
        public static string UpdateCount(string id) //counts how many update are on a bug, this is used in drawbugpanels
            // 
        {
            string query = $"SELECT count(idupdate) as `count` FROM `update` WHERE bug = '{id}'";
            return query;
        }
        public static string RecentList(string id) //gets recent bugs
        {
            string query = $"SELECT * FROM bug WHERE poster = '{id}' AND status != 'solved' ORDER BY timePosted DESC LIMIT 5";
            return query;
        }
        public static string ToDoList(string id) //it would be nice to also order by OLDEST first
        {
            string query = $"SELECT * FROM bug WHERE poster = '{id}' AND status != 'solved' ORDER BY priority DESC LIMIT 5";
            return query;
        }
        public static string GetBugs(string id)
        {
            string query = $"SELECT * FROM bug WHERE project = '{id}' ORDER BY timePosted ASC";
            return query;
        }

        public static string GetOneBug (string id)
        {
            string query = $"SELECT * FROM bug WHERE idbug = '{id}'";
            return query;
        }

        /// <summary>
        /// gets all bugs that a given user is following
        /// </summary>
        /// <param name="userid"></param>
        /// <returns></returns>
        public static string GetFollowedBugs(string userid)
        {
            string query = $"SELECT * FROM bug " +
                $"INNER JOIN follow ON follow.bug = bug.idbug " +
                $"WHERE follow.user = { userid }";
            return query;
        }

        private MySqlCommand _updateStatus = new MySqlCommand("UPDATE bug SET status = @status WHERE idbug = @id",
            Connection.connToDb);
        public  void UpdateStatus(string id, string status)
        {
            _updateStatus.Parameters.Clear();
            _updateStatus.Parameters.AddWithValue("@status", status);
            _updateStatus.Parameters.AddWithValue("@id", id);
            using (Connection.connToDb = new MySqlConnection(Connection.connStr))
            {
                try
                {
                    _updateStatus.Connection.Open();
                    _updateStatus.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    //Will trial this with a .ToString of the sql query (i have no idea if this will work)
                    MessageBox.Show("This query will fail " + e.Message + _updateStatus.ToString());
                }
            }
        }

        //public static string 
        private MySqlCommand _insertBug = new MySqlCommand("INSERT INTO bug " +
         "(title, description, location, timePosted, status, poster, project, priority) " +
            "VALUES (@title, @description, @location, @timePosted, @status, @poster, @project, @priority)", Connection.connToDb);

        public void InsertBug(string title, string description, string location, DateTime timePosted, string status,
                                                                    string poster, string project, string priority)
        {
            // Set parameters
            _insertBug.Parameters.Clear();
            _insertBug.Parameters.AddWithValue("@title", title);
            _insertBug.Parameters.AddWithValue("@description", description);
            _insertBug.Parameters.AddWithValue("@location", location);
            _insertBug.Parameters.AddWithValue("@timePosted", timePosted);
            _insertBug.Parameters.AddWithValue("@status", status);
            _insertBug.Parameters.AddWithValue("@poster", poster);
            _insertBug.Parameters.AddWithValue("@project", project);
            _insertBug.Parameters.AddWithValue("@priority", priority);

            using (Connection.connToDb = new MySqlConnection(Connection.connStr))
            {
                try { 
                    _insertBug.Connection.Open();
                    _insertBug.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    //Will trial this with a .ToString of the sql query (i have no idea if this will work)
                    MessageBox.Show("This query will fail " + e.Message + _insertBug.ToString());
                }

            }

        }
    }
}
