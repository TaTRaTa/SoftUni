using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;


class ReverseNumber
{
    static void Main()
    {
        double number = 123.45;

        double reversed = GetReverseNumber(number);

        Console.WriteLine(reversed);
    }

    private static double GetReverseNumber(double number)
    {
        bool isNegative = number >= 0 ? false : true;
        number = Math.Abs(number);
        string strNumber = number.ToString();
        char[] chs = strNumber.ToCharArray();
        Array.Reverse(chs);
        string newStr = new string(chs);
        number = double.Parse(newStr);
        return isNegative ? -number : number;

    }
}

