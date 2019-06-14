using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    public class AbbrevNameKata
    {
        public static string AbbrevName(string name)
        {
            var nameBuilder = new StringBuilder();
            nameBuilder.Append(name);
            nameBuilder.Replace(" ", ".");

            foreach (char c in name)
            {
                if (Char.IsUpper(c))
                {
                    nameBuilder.Append(c);
                }
            }
            nameBuilder.Remove(nameBuilder.Length - 1,1);
            return nameBuilder.ToString();
        }
    }
}
