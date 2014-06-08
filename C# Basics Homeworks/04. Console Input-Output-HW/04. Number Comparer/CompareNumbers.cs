using System;

/*
    Problem 4.	Number Comparer
    Write a program that gets two numbers from the console and prints the greater of them. Try to implement this without if statements. Examples:
    a	    b	    greater
    5	    6	    6
    10	    5	    10
    0	    0	    0
    -5	    -2	    -2
    1.5 	1.6	    1.6
 */
class Program
{
    static void Main()
    {
        Console.Write("a = ");
        double firstNumber = double.Parse(Console.ReadLine());
        Console.Write("b = ");
        double secondNumber = double.Parse(Console.ReadLine());
        double greater = Math.Max(firstNumber, secondNumber);
        Console.WriteLine("{0} is greater", greater);
    }
}
