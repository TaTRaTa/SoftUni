using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;

class SeriesOfLetters
{
    static void Main(string[] args)
    {

        string input = Console.ReadLine();
        Regex regex = new Regex(@"(.)\1+");
        input = regex.Replace(input, "$1");
        Console.WriteLine(input);
        
    }
}