using System;
using System.Collections.Generic;
/*
    Problem 3.	Primes in Given Range
    Write a method that calculates all prime numbers in given range and returns them as list of integers:
    static List<int> FindPrimesInRange(startNum, endNum)
    {
    …
    }   
    Write a method to print a list of integers. Write a program that enters two integer numbers 
    (each at a separate line) and prints all primes in their range, separated by a comma.
 *  Examaples: 
    Start number
    End number	Output
    0
    10	        2, 3, 5, 7
    ------
    5
    11	        5, 7, 11
    ------
    100         101, 103, 107, 109, 113, 127, 131, 137, 139, 
    200         149, 151, 157, 163, 167, 173, 179, 181, 191, 193, 197, 199
    -------
    100
    50      	(empty list)
 */
class PrimesInGivenRange
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Primes:");
            Console.Write("from = ");
            int from = int.Parse(Console.ReadLine());
            Console.Write("to = ");
            int to = int.Parse(Console.ReadLine());

            List<int> primesInrRange = FindPrimesInRange(from, to);
            ReturnList(primesInrRange);   
        }
    }

    private static void ReturnList(List<int> list)
    {
        if (list.Count == 0)
        {
            Console.WriteLine("(empty list)");
            return;
        }
        string printList = string.Join(", ", list);
        Console.WriteLine(printList);
    }

    static List<int> FindPrimesInRange(int startNum, int endNum)
    {
        string endResult = string.Empty;
        List<int> primesInRange = new List<int>();
        for (int number = startNum; number <= endNum; number++)
        {
            int squareRoot = (int)Math.Sqrt(number);
            bool prime = true;
            for (int divider = 2; divider <= squareRoot; divider++)
            {
                if (number % divider == 0)
                {
                    prime = false;
                    break;
                }
            }

            if (prime)
            {
                primesInRange.Add(number);       
            }
        }
        return primesInRange;
	}
		 
	
}
