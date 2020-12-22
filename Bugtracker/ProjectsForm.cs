using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;

using System.Windows.Forms;

namespace Bugtracker
{
    public partial class ProjectsForm : Form
    {
        public ProjectsForm()
        {
            InitializeComponent();
            DrawPanels();
        }

        private void newProject_Click(object sender, EventArgs e)
        {
            NewProjectForm np = new NewProjectForm();
            Hide();
            np.Show();
        }

        private void DrawPanels()
        {
            Panel_DisplayProjects.Controls.Clear();

            int separatorDistance = 32;
            int rowWidth = separatorDistance;
            int totalRows = 0;
            int rowNumber = totalRows;
            int projectPosition = 0;
            int firstColumnX = separatorDistance;
            int firstColumnY = separatorDistance;
            int lastColumnY = firstColumnY;
            int lastX = firstColumnX;
            int lastY = firstColumnY;
            int newX;
            int newY;

            DataTable projects = Connection.GetDbConn().GetDataTable(SqlProject.GetProjects());

            foreach (DataRow project in projects.Rows)
            {
                Panel Panel_ProjectPanel = new Panel();
                Panel_ProjectPanel.Name = "ProjectPanel_" + project["idproject"].ToString();
                Panel_ProjectPanel.BackColor = Color.White;
                Panel_ProjectPanel.Width = 230;
                Panel_ProjectPanel.Height = 146;

                Label Label_ProjectName = new Label();
                Label_ProjectName.Name = "ProjectName_" + project["idproject"].ToString();
                Label_ProjectName.Location = new Point(16, 16);
                Label_ProjectName.Text = project["projName"].ToString();

                Label Label_ProjectDescription = new Label();
                Label_ProjectDescription.Name = "ProjectDescription_" + project["idproject"].ToString();
                Label_ProjectDescription.Location = new Point(16, 64);
                Label_ProjectDescription.Text = project["description"].ToString();

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

        private void ProjectsForm_Resize(object sender, EventArgs e)
        {
            DrawPanels();
        }
    }
}
