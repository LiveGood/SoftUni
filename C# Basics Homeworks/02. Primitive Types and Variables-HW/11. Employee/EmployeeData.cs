using System;

/* 
    Problem 11.	Employee Data
    A marketing company wants to keep record of its employees. Each record would have the following characteristics:
    •	First name
    •	Last name
    •	Age (0...100)
    •	Gender (m or f)
    •	Personal ID number (e.g. 8306112507)
    •	Unique employee number (27560000…27569999)
    Declare the variables needed to keep the information for a single employee using appropriate
    primitive data types. Use descriptive names. Print the data at the console.
 */
class EmployeeData
{
    static void Main()
    {
        Console.Write("First name : ");
        string firsName = Console.ReadLine();
        Console.Write("Last name : ");
        string  lastName = Console.ReadLine();
        Console.Write("Age :");
        byte age = byte.Parse(Console.ReadLine());
        Console.Write("Gemder : ");
        char gender = char.Parse(Console.ReadLine());
        Console.Write("Personal ID number : ");
        long idNum = long.Parse(Console.ReadLine());
        Console.Write("Unique employee number : ");
        int employeeNum = int.Parse(Console.ReadLine());

        Console.WriteLine(firsName);
        Console.WriteLine(lastName);
        Console.WriteLine(age);
        Console.WriteLine(gender);
        Console.WriteLine(idNum);
        Console.WriteLine(employeeNum);
    }
}
