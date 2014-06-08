using System;
using System.Collections.Generic;
/*
 *  Problem 6.	Longest Area in Array
    Write a program to find the longest area of equal elements in array of strings.
    You first should read an integer n and n strings (each at a separate line), then 
    find and print the longest sequence of equal elements (first its length, then its
    elements). If multiple sequences have the same maximal length, print the leftmost of them. 
 */
class LongestAreaInArray
{
    static void Main()
    {
        while (true)
        {
            int n = int.Parse(Console.ReadLine());
            string[] stringArray = new string[n];

            for (int i = 0; i < stringArray.Length; i++)
            {
                stringArray[i] = Console.ReadLine();
            }

            LongestArea(stringArray);   
        }
    }

    private static void LongestArea(string[] stringArray)
    {
        List<string> dontCheckAgain = new List<string>();

        string checkForElement = string.Empty;
        string mostRepeatedString = string.Empty;
        string previousString = string.Empty;
        int previousCounter = 0;

        for (int i = 0; i < stringArray.Length; i++)
        {
            checkForElement = stringArray[i];
            int currentCounter = 0;

            // condition for not repeating the allready counted strings
            if (dontCheckAgain.Contains(checkForElement))
            {
                continue;
            }
            dontCheckAgain.Add(checkForElement);

            for (int k = 0; k < stringArray.Length; k++)
            {
                if (stringArray[k] == checkForElement)
                {
                    currentCounter++;
                }

                if (currentCounter > previousCounter)
                {
                    previousCounter = currentCounter;
                    mostRepeatedString = checkForElement;
                }
                else if (currentCounter == previousCounter)
                {
                    if (previousString.Length >= mostRepeatedString.Length)
                    {
                        mostRepeatedString = previousString;
                    }
                }
            }

            previousString = mostRepeatedString;
        }

        Console.WriteLine(previousCounter);
        for (int i = 0; i < previousCounter; i++)
        {
            Console.WriteLine(mostRepeatedString);
        }
    }

}