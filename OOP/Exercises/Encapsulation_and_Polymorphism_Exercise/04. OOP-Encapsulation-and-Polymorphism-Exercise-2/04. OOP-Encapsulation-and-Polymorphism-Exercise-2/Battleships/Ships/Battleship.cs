using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleships.Ships
{
    public abstract class Battleship : Ship, IAttack
    {
        protected Battleship(string name, double length, double volume)
            : base(name, length, volume)
        {
            
        }

        public abstract string Attack(Ship targetShip);

        protected void DestroyShip(Ship targShip)
        {
            targShip.IsDestroyed = true;
        }
    }
}
