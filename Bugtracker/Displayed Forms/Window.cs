using System;
using System.Drawing;
using System.Windows.Forms;

namespace Bugtracker
{
    public partial class Window : Form
    {
        // Instantiate each form type
        Form1 f1;
        ProjectsForm projForm;
        NewProjectForm newProjForm;
        BugsForm bugsForm;
        BugReportForm bugReportForm;
        BugInfoForm bugInfoForm;
        PostUpdateForm postUpdateForm;
        DashboardForm dashboardForm;
        
        public static int heightOffset;
        public static int widthOffset; // These will be calculated in the resize function, static so that other forms
                                       //can use their value to position forms on the FormContent Panel
        //public static Window display = new Window(); //instead of passing this around everywhere, make it static?

        string currentForm;
        public Window()
        {
            
            InitializeComponent();
            Console.WriteLine(this.Size); // static instance of instance has a size here but not but not in project
            //for constructor
            DisplayProjectsForm();// cant call the object in its constructor
            
        }
      

        /// <summary>
        /// Display functions create a new instance of the form, then adds that form to the Panel_FormContent
        /// Should be the same for all forms
        /// </summary>
        public void DisplayForm1()
        {
            currentForm = "Form1";
            Controls.Clear();
            f1 = new Form1(this)
            {
                TopLevel = false
            };
            Controls.Add(f1);
            ResetButtons();
            f1.Show();
            //Panel_FormContent.Controls.Clear();
            //Panel_FormContent.Controls.Add(f1);
        }

        public  void DisplayProjectsForm()
        {
            
            currentForm = "DisplayProjectsForm";
            string t = Panel_FormContent.Size.ToString();
            Panel_FormContent.Controls.Clear();
            //Controls.Clear();
            projForm = new ProjectsForm(this)
            {
                TopLevel = false
            };
            Panel_FormContent.Controls.Add(projForm);
            //Controls.Add(projForm);
            //Panel_FormContent.Size = Size;
            //projForm.Size = Panel_FormContent.Size;
            ResetButtons();
            Label_Projects.ForeColor = Color.FromArgb(255, 85, 0);
            projForm.Show();
        }
        public void DisplayNewProjectForm()
        {
            
            currentForm = "DisplayNewProjectForm";
            //Controls.Clear();
            Panel_FormContent.Controls.Clear();
            newProjForm = new NewProjectForm(this)
            {
                TopLevel = false
            };
            Panel_FormContent.Controls.Add(newProjForm);
            ResetButtons();
            //Controls.Add(newProjForm);
            newProjForm.Show();
        }
        public void DisplayBugsForm(string id)
        {
            currentForm = "DisplayBugsForm";
            Panel_FormContent.Controls.Clear();
            //i assume making a new window instance with the blank constructor has something to do with 'object
            //reference not set to an object' error
            //Controls.Clear();
            bugsForm = new BugsForm(this, id)
            {
                TopLevel = false
            };
            Panel_FormContent.Controls.Add(bugsForm);
            ResetButtons();
            //Controls.Add(bugsForm);
            bugsForm.Show();
        }
        public void DisplayBugReportForm(string id)
        {
            currentForm = "DisplayBugReportForm";
            Panel_FormContent.Controls.Clear();
            //Controls.Clear();
            bugReportForm = new BugReportForm(this, id)
            {
                TopLevel = false
            };
            Panel_FormContent.Controls.Add(bugReportForm);
            ResetButtons();
            //Controls.Add(bugReportForm);
            bugReportForm.Show();
        }
        public void DisplayBugInfoForm(BugObject selectedBug)
        {
            currentForm = "DisplayBugInfoForm";
            Panel_FormContent.Controls.Clear();
            //Controls.Clear();
            bugInfoForm = new BugInfoForm(this, selectedBug)
            {
                TopLevel = false
            };
            Panel_FormContent.Controls.Add(bugInfoForm);
            ResetButtons();
            //Controls.Add(bugReportForm);
            bugInfoForm.Show();
        }
        public void DisplayPostUpdateForm(BugObject selectedBug)
        {
            currentForm = "DisplayPostUpdateForm";
            Panel_FormContent.Controls.Clear();
            //Controls.Clear();
            postUpdateForm = new PostUpdateForm(this, selectedBug) //,id
            {
                TopLevel = false
            };
            Panel_FormContent.Controls.Add(postUpdateForm);
            ResetButtons();
            //Controls.Add(bugReportForm);
            postUpdateForm.Show();
        }
        public void DisplayDashboardForm(string id)
        {
            currentForm = "DisplayDashboardForm";
            Panel_FormContent.Controls.Clear();
            //Controls.Clear();
            dashboardForm = new DashboardForm(this, id) //,id
            {
                TopLevel = false
            };
            Panel_FormContent.Controls.Add(dashboardForm);
            ResetButtons();
            //Controls.Add(bugReportForm);
            dashboardForm.Show();
        }


        /// <summary>
        /// Some logic to handle window resizing, when window resized, runs the correct function depending on current form
        /// This is useful on pages like ProjectsForm where the amount of projects on the page
        /// changes depending on the size of the window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Window_Resize(object sender, EventArgs e)
        {
            //Panel_FormContent.Size = Size; panel now outsizes window
            heightOffset = Panel_Management.Height + 40; //I guess 40 and 20 is the size of the windows
            widthOffset = Panel_Navigation.Width + 20;   //toolbar and margins
            Panel_FormContent.Height = Height - heightOffset;
            Panel_FormContent.Width = Width - widthOffset ;
            //Here the form content panel needs to be resized if the window ever changes size. However
            //content draws outside of the panel if panel.size = size is used - because the panel
            //gets resized but doesnt start from 0,0 it starts from where the nav bar and toolbar
            //meet. needs to take nav bar (left hand bar's) width for panel.width = width - navbar.width
            // and toolbar (top bar - orange) for panel.height = height = toolbar.height
            
            switch (currentForm)
            {
                case "Form1":
                    
                    DisplayForm1();
                    
                    break;

                case "DisplayProjectsForm":

                    projForm.doResize();

                    break;

                case "DisplayNewProjectForm":
                    //DisplayNewProjectForm();
                    break;

                case "DisplayReportBugForm":

                    break;
                case "DisplayBugsForm":
                    bugsForm.DoResize();
                    //when screen resized, needs to redraw all the panels containing bug info. I dont want it to requery 
                    //the DB as resize should only focus on redrawing  (and it's hard to pass the project id around)
                    //id stored in currentProject variable in bugsForm - no need to pass id
                    break;
                case "DisplayDashboardForm":
                    dashboardForm.Resize();
                    break;
            }

        }

        private void ResetButtons()
        {
            Label_Dashboard.ForeColor = Color.FromArgb(82, 82, 82);
            Label_Projects.ForeColor = Color.FromArgb(82, 82, 82);
            Label_Recent.ForeColor = Color.FromArgb(82, 82, 82);
        }

        private void Label_Dashboard_Click(object sender, EventArgs e)
        {
            // need to add a dashboard form
            DisplayDashboardForm(UserObject.loggedUser.iduser);
        }

        private void Label_Projects_Click(object sender, EventArgs e)
        {
            DisplayProjectsForm();
        }

        private void Label_Recent_Click(object sender, EventArgs e)
        {
            // need to add a recent bugs form
        }
    }
}
