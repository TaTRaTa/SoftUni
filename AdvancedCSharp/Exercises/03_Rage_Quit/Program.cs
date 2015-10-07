using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        Regex regex = new Regex(@"(\D+)(\d+)");
        MatchCollection matches = regex.Matches(input.ToUpper());

        StringBuilder sb = new StringBuilder();
        foreach (Match match in matches)
        {
            for (int i = 0; i < int.Parse(match.Groups[2].Value); i++)
            {
                sb.Append(match.Groups[1].Value);
            }
                       
        }
        int count = sb.ToString().Distinct().Count();
        Console.WriteLine("Unique symbols used: {0}",count);
        Console.WriteLine(sb.ToString());
    }
}

