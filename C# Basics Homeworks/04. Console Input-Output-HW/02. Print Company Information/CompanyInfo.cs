﻿using System;
/*
    Problem 2.	Print Company Information
    A company has name, address, phone number, fax number, web site and manager. The manager has first name,
    last name, age and a phone number. Write a program that reads the information about a company 
    and its manager and prints it back on the console.
 */
class CompanyInfo
{
    static void Main()
    {
        Console.Write("Company name: ");
        string companyName = Console.ReadLine();
        Console.Write("Company adress: ");
        string companyAdress = Console.ReadLine();
        Console.Write("Phone number: ");
        string phoneNumber = Console.ReadLine();
        Console.Write("Fax Number: ");
        string faxNumber = Console.ReadLine();
        Console.Write("Website: ");
        string webSite = Console.ReadLine();
        Console.Write("Manager first name: ");
        string managerFirstName = Console.ReadLine();
        Console.Write("Manager last name: ");
        string managerLastName = Console.ReadLine();
        Console.Write("Manager age: ");
        int managerAge = int.Parse(Console.ReadLine());
        Console.Write("Manager phone: ");
        string managerNumber = Console.ReadLine();
        Console.WriteLine(companyName);
        Console.WriteLine("Adress: " + companyAdress);
        Console.WriteLine("Tel. " + phoneNumber);
        Console.WriteLine("Fax:" + faxNumber);
        Console.WriteLine("Web site: " + webSite);
        Console.WriteLine("Manager: {0} {1} (age: {2}, tel. {3}",managerFirstName, managerLastName, managerAge, managerNumber);
    }
}
