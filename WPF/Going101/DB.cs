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
        private MySql.Data.MySqlClient.MySqlConnection conn;
        private string myConnectionString;

        private string server = "localhost";
        private string port =   "3306";
        private string usern =  "root";
        private string pw =     "";         //FILL IN PASSWORD
        private string datab;

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
           
            //read the non-sql table value out example:
            var rows = dt.AsEnumerable().ToArray();
            Console.WriteLine(rows[0]["Name"]);

            return dt;
            //return rows;
        }

        private void Connect()
        {
            string servr = server;
            string prt = port;
            string uid = usern;
            string pwd = pw;
            string db = datab;

            this.myConnectionString = "server=" + servr + ";uid=" + uid + ";port= " + prt + ";" +
                                      "pwd=" + pwd + ";database=" + db + ";";

            try
            {
                conn = new MySql.Data.MySqlClient.MySqlConnection(myConnectionString);
                conn.Open();

                Console.WriteLine("> Test connection made with SQL DB");

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
            Console.WriteLine("> SQL DB test connection closing");
            conn.Close();
        }

        public DataTable selectQuery(string request)
        {
            DataTable table = new DataTable();
            try
            {
                conn = new MySql.Data.MySqlClient.MySqlConnection(myConnectionString);
                conn.Open();

                table = getSQLTable(request, conn);

            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            conn.Close();
            return table;
        }

        public DB(string db)
        {
            this.datab = db;
            Connect();
        }

    }
}