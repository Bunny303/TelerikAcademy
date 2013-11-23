using System;

class ReadWriteInformation
{
    static void Main()
    {
        Console.Write("Enter name of the company: ");
        string CompanyName = Console.ReadLine();

        Console.Write("Enter address of the company: ");
        string CompanyAddress = Console.ReadLine();

        Console.Write("Enter phone number of the company: ");
        string CompanyPhoneNumber = Console.ReadLine();
        int PhoneNumber = int.Parse(CompanyPhoneNumber);

        Console.Write("Enter fax number of the company: ");
        string CompanyFaxNumber = Console.ReadLine();
        int FaxNumber = int.Parse(CompanyFaxNumber);

        Console.Write("Enter web site of the company: ");
        string CompanyWebSite = Console.ReadLine();

        Console.Write("Enter first name of the company's manager: ");
        string ManagerFirstName = Console.ReadLine();

        Console.Write("Enter last name of the company's manager: ");
        string ManagerLastName = Console.ReadLine();

        Console.Write("Enter age of the company's manager: ");
        string ManagerAge = Console.ReadLine();

        Console.Write("Enter phone number of the company's manager: ");
        string ManagerPhoneNumber = Console.ReadLine();
        int MobileNumber = int.Parse(ManagerPhoneNumber);

        Console.WriteLine("Information about: {0}", CompanyName);
        Console.WriteLine("Address: {0}", CompanyAddress);
        Console.WriteLine("Phone number: {0:## ### ###}", PhoneNumber);
        Console.WriteLine("Fax number: {0:## ### ###}", FaxNumber);
        Console.WriteLine("Web site: {0}", CompanyWebSite);

        Console.WriteLine("The manager of the {0} is {1} {2}. He is {3} years old.: ", CompanyName, ManagerFirstName, ManagerLastName, ManagerAge);
        Console.WriteLine("For contacts: {0:#### ### ###}", MobileNumber);

    }
}

