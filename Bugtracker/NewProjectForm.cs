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
    public partial class NewProjectForm : Form
    {
        public NewProjectForm()
        {
            InitializeComponent();
        }

        private void Button_BackBtn_Click(object sender, EventArgs e)
        {
            ProjectsForm pf = new ProjectsForm();
            Hide();
            pf.Show();
        }

        private void Button_SaveProject_Click(object sender, EventArgs e)
        {
            SqlProject newProject = new SqlProject();
            newProject.InserProject(TextBox_ProjectName.Text, 41 , RichTextBox_Description.Text);
            TextBox_ProjectName.Clear();
            RichTextBox_Description.Clear();
        }
    }
}
