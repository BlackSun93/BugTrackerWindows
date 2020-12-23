﻿using System;
using System.Data;
using System.Drawing;

using System.Windows.Forms;

namespace Bugtracker
{
    public partial class ProjectsForm : Form
    {
        Window display;
        public ProjectsForm(Window window)
        {
            InitializeComponent();
            display = window;
            DrawPanels();

        }

        private void Button_NewProject_Click(object sender, EventArgs e)
        {
            display.DisplayNewProjectForm();
        }

        private void DrawPanels()
        {
            Panel_DisplayProjects.Controls.Clear();

            int separatorDistance = 32,
                maxWidth = display.Width, //added
                rowWidth = separatorDistance,
                columnHeight = separatorDistance,
                totalRows = 0,
                rowNumber = totalRows,
                projectPosition = 0,
                firstColumnX = separatorDistance,
                firstColumnY = separatorDistance,
                lastColumnY,
                lastX = firstColumnX,
                lastY = firstColumnY,
                newX,
                newY;

            DataTable projects = Connection.GetDbConn().GetDataTable(SqlProject.GetProjects());

            foreach (DataRow project in projects.Rows)
            {
                //For each project in the project table, make a panel that contains that project's title and description
                Panel Panel_ProjectPanel = new Panel
                {
                    Name = "ProjectPanel_" + project["idproject"].ToString(),
                    BackColor = Color.White,
                    Width = 230,
                    Height = 146
                };

                Label Label_ProjectName = new Label
                {
                    Name = "ProjectName_" + project["idproject"].ToString(),
                    Location = new Point(16, 16),
                    Text = project["projName"].ToString()
                };

                Label Label_ProjectDescription = new Label
                {
                    Name = "ProjectDescription_" + project["idproject"].ToString(),
                    Location = new Point(16, 64),
                    Text = project["description"].ToString()
                };

                //add this panel to the projectsForm, add the labels to the new panel
                Controls.Add(Panel_DisplayProjects);
                Panel_DisplayProjects.Controls.Add(Panel_ProjectPanel);
                Panel_ProjectPanel.Controls.Add(Label_ProjectName);
                Panel_ProjectPanel.Controls.Add(Label_ProjectDescription);

                //to keep track of when a new row is needed, rowWidth is the total of all panel widths + separator distance

                rowWidth += Panel_ProjectPanel.Width + separatorDistance;

                // First Column on First Row
                if (projectPosition == 0 && totalRows == 0)
                {
                    newX = firstColumnX;
                    newY = firstColumnY;
                    Panel_ProjectPanel.Location = new Point(newX, newY);
                    lastX = newX;
                    lastY = newY;

                    rowNumber++;
                    totalRows++;
                }
                // First Column on Next Row
                // else if (rowWidth > Panel_DisplayProjects.Width)
                else if (rowWidth > maxWidth) //changed to take max width of the display
                {
                    lastColumnY = ((firstColumnY + Panel_ProjectPanel.Height) * totalRows) + separatorDistance;
                    
                    newX = firstColumnX;
                    newY = lastColumnY;
                    Panel_ProjectPanel.Location = new Point(newX, newY);
                    lastX = newX;
                    lastY = newY;

                    rowWidth = separatorDistance + Panel_ProjectPanel.Width + separatorDistance;
                    //columnHeight += Panel_ProjectPanel.Height + separatorDistance;
                    rowNumber++;
                    totalRows++;

                }
                // Next Column on Current Row
                //else if (rowWidth <= Panel_DisplayProjects.Width) CHANGED as this was writing the 2nd row weirdly
                else if (rowWidth <= maxWidth)
                {
                    newX = lastX + Panel_ProjectPanel.Width + separatorDistance;
                    newY = lastY;
                    Panel_ProjectPanel.Location = new Point(newX, newY);
                    lastX = newX;
                    lastY = newY;
                }

                projectPosition++;
            }
        }






        /// <summary>
        /// neither of these are called
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void ProjectsForm_Resize(object sender, EventArgs e)
        {
            DrawPanels();
            Width = display.Width;
            Height = display.Height;
        }

        public void testResize()
        {
            Width = display.Width;
            Height = display.Height;
            DrawPanels();
            
        }
    }
}
