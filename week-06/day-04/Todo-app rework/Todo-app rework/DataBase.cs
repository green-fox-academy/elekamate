using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SQLite;
using System.IO;

namespace ToDoApp
{
    class DataBase
    {
        private SQLiteConnection myConnection;


        public DataBase()
        {
            myConnection = new SQLiteConnection("Data Source = todoDB.sqlite3");
            if (!File.Exists("todoDB.sqlite3"))
            {
                SQLiteConnection.CreateFile("todoDB.sqlite3");
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
    }
}
