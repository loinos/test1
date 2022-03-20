using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;


namespace test1.Data
{
    public class DatabaseConnect
    {
        private static MySqlConnection mySqlConnection;
        public static MySqlConnection GetDBConnection()
        {
            String connString = "Server=eu-cdbr-west-02.cleardb.net;Database=heroku_4cd4b5c20e2361e;port=3306;User Id=b77b8589b4af06;password=4517c819;";

            MySqlConnection conn = new MySqlConnection(connString);

            return conn;
        }
        public static void connectToDB()
        {
            string _connectStr = "Server=eu-cdbr-west-02.cleardb.net;Database=heroku_4cd4b5c20e2361e;port=3306;User Id=b77b8589b4af06;password=4517c819;";
            try
            {
                mySqlConnection = new MySqlConnection(_connectStr);
                mySqlConnection.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: not connect to database");
                throw;
            }
        }
    }
}