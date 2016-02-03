using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.SrybskoUnleashed
{
    class SrybskoUnleashed
    {
        static void Main()
        {
            string pattern = @"(.+?) @([A-Z].*) (\d+) (\d+)";
            Regex regex = new Regex(pattern);
            Dictionary<string, Dictionary<string, double>> dictionary = new Dictionary<string, Dictionary<string, double>>();
            string input = Console.ReadLine();

            while (input != "End")
            {
                Match match = regex.Match(input);
                if (match.Success)
                {
                    string singer = match.Groups[1].Value;
                    string venue = match.Groups[2].Value;
                    double sum = int.Parse(match.Groups[3].Value) * int.Parse(match.Groups[4].Value);

                    if (!dictionary.ContainsKey(venue))
                    {
                        dictionary.Add(venue, new Dictionary<string, double>());
                    }

                    if (!dictionary[venue].ContainsKey(singer))
                    {
                        dictionary[venue].Add(singer, 0.0);
                    }

                    dictionary[venue][singer] += sum;
                }

                input = Console.ReadLine();
            }

            foreach (KeyValuePair<string, Dictionary<string, double>> keyValuePair in dictionary)
            {
                Console.WriteLine(keyValuePair.Key);
                foreach (KeyValuePair<string, double> valuePair in keyValuePair.Value.OrderByDescending(c => c.Value))
                {
                    Console.WriteLine("#  {0} -> {1}", valuePair.Key, valuePair.Value);
                }
            }
        }
    }
}
