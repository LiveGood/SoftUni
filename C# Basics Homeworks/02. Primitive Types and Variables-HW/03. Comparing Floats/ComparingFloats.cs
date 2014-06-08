using System;

//Problem 3.	Comparing Floats
//Write a program that safely compares floating-point numbers with precision 
// eps = 0.000001. Note that we cannot directly compare two floating-point numbers
//a and b by a==b because of the nature of the floating-point arithmetic. Therefore, we assume 
//two numbers are equal if they are more closely to each other than a fixed constant eps. Examples:

class ComparingFloats
{
    static void Main()
    {

        Console.WriteLine("Enter two floating point numbers:");
        // use ',' for seperator
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double eps =  0.000001;
        double bigger = (double)Math.Max(a, b);
        double smaller = (double)Math.Min(a, b);
        bool equal = (double)(bigger - smaller) >= eps ? false : true;
        Console.WriteLine(equal); 
    }
}

