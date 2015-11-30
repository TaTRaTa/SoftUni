using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Human_Student_and_Worker.models
{
    class Student : Human
    {
        private string facultyNum;
        public Student(string firstName, string lastName, string facultyNum)
            :base(firstName, lastName)
        {
            this.FacultyNumber = facultyNum;
        }

        public string FacultyNumber
        {
            get { return this.facultyNum; }
            set
            {
                if (value.Length < 5 || 10 < value.Length)
                {
                    throw new ArgumentOutOfRangeException("faculty must be  of range 5-10");
                }
                this.facultyNum = value;
            }
        }
    }
}
