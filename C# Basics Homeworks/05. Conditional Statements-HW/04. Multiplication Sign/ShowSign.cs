using System;

/*
    Problem 4.	Multiplication Sign
    Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it. Use a sequence of if operators. Examples:
    a	    b	    c	    result
    5	    2	    2	    +
    -2	    -2	    1	    +
    -2	    4	    3	    -
    0	    -2.5	4	    0
    -1	    -0.5	-5.1	-
 */
class ShowSign
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        double product = a * b * c;
        if (product > 0)
        {
            Console.WriteLine("+");
        }
        else if (product < 0)
        {
            Console.WriteLine("-");
        }
        else
        {
            Console.WriteLine(0);
        }

    }
}
