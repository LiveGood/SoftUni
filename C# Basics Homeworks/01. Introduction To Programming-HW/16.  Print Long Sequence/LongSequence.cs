using System;

// Problem 16. * Print Long Sequence
// Write a program that prints the first 1000 members of the sequence: 2, -3, 4, -5, 6, -7, … 
// You might need to learn how to use loops (search in Internet). 

class Program
{
    static void Main()
    {
        Console.BufferHeight = 1001;
        for (int i = 2; i <= 1001; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine("Member {1} ---> {0}", i, i - 1);
            }
            else
            {
                Console.WriteLine("Member {1} ---> {0}", i * -1, i - 1);                      
            }
        }
    }
}
