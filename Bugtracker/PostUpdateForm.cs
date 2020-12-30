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
        string currentBug;
        public PostUpdateForm(Window window, string bugId)
        {
            InitializeComponent();
            display = window;
            //LoadBugs(id);
            Size = new Size(display.Width, display.Height);
            currentBug = bugId;
            //label1.Text = this.Size.ToString();
            //currentProject = id; //need to track which project is being viewed so that newly reported bugs are
            //connected to the correct project and so on returning from the new bug screen, the correct project
            //is loaded. id is passed from a function applied to the panels in ProjectsForm
            //DoResize();
            //these need enumerating - actual statuses need to be figured out
            ComboBox_Status.Items.Add("in progress");
            ComboBox_Status.Items.Add("Solved");
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
            postedBy = "41"; //stand-in variable, need to make logged in user class and query this for user id;
            bug = currentBug;
            SqlUpdate newUpdate = new SqlUpdate();
            newUpdate.InsertUpdate(postedBy, comment, bug);
            SqlBug updateStatus = new SqlBug();
            updateStatus.UpdateStatus(bug, status);

            display.DisplayBugInfoForm(bug);
        }
    }
}
