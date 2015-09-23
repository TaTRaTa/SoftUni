using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class NightLife
{
    static void Main()
    {
        Dictionary<string, SortedDictionary<string, SortedSet<string>>> book = new Dictionary<string, SortedDictionary<string, SortedSet<string>>>();

        string[] input = Console.ReadLine().Split(';').ToArray();

        while (!(input[0].ToUpper() == "END"))
        {
            if (!(book.ContainsKey(input[0])))
                {
                    SortedDictionary<string, SortedSet<string>> city = new SortedDictionary<string, SortedSet<string>>();
                    book[input[0]] = city;
                }
            if (!(book[input[0]].ContainsKey(input[1])))
                {
                    SortedSet<string> venue = new SortedSet<string>();
                    book[input[0]][input[1]] = venue;
                }
            book[input[0]][input[1]].Add(input[2]);
            input = Console.ReadLine().Split(';').ToArray();
        }
        // print result
        foreach (string city in book.Keys)
        {
            Console.WriteLine(city);
            SortedDictionary<string, SortedSet<string>> venues = book[city];
            foreach (string venue in venues.Keys)
                {
                    SortedSet<string> performers = venues[venue];
                    string performersStr = string.Join(", ", performers);
                    Console.WriteLine("->{0}: {1}", venue, performersStr);
                }
        }
    }
}

