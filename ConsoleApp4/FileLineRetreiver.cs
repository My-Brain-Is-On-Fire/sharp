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
        string FilePath { get; set; }
        int LineNumber { get; set; }
        public IEnumerable<string> Lines { get; private set; }

        public FileLineRetreiver(string filePath)
        {
            if (!File.Exists(filePath))
            {
                Console.WriteLine($"File {filePath} cannot be found!");
                Console.ReadKey();
                Environment.Exit(0);
            }
            else
            {
                FilePath = filePath;
                Lines = File.ReadLines(FilePath);
            }
        }

        public string LineOutput(int lineNumber)
        {
            return Lines.ElementAt(lineNumber - 1).ToString();
        }

        public void LineInsert(string text, int lineNumber)
        {
            var LineList = Lines.ToList();
            LineList[lineNumber] = text;
            File.WriteAllLines(FilePath, LineList);
        }
    }
}
