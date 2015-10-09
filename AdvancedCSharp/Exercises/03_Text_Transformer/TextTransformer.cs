using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


class TextTransformer
{
    static void Main()
    {
        string input = Console.ReadLine();
        StringBuilder sb = new StringBuilder();
        while (input.ToLower() != "burp")
        {
            sb.Append(input);
            input = Console.ReadLine();
        }
        Regex.Replace(sb.ToString(), @"\s+", " ");

        Regex regex = new Regex( @"(\$|%|&|\')([^$%&\']+)\1");
        MatchCollection matches = regex.Matches(sb.ToString());
        sb = new StringBuilder();
        foreach (Match match in matches)
        {
            char[] ch = new char[match.Groups[2].Value.Length];
            string str = match.Groups[2].Value;
            char[] element = match.Groups[1].ToString().ToCharArray();
            int digit = 0;
            switch (element[0])
            {
                case '$':
                    digit = 1;
                    break;
                case '%':
                    digit = 2;
                    break;
                case '&':
                    digit = 3;
                    break;
                case '\'':
                    digit = 4;
                    break; 
            }
            for (int i = 0; i < str.Length; i++)
            {
                if (i % 2 == 0)
                {
                    ch[i] = (char)(str[i] + digit);
                    sb.Append(ch[i]);
                }
                else
                {
                    ch[i] = (char)(str[i] - digit);
                    sb.Append(ch[i]);
                }
            }
            sb.Append(" ");
        }
        Console.WriteLine("{0}", string.Join("",sb));

    }
}

