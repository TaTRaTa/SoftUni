using System;

class OddandEvenProduct
{
    static void Main()
    {
        string[] numbers = Console.ReadLine().Split();
        int sumOdd = 1;
        int sumEven = 1;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (i % 2 == 0)
            {
                sumEven *= int.Parse(numbers[i]);
            }
            else
            {
                sumOdd *= int.Parse(numbers[i]);
            }
        }
        if (sumOdd == sumEven)
        {
            Console.WriteLine("Yes");
            Console.WriteLine("Product = {0}", sumEven);
        }
        else
        {
            Console.WriteLine("No");
            Console.WriteLine("Odd_product = {0}",sumOdd);
            Console.WriteLine("Even_product = {0}",sumEven);
        }


    }
}