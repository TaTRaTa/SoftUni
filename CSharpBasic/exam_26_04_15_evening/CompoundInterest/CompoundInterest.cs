using System;

class CompoundInterest
{
    static void Main()
    {
        double priceOnTV = double.Parse(Console.ReadLine());
        int yearsUntilPay = int.Parse(Console.ReadLine());
        double interestRateBank = double.Parse(Console.ReadLine());
        double interestRateFriend = double.Parse(Console.ReadLine());

        double bankRate =  Math.Pow( 1 + interestRateBank , yearsUntilPay);
        double friendRate = 1 + interestRateFriend;

        double bankLoan = priceOnTV * bankRate;
        double friendLoan = priceOnTV * friendRate;
        if (bankRate != friendLoan)
        {
            if (bankLoan < friendLoan)
            {
                Console.WriteLine("{0:f2} Bank", bankLoan );
                
            }
            else
            {
                Console.WriteLine("{0:f2} Friend",friendLoan);
            }
           
        }

    }
}