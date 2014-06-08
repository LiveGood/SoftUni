using System;

/*
    Problem 19.	** Spiral Matrix
    Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) and prints a
    matrix holding the numbers from 1 to n*n in the form of square spiral like in the examples below. 
 */
class SpiralMatrix
{
    //This solutin uses multidimensional array (matrix)
    static void Main()
    {
        Console.WindowWidth = 85;
        int n = int.Parse(Console.ReadLine());
        int[,] spiralMatrix = new int[n,n];
        int rows = 0;
        int cols = 0;
        for (int i = 0, addNumber = 1; addNumber <= n * n; i++)
        {
            //filling the matrix left to right
            while (cols < spiralMatrix.GetLength(1) - i)
            {
                spiralMatrix[rows , cols] = addNumber;
                addNumber++;
                cols++;
            }
            cols--;
            rows++;
            // filling top to bottom
            while (rows < spiralMatrix.GetLength(0) - i)
            {
                spiralMatrix[rows, cols] = addNumber;
                addNumber++;
                rows++;
            }
            cols--;
            rows--;
            // filling right to left
            while (cols >= 0 + i)
            {
                spiralMatrix[rows, cols] = addNumber;
                addNumber++;
                cols--;
            }
            cols++;
            rows--;
            // filling bottom to top
            while (rows > i)
            {
                spiralMatrix[rows, cols] = addNumber;
                addNumber++;
                rows--;
            }
            cols++;
            rows++;
        }
        // printing the matrix
        for (int i = 0; i < spiralMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < spiralMatrix.GetLength(1); j++)
            {
                if (n < 10)
                {
                    Console.Write("{0,-3}", spiralMatrix[i, j]);                        
                }
                else
                {
                    Console.Write("{0,-4}", spiralMatrix[i, j]);
                }
            }
            Console.WriteLine();
        }
    }
}
