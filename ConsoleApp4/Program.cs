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

            //Console.WriteLine("Input something");
            //string input = Console.ReadLine();
            //Console.WriteLine(Kata.AlphabetPosition(input));
            List<int> sampleIntList = new List<int>() { 1, 2, 1, 1, 3, 3, 2, 45 };

            int[] dupeArray = { 1, 2, 1, 1, 3, 3, 2, 45 };
            
            
            ArrayDuplicates.GetDupe2(dupeArray);
            Console.ReadKey();
        }
    }
}
