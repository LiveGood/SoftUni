using System;

//Problem 5.	Boolean Variable
//Declare a Boolean variable called isFemale and assign an appropriate value corresponding to your gender. Print it on the console.

class BoolValue
{
    static void Main(string[] args)
    {
        Console.Write("Enter your gender : ");
        string gender = Console.ReadLine().ToLower();
        bool isFemale = gender == "female";
        Console.WriteLine(isFemale);
    }
}
