using System;
/*
    Problem 1.	Numbers from 1 to N
    Write a program that enters from the console a positive integer n and prints all
    the numbers from 1 to n, on a single line, separated by a space. Examples:
    n	output
    3	1 2 3
    5	1 2 3 4 5
 */
class From1toN
{
    static void Main()
    {

        uint n;
        // checks if the input is actualy postiive integer 
        while (true)
        {
            Console.Write("Entere positive integer: ");
            bool tryParse = uint.TryParse(Console.ReadLine(), out n);
            if (tryParse)
            {
                break;
            }
        }

        for (int i = 1; i <= n; i++)
        {
            Console.Write(i + " ");
        }
    }
}
