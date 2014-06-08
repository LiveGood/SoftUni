using System;
/*
    Problem 2.	Prime Checker
    Write a Boolean method IsPrime(n) that check whether a given integer number n is prime. Examples:
    n	IsPrime(n)
    0	false
    1	false
    2	true
    3	true
    4	false
    5	true
    323	false
    337	true
    6737626471	true
    117342557809	false
 */

class PrimeChecker
{
    static void Main()
    {
        while (true)
        {
            while (true)
            {
                Console.Write("n = ");
                long input = long.Parse(Console.ReadLine());
                string trueOrFalse = isPrime(input) ? "true" : "false";  // 
                Console.WriteLine(trueOrFalse);
            }    
        }
    }

    private static bool isPrime(long input)
    {
        long squareRoot = (long)Math.Sqrt(input);
        bool prime = true;
        for (long i = 2; i <= squareRoot; i++)
        {
            if (input % i == 0)
            {
                prime = false;
                break;
            }           
        }
        return prime;
    }
}