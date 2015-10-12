/*Problem 2. Print Company Information

A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number.
Write a program that reads the information about a company and its manager and prints it back on the console.
 */

using System;
class PrintCompanyInformation
{
    static void Main()
    {
        string companyName;
        Console.Write("Please enter your Company name : ");
        companyName = Console.ReadLine();
        string companyAddress;
        Console.Write("Please enter the company addresss: ");
        companyAddress = Console.ReadLine();
        string phoneNumber;
        Console.Write("Please enter a phone number: ");
        phoneNumber = Console.ReadLine();
        int faxNumber;
        Console.Write("Please enter fax number : ");
        faxNumber = int.Parse(Console.ReadLine());
        string webSite;
        Console.Write("Please enter a web site:");
        webSite = Console.ReadLine();
        string managerFirstName;
        Console.Write("Please enter Manadger first name : ");
        managerFirstName = Console.ReadLine();
        string managerLastName;
        Console.Write("Please enter Manager last name : ");
        managerLastName = Console.ReadLine();
        int managerAge;
        Console.Write("Please enter manager age : ");
        managerAge = int.Parse(Console.ReadLine());
        string managerPhone;
        Console.Write("Please enter manager phone : ");
        managerPhone = Console.ReadLine();
        Console.WriteLine(companyName);
        Console.WriteLine("Address : {0}", companyAddress);
        Console.WriteLine("Tel . {0}", phoneNumber);
        Console.WriteLine("Fax : {0}", faxNumber);
        Console.WriteLine("Web Site : {0}", webSite);
        Console.WriteLine("Manager : {0} {1} (age:{2} , tel. {3})", managerFirstName, managerLastName, managerAge, managerPhone);


    }
}

