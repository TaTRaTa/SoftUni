using System;

class magicWand
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("{0}*{0}",new string('.', ((n * 3) + 2)/2));
        for (int i = 1; i <= (n + 1) / 2; i++)
        {
            Console.WriteLine("{0}*{1}*{0}",new string('.',(((n * 3) + 2)/2) - i), new string('.', (2*i) - 1));
        }
        Console.WriteLine("{0}{1}{0}", new string('*', n),new string('.',n +2));
        for (int i = 1; i <= n / 2; i++)
        {
            Console.WriteLine("{0}*{1}*{0}", new string('.', i), new string('.', (n * 3) - (i * 2)));
        }
        Console.WriteLine("{0}*{1}**{2}**{1}*{0}", new string('.',(((((n * 3)- 4) - n) - (2 * (n / 2))) /2)),new string('.', n / 2), new string('.', n));
        for (int i = 1; i <= n / 2 - 1; i++)
        {
            //if (i == n / 2 - 1)
            //{
            //    Console.WriteLine("*{0}*{1}*{2}*{1}*{0}*", new string('.', n / 2), new string('.', i), new string('.', n));
            //    break;
            //}
            Console.WriteLine("{0}*{1}*{2}*{3}*{2}*{1}*{0}", new string('.', ((((((n * 3) - 4) - n) - (2 * i)) - (2 * (n / 2))) / 2)), 
                                                             new string('.',n / 2), 
                                                             new string('.', i), 
                                                             new string('.', n ));
        }
        Console.WriteLine("{0}{1}*{2}*{1}{0}", new string('*', (int)Math.Ceiling((double)n / 2)), new string('.', n / 2), new string('.', n));
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("{0}*{0}*{0}", new string('.', n));
        }
        Console.WriteLine("{0}*{1}*{0}", new string('.', n), new string('*', n));

    }
}