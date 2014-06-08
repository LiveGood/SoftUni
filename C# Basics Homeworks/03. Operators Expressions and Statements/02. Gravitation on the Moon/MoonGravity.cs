﻿using System;

/*
    Problem 2.	Gravitation on the Moon
    The gravitational field of the Moon is approximately 17% of that on the Earth. Write a program that calculates the weight of a man on the moon by a given weight on the Earth. Examples:
    weight	weight on the Moon
    86	    14.62
    74.6	12.682
    53.7	9.129
 */

class MoonGravity
{
    static void Main()
    {
        Console.Write("Earth weight: ");
        double earthWeighht = double.Parse(Console.ReadLine());
        double moonWeight = earthWeighht * 0.17;
        Console.WriteLine("Moon weight: {0}", moonWeight);
    }
}
