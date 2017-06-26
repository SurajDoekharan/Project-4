//use package control manager and put in "PM > Install-Package MySql.Data -Version 6.9.9" to make it work
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Going101
{
    class DB
    {
        MySql.Data.MySqlClient.MySqlConnection conn;
        string myConnectionString;
        DataTable table = new DataTable();

        private DataTable getSQLTable(string request, MySql.Data.MySqlClient.MySqlConnection conn)
        {
            var dt = new DataTable();
            MySqlCommand cmd = new MySqlCommand(request, conn);
            
            //Debug test
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                for (var i = 0; i < reader.FieldCount; i++)
                {
                    Console.Write(reader[i] + " ");
                }
                Console.WriteLine();
            }
            reader.Close();

            dt.Load(cmd.ExecuteReader());
           
            //to read the table out:
            var rows = dt.AsEnumerable().ToArray();
            Console.WriteLine(rows[0]["Name"]);

            return dt;
            //return rows;
        }

        public DB(string server, string uid, string port, string pwd, string db)
        {
            //dbConnection("localhost", "root", "3306", "Z46f5x65V", "project4test");
            myConnectionString = "server=" + server + ";uid=" + uid + ";port= " + port + ";" +
               "pwd=" + pwd + ";database=" + db + ";";

            try
            {
                conn = new MySql.Data.MySqlClient.MySqlConnection(myConnectionString);
                Console.WriteLine("Connecting to server");
                conn.Open();

                //sets request in a not-sql table for outside sql usage
                table = getSQLTable("SELECT * FROM events", conn);
                
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 1:
                        Console.WriteLine("Cannot connect to server.  Contact administrator");
                        break;
                    case 1045:
                        Console.WriteLine("Invalid username/password, please try again");
                        break;
                }
            }
            conn.Close();
        }
    }
}