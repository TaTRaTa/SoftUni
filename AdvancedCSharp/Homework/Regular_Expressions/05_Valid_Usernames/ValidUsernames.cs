using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


class ValidUsernames
{
    static void Main()
    {
        string text = Console.ReadLine();
        string pattern = @"\b[a-zA-Z]\w{2,24}\b";
        Regex regex = new Regex(pattern);
        MatchCollection matches = regex.Matches(text);
        int sum = 0;
        int maxValue = int.MinValue;
        int first = 0; int second = 0;

        for (int i = 0; i < matches.Count - 1; i++)
        {
            sum = matches[i].Length + matches[i + 1].Length;
            if (sum > maxValue)
            {
                maxValue = sum;
                first = i;
                second = i + 1;
            }
        }
        Console.WriteLine(matches[first]);
        Console.WriteLine(matches[second]);

    }
}

