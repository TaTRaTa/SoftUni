using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class ReverseString
{
    static void Main()
    {
        string input = Console.ReadLine().Trim();
        char[] ch = new char[input.Length];

        for (int i = 0; i < input.Length; i++)
        {
            ch[i] = input[i];
        }
        Array.Reverse(ch);
        Console.WriteLine(string.Join("",ch));

    }
}

