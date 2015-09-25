using System;
using System.Text.RegularExpressions;


class ExtractEmails
{
    static void Main()
    {
        string input = Console.ReadLine();
        Regex regex = new Regex(@"(?<user>[a-zA-Z]+[-_.]*[a-zA-Z0-9]*)@(?<host>[a-zA-Z]+[-.]*[a-zA-Z]*\.[a-zA-Z]+)");
        MatchCollection matches = regex.Matches(input);

        foreach (Match match in matches)
        {
            Console.WriteLine(match);
        }
    }
}

