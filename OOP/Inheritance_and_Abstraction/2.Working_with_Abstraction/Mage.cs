
namespace _2.Working_with_Abstraction
{
    using System;
    using Characters;
    class Mage : Character
    {
        public Mage()
            : base(100, 300, 75)
        {
            
        }

        public override void Attack(Character target)
        {
            this.Mana -= 100;
            target.Health -= 2*this.Damage;
        }
    }
}
