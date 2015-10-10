using System;

class RandomNumbersInGivenRange
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int min = int.Parse(Console.ReadLine());
        int max = int.Parse(Console.ReadLine());
        Random rnd = new Random();
        if (min<=max)
        {
            for (int i = 0; i < n; i++)
            {
                int randomNum = rnd.Next(min , max + 1);
                Console.Write("{0} ", randomNum);
                
            }
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Invalid input");
        }
    }
}