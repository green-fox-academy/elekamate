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
            DataBase todoDB = new DataBase();

            string query = "INSERT INTO album ('title', 'artist') VALUES (@title, @artist)";
            SQLiteCommand myCommand = new SQLiteCommand(query, todoDB.GetMyConnection());
            todoDB.OpenConnection();
            myCommand.Parameters.AddWithValue("@title", "xx");
            myCommand.Parameters.AddWithValue("@artist", "yy");

            var result = myCommand.ExecuteNonQuery();
            todoDB.CloseConnection();

            Console.WriteLine($"Entries added: {result}");




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

            Console.WriteLine($"Entries added: {result}");


            Console.ReadLine();
        }
    }
}
