using System;

class arrow
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int temp = (n + 2 * (n / 2)) - 4;
        Console.WriteLine("{0}{1}{0}", new string('.',n / 2),new string('#',n));
        for (int i = 0; i < n - 2; i++)
        {
            Console.WriteLine("{0}#{1}#{0}", new string('.', n / 2), new string('.', n - 2));
        }
        Console.WriteLine("{0}{1}{0}", new string('#',(int)Math.Ceiling((double)n / 2)), new string('.', n - 2));
        for (int i = 0; i < n - 2; i++)
        {
            Console.WriteLine("{0}#{1}#{0}",new string('.',i + 1), new string('.', temp - (2 * i) ));
        }
        Console.WriteLine("{0}#{0}", new string('.', n - 1));
    }
}