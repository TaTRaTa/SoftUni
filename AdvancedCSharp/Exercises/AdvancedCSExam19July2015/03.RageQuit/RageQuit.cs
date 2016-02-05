namespace _03.RageQuit
{
    using System;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;

    class RageQuit
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string pat = @"(.+?)(\d+)";
            StringBuilder appndMatch = new StringBuilder();
            Regex regex = new Regex(pat);
            MatchCollection matches = regex.Matches(input.ToUpper());

            foreach (Match match in matches)
            {
                int len = int.Parse(match.Groups[2].Value);
                for (int i = 0; i < len; i++)
                {
                    appndMatch.Append(match.Groups[1].Value);
                }
            }

            int count = appndMatch.ToString().Distinct().Count();
            Console.WriteLine("Unique symbols used: {0}", count);
            Console.WriteLine(appndMatch.ToString());        
        }
    }
}
