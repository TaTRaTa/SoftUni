using System;

class DecimaltoBinaryNumber
{
    static void Main()
    {
        long decimalNum = long.Parse(Console.ReadLine());
        string binary =  string.Empty;
        long result = 0;
        long count = 1;

        while (count!=0)
        {
            result = decimalNum % 2;
            binary += result.ToString();
            count = decimalNum / 2;
            decimalNum = count;
        }
        char[] valueCh = binary.ToCharArray();
        Array.Reverse(valueCh);
       
        for (int i = 0; i < binary.Length; i++)
        {
            Console.Write(valueCh[i]);
        } 
        Console.WriteLine();
        
       
    }
}