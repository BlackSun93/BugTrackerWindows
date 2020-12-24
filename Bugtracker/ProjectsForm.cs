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
                rowWidth = separatorDistance,
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
                    Width = 220,
                    Height = 220,
                };

                Label Label_ProjectName = new Label
                {
                    Name = "ProjectName_" + project["idproject"].ToString(),
                    Location = new Point(16, 16),
                    Font = new Font("Arial", 14f, FontStyle.Bold),
                    ForeColor = Color.FromArgb(82, 82, 82),
                    MaximumSize = new Size(Panel_ProjectPanel.Width - 32, Panel_ProjectPanel.Height / 4), //50
                    AutoSize = true,
                    Text = project["projName"].ToString()
                };

                Label Label_ProjectDescription = new Label
                {
                    Name = "ProjectDescription_" + project["idproject"].ToString(),
                    Location = new Point(16, (Panel_ProjectPanel.Height / 4) + 16), //62
                    Font = new Font("Arial", 8f, FontStyle.Bold),
                    ForeColor = Color.FromArgb(82, 82, 82),
                    MaximumSize = new Size(Panel_ProjectPanel.Width - 32, Panel_ProjectPanel.Height / 2),
                    AutoSize = true,
                    Text = project["description"].ToString()
                };
                Panel_ProjectPanel.Click += new System.EventHandler((sender, e) => ProjectClicked(sender, e, project["idproject"].ToString()));

                Controls.Add(Panel_DisplayProjects);
                Panel_DisplayProjects.Controls.Add(Panel_ProjectPanel);
                Panel_ProjectPanel.Controls.Add(Label_ProjectName);
                Panel_ProjectPanel.Controls.Add(Label_ProjectDescription);

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
                else if (rowWidth > Panel_DisplayProjects.Width)
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
                else if (rowWidth <= Panel_DisplayProjects.Width)
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

        public void doResize()
        {
            Size = new Size(display.Width, display.Height);

            DrawPanels();
        }

        private void ProjectClicked(object sender, EventArgs e, string id)
        {

            display.DisplayBugsForm(id);
        }
    }
}
