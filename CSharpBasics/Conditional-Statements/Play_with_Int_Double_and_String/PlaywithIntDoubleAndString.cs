using System;

class PlaywithIntDoubleAndString
{
    static void Main()
    {
        Console.WriteLine("Please choose a type:");
        Console.WriteLine(" 1 --> int ");
        Console.WriteLine("2 --> double");
        Console.WriteLine("3 --> string");
        string number = Console.ReadLine();
        switch (number)
        {
            case "1":
                Console.Write("please enter int : ");
                int intNumber = int.Parse(Console.ReadLine());
                Console.WriteLine(intNumber);
                break;
            case "2":
                Console.Write("please enter double : ");
                double doubleNumber = double.Parse(Console.ReadLine());
                Console.WriteLine(doubleNumber);
                break;
            case "3":
                Console.Write("please enter string : ");
                string stringWithStar = Console.ReadLine();
                Console.WriteLine("{0}* ", stringWithStar);
                break;
            default: Console.WriteLine("error");
                break;
        }

    }
}