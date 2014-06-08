using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 *  Problem 17.	* Perimeter and Area of Polygon
    Write a program that calculates the perimeter and the area of given polygon (not necessarily convex)
    consisting of n floating-point coordinates in the 2D plane. Print the result rounded to two decimal
    digits after the decimal point. Use the input and output format from the examples. To hold the points,
    define a class Point(x, y). To hold the polygon use a Polygon class which holds a list of points. Find
    in Internet how to calculate the polygon perimeter and how to calculate the area of a polygon. Examples:
    Input	Output
    3       perimeter = 3.41
    0 0     area = 0.50
    0 1
    1 1	
    ------    
    7       perimeter = 22.64
    -2 1    area = 9.5
    1 3
    5 1
    1 2
    1 1
    3 -2
    -2 1	
 */
class Point
{
    public double x;
    public double y;
}
class PolygonPandS
{
    static void Main()
    {
        while (true)
        {
            int pointsNumber = int.Parse(Console.ReadLine());
            List<Point> pointsList = new List<Point>();

            for (int i = 0; i < pointsNumber; i++)
            {
                string pointsInput = Console.ReadLine();
                string[] XandY = pointsInput.Split();
                Point point = new Point();
                point.x = double.Parse(XandY[0]);
                point.y = double.Parse(XandY[1]);
                pointsList.Add(point);
            }

            PerimeterOfPolygon(pointsList);
            AreaOfPolygon(pointsList);   
        }
    }

    private static void AreaOfPolygon(List<Point> pointsList)
    {
        double area = 0;
        for (int i = 0; i < pointsList.Count; i++)
        {
            if (i < pointsList.Count - 1)
            {
                double a = pointsList[i].x * pointsList[i + 1].y;
                double b = pointsList[i].y * pointsList[i + 1].x;
                double c = a - b;
                area += c;
            }
            else // last point * first point
            {
                double a = pointsList[i].x * pointsList[0].y;
                double b = pointsList[i].y * pointsList[0].x;
                double c = a - b;
                area += c;
            }
        }
        area = area / 2 > 0 ? area / 2 : -(area / 2);
        Console.WriteLine("area = {0:F2}", area);
    }

    private static void PerimeterOfPolygon(List<Point> pointsList)
    {
        double perimeter = 0;
        for (int i = 0; i < pointsList.Count; i++)
        {
            //  The Pythagor thorem is used for finding the lenght between 2 points:
            //  given A(x, y) and B(x, y)  
            //  lenght^2 = (xA - xB)^2 + (yA - yB)^2;
            if (i < pointsList.Count - 1)
            {
                double a = pointsList[i].x - pointsList[i + 1].x;
                a *= a; // a^2
                double b = pointsList[i].y - pointsList[i + 1].y;
                b *= b;
                double lenghtBetweenPoints = Math.Sqrt(a + b);
                perimeter += lenghtBetweenPoints;
            }
            else // last point * first point
            {
                double a = pointsList[i].x - pointsList[0].x;
                a *= a; // a^2
                double b = pointsList[i].y - pointsList[0].y;
                b *= b;
                double lenghtBetweenPoints = Math.Sqrt(a + b);
                perimeter += lenghtBetweenPoints;
            }
        }
        string outputPerimeter = string.Format("perimeter = {0:F2}", perimeter);
        Console.WriteLine(outputPerimeter);
    }
}
