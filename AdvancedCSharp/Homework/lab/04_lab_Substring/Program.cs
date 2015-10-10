﻿namespace Debugging_Substring
{
    using System;

    public class Substring_broken
    {
        public static void Main()
        {
            string text = Console.ReadLine();
            int jump = int.Parse(Console.ReadLine());

            const char Search = 'p';
            bool hasMatch = false;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == Search)
                {
                    hasMatch = true;
                    string matchedString;
                    int endIndex = jump + 1 ;

                    if ((endIndex + i) > text.Length)
                    {
                        //endIndex = text.Length;
                         matchedString = text.Substring(i);

                    }
                    else
                    {
                         matchedString = text.Substring(i, endIndex);
                        
                    }

                    Console.WriteLine(matchedString);
                    i += jump;
                }
            }

            if (!hasMatch)
            {
                Console.WriteLine("no");
            }
        }
    }
}