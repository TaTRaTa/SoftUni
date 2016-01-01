using System;



class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 2, 6, 6, 9, 12, 1, 3, 10, 7, 5, 0 };
        
        for (int i = 1 ; i < numbers.Length ; i++)
        {
            int j = i;
            while (j > 0 && numbers[j - 1] > numbers[j])
            {
                int temp = numbers[j - 1];
                numbers[j - 1] = numbers[j];
                numbers[j] = temp;
                j--;                   
            }
        }
        
        Console.WriteLine(string.Join(", ", numbers));
    }
}

