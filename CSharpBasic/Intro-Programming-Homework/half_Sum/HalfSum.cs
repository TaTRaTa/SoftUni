
using System;

class HalfSum
{
    static void Main()
    {
        Console.Write("n= ");
        int n = int.Parse(Console.ReadLine());
        int firstNum = 0;
        int secondNum = 0;

        for (int i = 0; i<2*n; i++ )
        {
            int num = int.Parse(Console.ReadLine());
            if (i<n)
            {
              
                firstNum += num;

            }
            else
            {
               
                secondNum += num;

            }
        }
        if (firstNum == secondNum)
        {
            Console.WriteLine("Yes, sum={0} ", firstNum);
        }
        else if (firstNum != secondNum)
        {
            Console.WriteLine("No, diff={0}", Math.Abs(firstNum-secondNum));
        }

    }
}