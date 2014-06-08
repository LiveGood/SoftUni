﻿using System;
using System.Globalization;
using System.Threading;
/*
    Problem 4.	Rectangles
    Write an expression that calculates rectangle’s perimeter and area by given width and height. Examples:
    width	height	perimeter	area
    3	    4   	14	        12
    2.5	    3	    11	        7.5
    5	    5	    20	        25
 */

class Rectangles
{
    static void Main()
    {
        // making the decimal seperator '.' rather then ','
        Thread.CurrentThread.CurrentCulture = new CultureInfo("en-Us");

        Console.Write("widht = ");
        double width = double.Parse(Console.ReadLine());
        Console.Write("height = ");
        double height = double.Parse(Console.ReadLine());

        double perimeter = 2 * width + 2 * height;
        double area = width * height;
        Console.WriteLine("perimer = {0}", perimeter);
        Console.WriteLine("area = {0}", area);
    }
}