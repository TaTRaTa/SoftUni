using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class LineNumbers
{
    static void Main()
    {
        string readFile = "../../text.txt";
        string WriteFile = "../../anotherText.txt";

        using (StreamReader reader = new StreamReader(readFile))
        {
            using (StreamWriter writer = new StreamWriter(WriteFile))
            {
                int count = 1;
                string line = reader.ReadLine();
                while (line != null)
                {
                    writer.WriteLine("{0,-2}:{1}",count,line);
                    count++;
                    line = reader.ReadLine();
                }
            }
        }



    }
}

