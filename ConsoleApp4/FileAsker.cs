using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    public class FileAsker
    {
        public static void Ask()
        {
            Console.WriteLine(@"What do you want to do?  
                1. Read a line 
                2. Insert a line");

            int answer = int.Parse(Console.ReadLine());
            switch (answer)
            {
                case 1:
                    FileLineInputter.Input();
                    break;
                case 2:
                    FileLineInserter.Insert();
                    break;
                default:
                    Console.WriteLine($"{answer}? Unexpected...");
                    break;
            }
        }
        

        
}
}
