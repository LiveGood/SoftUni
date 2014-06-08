using System;
using System.Collections.Generic;
/*
 *  Problem 12.	* Randomize the Numbers 1…N
    Write a program that enters in integer n and prints the numbers 1, 2, …, n in random order. Examples:
    n	randomized numbers 1…n
    3	2 1 3
    10	3 4 8 2 6 7 9 1 10 5 
    Note that the above output is just an example. Due to randomness, your program 
    most probably will produce different results. You might need to use arrays.      
 */
class RandomIntFrom1ToN
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        Random randGen = new Random();

        //this method uses list 
        List<int> intList = new List<int>();
        //filling the list with 1 to n
        for (int i = 1; i <= n; i++)
        {
            intList.Add(i);        
        }
        for (int i = 0; i < n; i++)
        {
            // randomn number between 0 and the lenght of the list
            int generate = randGen.Next(intList.Count);
            Console.Write(intList[generate]+ " ");
            //removing current element so it cant be repeated
            intList.RemoveAt(generate);
        }

        //this method uses Fisher–Yates shuffle - check in wikiPedia  http://en.wikipedia.org/wiki/Fisher%E2%80%93Yates_shuffle

        //int[] nArray = new int[n];

        //for (int i = 0; i < nArray.Length; i++)
        //{
        //    nArray[i] = i + 1;
        //}
        //Random arrayGenerator = new Random();

        //for (int i = nArray.Length; i > 0; i--)
        //{
        //    int generate = arrayGenerator.Next(i);
        //    int value = nArray[generate];
        //    nArray[generate] = nArray[i - 1];
        //    nArray[i - 1] = value;
        //}

        //foreach (int numbers in nArray)
        //{
        //    Console.WriteLine(nArray[numbers - 1]);
        //}

    }
}
