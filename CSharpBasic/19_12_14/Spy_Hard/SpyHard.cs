using System;
// 50% jugde
class SpyHard
{
    static void Main()
    {
        int keyNum = int.Parse(Console.ReadLine());
        string messege = Console.ReadLine();

        int count = 0;
        int sum = 0;
        char [] arrMessege = messege.ToCharArray();
        for (int i = 0; i < arrMessege.Length; i++)
        {
            char temp = arrMessege[i];
            if ('a' <= temp  && temp <= 'z' )
            {
                sum += (char)(temp - 96);
            }
            else
            {
                sum += arrMessege[i];
            }
            
            count++;
        }
        
        string str = string.Empty;
        long result;
        while (! (sum == 0))
        {
            result = sum % keyNum;
             sum /= keyNum;
             str += result.ToString();
        }

        char[] last = str.ToCharArray();
        Array.Reverse(last);
        Console.Write("{0}{1}", keyNum, count);
        for (int i = 0; i < str.Length; i++)
        {
            
            Console.Write("{0}",last[i]);

        }
        Console.WriteLine();
        
    }
}