using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
namespace Bugtracker
{
    /// <summary>
    /// notification ware hard to figure out because a user can follow a bug as well as a project
    /// to avoid having a table for each type of notification (new bug on project, user requesting access
    /// new comment on bug, new project/ bug status, new user following project/ bug)
    /// i have made the notification table which willstore a user, a project and their level of access
    /// and a notiftype table will ref this table with relevant information
    /// new notiftype object for each relevant user for each new notification
    /// 
    /// 
    /// payload : target split
    /// payload = potentially all notif types, all ids, types, stauses, etc etc - ONLY 1 LINE MADE
    /// tagrget/s = all users to notify- foreach user in users (users = select userid where {userid} AND {proj/bugid} in followtable
    ///  insert into TONOTIFY {user}, {notifId} read(default false)
    ///  if {thisuser} in tonotify table select * from tonotify inner join notificationpayload where {thisuser}
    ///  more granularity on paylodnotif, targetnotif
    ///  
    /// </summary>
    class SqlNotifications
    {
        /// <summary>
        /// insert new notification when a user becomes a follower or an allowed user on a project,
        ///  have to check if an instance already exists (in case upgrading user from follow to allow)
        /// </summary>
        private MySqlCommand _insertNotification = new MySqlCommand("INSERT INTO notification " +
        "(usernotif, project, bug, `update`, type, status, timestamp) " +
           "VALUES (@usernotif, @project, @bug, @update, @type, @status, @timestamp)", Connection.connToDb);

        public void InsertNotification(string usernotif, string project, string bug,  string update,
            string type, string status, DateTime timestamp)
        {
            // Set parameters
            _insertNotification.Parameters.Clear();
            _insertNotification.Parameters.AddWithValue("@usernotif", usernotif);
            _insertNotification.Parameters.AddWithValue("@project", project);
            _insertNotification.Parameters.AddWithValue("@bug", bug);
            _insertNotification.Parameters.AddWithValue("@update", update);
            _insertNotification.Parameters.AddWithValue("@type", type);
            _insertNotification.Parameters.AddWithValue("@status", status);
            _insertNotification.Parameters.AddWithValue("@timestamp", timestamp);
            using (Connection.connToDb = new MySqlConnection(Connection.connStr))
            {
                try
                {
                    _insertNotification.Connection.Open();
                    _insertNotification.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    //Will trial this with a .ToString of the sql query (i have no idea if this will work)
                    MessageBox.Show("This query will fail " + e.Message + _insertNotification.ToString());
                }
            }
        }

        /// <summary>
        /// handles notifying relevant users of a notification and tracking if they have read it or not
        /// </summary>
        private MySqlCommand _insertToNotify = new MySqlCommand("INSERT INTO tonotify " +
       "(notifid, userid, `read`) " +
          "VALUES (@notifid, @userid, @read)", Connection.connToDb);

        public void InsertToNotify(string notifid, string userid, string read)
        {
            // Set parameters
            _insertToNotify.Parameters.Clear();
            _insertToNotify.Parameters.AddWithValue("@notifid", notifid);
            _insertToNotify.Parameters.AddWithValue("@userid", userid);
            _insertToNotify.Parameters.AddWithValue("@read", read);
            using (Connection.connToDb = new MySqlConnection(Connection.connStr))
            {
                try
                {
                    //_insertToNotify.Connection.Open();
                    _insertToNotify.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    //Will trial this with a .ToString of the sql query (i have no idea if this will work)
                    MessageBox.Show("This query will fail " + e.Message + _insertToNotify.ToString());
                }
            }
        }
    }
}
