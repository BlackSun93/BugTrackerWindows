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
        Window display;

        public NewProjectForm(Window window)
        {
            InitializeComponent();
            display = window;
            
        }

        private void Button_BackBtn_Click(object sender, EventArgs e)
        {
            display.DisplayProjectsForm();
        }

        /// <summary>
        /// On save button press, inserts a new project into the database with entered information
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_SaveProject_Click(object sender, EventArgs e)
        {
            int isPrivate;
            SqlProject newProject = new SqlProject();
            if (CheckBox_PrivateProject.Checked)
            {
                isPrivate = 1;
            }
            else
            {
                isPrivate = 0;
            }
            newProject.InserProject(TextBox_ProjectName.Text, UserObject.loggedUser.iduser , RichTextBox_Description.Text, isPrivate);
            TextBox_ProjectName.Clear();
            RichTextBox_Description.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
