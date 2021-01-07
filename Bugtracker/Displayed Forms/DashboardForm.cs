using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// this form will be the user's dashboard. it should display some stats about the user, info on their bugs/ projects, 
/// bugs/projects they are following and bugs which have unread notifications. (bugs they posted that now has an answer)
/// bugs/ projects dont need to display like on projectform and bugform, can use text as per wirerame (or how
/// bugs displayed on browser bugtracker)
/// 
/// to do list: when looking at bug info page , user would get an option to 'add to to do list' which would be a application 
/// side list containing bugs. user might get the option to go to 'next' in to do list or even a panel that shows
/// bugs in the list on the side of the screen. 
/// </summary>

namespace Bugtracker
{
    public partial class DashboardForm : Form
    {
        Window display;
        string postedBugNo; //variable to store how many bugs the logged in user has posted
        string solvedBugNo;
        string inProgressBugNo;
        // List<ProjectObject> user's projects
        // List<BugObject> user's bugs
        // List<ProjectObject> user's followed projects
        // List<BugObject> user's followed bugs
        // List<ProjectObject> projects with unread notifications
        // List<BugObject> bugs with notifications
        public DashboardForm(Window window)
        {
            InitializeComponent();
            window = display;
            LoadProfileInfo(UserObject.loggedUser.iduser); // loads lists with user's information
            //DrawListsIntoPanels(List<>)
            //resize();
            
        }

        private void LoadProfileInfo(string user)
        { //going to load user's projects, projects they're following and bugs they are following
            //bugs the user has posted on that aren't yet solved
            //bugs the user posted that have new posts


            //statistics: users posted, fixed, in progress
            //in progress, get all bugs with in progress status that user either made or posted on
            DataTable bugsPosted = Connection.GetDbConn().GetDataTable(SqlUser.GetNumberBugs(UserObject.loggedUser.iduser));
            foreach (DataRow result in bugsPosted.Rows)
            {
                postedBugNo = result["total"].ToString();
                solvedBugNo = result["solved"].ToString();
                inProgressBugNo = result["progress"].ToString();
            }
            /*DataTable bugUserPosted = Connection.GetDbConn().GetDataTable(SqlBug.GetUserPosted(UserObject.loggedUser.iduser));
            foreach (DataRow bugUserPosted in bugUserPosted.Rows)
            {
                BugObject up = new BugObject(bugUserPosted["idbug"].ToString(),
                     bugUserPosted["title"].ToString(), bugUserPosted["description"].ToString(), bugUserPosted["location"].ToString(),
                     bugUserPosted["status"].ToString(), bugUserPosted["poster"].ToString(),
                     bugUserPosted["project"].ToString(), bugUserPosted["priority"].ToString(), 
                     Convert.ToDateTime(bugUserPosted["timePosted"]));
                BugObject.Bugs.Add(up);

            } */

                // get user's projects
                /* DataTable userProjects = Connection.GetDbConn().GetDataTable(SqlProject.GetUserProjects(UserObject.loggedUser.iduser));
                foreach (DataRow userProject in userProjects.Rows)
                {
                    ProjectObject up = new ProjectObject(userProject["idproject"].ToString(),
                        userProject["projName"].ToString(), userProject["user"].ToString(), userProject["description"].ToString());
                    ProjectObject.UserProjects.Add(up);

                }
                // get followed projects
                DataTable followedProjects = Connection.GetDbConn().GetDataTable(SqlProject.GetUserProjects(UserObject.loggedUser.iduser));
                foreach (DataRow userProject in userProjects.Rows)
                {
                    ProjectObject up = new ProjectObject(userProject["idproject"].ToString(),
                        userProject["projName"].ToString(), userProject["user"].ToString(), userProject["description"].ToString());
                    ProjectObject.UserProjects.Add(up);

                }
                // get followed bugs
                DataTable followedBugs = Connection.GetDbConn().GetDataTable(SqlProject.GetUserProjects(UserObject.loggedUser.iduser));
                foreach (DataRow userProject in userProjects.Rows)
                {
                    ProjectObject up = new ProjectObject(userProject["idproject"].ToString(),
                        userProject["projName"].ToString(), userProject["user"].ToString(), userProject["description"].ToString());
                    ProjectObject.UserProjects.Add(up); */

        }

        }
    }
}
