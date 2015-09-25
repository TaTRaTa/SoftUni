using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


class SentenceExtractor
{
    static void Main()
    {
        string word = Console.ReadLine();
        string text = Console.ReadLine();

        string pattern = String.Format(@"([^!.?]*\b{0}\b[^!.?]*[!.?])", word);
        Regex regex = new Regex(pattern);
        MatchCollection matches = regex.Matches(text);
        foreach (Match match in matches)
        {
            Console.WriteLine(match);
        }
    }
}

