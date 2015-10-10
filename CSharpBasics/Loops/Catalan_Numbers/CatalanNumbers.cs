using System;
using System.Numerics;

class CatalanNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        BigInteger factorielN = 1;
        BigInteger factorielNN = 1;
        BigInteger factorielNplusOne = 1;
        if (1 < n && n < 100)
        {
            for (int i = 1; i <= n * 2; i++)
            {
                factorielNN *= i;
                if (i <= n)
                {
                    factorielN *= i;
                }
                if (i <= n + 1)
                {
                    factorielNplusOne *= i;
                }   
            }

            Console.WriteLine("{0}",factorielNN / (factorielNplusOne * factorielN));
        }
        else if (n == 0)
        {
            Console.WriteLine(1);
        }
        else
        {
            Console.WriteLine("Invalid input");
        }
    }
}