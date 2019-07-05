using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HumanBytes;

namespace CodeWars
{
    public class FileListPrinter
    {
        public void Print(string path)
        {
            var filelister = new FileLister();
            var filesList = filelister.GetLargeFiles(path);

            foreach (var item in filesList)
            {
                Console.WriteLine($"{item.Key}, {item.Value.Bytes()}");
            }
        }
    }
}
