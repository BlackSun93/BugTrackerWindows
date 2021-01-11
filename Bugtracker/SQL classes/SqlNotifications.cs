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
    /// </summary>
    class SqlNotifications
    {
        /// <summary>
        /// insert new notification when a user becomes a follower or an allowed user on a project,
        ///  have to check if an instance already exists (in case upgrading user from follow to allow)
        /// </summary>
        private MySqlCommand _insertNotification = new MySqlCommand("INSERT INTO notification " +
        "(user, project, isFollow, isAllowed) " +
           "VALUES (@user, @project, @isFollow, @isAllowed)", Connection.connToDb);

        public void InsertNotification(string user, string project, string isFollow,  string isAllowed)
        {
            // Set parameters
            _insertNotification.Parameters.Clear();
            _insertNotification.Parameters.AddWithValue("@user", user);
            _insertNotification.Parameters.AddWithValue("@project", project);
            _insertNotification.Parameters.AddWithValue("@isFollow", isFollow);
            _insertNotification.Parameters.AddWithValue("@isAllowed", isAllowed);
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
        /// have to check over all notification instances to see which notification table rows
        ///  need a notifType creating, this will contain relevant info to send to relevant users
        /// </summary>
        private MySqlCommand _insertNotifType = new MySqlCommand("INSERT INTO notiftype " +
       "(toNotifyId, type, relatedId, bug, timestamp) " +
          "VALUES (@toNotifyId, @type, @relatedId, @bug, @timestamp)", Connection.connToDb);

        public void InsertNotifType(string toNotifyId, string type, string relatedId, string bug, DateTime timestamp)
        {
            // Set parameters
            _insertNotifType.Parameters.Clear();
            _insertNotifType.Parameters.AddWithValue("@toNotifyId", toNotifyId);
            _insertNotifType.Parameters.AddWithValue("@type", type);
            _insertNotifType.Parameters.AddWithValue("@relatedId", relatedId);
            _insertNotifType.Parameters.AddWithValue("@bug", bug);
            _insertNotifType.Parameters.AddWithValue("@timestamp", timestamp);
            using (Connection.connToDb = new MySqlConnection(Connection.connStr))
            {
                try
                {
                    _insertNotifType.Connection.Open();
                    _insertNotifType.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    //Will trial this with a .ToString of the sql query (i have no idea if this will work)
                    MessageBox.Show("This query will fail " + e.Message + _insertNotifType.ToString());
                }
            }
        }
    }
}
