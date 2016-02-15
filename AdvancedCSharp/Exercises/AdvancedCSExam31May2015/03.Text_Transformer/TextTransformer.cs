using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Text_Transformer
{
    class TextTransformer
    {
        static void Main()
        {
            string input = Console.ReadLine();
            StringBuilder fullText = new StringBuilder();
            int temp;
            StringBuilder newText = new StringBuilder();

            while (input != "burp")
            {
                fullText.Append(input);
                input = Console.ReadLine();
            }

            fullText = new StringBuilder(Regex.Replace(fullText.ToString(), @"\s+", " "));
            string pattern = @"(\$|\%|\&|\')([^$%&\']+)\1";
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(fullText.ToString());
            int weight = 0;
            foreach (Match match in matches)
            {
                switch (match.Groups[1].Value)
                {
                    case "$":
                        weight = 1;
                        break;
                    case "%":
                        weight = 2;
                        break;
                    case "&":
                        weight = 3;
                        break;
                    case "\'":
                        weight = 4;
                        break;
                }

                string captured = match.Groups[2].Value;
                

                for (int i = 0; i < captured.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        temp = captured[i] + weight;
                        newText.Append((char)temp);
                    }
                    else
                    {
                        temp = captured[i] - weight;
                        newText.Append((char)temp);
                    }
                }

                newText.Append(" ");
            }
            Console.WriteLine(newText);
        }
    }
}
