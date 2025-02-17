﻿using System;
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
    
    public partial class BugsForm : Form
    {
        Window display;
        string currentProject;
        public BugsForm(Window window, string id)
        {
            {
                InitializeComponent();
                display = window;
                LoadBugsToList(id);
                Size = new Size(display.Width, display.Height);
                //label1.Text = this.Size.ToString();
                currentProject = id; //need to track which project is being viewed so that newly reported bugs are
                //connected to the correct project and so on returning from the new bug screen, the correct project
                //is loaded. id is passed from a function applied to the panels in ProjectsForm
                // a check to see if user is following this project, make a follow/ unfollow button depending
                FollowButton();
                DoResize();
            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            //display.DisplayProjectsForm();
        }

        private void LoadBugsToList(string projectId)
        {
            //gets all the projects stored in the DB and puts them in a list
            DataTable bugs = Connection.GetDbConn().GetDataTable(SqlBug.GetBugs(projectId));
            foreach (DataRow bug in bugs.Rows)
            {
                BugObject up = new BugObject(bug["idbug"].ToString(),
                    bug["title"].ToString(), bug["description"].ToString(), bug["location"].ToString(), bug["status"].ToString(),
                     bug["poster"].ToString(), bug["project"].ToString(), bug["priority"].ToString(),
                      bug["referencedBug"].ToString(), Convert.ToDateTime(bug["timePosted"]));
                BugObject.Bugs.Add(up);
            }
        }
        private void LoadBugs()
        {   //please read comment below regarding logic used and variable names (taken from ProjectsForm code)
            //go to the database with the project id, get a table containing all the bugs attached to this project
            //display these bugs to the screen

            //DataTable bugs = Connection.GetDbConn().GetDataTable(SqlBug.GetBugs(currentProject));
            
            //gets all bugs in the selected project
  
            Panel_DisplayBugs.Controls.Clear();

            int separatorDistance = 32,
                rowWidth = separatorDistance,
                totalRows = 0,
                rowNumber = totalRows,
                projectPosition = 0,
                firstColumnX = separatorDistance,
                firstColumnY = separatorDistance,
                lastColumnY,
                lastX = firstColumnX,
                lastY = firstColumnY,
                newX,
                newY;

            foreach (BugObject bug in BugObject.Bugs)
            {
                //PLEASE NOTE this is copied from the logic used in displaying projects SO VARIABLE NAMES ARE COPIED
                //IT WORKS BUT THESE NEED RENAMING AND PANEL CONTENTS NEED CHANGING (i.e poster, date, priority etc)
                //For each project in the project table, make a panel that contains that project's title and description
                Panel Panel_BugPanel = new Panel
                {
                    Name = "BugPanel_" + bug.idbug,
                    BackColor = Color.White,
                    Width = 220,
                    Height = 220,
                };

                Label Label_BugName = new Label
                {
                    Name = "BugName_" + bug.idbug,
                    Location = new Point(16, 16),
                    Font = new Font("Arial", 14f, FontStyle.Bold),
                    ForeColor = Color.FromArgb(82, 82, 82),
                    MaximumSize = new Size(Panel_BugPanel.Width - 32, Panel_BugPanel.Height / 4), //50
                    AutoSize = true,
                    Text = bug.title
                };

                Label Label_BugDescription = new Label
                {
                    Name = "BugDescription_" + bug.idbug,
                    Location = new Point(16, (Panel_BugPanel.Height / 4) + 16), //62
                    Font = new Font("Arial", 8f, FontStyle.Bold),
                    ForeColor = Color.FromArgb(82, 82, 82),
                    MaximumSize = new Size(Panel_BugPanel.Width - 32, Panel_BugPanel.Height / 2),
                    AutoSize = true,
                    Text = bug.description
                };

                Label label_BugStatus = new Label
                {
                    Name = "BugStatus_" + bug.idbug,
                    Location = new Point(16, (Panel_BugPanel.Height - 16)), //62
                    Font = new Font("Arial", 8f, FontStyle.Bold),
                    ForeColor = Color.FromArgb(82, 82, 82),
                    MaximumSize = new Size(Panel_BugPanel.Width - 32, Panel_BugPanel.Height / 2),
                    AutoSize = true,
                    Text = bug.status
                };
                Panel_BugPanel.Click += new System.EventHandler((sender, e) => BugClicked(sender, e, bug));
                Label_BugName.Click += new System.EventHandler((sender, e) => BugClicked(sender, e, bug));
                Label_BugDescription.Click += new System.EventHandler((sender, e) => BugClicked(sender, e, bug));
                // this is adding an on click method to each generated panel, as per code used on projectform
                //click function added to text elements so user can click anywhere on the panel
                Controls.Add(Panel_DisplayBugs);
                Panel_DisplayBugs.Controls.Add(Panel_BugPanel);
                Panel_BugPanel.Controls.Add(Label_BugName);
                Panel_BugPanel.Controls.Add(Label_BugDescription);
                Panel_BugPanel.Controls.Add(label_BugStatus);

                rowWidth += Panel_BugPanel.Width + separatorDistance;

                // First Column on First Row
                if (projectPosition == 0 && totalRows == 0)
                {
                    newX = firstColumnX;
                    newY = firstColumnY;
                    Panel_BugPanel.Location = new Point(newX, newY);
                    lastX = newX;
                    lastY = newY;

                    rowNumber++;
                    totalRows++;
                }
                // First Column on Next Row
                else if (rowWidth > Panel_DisplayBugs.Width)
                {
                    lastColumnY = ((firstColumnY + Panel_BugPanel.Height) * totalRows) + separatorDistance;

                    newX = firstColumnX;
                    newY = lastColumnY;
                    Panel_BugPanel.Location = new Point(newX, newY);
                    lastX = newX;
                    lastY = newY;

                    rowWidth = separatorDistance + Panel_BugPanel.Width + separatorDistance;
                    rowNumber++;
                    totalRows++;

                }
                // Next Column on Current Row
                else if (rowWidth <= Panel_DisplayBugs.Width)
                {
                    newX = lastX + Panel_BugPanel.Width + separatorDistance;
                    newY = lastY;
                    Panel_BugPanel.Location = new Point(newX, newY);
                    lastX = newX;
                    lastY = newY;
                }

                projectPosition++;
            }

        }

      
        private void BugClicked(object sender, EventArgs e, BugObject selectedBug)
        {
            //BugObject.Bugs.Clear();
            // if a bug is referenced, should be able to find that bug object in this list so
            // that the label showing that bug's id is clickable in the info form
            display.DisplayBugInfoForm(selectedBug);

        }
        private void Button_NewBug_Click(object sender, EventArgs e)
        {
            display.DisplayBugReportForm(currentProject);
            BugObject.Bugs.Clear();
        }

        private void Button_Back_Click(object sender, EventArgs e)
        {
            BugObject.Bugs.Clear();
            display.DisplayProjectsForm();
        }
        public void DoResize()
        {
            Size = new Size(display.Width, display.Height);
            Panel_DisplayBugs.Width = display.Width - (Window.widthOffset + 10); //as per the comment in window class,
                                                                                     //i dont really know why it needs this 10 added
            Panel_DisplayBugs.Height = display.Height - Window.heightOffset;

            LoadBugs();
        }
        private void FollowButton()
        {
            DataSet followCheck = Connection.GetDbConn().GetDataSet($"SELECT * FROM followproject " +
                $" WHERE user = {UserObject.loggedUser.iduser} AND project = {currentProject}");
            if (followCheck.Tables[0].Rows.Count != 0) // if user is following this project
            {
                //Button Button_Unfollow = new Button()
                //{
                //    Location = new Point(250, 9),
                //    Text = "UnFollow project",
                //    Font = new Font("Arial", 8f, FontStyle.Bold),
                //    AutoSize = true,


                //};
                Button_Follow.Text = "Unfollow Project";
                Button_Follow.Click += new EventHandler((sender, e) => Unfollow(sender, e, currentProject));
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
                Button_Follow.Text = "Follow Project";
                Button_Follow.Click += new EventHandler((sender, e) => Follow(sender, e, currentProject));
                Button_Follow.Visible = true;
            }
            
         
            //Button_RequestAccess.Click += new EventHandler((sender, e) => RequestAccess(sender, e, project));
            //Panel_ProjectPanel.Controls.Add(Button_RequestAccess);
            //containerPanel.Controls.Add(Panel_ProjectPanel);
        }

        private void Follow(object sender, EventArgs e, string project)
        {
            // need a timestamp for the notification, also needs some leeway as sending to the server may take a second
            // or more depending on connection.
            DateTime timestamp = DateTime.Now;
            string stringTime = timestamp.ToString("yyyy-MM-dd HH:mm:ss"); ;
            string toStringTime = timestamp.AddSeconds(5).ToString("yyyy-MM-dd HH:mm:ss");
            // create a follow project object which will notify the project poster that a user wants access
            SqlFollow sq = new SqlFollow();
            Connection.GetDbConn().CreateCommand(SqlFollow.FollowProject(UserObject.loggedUser.iduser, currentProject));

            // has to create a notification with relevant deatils
            SqlNotifications notif = new SqlNotifications();
            notif.InsertNotification(UserObject.loggedUser.iduser, project, "", "", "follow", "", timestamp);
            // have to get the new notif's id to make a toNotif object, have to use time here as its possible
            // that a user might make multiple requests or might follow, unfollow, then want back in
            DataSet getNotifId = Connection.GetDbConn().GetDataSet($"SELECT idnotification FROM notification" +
                $" WHERE usernotif = {UserObject.loggedUser.iduser} AND project = {project}  AND timestamp BETWEEN '{stringTime}' AND '{toStringTime}' ");
            string newNotifId = getNotifId.Tables[0].Rows[0].ItemArray.GetValue(0).ToString();
            // need to get the project owner's id
            DataSet projectOwner = Connection.GetDbConn().GetDataSet($"SELECT user FROM project WHERE idproject = {project}");
            string ownerId = projectOwner.Tables[0].Rows[0].ItemArray.GetValue(0).ToString();
            notif.InsertToNotify(newNotifId, ownerId, "0");


            MessageBox.Show("Followed");
            //catch (Exception)
            //{
            //    MessageBox.Show("Request already sent");
            //}

        }
        private void Unfollow(object sender, EventArgs e, string project)
        {
            // create a follow project object which will notify the project poster that a user wants access
            
                SqlFollow sq = new SqlFollow();
                Connection.GetDbConn().CreateCommand(SqlFollow.UnFollowProject(UserObject.loggedUser.iduser, currentProject));

                MessageBox.Show("Unfollowed");
            
            //catch (Exception)
            //{
            //    MessageBox.Show("Request already sent");
            //}

        }
    }
}
