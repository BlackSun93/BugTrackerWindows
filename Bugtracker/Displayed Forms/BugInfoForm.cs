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
    public partial class BugInfoForm : Form
    {
        Window display;

        BugObject currentBug;
        //how to go back to the correct project after a bug has been selected?
        //bug info loaded so we can use the project section of it
        public BugInfoForm(Window window, BugObject selectedBug)
        {
            //this form should show info on the bug such as title, description AND updates
            //this form should show the user a button to add an update on the bug

            InitializeComponent();
            display = window;
            Label_RefBug.Text = "";
            LoadUpdatesToList(selectedBug.idbug);
            Size = new Size(display.Width, display.Height);
            currentBug = selectedBug;
            //label1.Text = this.Size.ToString();
            LoadInfo();
            DoResize();
            FollowButton();
           
        }

        /// <summary>
        /// on page load, get info about the selected bug from the DB, changes labels to display info
        /// </summary>
        /// <param name="bugId"></param>
        private void LoadInfo()
        {
            //needs to populate labels and rich text box
            /*DataTable bugInfo = Connection.GetDbConn().GetDataTable(SqlBug.GetOneBug(bugId));
            DataRow row = bugInfo.Rows[0];

            Label_Title.Text = row["title"].ToString();
            RichText_Description.Text = row["description"].ToString();
            Label_Poster.Text = row["poster"].ToString(); //this will show id, either use FK to get name or translate */

            Label_Title.Text = currentBug.title;
            RichText_Description.Text = currentBug.description;
            Label_Poster.Text = currentBug.poster;
            Label_Priority.Text = currentBug.priority;
            Label_Status.Text = currentBug.status;
            // as bug list is no longer cleared when going into the bug info form, we can use the referenced
            // bug's id to find the ref'd bug in the list so we have a bug to pass into the bugclicked 
            // method. we can also get its title to display as label text.
            if (currentBug.referencedBug == "0" || currentBug.referencedBug == "")
            {
                Label_RefBug.Text = "";
            }
            else
            {
                BugObject refBug = BugObject.Bugs.Find(i => i.idbug == currentBug.referencedBug);
                Label_RefBug.Text = refBug.title;

                Label_RefBug.Click += new System.EventHandler((sender, e) => BugClicked(sender, e, refBug));
            }
             
                
            
        }

        /// <summary>
        /// Go to DB with bug's ID, return all updates on this bug. make update objects with these updates
        /// and add them to a list of updates
        /// this code will be reused whenever we query the db (projects, bugs etc)
        /// </summary>
        /// <param name="bugId"></param>
        private void LoadUpdatesToList(string bugId)
        {
            //needs to go to db with bug id, return a table of updates and store these in a list
            //
            DataTable updates = Connection.GetDbConn().GetDataTable(SqlUpdate.GetUpdates(bugId));
            foreach (DataRow update in updates.Rows)
            {
                UpdateObject up = new UpdateObject( update["idupdate"].ToString(), 
                    update["postedBy"].ToString(),  update["comment"].ToString(), update["bug"].ToString(), update["newStatus"].ToString());
                UpdateObject.Updates.Add(up);
            }
        }
        /// <summary>
        /// maybe can do without this as it just calls another function
        /// for each update in the updates list, make a panel for it
        /// </summary>
        private void ShowUpdates()
        {
            int panelYpos = 0;
            foreach (UpdateObject update in UpdateObject.Updates)
            {
                CreateDisplayElements(update, panelYpos);
                //add height of panel plus 10 pixel gap
                panelYpos += 160;
                //PlaceDisplayElements(whateverCreateMakes);
            }
        }

        /// <summary>
        /// code lifted from creating the project panels - needs work to get updates displaying nicely
        /// panels should get drawn under each other now
        /// needs consideration for making a drawPanels class to make these
        /// </summary>
        /// <param name="update"></param>
        private void CreateDisplayElements(UpdateObject update, int panelYpos)
        {
            
            Panel Panel_UpdatePanel = new Panel
            {
                Name = "UpdatePanel_" + update.id,
                BackColor = Color.White,
                Width = 430,
                Height = 150,
                Location = new Point(0, panelYpos)
            };

            Label Label_PostedBy = new Label
            {
                Name = "UpdatePoster_" + update.posterId, //this is now the poster's username
                Location = new Point(8, 8),
                Font = new Font("Arial", 14f, FontStyle.Bold),
                ForeColor = Color.FromArgb(82, 82, 82),
                MaximumSize = new Size(Panel_UpdatePanel.Width - 32, Panel_UpdatePanel.Height / 4), //50
                AutoSize = true,
                Text = "Posted By: " + update.posterId,
                
                Cursor = Cursors.Hand
        };

            Label Label_UpdateStatus = new Label
            {
                Name = "UpdateStatus_" + update.newStatus, 
                Location = new Point(430 - 180, 8), //Panel_UpdatePanel.Width - this.Width - 8, wanted to do the width of the panel - the length of the label - a margin
                Font = new Font("Arial", 10f, FontStyle.Bold),
                ForeColor = Color.FromArgb(82, 82, 82),
                MaximumSize = new Size(Panel_UpdatePanel.Width - 32, Panel_UpdatePanel.Height / 4), //50
                AutoSize = true,
                Text = "Status: " + update.newStatus
            };

            RichTextBox RichText_UpdateComment = new RichTextBox
            {
                // this works but can't scroll through updates if mouse cursor is inside richtextbox
                Name = "UpdateComment_" + update.comment,
                Location = new Point(16, (Panel_UpdatePanel.Height / 4) + 16), //62
                Font = new Font("Arial", 8f, FontStyle.Bold),
                ForeColor = Color.FromArgb(82, 82, 82),
                Size = new Size(Panel_UpdatePanel.Width - 32, Panel_UpdatePanel.Height / 2), 
                MaximumSize = new Size(Panel_UpdatePanel.Width - 16 , Panel_UpdatePanel.Height / 2),
                AutoSize = true,
                Text = update.comment,
                ReadOnly = true
                
            };
            // i want the username to be clickable to take the user to the update poster's page
            // however update's posterId is now username and not their iduser
            // so conversion will be needed
            Label_PostedBy.Click += new EventHandler((sender, e) => UserClicked(sender, e, update.posterId.ToString()));

            Controls.Add(Panel_Updates);
            Panel_Updates.Controls.Add(Panel_UpdatePanel);
            Panel_UpdatePanel.Controls.Add(Label_PostedBy);
            Panel_UpdatePanel.Controls.Add(RichText_UpdateComment);
            Panel_UpdatePanel.Controls.Add(Label_UpdateStatus);
        }

        private void Button_Back_Click(object sender, EventArgs e)
        {
            //THIS NEEDS TO BE CHANGED, IDEALLY WHEN PAGE LOADED, CREATE BUG INSTANCE INSTEAD OF ANOTHER QUERY
            /* DataTable bugInfo = Connection.GetDbConn().GetDataTable(SqlBug.GetOneBug(currentBug.idbug));
             DataRow row = bugInfo.Rows[0]; */
            BugObject.Bugs.Clear();
            UpdateObject.Updates.Clear();
            display.DisplayBugsForm(currentBug.project);
        }

        private void Button_AddUpdate_Click(object sender, EventArgs e)
        {
            UpdateObject.Updates.Clear();
            display.DisplayPostUpdateForm(currentBug);
        }

        private void UserClicked(object sender, EventArgs e, string id)
        {
            BugObject.Bugs.Clear();
            display.DisplayDashboardForm(id);
        }
        private void DoResize()
        {
            Size = new Size(display.Width, display.Height);
            Panel_Updates.Width = display.Width - (Window.widthOffset + 10); //as per the comment in window class,
                                                                             //i dont really know why it needs this 10 added
            Panel_Updates.Height = display.Height - Window.heightOffset;

            ShowUpdates();
        }
        private void BugClicked(object sender, EventArgs e, BugObject selectedBug)
        {
            //BugObject.Bugs.Clear();
            // if a bug is referenced, should be able to find that bug object in this list so
            // that the label showing that bug's id is clickable in the info form
            display.DisplayBugInfoForm(selectedBug);

        }
        private void FollowButton()
        {
            DataSet followCheck = Connection.GetDbConn().GetDataSet($"SELECT * FROM followbug " +
                $" WHERE user = {UserObject.loggedUser.iduser} AND bug = {currentBug.idbug}");
            if (followCheck.Tables[0].Rows.Count != 0) // if user is following this project
            {
                //Button Button_Unfollow = new Button()
                //{
                //    Location = new Point(250, 9),
                //    Text = "UnFollow project",
                //    Font = new Font("Arial", 8f, FontStyle.Bold),
                //    AutoSize = true,


                //};
                Button_Follow.Text = "Unfollow Bug";
                Button_Follow.Click += new EventHandler((sender, e) => Unfollow(sender, e));
                Button_Follow.Visible = true;
            }
            else
            {
                //Button Button_Follow = new Button()
                //{
                //    Location = new Point(250, 9),
                //    Text = "Follow This Project",
                //    Font = new Font("Arial", 8f, FontStyle.Bold),
                //    AutoSize = true,

                //};
                Button_Follow.Text = "Follow Bug";
                Button_Follow.Click += new EventHandler((sender, e) => Follow(sender, e));
                Button_Follow.Visible = true;
            }


            //Button_RequestAccess.Click += new EventHandler((sender, e) => RequestAccess(sender, e, project));
            //Panel_ProjectPanel.Controls.Add(Button_RequestAccess);
            //containerPanel.Controls.Add(Panel_ProjectPanel);
        }

        private void Follow(object sender, EventArgs e)
        {
            // add a folow object to link the logged in user and this bug
            // need a timestamp for the notification, also needs some leeway as sending to the server may take a second
            // or more depending on connection.
            DateTime timestamp = DateTime.Now;
            string stringTime = timestamp.ToString("yyyy-MM-dd HH:mm:ss"); ;
            string toStringTime = timestamp.AddSeconds(5).ToString("yyyy-MM-dd HH:mm:ss");
            // create a follow project object which will notify the project poster that a user wants access
            SqlFollow sq = new SqlFollow();
            Connection.GetDbConn().CreateCommand(SqlFollow.FollowBug(UserObject.loggedUser.iduser, currentBug.idbug));

            // has to create a notification with relevant deatils
            SqlNotifications notif = new SqlNotifications();
            notif.InsertNotification(UserObject.loggedUser.iduser, currentBug.project, currentBug.idbug, "", "bugfollow", "", timestamp);
            // have to get the new notif's id to make a toNotif object, have to use time here as its possible
            // that a user might make multiple requests or might follow, unfollow, then want back in
            // copied logic from following a project here as unlikely user will have multiple notifications on the same project
            // with the same timestamp
            DataSet getNotifId = Connection.GetDbConn().GetDataSet($"SELECT idnotification FROM notification" +
                $" WHERE usernotif = {UserObject.loggedUser.iduser} AND project = {currentBug.project}  AND timestamp BETWEEN '{stringTime}' AND '{toStringTime}' ");
            string newNotifId = getNotifId.Tables[0].Rows[0].ItemArray.GetValue(0).ToString();
            // need to notify the bug's poster
            DataSet bugPoster = Connection.GetDbConn().GetDataSet($"SELECT poster FROM bug WHERE idbug = {currentBug.idbug}");
            string posterId = bugPoster.Tables[0].Rows[0].ItemArray.GetValue(0).ToString();
            notif.InsertToNotify(newNotifId, posterId, "0");


            MessageBox.Show("Followed");
        }
        private void Unfollow(object sender, EventArgs e)
        {
            // create a follow project object which will notify the project poster that a user wants access

            SqlFollow sq = new SqlFollow();
            Connection.GetDbConn().CreateCommand(SqlFollow.UnFollowBug(UserObject.loggedUser.iduser, currentBug.idbug));

            MessageBox.Show("Unfollowed");

            //catch (Exception)
            //{
            //    MessageBox.Show("Request already sent");
            //}

        }
    }
}
