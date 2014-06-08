using System;

/*
    Problem 1.	Sum of 3 Integers
    Write a program that reads 3 integer numbers from the console and prints their sum. Examples:
    a	    b	    c	    sum
    3	    4	    11	    19
    -2	    0	    3	    1
    5.5	    4.5	    20.1	30.1
 */
class Program
{
    static void Main()
    {
        int a,b, c;
        Console.WriteLine("Enter 3 integers:");
        Int32.TryParse(Console.ReadLine(), out a);
        Int32.TryParse(Console.ReadLine(), out b);
        Int32.TryParse(Console.ReadLine(), out c);

        int sum = a + b + c;
        Console.WriteLine("The sum of them is: {0}",sum);
    }
}
