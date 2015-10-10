using System;

class calculateNandKfactoriel
{
    static void Main()
    {
        Console.WriteLine("Enter two integers n and k in the range (1 < k < n < 100):");
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("k = ");
        int k = int.Parse(Console.ReadLine());
        int factorielN = 1;
        int factorielK = 1;
        if (1 < k && k < n && n < 100)
        {
            for (int i = 1; i <= n; i++)
            {
                factorielN *= i;
                if (i <= k)
                {
                    factorielK *= i;
                }
            }
            Console.WriteLine("N!/K! = {0}",factorielN/factorielK);
        }
        else
        {
            Console.WriteLine("invalid input");
        }

    }
}
