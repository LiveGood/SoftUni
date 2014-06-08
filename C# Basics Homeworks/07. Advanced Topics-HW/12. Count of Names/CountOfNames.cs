using System;
using System.Collections.Generic;
using System.Linq;

/*
 * Problem 12.	Count of Names
    Write a program that reads a list of names and prints for each name 
    how many times it appears in the list. The names should be listed in 
    alphabetical order. Use the input and output format from the examples below.
    Examples:
    Input	                            Output
    Peter Steve Nakov Steve Alex Nakov	Alex -> 1
                                        Nakov -> 2
                                        Peter -> 1
                                        Steve -> 2
    Nakov Nakov Nakov SoftUni Nakov	    Nakov -> 5
                                       SoftUni -> 1
 */
class CountOfNames
{
    static void Main()
    {
        while (true)
        {
            string input = Console.ReadLine();
            List<string> namesList = input.Split().ToList();
            List<string> noNamesRepeat = new List<string>();

            namesList.Sort();
            for (int i = 0; i < namesList.Count; i++)
            {
                string checkName = namesList[i];
                int counter = 0;
                if (noNamesRepeat.Contains(checkName))
                {
                    continue;
                }
                noNamesRepeat.Add(namesList[i]);

                foreach (string str in namesList)
                {
                    if (str == checkName)
                    {
                        counter++;   
                    }    
                }
                Console.WriteLine("{0} -> {1}", checkName, counter);
            }
        }
    }
}