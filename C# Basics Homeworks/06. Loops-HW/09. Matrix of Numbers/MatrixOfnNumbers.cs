﻿using System;
/*
 * Problem 9.	Matrix of Numbers
   Write a program that reads from the console a positive integer number n 
   (1 ≤ n ≤ 20) and prints a matrix like in the examples below. Use two nested loops. 
 */

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            for (int k = i; k < i + n; k++)
            {
                Console.Write("{0,-3}", k);
            }
            Console.WriteLine();
        }
    }
}
