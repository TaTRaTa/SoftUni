using System;
class NewHouse
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i=i+2)
        {
            Console.WriteLine("{0}{1}{0}", new string('-', (n - i) / 2), new string('*', i)); 
        }
        for (int j = 1; j <= n; j++)
        {
            Console.WriteLine("{0}{1}{0}",'|',new string('*',n-2));
        }
    }
}



//string dash = new string('-', (n - i) / 2);
//string star = new string('*', i);
// Console.WriteLine("{0}{1}{0}", dash , star);