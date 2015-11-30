using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Human_Student_and_Worker.models
{
    class Worker : Human
    {
        private double weekSalary;
        private int workHoursPerDay;
        public Worker(string firstName, string lastName, double weekSalary, int workHoursPerDay)
            :base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public double WeekSalary { get; set; }
        public int WorkHoursPerDay { get; set; }

        public double MoneyPerHour(double weekSalary, int workHoursPerDay)
        {
            return weekSalary/(5*workHoursPerDay);
        }
    }
}
