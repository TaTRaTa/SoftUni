using System;

class CurrencyCheck
{
    static void Main()
    {
        
        long rubles = long.Parse(Console.ReadLine());
        long dollar = long.Parse(Console.ReadLine());
        long euro = long.Parse(Console.ReadLine());
        long levFor2copies = long.Parse(Console.ReadLine());
        long lev = long.Parse(Console.ReadLine());

         const decimal rubTolev = 3.5M ;
         const decimal dollarTolev = 1.5M;
         const decimal euroTolev = 1.95M;
        decimal isPriceRL = ((decimal)rubles / 100) * rubTolev;
        decimal isPriceDL = dollar * dollarTolev;
        decimal isPriceEL = euro * euroTolev;
        decimal isPriceS = (decimal)levFor2copies / 2;

        if (isPriceRL < isPriceDL && isPriceRL < isPriceEL && isPriceRL < isPriceS && isPriceRL < lev)
        {
            Console.WriteLine("{0:f2}",isPriceRL);
        }
        else if (isPriceDL < isPriceRL && isPriceDL < isPriceEL && isPriceDL < isPriceS && isPriceDL < lev)
        {
            Console.WriteLine("{0:f2}",isPriceDL);
        }
        else if (isPriceEL < isPriceDL && isPriceEL < isPriceRL && isPriceEL < isPriceS && isPriceEL < lev)
        {
            Console.WriteLine("{0:f2}",isPriceEL);
        }
        else if (isPriceS < isPriceRL && isPriceS < isPriceEL && isPriceS < isPriceDL && isPriceS < lev)
        {
            Console.WriteLine("{0:f2}", isPriceS);
        }
        else if (lev < isPriceS && lev < isPriceRL && lev < isPriceEL && lev < isPriceDL)
        {
            Console.WriteLine("{0:f2}",lev);
        }
    }
}