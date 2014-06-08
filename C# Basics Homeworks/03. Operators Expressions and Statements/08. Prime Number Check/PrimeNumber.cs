using System;
/*
    Problem 8.	Prime Number Check
    Write an expression that checks if given positive integer number n (n ≤ 100) is prime (i.e. it is divisible without remainder only to itself and 1). Examples:
    n	Prime?
    1	false
    2	true
    3	true
    4	false
    9	false
    97	true
    51	false
    -3	false
    0	false
*/
class PrimeNumber
{
    static void Main(string[] args)
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        int nSquareRoot = (int)Math.Sqrt(n);
        bool prime = true;
        if (n == 1) prime = false;
        for (int i = 2; i <= nSquareRoot; i++)
        {
            if (n % i == 0)
            {
                prime = false;
                break;
            }              
        }
        Console.WriteLine("Is n prime: {0}",prime);
    }
}

