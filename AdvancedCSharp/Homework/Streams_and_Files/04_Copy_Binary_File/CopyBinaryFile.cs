using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class CopyBinaryFile
{
    static void Main()
    {

        using (FileStream source = new FileStream("../../3.png", FileMode.Open))
        {
            using (FileStream destination = new FileStream("../../result.txt", FileMode.Create))
            {
                byte[] buffer = new byte[4096];
                while (true)
                {


                    int readBytes = source.Read(buffer, 0, buffer.Length);
                    if (readBytes == 0)
                    {
                        break;
                    }
                    
                    destination.Write(buffer, 0, readBytes);
                }


            }
        }       
    }
}

