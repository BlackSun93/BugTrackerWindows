using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bugtracker
{
    class UserObject
    {
        public string iduser;
        public string username;
        public static UserObject loggedUser = new UserObject("25", "not logged in"); //should pass details about the logged user when needed
                                                        //25 used as al user ids end in 1 so it should be easy to see where this is used,
                                                        //these need a value as login form isn;t the first form a user sees right now.
        //public static UserObject failedLog = new UserObject("999", "failed");
        public UserObject(string id, string username)
        {
            this.iduser = id;
            this.username = username;
        }
    }
}
