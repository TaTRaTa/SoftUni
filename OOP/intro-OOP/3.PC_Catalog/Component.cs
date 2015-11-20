using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.PC_Catalog
{
    class Component
    {
        private string name;
        private string details;
        private double price;

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value == string.Empty)
                {
                    throw new ArgumentNullException("You must specify a component name.");
                }
                this.name = value;
            }
        }

        public string Details { get; set; }

        public double Price
        {
            get { return this.price; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("You must be eneter positive price");
                }
                this.price = value;
            }
        }

        public Component(string name, string details, double price)
        {
            this.Name = name;
            this.Details = details;
            this.Price = price;
        }
    }
}
