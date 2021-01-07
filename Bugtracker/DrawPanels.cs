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
    class DrawPanels
    { // https://stackoverflow.com/questions/8763716/slowness-in-c-net-windows-form-resize-when-form-has-many-dropdownlist-controls
        Window display;
        public static List<Panel> masterPanelList = new List<Panel>();
        public static List<Panel> projectPanelList = new List<Panel>();
        /// <summary>
        /// this generates the large panels that the projects are attached to
        /// maybe there can be a check to see how many of these panels are getting drawn on a row
        /// if only 1 is being drawn, change location to somewhere more central
        /// in case usr is somewhere between normal size window and fullscreen
        /// </summary>
        /// <param name="toDrawTo"> the panel drawn on the form, master panel </param>
        /// <param name="sections"> a list of ProjectObject lists (see inside projectObject class) </param>
        /// <param name="window"> the display window </param>
        public void BasePanels (Panel masterPanel, List<List<ProjectObject>> sections, Window window)
        {// list of lists is used to allow us to easily make container panels by telling it how many lists
            //we need a panel for
            masterPanelList.Clear();
            int howManyPanels = sections.Count();
            display = window;
            masterPanel.Controls.Clear();
            // for each  project list, make a conatiner panel, draw that panel to the master panel on the form, 
            // then add the contents of that list to this panel. 
            // 
            foreach (List<ProjectObject> list in sections)
            {
                Panel Panel_Container = new Panel
                {
                    Location = new Point(16, 16), // this is updated in GridDraw, so redunadant here
                    BackColor = Color.Yellow, //i apologise for the colour
                    //MaximumSize = new Size(((display.Width / 2) - 200), toDrawTo.Height),
                    //Width = 530, // i want this size to fill the master panel on projectsForm when window at min size
                    // 2 project panels take up 536 px with their separators (3 * 32px) + (2*220px))
                    Width = (masterPanel.Width / howManyPanels),
                    Height = masterPanel.Height - 20, //max height of panel to draw to
                    MaximumSize = new Size (536, masterPanel.Height),
                    MinimumSize = new Size (536, masterPanel.Height),
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
                ProjectPanels(Panel_Container, list, window);
                masterPanelList.Add(Panel_Container);
                //needs to add to panel list after creation but panelList needs to be used by the project panels
                //could make another panel list
                /*foreach (List<ProjectObject> dataset in sections )
                {
                    ProjectPanels(Panel_Container, dataset, window);
                    
                } */
            }
            GridDraw(masterPanel, masterPanelList); // to draw to is the master panel
            masterPanelList.Clear();
        }

        /// <summary>
        /// this logic generates the clickable panels that display projects
        /// </summary>
        /// <param name="toDrawTo"></param>
        /// <param name="dataset"></param>
        /// <param name="window"></param>
        public void ProjectPanels (Panel containerPanel, List<ProjectObject> dataset, Window window)
        {
            projectPanelList.Clear(); // clear panel list 
            display = window;
            containerPanel.Controls.Clear();
            foreach (ProjectObject project in dataset)
            {
                //For each project object in the database, make a panel, display elements, give it an on click method
                Panel Panel_ProjectPanel = new Panel
                {
                    Name = "ProjectPanel_" + project.idproject,
                    BackColor = Color.White,
                    Width = 220,
                    Height = 220,
                };

                Label Label_ProjectName = new Label
                {
                    Name = "ProjectName_" + project.idproject,
                    Location = new Point(16, 16),
                    Font = new Font("Arial", 14f, FontStyle.Bold),
                    ForeColor = Color.FromArgb(82, 82, 82),
                    MaximumSize = new Size(Panel_ProjectPanel.Width - 32, Panel_ProjectPanel.Height / 4),
                    AutoSize = true,
                    Text = project.projName
                };

                Label Label_ProjectDescription = new Label
                {
                    Name = "ProjectDescription_" + project.idproject,
                    Location = new Point(16, (Panel_ProjectPanel.Height / 4) + 16),
                    Font = new Font("Arial", 8f, FontStyle.Bold),
                    ForeColor = Color.FromArgb(82, 82, 82),
                    MaximumSize = new Size(Panel_ProjectPanel.Width - 32, Panel_ProjectPanel.Height / 2),
                    AutoSize = true,
                    Text = project.description
                };
                
                //on click method is applied on each panel generated as dataset list is iterated over
                //we can move logic into drawpanels class
                
                Panel_ProjectPanel.Click += new EventHandler((sender, e) => ProjectClicked(sender, e, project.idproject.ToString()));
                Label_ProjectName.Click += new EventHandler((sender, e) => ProjectClicked(sender, e, project.idproject.ToString()));
                Label_ProjectDescription.Click += new EventHandler((sender, e) => ProjectClicked(sender, e, project.idproject.ToString()));

                //Controls.Add(Panel_DisplayProjects); isn't the base panel added as a control from the design form?
                containerPanel.Controls.Add(Panel_ProjectPanel);
                Panel_ProjectPanel.Controls.Add(Label_ProjectName);
                Panel_ProjectPanel.Controls.Add(Label_ProjectDescription);

                //problem is here, how would you take this outside of the loop?

                //GridDraw(toDrawTo, Panel_ProjectPanel, i);

                //could use .Count of the dataset (to get how many projects need to be made)
                //list of panels?
                projectPanelList.Add(Panel_ProjectPanel);
            }
            GridDraw(containerPanel, projectPanelList);
            projectPanelList.Clear(); //needs to clear the panel list once projects are drawn to their panels so master panels can be 
            //located afterwards
        }
        private void ProjectClicked(object sender, EventArgs e, string id)
        {
            ProjectObject.Projects.Clear(); //clear the list, we will need to clear all lists when more are added
            // i dont want to have to pass the display instance all the way to here
            ProjectObject.UserProjects.Clear();
            display.DisplayBugsForm(id);
        }

        /// <summary>
        /// current logic used to determine location of passed in newPanel is below but this means
        /// resetting required vars such as rowWidth (needed to decide when to draw to a new row)
        /// firstColumnX and Y (needed to determine the location of the first columns and where to draw new panel from it)
        /// unless we make all the panels first THEN pass all of them into here 
        /// </summary>
        /// <param name="toDrawTo"></param>
        /// <param name="newPanel"></param>
        /// <param name="projectPosition"></param>
        public static void GridDraw(Panel toDrawTo, List<Panel> newPanels) //needs to know if its drawing 1st panel or no
        {

            int separatorDistance = 32,
              rowWidth = separatorDistance, //distance between rows
              totalRows = 0, //cant set to 0 here as this happens for each project (may explain why all drawing to 0th line)
              rowNumber = totalRows,
              projectPosition = 0,
              firstColumnX = separatorDistance, 
              firstColumnY = separatorDistance / 2, 
              lastColumnY, 
              lastX = firstColumnX,
              lastY = firstColumnY,
              newX,
              newY;
           
            
            foreach (Panel panel in newPanels)
            { 
                rowWidth += panel.Width + separatorDistance; //incrememnts by 1 panel and separator
                if (projectPosition == 0 && totalRows == 0)//first panel
                {
                    newX = firstColumnX;
                    newY = firstColumnY;
                    panel.Location = new Point(newX, newY);
                    lastX = newX;
                    lastY = newY;

                    rowNumber++;
                    totalRows++;
                }
                // First Column on Next Row
                else if (rowWidth > toDrawTo.Width) //if width would be wider than the panel, make a new row
                {
                    lastColumnY = ((firstColumnY + panel.Height) * totalRows) + separatorDistance;

                    newX = firstColumnX;
                    newY = lastColumnY;
                    panel.Location = new Point(newX, newY);
                    lastX = newX;
                    lastY = newY;

                    rowWidth = separatorDistance + panel.Width + separatorDistance;
                    rowNumber++;
                    totalRows++;

                }
                // Next Column on Current Row
                else if (rowWidth <= toDrawTo.Width) //if space, draw panel on same row 
                {
                    newX = lastX + panel.Width + separatorDistance;
                    newY = lastY;
                    panel.Location = new Point(newX, newY);
                    lastX = newX;
                    lastY = newY;
                }
            }

            
        }
    }
    
}
