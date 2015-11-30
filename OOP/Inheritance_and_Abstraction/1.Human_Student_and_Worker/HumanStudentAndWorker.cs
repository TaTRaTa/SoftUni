using System;
using System.Collections.Generic;
using System.Linq;


namespace _1.Human_Student_and_Worker
{
    using models;
    class HumanStudentAndWorker
    {
        static void Main()
        {
            List<Worker> listWorkers = new List<Worker>();
            Worker worker1 = new Worker("ceko", "davidkov", 500, 7);
                listWorkers.Add(worker1);
            Worker worker2 = new Worker("marto","ivanov",600, 7);
            listWorkers.Add(worker2);
            Worker worker3 = new Worker("emo","emo",700, 7);
            listWorkers.Add(worker3);
            Worker worker4 = new Worker("Borko","emo",780, 7);
            listWorkers.Add(worker4);
            Worker worker5 = new Worker("Dani","emo",131, 7);
            listWorkers.Add(worker5);
            Worker worker6 = new Worker("Niki","emo",757, 7);
            listWorkers.Add(worker6);
            Worker worker7 = new Worker("Dancho","emo",535, 7);
            listWorkers.Add(worker7);
            Worker worker8 = new Worker("RoYal","emo",555, 7);
            listWorkers.Add(worker8);
            Worker worker9 = new Worker("Ivan","borislav",979, 7);
            listWorkers.Add(worker9);
            Worker worker10 = new Worker("Nasko","cekov",575, 7);
            listWorkers.Add(worker10);

            List<Student> listStudents = new List<Student>();
            listStudents.Add(new Student("emo","davidkov","124324"));
            listStudents.Add(new Student("ceko","cekov","2356644"));
            listStudents.Add(new Student("marto","davidkov","568565"));
            listStudents.Add(new Student("dani","davidkov","567555"));
            listStudents.Add(new Student("borko","cankov","757777"));
            listStudents.Add(new Student("Niki","davidkov","7565555"));
            listStudents.Add(new Student("nasko","davidkov","657555"));
            listStudents.Add(new Student("emo","Ivanov","3453454"));
            listStudents.Add(new Student("Royal","davidkov","2543555"));
            listStudents.Add(new Student("Dancho","davidkov","5664756"));

            var orderListWorkers = listWorkers
                .OrderByDescending(a => a.MoneyPerHour(a.WeekSalary, a.WorkHoursPerDay));

            var mergeList = listWorkers
                .Concat(listWorkers)
                .ToList();

            var orderListbyName =
                mergeList
                .OrderBy(order => order.FirstName)
                .ThenBy(orderLastName => orderLastName.LastName)
                .ToList();

           // Console.WriteLine();
        }
    }
}
