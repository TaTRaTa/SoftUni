using System;

class ExtractBitfromInteger
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());
        int mask = 1 << (p - 1);
        int bite = (n & mask) >> (p - 1);
        Console.WriteLine( bite );

    }
}