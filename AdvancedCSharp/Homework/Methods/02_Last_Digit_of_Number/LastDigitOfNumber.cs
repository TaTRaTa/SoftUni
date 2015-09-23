using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class LastDigitOfNumber
{
    private static void Main()
    {
        int numInts = int.Parse(Console.ReadLine());

        Console.WriteLine(GetLastDigitAsword(numInts));
    }

    static string GetLastDigitAsword(int numInts)
    {
        string[] digitWords = { "zero", "one", "two", "three", "four",
                                  "five","six","seven","eight","nine"};
        int remainder = numInts % 10;

        return digitWords[remainder];

    }
}

