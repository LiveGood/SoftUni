using System;

// Problem 9.	Print a Sequence
// Write a program that prints the first 10 members of the sequence: 2, -3, 4, -5, 6, -7, ...

class PrintSequence
{
    static void Main(string[] args)
    {
        for (int i = 2; i < 12; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine("Member {0} ---> {1}", i - 1, i);
            }
            else
            {
                Console.WriteLine("Member {0} ---> {1}", i - 1, -i);
            }
        }
    }
}
