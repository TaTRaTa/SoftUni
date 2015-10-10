/*Create a program that assigns null values to an integer and to a double variable. Try to print these variables at the console.
Try to add some number or the null literal to these variables and print the result.*/

using System;

class valuesNull
{
    static void Main()
    {
        int? testOne = null;
        double? testTwo = null;
        Console.WriteLine("testOne: " + testOne);
        Console.WriteLine("TestTwo: " + testTwo + "\n ^^^^^^^^^");
        testOne = 8;
        testTwo = 1.5;
        Console.WriteLine("test 1: " + testOne);
        Console.WriteLine("test 2: " + testTwo);

       

    }
}