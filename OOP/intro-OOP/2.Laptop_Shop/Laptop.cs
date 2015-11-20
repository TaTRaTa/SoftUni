using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace _2.Laptop_Shop
{
    class Laptop
    {
        //Define a class Laptop that holds the following information about a laptop device:
        // model, manufacturer, processor, RAM, graphics card, HDD, screen, battery, battery life in hours and price.
        //
        private string model;
        private string manufacturer;
        private string processor;
        private string ram;
        private string graphicsCard;
        private string hdd;
        private string screen;        
        private double price;
        private string batteryName;
        private double batteryLife;
        private Battery battery;

        public Laptop(string model, string manufacturer, string processor, string ram, string graphicsCard, string hdd, string screen, string batteryName, double batteryLife, double price)
        {
            this.Model = model;
            this.Price = price;
            this.Processor = processor;
            this.Ram = ram;
            this.GraphicsCard = graphicsCard;
            this.HDD = hdd; 
            this.Screen = screen;
            this.Price = price;
            this.Manufacturer = manufacturer;
            this.battery = new Battery(batteryName, batteryLife);

        }

        public Laptop(string model, double price)
            : this(model, null, null, null, null, null, null, null, 0, price)
        {            
        }

        public string Model
        {
            get { return this.model; }
            set
            {
                if ((value != null && string.IsNullOrEmpty(value)) || (value != null &&  string.IsNullOrWhiteSpace(value)))
                {
                    throw new ArgumentNullException("You must enter a model.");
                }
                else this.model = value;
            }
        }

        public double Price
        {
            get { return this.price; }
            set
            {
                if (value < 0 )
                {
                    throw new ArgumentOutOfRangeException("...");
                }
                this.price = value;
            }
        }

        public string Processor
        {
            get
            { return this.processor; }
            set
            {
                if ((value != null && string.IsNullOrEmpty(value)) ||(value != null &&  string.IsNullOrWhiteSpace(value)))
                {
                    throw new ArgumentNullException("You must enter a processor");
                }
                this.processor = value;
            }
        }

        public string Ram
        {
            get
            { return this.ram; }
            set
            {
                if ((value != null && string.IsNullOrEmpty(value)) || (value != null && string.IsNullOrWhiteSpace(value)))
                {
                    throw new ArgumentNullException("You must enter a ram");
                }
                this.ram = value;
            }
        }

        public string GraphicsCard
        {
            get
            { return this.graphicsCard; }
            set
            {
                if ((value != null && string.IsNullOrWhiteSpace(value)) || (value != null && string.IsNullOrEmpty(value)))
                {
                    throw new ArgumentNullException("You must enter a VGA");
                }
                this.graphicsCard = value;
            }
        }

        public string HDD
        {
            get
            { return this.hdd; }
            set
            {
                if ((value != null && string.IsNullOrWhiteSpace(value)) ||(value != null && string.IsNullOrEmpty(value)))
                {
                    throw new ArgumentNullException("You must enter a HDD");
                }
                this.hdd = value;
            }
        }

        public string Screen
        {
            get { return this.screen; }
            set
            {
                if ((value != null && string.IsNullOrWhiteSpace(value)) ||(value != null &&  string.IsNullOrEmpty(value)))
                {
                    throw new ArgumentNullException("you must enter valid a screen");
                }
                this.screen = value;
            }
        }

        public string Manufacturer
        {
            get { return this.manufacturer; }
            set
            {
                if ((value != null && string.IsNullOrWhiteSpace(value)) ||(value != null &&  string.IsNullOrEmpty(value)))
                {
                    throw new ArgumentNullException("you must eneter valid a manufacturer");
                }
                this.manufacturer = value;
            }
        }



        public override string ToString()
        {
            return String.Format("model: {0}\nmanufacturer: {1}\nprocessor: {2}\nRAM: {3}\ngraphics card: {4}\nHDD: {5}\nscreen{6}\nbattery: {7}\nbattery life: {8}\nprice: {8} lv",
                Model,
                Manufacturer,
                Processor,
                Ram,
                GraphicsCard,
                HDD,
                Screen,
                battery.BATTERY,
                battery.BatteryLife,
                price);
        }
    }
}
