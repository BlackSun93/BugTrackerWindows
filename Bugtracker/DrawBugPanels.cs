using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Drawing;

namespace Bugtracker
{
    class DrawBugPanels
    {
        Window display;
        public static List<Panel> masterPanelList = new List<Panel>();
        public static List<Panel> bugPanelList = new List<Panel>();
        string updateCount;
        public void BasePanels(Panel masterPanel, List<List<BugObject>> sections, Window window, int masterPanelSize)
        {// list of lists is used to allow us to easily make container panels by telling it how many lists
            //we need a panel for
            masterPanelList.Clear();
            int howManyPanels = sections.Count();
            display = window;
            masterPanel.Controls.Clear();
            // for each  project list, make a conatiner panel, draw that panel to the master panel on the form, 
            // then add the contents of that list to this panel. 
            // 
            foreach (List<BugObject> list in sections)
            {
                Panel Panel_Container = new Panel
                {
                    //Location = new Point(16, 16), // this is updated in GridDraw, so redunadant here
                    BackColor = Color.DarkOliveGreen, //i apologise for the colour
                    //MaximumSize = new Size(((display.Width / 2) - 200), toDrawTo.Height),
                    //Width = 530, // i want this size to fill the master panel on projectsForm when window at min size
                    // 2 project panels take up 536 px with their separators (3 * 32px) + (2*220px))
                    Width = (masterPanel.Width / howManyPanels),
                    Height = masterPanel.Height - 20, //max height of panel to draw to
                    //MaximumSize = new Size(masterPanelSize/howManyPanels, masterPanel.Height),
                    //MinimumSize = new Size(masterPanelSize, masterPanel.Height),
                    AutoScroll = true
                };

                masterPanel.Controls.Add(Panel_Container);
                //to use drawGrid, have to add container panel to the list then clear it after
                //panelList.Add(Panel_Container);
                // draw container panel to master
                //GridDraw(masterPanel, panelList); // to draw to is the master panel
                //panelList.Clear();
                // create a panel for each project in the list and add them to the panel list. GridDraw is called 
                // at the end of this function too, to draw those panels into Panel_Container
                BugPanels(Panel_Container, list, window);
                masterPanelList.Add(Panel_Container);
                //needs to add to panel list after creation but panelList needs to be used by the project panels
                //could make another panel list
                /*foreach (List<ProjectObject> dataset in sections )
                {
                    ProjectPanels(Panel_Container, dataset, window);
                    
                } */
            }
            DrawPanels.GridDraw(masterPanel, masterPanelList); // to draw to is the master panel
            masterPanelList.Clear();
        }

        /// <summary>
        /// this logic generates the clickable panels that display projects
        /// </summary>
        /// <param name="toDrawTo"></param>
        /// <param name="dataset"></param>
        /// <param name="window"></param>
        public void BugPanels(Panel containerPanel, List<BugObject> dataset, Window window)
        {
            bugPanelList.Clear(); // clear panel list 
            display = window;
            containerPanel.Controls.Clear();
            foreach (BugObject bug in dataset)
            {
                //For each project object in the database, make a panel, display elements, give it an on click method
                // maybe have a count of how many updates there are on a bug
                
                DataTable updates = Connection.GetDbConn().GetDataTable(SqlBug.UpdateCount(bug.idbug));
                foreach (DataRow result in updates.Rows)
                {
                    updateCount = result["count"].ToString();
                }
                Panel Panel_BugPanel = new Panel
                {
                    //Name = "ProjectPanel_" + bug.idproject,
                    BackColor = Color.White,
                    Width = containerPanel.Width,
                    Height = 104,
                };

                Label Label_BugTitle = new Label
                {
                    //Name = "ProjectName_" + bug.idproject,
                    Location = new Point(16 ,Panel_BugPanel.Height/2 - 4 ),
                    Font = new Font("Arial", 14f, FontStyle.Bold),
                    ForeColor = Color.FromArgb(82, 82, 82),
                    //MaximumSize = new Size(Panel_BugPanel.Width - 32, Panel_BugPanel.Height / 4),
                    //AutoSize = true,
                    Text = bug.title
                };

                Label Label_BugUpdates = new Label
                {
                    //Name = "ProjectDescription_" + bug.idproject,
                    Location = new Point(Panel_BugPanel.Width/3, Panel_BugPanel.Height / 2 - 4),
                    Font = new Font("Arial", 14f, FontStyle.Bold),
                    ForeColor = Color.FromArgb(82, 82, 82),
                    //MaximumSize = new Size(Panel_BugPanel.Width - 32, Panel_BugPanel.Height / 2),
                    //AutoSize = true,
                    Text = updateCount
                };

                //on click method is applied on each panel generated as dataset list is iterated over
                //we can move logic into drawpanels class

                Panel_BugPanel.Click += new EventHandler((sender, e) => BugClicked(sender, e, bug));
                Label_BugTitle.Click += new EventHandler((sender, e) => BugClicked(sender, e, bug));
                Label_BugUpdates.Click += new EventHandler((sender, e) => BugClicked(sender, e, bug));

                //Controls.Add(Panel_DisplayProjects); isn't the base panel added as a control from the design form?
                containerPanel.Controls.Add(Panel_BugPanel);
                Panel_BugPanel.Controls.Add(Label_BugTitle);
                Panel_BugPanel.Controls.Add(Label_BugUpdates);

                //problem is here, how would you take this outside of the loop?

                //GridDraw(toDrawTo, Panel_ProjectPanel, i);

                //could use .Count of the dataset (to get how many projects need to be made)
                //list of panels?
                bugPanelList.Add(Panel_BugPanel);
            }
            DrawPanels.GridDraw(containerPanel, bugPanelList);
            bugPanelList.Clear(); //needs to clear the panel list once projects are drawn to their panels so master panels can be 
            //located afterwards
        }
        private void BugClicked(object sender, EventArgs e, BugObject id)
        {
            BugObject.followedBugs.Clear(); //clear the list, we will need to clear all lists when more are added
            // i dont want to have to pass the display instance all the way to here
            BugObject.recentBugs.Clear();
            BugObject.toDoBugs.Clear();
            display.DisplayBugInfoForm(id);
        }
    }
}
