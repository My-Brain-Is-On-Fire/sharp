using System;
using System.Text;

namespace CodeWars
{

    public class Kata
{
        public static string AlphabetPosition(string text)
        {
            text.Replace(" ", String.Empty);
            char[] charString = text.ToCharArray();
            StringBuilder endString = new StringBuilder();

            foreach (char c in text)
            {
                if (!Char.IsLetter(c)) { continue; }
                endString.Append(char.ToUpper(c) - 64);
                endString.Append(" ");
                Console.WriteLine(endString);
            }


            //charString = charString.Replace(c => c.Replace(char.ToUpper(c) - 64));
            return endString.ToString().Trim();
        }
    }
}