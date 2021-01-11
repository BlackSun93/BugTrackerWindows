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
        string currentProject; //needs to keep track of what project the user is currently on
        public BugReportForm(Window window, string id)
        {
            display = window;
            InitializeComponent();
            currentProject = id;

            DataSet db = Connection.GetDbConn().GetDataSet($"SELECT idbug, title FROM bug WHERE project = {currentProject}");

            //bind the datasource to the combo box
            Combo_RefExistBug.DataSource = db.Tables[0];
            
            Combo_RefExistBug.ValueMember = "idbug";
            Combo_RefExistBug.DisplayMember = "title";
            Combo_RefExistBug.SelectedItem = null;
            Combo_RefExistBug.SelectedText = "Select a bug to reference";
            //Combo_RefExistBug.Items.Insert(0, "");
            //Combo_RefExistBug.SelectedIndex = 0;

            var itemList = new List<Item>()
            {
                new Item() { Text = "Low", Value = "1" },
                new Item() { Text = "Med", Value = "2" },
                new Item() { Text = "High", Value = "3" }
            };

            ComboBox_Priority.DataSource = itemList;
            ComboBox_Priority.DisplayMember = "Text";
            ComboBox_Priority.ValueMember = "Value";
            

            // we will enumerate these or something
            //these should numbers but display as high med low
          
            

        }

       
        private void Button_Back_Click(object sender, EventArgs e)
        {
            
            display.DisplayBugsForm(currentProject);
        }

        /// <summary>
        /// Save button clicked, makes a new bug in the database with entered information
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Save_Click(object sender, EventArgs e)
        {
            string title,
                description,
                location,
                status,
                poster,
                project,
                referencedBug,
                priority;
            DateTime timePosted;
            //var referencedBug = "";
            title = TextBox_Title.Text;
            description = RichText_Description.Text;
            location = TextBox_Location.Text;
            timePosted = System.DateTime.Now;
            status = "In Progress";
            //maybe on log in have a class (loggedUser) which stores the logged in user's ID, then go to that class
            //for this info, for now we're using 41 as test user in DB
            poster = UserObject.loggedUser.iduser;
            project = currentProject;
            var prior = (Item)ComboBox_Priority.SelectedItem;
            priority =  prior.Value;
            if (Combo_RefExistBug.SelectedItem == null)
            {
                referencedBug = "0";
            }
            else
            {
                referencedBug = Combo_RefExistBug.SelectedValue.ToString();
            }
            




            SqlBug newBug = new SqlBug();
            newBug.InsertBug(title,  description,  location,  timePosted,  status,  poster,  project,  priority, referencedBug);


            //InsertBug(string title, int description, string location, DateTime timePosted, string status,
            //string poster, string project, string priority)
            display.DisplayBugsForm(currentProject);
        }

      public void DoResize()
        {

        }

       
    }
    public class Item
    {
        public string Value { get; set; }
        public string Text { get; set; }
    }
}
