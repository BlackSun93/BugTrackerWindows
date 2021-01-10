using System.Collections.Generic;

namespace Bugtracker
{
    class ProjectObject
    {
        public string idproject, projName, user, description;
        public int isPrivate; // 0 = public, 1 = private
        public static List<ProjectObject> Projects = new List<ProjectObject>(); //this is to be used whenever projects need storing
        //this will need clearing when navigating away from pages that show updates
        public static List<ProjectObject> UserProjects = new List<ProjectObject>(); //used to store projects the user has made
        public static List<ProjectObject> followProjects = new List<ProjectObject>(); //stores projects a user follows


        public ProjectObject(string idproject, string projName, string user, string description, int isPrivate)
        {
            //UpdateObject up = new UpdateObject(id, posterId, comment, bugId);
            this.idproject = idproject;
            this.projName = projName;
            this.user = user;
            this.description = description;
            this.isPrivate = isPrivate;
           
        }
    }
}
