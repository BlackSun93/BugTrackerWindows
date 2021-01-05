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
            string comment, status, postedBy, bug;
            comment = RichText_Update.Text;
            status = ComboBox_Status.Text;
            postedBy = UserObject.loggedUser.username; //comment
            bug = currentBug.idbug;
            SqlBug updateStatus = new SqlBug();
            updateStatus.UpdateStatus(bug, status);
            SqlUpdate newUpdate = new SqlUpdate();
            newUpdate.InsertUpdate(postedBy, comment, bug, status);
            
            //i dont there's there's enough time inbetween this update and the form displaying for the 
            // status change to register on the db, changed so that bug's status is changed first to see if this helps.

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
