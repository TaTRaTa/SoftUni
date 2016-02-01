using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _02.ShmoogleCounter
{
    class ShmoogleCounter
    {
        static void Main()
        {
            StringBuilder sb = new StringBuilder();

            string input = Console.ReadLine();
            while (input != "//END_OF_CODE")
            {
                sb.AppendLine(input);

                input = Console.ReadLine();
            }

            string pattern = @"((double|int)\s+([a-z][a-zA-Z]*).*?\;*)";
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(sb.ToString());

            List<string> listInt = new List<string>();
            List<string> listDouble = new List<string>();

            foreach (Match match in matches)
            {
                string key = match.Groups[2].Value;
                string value = match.Groups[3].Value;
                if (key == "int")
                {
                    listInt.Add(value);
                }
                else if (key == "double")
                {
                    listDouble.Add(value);
                }
                else
                {
                    throw new ArgumentException("Cannot be find the seek Match");
                }
                
            }
            listInt.Sort();
            listDouble.Sort();

            if (listDouble.Count == 0)
            {
                Console.WriteLine("Doubles: None");
            }
            else
            {
                Console.WriteLine("Doubles: {0}", string.Join(", ", listDouble));
            }

            if (listInt.Count == 0)
            {
                Console.WriteLine("Ints: None");
            }
            else
            {
                Console.WriteLine("Ints: {0}", string.Join(", ", listInt));
            }
            
        }
    }
}
