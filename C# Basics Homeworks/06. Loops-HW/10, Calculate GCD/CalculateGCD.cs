using System;
/*
 *  Problem 17.	* Calculate GCD
    Write a program that calculates the greatest common divisor (GCD) of given 
    two integers a and b. Use the Euclidean algorithm (find it in Internet). Examples:
    a	b	GCD(a, b)
    3	2	1
    60	40	20
    5	-15	5

 */

class CalculateGCD
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("m = ");
        int m = int.Parse(Console.ReadLine());

        int smaller = Math.Min(m, n);
        int bigger = Math.Max(m, n);
        int c;
        int result;

        while (true)
        {
            c = bigger % smaller;
            if (c == 0)
            {
                result = smaller;
                break;
            }
            bigger = smaller % c;
            if (bigger == 0)
            {
                result = c;
                break;
            }
            smaller = c % bigger;
            if (smaller == 0)
            {
                result = bigger;
                break;
            }
        }
        Console.WriteLine("GCD = {0}", result);
    }
}