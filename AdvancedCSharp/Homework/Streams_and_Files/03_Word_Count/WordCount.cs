using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

using System.Text.RegularExpressions;



class WordCount
{
  public static SortedDictionary<string, int> list = new SortedDictionary<string, int>();
  public static string wordsTxt = "words.txt";
  public static string textTxt = "text.txt";
  public static string resultTxt = "result.txt";

    static void Main()
    {       
        using (StreamReader readerWord = new StreamReader(wordsTxt))
        {           
            string word = readerWord.ReadLine();
            while (word != null)
            {
                string patern = string.Format(@"[-| ]({0})[ |,|.|?|!]", word.ToUpper()); // regex only for this task
                AddToList(patern, word);                                               // check with regex and add to list

                word = readerWord.ReadLine();
            }
        }
        PrintResult();                                                                  //  sorted by Descending and print
    }


    static void AddToList(string pattern, string word)
    {        
        using (StreamReader readerText = new StreamReader(textTxt))
        {
            Regex regex = new Regex(pattern);
            int count = 0;

            string textLine = readerText.ReadLine();
            while (textLine != null)
            {
                MatchCollection matches = regex.Matches(textLine.ToUpper());
                count += matches.Count;
                textLine = readerText.ReadLine();
            }
            list.Add(word, count);
        }
    }

    static void PrintResult()
    {
        using (StreamWriter writer = new StreamWriter(resultTxt))
        {
            var newOrderedList = list
                                .OrderByDescending(x => x.Value)
                                .Select(x => new { Value = x.Value, Key = x.Key });

            foreach (var i in newOrderedList)
            {
                writer.WriteLine("{1} - {0}", i.Value, i.Key);
                //Console.WriteLine("{1} - {0}", i.Value, i.Key);
            }
        }
    }

}

