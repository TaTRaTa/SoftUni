using System;



class BiggerNumber
{
    static void Main()
    {
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());

        int max = GetMax(firstNumber, secondNumber);

        Console.WriteLine(max);

    }

    static int GetMax(int a, int b)
    {
        if (a > b)
            {
                return a;
            }
        else if (b > a)
            {
                return b;
            }
        else
            {
                Console.WriteLine();
                Console.Write("both are equal: {0} == ", a);
                return a;
            }
    }
}

