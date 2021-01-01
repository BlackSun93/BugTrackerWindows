using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bugtracker
{
    
    public partial class BugsForm : Form
    {
        Window display;
        string currentProject;
        public BugsForm(Window window, string id)
        {
            {
                InitializeComponent();
                display = window;
                //LoadBugs(id);
                Size = new Size(display.Width, display.Height);
                label1.Text = this.Size.ToString();
                currentProject = id; //need to track which project is being viewed so that newly reported bugs are
                //connected to the correct project and so on returning from the new bug screen, the correct project
                //is loaded. id is passed from a function applied to the panels in ProjectsForm
                DoResize();
            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            display.DisplayProjectsForm();
        }

        private void LoadBugs()
        {   //please read comment below regarding logic used and variable names (taken from ProjectsForm code)
            //go to the database with the project id, get a table containing all the bugs attached to this project
            //display these bugs to the screen

            DataTable bugs = Connection.GetDbConn().GetDataTable(SqlBug.GetBugs(currentProject));
            //gets all bugs in the selected project
        

        
            Panel_DisplayBugs.Controls.Clear();

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

            

            foreach (DataRow project in bugs.Rows)
            {
                //PLEASE NOTE this is copied from the logic used in displaying projects SO VARIABLE NAMES ARE COPIED
                //IT WORKS BUT THESE NEED RENAMING AND PANEL CONTENTS NEED CHANGING (i.e poster, date, priority etc)
                //For each project in the project table, make a panel that contains that project's title and description
                Panel Panel_ProjectPanel = new Panel
                {
                    Name = "ProjectPanel_" + project["idbug"].ToString(),
                    BackColor = Color.White,
                    Width = 220,
                    Height = 220,
                };

                Label Label_ProjectName = new Label
                {
                    Name = "ProjectName_" + project["idbug"].ToString(),
                    Location = new Point(16, 16),
                    Font = new Font("Arial", 14f, FontStyle.Bold),
                    ForeColor = Color.FromArgb(82, 82, 82),
                    MaximumSize = new Size(Panel_ProjectPanel.Width - 32, Panel_ProjectPanel.Height / 4), //50
                    AutoSize = true,
                    Text = project["title"].ToString()
                };

                Label Label_ProjectDescription = new Label
                {
                    Name = "ProjectDescription_" + project["title"].ToString(),
                    Location = new Point(16, (Panel_ProjectPanel.Height / 4) + 16), //62
                    Font = new Font("Arial", 8f, FontStyle.Bold),
                    ForeColor = Color.FromArgb(82, 82, 82),
                    MaximumSize = new Size(Panel_ProjectPanel.Width - 32, Panel_ProjectPanel.Height / 2),
                    AutoSize = true,
                    Text = project["description"].ToString()
                };
                Panel_ProjectPanel.Click += new System.EventHandler((sender, e) => BugClicked(sender, e, project["idbug"].ToString()));
                // this is adding an on click method to each generated panel
                Controls.Add(Panel_DisplayBugs);
                Panel_DisplayBugs.Controls.Add(Panel_ProjectPanel);
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
                else if (rowWidth > Panel_DisplayBugs.Width)
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
                else if (rowWidth <= Panel_DisplayBugs.Width)
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

      
        private void BugClicked(object sender, EventArgs e, string id)
        {
            display.DisplayBugInfoForm(id);
        }
        private void Button_NewBug_Click(object sender, EventArgs e)
        {
            display.DisplayBugReportForm(currentProject);
        }

        private void Button_Back_Click(object sender, EventArgs e)
        {
            display.DisplayProjectsForm();
        }
        public void DoResize()
        {
            Size = new Size(display.Width, display.Height);
            Panel_DisplayBugs.Width = display.Width - (Window.widthOffset + 10); //as per the comment in window class,
                                                                                     //i dont really know why it needs this 10 added
            Panel_DisplayBugs.Height = display.Height - Window.heightOffset;

            LoadBugs();
        }
    }
}
