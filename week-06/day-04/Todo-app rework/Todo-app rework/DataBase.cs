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
    }
}
