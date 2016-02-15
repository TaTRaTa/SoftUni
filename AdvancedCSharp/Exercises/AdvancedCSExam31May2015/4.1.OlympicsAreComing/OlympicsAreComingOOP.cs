using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _4._1.OlympicsAreComing
{
    class Country
    {
        public string Name;
        public List<string> Participants;
        public int Wins;
        public Country()
        {
            this.Name = string.Empty;
            this.Participants = new List<string>();
            this.Wins = 0;
        }
    }
    class OlympicsAreComingOOP
    {
        static void Main(string[] args)
        {
            var dic = new Dictionary<string, Country>();
            string input = Regex.Replace(Console.ReadLine(), @"\s+", " ");

            while (input != "report")
            {
                string[] data = input.Split('|');
                string athlete = data[0].Trim();
                string country = data[1].Trim();

                if (!dic.ContainsKey(country))
                {
                    dic.Add(country, new Country());
                }

                if (!dic[country].Participants.Contains(athlete))
                {
                    dic[country].Participants.Add(athlete);
                }

                dic[country].Wins++;

                input = Regex.Replace(Console.ReadLine(), @"\s+", " ");
            }

            var order = dic.OrderByDescending(o => o.Value.Wins);

            foreach (KeyValuePair<string, Country> keyValuePair in order)
            {
                Console.WriteLine("{0} ({1} participants): {2} wins", keyValuePair.Key, keyValuePair.Value.Participants.Count,
                    keyValuePair.Value.Wins);
            }
        }
    }
}
