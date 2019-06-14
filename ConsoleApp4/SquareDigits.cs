using System;

public class Kata
{
    public static int SquareDigits(int n)
    {
        n = Math.Abs(n);
        var stringN = n.ToString();
        var result = "";

        foreach (char digit in stringN)
        {
            int digitnumber = Convert.ToInt32(digit);
            result = result + Math.Pow(digitnumber, 2).ToString();
        }

        return Convert.ToInt32(result);
    }
}
