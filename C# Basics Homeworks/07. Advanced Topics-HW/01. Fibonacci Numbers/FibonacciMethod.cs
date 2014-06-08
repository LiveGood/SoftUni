
// ALLERT!!!!
// All projects in the solution are put in endless while loops for eaiser checking with diffrent inputs.
// Enjoy :)

using System;
/*
    Problem 1.	Fibonacci Numbers
    Define a method Fib(n) that calculates the nth Fibonacci number. 
    Examples:
    n	Fib(n)
    0	1
    1	1
    2	2
    3	3
    4	5
    5	8
    6	13
    11	144
    25	121393
 */
class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Write("n = ");
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine("Fib(n) = {0}", Fib(input)); 
        }
    }

    private static long Fib(int n)
    {
        long a = 0;
        long b = 1;
        long c = a + b;
        if (n < 2)
        {
            return b;   
        }
        for (int i = 0; i < n; i++)
        {
            c = a + b;
            a = b;
            b = c;
        }
        
        return c;
    }
}
