using System;

class RandomizeTheNumbers1N
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] num = new int[n];
        Random rnd = new Random();
        for (int i = 1; i <= n; i++)
        {
            int rndNum = rnd.Next(1, n + 1);
            num[i] = rndNum; 

        }
        Console.WriteLine();
        //ne e vqrna
        
    }
}