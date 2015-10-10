using System;

class TheExplorer
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int temp = 4;
        temp = n - temp;
        int temp2 = 0;
        Console.WriteLine("{0}{1}{0}",new string('-', (n - 1) / 2), '*');         
        for (int i = 1, j = 0; i < n-1; i++ , j++ )
        {
            if (i < (n + 1) / 2)
            {
                Console.WriteLine("{0}{1}{2}{1}{0}", new string('-', ((n - 1) / 2)-j-1), '*',new string('-',(j+1)+j));
            } 
            else if(i >= (n + 1) / 2)
            {
                temp2++;
                Console.WriteLine("{0}{1}{2}{1}{0}", new string('-', temp2), '*', new string('-', (n + temp) - (i + j))); 
            }
        }
        Console.WriteLine("{0}{1}{0}", new string('-', (n - 1) / 2), '*');
    }
}
