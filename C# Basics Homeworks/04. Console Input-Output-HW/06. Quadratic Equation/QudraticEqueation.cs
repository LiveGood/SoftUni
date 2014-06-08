using System;

/*
    Problem 6.	Quadratic Equation
    Write a program that reads the coefficients a, b and c of a quadratic equation
    ax2 + bx + c = 0 and solves it (prints its real roots). Examples:
    a	    b	    c	    roots
    2	    5	    -3  	x1=-3; x2=0.5
    -1	    3	    0	    x1=3; x2=0
    -0.5	4	    -8  	x1=x2=4
    5	    2   	8	    no real roots
 */
class QudraticEqueation
{
    static void Main()
    {
        Console.Write("a = ");
        float a = float.Parse(Console.ReadLine());
        Console.Write("b = ");
        float b = float.Parse(Console.ReadLine());
        Console.Write("c = ");
        float c = float.Parse(Console.ReadLine());
        float x1 = 0;
        float x2 = 0;
        float D = (float)Math.Sqrt((b * b) - (4 * a * c));

        if (D > 0)
        {
            x1 = (-b + D) / (2 * a);
            x2 = (-b - D) / (2 * a);
            Console.WriteLine("Two real solutions:");
            Console.WriteLine("x1 = {0} \nx2 = {1}", x1, x2);
        }
        else if (D == 0)
        {
            x1 = -b / (2 * a);
            Console.WriteLine("One real solution:");
            Console.WriteLine("x1 = x2 = {0}", x1);
        }
        else
        {
            Console.WriteLine("No real roots");
        }

    }
}
