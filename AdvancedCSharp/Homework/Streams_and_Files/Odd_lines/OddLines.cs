using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class OddLines
{
    static void Main()
    {
        string textFile = "text.txt";
        int count = 0;
        
        using (StreamReader text = new StreamReader(textFile))
        {
            string line = text.ReadLine();
            while (line != null)
            {
                if (count % 2 == 0)
                {
                    Console.WriteLine(line);
                }
                count++;
                line = text.ReadLine();
            }
        }
    }
}

