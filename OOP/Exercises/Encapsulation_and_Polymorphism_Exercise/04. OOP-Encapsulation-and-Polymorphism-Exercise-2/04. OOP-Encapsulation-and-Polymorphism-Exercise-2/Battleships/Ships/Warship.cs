namespace Battleships.Ships
{
    using System;

    public class Warship : Battleship
    {
        private string name;
        private double lengthInMeters;
        private double volume;

        public Warship(string name, double lengthInMeters, double volume)
            :base(name, lengthInMeters, volume)
        {
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("value", "Name cannot be null or empty.");
                }

                this.name = value;
            }
        }

        public double LengthInMeters
        {
            get
            {
                return this.lengthInMeters;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("value", "The length of a ship cannot be negative.");
                }

                this.lengthInMeters = value;
            }
        }

        public double Volume
        {
            get
            {
                return this.volume;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("value", "The volume of a ship cannot be negative.");
                }

                this.volume = value;
            }
        }

        public override string Attack(Ship targShip)
        {
            this.DestroyShip(targShip);
            return "Victory is ours!";
        }
    }
}
