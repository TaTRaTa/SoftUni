using System;

class DigitNumber
{
    static void Main()
    {
        Console.WriteLine("Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:");
        Console.WriteLine(" 	Calculates the sum of the digits (in our example 2+0+1+1 = 4)");
        Console.WriteLine(" 	Prints on the console the number in reversed order: dcba (in our example 1102)");
        Console.WriteLine(" 	Puts the last digit in the first position: dabc (in our example 1201).");
        Console.WriteLine("        Exchanges the second and the third digits: acbd (in our example 2101)");
        int n = int.Parse(Console.ReadLine());
        //  last number (4)
        int firstNumber = n % 10;
        //  number (3)
        int restSecondNumber = ( n / 10 ) % 10;
        //  number (2)
        int restThreeNumber = ( n / 100) % 10;
        // number (1)
        int restFourNumber = (n / 1000) % 10;
        // sum of digits
        int sum = restFourNumber + restThreeNumber + restSecondNumber + firstNumber;
            Console.WriteLine("sum of digits = " + sum);
        // reversed
            Console.WriteLine("reversed {0}{1}{2}{3}", firstNumber,restSecondNumber,restThreeNumber,restFourNumber);
        // last digit in front
            Console.WriteLine("last digit in front {0}{1}{2}{3}", firstNumber, restFourNumber, restThreeNumber, restSecondNumber);
        //
            Console.WriteLine("Second and third digits exchanged {0}{1}{2}{3}",restFourNumber,restSecondNumber, restThreeNumber, firstNumber);
    }
}