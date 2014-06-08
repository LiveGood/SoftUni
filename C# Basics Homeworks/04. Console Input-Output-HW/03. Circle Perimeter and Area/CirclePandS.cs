using System;

/* 
    Problem 3.	Circle Perimeter and Area
    Write a program that reads the radius r of a circle and prints its perimeter and area formatted with 2 digits after the decimal point. Examples:
    r	    perimeter	area
    2	    12.57	    12.57
    3.5	    21.99	    38.48

 */
class CirclePandS
{
    static void Main()
    {
        Console.Write("Radius r = ");
        double r = double.Parse(Console.ReadLine());
        double pi = Math.PI;
        Console.WriteLine("P = {0:F2}", 2 * pi * r);
        Console.WriteLine("S = {0:F2}", pi * r * r);
    }
}
