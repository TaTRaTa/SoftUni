using System;

class BiteWise
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int p = 3;
        int mask = 1 << p;
        int bit = (n & mask) >> p;
        Console.WriteLine( bit );
    }
}