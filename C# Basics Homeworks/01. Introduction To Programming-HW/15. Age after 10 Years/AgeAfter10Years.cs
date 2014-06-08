using System;

// Problem 15.	* Age after 10 Years
// Write a program to read your birthday from the console and print how old you are now and how old you will be after 10 years.

class AgeAfter10Years
{
    static void Main()
    {
        Console.Write("Enter birth date in the format yyyy/mm/dd: ");
        string birthDateStr = Console.ReadLine();
        DateTime birthDate = DateTime.Parse(birthDateStr);
        DateTime todayDate = DateTime.Now;
        int age = DateTime.Now.Year - birthDate.Year;
        if (todayDate.Month < birthDate.Month || (todayDate.Month == birthDate.Month && todayDate.Day < birthDate.Day))
        {
            age--;
        }
        Console.WriteLine("Your are age now is: {0}", age);
        Console.WriteLine("Your age after 10 yeas: {0}", age + 10);
    }
}
