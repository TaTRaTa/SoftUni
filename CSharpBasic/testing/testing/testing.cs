using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testing
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}{1}{0}", new string('.', (n - 1) / 2), '*');
            for (int i = 1; i <= ((n - 1) / 2) - 1; i++)
            {
                Console.WriteLine("{0}{1}{2}{1}{0}", new string('.', ((n - 1) / 2) - i), '*', new string('.', (2 * i) - 1));
            }
            Console.WriteLine("{0}", new string('*', n));
            if (n == 5)
            {
                Console.WriteLine("{0}{1}{0}{1}{0}", '.', '*');
                Console.WriteLine("{0}{1}{0}", '.', new string('*', 3));
            }
            else
            {
                for (int j = 1; j <= ((n - 1) / 2) - 1; j++)
                {
                    Console.WriteLine("{0}{1}{2}{1}{0}", new string('.', (n - 5) / 2), '*', new string('.', 3));
                }

                Console.WriteLine("{0}{1}{0}", new string('.', (n - 5) / 2), new string('*', 5));
            }
        }
    }
}
