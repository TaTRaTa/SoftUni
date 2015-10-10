using System;

class sunlight
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        
        Console.WriteLine("{0}*{0}",new string('.', (3 * n) / 2));
        for (int i = 1; i < n; i++)
        {
            Console.WriteLine("{0}*{1}*{1}*{0}", new string('.', i), new string('.', (((n * 3) - (i * 2)) / 2) - 1));
        }
        
        for (int i = 0; i < ((((n * 3)- 3) - 2*(n-1)) / 2); i++)
        {
            Console.WriteLine("{0}{1}{0}", new string('.', n), new string('*', n));
        }
        Console.WriteLine("{0}{0}{0}", new string('*',n));
        for (int i = 0; i < ((((n * 3) - 3) - 2 * (n - 1)) / 2); i++)
        {
            Console.WriteLine("{0}{1}{0}", new string('.', n), new string('*', n));
        }
        
        for (int i = n - 1; i > 0; i--)
        {
            Console.WriteLine("{0}*{1}*{1}*{0}", new string('.', i),new string('.', ((((n * 3) - (i * 2)) - 3) / 2)));
        }
        
        Console.WriteLine("{0}*{0}", new string('.', (3 * n) / 2));
        
        
    }
}