using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _04.OlympicsAreComing
{
    class OlympicsAreComing
    {
        static void Main()
        {
            Dictionary<string, Dictionary<string, int>> dic = new Dictionary<string, Dictionary<string, int>>();
            var orderByWins = new Dictionary<string, int>();
            string input = Regex.Replace(Console.ReadLine(), @"\s+", " ");

            while (input != "report")
            {
                string[] data = input.Split('|');
                string athlete = data[0].Trim();
                string country = data[1].Trim();

                if (!dic.ContainsKey(country))
                {
                    dic.Add(country, new Dictionary<string, int>());
                }

                if (!dic[country].ContainsKey(athlete))
                {
                    dic[country].Add(athlete, 0);
                }

                dic[country][athlete] += 1;
                input = Regex.Replace(Console.ReadLine(), @"\s+", " ");
            }

            foreach (KeyValuePair<string, Dictionary<string, int>> keyValuePair in dic)
            {
                var wins = keyValuePair.Value.Sum(s => s.Value);
                orderByWins.Add(keyValuePair.Key, wins);
            }

            foreach (KeyValuePair<string, int> keyValuePair in orderByWins.OrderByDescending(o => o.Value))
            {
                Console.WriteLine("{0} ({1} participants): {2} wins", keyValuePair.Key, dic[keyValuePair.Key].Keys.Count,
                    keyValuePair.Value);
            }
        }
    }
}
