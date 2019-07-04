using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CodeWars
{
    public class FileLister
    {
        static int filterSize = 5 * 1024 * 1024; // 5MB

        public Dictionary<string, long> GetLargeFiles(string dirPath)
        {
            DirectoryInfo dir = new DirectoryInfo(dirPath);

            var allFiles = dir.EnumerateFiles("*", SearchOption.AllDirectories);
            var filePathSize = new Dictionary<string, long>();

            foreach (FileInfo fi in allFiles)
            {
                if (fi.Length > filterSize)
                {
                    filePathSize.Add(fi.ToString(), fi.Length);
                }
            }
            return filePathSize;
        }
    }
}
