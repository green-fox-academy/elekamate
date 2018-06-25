using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string databaseName = "todo";
            string queryCreateTable = @"CREATE TABLE `todos` (
	                                        `id`	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
	                                        `todo`	TEXT NOT NULL,
	                                        `createdat`	INTEGER NOT NULL,
	                                        `completedat`	INTEGER
                                        );";
            
            DataBase todoDB = new DataBase(databaseName, queryCreateTable);
            todoDB.InsertInto("x1");
            //string query2 = "SELECT * FROM todos";
            //todoDB.SelectData(query2);
            Console.ReadLine();
        }
    }
}
