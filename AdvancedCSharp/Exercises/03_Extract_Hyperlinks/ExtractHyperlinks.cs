using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


class ExtractHyperlinks
{
    static void Main()
    {
        string input = Console.ReadLine();
        StringBuilder sb = new StringBuilder();
        while (input.ToUpper() != "END")
        {
            sb.Append(input);
            input = Console.ReadLine();
        }
        string text = sb.ToString();

        // logic           
        string pattern = @"(?<=<a\s+(?:[^>]+\s+)?href\s*=\s*)(?:""([^""]*)""|'([^']*)'|([^\s>]+))(?=[^>]*>)";
                       //@"<a\s+(?:[^>]+\s+)?href\s*=\s*(?:'([^']*)'|""([^""]*)""|([^\s>]+))[^>]*>";
        Regex regex = new Regex(pattern);
        MatchCollection matches = regex.Matches(text);

        // print
        foreach (Match hyperlink in matches)
        {
            for (int i = 1; i <= 3; i++)
            {
                if (hyperlink.Groups[i].Length > 0)
                {
                    Console.WriteLine(hyperlink.Groups[i]);
                }
            }
        }

        //string input = Console.ReadLine();
        //string pattern = @"<a.*?(?<!"">)href\s*?=\s*?([""'])?(\S.*?)(?:>|class|\1)";
        //while (input.Substring(input.Length - 3) != "END")
        //{
        //    input += Console.ReadLine();
        //}
        //input = input.Remove(input.Length - 3);
        //Regex regex = new Regex(pattern);
        //MatchCollection matches = regex.Matches(input);
        //string fix;
        //foreach (Match item in matches)
        //{
        //    fix = item.Groups[2].ToString();
        //    fix = Regex.Replace(fix, @"\s{2,}", " ");
        //    Console.WriteLine(fix);
        //}
    }
}

