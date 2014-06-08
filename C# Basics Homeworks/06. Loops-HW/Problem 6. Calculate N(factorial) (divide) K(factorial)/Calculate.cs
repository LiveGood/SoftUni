using System;
using System.Numerics;

/*
 * Problem 6.	Calculate N! / K!
    Write a program that calculates n! / k! for given n and k (1 < k < n < 100). Use only one loop. Examples:
    n	k	n! / k!
    5	2	60
    6	5	6
    8	3	6720
 */
class Calculate
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        BigInteger factorial = 1;

        for (int i = k + 1; i <= n; i++)
        {
            factorial *= i;          
        }
        Console.WriteLine(factorial);
    }
}
