using System;
using System.Collections.Generic;
using System.Linq;

/*
 *  Problem 10.	Join Lists
    Write a program that takes as input two lists of integers and joins them.
    The result should hold all numbers from the first list, and all numbers from 
    the second list, without repeating numbers, and arranged in increasing order.
    The input and output lists are given as integers, separated by a space, each
    list at a separate line. Examples:
    Input	            Output
    20 40 10 10 30 80   10 20 25 30 40 80
    25 20 40 30 10
    ----
    5 4 3 2 1           1 2 3 4 5 6
    6 3 2
    ------
    1                   1
    1	
 */
class Program
{
    static void Main()
    {
        while (true)
        {
            string firstInput = Console.ReadLine();
            string secondInput = Console.ReadLine();
            string[] firstArray = firstInput.Split();
            string[] scondtArray = secondInput.Split();
            List<int> firstList = new List<int>();
            List<int> secondList = new List<int>();

            for (int i = 0; i < firstArray.Length; i++)
            {
                firstList.Add(int.Parse(firstArray[i]));
            }
            for (int i = 0; i < scondtArray.Length; i++)
            {
                secondList.Add(int.Parse(scondtArray[i]));
            }

            List<int> biggerList = new List<int>();
            List<int> smallerList = new List<int>();
            if (firstList.Count > secondList.Count)
            {
                smallerList = secondList;
                biggerList = firstList;
            }
            else
            {
                biggerList = secondList;
                smallerList = firstList;
            }

            //remove repeating elements
            for (int i = 0; i < biggerList.Count; i++)
            {
                int removeRepeatedElements = biggerList[i];
                for (int k = 0; k < biggerList.Count; k++)
                {
                    if (k != i && removeRepeatedElements == biggerList[k])
                    {
                        biggerList.RemoveAt(k);
                        k--;
                        i--;
                    }
                }
            }

            //adding elements
            for (int i = 0; i < smallerList.Count; i++)
            {
                if (!biggerList.Contains(smallerList[i]))
                {
                    biggerList.Add(smallerList[i]);
                }
            }
            biggerList.Sort();
            Console.WriteLine(string.Join(" ", biggerList));   
        }
    }
}
