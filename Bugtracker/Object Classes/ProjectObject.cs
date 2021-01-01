using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bugtracker
{
    class ProjectObject
    {
        public string idproject, projName, user, description;
        public static List<ProjectObject> Projects = new List<ProjectObject>(); //this is to be used whenever projects need storing
        //this will need clearing when navigating away from pages that show updates


        public ProjectObject(string idproject, string projName, string user, string description)
        {
            //UpdateObject up = new UpdateObject(id, posterId, comment, bugId);
            this.idproject = idproject;
            this.projName = projName;
            this.user = user;
            this.description = description;
           
        }
    }
}
