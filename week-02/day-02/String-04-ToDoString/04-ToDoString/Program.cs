using System;
using System.Text;

namespace TodoPrint
{
    public class TodoPrint
    {
        public static void Main(string[] args)
        {
            string todoText = " - Buy milk\n";
            // Add "My todo:" to the beginning of the todoText
            // Add " - Download games" to the end of the todoText
            // Add " - Diablo" to the end of the todoText but with indentation

            // Expected output:

            // My todo:
            //  - Buy milk
            //  - Download games
            //      - Diablo
            StringBuilder stringBuilder = new StringBuilder();
            string begginingOfTodo= "My todo:\n";
            string todo2ndLine = " - Download games";
            string todo3rdLine = "\n\t - Diablo";

            stringBuilder.Append(todoText);
            stringBuilder.Insert(0, begginingOfTodo);
            stringBuilder.Append(todo2ndLine);
            stringBuilder.Append(todo3rdLine);
            Console.WriteLine(stringBuilder.ToString());

            Console.ReadLine();
        }
    }
}