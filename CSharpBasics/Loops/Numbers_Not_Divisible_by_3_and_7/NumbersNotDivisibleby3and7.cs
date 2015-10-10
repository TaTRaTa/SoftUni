using System;

class NumbersNotDivisibleby3and7
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            if (i % 3 == 0)
            {
                continue;
            }
            else if (i % 7 == 0)
            {
                continue;
            }
            Console.Write("{0} ", i);
        }
        Console.WriteLine();
    }
}