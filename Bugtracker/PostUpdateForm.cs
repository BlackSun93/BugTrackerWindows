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
    public partial class PostUpdateForm : Form
    {
        Window display;
        string currentBug;
        public PostUpdateForm(Window window, string bugId)
        {
            InitializeComponent();
            display = window;
            //LoadBugs(id);
            Size = new Size(display.Width, display.Height);
            currentBug = bugId;
            //label1.Text = this.Size.ToString();
            //currentProject = id; //need to track which project is being viewed so that newly reported bugs are
                                 //connected to the correct project and so on returning from the new bug screen, the correct project
                                 //is loaded. id is passed from a function applied to the panels in ProjectsForm
            //DoResize();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            display.DisplayBugInfoForm(currentBug);
        }
    }
}
