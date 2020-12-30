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
    public partial class BugInfoForm : Form
    {
        Window display;
        string currentBug;
        //how to go back to the correct project after a bug has been selected?
        //bug info loaded so we can use the project section of it
        public BugInfoForm(Window window, string bugId)
        {
            //this form should show info on the bug such as title, description AND updates
            //this form should show the user a button to add an update on the bug

            InitializeComponent();
            display = window;
            LoadInfo(bugId);
            LoadUpdatesToList(bugId);
            Size = new Size(display.Width, display.Height);
            currentBug = bugId;
            //label1.Text = this.Size.ToString();
            
            //DoResize();
        }

        private void LoadInfo(string bugId)
        {
            //needs to populate labels and rich text box
            DataTable bugInfo = Connection.GetDbConn().GetDataTable(SqlBug.GetOneBug(bugId));
            DataRow row = bugInfo.Rows[0];

            Label_Title.Text = row["title"].ToString();
            RichText_Description.Text = row["description"].ToString();
            Label_Poster.Text = row["poster"].ToString(); //this will show id, either use FK to get name or translate

        }
        private void LoadUpdatesToList(string bugId)
        {
            //needs to go to db with bug id, return a table of updates and store these in a list
        }

        private void Button_Back_Click(object sender, EventArgs e)
        {
            //THIS NEEDS TO BE CHANGED, IDEALLY WHEN PAGE LOADED, CREATE BUG INSTANCE INSTEAD OF ANOTHER QUERY
            DataTable bugInfo = Connection.GetDbConn().GetDataTable(SqlBug.GetOneBug(currentBug));
            DataRow row = bugInfo.Rows[0];

            display.DisplayBugsForm(row["project"].ToString());
        }

        private void Button_AddUpdate_Click(object sender, EventArgs e)
        {
            display.DisplayPostUpdateForm(currentBug);
        }
    }
}
