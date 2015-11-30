using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Human_Student_and_Worker.models
{
    abstract class Human
    {
        private string firstName;
        private string lastName;

        protected Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;

        }

        public string FirstName
        {
            get { return this.firstName; }
            set {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("FirstName cannot be null");
                }
                this.firstName = value;
            }
        }

        public string LastName
        {
            get { return this.lastName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("SecondName cannot be null");
                }
                this.lastName = value;
            }
        }
    }
}
