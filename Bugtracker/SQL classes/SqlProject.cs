using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;


namespace Bugtracker
{
    class SqlProject
    {
        // only allow bugs to be posted on public projects once an allowedusers row is made with the userid/ projid
        // for private project, assume that project owner is ok with any allowed users to post bugs
        // do allowedusers stuff through this class? 

        private MySqlCommand _insertProject = new MySqlCommand("INSERT INTO project " +
         "(projName, user, description, isPrivate) VALUES (@projName, @user, @description, @isPrivate)", Connection.connToDb);

        public void InserProject(string projName, string user, string description, int isPrivate)
        {
            // Set parameters
            _insertProject.Parameters.Clear();
            _insertProject.Parameters.AddWithValue("@projName", projName);
            _insertProject.Parameters.AddWithValue("@user", user);
            _insertProject.Parameters.AddWithValue("@description", description);
            _insertProject.Parameters.AddWithValue("@isPrivate", isPrivate);

            using (Connection.connToDb = new MySqlConnection(Connection.connStr))
            {
                try
                {
                    _insertProject.Connection.Open();
                    _insertProject.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    //Will trial this with a .ToString of the sql query (i have no idea if this will work)
                    MessageBox.Show("This query will fail " + e.Message + _insertProject.ToString());
                }

            }

        }

        public static string FollowProject(string userId, string projectId)
        {
            string query = $"INSERT INTO projectusers (user, project) VALUES ({userId}, {projectId})";
            return query;
        }
        public static string GetProjects()
        {
            string query = $"SELECT * FROM project ORDER BY projName ASC";
            return query;
        }

        public static string GetUserProjects(string userid)
        {
            string query = $"SELECT * FROM project WHERE user = {userid} ORDER BY projName ASC";
            return query;
        }
        public static string CheckUserAccess(string userid, string projectId)
        {
            string query = $"SELECT * FROM allowedusers WHERE userId = {userid} AND idproject = {projectId}";
            return query;
        }



        /// <summary>
        /// gets all projects that a given user is following
        /// </summary>
        /// <param name="userid"></param>
        /// <returns></returns>
        public static string GetFollowedProjects(string userid)
        {
            string query = $"SELECT * FROM projectusers " +
                $"INNER JOIN project ON projectusers.user = project.user " +
                $"WHERE project.user = { userid }";
            return query;
        }

    }
}
