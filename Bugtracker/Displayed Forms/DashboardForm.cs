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
/// https://stackoverflow.com/questions/4452590/c-sharp-get-the-item-type-for-a-generic-list
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
        DrawBugPanels dbp = new DrawBugPanels();
        List<List<BugObject>> bugLists = new List<List<BugObject>>();
        public DashboardForm(Window window, string userId)
        {
            InitializeComponent();
            bugLists.Clear();
            display = window;
            Size = new Size(window.Width, window.Height);
            LoadProfileInfo(userId); // loads lists with user's information
            //DrawListsIntoPanels(List<>)
            Resize();
            
        }

        private void LoadProfileInfo(string userId)
        { //going to load user's projects, projects they're following and bugs they are following
            //bugs the user has posted on that aren't yet solved
            //bugs the user posted that have new posts


            //statistics: users posted, fixed, in progress
            //in progress, get all bugs with in progress status that user either made or posted on
            DataTable bugsPosted = Connection.GetDbConn().GetDataTable(SqlUser.GetNumberBugs(userId));
            foreach (DataRow result in bugsPosted.Rows)
            {
                postedBugNo = result["total"].ToString();
                solvedBugNo = result["solved"].ToString();
                inProgressBugNo = result["progress"].ToString();
            }
            Label_ProgressBugs.Text = inProgressBugNo;
            Label_SolvedBugs.Text = solvedBugNo;
            Label_TotalBugs.Text = postedBugNo;
               

            //to do list is 5 bugs user posted of high imprtance and oldest at the top
            DataTable toDoList = Connection.GetDbConn().GetDataTable(SqlBug.ToDoList(userId));
            foreach (DataRow toDo in toDoList.Rows)
            {
                BugObject up = new BugObject(toDo["idbug"].ToString(),
                     toDo["title"].ToString(), toDo["description"].ToString(), toDo["location"].ToString(),
                     toDo["status"].ToString(), toDo["poster"].ToString(),
                     toDo["project"].ToString(), toDo["priority"].ToString(), toDo["referencedBug"].ToString(),
                     Convert.ToDateTime(toDo["timePosted"]));
                BugObject.toDoBugs.Add(up);
            }

            // the most recent bugs this user has posted, not ones they have updates on as notification bar does this
            DataTable recentList = Connection.GetDbConn().GetDataTable(SqlBug.RecentList(userId));
            foreach (DataRow recent in recentList.Rows)
            {
                BugObject up = new BugObject(recent["idbug"].ToString(),
                     recent["title"].ToString(), recent["description"].ToString(), recent["location"].ToString(),
                     recent["status"].ToString(), recent["poster"].ToString(),
                     recent["project"].ToString(), recent["priority"].ToString(), recent["referencedBug"].ToString(),
                     Convert.ToDateTime(recent["timePosted"]));
                BugObject.recentBugs.Add(up);
            }
            //adds these 2 lists into a list 
            bugLists.Add(BugObject.toDoBugs);
            bugLists.Add(BugObject.recentBugs);

        }

        public void Resize()
        {
            Size = new Size(display.Width, display.Height);
            Panel_MasterPanel.Width = display.Width - (Window.widthOffset + 40); //as per the comment in window class,
                                                                                 //i dont really know why it needs this 10 added
            Panel_MasterPanel.Height = display.Height - (Window.heightOffset + 80);
            dbp.BasePanels(Panel_MasterPanel, bugLists, display, display.Width);
        }
    }
}
