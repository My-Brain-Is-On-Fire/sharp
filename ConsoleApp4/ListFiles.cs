using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using HumanBytes;

namespace CodeWars
{
    public class ListFiles
    {
        static int filterSize = 5 * 1024 * 1024; // 5MB

        public static void GetLargeFiles(string dirPath)
        {
            DirectoryInfo dir = new DirectoryInfo(dirPath);

            var allFiles = dir.EnumerateFiles("*", SearchOption.AllDirectories);

            foreach (FileInfo fi in allFiles)
            {
                if (fi.Length > filterSize)
                {
                    Console.WriteLine($"{fi.ToString()} \n Size: {fi.Length.Bytes()}");
                }
            }
        }
    }
}
