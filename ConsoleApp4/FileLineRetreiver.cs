using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CodeWars
{
    public class FileLineRetreiver
    {
        public string FilePath { get; private set; }
        public int LineNumber { get; private set; }

        public FileLineRetreiver(string filePath)
        {
            FilePath = filePath;
        }

        public string LineOutput(int lineNumber)
        {
            return File.ReadLines(FilePath).ElementAt(lineNumber - 1).ToString();
        }

        // rest is in FileLineInputter.cs

    }
}
