using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    public static class ArrayDuplicates
    {

        public static void GetDupe(int[] array)
        {
            Dictionary<int, int> dupeCount = new Dictionary<int, int>();

            foreach (int element in array)
            {
                if (!dupeCount.ContainsKey(element))
                    dupeCount[element] = 1;
                else
                    dupeCount[element]++;
            }
        
            foreach (var element in dupeCount)
            {
                if (element.Value > 1)
                    Console.WriteLine($"Number {element.Key} repeats {element.Value} times.");
            }
        }

        public static void GetDupe2(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                        Console.WriteLine($"Match detected: Element {i} ({array[i]}) is identical to element {j}");

                }
            }
            
        }


    }
}
