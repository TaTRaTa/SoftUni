using System;
using System.Linq;
using System.Collections.Generic;
using System.IO;
class SlicingFile
{
    static string ext;
    static void Main()
    {
        // slice file
        Console.Write("Please enter number of slices: ");
        int parts = int.Parse(Console.ReadLine());
        Slice("hubble.jpg", @"\..", parts);
        Console.WriteLine("Slicing done.");
        // assemble files
        List<string> files = new List<string>();
        string destinationDirectory = Directory.GetCurrentDirectory();
        string[] allFiles = Directory.GetFiles(destinationDirectory);
        for (int i = 0; i < allFiles.Length; i++)
        {
            if (allFiles[i].Contains("Part-") && allFiles[i].Contains(ext))
            {
                files.Add(allFiles[i]);
            }
        }
        Assemble(files, destinationDirectory);
        Console.WriteLine("Original file assembled.");
    }
    static void Slice(string sourceFile, string destinationDirectory, int parts)
    {
        byte[] buffer = new byte[4096];
        long fileSize = new FileInfo(sourceFile).Length;
        string extension = new FileInfo(sourceFile).Extension;
        ext = extension;
        int pieceSize = (int)Math.Ceiling((decimal)fileSize / parts);
        using (FileStream reader = new FileStream(sourceFile, FileMode.Open))
        {
            for (int part = 0; part < parts; part++)
            {
                string destinationFileName = string.Format("Part-{0}", (part + 1).ToString("D3")) + extension;
                using (FileStream writer = new FileStream(destinationFileName, FileMode.Append))
                {
                    long currentPieceSize = 0;
                    while (currentPieceSize < pieceSize)
                    {
                        // read piece
                        int bytesRead = reader.Read(buffer, 0, buffer.Length);
                        if (bytesRead == 0) break;
                        // write piece
                        writer.Write(buffer, 0, bytesRead);
                        currentPieceSize += bytesRead;
                    }
                }
            }
        }
    }
    static void Assemble(List<string> files, string destinationDirectory)
    {
        byte[] buffer = new byte[4096];
        using (FileStream writer = new FileStream(("Assembled" + ext), FileMode.Append))
        {
            foreach (var sourceFile in files)
            {
                using (FileStream reader = new FileStream(sourceFile, FileMode.Open))
                {
                    while (true)
                    {
                        // read piece
                        int bytesRead = reader.Read(buffer, 0, buffer.Length);
                        if (bytesRead == 0) break;
                        // write piece
                        writer.Write(buffer, 0, bytesRead);
                    }
                }
            }
        }
    }
}