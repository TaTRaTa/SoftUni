using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Animals
{
    class Kitten : Cat
    {
        public Kitten(string name, int age)
            : base(name, age, GenderType.Female)
        {           
        }

        public override void ProduceSound()
        {
            Console.WriteLine("aaaaa");
        }
    }
}
