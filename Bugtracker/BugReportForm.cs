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
    public partial class BugReportForm : Form
    {
        Window display;
        string currentProject; //needs to keep track of what project the user is currently on
        public BugReportForm(Window window, string id)
        {
            display = window;
            InitializeComponent();
            currentProject = id;
            // we will enumerate these or something
            ComboBox_Priority.Items.Add("low");
            ComboBox_Priority.Items.Add("med");
            ComboBox_Priority.Items.Add("high");

        }

       
        private void Button_Back_Click(object sender, EventArgs e)
        {
            
            display.DisplayBugsForm(currentProject);
        }

        private void Button_Save_Click(object sender, EventArgs e)
        {
            string title,
                description,
                location,
                status,
                poster,
                project,
                priority;
            DateTime timePosted;
            title = TextBox_Title.Text;
            description = RichText_Description.Text;
            location = TextBox_Location.Text;
            timePosted = System.DateTime.Now;
            status = "In Progress";
            //maybe on log in have a class (loggedUser) which stores the logged in user's ID, then go to that class
            //for this info, for now we're using 41 as test user in DB
            poster = "41";
            project = currentProject;
            priority = ComboBox_Priority.Text;
           


            SqlBug newBug = new SqlBug();
            newBug.InsertBug(title,  description,  location,  timePosted,  status,  poster,  project,  priority);


            //InsertBug(string title, int description, string location, DateTime timePosted, string status,
            //string poster, string project, string priority)
            display.DisplayBugsForm(currentProject);
        }

      
    }
}
