using System;

class Headphones
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("{0}*{1}*{0}" ,new string('-', n/2),new string('*', n));
        for (int i = 1; i < n; i++)
        {
            Console.WriteLine("{0}*{1}*{0}" ,new string('-', n/2),new string('-', n));
        }
        for (int i = 1; i <= n / 2; i++)
        {
            int temp = (int)Math.Ceiling((double)n / 2) - i;
            int temp2 = (n + 1) - ((2*i)-1);
            Console.WriteLine("{0}{1}{2}{1}{0}",new string('-', temp), 
                                                new string('*', (2 * i) - 1),
                                                new string('-',temp2));
          
        }
        Console.WriteLine("{0}-{0}", new string('*', n));
        for (int i = 1; i <= n / 2; i++)
        {
            int temp = (((2 * n + 1) - (2 * i)) - ((2 * i) + 1)) / 2;
            Console.WriteLine("{0}{1}{2}{1}{0}", new string('-', i), 
                                                 new string('*',temp),    
                                                 new string('-', 2 * i + 1));
        }

    }
}