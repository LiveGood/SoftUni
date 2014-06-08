using System;
using System.Collections.Generic;
using System.Linq;

/*
 *  Problem 14.	Longest Word in a Text
    Write a program to find the longest word in a text.
 *  Examples:
    Input	                                    Output
    Welcome to the Software University.	        University
    ------
    The C# Basics course is awesome start       programming
    in programming with C# and Visual Studio.	
 */
class LongestWord
{
    static void Main()
    {
        while (true)
        {
            string text = Console.ReadLine();
            char[] seperators = { ' ', '.', ',' };
            List<string> wordsList = text.Split(seperators, StringSplitOptions.RemoveEmptyEntries).ToList();
            string longestWord = string.Empty;

            for (int i = 0; i < wordsList.Count; i++)
            {
                if (wordsList[i].Length >= longestWord.Length)
                {
                    longestWord = wordsList[i];
                }
            }
            Console.WriteLine(longestWord);
        }
    }
}

