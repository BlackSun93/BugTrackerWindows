using System;
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
            
            Size = new Size(display.Width, display.Height);
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
            display.DisplayNewProjectForm();
        }

        private void LoadProjectsToList()
        {
            //gets all the projects stored in the DB and puts them in a list
            DataTable projects = Connection.GetDbConn().GetDataTable(SqlProject.GetProjects());
            foreach (DataRow project in projects.Rows)
            {
                ProjectObject up = new ProjectObject(project["idproject"].ToString(),
                    project["projName"].ToString(), project["user"].ToString(), project["description"].ToString());
                ProjectObject.Projects.Add(up);
            }
        }

        /// <summary>
        /// This querys the database and draws a panel, with info about the project, for each project in the db
        /// a method is also added to each panel so that on click, their project page is opened
        /// This needs to be changed to not query the db as this function runs whenever the window is resized
        /// </summary>
        private void DrawPanels()
        {
            LoadProjectsToList();
            //Panel_DisplayProjects.Size = Size;

            Panel_DisplayProjects.Controls.Clear();

            int separatorDistance = 32,
                rowWidth = separatorDistance,
                totalRows = 0,
                rowNumber = totalRows,
                projectPosition = 0,
                firstColumnX = separatorDistance,
                firstColumnY = separatorDistance/2,
                lastColumnY,
                lastX = firstColumnX,
                lastY = firstColumnY,
                newX,
                newY;

            //DataTable projects = Connection.GetDbConn().GetDataTable(SqlProject.GetProjects());

            /////////////////// debug
            //label1.Text = Panel_DisplayProjects.Size.ToString();
            //label2.Text = Size.ToString();
            /////////////////////
            foreach (ProjectObject project in ProjectObject.Projects)
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
                Panel_ProjectPanel.Click += new EventHandler((sender, e) => ProjectClicked(sender, e, project.idproject.ToString()));
                Label_ProjectName.Click += new EventHandler((sender, e) => ProjectClicked(sender, e, project.idproject.ToString()));
                Label_ProjectDescription.Click += new EventHandler((sender, e) => ProjectClicked(sender, e, project.idproject.ToString()));

                Controls.Add(Panel_DisplayProjects);
                Panel_DisplayProjects.Controls.Add(Panel_ProjectPanel);
                Panel_ProjectPanel.Controls.Add(Label_ProjectName);
                Panel_ProjectPanel.Controls.Add(Label_ProjectDescription);

                rowWidth += Panel_ProjectPanel.Width + separatorDistance;

                //below code handles changing the location of the project panels
                // First Column on First Row
                if (projectPosition == 0 && totalRows == 0)//first panel
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
                else if (rowWidth > Panel_DisplayProjects.Width) //if width would be wider than the panel, make a new row
                {
                    lastColumnY = ((firstColumnY + Panel_ProjectPanel.Height) * totalRows) + separatorDistance;
                    
                    newX = firstColumnX;
                    newY = lastColumnY;
                    Panel_ProjectPanel.Location = new Point(newX, newY);
                    lastX = newX;
                    lastY = newY;

                    rowWidth = separatorDistance + Panel_ProjectPanel.Width + separatorDistance;
                    rowNumber++;
                    totalRows++;

                }
                // Next Column on Current Row
                else if (rowWidth <= Panel_DisplayProjects.Width) //if space, draw panel on same row 
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
        /// runs from window class, when window is resized, runs this code
        /// </summary>
        public void doResize()
        {
            ProjectObject.Projects.Clear();
            Size = new Size(display.Width, display.Height);
            Panel_DisplayProjects.Width = display.Width - (Window.widthOffset + 40); //as per the comment in window class,
                                                                                     //i dont really know why it needs this 10 added
            Panel_DisplayProjects.Height = display.Height - (Window.heightOffset + 80);

            DrawPanels();
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
            display.DisplayBugsForm(id);
        }
    }
}
