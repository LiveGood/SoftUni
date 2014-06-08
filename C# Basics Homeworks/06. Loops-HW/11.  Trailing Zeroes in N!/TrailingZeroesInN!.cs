using System;
/*
    Problem 11.	* Trailing Zeroes in N!
    Write a program that calculates with how many zeroes the factorial of a given number n has at its end.
    Your program should work well for very big numbers, e.g. n=100000. Examples:
    n	    trailing zeroes of n!	explaination
    10	    2                     	3628800
    20	    4	                    2432902008176640000
    100000	24999	                think why
 */
class TrailingZeroesInNFactorial
{
    static void Main()
    {
        // the formula for finding trailing zeros in factorial is:
        // if n > 5  zeroes += n /5 if n > n^2  zeroes += n / n^2 
        // if n > 5^3 zeroes += n / 5^3 .... until n is smaller then n^x
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        int zeroCounter = 0;
        int divide;
        for (int i = 1; ; i++)
        {
            divide = n / (int)Math.Pow(5, i);
            if (divide > 0)
            {
                zeroCounter += divide;
            }
            else
            {
                break;
            }
        }
        Console.WriteLine(zeroCounter);
    }
}
