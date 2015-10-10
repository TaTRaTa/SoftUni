using System;

class ChessboardGame
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string str = Console.ReadLine();
        char[] ascii = str.ToCharArray();
        int blackSum = 0;
        int whiteSum = 0;
        for (int i = 0; i < ascii.Length ; i++)
        {
            if (i < n * n)
            {
                if (i % 2 == 0 && char.IsUpper(ascii[i]))
                {
                    whiteSum += (int)ascii[i];
                }
                else if (i % 2 == 0 && char.IsLetterOrDigit(ascii[i]))
                {
                    blackSum += (int)ascii[i];
                }
                else if (i % 2 != 0 && char.IsUpper(ascii[i]))
                {
                    blackSum += (int)ascii[i];
                }
                else if (i % 2 != 0 && char.IsLetterOrDigit(ascii[i]))
                {
                    whiteSum += (int)ascii[i];
                }
            }
            else
            {
                break;
            }
            
           
        }
        if (blackSum > whiteSum)
        {
            Console.WriteLine("The winner is: black team");
            Console.WriteLine(blackSum-whiteSum);
            return;
        }
        else if (blackSum < whiteSum)
        {
            Console.WriteLine("The winner is: white team");
            Console.WriteLine(whiteSum-blackSum); 
            return;
        }
        else if (blackSum == whiteSum)
        {
            Console.WriteLine("Equal result: {0}",blackSum);
            return;
        }
    }
}