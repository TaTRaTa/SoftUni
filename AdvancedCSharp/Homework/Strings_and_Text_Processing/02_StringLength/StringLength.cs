using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class StrLenght
{
    static void Main()
    {
        string text = Console.ReadLine();
        StringBuilder sb;
        if (text.Length > 20)
        {
            sb = new StringBuilder(text.Substring(0, 20));
        }
        else
        {
            sb = new StringBuilder(text);
            while (sb.Length < 20)
            {
                sb.Append('*');
            }
        }
        Console.WriteLine(sb.ToString());
    }
}

