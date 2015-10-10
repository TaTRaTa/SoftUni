using System;
using System.Text;

class ASCII_Table
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.GetEncoding(1252);
        Console.WriteLine("ASCII Table: ");
        
        for (int i = 0; i <= 255; i++)
        {
            Console.WriteLine("{0}--->{1}",i,(char)i);
        }

    }
}