using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using HumanBytes;

namespace CodeWars
{
    class ListFiles
    {
        static string dirPath = @"E:\Книги";

        public static void GetLargeFiles()
        {
            DirectoryInfo dir = new DirectoryInfo(dirPath);

            var allFiles = dir.EnumerateFiles("*", SearchOption.AllDirectories);

            foreach (FileInfo fi in allFiles)
            {
                if (fi.Length > 5242880) // 5MB
                {
                    Console.WriteLine($"{fi.ToString()} \n Size: {fi.Length.Bytes()}");
                }
                
            }

        }
       
    }
}
