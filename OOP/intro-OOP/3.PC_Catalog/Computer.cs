using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.PC_Catalog
{
    class Computer
    {
        private string name;
        private double price;

        public Computer(string name, string cruName, string cruDetails, double cruPrice,
                                     string vgaName, string vgaDetails, double vgaPrice,
                                     string mbName, string mbDetails, double mbPrice)
        {
            this.Name = name;
            this.CPU = new Component(cruName, cruDetails, cruPrice);
            this.MotherBoard = new Component(mbName, mbDetails, mbPrice);
            this.VGA = new Component(vgaName, vgaDetails, vgaPrice);
            this.Price = cruPrice + vgaPrice + mbPrice;
        }

        public Computer(string name, string cruName, double cruPrice,
            string vgaName, double vgaPrice,
            string mbName, double mbPrice)
            : this(name, cruName, null, cruPrice, vgaName, null, vgaPrice, mbName, null, mbPrice)
        {
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value == string.Empty)
                {
                    throw new ArgumentNullException("Please specify a computer name.");
                }
                this.name = value;
            }
        }

        public double Price
        {
            get { return this.price; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Price must be positive");
                }
                this.price = value;
            }
        }
        public Component CPU { get; set; }
        public Component MotherBoard { get; set; }
        public Component VGA { get; set; }

        public void PrintConfigDetails()
        {
            Console.WriteLine(new string('=', 30));
            Console.WriteLine("Computer Details:");
            Console.WriteLine(new string('=', 30));
            Console.WriteLine("Name: {0}", this.Name);
            Console.WriteLine("CPU: {0}", this.CPU.Name);
            if (!string.IsNullOrEmpty(this.CPU.Details)) Console.WriteLine("CPU Details: {0}", this.CPU.Details);
            Console.WriteLine("Motherboard: {0}", this.MotherBoard.Name);
            if (!string.IsNullOrEmpty(this.MotherBoard.Details)) Console.WriteLine("Motherboard Details: {0}", this.MotherBoard.Details);
            Console.WriteLine("VGA: {0}", this.VGA.Name);
            if (!string.IsNullOrEmpty(this.VGA.Details)) Console.WriteLine("VGA Details: {0}", this.VGA.Details);
            Console.WriteLine("Total Price: {0} BGN", this.Price);
        }
    }
}
