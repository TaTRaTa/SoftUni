using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class DirectoryTraversal
{
    static void Main()
    {
        string[] files = Directory.GetFiles(Directory.GetCurrentDirectory());
        var dir = new Dictionary<string, Dictionary<string, double>>();

        foreach (var file in files)
        {
            FileInfo info = new FileInfo(file);
            string extension = info.Extension;
            string name = info.Name;
            double size = info.Length;
            if (!dir.Keys.Contains(extension))
            {
                dir.Add(extension, new Dictionary<string,double>());
            }
            dir[extension].Add(name, size);
        }
        string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

        //var sortedList = dir
        //                    .OrderByDescending(p => p.Value.Keys)
        //                    .ThenBy(p => p.Key)
        //                    .ThenBy(p => p.Value);
        // sorting is'nt work. I don't know why 

        using (StreamWriter writer = new StreamWriter(desktop + @"\report.txt"))
        {
            //dir.OrderBy(p => p.Key); is'nt work

            foreach (var extension in dir)
            {
                writer.WriteLine(extension.Key);

                foreach (var file in extension.Value)
                {
                    writer.WriteLine("--{0} - {1:f3}", file.Key, file.Value / 1024);
                }
            }
        }


    }
}

