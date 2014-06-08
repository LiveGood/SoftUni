using System;
using System.Numerics;

/*
    Problem 10.	Fibonacci Numbers
    Write a program that reads a number n and prints on the console the first n 
    members of the Fibonacci sequence (at a single line, separated by spaces) :
    0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, …. Note that you may 
    need to learn how to use loops. Examples:
    n	    comments
    1	    0
    3	    0 1 1
    10	    0 1 1 2 3 5 8 13 21 34
 */
class Fibonacci
{
    static void Main()
    {
        Console.WriteLine("n = ");
        BigInteger n = BigInteger.Parse(Console.ReadLine());
        BigInteger a = 0;
        BigInteger b = 1;
        BigInteger c = a + b;
        Console.Write("{0} {1} {2}", a, b, c);
        for (int i = 0; i < n - 3; i++)
        {
            a = b;
            b = c;
            c = a + b;
            Console.Write(" {0}", c);
        }
        Console.WriteLine();
    }
}
