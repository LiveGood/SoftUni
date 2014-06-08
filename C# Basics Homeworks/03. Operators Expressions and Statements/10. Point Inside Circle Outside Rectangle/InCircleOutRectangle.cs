using System;
//Problem 10.	Point Inside a Circle & Outside of a Rectangle
//Write an expression that checks for given point (x, y) if it is within 
//the circle K({1, 1}, 1.5) and out of the rectangle R(top=1, left=-1, width=6, height=2). 
 //     x	    y	    inside K & outside of R
//      1	    2	    yes
//      2.5	    2	    no
//      0	    1	    no
//      2.5	    1	    no
//      2	    0	    no
//      4   	0	    no
//      2.5 	1.5	    no
//      1	    2.5	    yes
//      -100    -100	no


class InCircleOutRectangle
{
    static void Main()
    {
        Console.Write("x = ");
        double xPoint = double.Parse(Console.ReadLine());
        Console.Write("y = ");
        double yPoint = double.Parse(Console.ReadLine());
        double xCricle = 1;
        double yCircle = 1;
        double r = 1.5;
        //Pythagor theorem
        double d = Math.Pow(xPoint - xCricle, 2) + Math.Pow(yPoint - yCircle, 2);

        bool pointInside = d <= r * r;
        bool insideRectangle = (xPoint >= -1 && xPoint <= 5) && (yPoint >= -1 && yPoint <= 1);

        if (pointInside && !insideRectangle)
        {
            Console.WriteLine("yes");    
        }
        else
        {
            Console.WriteLine("no");
        }
    }
}