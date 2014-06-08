using System;

/*
    Problem 3.	Divide by 7 and 5
    Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 in the same time. Examples:
    n	    Divided by 7 and 5?
    3	    false
    0	    false
    5	    false
    7	    false
    35	    true
    140	    true
 */
class DivideBy7and5
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        bool divideBy7and5 = n % 5 == 0 && n % 7 == 0;
        Console.WriteLine(divideBy7and5);
    }
 }
