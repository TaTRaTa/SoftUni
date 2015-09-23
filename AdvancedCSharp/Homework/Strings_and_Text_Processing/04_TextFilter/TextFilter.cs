using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class TextFilter
{
    static void Main()
    {
        string text = Console.ReadLine();
        string[] bans = Console.ReadLine().Split(',').Select(p => p.Trim()).ToArray();
        StringBuilder sb = new StringBuilder(text);
        foreach (var item in bans)
        {
            string censor = new string('*', item.Length);
            sb.Replace(item, censor);
        }
        Console.WriteLine(sb);
    }
}

