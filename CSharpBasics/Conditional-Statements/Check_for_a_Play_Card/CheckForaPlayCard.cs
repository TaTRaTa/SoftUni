using System;

class CheckForaPlayCard
{
    static void Main()
    {

        string a = Console.ReadLine();
        Console.WriteLine("Valid card sign?");
        switch (a)
        {
            case "J":
            case "K":
            case "Q":
            case "A":
            case "2":
            case "3":
            case "4":
            case "5":
            case "6":
            case "7":
            case "8":
            case "9":
            case "10":
                Console.WriteLine("YES");
                break;
            default: Console.WriteLine("NO");
                break;
        }

    }
}