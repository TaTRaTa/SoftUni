

namespace _2.Working_with_Abstraction
{
    using System;
    using Characters;
    class Warrior : Character
    {
        public Warrior()
            : base(300, 0, 120)
        {           
        }

        public override void Attack(Character target)
        {
            target.Health -= 100;
        }
    }
}
