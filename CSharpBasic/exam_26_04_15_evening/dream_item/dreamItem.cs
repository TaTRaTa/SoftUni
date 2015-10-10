using System;

class dreamItem
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split('\\');

        string month = input[0];
        decimal moneyPerHour = decimal.Parse(input[1]);
        decimal hoursPerDay = decimal.Parse(input[2]);
        decimal priceOfTheItem  = decimal.Parse(input[3]);
        int days = 0;
        switch (month)
        {
            case "Feb": days = 28; break;
            case "Apr":
            case "June":
            case "Sept":
            case "Nov": days = 30; break;
            default: days = 31; break;
        }
        days -= 10;
        decimal result = days * moneyPerHour * hoursPerDay;
        if (result > 700)
        {
            result *= (1 + 0.10M);
        }
        if (result - priceOfTheItem >= 0)
        {
            Console.WriteLine("Money left = {0:f2} leva.", result - priceOfTheItem);
        }
        else
        {
            Console.WriteLine("Not enough money. {0:f2} leva needed.", priceOfTheItem - result);
        }
    }
}