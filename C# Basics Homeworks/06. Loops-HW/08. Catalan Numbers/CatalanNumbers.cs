using System;
using System.Numerics;
/*
 * Problem 8.	Catalan Numbers
    In combinatorics, the Catalan numbers are calculated by the following formula:
    // can't be displayed here
    Write a program to calculate the nth Catalan number by given n (1 < n < 100). Examples:
    n	Catalan(n)
    0	1
    5	42
    10	16796
    15	9694845
 */
class CatalanNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        // Catalan number formula is (2 * n)! / (n + 1)! * n!
        // this expression can be transformed like the previous problem:
        // multiplying the numbers from (n + 1) up to (2 * n) divideded by (n + 1)!
        BigInteger fromNTo2TimesN = 1;
        BigInteger nPlus1Fact = 1;

        for (int i = n  + 1; i <= n * 2; i++)
        {
            fromNTo2TimesN *= i;       
        }

        for (int i = 1; i <= n + 1; i++)
        {
            nPlus1Fact *= i;
        }
        Console.WriteLine(fromNTo2TimesN / nPlus1Fact);
    }
}
