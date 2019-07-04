using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the file path: ");
            string path = Console.ReadLine();

            var printer = new ListFilesPrinter();
            printer.Print(path);

            Console.ReadKey();
        }
    }
}
