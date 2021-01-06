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
        private MySqlCommand _insertProject = new MySqlCommand("INSERT INTO project " +
         "(projName, user, description) VALUES (@projName, @user, @description)", Connection.connToDb);

        public void InserProject(string projName, string user, string description)
        {
            // Set parameters
            _insertProject.Parameters.Clear();
            _insertProject.Parameters.AddWithValue("@projName", projName);
            _insertProject.Parameters.AddWithValue("@user", user);
            _insertProject.Parameters.AddWithValue("@description", description);

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
    }
}
