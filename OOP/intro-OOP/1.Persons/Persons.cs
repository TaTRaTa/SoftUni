using System;


namespace _1.Persons
{
    class Persons
    {
        static void Main()
        {

            Console.WriteLine("Enter name...");
            var name = Console.ReadLine();
            Console.WriteLine("Enter age...");
            var age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter email...");
            var email = Console.ReadLine();

            
            if (!email.Equals(""))
            {
                Person person = new Person(name, age, email);
                Console.WriteLine(person);
            }
            else
            {
                Person person = new Person(name, age);
                Console.WriteLine(person);
            }
            
            
            

        }
    }
}
