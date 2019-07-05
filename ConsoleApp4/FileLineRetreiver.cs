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
        string FilePath;
        IEnumerable<string> Lines { get; set; }

        public FileLineRetreiver(string filePath)
        {
            if (!File.Exists(filePath))
            {
                throw new IOException($"File does not exist: {filePath}");
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
            LineList.Insert(lineNumber, text);
            File.WriteAllLines(FilePath, LineList);
        }
    }
}
