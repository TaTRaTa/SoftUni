using System;

class House
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("{0}{1}{0}",new string('.',(n - 1) / 2),'*');
            for (int i = 1; i <= ((n - 1) / 2) - 1; i++)
            { 
                 Console.WriteLine("{0}{1}{2}{1}{0}",new string('.', (n / 2) - i),'*',new string('.', (2 * i) - 1));
            }
        Console.WriteLine("{0}", new string('*', n));
          
            for (int j = n / 2 + 1; j < n - 1; j++)
            {
                 Console.WriteLine("{0}{1}{2}{1}{0}", new string('.',n / 4),'*',new string('.', n - 2 * n / 4 - 2 ));
            }

        Console.WriteLine("{0}{1}{0}", new string('.', n / 4), new string('*', n - 2 * n / 4));
        
    }
}//(n - 5) / 2) or n / 4 orr n - 2 * n / 4 - 2 ///  (int j = 1; j <= ((n - 1) / 2) - 1; j++)