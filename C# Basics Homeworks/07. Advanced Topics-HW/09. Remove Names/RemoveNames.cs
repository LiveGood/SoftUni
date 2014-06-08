using System;
using System.Collections.Generic;
using System.Linq;

/*
 * Problem 9.	Remove Names
    Write a program that takes as input two lists of names and removes from the first
    list all names given in the second list. The input and output lists are given as 
    words, separated by a space, each list at a separate line. Examples:
    Input	                                        Output
    Peter Alex Maria Todor Steve Diana Steve        Peter Alex Maria Diana
    Todor Steve Nakov	
    Hristo Hristo Nakov Nakov Petya                 Hristo Hristo Petya
    Nakov Vanessa Maria	
 */
class RemoveNames
{
    static void Main()
    {
        while (true)
        {
            string firstInput = Console.ReadLine();
            string secondInput = Console.ReadLine();
            List<string> firstList = firstInput.Split().ToList();
            List<string> secondList = secondInput.Split().ToList();

            RemoveRepeatingNames(firstList, secondList);   
        }
    }

    private static void RemoveRepeatingNames(List<string> firstList, List<string> secondList)
    {
        for (int i = 0; i < secondList.Count; i++)
        {
            string removeName = secondList[i];
            for (int k = 0; k < firstList.Count; k++)
            {
                string checkName = firstList[k];
                if (removeName == checkName)
                {
                    firstList.RemoveAt(k);
                    k--;
                }
            }
        }
        Console.WriteLine(string.Join(" ", firstList));
    }
}
