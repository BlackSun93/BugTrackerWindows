using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Bugtracker
{
    public partial class PostUpdateForm : Form
    {
        Window display;
        
        BugObject currentBug;
        public PostUpdateForm(Window window, BugObject selectedBug)
        {
            InitializeComponent();
            display = window;
            Size = new Size(display.Width, display.Height);
            currentBug = selectedBug;
            //if the bug's current status is solved, and the logged in user didnt post the bug, only display solved 
            // this is to only allow the user who reported a bug to re-open a bug (and post an update saying why they did this)
            // stops anyone from being able to change any bug's status from solved to in prog
            ComboBoxOptions(currentBug);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            display.DisplayBugInfoForm(currentBug);
        }

        private void Button_PostUpdate_Click(object sender, EventArgs e)
        {
            string comment, status, postedBy, bug, timeString, timeStringTo;
            DateTime now = DateTime.Now;
            timeString = now.ToString("yyyy-MM-dd HH:mm:ss");
            timeStringTo = now.AddSeconds(5).ToString("yyyy-MM-dd HH:mm:ss");
            comment = RichText_Update.Text;
            status = ComboBox_Status.Text;
            postedBy = UserObject.loggedUser.username; //comment
            bug = currentBug.idbug;
            SqlBug updateStatus = new SqlBug();
            updateStatus.UpdateStatus(bug, status);
            SqlUpdate newUpdate = new SqlUpdate();
            newUpdate.InsertUpdate(postedBy, comment, bug, status);
            Thread.Sleep(1000); // to try and allow status update to reflect when form reloaded

            DataSet toGetUpdateId = Connection.GetDbConn().GetDataSet($"SELECT idupdate FROM `update`" +
                $" WHERE postedBy = {postedBy} AND timestamp BETWEEN '{timeString}' AND '{timeStringTo}'");
            //DataSet ds = Connection.GetDbConn().GetDataSet($"SELECT @@identity");
            string newUpdateId = toGetUpdateId.Tables[0].Rows[0].ItemArray.GetValue(0).ToString();

            //i dont there's there's enough time inbetween this update and the form displaying for the 
            // status change to register on the db, changed so that bug's status is changed first to see if this helps.
            SqlNotifications notif = new SqlNotifications();
            notif.InsertNotification(UserObject.loggedUser.iduser, currentBug.project, currentBug.idbug,
                newUpdateId , "new update", status, now);

            DataSet getNotifId = Connection.GetDbConn().GetDataSet($"SELECT idnotification FROM notification" +
            $" WHERE usernotif = {UserObject.loggedUser.iduser} AND project = {currentBug.project} AND timestamp BETWEEN '{timeString}' AND '{timeStringTo}'");
            string notifId = getNotifId.Tables[0].Rows[0].ItemArray.GetValue(0).ToString();

            DataTable getBugFollowers = Connection.GetDbConn().GetDataTable($"SELECT user FROM followbug WHERE bug = { currentBug.idbug}");
            foreach (DataRow follower in getBugFollowers.Rows)
            {
                notif.InsertToNotify(notifId, follower["user"].ToString(), "0");
            }
            //string projOwner = getProjectOwner.Tables[0].Rows[0].ItemArray.GetValue(0).ToString();

            

            display.DisplayBugInfoForm(currentBug);
        }

        private void ComboBoxOptions (BugObject selectedBug)
        {
            if (selectedBug.status == "Solved" && selectedBug.poster != UserObject.loggedUser.iduser)
            {
                // if the bug is marked as solved and you didn;t post it,
                ComboBox_Status.Items.Add("Solved");
                // you cant change its status
            }
            else
            {
                ComboBox_Status.Items.Add("in progress");
                ComboBox_Status.Items.Add("Solved");
            }
            
        }
    }
}
