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
    public partial class BugInfoForm : Form
    {
        Window display;
        string currentBug;
        //how to go back to the correct project after a bug has been selected?
        //bug info loaded so we can use the project section of it
        public BugInfoForm(Window window, string bugId)
        {
            //this form should show info on the bug such as title, description AND updates
            //this form should show the user a button to add an update on the bug

            InitializeComponent();
            display = window;
            LoadInfo(bugId);
            LoadUpdatesToList(bugId);
            Size = new Size(display.Width, display.Height);
            currentBug = bugId;
            //label1.Text = this.Size.ToString();
            
            DoResize();
        }

        /// <summary>
        /// on page load, get info about the selected bug from the DB, changes labels to display info
        /// </summary>
        /// <param name="bugId"></param>
        private void LoadInfo(string bugId)
        {
            //needs to populate labels and rich text box
            DataTable bugInfo = Connection.GetDbConn().GetDataTable(SqlBug.GetOneBug(bugId));
            DataRow row = bugInfo.Rows[0];

            Label_Title.Text = row["title"].ToString();
            RichText_Description.Text = row["description"].ToString();
            Label_Poster.Text = row["poster"].ToString(); //this will show id, either use FK to get name or translate

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
            DataTable updates = Connection.GetDbConn().GetDataTable(SqlUpdate.GetUpdates(bugId));
            foreach (DataRow update in updates.Rows)
            {
                UpdateObject up = new UpdateObject( update["idupdate"].ToString(), 
                    update["postedBy"].ToString(),  update["comment"].ToString(), update["bug"].ToString());
                UpdateObject.Updates.Add(up);
            }
        }
        /// <summary>
        /// maybe can do without this as it just calls another function
        /// for each update in the updates list, make a panel for it
        /// </summary>
        private void ShowUpdates()
        {
            foreach (UpdateObject update in UpdateObject.Updates)
            {
                CreateDisplayElements(update);
                //PlaceDisplayElements(whateverCreateMakes);
            }
        }

        /// <summary>
        /// code lifted from creating the project panels - needs work to get updates displaying nicely
        /// also needs logic for drawing panels below
        /// </summary>
        /// <param name="update"></param>
        private void CreateDisplayElements(UpdateObject update)
        {
            Panel Panel_UpdatePanel = new Panel
            {
                Name = "UpdatePanel_" + update.id,
                BackColor = Color.White,
                Width = 430,
                Height = 150,
            };

            Label Label_ProjectName = new Label
            {
                Name = "UpdatePoster_" + update.posterId, //this wants to translate to the poster's username
                Location = new Point(8, 8),
                Font = new Font("Arial", 14f, FontStyle.Bold),
                ForeColor = Color.FromArgb(82, 82, 82),
                MaximumSize = new Size(Panel_UpdatePanel.Width - 32, Panel_UpdatePanel.Height / 4), //50
                AutoSize = true,
                Text = "Posted By: " + update.posterId
            };

            RichTextBox RichText_UpdateComment = new RichTextBox
            {
                Name = "UpdateComment_" + update.comment,
                Location = new Point(16, (Panel_UpdatePanel.Height / 4) + 16), //62
                Font = new Font("Arial", 8f, FontStyle.Bold),
                ForeColor = Color.FromArgb(82, 82, 82),
                MaximumSize = new Size(Panel_UpdatePanel.Width - 32, Panel_UpdatePanel.Height / 2),
                AutoSize = true,
                Text = update.comment,
                ReadOnly = true
                
            };

            Controls.Add(Panel_Updates);
            Panel_Updates.Controls.Add(Panel_UpdatePanel);
            Panel_UpdatePanel.Controls.Add(Label_ProjectName);
            Panel_UpdatePanel.Controls.Add(RichText_UpdateComment);
        }

        private void Button_Back_Click(object sender, EventArgs e)
        {
            //THIS NEEDS TO BE CHANGED, IDEALLY WHEN PAGE LOADED, CREATE BUG INSTANCE INSTEAD OF ANOTHER QUERY
            DataTable bugInfo = Connection.GetDbConn().GetDataTable(SqlBug.GetOneBug(currentBug));
            DataRow row = bugInfo.Rows[0];

            display.DisplayBugsForm(row["project"].ToString());
        }

        private void Button_AddUpdate_Click(object sender, EventArgs e)
        {
            display.DisplayPostUpdateForm(currentBug);
        }


        private void DoResize()
        {
            Size = new Size(display.Width, display.Height);
            Panel_Updates.Width = display.Width - (Window.widthOffset + 10); //as per the comment in window class,
                                                                             //i dont really know why it needs this 10 added
            Panel_Updates.Height = display.Height - Window.heightOffset;

            ShowUpdates();
        }
    }
}
