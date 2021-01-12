using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Bugtracker
{
    class SqlFollow
    {
        public static string FollowProject(string userId, string projectId)
        {
            string query = $"INSERT INTO followproject (user, project, isFollow) VALUES ({userId}, {projectId}, 1)";
            return query;
        }
        public static string UnFollowProject(string userId, string projectId)
        {
            string query = $"DELETE FROM  followproject  WHERE user = {userId} and project = {projectId}";
            return query;
        }
    }
}
