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
        public BugsForm(Window window, string id)
        {
            {
                InitializeComponent();
                display = window;
                LoadBugs(id);
                Size = new Size(display.Width, display.Height);
                label1.Text = this.Size.ToString();
                NewBugOnClick(id);
                
            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            display.DisplayProjectsForm();
        }

        private void LoadBugs(string id)
        {
            //go to the database with the project id, get a table containing all the bugs attached to this project
            //display these bugs to the screen
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

            DataTable bugs = Connection.GetDbConn().GetDataTable(SqlBug.GetBugs(id));

            foreach (DataRow project in bugs.Rows)
            {
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
               // Panel_ProjectPanel.Click += new System.EventHandler((sender, e) => BugClicked(sender, e, project["idproject"].ToString()));

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

        /// <summary>
        /// cant pass arguements into initialiseComponent function which means .designer code
        /// cant pass the project's ID into the new bug form. Adding the onclick function
        /// here instead of in .designer code should work
        /// </summary>
        /// <param name="id"></param>
        private void NewBugOnClick(string id)
        {
            //Button_NewBug
        }
        private void BugClicked(object sender, EventArgs e, string id)
        {

        }

        private void Button_NewBug_Click(object sender, EventArgs e, string id)
        {
            display.DisplayBugReportForm(id);
        }
    }
}
