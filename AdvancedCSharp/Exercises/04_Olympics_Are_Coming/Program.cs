using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04_Olympics_Are_Coming
{



    internal class Country
    {
        public string Name;
        public List<string> Participants;
        public int Wins;

        public Country()
        {
            Name = String.Empty;
            Participants = new List<string>();
            Wins = 0;
        }
    }

    internal class Program
    {

        private static void Main()
        {
            string input = Regex.Replace(Console.ReadLine(), @"\s+", " ");
            Dictionary<string, Country> list = new Dictionary<string, Country>();

            while (input.ToLower() != "report")
            {
                string[] arg = input.Split('|');
                string name = arg[0].Trim();
                string country = arg[1].Trim();

                if (!list.ContainsKey(country))
                {
                    list.Add(country, new Country());
                    list[country].Name = country;
                    list[country].Participants.Add(name);
                    list[country].Wins = 1;

                }
                else
                {
                    if (!list[country].Participants.Contains(name))
                    {
                        list[country].Participants.Add(name);
                        list[country].Wins++;
                    }
                    else
                    {
                        list[country].Wins++;
                    }
                }


                input = Regex.Replace(Console.ReadLine(), @"\s+", " ");
            }
            var order = from c in list
                orderby c.Value.Wins descending
                select c;
            foreach (var c in order)
            {
                Console.WriteLine("{0} ({1} participants): {2} wins", c.Key, c.Value.Participants.Count, c.Value.Wins);
            }

        }
    }
}

