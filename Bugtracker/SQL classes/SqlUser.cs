using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Bugtracker
{
    class SqlUser
    {
        /// <summary>
        /// get user commands are used when logging in on the login form, gets the user matching given log credentials
        /// </summary>
        private MySqlCommand _getUser = new MySqlCommand("SELECT * FROM user WHERE username = @username AND password = @password"
            , Connection.connToDb);


        public void GetUser(string username, string password)
        {
            _getUser.Parameters.Clear();
            _getUser.Parameters.AddWithValue("@username", username);
            _getUser.Parameters.AddWithValue("@password", password);

            // GetFromDb(_getUser).ToString();// then we can use this string (which is the user id) to get the user's info
            //this means we get the data table and the request was parameterised 
            //UserObject.loggedUser = GetFromDbTable(_getUser);
            GetFromDbTable(_getUser);
        }
        
         private MySqlCommand _insertUser = new MySqlCommand("INSERT INTO user " +
          "(username, email, password) VALUES (@username, @email, @password)", Connection.connToDb);

        public void InsertUser(string username, string email, string password)
        {
            // Set parameters
            _insertUser.Parameters.Clear();
            _insertUser.Parameters.AddWithValue("@username", username);
            _insertUser.Parameters.AddWithValue("@email", email);
            _insertUser.Parameters.AddWithValue("@password", password);

            GoToDb(_insertUser);

        
        }
        /// <summary>
        /// executes an action on the DB but doesn't return anything
        /// </summary>
        /// <param name="toExecute"></param>
        private void GoToDb(MySqlCommand toExecute)
        {
            using (Connection.connToDb = new MySqlConnection(Connection.connStr))
            {
                try
                {
                    toExecute.Connection.Open();
                    toExecute.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    //Will trial this with a .ToString of the sql query (i have no idea if this will work)
                    MessageBox.Show("This query will fail " + e.Message + toExecute.ToString());
                }

            }
        }
        /// <summary> UNUSED
        /// This function uses a scalar to retrieve one value from the db, this could be used to
        /// make sure the query is parameterised, then use a query like in bugs/ projects to retrieve that user
        /// as a dataTable (as this is an easy object to convert into a User object)
        /// HOWEVER this means going to the DB twice
        /// </summary>
        /// <param name="toRetrieve"></param>
        /// <returns></returns>
        private object GetFromDb(MySqlCommand toRetrieve)
        {
            using (Connection.connToDb = new MySqlConnection(Connection.connStr))
            {
                try
                {
                    toRetrieve.Connection.Open();
                    return toRetrieve.ExecuteScalar();
                }
                catch (Exception e)
                {
                    //Will trial this with a .ToString of the sql query (i have no idea if this will work)
                   return MessageBox.Show("This query will fail " + e.Message + toRetrieve.ToString());
                }

            }
        }

        /// <summary>
        /// uses a mysqlcommand to make a mysqlreader object, reads over this object and makes a userObject
        /// assigns the public static userobject variable 'loggeduser' to whichever user logged in
        /// </summary>
        /// <param name="toRetrieve"></param>
        private void GetFromDbTable (MySqlCommand toRetrieve)
        {
            List<string> data = new List<string>();
            // UserObject loggedIn; out of scope for return
            using (Connection.connToDb = new MySqlConnection(Connection.connStr))
            {
                try
                {
                    
                    toRetrieve.Connection.Open();
                    MySqlDataReader table = toRetrieve.ExecuteReader(); //you have to use read() before getting vals
                    while (table.Read())
                    {
                        data.Add(table[0].ToString());
                        data.Add(table[1].ToString());
                        data.Add(table[2].ToString()); 
                         //loggedIn = new UserObject(table[0].ToString(), table[1].ToString()); loggedin out of return scope
                        
                    }
                    UserObject loggedIn = new UserObject(data[0], data[1]);
                    UserObject.loggedUser = loggedIn;
                    

                }
                catch (Exception e)
                {
                    //Will trial this with a .ToString of the sql query (i have no idea if this will work)
                     MessageBox.Show("This query will fail " + e.Message + toRetrieve.ToString());
                     
                }

            }

           
            
            
        }
        
    }
}
