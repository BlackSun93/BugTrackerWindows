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
/// </summary>

namespace Bugtracker
{
    public partial class DashboardForm : Form
    {
        Window display;
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
            //LoadProfileInfo(UserObject.loggedUser.iduser) // loads lists with user's information
            //DrawListsIntoPanels(List<>)
            //resize();
            
        }

        private void LoadProfileInfo(string user)
        { //going to load user's projects, projects they're following and bugs they are following


            DataTable userProjects = Connection.GetDbConn().GetDataTable(SqlProject.GetUserProjects(UserObject.loggedUser.iduser));
            foreach (DataRow userProject in userProjects.Rows)
            {
                ProjectObject up = new ProjectObject(userProject["idproject"].ToString(),
                    userProject["projName"].ToString(), userProject["user"].ToString(), userProject["description"].ToString());
                ProjectObject.UserProjects.Add(up);

            }

            DataTable followedProjects = Connection.GetDbConn().GetDataTable(SqlProject.GetUserProjects(UserObject.loggedUser.iduser));
            foreach (DataRow userProject in userProjects.Rows)
            {
                ProjectObject up = new ProjectObject(userProject["idproject"].ToString(),
                    userProject["projName"].ToString(), userProject["user"].ToString(), userProject["description"].ToString());
                ProjectObject.UserProjects.Add(up);

            }

            DataTable followedBugs = Connection.GetDbConn().GetDataTable(SqlProject.GetUserProjects(UserObject.loggedUser.iduser));
            foreach (DataRow userProject in userProjects.Rows)
            {
                ProjectObject up = new ProjectObject(userProject["idproject"].ToString(),
                    userProject["projName"].ToString(), userProject["user"].ToString(), userProject["description"].ToString());
                ProjectObject.UserProjects.Add(up);

            }
        }
    }
}
