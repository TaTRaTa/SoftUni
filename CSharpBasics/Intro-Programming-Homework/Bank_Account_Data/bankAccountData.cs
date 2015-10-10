/*A bank account has a holder name (first name, middle name and last name),
available amount of money (balance), bank name, IBAN, 3 credit card numbers associated with the account.
Declare the variables needed to keep the information for a single bank account using the appropriate data types and descriptive names.*/

using System;

class bankAccountData
{
    static void Main()
    {
        Console.WriteLine("First Name: ");
        string firstName = Console.ReadLine();
        Console.WriteLine("Middle Name: ");
        string middleName = Console.ReadLine();
        Console.WriteLine("Last Name: ");
        string lastName = Console.ReadLine();
        Console.WriteLine("Balance : ");
        string balance = Console.ReadLine();
        Console.WriteLine("bank Name: ");
        string bankName = Console.ReadLine();
        Console.WriteLine("IBAN : ");
        string IBAN = Console.ReadLine();
        Console.WriteLine("credit card 1: ");
        string cardOne = Console.ReadLine();
        Console.WriteLine("credit card 2: ");
        string cardTwo = Console.ReadLine();
        Console.WriteLine("credit card 3: ");
        string cardThree = Console.ReadLine();

        Console.WriteLine("Full Name: {0} {1} {2} "
                        + "\n Balance : {3}" 
                        + "\n Bank Name: {4}" 
                        + "\n IBAN : {5}" 
                        + "\n credit card 1: {6}" 
                        + "\n credit card 2: {7}" 
                        + "\n credit card 3: {8}",
                        firstName,middleName,lastName,balance,bankName,IBAN,cardOne,cardTwo,cardThree);
    }
}