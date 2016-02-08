namespace _04.PopulationCounter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class PopulationCounter
    {
        static void Main()
        {
            string input = Console.ReadLine();
            Dictionary<string, Dictionary<string, long>> data = new Dictionary<string, Dictionary<string, long>>();
            Dictionary<string, long> countPopulation = new Dictionary<string, long>();

            while (input != "report")
            {
                string[] command = input.Split('|');

                AddCountryCityPopulation(command, data, countPopulation);

                input = Console.ReadLine();
            }

            Print(countPopulation, data);
        }

        /// <summary>
        /// Print result from both dictionaries to console application
        /// </summary>
        /// <param name="countPopulation">The Dictionary --> country with collected population</param>
        /// <param name="data">The Dictionary --> country, city, population </param>
        private static void Print(Dictionary<string, long> countPopulation, Dictionary<string, Dictionary<string, long>> data)
        {
            var sortCountryByPopulation = countPopulation.OrderByDescending(v => v.Value);
            foreach (KeyValuePair<string, long> pair in sortCountryByPopulation)
            {
                Console.WriteLine("{0} (total population: {1})", pair.Key, pair.Value);
                var sdata = data[pair.Key].OrderByDescending(v => v.Value);
                foreach (KeyValuePair<string, long> keyValuePair in sdata)
                {
                    Console.WriteLine("=>{0}: {1}", keyValuePair.Key, keyValuePair.Value);
                }
            }
        }

        /// <summary>
        /// Add specified key and value to both dictionaries
        /// </summary>
        /// <param name="command">string array</param>
        /// <param name="data"></param>
        /// <param name="countPopulation"></param>
        private static void AddCountryCityPopulation(string[] command, Dictionary<string, Dictionary<string, long>> data, Dictionary<string, long> countPopulation)
        {
            string city = command[0];
            string country = command[1];
            int population = int.Parse(command[2]);

            if (!data.ContainsKey(country))
            {
                data.Add(country, new Dictionary<string, long>());
            }
            if (!data[country].ContainsKey(city))
            {
                data[country].Add(city, population);
            }

            if (!countPopulation.ContainsKey(country))
            {
                countPopulation.Add(country, 0);
            }

            countPopulation[country] += population;
        }
    }
}
