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
    {
        Window display;
        public static List<Panel> panelList = new List<Panel>();
        /// <summary>
        /// this generates the large panels that the projects are attached to
        /// maybe there can be a check to see how many of these panels are getting drawn on a row
        /// if only 1 is being drawn, change location to somewhere more central
        /// in case usr is somewhere between normal size window and fullscreen
        /// </summary>
        /// <param name="toDrawTo"></param>
        /// <param name="sections"></param>
        /// <param name="window"></param>
        public void BasePanels (Panel toDrawTo, List<List<ProjectObject>> sections, Window window)
        {
            panelList.Clear();
            int howManyPanels = sections.Count();
            display = window;
            toDrawTo.Controls.Clear();
            for (int i = 0; i < sections.Count; i++)
            {
                Panel Panel_Container = new Panel
                {
                    Name = "Panel_" + i, //just the name for the panel to attach other panels to
                    BackColor = Color.Yellow,
                    MaximumSize = new Size(((display.Width / 2) - 200), toDrawTo.Height),
                    Width = toDrawTo.Width,
                    Height = toDrawTo.Height,
                    AutoScroll = true
                };
                toDrawTo.Controls.Add(Panel_Container);
                //to use drawGrid, have to add container panel to the list then clear it after
                panelList.Add(Panel_Container);
                GridDraw(toDrawTo, panelList);
                panelList.Clear();

                foreach (List<ProjectObject> dataset in sections )
                {
                    ProjectPanels(Panel_Container, dataset, window);
                    
                }
            }
        }

        /// <summary>
        /// this logic generates the clickable panels that display projects
        /// </summary>
        /// <param name="toDrawTo"></param>
        /// <param name="dataset"></param>
        /// <param name="window"></param>
        public void ProjectPanels (Panel toDrawTo, List<ProjectObject> dataset, Window window)
        {
            display = window;
            toDrawTo.Controls.Clear();
            

            
            int totalRows = 0;
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
                toDrawTo.Controls.Add(Panel_ProjectPanel);
                Panel_ProjectPanel.Controls.Add(Label_ProjectName);
                Panel_ProjectPanel.Controls.Add(Label_ProjectDescription);

                //problem is here, how would you take this outside of the loop?

                //GridDraw(toDrawTo, Panel_ProjectPanel, i);
                
                //could use .Count of the dataset (to get how many projects need to be made)
                //list of panels?
                panelList.Add(Panel_ProjectPanel);
            }
            GridDraw(toDrawTo, panelList);

        }
        private void ProjectClicked(object sender, EventArgs e, string id)
        {
            ProjectObject.Projects.Clear(); //clear the list, we will need to clear all lists when more are added
            // i dont want to have to pass the display instance all the way to here
            //Window w = new Window("im so sorry");
            //this creates a new window with nothing on it (i think) and so we cant use DisplayBugsForm
            //on it (as the w instance of Window isn;t even initialised) (and doing so would defeat the purpose of adding as 
            //controls instead of using new forms)
            display.DisplayBugsForm(id);
            //get it so that Window.display.DisplayBugsForm(id) works?
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
        private void GridDraw(Panel toDrawTo, List<Panel> newPanels) //needs to know if its drawing 1st panel or no
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
                //below code handles changing the location of the project panels
                // First Column on First Row
                if (projectPosition == 0 && totalRows == 0)//first panel
                {
                    newX = firstColumnX;
                    newY = firstColumnY;
                    panel.Location = new Point(newX, newY);
                    lastX = newX;
                    lastY = newY;

                    rowNumber++;
                    totalRows++;
                    rowWidth += newPanels[0].Width + separatorDistance; //rowwidth is always reset here // gets the width of a panel
                }
                // First Column on Next Row
                else if (rowWidth > toDrawTo.Width) //if width would be wider than the panel, make a new row
                {
                    lastColumnY = ((firstColumnY + newPanels[0].Height) * totalRows) + separatorDistance;

                    newX = firstColumnX;
                    newY = lastColumnY;
                    panel.Location = new Point(newX, newY);
                    lastX = newX;
                    lastY = newY;

                    rowWidth = separatorDistance ;
                    rowNumber++;
                    totalRows++;
                    //only increase rowidth if something was placed on the row, otherwise reset rowwidth
                }
                // Next Column on Current Row
                else if (rowWidth <= toDrawTo.Width) //if space, draw panel on same row 
                {
                    newX = lastX + panel.Width + separatorDistance;
                    newY = lastY;
                    panel.Location = new Point(newX, newY);
                    lastX = newX;
                    lastY = newY;
                    rowWidth += newPanels[0].Width + separatorDistance; //rowwidth is always reset here // gets the width of a panel
                }
                
            }

            
        }
    }
    
}
