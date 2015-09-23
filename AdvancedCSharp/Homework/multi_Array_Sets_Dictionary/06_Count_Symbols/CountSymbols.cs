using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class CountSymbols
{
    static void Main()
    {
        char[] input = Console.ReadLine().ToCharArray();

        Dictionary<char, int> counter = new Dictionary<char, int>();
        foreach (char symbol in input)
        {
            if (counter.ContainsKey(symbol))
            {
                counter[symbol]++;
            }
            else
            {
                counter.Add(symbol, 1);
            }
        }
        char[] orderedKeys = counter.Keys.OrderBy(p => p).ToArray();
        foreach (char key in orderedKeys)
        {
            Console.WriteLine("{0}: {1} time(s)", key, counter[key]);
        }

    }
}

