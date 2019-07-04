using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CodeWars
{
    public class ArrayDuplicatesStream
    {
        
        public void GetSeenDuplicates(MemoryStream stream)
        {
            StreamReader reader = new StreamReader(stream);
            string text = reader.ReadToEnd();
        }
    }
}
