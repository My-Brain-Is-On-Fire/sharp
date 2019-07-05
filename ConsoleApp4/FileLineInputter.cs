using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    static class FileLineInputter
    {
        public static void Input()
        {
            Console.WriteLine("Welcome to Super Deluxe Premium Edition Line Reader!");
            Console.WriteLine("Please enter the file path:");
            
            try
            {
                string filePath = Console.ReadLine();
                var FileRetreiver = new FileLineRetreiver(filePath);
                Console.Write("Please enter the line number: ");
                int lineNumber = int.Parse(Console.ReadLine());

                Console.WriteLine(FileRetreiver.LineOutput(lineNumber));
            }
            catch  (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Your number exceeds number of lines in the file");
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
