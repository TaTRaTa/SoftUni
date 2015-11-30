

namespace _2.Working_with_Abstraction
{
    using System;
    using Characters;
    using Interfaces;
    class Priest : Character, IHeal
    {
        public Priest()
            : base(125, 200, 100)
        {            
        }

        public override void Attack(Character target)
        {
            this.Mana -= 100;
            target.Health -= this.Damage;
            this.Health += this.Damage/10;
        }

        public void Heal(Character target)
        {
            this.Mana -= 100;
            target.Health += 150;
        }
    }
}
