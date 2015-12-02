using System;
using System.Collections.Specialized;

namespace Battleships.Ships
{
    public abstract class Ship
    {
        private string name;
        private double length;
        private double volume;

        protected Ship(string name, double length, double volume)
        {
            this.Name = name;
            this.Length = length;
            this.Volume = volume;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be null, or whiteSpace");
                }
                this.name = value;
            }
        }

        public double Length
        {
            get { return this.length; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Length cannot be negative");
                }
                this.length = value;
            }
        }

        public double Volume
        {
            get { return this.volume; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Length cannot be negative");
                }
                this.volume = value;
            }
        }

        public bool IsBattleship { get; set; }

        public bool IsDestroyed { get; set; }
    }
}
