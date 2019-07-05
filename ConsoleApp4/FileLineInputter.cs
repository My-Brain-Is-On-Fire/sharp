using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    public static class FileSingleLineOperator
    {
        public static void Input()
        {
            Console.WriteLine("Welcome to Super Deluxe Premium Edition Line Reader!");
            Console.WriteLine("Please enter the file path:");
            
            try
            {
                string filePath = Console.ReadLine();
                var FileRetreived = new FileLineRetreiver(filePath);
                Console.Write("Please enter the line number: ");
                int lineNumber = int.Parse(Console.ReadLine());

                Console.WriteLine(FileRetreived.LineOutput(lineNumber));
            }

            catch  (FormatException)
            {
                Console.WriteLine("Please enter a valid number");
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
