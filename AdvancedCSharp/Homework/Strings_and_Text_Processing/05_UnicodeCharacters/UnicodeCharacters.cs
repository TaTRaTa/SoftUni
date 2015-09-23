using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class UnicodeCharacters
{
    static void Main()
    {
        string text = Console.ReadLine();
        foreach (char ch in text)
        {
            Console.Write(@"\{0:X5}", (int)ch);
        }
        Console.WriteLine();
    }
}

