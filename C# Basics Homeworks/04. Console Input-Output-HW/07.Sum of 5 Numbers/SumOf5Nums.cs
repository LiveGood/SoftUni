using System;
/*
    Problem 7.	Sum of 5 Numbers
    Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum. Examples:
 */
class SumOf5Nums
{
    static void Main()
    {
        Console.WriteLine("Enter five numbers seperated by single space:");
        string[] numberInputs = Console.ReadLine().Split();
        double a = double.Parse(numberInputs[0]);
        double b = double.Parse(numberInputs[1]);
        double c = double.Parse(numberInputs[2]);
        double d = double.Parse(numberInputs[3]);
        double e = double.Parse(numberInputs[4]);
        Console.WriteLine(a + b + c + d + e);

    }
}
