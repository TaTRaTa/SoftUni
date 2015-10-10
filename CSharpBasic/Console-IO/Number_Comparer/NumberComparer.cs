using System;

class NumberComparer
{
    static void Main()
    {
        decimal a = decimal.Parse(Console.ReadLine());
        decimal b = decimal.Parse(Console.ReadLine());
        decimal c = Math.Max(a, b);
        
        Console.WriteLine(c);
    }
}