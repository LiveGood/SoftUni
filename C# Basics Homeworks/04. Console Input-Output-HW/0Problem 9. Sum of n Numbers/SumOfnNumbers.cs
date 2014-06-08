using System;

/*
    Problem 9.	Sum of n Numbers
    Write a program that enters a number n and after that enters more n numbers and 
    calculates and prints their sum. Note that you may need to use a for-loop. 
 */
class SumOfnNumbers
{
    static void Main()
    {
        Console.Write("n = ");
        double n = double.Parse(Console.ReadLine());
        double sum = 0;
        for (double i = 0; i < n; i++)
        {
            double input = double.Parse(Console.ReadLine());
            sum += input;
        }
        Console.WriteLine(sum);
    }
}
