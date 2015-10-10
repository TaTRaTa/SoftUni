using System;

class Dumbbell
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("{0}{1}{2}{1}{0}", new string('.',n / 2), new string('&',(int)Math.Ceiling((decimal)n / 2)), new string('.', n)    );
        for (int i = 0; i < (n - 3) / 2 ; i++)
        {
           int dot = n / 2 - 1 - i;
            int astar = n / 2 + i;
            Console.WriteLine("{0}&{1}&{2}&{1}&{0}",new string('.', dot), new string('*',astar), new string('.', n) );
            

        }
        Console.WriteLine("&{0}&{1}&{0}&", new string('*', ((((n * 3)- n) - 4) / 2)), new string('=', n));
        for (int i = 1; i < (n - 3) / 2 + 1; i++)
        {
            Console.WriteLine("{0}&{1}&{2}&{1}&{0}", new string('.', i), new string('*', ((((n*3) - 4) - 2 * i) -n) / 2), new string('.', n));
        }
        Console.WriteLine("{0}{1}{2}{1}{0}", new string('.', n / 2), new string('&', (int)Math.Ceiling((decimal)n / 2)), new string('.', n));
    }
}