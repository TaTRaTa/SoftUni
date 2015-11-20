using System;
using System.Collections.Generic;
using System.Linq;

namespace _3.PC_Catalog
{
    class PCCatalog
    {
        static void Main()
        {
            Computer pc1 = new Computer(
                "Dell Precision T3400 Workstation",
                "Intel Core2Quad E6600",
                100,
                "Dell Intel Motherboard",
                50,
                "nVidia GeForce 8600 GT",
                50);
            Computer pc2 = new Computer("Assembled",
                "AMD Athlon X2 64 4400+",
                "2 MB cache, not overclocked",
                30, "ASUS M2N-E",
                "nVidia nForce 570 Chipset, 10xUSB 2.0, 1xPCIe x16, 4xPCI",
                30, "nVidia Quadro FX 1700",
                "Professional Graphics Card", 30);
            

            Computer pc6 = new Computer(
                "ASUS G20AJ-BG002S",
                "INTEL CORE i7-4790",
                "3.6 GHz 8MB",
                1000,                
                "Unknown Motherboard",
                "INTEL H97 CHIPSET",
                1000,                
                "NVIDIA GeForce GTX970",
                "4GB DDR5",
                1000
                
                );


            List<Computer> compList = new List<Computer> { pc1, pc2, pc6 };
            var sortCompsByPrice = compList.OrderByDescending(x => x.Price);
            foreach (var comp in sortCompsByPrice)
            {
                comp.PrintConfigDetails();
            }
        }
    }
}
