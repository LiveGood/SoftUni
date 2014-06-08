using System;
/*
    Problem 7.	Point in a Circle
    Write an expression that checks if given point (x,  y) is inside a circle K({0, 0}, 2). Examples:
    x	    y	    inside
    0	    1	    true
    -2	    0	    true
    -1	    2	    false
    1.5 	-1	    true
    -1.5	-1.5	false
    100	    -30	    false
    0	    0	    true
    0.2	    -0.8	true
    0.9 	-1.93	false
    1	    1.655	true

 */
class PointInCircle
{
    static void Main()
    {
        Console.Write("x = ");
        double xPoint = double.Parse(Console.ReadLine());
        Console.Write("y = ");
        double yPoint = double.Parse(Console.ReadLine());
        double xCricle = 0;
        double yCircle = 0;
        double r = 2;
        //Pythagor theorem
        double d = Math.Pow(xPoint - xCricle, 2) + Math.Pow(yPoint - yCircle, 2);

        bool pointInside = d < r * r;
        Console.WriteLine(pointInside);

    }
}

