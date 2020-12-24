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
                label1.Text = id;
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
        }
    }
}
