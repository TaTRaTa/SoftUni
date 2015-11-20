using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Laptop_Shop
{
    class Battery
    {
        private string batteryName;
        private double batteryLife;

        public Battery(string batteryName, double batteryLife)
        {
            this.BATTERY = batteryName;
            this.BatteryLife = batteryLife;
        }
        public Battery()
            :this(null, 0)
        { }

        public string BATTERY
        {
            get { return this.batteryName; }
            set
            {
                if ((value != null && string.IsNullOrWhiteSpace(value)) ||(value != null &&  string.IsNullOrEmpty(value)))
                {
                    throw new ArgumentNullException("You must enter valid battery name");
                }
                this.batteryName = value;
            }
        }

        public double BatteryLife
        {
            get { return this.batteryLife; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("you must enter positive number");
                }
                this.batteryLife = value;
            }
        }

    }
}
