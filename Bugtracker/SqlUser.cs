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
        
        
         private MySqlCommand _insertUser = new MySqlCommand("INSERT INTO user " +
          "(username, email, password) VALUES (@username, @email, @password)", Connection.connToDb);

        public void InsertUser(string username, string email, string password)
        {
            // Set parameters
            _insertUser.Parameters.Clear();
            _insertUser.Parameters.AddWithValue("@username", username);
            _insertUser.Parameters.AddWithValue("@email", email);
            _insertUser.Parameters.AddWithValue("@password", password);

            using (Connection.connToDb = new MySqlConnection(Connection.connStr))
            {
                try
                {
                    _insertUser.Connection.Open();
                    _insertUser.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    //Will trial this with a .ToString of the sql query (i have no idea if this will work)
                    MessageBox.Show("This query will fail " + e.Message + _insertUser.ToString());
                }

            }
        }
    }
}
