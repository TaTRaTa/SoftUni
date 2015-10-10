using System;

class KingOfThieves
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int chInt = Console.Read();
        char ch = Convert.ToChar(chInt);
        
        
        int temp = (n / 2) - 1;
        
        Console.WriteLine("{0}{1}{0}",new string('-',n / 2), ch);
        for (int i = 1; i < (n / 2)  ; i++)
        {
            Console.WriteLine("{0}{1}{0}",new string('-', temp) ,new string(ch, (i * 2) + 1));
            temp--;
        }
        Console.WriteLine("{0}", new string(ch, n ));
        for (int i = 1; i < n / 2; i++)
        {
            Console.WriteLine("{0}{1}{0}", new string('-',i),new string(ch,n-(2*i) ));
            
        }
        Console.WriteLine("{0}{1}{0}", new string('-', n / 2), ch);
    }
}