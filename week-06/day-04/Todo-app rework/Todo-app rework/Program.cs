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
            string queryForInsert = "INSERT INTO todos (`todo`, `createdat`, `completedat`) VALUES (@todo, @createdat, @completedat)";
            
            DataBase todoDB = new DataBase(databaseName, queryCreateTable);

            todoDB.InsertInto(queryForInsert);
            




            //string query2 = "SELECT * FROM albums";
            //SQLiteCommand myCommand2 = new SQLiteCommand(query2, todoDB.GetMyConnection());
            //todoDB.OpenConnection();
            //SQLiteDataReader result2 = myCommand2.ExecuteReader();
            //if (result2.HasRows)
            //{
            //    while (result2.Read())
            //    {
            //        Console.WriteLine($"Album: {result2["title"]}, {result2["artist"]}");
            //    }
            //}
            //todoDB.CloseConnection();

            //Console.WriteLine($"Entries added: {result}");


            Console.ReadLine();
        }
    }
}
