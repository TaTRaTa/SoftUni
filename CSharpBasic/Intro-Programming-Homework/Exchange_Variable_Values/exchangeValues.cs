using System;

class exchangeValues
{
    static void Main()
    {
        int a = 5;
        int b = 10;
        Console.WriteLine("{0}" + "\n" + "{1}", a, b);
        b -= a;
        a += b;
        Console.WriteLine("{0}" + "\n" + "{1}", a, b);
    }
}