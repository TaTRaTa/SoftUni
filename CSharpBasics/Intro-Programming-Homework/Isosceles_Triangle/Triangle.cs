using System;
using System.Text;


class Triangle
{
    
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        // MANDANTORY to use ---> using System.text; <--- for Console.OutputEncoding = Encoding.UTF8;
        char copyright = (char)169;
        // or ---> char copyright = '\u00A9'; <---
        Console.WriteLine(" " + " " + " " + copyright);
        Console.WriteLine(" " + " " + copyright + " " + copyright);
        Console.WriteLine(" " + copyright + " " + " " + " " + copyright);
        Console.WriteLine(copyright + " " + copyright + " " + copyright + " " + copyright);
    }

   
}