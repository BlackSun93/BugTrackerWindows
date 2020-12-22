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
    public partial class ProjectsForm : Form
    {
        public ProjectsForm()
        {
            InitializeComponent();
            DrawProjects();
        }

        private void DrawProjects()
        {
            int projectNameStart = 0;
            int projectDecStart = 0;
            int panelStart = 0;
            DataSet projects = Connection.GetDbConn().GetDataSet(SqlProject.GetProjects());
            //DataRow sectionDBValue = projects.Tables[0].Rows[0];
            foreach (DataRow project in projects.Tables)
            {
                
                this.panel2.Controls.Add(this.label3);
                this.panel2.Controls.Add(this.label2);
                this.panel2.Location = new System.Drawing.Point(218, 93);
                this.panel2.Name = "panel2";
                this.panel2.Size = new System.Drawing.Size(165, 146);
                this.panel2.TabIndex = 1;
            
                // 
                // label3
                // 
                this.label3.AutoSize = true;
                this.label3.Location = new System.Drawing.Point(23, 40);
                this.label3.Name = "label3";
                this.label3.Size = new System.Drawing.Size(35, 13);
                this.label3.TabIndex = 1;
                this.label3.Text = "label3";
                // 
                // label2
                // 
                this.label2.AutoSize = true;
                this.label2.Location = new System.Drawing.Point(20, 12);
                this.label2.Name = "label2";
                this.label2.Size = new System.Drawing.Size(35, 13);
                this.label2.TabIndex = 0;
                this.label2.Text = "label2";
                this.Controls.Add(this.panel2);
                //panel.name = ""
                projectNameStart++;
                projectDecStart++;
                panelStart++;
            }


            //throw new NotImplementedException();
        }
        /*
         * // Creating and setting the properties of label
int yCoord = firstSectionStartingYCoord + (numberOfSections * spacingBetweenSections) + (numberOfComments * spacingBetweenComments);
Label section = new Label();
section.AutoSize = true;
section.Text = dr["sectionName"].ToString();
section.Location = new Point(220, yCoord);
section.ForeColor = Color.DodgerBlue;
section.Anchor = AnchorStyles.Top;
section.Font = new Font("Microsoft Sans Serif", 14);
// Adding this label to form
this.Controls.Add(section);*/

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void propertyGrid1_Click(object sender, EventArgs e)
        {

        }

        private void newProject_Click(object sender, EventArgs e)
        {
            NewProjectForm np = new NewProjectForm();
            this.Hide();
            np.Show();
        }

        
    }
}
