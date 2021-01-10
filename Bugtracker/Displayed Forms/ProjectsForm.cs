using System;
using System.Data;
using System.Drawing;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Bugtracker
{
    public partial class ProjectsForm : Form
    {
        Window display;
        DrawPanels dp = new DrawPanels();
        List<List<ProjectObject>> projectLists = new List<List<ProjectObject>>();
        public ProjectsForm(Window window)
        {
            ProjectObject.UserProjects.Clear();
            InitializeComponent();
            display = window;
            int w = window.Width;
            Label_loggedUser.Text = UserObject.loggedUser.username;
            Size = new Size(window.Width, window.Height);
            LoadProjectsToList();
            doResize();
            //doResize used because this resizes the displayProjects panel then draws the panels to it
            //DrawPanels();
        }
        /// <summary>
        /// function that runs when new project button is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_NewProject_Click(object sender, EventArgs e)
        {
            ProjectObject.Projects.Clear();
            ProjectObject.UserProjects.Clear();
            display.DisplayNewProjectForm();
        }

        private void LoadProjectsToList()
        {
            //gets all the projects stored in the DB and puts them in a list
            //this will now populate multiple lists (for now it will have all projects 
            // named 'userprojects' (projects the logged in user made) and 'projects' (all projects)
            // THESE ARE EXAMPLES, WE SHOULD FIGURE OUT WHAT PROJECTS PEOPLE WILL WANT TO SEE
            // this is also written as dashboard will employ similar methods of panel drawings
            
            
            DataTable userProjects = Connection.GetDbConn().GetDataTable(SqlProject.GetUserProjects(UserObject.loggedUser.iduser));
            foreach (DataRow userProject in userProjects.Rows)
            {
                ProjectObject up = new ProjectObject(userProject["idproject"].ToString(),
                    userProject["projName"].ToString(), userProject["user"].ToString(), userProject["description"].ToString(),
                    Convert.ToInt32(userProject["isPrivate"]));
                ProjectObject.UserProjects.Add(up);
                
            }
            //projectLists.Add(ProjectObject.UserProjects); 

            DataTable projects = Connection.GetDbConn().GetDataTable(SqlProject.GetProjects());
            foreach (DataRow project in projects.Rows)
            {
                ProjectObject up1 = new ProjectObject(project["idproject"].ToString(),
                    project["projName"].ToString(), project["user"].ToString(), project["description"].ToString(),
                    Convert.ToInt32(project["isPrivate"]));
                ProjectObject.Projects.Add(up1);
            }
            projectLists.Add(ProjectObject.Projects);
            projectLists.Add(ProjectObject.UserProjects);
        }

       

        /// <summary>
        /// runs from window class, when window is resized, runs this code
        /// </summary>
        public void doResize()
        {
            //ProjectObject.Projects.Clear();
            Size = new Size(display.Width, display.Height);
            Panel_DisplayProjects.Width = display.Width - (Window.widthOffset + 40); //as per the comment in window class,
                                                                                     //i dont really know why it needs this 10 added
            Panel_DisplayProjects.Height = display.Height - (Window.heightOffset + 80);
            //making an instance of drawpanels means it's not static (so display doesnt have to be passed) however
            //now we have to pass in ProjectPanel arguements (although this would be required anyway with
            // multiple panels), i would rather not make a new instance of the draw class on ever resize
            dp.BasePanels(Panel_DisplayProjects, projectLists, display);
           // dp.ProjectPanels(Panel_DisplayProjects, ProjectObject.Projects, display);
            //dp.ProjectPanels(Panel_UserProjects, ProjectObject.UserProjects, display);
            //dp.projectpanels(panel_yourProjects, userlist)
            //dp.projectpanes(panel_followedprojs, followedlist

            //DrawPanels();
        }

        /// <summary>
        /// Run this when a project's panel is clicked on
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <param name="id"></param>
        private void ProjectClicked(object sender, EventArgs e, string id)
        {
            ProjectObject.Projects.Clear();
            ProjectObject.UserProjects.Clear();
            display.DisplayBugsForm(id);
        }
       

        /// <summary>
        /// im srry this button hasnt been renamed yet
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DebugButton_Login_Click(object sender, EventArgs e)
        {
            ProjectObject.Projects.Clear();
            ProjectObject.UserProjects.Clear();
            UserObject.loggedUser.username = "";
            UserObject.loggedUser.iduser = "";
            this.Hide();
            display.Hide();
            LoginForm lf = new LoginForm();
            lf.Show();
        }
    }
}
