/*A marketing company wants to keep record of its employees. Each record would have the following characteristics:
•	First name
•	Last name
•	Age (0...100)
•	Gender (m or f)
•	Personal ID number (e.g. 8306112507)
•	Unique employee number (27560000…27569999)
Declare the variables needed to keep the information for a single employee using appropriate primitive data types. 
 * Use descriptive names. Print the data at the console.*/
using System;


class employeeData
{
    static void Main()
    {
        Console.WriteLine("write first and last name: ");
        string firstName =Console.ReadLine();
        string lastName = Console.ReadLine();
        
        Console.WriteLine("your age: ");
        byte age = byte.Parse(Console.ReadLine());
        
        Console.WriteLine("male or female: ");
        string gender = Console.ReadLine();
        
        Console.WriteLine(@"personal ID number ""8306112507"" : ");
        long ID = long.Parse(Console.ReadLine());

        Console.WriteLine(@"unique employee number ""27560000…27569999"": ");
        long UEN = long.Parse(Console.ReadLine());


        Console.WriteLine("write first and last name:  {0}  {1}"+
                          "\n your age: {2}"+
                          "\n male or female: {3}"+
                          "\n personal ID number : {4}"+
                          "\n unique employee number: {5}",
                          firstName,lastName,age,gender,ID,UEN);
       


    }
}