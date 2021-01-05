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
        
        /// <summary>
        /// this generates the large panels that the projects are attached to
        /// </summary>
        /// <param name="toDrawTo"></param>
        /// <param name="sections"></param>
        /// <param name="window"></param>
        public void BasePanels (Panel toDrawTo, List<List<ProjectObject>> sections, Window window)
        {

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
                };
                toDrawTo.Controls.Add(Panel_Container);
                GridDraw(toDrawTo, Panel_Container, i);
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

            int i = 0; //needs this to allow GridDraw to know if 1st panel of not
            int totalRows = 0;
            foreach (ProjectObject project in dataset)
            {
                //For each project in the project table, make a panel that contains that project's title and description
                //maybe make a drawing class to manage this code, could pass in the panel to add things to
                //(here it would be Panel_DisplayProjects)
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

                GridDraw(toDrawTo, Panel_ProjectPanel, i);
                i++;

            } 

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

        private void GridDraw(Panel toDrawTo, Panel newPanel, int projectPosition) //needs to know if its drawing 1st panel or no
        {
            int separatorDistance = 32,
              rowWidth = separatorDistance,
              totalRows = 0, //cant set to 0 here as this happens for each project (may explain why all drawing to 0th line)
              rowNumber = totalRows,
              //projectPosition = 0,
              firstColumnX = separatorDistance,
              firstColumnY = separatorDistance / 2,
              lastColumnY,
              lastX = firstColumnX,
              lastY = firstColumnY,
              newX,
              newY;
            rowWidth += newPanel.Width + separatorDistance; //rowwidth is always reset here

            //below code handles changing the location of the project panels
            // First Column on First Row
            if (projectPosition == 0 && totalRows == 0)//first panel
            {
                newX = firstColumnX;
                newY = firstColumnY;
                newPanel.Location = new Point(newX, newY);
                lastX = newX;
                lastY = newY;

                rowNumber++;
                totalRows++;
            }
            // First Column on Next Row
            else if (rowWidth > toDrawTo.Width) //if width would be wider than the panel, make a new row
            {
                lastColumnY = ((firstColumnY + toDrawTo.Height) * totalRows) + separatorDistance;

                newX = firstColumnX;
                newY = lastColumnY;
                newPanel.Location = new Point(newX, newY);
                lastX = newX;
                lastY = newY;

                rowWidth = separatorDistance + newPanel.Width + separatorDistance;
                rowNumber++;
                totalRows++;

            }
            // Next Column on Current Row
            else if (rowWidth <= toDrawTo.Width) //if space, draw panel on same row 
            {
                newX = lastX + newPanel.Width + separatorDistance;
                newY = lastY;
                newPanel.Location = new Point(newX, newY);
                lastX = newX;
                lastY = newY;
            }
        }
    }
    
}
