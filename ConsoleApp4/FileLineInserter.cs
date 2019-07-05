using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    static class FileLineInserter
    {
        public static void Insert()
        {
            // bothersome to input, hardcoded for now 
            string filePath = @"C:\AMFTrace.log";
            var FileRetreived = new FileLineRetreiver(filePath);
            Console.WriteLine($"Preparing {filePath} for insertion...");

            Console.WriteLine("What text do you want to insert?");
            string text = Console.ReadLine();
            Console.Write("Please enter the line number : ");
            int lineNumber = int.Parse(Console.ReadLine());

            
            FileRetreived.LineInsert(text, lineNumber - 1);

            Console.WriteLine("Great Success!");
            foreach (var row in FileRetreived.Lines.ToList())
            {
                Console.WriteLine(row);
            }
        }
    }
}
