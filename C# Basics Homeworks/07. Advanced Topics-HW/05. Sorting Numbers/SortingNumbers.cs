using System;
using System.Collections.Generic;

/*
 *  Problem 5.	Sorting Numbers
    Write a program that reads a number n and a sequence of n integers, sorts them and prints them. Examples:
    Input	Output
    5       -3
    3        0
    -3       2
    2        3
    122      122
    0	
 */
class SortingNumbers
{
    static void Main()
    {
        while (true)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbersArray = new int[n];

            for (int i = 0; i < numbersArray.Length; i++)
            {
                numbersArray[i] = int.Parse(Console.ReadLine());
            }

            sortNumbers(numbersArray);

            //using internal .Net method 
            // Array.Sort(numbersArray);

        }
    }

    public static void sortNumbers(int[] numbersArray)
    {
        for (int i = 0; i < numbersArray.Length; i++)
        {
            int smallest = Int32.MaxValue;
            // this loop finds the next smallest element
            // the loop starts from i , that way we are making sure we are not using the sorted elements
            for (int k = i; k < numbersArray.Length; k++)
            {
                if (numbersArray[k] <= smallest)
                {
                    smallest = numbersArray[k];
                    numbersArray[k] = numbersArray[i];
                    numbersArray[i] = smallest;
                }
            }
            Console.WriteLine(numbersArray[i]);
        }
    }
}
