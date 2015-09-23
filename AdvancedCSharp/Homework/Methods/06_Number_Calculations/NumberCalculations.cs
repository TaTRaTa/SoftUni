using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
 
class Number_Calculations
{
    static void Main()
    {
        //int[] numbersInts = Console.ReadLine().Split().Select(int.Parse).ToArray(); // other way with "Linq"
        string[] strNum = Console.ReadLine().Split(' ');
        int[] numbersInts = new int[strNum.Length];
        for (int i = 0; i < strNum.Length; i++)
        {
            numbersInts[i] = int.Parse(strNum[i]);
        }
        Console.WriteLine("Minimum of int's Array {0}", MinimumInt(numbersInts));
        Console.WriteLine("Maximum of int's Array {0}", MaximumInt(numbersInts));
        Console.WriteLine("Average of int's Array {0:f2}", AverageInt(numbersInts));
        Console.WriteLine("Sum of int's Array {0}", SumInt(numbersInts));
        Console.WriteLine("Product of int's Array {0}", ProductInt(numbersInts));

        //double[] numbersDoubles = Console.ReadLine().Split().Select(double.Parse).ToArray(); other way with "Linq"
        string[] strNum2 = Console.ReadLine().Split();
        double[] numbersDoubles = new double[strNum2.Length];
        for (int i = 0; i < strNum2.Length; i++)
        {
            numbersDoubles[i] = double.Parse(strNum2[i]);
        }
        Console.WriteLine("Minimum of double's Array {0}", MinimumDouble(numbersDoubles));
        Console.WriteLine("Maximum of double's Array {0}", MaximumDouble(numbersDoubles));
        Console.WriteLine("Average of double's Array {0:f2}", AverageDouble(numbersDoubles));
        Console.WriteLine("Sum of double's Array {0}", SumDouble(numbersDoubles));
        Console.WriteLine("Product of double's Array {0}", ProductDouble(numbersDoubles));
    }

    private static BigInteger ProductInt(int[] numbers)
    {
        BigInteger product = 1;
        for (int i = 0; i < numbers.Length; i++)
        {
            product *= numbers[i];
        }
        return product;
    }

    private static decimal ProductDouble(double[] numbers)
    {
        decimal product = 1;
        for (int i = 0; i < numbers.Length; i++)
        {
            product *= (decimal)numbers[i];
        }
        return product;
    }

    private static int SumInt(int[] numbers )
    {
        int sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }
        return sum;
    }

    private static double SumDouble(double[] numbers)
    {
        double sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }
        return sum;
    }
    private static double AverageInt(int[] numbers)
    {
        double avg = 0;
        return avg = (SumInt(numbers) + 0.0) / numbers.Length;
    }

    private static decimal AverageDouble(double[] numbers)
    {
        decimal avg = 0;
        return avg = (decimal)SumDouble(numbers)/(decimal)numbers.Length;
    }

    private static int MaximumInt(int[] numbers)
    {
        int maxValue = int.MinValue;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (maxValue < numbers[i])
            {
                maxValue = numbers[i];
            }
        }
        return maxValue;

    }

    private static double MaximumDouble(double[] numbers)
    {
        double maxValue = int.MinValue;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (maxValue < numbers[i])
            {
                maxValue = numbers[i];
            }
        }
        return maxValue;

    }

    public static int MinimumInt(int[] numbers)
    {
        int minValue = int.MaxValue;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (minValue > numbers[i])
            {
                minValue = numbers[i];
            }
        }
        return minValue;
    }
    public static double MinimumDouble(double[] numbers)
    {
        double minValue = int.MaxValue;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (minValue > numbers[i])
            {
                minValue = numbers[i];
            }
        }
        return minValue;
    }
}

