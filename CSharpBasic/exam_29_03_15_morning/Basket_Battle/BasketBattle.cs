using System;
// 60% from judge
class BasketBattle
{
    static void Main()
    {
        string fName = Console.ReadLine();
        string sName;
        int rounds = int.Parse(Console.ReadLine());
        int sum = 0;
        int sum2 = 0;
        int count = 0;
        int count2 = 0;
        if (fName == "Simeon")
        {
            sName = "Nakov";
        }
        else
        {
            sName = "Simeon";
        }

        for (int i = 1; i <= rounds; i++)
        {
            int score, score2;
            string succ, succ2;
            if (i % 2 != 0)
            {
                 score = int.Parse(Console.ReadLine());
                 succ = Console.ReadLine();
                if (succ == "success")
                {
                    sum += score;
                    if (sum >= 500)
                    {
                        count = i;
                        break;
                    }
                }
                 score2 = int.Parse(Console.ReadLine());
                 succ2 = Console.ReadLine();
                if (succ2 == "success")
                {
                    sum2 += score2;
                    if (sum2 >= 500)
                    {
                        count2 = i;
                        break;
                    }
                }
            }
            else
            {
                 score2 = int.Parse(Console.ReadLine());
                 succ2 = Console.ReadLine();
                if (succ2 == "success")
                {
                    sum2 += score2;
                    if (sum2 >= 500)
                    {
                        count2 = i;
                        break;
                    }
                }
                 score = int.Parse(Console.ReadLine());
                 succ = Console.ReadLine();
                if (succ == "success")
                {
                    sum += score;
                    if (sum >= 500)
                    {
                        count = i;
                        break;
                    }
                }
            }
        }
        if (sum == sum2)
        {
            Console.WriteLine("DRAW");
            Console.WriteLine(sum2);
        }
        else
        {
            if (sum >= 500)
            {
                Console.WriteLine(fName);
                Console.WriteLine(count);
                Console.WriteLine(sum2);
            }
            else if (sum2 >= 500)
            {
                Console.WriteLine(sName);
                Console.WriteLine(count2);
                Console.WriteLine(sum);
            }
            else if (sum < 500 && sum2 < 500)
            {
                if (sum > sum2)
                {
                    Console.WriteLine(fName);
                    Console.WriteLine("{0}", Math.Abs(sum - sum2));
                }
                else
                {
                    Console.WriteLine(sName);
                    Console.WriteLine("{0}", Math.Abs(sum2 - sum));
                }
            }
        }
    }
}