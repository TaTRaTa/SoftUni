using System;

class calculeteNandX2
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int x = int.Parse(Console.ReadLine());
        int factoriel = 1;
        double s = 1;
        for (int i = 1; i <= n; i++)
        {
            // sum S = 1 + 1!/x + 2!/x2 + … + n!/xn
            factoriel *= i;
            
            s += factoriel / Math.Pow(x, i);

        }
        Console.WriteLine("{0:f5}",s);
    }
}