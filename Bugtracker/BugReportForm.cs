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
    public partial class BugReportForm : Form
    {
        Window display;
        public BugReportForm(Window window, string id)
        {
            display = window;
            InitializeComponent();
        }

        private void Button_Back_Click(object sender, EventArgs e, string id)
        {
            display.DisplayBugsForm(id);
        }
    }
}
