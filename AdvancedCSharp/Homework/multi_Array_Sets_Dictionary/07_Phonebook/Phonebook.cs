using System;
using System.Collections.Generic;



class Phonebook
{
    static void Main()
    {
        string inputLine = Console.ReadLine();

        Dictionary<string, string> Phonebooks = new Dictionary<string, string>();

        while (!(inputLine == "search"))
        {
            string[] items = inputLine.Split('-');
            if (Phonebooks.ContainsKey(items[0]))
            {
                Phonebooks.Remove(items[0]);
            }
            Phonebooks.Add(items[0].Trim(), items[1].Trim());

            inputLine = Console.ReadLine();
        }

        inputLine = Console.ReadLine().Trim();
        while (inputLine.Length > 0)
        {
            if (Phonebooks.ContainsKey(inputLine))
            {
                Console.WriteLine("{0} -> {1}", inputLine, Phonebooks[inputLine]);
            }
            else
            {
                Console.WriteLine("Contact {0} does not exist.", inputLine);
            }
            inputLine = Console.ReadLine();
        }
    }
}

