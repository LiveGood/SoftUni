using System;

/*  
    Problem 1.	Odd or Even Integers
    Write an expression that checks if given integer is odd or even. Examples:
    n	Odd?
    3	true
    2	false
   -2	false
   -1	true
    0	false
*/
class OddOrEven
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        bool oddOrEven = n % 2 == 1 ? true : false;
        Console.WriteLine(oddOrEven);
    }
}

