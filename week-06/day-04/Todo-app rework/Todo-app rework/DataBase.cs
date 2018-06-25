﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SQLite;
using System.IO;

namespace ToDoApp
{
    class DataBase
    {
        private SQLiteConnection myConnection;

        public DataBase(string dbFileName, string queryCreateTable)
        {
            myConnection = new SQLiteConnection($"Data Source = {dbFileName}.sqlite3");
            if (!File.Exists($"{dbFileName}.sqlite3"))
            {
                SQLiteConnection.CreateFile($"{dbFileName}.sqlite3");
                OpenConnection();
                SQLiteCommand command = new SQLiteCommand(queryCreateTable, myConnection);
                command.ExecuteNonQuery();
                CloseConnection();
                Console.WriteLine("Todo DB has not found, file created.");
            }
            else
            {
                Console.WriteLine("Todo DB file already exists, it will be used.");
            }
        }

        public SQLiteConnection GetMyConnection()
        {
            return myConnection;
        }

        public void OpenConnection()
        {
            if (myConnection.State != System.Data.ConnectionState.Open)
            {
                myConnection.Open();
            }
        }

        public void CloseConnection()
        {
            if (myConnection.State != System.Data.ConnectionState.Closed)
            {
                myConnection.Close();
            }
        }

        public void InsertInto(string todoDescr, object completedat)
        {
            string queryForInsert = "INSERT INTO todos (`todo`, `createdat`, `completedat`) VALUES (@todo, @createdat, @completedat)";
            SQLiteCommand myCommand = new SQLiteCommand(queryForInsert, myConnection);
            OpenConnection();
            myCommand.Parameters.AddWithValue("@todo", todoDescr);
            myCommand.Parameters.AddWithValue("@createdat", DateTime.Now);
            myCommand.Parameters.AddWithValue("@completedat", completedat);
            var result = myCommand.ExecuteNonQuery();
            CloseConnection();
            Console.WriteLine($"Entries added: {result}");
        }

        public void SelectData(string queryForSelect)
        {
            SQLiteCommand myCommand2 = new SQLiteCommand(queryForSelect, GetMyConnection());
            OpenConnection();
            SQLiteDataReader result2 = myCommand2.ExecuteReader();
            if (result2.HasRows)
            {
                while (result2.Read())
                {
                    Console.WriteLine($"todos: {result2["todo"]}, {result2["createdat"]}, {result2["completedat"]}");
                }
            }
            CloseConnection();
            Console.WriteLine($"Entries read: {result2}");
        }
    }
}
