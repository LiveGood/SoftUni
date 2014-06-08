using System;
using System.Numerics;

/*
 *  Problem 7.	Calculate N! / (K! * (N-K)!)
 *  In combinatorics, the number of ways to choose k different members out of a group of n different elements
 *  (also known as the number of combinations) is calculated by the following formula: 
 *  For example, there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards.
 *  Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k 
 *  (1 < k < n < 100). Try to use only two loops. Examples:
 *  n	k	n! / (k! * (n-k)!)
    3	2	3
    4	2	6
    10 	6	210
    52	5	2598960
 */
class Program
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("k = ");
        int k = int.Parse(Console.ReadLine());
        int nMinusK = n - k;
        BigInteger fromNminusKToNFact = 1;
        BigInteger kFact = 1;
        // n! / (k! * (n - k)!) =  miltiplying from (n - k + 1 to n)  / k!
        for (int i = nMinusK + 1; i <= n; i++)
        {
            fromNminusKToNFact *= i;       
        }
        for (int i = 1; i <= k; i++)
        {
            kFact *= i;    
        }
        Console.WriteLine(fromNminusKToNFact / kFact);
    }
}
