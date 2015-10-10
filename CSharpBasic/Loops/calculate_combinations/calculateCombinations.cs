using System;
using System.Numerics;
class calculateCombinations
{
    static void Main()
    {
        Console.WriteLine("Enter two integers n and k in the range (1 < k < n < 100):");
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("k = ");
        int k = int.Parse(Console.ReadLine());
        BigInteger factorielN = 1;
        int factorielK = 1;
        BigInteger factorialNK = 1;
        int NK = Math.Abs(n - k);
       
        if (1 < k && k < n && n < 100)
        {
            for (int i = 1; i <= n; i++)
            {
                factorielN *= i;
                if (i <= k)
                {
                    factorielK *= i;
                } if (i <= NK)
                {
                    factorialNK *= i;
                }
            }
            // for (int j = 1; j <= NK; j++)
            //{
            //    factorialNK *= j;   
            //}
            
            Console.WriteLine("N! / (K! * (N-K)!) = {0}",factorielN / (factorielK * factorialNK));
        }
        else
        {
            Console.WriteLine("invalid input");
        }

    }
}