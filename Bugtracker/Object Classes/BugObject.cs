using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bugtracker
{
    public class BugObject
    {
        public string idbug, title, description, location, status, poster, project, priority;
        public DateTime timePosted;
        public static List<BugObject> Bugs = new List<BugObject>(); //this is to be used whenever projects need storing
        //this will need clearing when navigating away from pages that show updates
        public static List<BugObject> followedBugs = new List<BugObject>();
        //public static List<BugObject> 


        public BugObject(string idbug, string title, string description, string location, 
            string status, string poster, string project, string priority, DateTime timePosted)
        {
            //UpdateObject up = new UpdateObject(id, posterId, comment, bugId);
            this.idbug = idbug;
            this.title = title;
            this.description = description;
            this.location = location;
            this.status = status;
            this.poster = poster;
            this.project = project;
            this.priority = priority;
            this.timePosted = timePosted;

        }
    }
}
