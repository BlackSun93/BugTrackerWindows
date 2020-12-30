using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bugtracker
{
    class UpdateObject
    {
        public string id, posterId, comment, bugId;
        public static List<UpdateObject> Updates = new List<UpdateObject>(); //this is to be used whenever updates need storing
        //this will need clearing when navigating away from pages that show updates


        public UpdateObject(string id, string posterId, string comment, string bugId)
        {
            //UpdateObject up = new UpdateObject(id, posterId, comment, bugId);
            this.id = id;
            this.posterId = posterId;
            this.comment = comment;
            this.bugId = bugId; 
        }

      
    }
}
