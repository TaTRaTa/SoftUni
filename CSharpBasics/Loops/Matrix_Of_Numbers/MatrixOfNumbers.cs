using System;

class MatrixOfNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int countCol = 1;
        if (1 < n && n < 20)
        {
            for (int i = 1; i <= n; i++)
            {            
                for (int j = i; j <= n * 2; j++)
                {
                    if (countCol <= n)
                    {
                        Console.Write("{0,-3}", j);
                        countCol++;                       
                    }                   
                }
                Console.WriteLine();
                countCol = 1;
            }
        }
        else
        {
            Console.WriteLine("Invalid input");
        }
    }
}