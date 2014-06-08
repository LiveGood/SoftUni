using System;
using System.Collections.Generic;

/*
 *  Problem 7.	Matrix of Palindromes
    Write a program to generate the following matrix of palindromes of 3 letters with r rows and c columns:
    Input	Output
    3 6	    aaa aba aca	ada aea afa
            bbb bcb bdb	beb bfb bgb
            ccc cdc cec	cfc cgc chc
    2 3	    aaa aba aca
            bbb bcb bdb
    1 1 	aaa
    1 3	    aaa aba aca
 */
class Program
{
    static void Main()
    {
        while (true)
        {
            string input = Console.ReadLine();
            string[] rowsAndCols = input.Split();
            int rows = int.Parse(rowsAndCols[0]);
            int cols = int.Parse(rowsAndCols[1]);
            string[,] palidromes = new string[rows, cols];
            string alphabet = "abcdefghigklmnopqrstuvwxyz";

            for (int row = 0; row < palidromes.GetLength(0); row++)
            {
                for (int col = 0; col < palidromes.GetLength(1); col++)
                {
                    string currentPalidrome = string.Format("{0}{1}{0}", alphabet[row], alphabet[row + col]);
                    palidromes[row, col] = currentPalidrome;
                }
            }

            for (int row = 0; row < palidromes.GetLength(0); row++)
            {
                for (int col = 0; col < palidromes.GetLength(1); col++)
                {
                    Console.Write(palidromes[row, col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
