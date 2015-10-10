using System;

class ThirdDigitIs7
    {
        static void Main()
        {
            Console.WriteLine("Write an expression that checks for given integer if its third digit from right-to-left is 7. ");
            int n = int.Parse(Console.ReadLine());
            bool number = (n / 100) % 10 == 7 ? true : false;
            Console.WriteLine( number );
        }
    }

