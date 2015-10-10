using System;

class PrimeNumberCheck
{
    static void Main()
    {
        Console.WriteLine("Write an expression that checks if given positive integer number n (n ≤ 100) is prime (i.e. it is divisible without remainder only to itself and 1).");
        Console.WriteLine("Enter a Number : ");
        
        int n = int.Parse(Console.ReadLine());
        int count = 0;
        for (int i = 1; i <= n; i++)
        {
            if (n % i == 0)
            {
                count++;
            }
        }
                if (count == 2)
                {
                    Console.WriteLine("The number is prime");
                }
                else
                {
                    Console.WriteLine("The number is not prime ");
                }
                Console.ReadLine();

			
    }
}