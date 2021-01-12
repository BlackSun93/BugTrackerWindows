using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bugtracker
{
    public partial class NotificationsForm : Form
    {
        Window display;
        public NotificationsForm(Window window)
        {
            InitializeComponent();
            display = window;
            Size = new Size(window.Width, window.Height);
            LoadNotifications(UserObject.loggedUser.iduser);
        }



        private void LoadNotifications(string userid)
        {
            // get all results from notification table where user = userid
            // join notiftype AND notification tables where notification.idnotification = notiftype.toNotifyId
            // order by unread first and timestamp
            // depending on notif type, do something with related id
            // types are: reqUserAccess, newBug, newPost, newFollowProj, newFollowBug, bugStatus, projStatus
            // may need type to advise user of a comment written on their update
            ///// ///// ///// ///// ///// ///// ///// ///// ///// ///// ///// ///// ///// /////
            // example: if notifType == reqUserAccess: panelText = USER foo HAS REQUESTED ACCESS TO PROJECT bar
            // foo = SELECT user.username WHERE iduser = notiftype.relatedId
            // bar = notification.project
            // example: if notifType == newBug: panelText = USER foo HAS POSTED NEW BUG bar IN PROJECT wiz 
            // foo = SELECT user.username FROM user WHERE userid = notiftype.relatedid
            // bar = notification.bug
            // wiz = notification.project
            ///// ///// ///// ///// ///// ///// ///// ///// ///// ///// ///// ///// ///// /////
            // inserting a new bug needs to create a new line for all userids
            // users = select users, isfollow, isallow, idnotification from notification where project == thisProject AND follow == 1
            // for each user in users
            // INSERT INTO notiftype VALUES toNotify, type, relatedId, bug, timestamp, read (default as false)
            // idnotification, newBug, newbug.poster, bug'sID (will have to insert then deref id), datetime.now
            //  ///// ///// ///// ///// ///// ///// ///// ///// ///// ///// ///// ///// /////
            // a new update on a bug will need to notify all users who are following the bug
            // INSERT INTO update (postedBy, comment, bug, status, timestamp)
            // usersToNotify = SELECT * FROM notifications WHERE project == thisProject 
            // for user in usersToNotify
            // INSERT INTO notiftype VALUES toNotify, type, relatedId, bug, timestamp, read
            // user.idnotification, newPost, update's.id, bug, timestamp
            // if it's a new post then user will want to see the bug's updated status - can deref relatedid for status

            DataTable table = Connection.GetDbConn().GetDataTable($"SELECT * FROM tonotify INNER JOIN notification as n " +
                $"on n.idnotification = tonotify.notifid WHERE tonotify.userid = {UserObject.loggedUser.iduser}");
            //foreach { DataRow row in table}
            //{
            //    // display the notification differently depending on type, add on click to show related info
            //}

        }
    }
}
