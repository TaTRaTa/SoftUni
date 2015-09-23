using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Palindromes
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(new char[] {' ', ',', '!', '?', '.' }, StringSplitOptions.RemoveEmptyEntries );
        foreach (var word in input)
        {
            if (IsPalindromes(word))
            {
                if (input[input.Length - 1] == word)
                {
                    Console.WriteLine(word);
                }
                else
                {
                    Console.Write(word + ", ");
                }
                
            }
        }
        Console.WriteLine();


    }

    static bool IsPalindromes(string word)
    {
        int min = 0;
        int max = word.Length - 1;
        while (true)
        {
            if (min > max)
            {
                return true;
            }
            char a = word[min];
            char b = word[max];
            if (char.ToLower(a) != char.ToLower(b))
            {
                return false;
            }
            min++;
            max--;
        }



    }
}

