using System;

class BinaryToDecimalNumber
{
    static void Main()
    {
        Console.WriteLine("Enter binary integer:");
        string binary = Console.ReadLine();
        int[] num = new int[binary.Length];
        long decimalNum = 0;
        long count = binary.Length - 1;
        for (int i = 0; i < binary.Length; i++)
        {
            char ch = binary[i];
             num[i] = int.Parse(ch.ToString());
             decimalNum += num[i] * (long)Math.Pow(2, count);
             count--;

        }
        Console.WriteLine(decimalNum);

    }
}