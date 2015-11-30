using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Animals
{
    abstract class Animal : ISoundProducible
    {
        private string name;
        private int age;
        private  GenderType gender;

        protected Animal(string name, int age, GenderType gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public  string Name { get; set; }
        public int Age { get; set; }
        public GenderType Gender { get; set; }

        public virtual void ProduceSound()
        {
            Console.WriteLine("ANIMAL");
        }
    }
}
