 using System;

class OddEvenSum
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        
        int even = 0;
        int odd = 0;
       
        for (int i = 0; i < 2*n; i++)
        {
            int number = int.Parse(Console.ReadLine());
            if (number % 2 == 0)
            {
                even += number;
            }
            else
            {
                odd += number;
            }
        } 
        if (even == odd)
        {
            Console.WriteLine("Yes, sum={0}", (even));
        }
        else
        {
            Console.WriteLine("No, diff={0}", Math.Abs(odd-even));
        }
    }
} 
