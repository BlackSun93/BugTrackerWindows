using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Bugtracker
{
    class Connection
        ///
        /// I want a connection class like we used in the feedback project. This class will deal with making connections to the DB
        /// This might be complicated by the cloud-hosted nature of the DB but i'm sure we'll figure it out
        /// please note that differeing from the feedback project, we use MySqlConnection instead of SqlConnection
        /// I have an issue now ehre i want all requests to the DB to be parameterised however MySqlCommands
        /// need a string and the connToDb string. ConnToDb is private to this class so either 
        /// make it public and allow multiple classes to access it or put all sql requests here

    {
      

        // Private object of the class
        private static Connection _instance;

        //private string connStr;
        // public MySqlConnection connToDb;
        public static string connStr;
        public static MySqlConnection connToDb;

        /// <summary>
        /// default constructor
        /// </summary>
        private Connection()
        {
            connStr = Properties.Settings.Default.database;
            

        }

        /// <summary>
        /// creates a connection with the DB, needs to be used before other methods
        /// </summary>
        /// <returns>returns a connection to the DB</returns>        
        public static Connection GetDbConn()
        {
            if (_instance == null)
                _instance = new Connection();
            return _instance;

        }

        /// <summary>
        /// 
        ///    This method opens a connection to the database, takes a sqlquery and returns the results of this query
        /// 
        /// </summary>
        /// <param name="sqlQuery">SQL code to be used. code will be from SqlQueries.cs </param>
        /// <returns>Returns the result of the sql query</returns>
        public DataSet GetDataSet(string sqlQuery)
        {
            DataSet dataSet = new DataSet(); // Create empty dataset
            using (connToDb = new MySqlConnection(connStr))
            {
                // Open connection
                connToDb.Open();
                // Create the object dataadapter to send query to db
                MySqlDataAdapter adapter = new MySqlDataAdapter(sqlQuery, connToDb);
                adapter.Fill(dataSet);

            }
            return dataSet;
        }

        /// <summary>
        /// 
        ///   executes code on the DB and doesn't return anything
        /// 
        /// </summary>
        /// <param name="queryString"> sql query to be executed on the DB. </param>
        public void CreateCommand(string queryString)
        {
            using (connToDb = new MySqlConnection(connStr))
            {
                MySqlCommand command = new MySqlCommand(queryString, connToDb);
                command.Connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void TestCommand(MySqlCommand test)
        {
            using (connToDb = new MySqlConnection(connStr))
            {

            }
        }
    }



}
