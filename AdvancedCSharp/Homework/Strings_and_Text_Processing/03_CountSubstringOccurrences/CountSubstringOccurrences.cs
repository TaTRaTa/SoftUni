using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class CountSubstringOccurrences
{
    static void Main()
    {
        string text = Console.ReadLine();
        string search = Console.ReadLine();
        int count = 0;
        for (int i = 0; i < text.Length; i++)
        {
            if (text.IndexOf(search, i, StringComparison.OrdinalIgnoreCase) >= 0)
            {
                count++;
                i = text.IndexOf(search, i, StringComparison.OrdinalIgnoreCase);
            }
            else
            {
                break;
            }

        }

        Console.WriteLine(count);
    }
}

