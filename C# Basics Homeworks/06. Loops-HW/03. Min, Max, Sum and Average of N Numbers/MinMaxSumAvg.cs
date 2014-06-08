using System;
/*
 *   Problem 3.	Min, Max, Sum and Average of N Numbers
 *   Write a program that reads from the console a sequence of n integer numbers and returns
 *   the minimal, the maximal number, the sum and the average of all numbers (displayed with 2
 *   digits after the decimal point). The input starts by the number n (alone in a line) followed
 *   by n lines, each holding an integer number. The output is like in the examples below. Examples:
 */
class MinMaxSumAvg
{
    static void Main()
    {
        Console.Write("How many numbers to enter: ");
        int numbers = int.Parse(Console.ReadLine());
        int maxNumber = Int32.MinValue;
        int minNumber = Int32.MaxValue;
        int sum = 0;
        double avarage;

        for (int i = 0; i < numbers; i++)
        {
            Console.Write("n{0} = ", i + 1);
            int input = int.Parse(Console.ReadLine());
            if (input > maxNumber)
            {
                maxNumber = input;    
            }
            if (input < minNumber)
            {
                minNumber = input;    
            }
            sum += input;
        }
        avarage = (double)sum / numbers;

        Console.WriteLine("min = {0}", minNumber);
        Console.WriteLine("max = {0}", maxNumber);
        Console.WriteLine("sum = {0}", sum);
        Console.WriteLine("avg = {0:F2}", avarage);
    }
}
