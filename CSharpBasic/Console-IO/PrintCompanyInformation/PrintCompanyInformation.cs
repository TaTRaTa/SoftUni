using System;

class PrintCompanyInformation
{
    static void Main()
    {
        Console.Write("Company name: ");
        string companyName = Console.ReadLine();
        Console.Write("Address: ");
        string address = Console.ReadLine();
        Console.Write("Phone Number: ");
        string phoneNumber = Console.ReadLine();
        Console.Write("Fax Number: ");
        string faxNumber = Console.ReadLine();
           if (faxNumber=="")
           {
               faxNumber = "(no FAX)";
           }
        Console.Write("web site: ");
        string webSite = Console.ReadLine();
        Console.Write("Manager first name: ");
        string firstName = Console.ReadLine();
        Console.Write("Manager last name: ");
        string lastName = Console.ReadLine();
        Console.Write("Manager age: ");
        string managerAge = Console.ReadLine();
        Console.Write("Manager phone: ");
        string managerPhone = Console.ReadLine();
        Console.WriteLine(" {0}\nAddress: {1}\nTel. {2}\nFAX: {3}\nweb site: {4}\nManager: {5} {6} (age: {7}, tel. {8}) ", companyName, address, phoneNumber
                                                                                                                         , faxNumber, webSite, firstName
                                                                                                                         , lastName, managerAge, managerPhone);

    }
}